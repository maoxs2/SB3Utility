﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using SlimDX;
using SlimDX.Direct3D9;

namespace SB3Utility
{
	[Plugin]
	[PluginOpensFile(".xa")]
	public partial class FormXA : DockContent
	{
		private enum MorphExportFormat
		{
			[Description("Metasequoia")]
			Mqo,
			[Description("FBX 2012.2")]
			Fbx,
			[Description("FBX 2006")]
			Fbx_2006
		}

		public xaEditor Editor { get; protected set; }
		public string EditorVar { get; protected set; }
		public string ParserVar { get; protected set; }
		public string FormVar { get; protected set; }

		private bool propertiesChanged = false;

		private TextBox[][] xaMaterialMatrixText = new TextBox[6][];
		private int loadedSection1Material = -1;
		private int loadedSection1MaterialConfig = -1;
		private DataGridViewRow loadedAnimationClip = null;

		private int animationId;
		private KeyframedAnimationSet animationSet = null;
		
		private Timer renderTimer = new Timer();
		private DateTime startTime;
		private double trackPos = 0;
		private bool play = false;
		private bool trackEnabled = false;
		private bool userTrackBar = true;

		public float AnimationSpeed { get; set; }
		public bool FollowSequence { get; set; }

		public FormXA(string path, string variable)
		{
			InitializeComponent();

			this.ShowHint = DockState.Document;
			this.Text = Path.GetFileName(path);
			this.ToolTipText = path;

			ParserVar = Gui.Scripting.GetNextVariable("xaParser");
			EditorVar = Gui.Scripting.GetNextVariable("xaEditor");
			FormVar = variable;

			Init();
			ReopenXA();

			List<DockContent> formXAList;
			if (Gui.Docking.DockContents.TryGetValue(typeof(FormXA), out formXAList))
			{
				var listCopy = new List<FormXA>(formXAList.Count);
				for (int i = 0; i < formXAList.Count; i++)
				{
					listCopy.Add((FormXA)formXAList[i]);
				}

				foreach (var form in listCopy)
				{
					if (form != this)
					{
						if (form.ToolTipText == this.ToolTipText)
						{
							form.Close();
						}
					}
				}
			}
		}

		void ReopenXA()
		{
			string path = this.ToolTipText;
			string parserCommand = ParserVar + " = OpenXA(path=\"" + path + "\")";
			xaParser parser = (xaParser)Gui.Scripting.RunScript(parserCommand);

			string editorCommand = EditorVar + " = xaEditor(parser=" + ParserVar + ")";
			Editor = (xaEditor)Gui.Scripting.RunScript(editorCommand);

			LoadXA();
		}

		public FormXA(ppParser ppParser, string xaParserVar)
		{
			InitializeComponent();
			this.Controls.Remove(this.menuStrip1);

			xaParser parser = (xaParser)Gui.Scripting.Variables[xaParserVar];

			this.ShowHint = DockState.Document;
			this.Text = parser.Name;
			this.ToolTipText = ppParser.FilePath + @"\" + parser.Name;

			ParserVar = xaParserVar;

			EditorVar = Gui.Scripting.GetNextVariable("xaEditor");
			Editor = (xaEditor)Gui.Scripting.RunScript(EditorVar + " = xaEditor(parser=" + ParserVar + ")");

			Init();
			LoadXA();
		}

