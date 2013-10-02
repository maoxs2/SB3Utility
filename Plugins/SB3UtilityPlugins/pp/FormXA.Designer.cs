﻿namespace SB3Utility
{
	partial class FormXA
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			CustomDispose();

			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXA));
			this.tabControlXA = new System.Windows.Forms.TabControl();
			this.tabPageXAObjectView = new System.Windows.Forms.TabPage();
			this.splitContainer7 = new System.Windows.Forms.SplitContainer();
			this.treeViewXA = new System.Windows.Forms.TreeView();
			this.tableLayoutXAHex = new System.Windows.Forms.TableLayoutPanel();
			this.label42 = new System.Windows.Forms.Label();
			this.tabPageMaterial = new System.Windows.Forms.TabPage();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.xaMatNameText = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.labelType1ConfigPositionMax = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.numericType1ConfigPosition = new System.Windows.Forms.NumericUpDown();
			this.listViewType1 = new System.Windows.Forms.ListView();
			this.columnHeaderType1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label27 = new System.Windows.Forms.Label();
			this.xaMatUnknown = new System.Windows.Forms.TextBox();
			this.xaMatSpecularPower = new System.Windows.Forms.TextBox();
			this.xaMatEmissiveA = new System.Windows.Forms.TextBox();
			this.xaMatEmissiveB = new System.Windows.Forms.TextBox();
			this.xaMatEmissiveG = new System.Windows.Forms.TextBox();
			this.xaMatEmissiveR = new System.Windows.Forms.TextBox();
			this.xaMatSpecularA = new System.Windows.Forms.TextBox();
			this.xaMatSpecularB = new System.Windows.Forms.TextBox();
			this.xaMatSpecularG = new System.Windows.Forms.TextBox();
			this.xaMatSpecularR = new System.Windows.Forms.TextBox();
			this.xaMatAmbientA = new System.Windows.Forms.TextBox();
			this.xaMatAmbientB = new System.Windows.Forms.TextBox();
			this.xaMatAmbientG = new System.Windows.Forms.TextBox();
			this.xaMatAmbientR = new System.Windows.Forms.TextBox();
			this.xaMatDiffuseA = new System.Windows.Forms.TextBox();
			this.xaMatDiffuseB = new System.Windows.Forms.TextBox();
			this.xaMatDiffuseG = new System.Windows.Forms.TextBox();
			this.xaMatDiffuseR = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.tabPageType2 = new System.Windows.Forms.TabPage();
			this.tabPageMorph = new System.Windows.Forms.TabPage();
			this.splitContainerMorph = new System.Windows.Forms.SplitContainer();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.buttonRefDown = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.buttonRefUp = new System.Windows.Forms.Button();
			this.buttonDeleteRef = new System.Windows.Forms.Button();
			this.textBoxFrameNameRefID = new SB3Utility.EditTextBox();
			this.buttonNewRef = new System.Windows.Forms.Button();
			this.checkBoxOnlyValidKeyframes = new System.Windows.Forms.CheckBox();
			this.comboBoxRefKeyframe = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.editTextBoxMorphClipMesh = new SB3Utility.EditTextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.editTextBoxMorphClipName = new SB3Utility.EditTextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.checkBoxFbxOptionEmbedMedia = new System.Windows.Forms.CheckBox();
			this.checkBoxFbxOptionOneBlendshape = new System.Windows.Forms.CheckBox();
			this.comboBoxMorphExportFormat = new System.Windows.Forms.ComboBox();
			this.buttonMorphClipExport = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBoxMorphMesh = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.treeViewMorphClip = new System.Windows.Forms.TreeView();
			this.label57 = new System.Windows.Forms.Label();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.checkBoxEndKeyframe = new System.Windows.Forms.CheckBox();
			this.trackBarMorphFactor = new System.Windows.Forms.TrackBar();
			this.checkBoxStartKeyframe = new System.Windows.Forms.CheckBox();
			this.buttonDeleteKeyframe = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.editTextBoxNewKeyframeName = new SB3Utility.EditTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.listViewMorphKeyframe = new System.Windows.Forms.ListView();
			this.columnHeaderMorphKeyframeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderMorphKeyframeVertices = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabPageType4 = new System.Windows.Forms.TabPage();
			this.tabPageAnimation = new System.Windows.Forms.TabPage();
			this.splitContainerAnimation = new System.Windows.Forms.SplitContainer();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonAnimationTrackRemove = new System.Windows.Forms.Button();
			this.listViewAnimationTrack = new System.Windows.Forms.ListView();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonAnimationTrackNormalize = new System.Windows.Forms.Button();
			this.groupBox18 = new System.Windows.Forms.GroupBox();
			this.numericAnimationKeyframeEnd = new System.Windows.Forms.NumericUpDown();
			this.label45 = new System.Windows.Forms.Label();
			this.numericAnimationKeyframeStart = new System.Windows.Forms.NumericUpDown();
			this.label46 = new System.Windows.Forms.Label();
			this.buttonAnimationKeyframeRemove = new System.Windows.Forms.Button();
			this.buttonAnimationClipEditHex = new System.Windows.Forms.Button();
			this.dataGridViewAnimationClip = new System.Windows.Forms.DataGridView();
			this.label33 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.buttonAnimationClipDelete = new System.Windows.Forms.Button();
			this.buttonAnimationClipCopy = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.buttonAnimationClipMoveUp = new System.Windows.Forms.Button();
			this.buttonAnimationClipMoveDown = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonAnimationClipPlayPause = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.trackBarAnimationClipKeyframe = new System.Windows.Forms.TrackBar();
			this.checkBoxAnimationClipLoadNextClip = new System.Windows.Forms.CheckBox();
			this.numericAnimationClipSpeed = new System.Windows.Forms.NumericUpDown();
			this.numericAnimationClipKeyframe = new System.Windows.Forms.NumericUpDown();
			this.labelSkeletalRender = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reopenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.keepBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAnimationClipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAnimationClipStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAnimationClipEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAnimationClipNext = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAnimationClipSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAnimationClipUnknown1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAnimationClipRest = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControlXA.SuspendLayout();
			this.tabPageXAObjectView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
			this.splitContainer7.Panel1.SuspendLayout();
			this.splitContainer7.Panel2.SuspendLayout();
			this.splitContainer7.SuspendLayout();
			this.tabPageMaterial.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericType1ConfigPosition)).BeginInit();
			this.tabPageMorph.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMorph)).BeginInit();
			this.splitContainerMorph.Panel1.SuspendLayout();
			this.splitContainerMorph.Panel2.SuspendLayout();
			this.splitContainerMorph.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarMorphFactor)).BeginInit();
			this.tabPageAnimation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerAnimation)).BeginInit();
			this.splitContainerAnimation.Panel1.SuspendLayout();
			this.splitContainerAnimation.Panel2.SuspendLayout();
			this.splitContainerAnimation.SuspendLayout();
			this.groupBox18.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericAnimationKeyframeEnd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericAnimationKeyframeStart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimationClip)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarAnimationClipKeyframe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericAnimationClipSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericAnimationClipKeyframe)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlXA
			// 
			this.tabControlXA.Controls.Add(this.tabPageXAObjectView);
			this.tabControlXA.Controls.Add(this.tabPageMaterial);
			this.tabControlXA.Controls.Add(this.tabPageType2);
			this.tabControlXA.Controls.Add(this.tabPageMorph);
			this.tabControlXA.Controls.Add(this.tabPageType4);
			this.tabControlXA.Controls.Add(this.tabPageAnimation);
			this.tabControlXA.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlXA.Location = new System.Drawing.Point(0, 18);
			this.tabControlXA.Name = "tabControlXA";
			this.tabControlXA.SelectedIndex = 0;
			this.tabControlXA.Size = new System.Drawing.Size(524, 518);
			this.tabControlXA.TabIndex = 104;
			// 
			// tabPageXAObjectView
			// 
			this.tabPageXAObjectView.Controls.Add(this.splitContainer7);
			this.tabPageXAObjectView.Location = new System.Drawing.Point(4, 22);
			this.tabPageXAObjectView.Name = "tabPageXAObjectView";
			this.tabPageXAObjectView.Size = new System.Drawing.Size(516, 492);
			this.tabPageXAObjectView.TabIndex = 2;
			this.tabPageXAObjectView.Text = "Object Tree";
			this.tabPageXAObjectView.UseVisualStyleBackColor = true;
			// 
			// splitContainer7
			// 
			this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer7.Location = new System.Drawing.Point(0, 0);
			this.splitContainer7.Name = "splitContainer7";
			// 
			// splitContainer7.Panel1
			// 
			this.splitContainer7.Panel1.Controls.Add(this.treeViewXA);
			// 
			// splitContainer7.Panel2
			// 
			this.splitContainer7.Panel2.Controls.Add(this.tableLayoutXAHex);
			this.splitContainer7.Panel2.Controls.Add(this.label42);
			this.splitContainer7.Size = new System.Drawing.Size(516, 492);
			this.splitContainer7.SplitterDistance = 227;
			this.splitContainer7.TabIndex = 0;
			// 
			// treeViewXA
			// 
			this.treeViewXA.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewXA.HideSelection = false;
			this.treeViewXA.Location = new System.Drawing.Point(0, 0);
			this.treeViewXA.Name = "treeViewXA";
			this.treeViewXA.Size = new System.Drawing.Size(227, 492);
			this.treeViewXA.TabIndex = 37;
			// 
			// tableLayoutXAHex
			// 
			this.tableLayoutXAHex.ColumnCount = 2;
			this.tableLayoutXAHex.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutXAHex.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutXAHex.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutXAHex.Location = new System.Drawing.Point(0, 20);
			this.tableLayoutXAHex.Name = "tableLayoutXAHex";
			this.tableLayoutXAHex.RowCount = 1;
			this.tableLayoutXAHex.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutXAHex.Size = new System.Drawing.Size(285, 472);
			this.tableLayoutXAHex.TabIndex = 92;
			// 
			// label42
			// 
			this.label42.Dock = System.Windows.Forms.DockStyle.Top;
			this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label42.Location = new System.Drawing.Point(0, 0);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(285, 20);
			this.label42.TabIndex = 91;
			this.label42.Text = "description [size]";
			this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabPageMaterial
			// 
			this.tabPageMaterial.Controls.Add(this.label13);
			this.tabPageMaterial.Controls.Add(this.label14);
			this.tabPageMaterial.Controls.Add(this.label17);
			this.tabPageMaterial.Controls.Add(this.label18);
			this.tabPageMaterial.Controls.Add(this.xaMatNameText);
			this.tabPageMaterial.Controls.Add(this.label29);
			this.tabPageMaterial.Controls.Add(this.labelType1ConfigPositionMax);
			this.tabPageMaterial.Controls.Add(this.label28);
			this.tabPageMaterial.Controls.Add(this.numericType1ConfigPosition);
			this.tabPageMaterial.Controls.Add(this.listViewType1);
			this.tabPageMaterial.Controls.Add(this.label27);
			this.tabPageMaterial.Controls.Add(this.xaMatUnknown);
			this.tabPageMaterial.Controls.Add(this.xaMatSpecularPower);
			this.tabPageMaterial.Controls.Add(this.xaMatEmissiveA);
			this.tabPageMaterial.Controls.Add(this.xaMatEmissiveB);
			this.tabPageMaterial.Controls.Add(this.xaMatEmissiveG);
			this.tabPageMaterial.Controls.Add(this.xaMatEmissiveR);
			this.tabPageMaterial.Controls.Add(this.xaMatSpecularA);
			this.tabPageMaterial.Controls.Add(this.xaMatSpecularB);
			this.tabPageMaterial.Controls.Add(this.xaMatSpecularG);
			this.tabPageMaterial.Controls.Add(this.xaMatSpecularR);
			this.tabPageMaterial.Controls.Add(this.xaMatAmbientA);
			this.tabPageMaterial.Controls.Add(this.xaMatAmbientB);
			this.tabPageMaterial.Controls.Add(this.xaMatAmbientG);
			this.tabPageMaterial.Controls.Add(this.xaMatAmbientR);
			this.tabPageMaterial.Controls.Add(this.xaMatDiffuseA);
			this.tabPageMaterial.Controls.Add(this.xaMatDiffuseB);
			this.tabPageMaterial.Controls.Add(this.xaMatDiffuseG);
			this.tabPageMaterial.Controls.Add(this.xaMatDiffuseR);
			this.tabPageMaterial.Controls.Add(this.label2);
			this.tabPageMaterial.Controls.Add(this.label7);
			this.tabPageMaterial.Controls.Add(this.label12);
			this.tabPageMaterial.Controls.Add(this.label15);
			this.tabPageMaterial.Controls.Add(this.label16);
			this.tabPageMaterial.Location = new System.Drawing.Point(4, 22);
			this.tabPageMaterial.Name = "tabPageMaterial";
			this.tabPageMaterial.Size = new System.Drawing.Size(516, 492);
			this.tabPageMaterial.TabIndex = 3;
			this.tabPageMaterial.Text = "Material";
			this.tabPageMaterial.UseVisualStyleBackColor = true;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(471, 157);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(14, 13);
			this.label13.TabIndex = 73;
			this.label13.Text = "A";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(406, 157);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(14, 13);
			this.label14.TabIndex = 72;
			this.label14.Text = "B";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(344, 157);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(15, 13);
			this.label17.TabIndex = 71;
			this.label17.Text = "G";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(276, 157);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(15, 13);
			this.label18.TabIndex = 70;
			this.label18.Text = "R";
			// 
			// xaMatNameText
			// 
			this.xaMatNameText.Location = new System.Drawing.Point(251, 26);
			this.xaMatNameText.Name = "xaMatNameText";
			this.xaMatNameText.Size = new System.Drawing.Size(257, 20);
			this.xaMatNameText.TabIndex = 67;
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(189, 29);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(35, 13);
			this.label29.TabIndex = 68;
			this.label29.Text = "Name";
			// 
			// labelType1ConfigPositionMax
			// 
			this.labelType1ConfigPositionMax.AutoSize = true;
			this.labelType1ConfigPositionMax.Location = new System.Drawing.Point(332, 124);
			this.labelType1ConfigPositionMax.Name = "labelType1ConfigPositionMax";
			this.labelType1ConfigPositionMax.Size = new System.Drawing.Size(21, 13);
			this.labelType1ConfigPositionMax.TabIndex = 66;
			this.labelType1ConfigPositionMax.Text = "/ 0";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(189, 122);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(77, 13);
			this.label28.TabIndex = 65;
			this.label28.Text = "Config Number";
			// 
			// numericType1ConfigPosition
			// 
			this.numericType1ConfigPosition.Location = new System.Drawing.Point(272, 120);
			this.numericType1ConfigPosition.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericType1ConfigPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericType1ConfigPosition.Name = "numericType1ConfigPosition";
			this.numericType1ConfigPosition.Size = new System.Drawing.Size(57, 20);
			this.numericType1ConfigPosition.TabIndex = 64;
			this.numericType1ConfigPosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericType1ConfigPosition.ValueChanged += new System.EventHandler(this.numericType1ConfigPosition_ValueChanged);
			// 
			// listViewType1
			// 
			this.listViewType1.AutoArrange = false;
			this.listViewType1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderType1});
			this.listViewType1.FullRowSelect = true;
			this.listViewType1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewType1.HideSelection = false;
			this.listViewType1.LabelWrap = false;
			this.listViewType1.Location = new System.Drawing.Point(3, 4);
			this.listViewType1.Name = "listViewType1";
			this.listViewType1.ShowGroups = false;
			this.listViewType1.ShowItemToolTips = true;
			this.listViewType1.Size = new System.Drawing.Size(183, 436);
			this.listViewType1.TabIndex = 63;
			this.listViewType1.UseCompatibleStateImageBehavior = false;
			this.listViewType1.View = System.Windows.Forms.View.Details;
			this.listViewType1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewType1_ItemSelectionChanged);
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(189, 296);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(53, 13);
			this.label27.TabIndex = 62;
			this.label27.Text = "Unknown";
			// 
			// xaMatUnknown
			// 
			this.xaMatUnknown.Location = new System.Drawing.Point(251, 293);
			this.xaMatUnknown.Name = "xaMatUnknown";
			this.xaMatUnknown.Size = new System.Drawing.Size(62, 20);
			this.xaMatUnknown.TabIndex = 61;
			// 
			// xaMatSpecularPower
			// 
			this.xaMatSpecularPower.Location = new System.Drawing.Point(251, 269);
			this.xaMatSpecularPower.Name = "xaMatSpecularPower";
			this.xaMatSpecularPower.Size = new System.Drawing.Size(62, 20);
			this.xaMatSpecularPower.TabIndex = 60;
			// 
			// xaMatEmissiveA
			// 
			this.xaMatEmissiveA.Location = new System.Drawing.Point(446, 221);
			this.xaMatEmissiveA.Name = "xaMatEmissiveA";
			this.xaMatEmissiveA.Size = new System.Drawing.Size(62, 20);
			this.xaMatEmissiveA.TabIndex = 59;
			// 
			// xaMatEmissiveB
			// 
			this.xaMatEmissiveB.Location = new System.Drawing.Point(381, 221);
			this.xaMatEmissiveB.Name = "xaMatEmissiveB";
			this.xaMatEmissiveB.Size = new System.Drawing.Size(62, 20);
			this.xaMatEmissiveB.TabIndex = 58;
			// 
			// xaMatEmissiveG
			// 
			this.xaMatEmissiveG.Location = new System.Drawing.Point(316, 221);
			this.xaMatEmissiveG.Name = "xaMatEmissiveG";
			this.xaMatEmissiveG.Size = new System.Drawing.Size(62, 20);
			this.xaMatEmissiveG.TabIndex = 57;
			// 
			// xaMatEmissiveR
			// 
			this.xaMatEmissiveR.Location = new System.Drawing.Point(251, 221);
			this.xaMatEmissiveR.Name = "xaMatEmissiveR";
			this.xaMatEmissiveR.Size = new System.Drawing.Size(62, 20);
			this.xaMatEmissiveR.TabIndex = 56;
			// 
			// xaMatSpecularA
			// 
			this.xaMatSpecularA.Location = new System.Drawing.Point(446, 245);
			this.xaMatSpecularA.Name = "xaMatSpecularA";
			this.xaMatSpecularA.Size = new System.Drawing.Size(62, 20);
			this.xaMatSpecularA.TabIndex = 55;
			// 
			// xaMatSpecularB
			// 
			this.xaMatSpecularB.Location = new System.Drawing.Point(381, 245);
			this.xaMatSpecularB.Name = "xaMatSpecularB";
			this.xaMatSpecularB.Size = new System.Drawing.Size(62, 20);
			this.xaMatSpecularB.TabIndex = 54;
			// 
			// xaMatSpecularG
			// 
			this.xaMatSpecularG.Location = new System.Drawing.Point(316, 245);
			this.xaMatSpecularG.Name = "xaMatSpecularG";
			this.xaMatSpecularG.Size = new System.Drawing.Size(62, 20);
			this.xaMatSpecularG.TabIndex = 53;
			// 
			// xaMatSpecularR
			// 
			this.xaMatSpecularR.Location = new System.Drawing.Point(251, 245);
			this.xaMatSpecularR.Name = "xaMatSpecularR";
			this.xaMatSpecularR.Size = new System.Drawing.Size(62, 20);
			this.xaMatSpecularR.TabIndex = 52;
			// 
			// xaMatAmbientA
			// 
			this.xaMatAmbientA.Location = new System.Drawing.Point(446, 197);
			this.xaMatAmbientA.Name = "xaMatAmbientA";
			this.xaMatAmbientA.Size = new System.Drawing.Size(62, 20);
			this.xaMatAmbientA.TabIndex = 51;
			// 
			// xaMatAmbientB
			// 
			this.xaMatAmbientB.Location = new System.Drawing.Point(381, 197);
			this.xaMatAmbientB.Name = "xaMatAmbientB";
			this.xaMatAmbientB.Size = new System.Drawing.Size(62, 20);
			this.xaMatAmbientB.TabIndex = 50;
			// 
			// xaMatAmbientG
			// 
			this.xaMatAmbientG.Location = new System.Drawing.Point(316, 197);
			this.xaMatAmbientG.Name = "xaMatAmbientG";
			this.xaMatAmbientG.Size = new System.Drawing.Size(62, 20);
			this.xaMatAmbientG.TabIndex = 49;
			// 
			// xaMatAmbientR
			// 
			this.xaMatAmbientR.Location = new System.Drawing.Point(251, 197);
			this.xaMatAmbientR.Name = "xaMatAmbientR";
			this.xaMatAmbientR.Size = new System.Drawing.Size(62, 20);
			this.xaMatAmbientR.TabIndex = 48;
			// 
			// xaMatDiffuseA
			// 
			this.xaMatDiffuseA.Location = new System.Drawing.Point(446, 173);
			this.xaMatDiffuseA.Name = "xaMatDiffuseA";
			this.xaMatDiffuseA.Size = new System.Drawing.Size(62, 20);
			this.xaMatDiffuseA.TabIndex = 47;
			// 
			// xaMatDiffuseB
			// 
			this.xaMatDiffuseB.Location = new System.Drawing.Point(381, 173);
			this.xaMatDiffuseB.Name = "xaMatDiffuseB";
			this.xaMatDiffuseB.Size = new System.Drawing.Size(62, 20);
			this.xaMatDiffuseB.TabIndex = 46;
			// 
			// xaMatDiffuseG
			// 
			this.xaMatDiffuseG.Location = new System.Drawing.Point(316, 173);
			this.xaMatDiffuseG.Name = "xaMatDiffuseG";
			this.xaMatDiffuseG.Size = new System.Drawing.Size(62, 20);
			this.xaMatDiffuseG.TabIndex = 45;
			// 
			// xaMatDiffuseR
			// 
			this.xaMatDiffuseR.Location = new System.Drawing.Point(251, 173);
			this.xaMatDiffuseR.Name = "xaMatDiffuseR";
			this.xaMatDiffuseR.Size = new System.Drawing.Size(62, 20);
			this.xaMatDiffuseR.TabIndex = 44;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(189, 225);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 43;
			this.label2.Text = "Emissive";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(189, 272);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 13);
			this.label7.TabIndex = 42;
			this.label7.Text = "Specular";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(189, 248);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(49, 13);
			this.label12.TabIndex = 41;
			this.label12.Text = "Specular";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(190, 200);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(45, 13);
			this.label15.TabIndex = 40;
			this.label15.Text = "Ambient";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(190, 176);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(40, 13);
			this.label16.TabIndex = 39;
			this.label16.Text = "Diffuse";
			// 
			// tabPageType2
			// 
			this.tabPageType2.Location = new System.Drawing.Point(4, 22);
			this.tabPageType2.Name = "tabPageType2";
			this.tabPageType2.Size = new System.Drawing.Size(516, 492);
			this.tabPageType2.TabIndex = 4;
			this.tabPageType2.Text = "Type2";
			this.tabPageType2.UseVisualStyleBackColor = true;
			// 
			// tabPageMorph
			// 
			this.tabPageMorph.Controls.Add(this.splitContainerMorph);
			this.tabPageMorph.Location = new System.Drawing.Point(4, 22);
			this.tabPageMorph.Name = "tabPageMorph";
			this.tabPageMorph.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageMorph.Size = new System.Drawing.Size(516, 492);
			this.tabPageMorph.TabIndex = 0;
			this.tabPageMorph.Text = "Morph";
			this.tabPageMorph.UseVisualStyleBackColor = true;
			// 
			// splitContainerMorph
			// 
			this.splitContainerMorph.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerMorph.Location = new System.Drawing.Point(3, 3);
			this.splitContainerMorph.Name = "splitContainerMorph";
			this.splitContainerMorph.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainerMorph.Panel1
			// 
			this.splitContainerMorph.Panel1.Controls.Add(this.groupBox10);
			this.splitContainerMorph.Panel1.Controls.Add(this.groupBox9);
			this.splitContainerMorph.Panel1.Controls.Add(this.groupBox5);
			this.splitContainerMorph.Panel1.Controls.Add(this.treeViewMorphClip);
			this.splitContainerMorph.Panel1.Controls.Add(this.label57);
			this.splitContainerMorph.Panel1.Controls.Add(this.groupBox7);
			// 
			// splitContainerMorph.Panel2
			// 
			this.splitContainerMorph.Panel2.Controls.Add(this.buttonDeleteKeyframe);
			this.splitContainerMorph.Panel2.Controls.Add(this.label9);
			this.splitContainerMorph.Panel2.Controls.Add(this.editTextBoxNewKeyframeName);
			this.splitContainerMorph.Panel2.Controls.Add(this.label3);
			this.splitContainerMorph.Panel2.Controls.Add(this.listViewMorphKeyframe);
			this.splitContainerMorph.Size = new System.Drawing.Size(510, 486);
			this.splitContainerMorph.SplitterDistance = 374;
			this.splitContainerMorph.TabIndex = 123;
			// 
			// groupBox10
			// 
			this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox10.Controls.Add(this.buttonRefDown);
			this.groupBox10.Controls.Add(this.label8);
			this.groupBox10.Controls.Add(this.buttonRefUp);
			this.groupBox10.Controls.Add(this.buttonDeleteRef);
			this.groupBox10.Controls.Add(this.textBoxFrameNameRefID);
			this.groupBox10.Controls.Add(this.buttonNewRef);
			this.groupBox10.Controls.Add(this.checkBoxOnlyValidKeyframes);
			this.groupBox10.Controls.Add(this.comboBoxRefKeyframe);
			this.groupBox10.Controls.Add(this.label6);
			this.groupBox10.Location = new System.Drawing.Point(322, 79);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(188, 161);
			this.groupBox10.TabIndex = 100;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "Morh Keyframe Reference";
			// 
			// buttonRefDown
			// 
			this.buttonRefDown.Location = new System.Drawing.Point(6, 134);
			this.buttonRefDown.Name = "buttonRefDown";
			this.buttonRefDown.Size = new System.Drawing.Size(75, 23);
			this.buttonRefDown.TabIndex = 118;
			this.buttonRefDown.Text = "Down";
			this.buttonRefDown.UseVisualStyleBackColor = true;
			this.buttonRefDown.Click += new System.EventHandler(this.buttonRefDown_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(71, 13);
			this.label8.TabIndex = 129;
			this.label8.Text = "Reference ID";
			// 
			// buttonRefUp
			// 
			this.buttonRefUp.Location = new System.Drawing.Point(6, 105);
			this.buttonRefUp.Name = "buttonRefUp";
			this.buttonRefUp.Size = new System.Drawing.Size(75, 23);
			this.buttonRefUp.TabIndex = 116;
			this.buttonRefUp.Text = "Up";
			this.buttonRefUp.UseVisualStyleBackColor = true;
			this.buttonRefUp.Click += new System.EventHandler(this.buttonRefUp_Click);
			// 
			// buttonDeleteRef
			// 
			this.buttonDeleteRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDeleteRef.Location = new System.Drawing.Point(107, 134);
			this.buttonDeleteRef.Name = "buttonDeleteRef";
			this.buttonDeleteRef.Size = new System.Drawing.Size(75, 23);
			this.buttonDeleteRef.TabIndex = 122;
			this.buttonDeleteRef.Text = "Delete";
			this.buttonDeleteRef.UseVisualStyleBackColor = true;
			this.buttonDeleteRef.Click += new System.EventHandler(this.buttonDeleteRef_Click);
			// 
			// textBoxFrameNameRefID
			// 
			this.textBoxFrameNameRefID.Enabled = false;
			this.textBoxFrameNameRefID.Location = new System.Drawing.Point(80, 13);
			this.textBoxFrameNameRefID.Name = "textBoxFrameNameRefID";
			this.textBoxFrameNameRefID.Size = new System.Drawing.Size(36, 20);
			this.textBoxFrameNameRefID.TabIndex = 110;
			this.textBoxFrameNameRefID.AfterEditTextChanged += new System.EventHandler(this.textBoxFrameNameRefID_AfterEditTextChanged);
			// 
			// buttonNewRef
			// 
			this.buttonNewRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonNewRef.Location = new System.Drawing.Point(107, 104);
			this.buttonNewRef.Name = "buttonNewRef";
			this.buttonNewRef.Size = new System.Drawing.Size(75, 23);
			this.buttonNewRef.TabIndex = 120;
			this.buttonNewRef.Text = "New Ref";
			this.buttonNewRef.UseVisualStyleBackColor = true;
			this.buttonNewRef.Click += new System.EventHandler(this.buttonNewRef_Click);
			// 
			// checkBoxOnlyValidKeyframes
			// 
			this.checkBoxOnlyValidKeyframes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxOnlyValidKeyframes.AutoSize = true;
			this.checkBoxOnlyValidKeyframes.Checked = true;
			this.checkBoxOnlyValidKeyframes.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxOnlyValidKeyframes.Location = new System.Drawing.Point(6, 82);
			this.checkBoxOnlyValidKeyframes.Name = "checkBoxOnlyValidKeyframes";
			this.checkBoxOnlyValidKeyframes.Size = new System.Drawing.Size(125, 17);
			this.checkBoxOnlyValidKeyframes.TabIndex = 114;
			this.checkBoxOnlyValidKeyframes.Text = "Only Valid Keyframes";
			this.checkBoxOnlyValidKeyframes.UseVisualStyleBackColor = true;
			this.checkBoxOnlyValidKeyframes.CheckedChanged += new System.EventHandler(this.checkBoxOnlyValidKeyframes_CheckedChanged);
			// 
			// comboBoxRefKeyframe
			// 
			this.comboBoxRefKeyframe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxRefKeyframe.Enabled = false;
			this.comboBoxRefKeyframe.FormattingEnabled = true;
			this.comboBoxRefKeyframe.Location = new System.Drawing.Point(6, 55);
			this.comboBoxRefKeyframe.Name = "comboBoxRefKeyframe";
			this.comboBoxRefKeyframe.Size = new System.Drawing.Size(179, 21);
			this.comboBoxRefKeyframe.TabIndex = 112;
			this.comboBoxRefKeyframe.SelectedIndexChanged += new System.EventHandler(this.comboBoxRefKeyframe_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 39);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 13);
			this.label6.TabIndex = 127;
			this.label6.Text = "Referencing Keyframe";
			// 
			// groupBox9
			// 
			this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox9.Controls.Add(this.editTextBoxMorphClipMesh);
			this.groupBox9.Controls.Add(this.label10);
			this.groupBox9.Controls.Add(this.label11);
			this.groupBox9.Controls.Add(this.editTextBoxMorphClipName);
			this.groupBox9.Location = new System.Drawing.Point(321, 5);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(188, 68);
			this.groupBox9.TabIndex = 90;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Morph Clip";
			// 
			// editTextBoxMorphClipMesh
			// 
			this.editTextBoxMorphClipMesh.Location = new System.Drawing.Point(48, 42);
			this.editTextBoxMorphClipMesh.Name = "editTextBoxMorphClipMesh";
			this.editTextBoxMorphClipMesh.Size = new System.Drawing.Size(134, 20);
			this.editTextBoxMorphClipMesh.TabIndex = 94;
			this.editTextBoxMorphClipMesh.AfterEditTextChanged += new System.EventHandler(this.editTextBoxMorphClipMesh_AfterEditTextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(7, 19);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(35, 13);
			this.label10.TabIndex = 138;
			this.label10.Text = "Name";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(7, 45);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(33, 13);
			this.label11.TabIndex = 140;
			this.label11.Text = "Mesh";
			// 
			// editTextBoxMorphClipName
			// 
			this.editTextBoxMorphClipName.Location = new System.Drawing.Point(48, 16);
			this.editTextBoxMorphClipName.Name = "editTextBoxMorphClipName";
			this.editTextBoxMorphClipName.Size = new System.Drawing.Size(134, 20);
			this.editTextBoxMorphClipName.TabIndex = 92;
			this.editTextBoxMorphClipName.AfterEditTextChanged += new System.EventHandler(this.editTextBoxMorphClipName_AfterEditTextChanged);
			// 
			// groupBox5
			// 
			this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox5.Controls.Add(this.groupBox8);
			this.groupBox5.Controls.Add(this.comboBoxMorphExportFormat);
			this.groupBox5.Controls.Add(this.buttonMorphClipExport);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Controls.Add(this.comboBoxMorphMesh);
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Location = new System.Drawing.Point(0, 292);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(509, 82);
			this.groupBox5.TabIndex = 140;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Export Options";
			// 
			// groupBox8
			// 
			this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox8.Controls.Add(this.checkBoxFbxOptionEmbedMedia);
			this.groupBox8.Controls.Add(this.checkBoxFbxOptionOneBlendshape);
			this.groupBox8.Location = new System.Drawing.Point(238, 40);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(215, 36);
			this.groupBox8.TabIndex = 143;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Fbx Options";
			// 
			// checkBoxFbxOptionEmbedMedia
			// 
			this.checkBoxFbxOptionEmbedMedia.AutoSize = true;
			this.checkBoxFbxOptionEmbedMedia.Location = new System.Drawing.Point(119, 15);
			this.checkBoxFbxOptionEmbedMedia.Name = "checkBoxFbxOptionEmbedMedia";
			this.checkBoxFbxOptionEmbedMedia.Size = new System.Drawing.Size(91, 17);
			this.checkBoxFbxOptionEmbedMedia.TabIndex = 145;
			this.checkBoxFbxOptionEmbedMedia.Text = "Embed Media";
			this.toolTip1.SetToolTip(this.checkBoxFbxOptionEmbedMedia, "Textures are stored inside the output file.");
			this.checkBoxFbxOptionEmbedMedia.UseVisualStyleBackColor = true;
			// 
			// checkBoxFbxOptionOneBlendshape
			// 
			this.checkBoxFbxOptionOneBlendshape.AutoSize = true;
			this.checkBoxFbxOptionOneBlendshape.Checked = true;
			this.checkBoxFbxOptionOneBlendshape.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxFbxOptionOneBlendshape.Location = new System.Drawing.Point(6, 15);
			this.checkBoxFbxOptionOneBlendshape.Name = "checkBoxFbxOptionOneBlendshape";
			this.checkBoxFbxOptionOneBlendshape.Size = new System.Drawing.Size(107, 17);
			this.checkBoxFbxOptionOneBlendshape.TabIndex = 144;
			this.checkBoxFbxOptionOneBlendshape.Text = "One BlendShape";
			this.toolTip1.SetToolTip(this.checkBoxFbxOptionOneBlendshape, "If checked, all morph keyframes appear as channels in one common BlendShape.\r\nIf " +
        "unchecked, each morph keyframe will appear as channel in it\'s own BlendShape.");
			this.checkBoxFbxOptionOneBlendshape.UseVisualStyleBackColor = true;
			// 
			// comboBoxMorphExportFormat
			// 
			this.comboBoxMorphExportFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxMorphExportFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMorphExportFormat.FormattingEnabled = true;
			this.comboBoxMorphExportFormat.Location = new System.Drawing.Point(133, 50);
			this.comboBoxMorphExportFormat.Name = "comboBoxMorphExportFormat";
			this.comboBoxMorphExportFormat.Size = new System.Drawing.Size(99, 21);
			this.comboBoxMorphExportFormat.TabIndex = 142;
			// 
			// buttonMorphClipExport
			// 
			this.buttonMorphClipExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMorphClipExport.Location = new System.Drawing.Point(411, 11);
			this.buttonMorphClipExport.Name = "buttonMorphClipExport";
			this.buttonMorphClipExport.Size = new System.Drawing.Size(92, 23);
			this.buttonMorphClipExport.TabIndex = 148;
			this.buttonMorphClipExport.Text = "Export Clip";
			this.buttonMorphClipExport.UseVisualStyleBackColor = true;
			this.buttonMorphClipExport.Click += new System.EventHandler(this.buttonMorphClipExport_Click);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(55, 53);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 13);
			this.label5.TabIndex = 125;
			this.label5.Text = "Export Format";
			// 
			// comboBoxMorphMesh
			// 
			this.comboBoxMorphMesh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxMorphMesh.DropDownHeight = 200;
			this.comboBoxMorphMesh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMorphMesh.FormattingEnabled = true;
			this.comboBoxMorphMesh.IntegralHeight = false;
			this.comboBoxMorphMesh.Location = new System.Drawing.Point(133, 13);
			this.comboBoxMorphMesh.Name = "comboBoxMorphMesh";
			this.comboBoxMorphMesh.Size = new System.Drawing.Size(259, 21);
			this.comboBoxMorphMesh.TabIndex = 141;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 17);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 13);
			this.label4.TabIndex = 123;
			this.label4.Text = ".xx File with Target Mesh";
			// 
			// treeViewMorphClip
			// 
			this.treeViewMorphClip.AllowDrop = true;
			this.treeViewMorphClip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeViewMorphClip.HideSelection = false;
			this.treeViewMorphClip.Location = new System.Drawing.Point(0, 18);
			this.treeViewMorphClip.Name = "treeViewMorphClip";
			this.treeViewMorphClip.Size = new System.Drawing.Size(315, 263);
			this.treeViewMorphClip.TabIndex = 80;
			this.treeViewMorphClip.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewMorphClip_ItemDrag);
			this.treeViewMorphClip.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMorphClip_AfterSelect);
			this.treeViewMorphClip.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewMorphClip_DragDrop);
			this.treeViewMorphClip.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeViewMorphClip_DragEnter);
			this.treeViewMorphClip.DragOver += new System.Windows.Forms.DragEventHandler(this.treeViewMorphClip_DragOver);
			// 
			// label57
			// 
			this.label57.AutoSize = true;
			this.label57.Location = new System.Drawing.Point(-1, 3);
			this.label57.Name = "label57";
			this.label57.Size = new System.Drawing.Size(128, 13);
			this.label57.TabIndex = 8;
			this.label57.Text = "Morph Clips [Mesh Name]";
			// 
			// groupBox7
			// 
			this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox7.Controls.Add(this.checkBoxEndKeyframe);
			this.groupBox7.Controls.Add(this.trackBarMorphFactor);
			this.groupBox7.Controls.Add(this.checkBoxStartKeyframe);
			this.groupBox7.Location = new System.Drawing.Point(322, 246);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(188, 65);
			this.groupBox7.TabIndex = 130;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Morph Keyrame Preview";
			// 
			// checkBoxEndKeyframe
			// 
			this.checkBoxEndKeyframe.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBoxEndKeyframe.Location = new System.Drawing.Point(95, 15);
			this.checkBoxEndKeyframe.Margin = new System.Windows.Forms.Padding(0);
			this.checkBoxEndKeyframe.Name = "checkBoxEndKeyframe";
			this.checkBoxEndKeyframe.Size = new System.Drawing.Size(89, 23);
			this.checkBoxEndKeyframe.TabIndex = 134;
			this.checkBoxEndKeyframe.Text = "End";
			this.checkBoxEndKeyframe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBoxEndKeyframe.UseVisualStyleBackColor = true;
			this.checkBoxEndKeyframe.Click += new System.EventHandler(this.checkBoxStartEndKeyframe_Click);
			// 
			// trackBarMorphFactor
			// 
			this.trackBarMorphFactor.AutoSize = false;
			this.trackBarMorphFactor.Location = new System.Drawing.Point(3, 41);
			this.trackBarMorphFactor.Maximum = 25;
			this.trackBarMorphFactor.Name = "trackBarMorphFactor";
			this.trackBarMorphFactor.Size = new System.Drawing.Size(178, 18);
			this.trackBarMorphFactor.TabIndex = 135;
			this.trackBarMorphFactor.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBarMorphFactor.ValueChanged += new System.EventHandler(this.trackBarMorphFactor_ValueChanged);
			// 
			// checkBoxStartKeyframe
			// 
			this.checkBoxStartKeyframe.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBoxStartKeyframe.Location = new System.Drawing.Point(4, 15);
			this.checkBoxStartKeyframe.Margin = new System.Windows.Forms.Padding(0);
			this.checkBoxStartKeyframe.Name = "checkBoxStartKeyframe";
			this.checkBoxStartKeyframe.Size = new System.Drawing.Size(89, 23);
			this.checkBoxStartKeyframe.TabIndex = 132;
			this.checkBoxStartKeyframe.Text = "Start";
			this.checkBoxStartKeyframe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBoxStartKeyframe.UseVisualStyleBackColor = true;
			this.checkBoxStartKeyframe.Click += new System.EventHandler(this.checkBoxStartEndKeyframe_Click);
			// 
			// buttonDeleteKeyframe
			// 
			this.buttonDeleteKeyframe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDeleteKeyframe.Location = new System.Drawing.Point(364, 75);
			this.buttonDeleteKeyframe.Name = "buttonDeleteKeyframe";
			this.buttonDeleteKeyframe.Size = new System.Drawing.Size(58, 23);
			this.buttonDeleteKeyframe.TabIndex = 168;
			this.buttonDeleteKeyframe.Text = "Delete";
			this.buttonDeleteKeyframe.UseVisualStyleBackColor = true;
			this.buttonDeleteKeyframe.Click += new System.EventHandler(this.buttonDeleteKeyframe_Click);
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(361, 17);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(63, 13);
			this.label9.TabIndex = 136;
			this.label9.Text = "Rename To";
			// 
			// editTextBoxNewKeyframeName
			// 
			this.editTextBoxNewKeyframeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.editTextBoxNewKeyframeName.Location = new System.Drawing.Point(364, 33);
			this.editTextBoxNewKeyframeName.Name = "editTextBoxNewKeyframeName";
			this.editTextBoxNewKeyframeName.Size = new System.Drawing.Size(139, 20);
			this.editTextBoxNewKeyframeName.TabIndex = 164;
			this.editTextBoxNewKeyframeName.AfterEditTextChanged += new System.EventHandler(this.editTextBoxNewKeyframeName_AfterEditTextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(-1, 2);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Morph Keyframes";
			// 
			// listViewMorphKeyframe
			// 
			this.listViewMorphKeyframe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listViewMorphKeyframe.AutoArrange = false;
			this.listViewMorphKeyframe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMorphKeyframeName,
            this.columnHeaderMorphKeyframeVertices});
			this.listViewMorphKeyframe.FullRowSelect = true;
			this.listViewMorphKeyframe.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewMorphKeyframe.HideSelection = false;
			this.listViewMorphKeyframe.LabelWrap = false;
			this.listViewMorphKeyframe.Location = new System.Drawing.Point(0, 17);
			this.listViewMorphKeyframe.MultiSelect = false;
			this.listViewMorphKeyframe.Name = "listViewMorphKeyframe";
			this.listViewMorphKeyframe.ShowGroups = false;
			this.listViewMorphKeyframe.ShowItemToolTips = true;
			this.listViewMorphKeyframe.Size = new System.Drawing.Size(358, 91);
			this.listViewMorphKeyframe.TabIndex = 160;
			this.listViewMorphKeyframe.UseCompatibleStateImageBehavior = false;
			this.listViewMorphKeyframe.View = System.Windows.Forms.View.Details;
			this.listViewMorphKeyframe.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewMorphKeyframe_ItemSelectionChanged);
			// 
			// columnHeaderMorphKeyframeName
			// 
			this.columnHeaderMorphKeyframeName.Text = "Name";
			this.columnHeaderMorphKeyframeName.Width = 144;
			// 
			// columnHeaderMorphKeyframeVertices
			// 
			this.columnHeaderMorphKeyframeVertices.Text = "Vertices";
			this.columnHeaderMorphKeyframeVertices.Width = 51;
			// 
			// tabPageType4
			// 
			this.tabPageType4.Location = new System.Drawing.Point(4, 22);
			this.tabPageType4.Name = "tabPageType4";
			this.tabPageType4.Size = new System.Drawing.Size(516, 492);
			this.tabPageType4.TabIndex = 5;
			this.tabPageType4.Text = "Type4";
			this.tabPageType4.UseVisualStyleBackColor = true;
			// 
			// tabPageAnimation
			// 
			this.tabPageAnimation.Controls.Add(this.splitContainerAnimation);
			this.tabPageAnimation.Location = new System.Drawing.Point(4, 22);
			this.tabPageAnimation.Name = "tabPageAnimation";
			this.tabPageAnimation.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAnimation.Size = new System.Drawing.Size(516, 492);
			this.tabPageAnimation.TabIndex = 1;
			this.tabPageAnimation.Text = "Animation";
			this.tabPageAnimation.UseVisualStyleBackColor = true;
			// 
			// splitContainerAnimation
			// 
			this.splitContainerAnimation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerAnimation.Location = new System.Drawing.Point(3, 3);
			this.splitContainerAnimation.Name = "splitContainerAnimation";
			this.splitContainerAnimation.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainerAnimation.Panel1
			// 
			this.splitContainerAnimation.Panel1.Controls.Add(this.label1);
			this.splitContainerAnimation.Panel1.Controls.Add(this.buttonAnimationTrackRemove);
			this.splitContainerAnimation.Panel1.Controls.Add(this.listViewAnimationTrack);
			this.splitContainerAnimation.Panel1.Controls.Add(this.buttonAnimationTrackNormalize);
			this.splitContainerAnimation.Panel1.Controls.Add(this.groupBox18);
			// 
			// splitContainerAnimation.Panel2
			// 
			this.splitContainerAnimation.Panel2.Controls.Add(this.buttonAnimationClipEditHex);
			this.splitContainerAnimation.Panel2.Controls.Add(this.dataGridViewAnimationClip);
			this.splitContainerAnimation.Panel2.Controls.Add(this.label33);
			this.splitContainerAnimation.Panel2.Controls.Add(this.groupBox3);
			this.splitContainerAnimation.Panel2.Controls.Add(this.groupBox2);
			this.splitContainerAnimation.Panel2.Controls.Add(this.groupBox1);
			this.splitContainerAnimation.Size = new System.Drawing.Size(510, 486);
			this.splitContainerAnimation.SplitterDistance = 197;
			this.splitContainerAnimation.TabIndex = 159;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(-1, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 153;
			this.label1.Text = "Animation Tracks";
			// 
			// buttonAnimationTrackRemove
			// 
			this.buttonAnimationTrackRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAnimationTrackRemove.Location = new System.Drawing.Point(409, 121);
			this.buttonAnimationTrackRemove.Name = "buttonAnimationTrackRemove";
			this.buttonAnimationTrackRemove.Size = new System.Drawing.Size(100, 23);
			this.buttonAnimationTrackRemove.TabIndex = 152;
			this.buttonAnimationTrackRemove.Text = "Remove Tracks";
			this.buttonAnimationTrackRemove.UseVisualStyleBackColor = true;
			this.buttonAnimationTrackRemove.Click += new System.EventHandler(this.buttonAnimationTrackRemove_Click);
			// 
			// listViewAnimationTrack
			// 
			this.listViewAnimationTrack.AllowDrop = true;
			this.listViewAnimationTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listViewAnimationTrack.AutoArrange = false;
			this.listViewAnimationTrack.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader1});
			this.listViewAnimationTrack.FullRowSelect = true;
			this.listViewAnimationTrack.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewAnimationTrack.HideSelection = false;
			this.listViewAnimationTrack.LabelEdit = true;
			this.listViewAnimationTrack.LabelWrap = false;
			this.listViewAnimationTrack.Location = new System.Drawing.Point(0, 17);
			this.listViewAnimationTrack.Name = "listViewAnimationTrack";
			this.listViewAnimationTrack.ShowGroups = false;
			this.listViewAnimationTrack.ShowItemToolTips = true;
			this.listViewAnimationTrack.Size = new System.Drawing.Size(403, 180);
			this.listViewAnimationTrack.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listViewAnimationTrack.TabIndex = 137;
			this.listViewAnimationTrack.UseCompatibleStateImageBehavior = false;
			this.listViewAnimationTrack.View = System.Windows.Forms.View.Details;
			this.listViewAnimationTrack.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listViewAnimationTrack_AfterLabelEdit);
			this.listViewAnimationTrack.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewAnimationTrack_ItemDrag);
			this.listViewAnimationTrack.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewAnimationTrack_ItemSelectionChanged);
			this.listViewAnimationTrack.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewAnimationTrack_DragDrop);
			this.listViewAnimationTrack.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewAnimationTrack_DragEnter);
			this.listViewAnimationTrack.DragOver += new System.Windows.Forms.DragEventHandler(this.listViewAnimationTrack_DragOver);
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Track Name";
			this.columnHeader3.Width = 180;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Keyframes";
			this.columnHeader4.Width = 64;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Length";
			this.columnHeader1.Width = 50;
			// 
			// buttonAnimationTrackNormalize
			// 
			this.buttonAnimationTrackNormalize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAnimationTrackNormalize.Enabled = false;
			this.buttonAnimationTrackNormalize.Location = new System.Drawing.Point(409, 155);
			this.buttonAnimationTrackNormalize.Name = "buttonAnimationTrackNormalize";
			this.buttonAnimationTrackNormalize.Size = new System.Drawing.Size(100, 23);
			this.buttonAnimationTrackNormalize.TabIndex = 158;
			this.buttonAnimationTrackNormalize.Text = "Normalize All";
			this.buttonAnimationTrackNormalize.UseVisualStyleBackColor = true;
			// 
			// groupBox18
			// 
			this.groupBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox18.Controls.Add(this.numericAnimationKeyframeEnd);
			this.groupBox18.Controls.Add(this.label45);
			this.groupBox18.Controls.Add(this.numericAnimationKeyframeStart);
			this.groupBox18.Controls.Add(this.label46);
			this.groupBox18.Controls.Add(this.buttonAnimationKeyframeRemove);
			this.groupBox18.Enabled = false;
			this.groupBox18.Location = new System.Drawing.Point(409, 12);
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.Size = new System.Drawing.Size(100, 98);
			this.groupBox18.TabIndex = 140;
			this.groupBox18.TabStop = false;
			this.groupBox18.Text = "Keyframes";
			// 
			// numericAnimationKeyframeEnd
			// 
			this.numericAnimationKeyframeEnd.Location = new System.Drawing.Point(36, 41);
			this.numericAnimationKeyframeEnd.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.numericAnimationKeyframeEnd.Name = "numericAnimationKeyframeEnd";
			this.numericAnimationKeyframeEnd.Size = new System.Drawing.Size(55, 20);
			this.numericAnimationKeyframeEnd.TabIndex = 144;
			// 
			// label45
			// 
			this.label45.AutoSize = true;
			this.label45.Location = new System.Drawing.Point(8, 44);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(26, 13);
			this.label45.TabIndex = 149;
			this.label45.Text = "End";
			// 
			// numericAnimationKeyframeStart
			// 
			this.numericAnimationKeyframeStart.Location = new System.Drawing.Point(36, 17);
			this.numericAnimationKeyframeStart.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.numericAnimationKeyframeStart.Name = "numericAnimationKeyframeStart";
			this.numericAnimationKeyframeStart.Size = new System.Drawing.Size(55, 20);
			this.numericAnimationKeyframeStart.TabIndex = 142;
			// 
			// label46
			// 
			this.label46.AutoSize = true;
			this.label46.Location = new System.Drawing.Point(5, 20);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(29, 13);
			this.label46.TabIndex = 148;
			this.label46.Text = "Start";
			// 
			// buttonAnimationKeyframeRemove
			// 
			this.buttonAnimationKeyframeRemove.Location = new System.Drawing.Point(8, 67);
			this.buttonAnimationKeyframeRemove.Name = "buttonAnimationKeyframeRemove";
			this.buttonAnimationKeyframeRemove.Size = new System.Drawing.Size(83, 23);
			this.buttonAnimationKeyframeRemove.TabIndex = 148;
			this.buttonAnimationKeyframeRemove.Text = "Remove";
			this.buttonAnimationKeyframeRemove.UseVisualStyleBackColor = true;
			// 
			// buttonAnimationClipEditHex
			// 
			this.buttonAnimationClipEditHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonAnimationClipEditHex.Enabled = false;
			this.buttonAnimationClipEditHex.Location = new System.Drawing.Point(436, 258);
			this.buttonAnimationClipEditHex.Name = "buttonAnimationClipEditHex";
			this.buttonAnimationClipEditHex.Size = new System.Drawing.Size(73, 23);
			this.buttonAnimationClipEditHex.TabIndex = 212;
			this.buttonAnimationClipEditHex.Text = "Edit Hex";
			this.buttonAnimationClipEditHex.UseVisualStyleBackColor = true;
			// 
			// dataGridViewAnimationClip
			// 
			this.dataGridViewAnimationClip.AllowUserToAddRows = false;
			this.dataGridViewAnimationClip.AllowUserToDeleteRows = false;
			this.dataGridViewAnimationClip.AllowUserToResizeRows = false;
			this.dataGridViewAnimationClip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewAnimationClip.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewAnimationClip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridViewAnimationClip.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridViewAnimationClip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAnimationClip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ColumnAnimationClipName,
            this.ColumnAnimationClipStart,
            this.ColumnAnimationClipEnd,
            this.ColumnAnimationClipNext,
            this.ColumnAnimationClipSpeed,
            this.ColumnAnimationClipUnknown1,
            this.ColumnAnimationClipRest});
			this.dataGridViewAnimationClip.EnableHeadersVisualStyles = false;
			this.dataGridViewAnimationClip.GridColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridViewAnimationClip.Location = new System.Drawing.Point(0, 18);
			this.dataGridViewAnimationClip.MultiSelect = false;
			this.dataGridViewAnimationClip.Name = "dataGridViewAnimationClip";
			this.dataGridViewAnimationClip.RowHeadersVisible = false;
			this.dataGridViewAnimationClip.RowTemplate.Height = 18;
			this.dataGridViewAnimationClip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewAnimationClip.ShowCellToolTips = false;
			this.dataGridViewAnimationClip.Size = new System.Drawing.Size(509, 203);
			this.dataGridViewAnimationClip.StandardTab = true;
			this.dataGridViewAnimationClip.TabIndex = 170;
			this.dataGridViewAnimationClip.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAnimationClip_CellValueChanged);
			this.dataGridViewAnimationClip.SelectionChanged += new System.EventHandler(this.dataGridViewAnimationClip_SelectionChanged);
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(-1, 2);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(78, 13);
			this.label33.TabIndex = 135;
			this.label33.Text = "Animation Clips";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox3.Controls.Add(this.buttonAnimationClipDelete);
			this.groupBox3.Controls.Add(this.buttonAnimationClipCopy);
			this.groupBox3.Location = new System.Drawing.Point(346, 220);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(75, 65);
			this.groupBox3.TabIndex = 200;
			this.groupBox3.TabStop = false;
			// 
			// buttonAnimationClipDelete
			// 
			this.buttonAnimationClipDelete.Location = new System.Drawing.Point(5, 37);
			this.buttonAnimationClipDelete.Name = "buttonAnimationClipDelete";
			this.buttonAnimationClipDelete.Size = new System.Drawing.Size(65, 23);
			this.buttonAnimationClipDelete.TabIndex = 203;
			this.buttonAnimationClipDelete.Text = "Delete";
			this.buttonAnimationClipDelete.UseVisualStyleBackColor = true;
			this.buttonAnimationClipDelete.Click += new System.EventHandler(this.buttonAnimationClipDelete_Click);
			// 
			// buttonAnimationClipCopy
			// 
			this.buttonAnimationClipCopy.Location = new System.Drawing.Point(5, 10);
			this.buttonAnimationClipCopy.Name = "buttonAnimationClipCopy";
			this.buttonAnimationClipCopy.Size = new System.Drawing.Size(65, 23);
			this.buttonAnimationClipCopy.TabIndex = 202;
			this.buttonAnimationClipCopy.Text = "Copy";
			this.buttonAnimationClipCopy.UseVisualStyleBackColor = true;
			this.buttonAnimationClipCopy.Click += new System.EventHandler(this.buttonAnimationClipCopy_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox2.Controls.Add(this.buttonAnimationClipMoveUp);
			this.groupBox2.Controls.Add(this.buttonAnimationClipMoveDown);
			this.groupBox2.Location = new System.Drawing.Point(280, 220);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(63, 65);
			this.groupBox2.TabIndex = 190;
			this.groupBox2.TabStop = false;
			// 
			// buttonAnimationClipMoveUp
			// 
			this.buttonAnimationClipMoveUp.Location = new System.Drawing.Point(5, 10);
			this.buttonAnimationClipMoveUp.Name = "buttonAnimationClipMoveUp";
			this.buttonAnimationClipMoveUp.Size = new System.Drawing.Size(53, 23);
			this.buttonAnimationClipMoveUp.TabIndex = 191;
			this.buttonAnimationClipMoveUp.Text = "Up";
			this.buttonAnimationClipMoveUp.UseVisualStyleBackColor = true;
			this.buttonAnimationClipMoveUp.Click += new System.EventHandler(this.buttonAnimationClipMoveUp_Click);
			// 
			// buttonAnimationClipMoveDown
			// 
			this.buttonAnimationClipMoveDown.Location = new System.Drawing.Point(5, 37);
			this.buttonAnimationClipMoveDown.Name = "buttonAnimationClipMoveDown";
			this.buttonAnimationClipMoveDown.Size = new System.Drawing.Size(53, 23);
			this.buttonAnimationClipMoveDown.TabIndex = 192;
			this.buttonAnimationClipMoveDown.Text = "Down";
			this.buttonAnimationClipMoveDown.UseVisualStyleBackColor = true;
			this.buttonAnimationClipMoveDown.Click += new System.EventHandler(this.buttonAnimationClipMoveDown_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.Controls.Add(this.buttonAnimationClipPlayPause);
			this.groupBox1.Controls.Add(this.trackBarAnimationClipKeyframe);
			this.groupBox1.Controls.Add(this.checkBoxAnimationClipLoadNextClip);
			this.groupBox1.Controls.Add(this.numericAnimationClipSpeed);
			this.groupBox1.Controls.Add(this.numericAnimationClipKeyframe);
			this.groupBox1.Controls.Add(this.labelSkeletalRender);
			this.groupBox1.Controls.Add(this.label30);
			this.groupBox1.Location = new System.Drawing.Point(0, 220);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(277, 65);
			this.groupBox1.TabIndex = 180;
			this.groupBox1.TabStop = false;
			// 
			// buttonAnimationClipPlayPause
			// 
			this.buttonAnimationClipPlayPause.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.buttonAnimationClipPlayPause.ImageIndex = 0;
			this.buttonAnimationClipPlayPause.ImageList = this.imageList1;
			this.buttonAnimationClipPlayPause.Location = new System.Drawing.Point(7, 12);
			this.buttonAnimationClipPlayPause.Name = "buttonAnimationClipPlayPause";
			this.buttonAnimationClipPlayPause.Size = new System.Drawing.Size(20, 19);
			this.buttonAnimationClipPlayPause.TabIndex = 181;
			this.buttonAnimationClipPlayPause.UseVisualStyleBackColor = true;
			this.buttonAnimationClipPlayPause.Click += new System.EventHandler(this.buttonAnimationClipPlayPause_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.White;
			this.imageList1.Images.SetKeyName(0, "play.bmp");
			this.imageList1.Images.SetKeyName(1, "pause.bmp");
			// 
			// trackBarAnimationClipKeyframe
			// 
			this.trackBarAnimationClipKeyframe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.trackBarAnimationClipKeyframe.AutoSize = false;
			this.trackBarAnimationClipKeyframe.Location = new System.Drawing.Point(33, 14);
			this.trackBarAnimationClipKeyframe.Name = "trackBarAnimationClipKeyframe";
			this.trackBarAnimationClipKeyframe.Size = new System.Drawing.Size(143, 18);
			this.trackBarAnimationClipKeyframe.TabIndex = 182;
			this.trackBarAnimationClipKeyframe.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBarAnimationClipKeyframe.ValueChanged += new System.EventHandler(this.trackBarAnimationClipKeyframe_ValueChanged);
			// 
			// checkBoxAnimationClipLoadNextClip
			// 
			this.checkBoxAnimationClipLoadNextClip.AutoSize = true;
			this.checkBoxAnimationClipLoadNextClip.Checked = true;
			this.checkBoxAnimationClipLoadNextClip.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxAnimationClipLoadNextClip.Location = new System.Drawing.Point(7, 42);
			this.checkBoxAnimationClipLoadNextClip.Name = "checkBoxAnimationClipLoadNextClip";
			this.checkBoxAnimationClipLoadNextClip.Size = new System.Drawing.Size(95, 17);
			this.checkBoxAnimationClipLoadNextClip.TabIndex = 186;
			this.checkBoxAnimationClipLoadNextClip.Text = "Load Next Clip";
			this.checkBoxAnimationClipLoadNextClip.UseVisualStyleBackColor = true;
			this.checkBoxAnimationClipLoadNextClip.CheckedChanged += new System.EventHandler(this.checkBoxAnimationClipLoadNextClip_CheckedChanged);
			// 
			// numericAnimationClipSpeed
			// 
			this.numericAnimationClipSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numericAnimationClipSpeed.DecimalPlaces = 1;
			this.numericAnimationClipSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.numericAnimationClipSpeed.Location = new System.Drawing.Point(180, 39);
			this.numericAnimationClipSpeed.Name = "numericAnimationClipSpeed";
			this.numericAnimationClipSpeed.Size = new System.Drawing.Size(55, 20);
			this.numericAnimationClipSpeed.TabIndex = 188;
			this.numericAnimationClipSpeed.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.numericAnimationClipSpeed.ValueChanged += new System.EventHandler(this.numericAnimationClipSpeed_ValueChanged);
			// 
			// numericAnimationClipKeyframe
			// 
			this.numericAnimationClipKeyframe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.numericAnimationClipKeyframe.Location = new System.Drawing.Point(180, 13);
			this.numericAnimationClipKeyframe.Name = "numericAnimationClipKeyframe";
			this.numericAnimationClipKeyframe.Size = new System.Drawing.Size(55, 20);
			this.numericAnimationClipKeyframe.TabIndex = 184;
			this.numericAnimationClipKeyframe.ValueChanged += new System.EventHandler(this.numericAnimationClipKeyframe_ValueChanged);
			// 
			// labelSkeletalRender
			// 
			this.labelSkeletalRender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelSkeletalRender.AutoSize = true;
			this.labelSkeletalRender.Location = new System.Drawing.Point(236, 17);
			this.labelSkeletalRender.Name = "labelSkeletalRender";
			this.labelSkeletalRender.Size = new System.Drawing.Size(21, 13);
			this.labelSkeletalRender.TabIndex = 148;
			this.labelSkeletalRender.Text = "/ 0";
			// 
			// label30
			// 
			this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(235, 43);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(38, 13);
			this.label30.TabIndex = 146;
			this.label30.Text = "Speed";
			// 
			// menuStrip1
			// 
			this.menuStrip1.AllowMerge = false;
			this.menuStrip1.AutoSize = false;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.menuStrip1.Size = new System.Drawing.Size(524, 18);
			this.menuStrip1.TabIndex = 185;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reopenToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator6,
            this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 18);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// reopenToolStripMenuItem
			// 
			this.reopenToolStripMenuItem.Name = "reopenToolStripMenuItem";
			this.reopenToolStripMenuItem.ShortcutKeyDisplayString = "";
			this.reopenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.reopenToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.reopenToolStripMenuItem.Text = "&Reopen .xa";
			this.reopenToolStripMenuItem.Click += new System.EventHandler(this.reopenToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.saveToolStripMenuItem.Text = "&Save .xa";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.saveAsToolStripMenuItem.Text = "Save .xa &As...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(169, 6);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F4";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.closeToolStripMenuItem.Text = "&Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keepBackupToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 18);
			this.optionsToolStripMenuItem.Text = "&Options";
			// 
			// keepBackupToolStripMenuItem
			// 
			this.keepBackupToolStripMenuItem.Checked = true;
			this.keepBackupToolStripMenuItem.CheckOnClick = true;
			this.keepBackupToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.keepBackupToolStripMenuItem.Name = "keepBackupToolStripMenuItem";
			this.keepBackupToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.keepBackupToolStripMenuItem.Text = "Keep Backup";
			this.keepBackupToolStripMenuItem.CheckedChanged += new System.EventHandler(this.keepBackupToolStripMenuItem_CheckedChanged);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = ".xa Files (*.xa)|*.xa|All Files (*.*)|*.*";
			// 
			// Column1
			// 
			this.Column1.Frozen = true;
			this.Column1.HeaderText = "Idx";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 29;
			// 
			// ColumnAnimationClipName
			// 
			this.ColumnAnimationClipName.Frozen = true;
			this.ColumnAnimationClipName.HeaderText = "Name";
			this.ColumnAnimationClipName.MinimumWidth = 25;
			this.ColumnAnimationClipName.Name = "ColumnAnimationClipName";
			this.ColumnAnimationClipName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ColumnAnimationClipName.Width = 234;
			// 
			// ColumnAnimationClipStart
			// 
			this.ColumnAnimationClipStart.Frozen = true;
			this.ColumnAnimationClipStart.HeaderText = "Start";
			this.ColumnAnimationClipStart.MinimumWidth = 25;
			this.ColumnAnimationClipStart.Name = "ColumnAnimationClipStart";
			this.ColumnAnimationClipStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ColumnAnimationClipStart.Width = 36;
			// 
			// ColumnAnimationClipEnd
			// 
			this.ColumnAnimationClipEnd.Frozen = true;
			this.ColumnAnimationClipEnd.HeaderText = "End";
			this.ColumnAnimationClipEnd.MinimumWidth = 25;
			this.ColumnAnimationClipEnd.Name = "ColumnAnimationClipEnd";
			this.ColumnAnimationClipEnd.Width = 36;
			// 
			// ColumnAnimationClipNext
			// 
			this.ColumnAnimationClipNext.Frozen = true;
			this.ColumnAnimationClipNext.HeaderText = "Next";
			this.ColumnAnimationClipNext.MinimumWidth = 25;
			this.ColumnAnimationClipNext.Name = "ColumnAnimationClipNext";
			this.ColumnAnimationClipNext.Width = 33;
			// 
			// ColumnAnimationClipSpeed
			// 
			this.ColumnAnimationClipSpeed.Frozen = true;
			this.ColumnAnimationClipSpeed.HeaderText = "Speed";
			this.ColumnAnimationClipSpeed.MinimumWidth = 25;
			this.ColumnAnimationClipSpeed.Name = "ColumnAnimationClipSpeed";
			this.ColumnAnimationClipSpeed.Width = 45;
			// 
			// ColumnAnimationClipUnknown1
			// 
			this.ColumnAnimationClipUnknown1.HeaderText = "Hex";
			this.ColumnAnimationClipUnknown1.Name = "ColumnAnimationClipUnknown1";
			this.ColumnAnimationClipUnknown1.Width = 40;
			// 
			// ColumnAnimationClipRest
			// 
			this.ColumnAnimationClipRest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ColumnAnimationClipRest.HeaderText = "";
			this.ColumnAnimationClipRest.Name = "ColumnAnimationClipRest";
			this.ColumnAnimationClipRest.ReadOnly = true;
			// 
			// FormXA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 536);
			this.Controls.Add(this.tabControlXA);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "FormXA";
			this.Text = "FormXA";
			this.tabControlXA.ResumeLayout(false);
			this.tabPageXAObjectView.ResumeLayout(false);
			this.splitContainer7.Panel1.ResumeLayout(false);
			this.splitContainer7.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
			this.splitContainer7.ResumeLayout(false);
			this.tabPageMaterial.ResumeLayout(false);
			this.tabPageMaterial.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericType1ConfigPosition)).EndInit();
			this.tabPageMorph.ResumeLayout(false);
			this.splitContainerMorph.Panel1.ResumeLayout(false);
			this.splitContainerMorph.Panel1.PerformLayout();
			this.splitContainerMorph.Panel2.ResumeLayout(false);
			this.splitContainerMorph.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMorph)).EndInit();
			this.splitContainerMorph.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.groupBox10.PerformLayout();
			this.groupBox9.ResumeLayout(false);
			this.groupBox9.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			this.groupBox7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBarMorphFactor)).EndInit();
			this.tabPageAnimation.ResumeLayout(false);
			this.splitContainerAnimation.Panel1.ResumeLayout(false);
			this.splitContainerAnimation.Panel1.PerformLayout();
			this.splitContainerAnimation.Panel2.ResumeLayout(false);
			this.splitContainerAnimation.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerAnimation)).EndInit();
			this.splitContainerAnimation.ResumeLayout(false);
			this.groupBox18.ResumeLayout(false);
			this.groupBox18.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericAnimationKeyframeEnd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericAnimationKeyframeStart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimationClip)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarAnimationClipKeyframe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericAnimationClipSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericAnimationClipKeyframe)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControlXA;
		private System.Windows.Forms.TabPage tabPageXAObjectView;
		private System.Windows.Forms.SplitContainer splitContainer7;
		private System.Windows.Forms.TreeView treeViewXA;
		private System.Windows.Forms.TableLayoutPanel tableLayoutXAHex;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.TabPage tabPageMaterial;
		private System.Windows.Forms.TextBox xaMatNameText;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label labelType1ConfigPositionMax;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.NumericUpDown numericType1ConfigPosition;
		private System.Windows.Forms.ListView listViewType1;
		private System.Windows.Forms.ColumnHeader columnHeaderType1;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox xaMatUnknown;
		private System.Windows.Forms.TextBox xaMatSpecularPower;
		private System.Windows.Forms.TextBox xaMatEmissiveA;
		private System.Windows.Forms.TextBox xaMatEmissiveB;
		private System.Windows.Forms.TextBox xaMatEmissiveG;
		private System.Windows.Forms.TextBox xaMatEmissiveR;
		private System.Windows.Forms.TextBox xaMatSpecularA;
		private System.Windows.Forms.TextBox xaMatSpecularB;
		private System.Windows.Forms.TextBox xaMatSpecularG;
		private System.Windows.Forms.TextBox xaMatSpecularR;
		private System.Windows.Forms.TextBox xaMatAmbientA;
		private System.Windows.Forms.TextBox xaMatAmbientB;
		private System.Windows.Forms.TextBox xaMatAmbientG;
		private System.Windows.Forms.TextBox xaMatAmbientR;
		private System.Windows.Forms.TextBox xaMatDiffuseA;
		private System.Windows.Forms.TextBox xaMatDiffuseB;
		private System.Windows.Forms.TextBox xaMatDiffuseG;
		private System.Windows.Forms.TextBox xaMatDiffuseR;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TabPage tabPageType2;
		private System.Windows.Forms.TabPage tabPageMorph;
		private System.Windows.Forms.SplitContainer splitContainerMorph;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.ComboBox comboBoxMorphMesh;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonMorphClipExport;
		private System.Windows.Forms.Label label57;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ColumnHeader columnHeaderMorphKeyframeName;
		private System.Windows.Forms.ColumnHeader columnHeaderMorphKeyframeVertices;
		private System.Windows.Forms.TabPage tabPageType4;
		private System.Windows.Forms.TabPage tabPageAnimation;
		private System.Windows.Forms.SplitContainer splitContainerAnimation;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonAnimationTrackRemove;
		private System.Windows.Forms.ListView listViewAnimationTrack;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Button buttonAnimationTrackNormalize;
		private System.Windows.Forms.GroupBox groupBox18;
		private System.Windows.Forms.NumericUpDown numericAnimationKeyframeEnd;
		private System.Windows.Forms.Label label45;
		private System.Windows.Forms.NumericUpDown numericAnimationKeyframeStart;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.Button buttonAnimationKeyframeRemove;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button buttonAnimationClipCopy;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button buttonAnimationClipMoveUp;
		private System.Windows.Forms.Button buttonAnimationClipMoveDown;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonAnimationClipPlayPause;
		private System.Windows.Forms.TrackBar trackBarAnimationClipKeyframe;
		public System.Windows.Forms.CheckBox checkBoxAnimationClipLoadNextClip;
		public System.Windows.Forms.NumericUpDown numericAnimationClipSpeed;
		private System.Windows.Forms.NumericUpDown numericAnimationClipKeyframe;
		private System.Windows.Forms.Label labelSkeletalRender;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.ImageList imageList1;
		public System.Windows.Forms.TreeView treeViewMorphClip;
		private System.Windows.Forms.ListView listViewMorphKeyframe;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBoxRefKeyframe;
		private System.Windows.Forms.Button buttonRefDown;
		private System.Windows.Forms.Button buttonRefUp;
		private System.Windows.Forms.Button buttonDeleteRef;
		private System.Windows.Forms.Button buttonNewRef;
		private EditTextBox textBoxFrameNameRefID;
		private EditTextBox editTextBoxNewKeyframeName;
		private System.Windows.Forms.Button buttonDeleteKeyframe;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox checkBoxOnlyValidKeyframes;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TrackBar trackBarMorphFactor;
		private System.Windows.Forms.CheckBox checkBoxStartKeyframe;
		private System.Windows.Forms.CheckBox checkBoxEndKeyframe;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.CheckBox checkBoxFbxOptionEmbedMedia;
		private System.Windows.Forms.CheckBox checkBoxFbxOptionOneBlendshape;
		private System.Windows.Forms.DataGridView dataGridViewAnimationClip;
		private System.Windows.Forms.Button buttonAnimationClipDelete;
		private System.Windows.Forms.Button buttonAnimationClipEditHex;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.GroupBox groupBox9;
		private EditTextBox editTextBoxMorphClipMesh;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private EditTextBox editTextBoxMorphClipName;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ComboBox comboBoxMorphExportFormat;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reopenToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem keepBackupToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnimationClipName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnimationClipStart;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnimationClipEnd;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnimationClipNext;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnimationClipSpeed;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnimationClipUnknown1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnimationClipRest;
	}
}