		void CustomDispose()
		{
			try
			{
				if (propertiesChanged)
				{
					Gui.Config.Save();
					propertiesChanged = false;
				}
				UnloadXA();

				if (FormVar != null)
				{
					Gui.Scripting.Variables.Remove(ParserVar);
					Gui.Scripting.Variables.Remove(FormVar);
				}
				Gui.Scripting.Variables.Remove(EditorVar);
				Editor.Dispose();
				Editor = null;

				Gui.Docking.DockContentAdded -= DockContentAdded;
				Gui.Docking.DockContentRemoved -= DockContentRemoved;
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void Init()
		{
			for (int i = 0; i < 4; i++)
			{
				xaMaterialMatrixText[i] = new TextBox[4];
			}
			xaMaterialMatrixText[4] = new TextBox[1];
			xaMaterialMatrixText[5] = new TextBox[1];
			xaMaterialMatrixText[0][0] = xaMatDiffuseR;
			xaMaterialMatrixText[0][1] = xaMatDiffuseG;
			xaMaterialMatrixText[0][2] = xaMatDiffuseB;
			xaMaterialMatrixText[0][3] = xaMatDiffuseA;
			xaMaterialMatrixText[1][0] = xaMatAmbientR;
			xaMaterialMatrixText[1][1] = xaMatAmbientG;
			xaMaterialMatrixText[1][2] = xaMatAmbientB;
			xaMaterialMatrixText[1][3] = xaMatAmbientA;
			xaMaterialMatrixText[2][0] = xaMatSpecularR;
			xaMaterialMatrixText[2][1] = xaMatSpecularG;
			xaMaterialMatrixText[2][2] = xaMatSpecularB;
			xaMaterialMatrixText[2][3] = xaMatSpecularA;
			xaMaterialMatrixText[3][0] = xaMatEmissiveR;
			xaMaterialMatrixText[3][1] = xaMatEmissiveG;
			xaMaterialMatrixText[3][2] = xaMatEmissiveB;
			xaMaterialMatrixText[3][3] = xaMatEmissiveA;
			xaMaterialMatrixText[4][0] = xaMatSpecularPower;
			xaMaterialMatrixText[5][0] = xaMatUnknown;

			comboBoxMorphMesh.DisplayMember = "Item1";
			comboBoxMorphMesh.ValueMember = "Item2";
			List<DockContent> formXXList;
			if (Gui.Docking.DockContents.TryGetValue(typeof(FormXX), out formXXList))
			{
				foreach (FormXX form in formXXList)
				{
					DockContentAdded(null, new DockContentEventArgs(form));
				}
			}
			Gui.Docking.DockContentAdded += DockContentAdded;
			Gui.Docking.DockContentRemoved += DockContentRemoved;

			MorphExportFormat[] values = Enum.GetValues(typeof(MorphExportFormat)) as MorphExportFormat[];
			string[] descriptions = new string[values.Length];
			for (int i = 0; i < descriptions.Length; i++)
			{
				descriptions[i] = values[i].GetDescription();
			}
			comboBoxMorphExportFormat.Items.AddRange(descriptions);
			comboBoxMorphExportFormat.SelectedIndex = 1;

			tabControlXA.TabPages.Remove(tabPageXAObjectView);

			AnimationSpeed = Decimal.ToSingle(numericAnimationClipSpeed.Value);
			FollowSequence = checkBoxAnimationClipLoadNextClip.Checked;

			keepBackupToolStripMenuItem.Checked = (bool)Gui.Config["KeepBackupOfXA"];
			Gui.Docking.ShowDockContent(this, Gui.Docking.DockEditors, ContentCategory.Animations);
		}

		void DockContentAdded(object sender, DockContentEventArgs e)
		{
			FormXX formXX = e.DockContent as FormXX;
			if (formXX != null)
			{
				var xxParser = (xxParser)Gui.Scripting.Variables[formXX.ParserVar];
				string xxDir = Path.GetDirectoryName(formXX.ToolTipText);
				string xxPath = xxDir.ToLower().EndsWith(".pp") ? xxDir : formXX.ToolTipText;
				comboBoxMorphMesh.Items.Add(new Tuple<string, FormXX>(xxParser.Name + " " + xxPath, formXX));
				if (comboBoxMorphMesh.Items.Count == 1)
				{
					comboBoxMorphMesh.SelectedIndex = 0;
				}
			}
		}

		void DockContentRemoved(object sender, DockContentEventArgs e)
		{
			FormXX formXX = e.DockContent as FormXX;
			if (formXX != null)
			{
				for (int i = 0; i < comboBoxMorphMesh.Items.Count; i++)
				{
					Tuple<string, FormXX> tuple = (Tuple<string, FormXX>)comboBoxMorphMesh.Items[i];
					if (tuple.Item2 == formXX)
					{
						bool current = comboBoxMorphMesh.SelectedIndex == i;
						comboBoxMorphMesh.Items.RemoveAt(i);
						if (current && comboBoxMorphMesh.Items.Count > 0)
						{
							comboBoxMorphMesh.SelectedIndex = 0;
						}
						break;
					}
				}
			}
		}

		private void LoadXA()
		{
			/*for (int i = 0; i < Editor.Parser.header.children.Count; i++)
			{
				xaSection section = (xaSection)Editor.Parser.header.children[i];
				TreeNode sectionNode = new TreeNode("Section " + (i + 1));
				sectionNode.Tag = section;
				makeXAObjectTree(section, sectionNode);
				treeViewXA.Nodes.Add(sectionNode);
			}*/

			if (Editor.Parser.MaterialSection != null)
			{
				listViewType1.Items.Clear();
				for (int i = 0; i < Editor.Parser.MaterialSection.MaterialList.Count; i++)
				{
					xaMaterial mat = Editor.Parser.MaterialSection.MaterialList[i];
					ListViewItem item = new ListViewItem(mat.Name);
					item.Tag = mat;
					listViewType1.Items.Add(item);
				}
				listViewType1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
				tabPageMaterial.Text = "Material [" + Editor.Parser.MaterialSection.MaterialList.Count + "]";
			}

			if (Editor.Parser.MorphSection != null)
			{
				LoadMorphs();
				tabControlXA.SelectTabWithoutLoosingFocus(tabPageMorph);
			}

			if (Editor.Parser.AnimationSection != null)
			{
				animationSet = CreateAnimationSet();
				if (animationSet != null)
				{
					animationId = Gui.Renderer.AddAnimationSet(animationSet);

					renderTimer.Interval = 10;
					renderTimer.Tick += new EventHandler(renderTimer_Tick);
					Play();
				}

				createAnimationClipDataGridView();
				tabPageAnimation.Text = "Animation [" + dataGridViewAnimationClip.Rows.Count + "]";

				List<xaAnimationTrack> animationTrackList = Editor.Parser.AnimationSection.TrackList;
				createAnimationTrackListView(animationTrackList);
				animationSetMaxKeyframes(animationTrackList);

				dataGridViewAnimationClip.SelectionChanged -= dataGridViewAnimationClip_SelectionChanged;
				tabControlXA.SelectTabWithoutLoosingFocus(tabPageAnimation);
				while (dataGridViewAnimationClip.SelectedRows.Count > 0)
				{
					dataGridViewAnimationClip.SelectedRows[0].Selected = false;
				}
				dataGridViewAnimationClip.SelectionChanged += dataGridViewAnimationClip_SelectionChanged;

				Gui.Renderer.RenderObjectAdded += new EventHandler(Renderer_RenderObjectAdded);
			}
			else
			{
				animationSetMaxKeyframes(null);
			}
		}

		private void LoadMorphs()
		{
			listViewMorphKeyframe.Items.Clear();
			List<xaMorphKeyframe> morphKeyframeList = Editor.Parser.MorphSection.KeyframeList;
			for (int i = 0; i < morphKeyframeList.Count; i++)
			{
				xaMorphKeyframe morphKeyframe = morphKeyframeList[i];
				ListViewItem item = new ListViewItem(new string[] { morphKeyframe.Name, morphKeyframe.PositionList.Count.ToString() });
				item.Tag = morphKeyframe;
				//*section3bItem.viewItems.Add(item);
				listViewMorphKeyframe.Items.Add(item);
			}
			columnHeaderMorphKeyframeName.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);

			treeViewMorphClip.BeginUpdate();
			treeViewMorphClip.Nodes.Clear();
			List<xaMorphClip> morphClipList = Editor.Parser.MorphSection.ClipList;
			for (int i = 0; i < morphClipList.Count; i++)
			{
				xaMorphClip morphClip = morphClipList[i];
				TreeNode morphClipNode = new TreeNode(morphClip.Name + " [" + morphClip.MeshName + "]");
				morphClipNode.Checked = true;
				morphClipNode.Tag = morphClip;
				//*section3cItem.viewItems.Add(animationSetNode);
				treeViewMorphClip.Nodes.Add(morphClipNode);

				List<xaMorphKeyframeRef> morphKeyframeRefList = morphClip.KeyframeRefList;
				for (int j = 0; j < morphKeyframeRefList.Count; j++)
				{
					xaMorphKeyframeRef morphKeyframeRef = morphKeyframeRefList[j];
					string refIdStr = morphKeyframeRef.Index.ToString("D3");
					TreeNode morphKeyframeRefNode = new TreeNode(refIdStr + " : " + morphKeyframeRef.Name);
					morphKeyframeRefNode.Tag = morphKeyframeRef;
					//*animation.viewItems.Add(animationNode);
					morphClipNode.Nodes.Add(morphKeyframeRefNode);
				}
			}
			treeViewMorphClip.EndUpdate();
			tabPageMorph.Text = "Morph [" + morphClipList.Count + "]";
		}

		private TreeNode FindMorphClipTreeNode(string name, TreeNodeCollection nodes)
		{
			foreach (TreeNode node in nodes)
			{
				if (node.Tag is xaMorphClip)
				{
					xaMorphClip clip = (xaMorphClip)node.Tag;
					if (clip.Name == name)
						return node;
				}

				TreeNode found = FindMorphClipTreeNode(name, node.Nodes);
				if (found != null)
					return found;
			}

			return null;
		}

		private TreeNode FindMorphKeyframeRefTreeNode(string morphClip, int refId, TreeNodeCollection nodes)
		{
			foreach (TreeNode node in nodes)
			{
				if (node.Tag is xaMorphKeyframeRef)
				{
					xaMorphClip clip = (xaMorphClip)node.Parent.Tag;
					xaMorphKeyframeRef morphRef = (xaMorphKeyframeRef)node.Tag;
					if (clip.Name == morphClip && morphRef.Index == refId)
						return node;
				}

				TreeNode found = FindMorphKeyframeRefTreeNode(morphClip, refId, node.Nodes);
				if (found != null)
					return found;
			}

			return null;
		}

		private void UnloadXA()
		{
			try
			{
				if (Editor.Parser.AnimationSection != null)
				{
					if (animationSet != null)
					{
						Pause();
						renderTimer.Tick -= renderTimer_Tick;
						Gui.Renderer.RemoveAnimationSet(animationId);
						animationSet.Dispose();
						animationSet = null;
					}

					Gui.Renderer.RenderObjectAdded -= new EventHandler(Renderer_RenderObjectAdded);
				}
				setType1View(-1);
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void listViewType1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			try
			{
				if (e.IsSelected)
				{
					setType1View(e.Item.Index);
				}
				else
				{
					setType1View(-1);
				}
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void setType1View(int matIdx)
		{
			try
			{
				if (matIdx < 0)
				{
					setType1ConfigView(-1);
					labelType1ConfigPositionMax.Text = "/ 0";
					xaMatNameText.Text = String.Empty;
					loadedSection1Material = -1;
				}
				else
				{
					loadedSection1Material = matIdx;
					numericType1ConfigPosition.Maximum = Editor.Parser.MaterialSection.MaterialList[matIdx].ColorList.Count;
					labelType1ConfigPositionMax.Text = "/ " + Editor.Parser.MaterialSection.MaterialList[matIdx].ColorList.Count;
					xaMatNameText.Text = Editor.Parser.MaterialSection.MaterialList[matIdx].Name;
					setType1ConfigView(Decimal.ToInt32(numericType1ConfigPosition.Value) - 1);
				}
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void setType1ConfigView(int position)
		{
			try
			{
				if (position < 0)
				{
					loadedSection1MaterialConfig = -1;

					for (int i = 0; i < xaMaterialMatrixText.Length; i++)
					{
						for (int j = 0; j < xaMaterialMatrixText[i].Length; j++)
						{
							xaMaterialMatrixText[i][j].Text = String.Empty;
						}
					}
				}
				else
				{
					loadedSection1MaterialConfig = position;

					Color4 diffuse = Editor.Parser.MaterialSection.MaterialList[loadedSection1Material].ColorList[position].Diffuse;
					for (int i = 0; i < 4; i++)
					{
						xaMaterialMatrixText[0][i].Text = diffuse.ToVector4()[i].ToString();
					}
					Color4 ambient = Editor.Parser.MaterialSection.MaterialList[loadedSection1Material].ColorList[position].Ambient;
					for (int i = 0; i < 4; i++)
					{
						xaMaterialMatrixText[1][i].Text = ambient.ToVector4()[i].ToString();
					}
					Color4 specular = Editor.Parser.MaterialSection.MaterialList[loadedSection1Material].ColorList[position].Specular;
					for (int i = 0; i < 4; i++)
					{
						xaMaterialMatrixText[2][i].Text = specular.ToVector4()[i].ToString();
					}
					Color4 emissive = Editor.Parser.MaterialSection.MaterialList[loadedSection1Material].ColorList[position].Emissive;
					for (int i = 0; i < 4; i++)
					{
						xaMaterialMatrixText[3][i].Text = emissive.ToVector4()[i].ToString();
					}
					xaMaterialMatrixText[4][0].Text = Editor.Parser.MaterialSection.MaterialList[loadedSection1Material].ColorList[position].Power.ToString();

					int unknown1 = BitConverter.ToInt32(Editor.Parser.MaterialSection.MaterialList[loadedSection1Material].ColorList[position].Unknown1, 0);
					xaMaterialMatrixText[5][0].Text = unknown1.ToString();
				}
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void numericType1ConfigPosition_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				if (loadedSection1Material >= 0)
				{
					setType1ConfigView(Decimal.ToInt32(numericType1ConfigPosition.Value) - 1);
				}
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void Renderer_RenderObjectAdded(object sender, EventArgs e)
		{
			if (trackEnabled)
			{
				EnableTrack();
			}
			SetTrackPosition(trackPos);
			AdvanceTime(0);
		}

		private void animationSetMaxKeyframes(List<xaAnimationTrack> animationTrackList)
		{
			int max = 0;
			if (animationTrackList != null)
			{
				foreach (xaAnimationTrack animationTrack in animationTrackList)
				{
					int numKeyframes = animationTrack.KeyframeList.Count - 1;
					if (numKeyframes > max)
					{
						max = numKeyframes;
					}
				}
			}

			labelSkeletalRender.Text = "/ " + max;
			numericAnimationClipKeyframe.Maximum = max;
			trackBarAnimationClipKeyframe.Maximum = max;
			numericAnimationKeyframeStart.Maximum = max;
			numericAnimationKeyframeEnd.Maximum = max;
		}

		private void createAnimationTrackListView(List<xaAnimationTrack> animationTrackList)
		{
			if (animationTrackList.Count > 0)
			{
				listViewAnimationTrack.BeginUpdate();
				listViewAnimationTrack.Items.Clear();
				for (int i = 0; i < animationTrackList.Count; i++)
				{
					xaAnimationTrack track = animationTrackList[i];
					ListViewItem item = new ListViewItem(new string[] { track.Name, track.KeyframeList.Count.ToString(), (track.KeyframeList[track.KeyframeList.Count - 1].Index + 1).ToString() });
					item.Tag = track;
					listViewAnimationTrack.Items.Add(item);
				}
				listViewAnimationTrack.EndUpdate();
			}
		}

		public void createAnimationClipDataGridView()
		{
			List<xaAnimationClip> clipList = Editor.Parser.AnimationSection.ClipList;

			int clipMax = -1;
			for (int i = 0; i < clipList.Count; i++)
			{
				xaAnimationClip clip = clipList[i];
				if ((clip.Name != String.Empty) || (clip.Start != 0) || (clip.End != 0) || (clip.Next != 0))
				{
					if (i > clipMax)
					{
						clipMax = i;
					}
				}
				if (clip.Next > clipMax)
				{
					clipMax = clip.Next;
				}
			}

			object rowTag = null;
			while (dataGridViewAnimationClip.SelectedRows.Count > 0)
			{
				rowTag = dataGridViewAnimationClip.SelectedRows[0].Tag;
				dataGridViewAnimationClip.SelectedRows[0].Selected = false;
			}
			dataGridViewAnimationClip.SelectionChanged -= dataGridViewAnimationClip_SelectionChanged;
			dataGridViewAnimationClip.CellValueChanged -= dataGridViewAnimationClip_CellValueChanged;
			dataGridViewAnimationClip.Rows.Clear();
			for (int i = 0; i <= clipMax; i++)
			{
				xaAnimationClip clip = clipList[i];
				string unknowns = clip.Unknown2[0].ToString("X2") + clip.Unknown4[0].ToString("X2");
				dataGridViewAnimationClip.Rows.Add(new string[] { i.ToString(), clip.Name, clip.Start.ToString(), clip.End.ToString(), clip.Next.ToString(), clip.Speed.ToString(), unknowns });
				DataGridViewRow row = dataGridViewAnimationClip.Rows[i];
				row.Tag = clip;
			}
			dataGridViewAnimationClip.CellValueChanged += dataGridViewAnimationClip_CellValueChanged;
			dataGridViewAnimationClip.SelectionChanged += dataGridViewAnimationClip_SelectionChanged;
			while (dataGridViewAnimationClip.SelectedRows.Count > 0)
			{
				dataGridViewAnimationClip.SelectedRows[0].Selected = false;
			}
			if (rowTag != null)
			{
				foreach (DataGridViewRow row in dataGridViewAnimationClip.Rows)
				{
					if (row.Tag == rowTag)
					{
						row.Selected = true;
						break;
					}
				}
			}
		}

		KeyframedAnimationSet CreateAnimationSet()
		{
			var trackList = Editor.Parser.AnimationSection.TrackList;
			if ((trackList == null) || (trackList.Count <= 0))
			{
				return null;
			}

			KeyframedAnimationSet set = new KeyframedAnimationSet("SetName", 1, PlaybackType.Once, trackList.Count, new CallbackKey[0]);
			for (int i = 0; i < trackList.Count; i++)
			{
				var track = trackList[i];
				var keyframes = track.KeyframeList;
				ScaleKey[] scaleKeys = new ScaleKey[keyframes.Count];
				RotationKey[] rotationKeys = new RotationKey[keyframes.Count];
				TranslationKey[] translationKeys = new TranslationKey[keyframes.Count];
				for (int k = 0; k < 10; k++)
				{
					try
					{
						set.RegisterAnimationKeys(k == 0 ? track.Name : track.Name + "_error" + k, scaleKeys, rotationKeys, translationKeys);
						for (int j = 0; j < keyframes.Count; j++)
						{
							float time = keyframes[j].Index;

							ScaleKey scale = new ScaleKey();
							scale.Time = time;
							scale.Value = keyframes[j].Scaling;
							//scaleKeys[j] = scale;
							set.SetScaleKey(i, j, scale);

							RotationKey rotation = new RotationKey();
							rotation.Time = time;
							rotation.Value = Quaternion.Invert(keyframes[j].Rotation);
							//rotationKeys[j] = rotation;
							set.SetRotationKey(i, j, rotation);

							TranslationKey translation = new TranslationKey();
							translation.Time = time;
							translation.Value = keyframes[j].Translation;
							//translationKeys[j] = translation;
							set.SetTranslationKey(i, j, translation);
						}
						break;
					}
					catch (Exception ex)
					{
						switch (k)
						{
						case 0:
							Report.ReportLog("Error in Track: " + track.Name);
							Utility.ReportException(ex);
							break;
						case 9:
							Report.ReportLog("Aborting to register with different name. Animation will not be displayed.");
							break;
						}
					}
				}
			}

			return set;
		}

		void SetTrackPosition(double position)
		{
			Gui.Renderer.SetTrackPosition(animationId, position);
			trackPos = position;
		}

		void AdvanceTime(double time)
		{
			Gui.Renderer.AdvanceTime(animationId, time, null);
			trackPos += time;
		}

		public void Play()
		{
			if (loadedAnimationClip != null)
			{
				var clip = (xaAnimationClip)loadedAnimationClip.Tag;
				if (trackPos < clip.Start)
				{
					SetTrackPosition(clip.Start);
					AdvanceTime(0);
				}
			}

			this.play = true;
			this.startTime = DateTime.Now;
			renderTimer.Start();
			buttonAnimationClipPlayPause.ImageIndex = 1;
		}

		public void Pause()
		{
			this.play = false;
			renderTimer.Stop();
			buttonAnimationClipPlayPause.ImageIndex = 0;
		}

		public void AnimationSetClip(int idx)
		{
			bool play = this.play;
			Pause();

			if (loadedAnimationClip != null)
			{
				dataGridViewAnimationClip.SelectionChanged -= dataGridViewAnimationClip_SelectionChanged;
				loadedAnimationClip.Selected = false;
				dataGridViewAnimationClip.SelectionChanged += dataGridViewAnimationClip_SelectionChanged;
			}

			if (idx < 0)
			{
				loadedAnimationClip = null;
				DisableTrack();
			}
			else
			{
				loadedAnimationClip = dataGridViewAnimationClip.Rows[idx];
				var clip = (xaAnimationClip)loadedAnimationClip.Tag;
				EnableTrack();
				SetTrackPosition(clip.Start);
				AdvanceTime(0);

				dataGridViewAnimationClip.SelectionChanged -= dataGridViewAnimationClip_SelectionChanged;
				loadedAnimationClip.Selected = true;
				dataGridViewAnimationClip.SelectionChanged += dataGridViewAnimationClip_SelectionChanged;

				SetKeyframeNum((int)clip.Start);
			}

			if (play)
			{
				Play();
			}
		}

		private void EnableTrack()
		{
			Gui.Renderer.EnableTrack(animationId);
			trackEnabled = true;
		}

		private void DisableTrack()
		{
			Gui.Renderer.DisableTrack(animationId);
			trackEnabled = false;
		}

		private void SetKeyframeNum(int num)
		{
			if ((num >= 0) && (num <= numericAnimationClipKeyframe.Maximum))
			{
				userTrackBar = false;
				numericAnimationClipKeyframe.Value = num;
				trackBarAnimationClipKeyframe.Value = num;
				userTrackBar = true;
			}
		}

		private void dataGridViewAnimationClip_SelectionChanged(object sender, EventArgs e)
		{
			if (dataGridViewAnimationClip.SelectedRows.Count > 0)
			{
				AnimationSetClip(dataGridViewAnimationClip.SelectedRows[0].Index);
			}
			else
			{
				if (loadedAnimationClip != null)
				{
					AnimationSetClip(-1);
				}
			}

			string clipRange = "-1-0";
			if (loadedAnimationClip != null)
			{
				xaAnimationClip clip = (xaAnimationClip)loadedAnimationClip.Tag;
				clipRange = clip.Start.ToString() + "-" + clip.End.ToString();
			}
			List<DockContent> formXXList;
			if (Gui.Docking.DockContents.TryGetValue(typeof(FormXX), out formXXList))
			{
				foreach (FormXX form in formXXList)
				{
					form.textBoxKeyframeRange.Text = clipRange;
				}
			}
		}

		private void dataGridViewAnimationClip_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex < 0)
					return;

				DataGridViewRow row = dataGridViewAnimationClip.Rows[e.RowIndex];
				xaAnimationClip clip = (xaAnimationClip)row.Tag;
				string name = row.Cells[1].Value.ToString();
				int start = Int32.Parse(row.Cells[2].Value.ToString());
				int end = Int32.Parse(row.Cells[3].Value.ToString());
				int next = Int32.Parse(row.Cells[4].Value.ToString());
				float speed = Single.Parse(row.Cells[5].Value.ToString());
				Gui.Scripting.RunScript(EditorVar + ".SetAnimationClip(clip=" + EditorVar + ".Parser.AnimationSection.ClipList[" + e.RowIndex + "], name=\"" + name + "\", start=" + start + ", end=" + end + ", next=" + next + ", speed=" + speed.ToFloatString() + ")");
				string hex = row.Cells[6].Value.ToString();
				string unknown1 = ScriptHelper.Bytes("unknown1", Utility.BytesToString(clip.Unknown1));
				string unknown2 = ScriptHelper.Bytes("unknown2", hex.Substring(0, 2));
				string unknown3 = ScriptHelper.Bytes("unknown3", Utility.BytesToString(clip.Unknown3));
				string unknown4 = ScriptHelper.Bytes("unknown4", hex.Substring(2, 2));
				string unknown5 = ScriptHelper.Bytes("unknown5", Utility.BytesToString(clip.Unknown5));
				string unknown6 = ScriptHelper.Bytes("unknown6", Utility.BytesToString(clip.Unknown6));
				string unknown7 = ScriptHelper.Bytes("unknown7", Utility.BytesToString(clip.Unknown7));
				Gui.Scripting.RunScript(EditorVar + ".SetAnimationClipUnknowns(clipId=" + e.RowIndex + ", " + unknown1 + ", " + unknown2 + ", " + unknown3 + ", " + unknown4 + ", " + unknown5 + ", " + unknown6 + ", " + unknown7 + ")");

				createAnimationClipDataGridView();
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void buttonAnimationClipMoveUp_Click(object sender, EventArgs e)
		{
			try
			{
				if (loadedAnimationClip == null || loadedAnimationClip.Index <= 0)
					return;

				xaAnimationClip clip = (xaAnimationClip)loadedAnimationClip.Tag;
				Gui.Scripting.RunScript(EditorVar + ".MoveAnimationClip(clip=" + EditorVar + ".Parser.AnimationSection.ClipList[" + loadedAnimationClip.Index + "], position=" + (loadedAnimationClip.Index - 1) + ")");

				createAnimationClipDataGridView();
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void buttonAnimationClipMoveDown_Click(object sender, EventArgs e)
		{
			try
			{
				if (loadedAnimationClip == null || loadedAnimationClip.Index >= dataGridViewAnimationClip.Rows.Count - 1)
					return;

				xaAnimationClip clip = (xaAnimationClip)loadedAnimationClip.Tag;
				Gui.Scripting.RunScript(EditorVar + ".MoveAnimationClip(clip=" + EditorVar + ".Parser.AnimationSection.ClipList[" + loadedAnimationClip.Index + "], position=" + (loadedAnimationClip.Index + 1) + ")");

				createAnimationClipDataGridView();
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void buttonAnimationClipCopy_Click(object sender, EventArgs e)
		{
			try
			{
				if (loadedAnimationClip == null)
					return;

				xaAnimationClip clip = (xaAnimationClip)loadedAnimationClip.Tag;
				Gui.Scripting.RunScript(EditorVar + ".CopyAnimationClip(clip=" + EditorVar + ".Parser.AnimationSection.ClipList[" + loadedAnimationClip.Index + "], position=" + dataGridViewAnimationClip.Rows.Count + ")");

				createAnimationClipDataGridView();
				dataGridViewAnimationClip.Rows[dataGridViewAnimationClip.Rows.Count - 1].Selected = true;
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void buttonAnimationClipDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (loadedAnimationClip == null)
					return;

				xaAnimationClip clip = (xaAnimationClip)loadedAnimationClip.Tag;
				Gui.Scripting.RunScript(EditorVar + ".DeleteAnimationClip(clip=" + EditorVar + ".Parser.AnimationSection.ClipList[" + loadedAnimationClip.Index + "])");

				createAnimationClipDataGridView();
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void renderTimer_Tick(object sender, EventArgs e)
		{
			if (play && (loadedAnimationClip != null))
			{
				TimeSpan elapsedTime = DateTime.Now - this.startTime;
				if (elapsedTime.TotalSeconds > 0)
				{
					double advanceTime = elapsedTime.TotalSeconds * AnimationSpeed;
					xaAnimationClip clip = (xaAnimationClip)loadedAnimationClip.Tag;
					if ((trackPos + advanceTime) >= clip.End)
					{
						if (FollowSequence && (clip.Next != 0) && (clip.Next != loadedAnimationClip.Index))
						{
							AnimationSetClip(clip.Next);
						}
						else
						{
							SetTrackPosition(clip.Start);
							AdvanceTime(0);
						}
					}
					else
					{
						AdvanceTime(advanceTime);
					}

					SetKeyframeNum((int)trackPos);
					this.startTime = DateTime.Now;
				}
			}
		}

		private void checkBoxAnimationClipLoadNextClip_CheckedChanged(object sender, EventArgs e)
		{
			FollowSequence = checkBoxAnimationClipLoadNextClip.Checked;
		}

		private void numericAnimationClipSpeed_ValueChanged(object sender, EventArgs e)
		{
			AnimationSpeed = Decimal.ToSingle(numericAnimationClipSpeed.Value);
		}

		private void buttonAnimationClipPlayPause_Click(object sender, EventArgs e)
		{
			if (this.play)
			{
				Pause();
			}
			else
			{
				Play();
			}
		}

		private void trackBarAnimationClipKeyframe_ValueChanged(object sender, EventArgs e)
		{
			if (userTrackBar && (Editor.Parser.AnimationSection != null))
			{
				Pause();

				if (!trackEnabled)
				{
					EnableTrack();
				}
				SetTrackPosition(Decimal.ToDouble(trackBarAnimationClipKeyframe.Value));
				AdvanceTime(0);

				userTrackBar = false;
				numericAnimationClipKeyframe.Value = trackBarAnimationClipKeyframe.Value;
				userTrackBar = true;
			}
		}

		private void numericAnimationClipKeyframe_ValueChanged(object sender, EventArgs e)
		{
			if (userTrackBar && (Editor.Parser.AnimationSection != null))
			{
				Pause();

				if (!trackEnabled)
				{
					EnableTrack();
				}
				SetTrackPosition((double)numericAnimationClipKeyframe.Value);
				AdvanceTime(0);

				userTrackBar = false;
				trackBarAnimationClipKeyframe.Value = Decimal.ToInt32(numericAnimationClipKeyframe.Value);
				userTrackBar = true;
			}
		}

		private void treeViewMorphClip_AfterSelect(object sender, TreeViewEventArgs e)
		{
			try
			{
				textBoxFrameNameRefID.AfterEditTextChanged -= textBoxFrameNameRefID_AfterEditTextChanged;
				editTextBoxMorphClipName.AfterEditTextChanged -= editTextBoxMorphClipName_AfterEditTextChanged;
				editTextBoxMorphClipMesh.AfterEditTextChanged -= editTextBoxMorphClipMesh_AfterEditTextChanged;
				if (e.Node.Tag is xaMorphKeyframeRef)
				{
					xaMorphKeyframeRef keyframeRef = (xaMorphKeyframeRef)e.Node.Tag;
					textBoxFrameNameRefID.Text = keyframeRef.Index.ToString();
					textBoxFrameNameRefID.Enabled = true;

					UpdateComboBoxRefKeyframe(keyframeRef.Name);

					xaMorphClip clip = (xaMorphClip)e.Node.Parent.Tag;
					editTextBoxMorphClipName.Text = clip.Name;
					editTextBoxMorphClipMesh.Text = clip.MeshName;
				}
				else
				{
					textBoxFrameNameRefID.Text = String.Empty;
					textBoxFrameNameRefID.Enabled = false;

					comboBoxRefKeyframe.Items.Clear();
					comboBoxRefKeyframe.Enabled = false;

					xaMorphClip clip = (xaMorphClip)e.Node.Tag;
					editTextBoxMorphClipName.Text = clip.Name;
					editTextBoxMorphClipMesh.Text = clip.MeshName;
				}
				textBoxFrameNameRefID.AfterEditTextChanged += textBoxFrameNameRefID_AfterEditTextChanged;
				editTextBoxMorphClipName.AfterEditTextChanged += editTextBoxMorphClipName_AfterEditTextChanged;
				editTextBoxMorphClipMesh.AfterEditTextChanged += editTextBoxMorphClipMesh_AfterEditTextChanged;
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void UpdateComboBoxRefKeyframe(string keyframeName)
		{
			xaMorphKeyframe keyframe = xa.FindMorphKeyFrame(keyframeName, Editor.Parser.MorphSection);
			comboBoxRefKeyframe.BeginUpdate();
			comboBoxRefKeyframe.SelectedIndexChanged -= comboBoxRefKeyframe_SelectedIndexChanged;
			comboBoxRefKeyframe.Items.Clear();
			foreach (xaMorphKeyframe i in Editor.Parser.MorphSection.KeyframeList)
			{
				if (!checkBoxOnlyValidKeyframes.Checked || i.PositionList.Count == keyframe.PositionList.Count)
				{
					comboBoxRefKeyframe.Items.Add(i.Name);
				}
			}
			comboBoxRefKeyframe.SelectedItem = keyframe.Name;
			comboBoxRefKeyframe.SelectedIndexChanged += comboBoxRefKeyframe_SelectedIndexChanged;
			comboBoxRefKeyframe.EndUpdate();
			comboBoxRefKeyframe.Enabled = true;

			foreach (ListViewItem item in listViewMorphKeyframe.Items)
			{
				if (item.Text == keyframe.Name)
				{
					listViewMorphKeyframe.SelectedItems.Clear();
					item.Selected = true;
					item.EnsureVisible();
				}
			}
		}

		private void treeViewMorphClip_ItemDrag(object sender, ItemDragEventArgs e)
		{
			try
			{
				if (e.Item is TreeNode)
				{
					treeViewMorphClip.DoDragDrop(e.Item, DragDropEffects.Copy);
				}
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void treeViewMorphClip_DragEnter(object sender, DragEventArgs e)
		{
			try
			{
				UpdateDragDropMorphs(sender, e);
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void treeViewMorphClip_DragOver(object sender, DragEventArgs e)
		{
			try
			{
				UpdateDragDropMorphs(sender, e);
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void treeViewMorphClip_DragDrop(object sender, DragEventArgs e)
		{
			try
			{
				TreeNode node = (TreeNode)e.Data.GetData(typeof(TreeNode));
				if (node == null)
				{
					Gui.Docking.DockDragDrop(sender, e);
				}
				else
				{
					ProcessDragDropMorphs(node);
				}
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void ProcessDragDropMorphs(TreeNode node)
		{
			if (node.Tag is DragSource)
			{
				if ((node.Parent != null) && !node.Checked && node.StateImageIndex != (int)CheckState.Indeterminate)
				{
					return;
				}

				DragSource? dest = null;
				if (treeViewMorphClip.SelectedNode != null)
				{
					dest = treeViewMorphClip.SelectedNode.Tag as DragSource?;
				}

				DragSource source = (DragSource)node.Tag;
				if (source.Type == typeof(WorkspaceMorph))
				{
					using (var dragOptions = new FormXADragDrop(Editor, true))
					{
						var srcEditor = (ImportedEditor)Gui.Scripting.Variables[source.Variable];
						dragOptions.textBoxName.Text = srcEditor.Morphs[(int)source.Id].Name;
						if (dragOptions.ShowDialog() == DialogResult.OK)
						{
							// repeating only final choices for repeatability of the script
							WorkspaceMorph wsMorph = srcEditor.Morphs[(int)source.Id];
							foreach (ImportedMorphKeyframe keyframe in wsMorph.KeyframeList)
							{
								if (!wsMorph.isMorphKeyframeEnabled(keyframe))
								{
									Gui.Scripting.RunScript(source.Variable + ".setMorphKeyframeEnabled(morphId=" + (int)source.Id + ", id=" + wsMorph.KeyframeList.IndexOf(keyframe) + ", enabled=false)");
								}
							}
							int numKeyframes = Editor.Parser.MorphSection.KeyframeList.Count;
							Gui.Scripting.RunScript(EditorVar + ".ReplaceMorph(morph=" + source.Variable + ".Morphs[" + (int)source.Id + "], destMorphName=\"" + dragOptions.textBoxName.Text + "\", newName=\"" + dragOptions.textBoxNewName.Text + "\", replaceNormals=" + dragOptions.radioButtonReplaceNormalsYes.Checked + ", minSquaredDistance=" + ((float)dragOptions.numericUpDownMinimumDistanceSquared.Value).ToFloatString() + ")");
							UnloadXA();
							LoadXA();
							TreeNode clipNode = FindMorphClipTreeNode(dragOptions.textBoxName.Text, treeViewMorphClip.Nodes);
							if (clipNode != null)
							{
								clipNode.Expand();
							}
							if (numKeyframes != Editor.Parser.MorphSection.KeyframeList.Count)
							{
								listViewMorphKeyframe.Items[listViewMorphKeyframe.Items.Count - 1].EnsureVisible();
							}
							tabControlXA.SelectedTab = tabPageMorph;
						}
					}
				}
			}
			else
			{
				foreach (TreeNode child in node.Nodes)
				{
					ProcessDragDropMorphs(child);
				}
			}
		}

		private void UpdateDragDropMorphs(object sender, DragEventArgs e)
		{
			Point p = treeViewMorphClip.PointToClient(new Point(e.X, e.Y));
			TreeNode target = treeViewMorphClip.GetNodeAt(p);
			if ((target != null) && ((p.X < target.Bounds.Left) || (p.X > target.Bounds.Right) || (p.Y < target.Bounds.Top) || (p.Y > target.Bounds.Bottom)))
			{
				target = null;
			}
			treeViewMorphClip.SelectedNode = target;

			TreeNode node = (TreeNode)e.Data.GetData(typeof(TreeNode));
			if (node == null)
			{
				Gui.Docking.DockDragEnter(sender, e);
			}
			else
			{
				e.Effect = e.AllowedEffect & DragDropEffects.Copy;
			}
		}

		private void editTextBoxMorphClipName_AfterEditTextChanged(object sender, EventArgs e)
		{
			if (treeViewMorphClip.SelectedNode == null)
				return;

			try
			{
				TreeNode clipNode = treeViewMorphClip.SelectedNode.Tag is xaMorphClip ? treeViewMorphClip.SelectedNode : treeViewMorphClip.SelectedNode.Parent;
				xaMorphClip clip = (xaMorphClip)clipNode.Tag;
				Gui.Scripting.RunScript(EditorVar + ".SetMorphClipName(position=" + Editor.Parser.MorphSection.ClipList.IndexOf(clip) + ", newName=\"" + editTextBoxMorphClipName.Text + "\")");

				clipNode.Text = clip.Name + " [" + clip.MeshName + "]";
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void editTextBoxMorphClipMesh_AfterEditTextChanged(object sender, EventArgs e)
		{
			if (treeViewMorphClip.SelectedNode == null)
				return;

			try
			{
				TreeNode clipNode = treeViewMorphClip.SelectedNode.Tag is xaMorphClip ? treeViewMorphClip.SelectedNode : treeViewMorphClip.SelectedNode.Parent;
				xaMorphClip clip = (xaMorphClip)clipNode.Tag;
				Gui.Scripting.RunScript(EditorVar + ".SetMorphClipMesh(position=" + Editor.Parser.MorphSection.ClipList.IndexOf(clip) + ", mesh=\"" + editTextBoxMorphClipMesh.Text + "\")");

				clipNode.Text = clip.Name + " [" + clip.MeshName + "]";
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void textBoxFrameNameRefID_AfterEditTextChanged(object sender, EventArgs e)
		{
			try
			{
				if (treeViewMorphClip.SelectedNode.Tag is xaMorphKeyframeRef)
				{
					TreeNode keyframeRefNode = treeViewMorphClip.SelectedNode;
					xaMorphKeyframeRef keyframeRef = (xaMorphKeyframeRef)keyframeRefNode.Tag;
					xaMorphClip clip = (xaMorphClip)keyframeRefNode.Parent.Tag;
					int refId = Int32.Parse(textBoxFrameNameRefID.Text);
					Gui.Scripting.RunScript(EditorVar + ".SetMorphKeyframeRefIndex(morphClip=\"" + clip.Name + "\", position=" + clip.KeyframeRefList.IndexOf(keyframeRef) + ", id=" + refId + ")");

					keyframeRefNode.Text = keyframeRef.Index.ToString("D3") + " : " + keyframeRef.Name;
				}
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void comboBoxRefKeyframe_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				TreeNode keyframeRefNode = treeViewMorphClip.SelectedNode;
				xaMorphKeyframeRef keyframeRef = (xaMorphKeyframeRef)keyframeRefNode.Tag;
				xaMorphClip clip = (xaMorphClip)keyframeRefNode.Parent.Tag;
				Gui.Scripting.RunScript(EditorVar + ".SetMorphKeyframeRefKeyframe(morphClip=\"" + clip.Name + "\", position=" + clip.KeyframeRefList.IndexOf(keyframeRef) + ", keyframe=\"" + comboBoxRefKeyframe.Items[comboBoxRefKeyframe.SelectedIndex] + "\")");

				keyframeRefNode.Text = keyframeRef.Index.ToString("D3") + " : " + keyframeRef.Name;
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void checkBoxOnlyValidKeyframes_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				if (treeViewMorphClip.SelectedNode != null)
				{
					xaMorphKeyframeRef morphRef = treeViewMorphClip.SelectedNode.Tag as xaMorphKeyframeRef;
					if (morphRef != null)
					{
						UpdateComboBoxRefKeyframe(morphRef.Name);
					}
				}
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void buttonNewRef_Click(object sender, EventArgs e)
		{
			try
			{
				if (treeViewMorphClip.SelectedNode == null)
				{
					Report.ReportLog("Select a predecessor first.");
					return;
				}
				xaMorphClip clip;
				int pos;
				xaMorphKeyframeRef morphRef = treeViewMorphClip.SelectedNode.Tag as xaMorphKeyframeRef;
				if (morphRef != null)
				{
					clip = (xaMorphClip)treeViewMorphClip.SelectedNode.Parent.Tag;
					pos = clip.KeyframeRefList.IndexOf(morphRef) + 1;
				}
				else
				{
					clip = (xaMorphClip)treeViewMorphClip.SelectedNode.Tag;
					pos = 0;
				}
				Gui.Scripting.RunScript(EditorVar + ".CreateMorphKeyframeRef(morphClip=\"" + clip.Name + "\", position=" + pos + ", keyframe=\"" + clip.KeyframeRefList[0].Name + "\")");

				RefreshMorphs();
				treeViewMorphClip.SelectedNode = treeViewMorphClip.SelectedNode.Tag is xaMorphClip
					? treeViewMorphClip.SelectedNode.Nodes[0]
					: treeViewMorphClip.SelectedNode.NextNode;
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void buttonDeleteRef_Click(object sender, EventArgs e)
		{
			try
			{
				if (treeViewMorphClip.SelectedNode == null || !(treeViewMorphClip.SelectedNode.Tag is xaMorphKeyframeRef))
				{
					return;
				}
				xaMorphClip clip = (xaMorphClip)treeViewMorphClip.SelectedNode.Parent.Tag;
				xaMorphKeyframeRef morphRef = (xaMorphKeyframeRef)treeViewMorphClip.SelectedNode.Tag;
				int pos = clip.KeyframeRefList.IndexOf(morphRef);
				Gui.Scripting.RunScript(EditorVar + ".RemoveMorphKeyframeRef(morphClip=\"" + clip.Name + "\", position=" + pos + ")");

				RefreshMorphs();
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void buttonRefUp_Click(object sender, EventArgs e)
		{
			try
			{
				if (treeViewMorphClip.SelectedNode == null || !(treeViewMorphClip.SelectedNode.Tag is xaMorphKeyframeRef))
				{
					return;
				}
				xaMorphClip clip = (xaMorphClip)treeViewMorphClip.SelectedNode.Parent.Tag;
				xaMorphKeyframeRef morphRef = (xaMorphKeyframeRef)treeViewMorphClip.SelectedNode.Tag;
				int pos = clip.KeyframeRefList.IndexOf(morphRef);
				if (pos > 0)
				{
					Gui.Scripting.RunScript(EditorVar + ".MoveMorphKeyframeRef(morphClip=\"" + clip.Name + "\", fromPos=" + pos + ", toPos=" + (pos - 1) + ")");

					RefreshMorphs();
				}
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void buttonRefDown_Click(object sender, EventArgs e)
		{
			try
			{
				if (treeViewMorphClip.SelectedNode == null || !(treeViewMorphClip.SelectedNode.Tag is xaMorphKeyframeRef))
				{
					return;
				}
				xaMorphClip clip = (xaMorphClip)treeViewMorphClip.SelectedNode.Parent.Tag;
				xaMorphKeyframeRef morphRef = (xaMorphKeyframeRef)treeViewMorphClip.SelectedNode.Tag;
				int pos = clip.KeyframeRefList.IndexOf(morphRef);
				if (pos < clip.KeyframeRefList.Count - 1)
				{
					Gui.Scripting.RunScript(EditorVar + ".MoveMorphKeyframeRef(morphClip=\"" + clip.Name + "\", fromPos=" + pos + ", toPos=" + (pos + 1) + ")");

					RefreshMorphs();
				}
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void buttonMorphClipExport_Click(object sender, EventArgs e)
		{
			try
			{
				if (treeViewMorphClip.SelectedNode == null)
				{
					Report.ReportLog("No morph clip was selected");
					return;
				}
				if (comboBoxMorphMesh.SelectedItem == null)
				{
					Report.ReportLog("No .xx file was selected");
					return;
				}

				TreeNode clipNode = treeViewMorphClip.SelectedNode;
				while (clipNode.Parent != null)
				{
					clipNode = clipNode.Parent;
				}
				xaMorphClip clip = (xaMorphClip)clipNode.Tag;
				int clipIdx = ((xaParser)Gui.Scripting.Variables[this.ParserVar]).MorphSection.ClipList.IndexOf(clip);

				FormXX formXX = ((Tuple<string, FormXX>)comboBoxMorphMesh.SelectedItem).Item2;
				string xxParserVar = formXX.ParserVar;
				xxParser xxParser = (xxParser)Gui.Scripting.Variables[xxParserVar];
				xxFrame meshFrame = xx.FindFrame(clip.MeshName, xxParser.Frame);
				if (meshFrame == null)
				{
					Report.ReportLog(xxParser.Name + " doesn't contain the " + clip.MeshName + " mesh");
					return;
				}
				string xxEditorVar = formXX.EditorVar;
				int meshFrameId = formXX.Editor.Frames.IndexOf(meshFrame);

				string path = Path.GetDirectoryName(this.ToolTipText);
				if (path.ToLower().EndsWith(".pp"))
				{
					path = path.Substring(0, path.Length - 3);
				}
				path += @"\" + Path.GetFileNameWithoutExtension(this.ToolTipText);
				DirectoryInfo dir = new DirectoryInfo(path);
				switch ((MorphExportFormat)comboBoxMorphExportFormat.SelectedIndex)
				{
				case MorphExportFormat.Mqo:
					Gui.Scripting.RunScript("ExportMorphMqo(dirPath=\"" + path + "\", xxparser=" + xxParserVar + ", meshFrame=" + xxEditorVar + ".Frames[" + meshFrameId + "], xaparser=" + this.ParserVar + ", clip="+ this.ParserVar + ".MorphSection.ClipList[" + clipIdx + "])");
					break;
				case MorphExportFormat.Fbx:
					path = Utility.GetDestFile(dir, clip.MeshName + "-" + clip.Name + "-", ".fbx");
					Gui.Scripting.RunScript("ExportMorphFbx(xxparser=" + xxParserVar + ", path=\"" + path + "\", meshFrame=" + xxEditorVar + ".Frames[" + meshFrameId + "], xaparser=" + this.ParserVar + ", morphClip=" + this.ParserVar + ".MorphSection.ClipList[" + clipIdx + "], exportFormat=\"" + ".fbx" + "\", oneBlendShape=" + checkBoxFbxOptionOneBlendshape.Checked + ", embedMedia=" + checkBoxFbxOptionEmbedMedia.Checked + ", compatibility=" + false + ")");
					break;
				case MorphExportFormat.Fbx_2006:
					path = Utility.GetDestFile(dir, clip.MeshName + "-" + clip.Name + "-", ".fbx");
					Gui.Scripting.RunScript("ExportMorphFbx(xxparser=" + xxParserVar + ", path=\"" + path + "\", meshFrame=" + xxEditorVar + ".Frames[" + meshFrameId + "], xaparser=" + this.ParserVar + ", morphClip=" + this.ParserVar + ".MorphSection.ClipList[" + clipIdx + "], exportFormat=\"" + ".fbx" + "\", oneBlendShape=" + checkBoxFbxOptionOneBlendshape.Checked + ", embedMedia=" + checkBoxFbxOptionEmbedMedia.Checked + ", compatibility=" + true + ")");
					break;
				}
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void listViewMorphKeyframe_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			editTextBoxNewKeyframeName.AfterEditTextChanged -= editTextBoxNewKeyframeName_AfterEditTextChanged;
			editTextBoxNewKeyframeName.Text = e.IsSelected ? ((xaMorphKeyframe)e.Item.Tag).Name : String.Empty;
			editTextBoxNewKeyframeName.AfterEditTextChanged += editTextBoxNewKeyframeName_AfterEditTextChanged;
		}

		private void editTextBoxNewKeyframeName_AfterEditTextChanged(object sender, EventArgs e)
		{
			try
			{
				if (listViewMorphKeyframe.SelectedIndices.Count < 1 || editTextBoxNewKeyframeName.Text == String.Empty)
					return;
				if (xa.FindMorphKeyFrame(editTextBoxNewKeyframeName.Text, Editor.Parser.MorphSection) != null)
				{
					Report.ReportLog("Keyframe " + editTextBoxNewKeyframeName.Text + " already exists.");
					return;
				}

				Gui.Scripting.RunScript(EditorVar + ".RenameMorphKeyframe(position=" + listViewMorphKeyframe.SelectedIndices[0] + ", newName=\"" + editTextBoxNewKeyframeName.Text + "\")");

				RefreshMorphs();
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void RefreshMorphs()
		{
			string morphClip = null;
			int pos = -2;
			if (treeViewMorphClip.SelectedNode != null)
			{
				TreeNode node = treeViewMorphClip.SelectedNode;
				if (node.Tag is xaMorphClip)
				{
					morphClip = ((xaMorphClip)node.Tag).Name;
					if (node.IsExpanded)
					{
						pos = -1;
					}
				}
				else if (node.Tag is xaMorphKeyframeRef)
				{
					xaMorphKeyframeRef morphRef = (xaMorphKeyframeRef)node.Tag;
					xaMorphClip clip = (xaMorphClip)node.Parent.Tag;
					morphClip = clip.Name;
					pos = clip.KeyframeRefList.IndexOf(morphRef);
				}
			}
			LoadMorphs();
			if (morphClip != null)
			{
				TreeNode node = FindMorphClipTreeNode(morphClip, treeViewMorphClip.Nodes);
				if (pos != -2)
				{
					node.Expand();
					if (pos != -1 && node.Nodes.Count > pos)
					{
						node = node.Nodes[pos];
					}
				}
				if (node != null)
				{
					treeViewMorphClip.SelectedNode = node;
					node.EnsureVisible();
				}
			}
		}

		private void checkBoxStartEndKeyframe_Click(object sender, EventArgs e)
		{
			try
			{
				CheckBox origin = (CheckBox)sender;
				if (!origin.Checked)
				{
					Tuple<RenderObjectXX, xxFrame, xaMorphIndexSet> tuple = (Tuple<RenderObjectXX, xxFrame, xaMorphIndexSet>)origin.Tag;
					if (tuple != null)
					{
						float morphFactor = tuple.Item1.UnsetMorphKeyframe(tuple.Item2, tuple.Item3, sender == checkBoxStartKeyframe);
						Gui.Renderer.Render();
						trackBarMorphFactor.ValueChanged -= trackBarMorphFactor_ValueChanged;
						trackBarMorphFactor.Value = (int)(trackBarMorphFactor.Maximum * morphFactor);
						trackBarMorphFactor.ValueChanged += trackBarMorphFactor_ValueChanged;
					}
					origin.Text = sender == checkBoxStartKeyframe ? "Start" : "End";
					return;
				}

				if (treeViewMorphClip.SelectedNode == null || !(treeViewMorphClip.SelectedNode.Tag is xaMorphKeyframeRef))
					return;

				xaMorphClip clip = (xaMorphClip)treeViewMorphClip.SelectedNode.Parent.Tag;
				xaMorphKeyframeRef morphRef = (xaMorphKeyframeRef)treeViewMorphClip.SelectedNode.Tag;
				List<DockContent> formXXList;
				if (Gui.Docking.DockContents.TryGetValue(typeof(FormXX), out formXXList))
				{
					foreach (FormXX form in formXXList)
					{
						for (int i = 0; i < form.renderObjectMeshes.Count; i++)
						{
							RenderObjectXX renderObj = form.renderObjectMeshes[i];
							if (renderObj != null && clip.MeshName == form.Editor.Meshes[i].Name)
							{
								xaMorphIndexSet idxSet = xa.FindMorphIndexSet(clip.Name, Editor.Parser.MorphSection);
								xaMorphKeyframe keyframe = xa.FindMorphKeyFrame(morphRef.Name, Editor.Parser.MorphSection);
								float morphFactor = renderObj.SetMorphKeyframe(form.Editor.Meshes[i], idxSet, keyframe, sender == checkBoxStartKeyframe);
								origin.Tag = new Tuple<RenderObjectXX, xxFrame, xaMorphIndexSet>(renderObj, form.Editor.Meshes[i], idxSet);
								Gui.Renderer.Render();
								trackBarMorphFactor.ValueChanged -= trackBarMorphFactor_ValueChanged;
								trackBarMorphFactor.Value = (int)(trackBarMorphFactor.Maximum * morphFactor);
								trackBarMorphFactor.ValueChanged += trackBarMorphFactor_ValueChanged;
								origin.Text = keyframe.Name;
								toolTip1.SetToolTip(origin, Graphics.FromHwnd(Handle).MeasureString(origin.Text, origin.Font).Width >= origin.Width - 6 ? origin.Text : null);
								return;
							}
						}
					}
				}
				Report.ReportLog("Mesh " + clip.MeshName + " not found.");
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void trackBarMorphFactor_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				Tuple<RenderObjectXX, xxFrame, xaMorphIndexSet> tuple = (Tuple<RenderObjectXX, xxFrame, xaMorphIndexSet>)checkBoxStartKeyframe.Tag;
				if (tuple != null)
				{
					tuple.Item1.SetTweenFactor(tuple.Item2, tuple.Item3, trackBarMorphFactor.Value / (float)trackBarMorphFactor.Maximum);
					Gui.Renderer.Render();
				}
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void buttonDeleteKeyframe_Click(object sender, EventArgs e)
		{
			try
			{
				if (listViewMorphKeyframe.SelectedItems.Count < 1)
				{
					return;
				}
				xaMorphKeyframe keyframe = (xaMorphKeyframe)listViewMorphKeyframe.SelectedItems[0].Tag;
				string refInClip = String.Empty;
				foreach (xaMorphClip clip in Editor.Parser.MorphSection.ClipList)
				{
					foreach (xaMorphKeyframeRef morphRef in clip.KeyframeRefList)
					{
						if (morphRef.Name == keyframe.Name)
						{
							refInClip += clip.Name + ", ";
							break;
						}
					}
				}
				if (refInClip.Length > 0)
				{
					Report.ReportLog("Keyframe " + keyframe.Name + " is referenced in morph clips : " + refInClip.Substring(0, refInClip.Length - 2));
					return;
				}

				Gui.Scripting.RunScript(EditorVar + ".RemoveMorphKeyframe(name=\"" + keyframe.Name + "\")");

				RefreshMorphs();
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void listViewAnimationTrack_ItemDrag(object sender, ItemDragEventArgs e)
		{
			try
			{
				if (e.Item is TreeNode)
				{
					listViewAnimationTrack.DoDragDrop(e.Item, DragDropEffects.Copy);
				}
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void listViewAnimationTrack_DragEnter(object sender, DragEventArgs e)
		{
			try
			{
				UpdateDragDropAnimations(sender, e);
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void listViewAnimationTrack_DragOver(object sender, DragEventArgs e)
		{
			try
			{
				UpdateDragDropAnimations(sender, e);
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void listViewAnimationTrack_DragDrop(object sender, DragEventArgs e)
		{
			try
			{
				TreeNode node = (TreeNode)e.Data.GetData(typeof(TreeNode));
				if (node == null)
				{
					Gui.Docking.DockDragDrop(sender, e);
				}
				else
				{
					ProcessDragDropAnimations(node);
				}
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void ProcessDragDropAnimations(TreeNode node)
		{
			if (node.Tag is DragSource)
			{
				if ((node.Parent != null) && !node.Checked && node.StateImageIndex != (int)CheckState.Indeterminate)
				{
					return;
				}

				DragSource source = (DragSource)node.Tag;
				if (source.Type == typeof(WorkspaceAnimation))
				{
					var srcEditor = (ImportedEditor)Gui.Scripting.Variables[source.Variable];
					WorkspaceAnimation wsAnimation = srcEditor.Animations[(int)source.Id];
					if (!(wsAnimation.importedAnimation is ImportedKeyframedAnimation))
					{
						Report.ReportLog("The animation has incompatible keyframes.");
						return;
					}
					using (var dragOptions = new FormXADragDrop(Editor, false))
					{
						List<ImportedAnimationKeyframedTrack> trackList = ((ImportedKeyframedAnimation)wsAnimation.importedAnimation).TrackList;
						int resampleCount = trackList[0].Keyframes.Length;
						for (int i = 0; i < trackList.Count; i++)
						{
							ImportedAnimationKeyframedTrack track = trackList[i];
							int numKeyframes = 0;
							for (int j = 0; j < track.Keyframes.Length; j++)
							{
								if (track.Keyframes[j] == null)
									continue;
								numKeyframes++;
							}
							if (numKeyframes != resampleCount)
							{
								resampleCount = -1;
								break;
							}
						}
						dragOptions.numericResample.Value = resampleCount;
						dragOptions.comboBoxMethod.SelectedIndex = (int)ReplaceAnimationMethod.ReplacePresent;
						if (dragOptions.ShowDialog() == DialogResult.OK)
						{
							// repeating only final choices for repeatability of the script
							foreach (ImportedAnimationKeyframedTrack track in trackList)
							{
								if (!wsAnimation.isTrackEnabled(track))
								{
									Gui.Scripting.RunScript(source.Variable + ".setTrackEnabled(animationId=" + (int)source.Id + ", id=" + trackList.IndexOf(track) + ", enabled=false)");
								}
							}
							Gui.Scripting.RunScript(EditorVar + ".ReplaceAnimation(animation=" + source.Variable + ".Animations[" + (int)source.Id + "], resampleCount=" + dragOptions.numericResample.Value + ", method=\"" + dragOptions.comboBoxMethod.SelectedItem + "\", insertPos=" + dragOptions.numericPosition.Value + ")");
							UnloadXA();
							LoadXA();
						}
					}
				}
			}
			else
			{
				foreach (TreeNode child in node.Nodes)
				{
					ProcessDragDropAnimations(child);
				}
			}
		}

		private void UpdateDragDropAnimations(object sender, DragEventArgs e)
		{
			Point p = listViewAnimationTrack.PointToClient(new Point(e.X, e.Y));
			ListViewItem target = listViewAnimationTrack.GetItemAt(p.X, p.Y);
			if ((target != null) && ((p.X < target.Bounds.Left) || (p.X > target.Bounds.Right) || (p.Y < target.Bounds.Top) || (p.Y > target.Bounds.Bottom)))
			{
				target = null;
			}

			if (target == null)
			{
				Gui.Docking.DockDragEnter(sender, e);
			}
			else
			{
				e.Effect = e.AllowedEffect & DragDropEffects.Copy;
			}
		}

		private void listViewAnimationTrack_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
		}

		private void listViewAnimationTrack_AfterLabelEdit(object sender, LabelEditEventArgs e)
		{
			try
			{
				if (e.Label != null)
				{
					string name = e.Label.Trim();
					if (name == String.Empty)
					{
						e.CancelEdit = true;
					}
					else
					{
						xaAnimationTrack keyframeList = (xaAnimationTrack)listViewAnimationTrack.Items[e.Item].Tag;
						Gui.Scripting.RunScript(EditorVar + ".RenameTrack(track=\"" + keyframeList.Name + "\", newName=\"" + e.Label.Trim() + "\")");
						UnloadXA();
						LoadXA();
					}
				}
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void buttonAnimationTrackRemove_Click(object sender, EventArgs e)
		{
			if (listViewAnimationTrack.SelectedItems.Count <= 0)
				return;

			try
			{
				foreach (ListViewItem item in listViewAnimationTrack.SelectedItems)
				{
					Gui.Scripting.RunScript(EditorVar + ".RemoveTrack(track=\"" + ((xaAnimationTrack)item.Tag).Name + "\")");
				}
				UnloadXA();
				LoadXA();
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void reopenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UnloadXA();
			ReopenXA();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Gui.Scripting.RunScript(EditorVar + ".SaveXA(path=\"" + this.ToolTipText + "\", backup=" + keepBackupToolStripMenuItem.Checked + ")");
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					Gui.Scripting.RunScript(EditorVar + ".SaveXA(path=\"" + saveFileDialog1.FileName + "\", backup=" + keepBackupToolStripMenuItem.Checked + ")");
				}
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void keepBackupToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				Gui.Config["KeepBackupOfXA"] = keepBackupToolStripMenuItem.Checked;
				propertiesChanged = true;
			}
			catch (Exception ex)
			{
				Utility.ReportException(ex);
			}
		}
	}
}
