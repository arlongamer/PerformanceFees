namespace PerformanceFees
{
    partial class FormFeeSheet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewFee = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addColomnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCellDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCellDetails = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxEvaluation = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxScript = new System.Windows.Forms.RichTextBox();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.textBoxCycle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMainStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxValue = new System.Windows.Forms.GroupBox();
            this.textBoxCellValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCurrentCellValue = new System.Windows.Forms.TextBox();
            this.groupBoxCellTape = new System.Windows.Forms.GroupBox();
            this.checkBoxIsOver = new System.Windows.Forms.CheckBox();
            this.radioButtonInput = new System.Windows.Forms.RadioButton();
            this.radioButtonScript = new System.Windows.Forms.RadioButton();
            this.tabPageHeaders = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBoxHeaderDescription = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBoxHeaderScript = new System.Windows.Forms.RichTextBox();
            this.listViewField = new System.Windows.Forms.ListView();
            this.tabPagePrimitives = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.richTextBoxCompVar = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.richTextBoxCompConst = new System.Windows.Forms.RichTextBox();
            this.Primitives = new System.Windows.Forms.GroupBox();
            this.richTextBoxCompPrim = new System.Windows.Forms.RichTextBox();
            this.tabPageHistoric = new System.Windows.Forms.TabPage();
            this.tabPageVector = new System.Windows.Forms.TabPage();
            this.buttonEvalMatrix = new System.Windows.Forms.Button();
            this.buttonEval2Vectors = new System.Windows.Forms.Button();
            this.buttonEvalVector = new System.Windows.Forms.Button();
            this.buttonEvalSelected = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.richTextBoxMonitorOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.richTextBoxMonitorScript = new System.Windows.Forms.RichTextBox();
            this.listViewMonitor = new System.Windows.Forms.ListView();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteColummToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFee)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageCellDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            this.groupBoxValue.SuspendLayout();
            this.groupBoxCellTape.SuspendLayout();
            this.tabPageHeaders.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPagePrimitives.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.Primitives.SuspendLayout();
            this.tabPageVector.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewFee);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1251, 933);
            this.splitContainer1.SplitterDistance = 648;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // dataGridViewFee
            // 
            this.dataGridViewFee.AllowDrop = true;
            this.dataGridViewFee.AllowUserToOrderColumns = true;
            this.dataGridViewFee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFee.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewFee.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridViewFee.EnableHeadersVisualStyles = false;
            this.dataGridViewFee.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFee.Name = "dataGridViewFee";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFee.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFee.Size = new System.Drawing.Size(1251, 645);
            this.dataGridViewFee.TabIndex = 0;
            this.dataGridViewFee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFee_CellClick);
            this.dataGridViewFee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFee_CellDoubleClick);
            this.dataGridViewFee.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFee_CellMouseUp);
            this.dataGridViewFee.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFee_CellValueChanged);
            this.dataGridViewFee.ColumnDisplayIndexChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewFee_ColumnDisplayIndexChanged);
            this.dataGridViewFee.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFee_ColumnHeaderMouseDoubleClick);
            this.dataGridViewFee.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewFee_RowsAdded);
            this.dataGridViewFee.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewFee_DragDrop);
            this.dataGridViewFee.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridViewFee_DragOver);
            this.dataGridViewFee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewFee_MouseDown);
            this.dataGridViewFee.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridViewFee_MouseMove);
            this.dataGridViewFee.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridViewFee_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.clearToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.toolStripSeparator2,
            this.addColomnToolStripMenuItem,
            this.deleteColummToolStripMenuItem,
            this.toolStripSeparator3,
            this.showCellDetailsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 198);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saveAsToolStripMenuItem.Text = "S&ave As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
            // 
            // addColomnToolStripMenuItem
            // 
            this.addColomnToolStripMenuItem.Name = "addColomnToolStripMenuItem";
            this.addColomnToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.addColomnToolStripMenuItem.Text = "Add Column";
            this.addColomnToolStripMenuItem.Click += new System.EventHandler(this.addColomnToolStripMenuItem_Click);
            // 
            // showCellDetailsToolStripMenuItem
            // 
            this.showCellDetailsToolStripMenuItem.Name = "showCellDetailsToolStripMenuItem";
            this.showCellDetailsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.showCellDetailsToolStripMenuItem.Text = "Show Cell Details";
            this.showCellDetailsToolStripMenuItem.Click += new System.EventHandler(this.showCellDetailsToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageCellDetails);
            this.tabControl1.Controls.Add(this.tabPageHeaders);
            this.tabControl1.Controls.Add(this.tabPagePrimitives);
            this.tabControl1.Controls.Add(this.tabPageHistoric);
            this.tabControl1.Controls.Add(this.tabPageVector);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1251, 281);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCellDetails
            // 
            this.tabPageCellDetails.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageCellDetails.Controls.Add(this.groupBox2);
            this.tabPageCellDetails.Controls.Add(this.groupBox1);
            this.tabPageCellDetails.Controls.Add(this.groupBoxStatus);
            this.tabPageCellDetails.Controls.Add(this.groupBoxValue);
            this.tabPageCellDetails.Controls.Add(this.groupBoxCellTape);
            this.tabPageCellDetails.Location = new System.Drawing.Point(4, 22);
            this.tabPageCellDetails.Name = "tabPageCellDetails";
            this.tabPageCellDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCellDetails.Size = new System.Drawing.Size(1243, 255);
            this.tabPageCellDetails.TabIndex = 0;
            this.tabPageCellDetails.Text = "Cell Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBoxEvaluation);
            this.groupBox2.Location = new System.Drawing.Point(272, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 103);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Evalluation";
            // 
            // richTextBoxEvaluation
            // 
            this.richTextBoxEvaluation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxEvaluation.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxEvaluation.Location = new System.Drawing.Point(6, 16);
            this.richTextBoxEvaluation.Name = "richTextBoxEvaluation";
            this.richTextBoxEvaluation.Size = new System.Drawing.Size(562, 81);
            this.richTextBoxEvaluation.TabIndex = 29;
            this.richTextBoxEvaluation.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxScript);
            this.groupBox1.Location = new System.Drawing.Point(272, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 103);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Script";
            // 
            // richTextBoxScript
            // 
            this.richTextBoxScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxScript.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxScript.Location = new System.Drawing.Point(6, 16);
            this.richTextBoxScript.Name = "richTextBoxScript";
            this.richTextBoxScript.Size = new System.Drawing.Size(562, 81);
            this.richTextBoxScript.TabIndex = 29;
            this.richTextBoxScript.Text = "";
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.textBoxCycle);
            this.groupBoxStatus.Controls.Add(this.label7);
            this.groupBoxStatus.Controls.Add(this.textBoxMainStatus);
            this.groupBoxStatus.Controls.Add(this.label2);
            this.groupBoxStatus.Location = new System.Drawing.Point(125, 6);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(141, 103);
            this.groupBoxStatus.TabIndex = 28;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Status:";
            // 
            // textBoxCycle
            // 
            this.textBoxCycle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxCycle.Location = new System.Drawing.Point(65, 46);
            this.textBoxCycle.Name = "textBoxCycle";
            this.textBoxCycle.Size = new System.Drawing.Size(49, 20);
            this.textBoxCycle.TabIndex = 12;
            this.textBoxCycle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cycle :";
            // 
            // textBoxMainStatus
            // 
            this.textBoxMainStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxMainStatus.Location = new System.Drawing.Point(65, 17);
            this.textBoxMainStatus.Name = "textBoxMainStatus";
            this.textBoxMainStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxMainStatus.Size = new System.Drawing.Size(49, 20);
            this.textBoxMainStatus.TabIndex = 10;
            this.textBoxMainStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Main :";
            // 
            // groupBoxValue
            // 
            this.groupBoxValue.Controls.Add(this.textBoxCellValue);
            this.groupBoxValue.Controls.Add(this.label1);
            this.groupBoxValue.Controls.Add(this.label3);
            this.groupBoxValue.Controls.Add(this.textBoxCurrentCellValue);
            this.groupBoxValue.Location = new System.Drawing.Point(6, 115);
            this.groupBoxValue.Name = "groupBoxValue";
            this.groupBoxValue.Size = new System.Drawing.Size(260, 103);
            this.groupBoxValue.TabIndex = 27;
            this.groupBoxValue.TabStop = false;
            this.groupBoxValue.Text = " Value";
            // 
            // textBoxCellValue
            // 
            this.textBoxCellValue.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxCellValue.Location = new System.Drawing.Point(60, 16);
            this.textBoxCellValue.Name = "textBoxCellValue";
            this.textBoxCellValue.Size = new System.Drawing.Size(106, 20);
            this.textBoxCellValue.TabIndex = 7;
            this.textBoxCellValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Previous";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Current :";
            // 
            // textBoxCurrentCellValue
            // 
            this.textBoxCurrentCellValue.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxCurrentCellValue.Location = new System.Drawing.Point(60, 48);
            this.textBoxCurrentCellValue.Name = "textBoxCurrentCellValue";
            this.textBoxCurrentCellValue.Size = new System.Drawing.Size(106, 20);
            this.textBoxCurrentCellValue.TabIndex = 9;
            this.textBoxCurrentCellValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxCellTape
            // 
            this.groupBoxCellTape.Controls.Add(this.checkBoxIsOver);
            this.groupBoxCellTape.Controls.Add(this.radioButtonInput);
            this.groupBoxCellTape.Controls.Add(this.radioButtonScript);
            this.groupBoxCellTape.Location = new System.Drawing.Point(6, 6);
            this.groupBoxCellTape.Name = "groupBoxCellTape";
            this.groupBoxCellTape.Size = new System.Drawing.Size(113, 103);
            this.groupBoxCellTape.TabIndex = 26;
            this.groupBoxCellTape.TabStop = false;
            this.groupBoxCellTape.Text = "FieldType";
            // 
            // checkBoxIsOver
            // 
            this.checkBoxIsOver.AutoSize = true;
            this.checkBoxIsOver.Location = new System.Drawing.Point(6, 75);
            this.checkBoxIsOver.Name = "checkBoxIsOver";
            this.checkBoxIsOver.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxIsOver.Size = new System.Drawing.Size(78, 17);
            this.checkBoxIsOver.TabIndex = 18;
            this.checkBoxIsOver.Text = "Overridden";
            this.checkBoxIsOver.UseVisualStyleBackColor = true;
            // 
            // radioButtonInput
            // 
            this.radioButtonInput.AutoSize = true;
            this.radioButtonInput.Location = new System.Drawing.Point(6, 24);
            this.radioButtonInput.Name = "radioButtonInput";
            this.radioButtonInput.Size = new System.Drawing.Size(49, 17);
            this.radioButtonInput.TabIndex = 25;
            this.radioButtonInput.Text = "Input";
            this.radioButtonInput.UseVisualStyleBackColor = true;
            // 
            // radioButtonScript
            // 
            this.radioButtonScript.AutoSize = true;
            this.radioButtonScript.Location = new System.Drawing.Point(6, 50);
            this.radioButtonScript.Name = "radioButtonScript";
            this.radioButtonScript.Size = new System.Drawing.Size(52, 17);
            this.radioButtonScript.TabIndex = 26;
            this.radioButtonScript.Text = "Script";
            this.radioButtonScript.UseVisualStyleBackColor = true;
            // 
            // tabPageHeaders
            // 
            this.tabPageHeaders.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageHeaders.Controls.Add(this.groupBox4);
            this.tabPageHeaders.Controls.Add(this.groupBox3);
            this.tabPageHeaders.Controls.Add(this.listViewField);
            this.tabPageHeaders.Location = new System.Drawing.Point(4, 22);
            this.tabPageHeaders.Name = "tabPageHeaders";
            this.tabPageHeaders.Size = new System.Drawing.Size(1243, 255);
            this.tabPageHeaders.TabIndex = 3;
            this.tabPageHeaders.Text = "Headers";
            this.tabPageHeaders.Click += new System.EventHandler(this.tabPageHeaders_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBoxHeaderDescription);
            this.groupBox4.Location = new System.Drawing.Point(750, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(485, 124);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Description";
            // 
            // richTextBoxHeaderDescription
            // 
            this.richTextBoxHeaderDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxHeaderDescription.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxHeaderDescription.Location = new System.Drawing.Point(6, 16);
            this.richTextBoxHeaderDescription.Name = "richTextBoxHeaderDescription";
            this.richTextBoxHeaderDescription.Size = new System.Drawing.Size(473, 102);
            this.richTextBoxHeaderDescription.TabIndex = 29;
            this.richTextBoxHeaderDescription.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBoxHeaderScript);
            this.groupBox3.Location = new System.Drawing.Point(750, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 118);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Script";
            // 
            // richTextBoxHeaderScript
            // 
            this.richTextBoxHeaderScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxHeaderScript.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxHeaderScript.Location = new System.Drawing.Point(6, 16);
            this.richTextBoxHeaderScript.Name = "richTextBoxHeaderScript";
            this.richTextBoxHeaderScript.Size = new System.Drawing.Size(473, 96);
            this.richTextBoxHeaderScript.TabIndex = 29;
            this.richTextBoxHeaderScript.Text = "";
            // 
            // listViewField
            // 
            this.listViewField.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listViewField.FullRowSelect = true;
            this.listViewField.HideSelection = false;
            this.listViewField.Location = new System.Drawing.Point(3, 3);
            this.listViewField.Name = "listViewField";
            this.listViewField.Size = new System.Drawing.Size(741, 253);
            this.listViewField.TabIndex = 13;
            this.listViewField.UseCompatibleStateImageBehavior = false;
            this.listViewField.View = System.Windows.Forms.View.Details;
            this.listViewField.SelectedIndexChanged += new System.EventHandler(this.listViewField_SelectedIndexChanged);
            this.listViewField.DoubleClick += new System.EventHandler(this.listViewField_DoubleClick);
            // 
            // tabPagePrimitives
            // 
            this.tabPagePrimitives.BackColor = System.Drawing.SystemColors.Control;
            this.tabPagePrimitives.Controls.Add(this.groupBox6);
            this.tabPagePrimitives.Controls.Add(this.groupBox5);
            this.tabPagePrimitives.Controls.Add(this.Primitives);
            this.tabPagePrimitives.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrimitives.Name = "tabPagePrimitives";
            this.tabPagePrimitives.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrimitives.Size = new System.Drawing.Size(1243, 255);
            this.tabPagePrimitives.TabIndex = 1;
            this.tabPagePrimitives.Text = "Primitives";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.richTextBoxCompVar);
            this.groupBox6.Location = new System.Drawing.Point(841, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(396, 245);
            this.groupBox6.TabIndex = 94;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Variables:";
            // 
            // richTextBoxCompVar
            // 
            this.richTextBoxCompVar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxCompVar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCompVar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.richTextBoxCompVar.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxCompVar.Name = "richTextBoxCompVar";
            this.richTextBoxCompVar.Size = new System.Drawing.Size(388, 220);
            this.richTextBoxCompVar.TabIndex = 83;
            this.richTextBoxCompVar.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.richTextBoxCompConst);
            this.groupBox5.Location = new System.Drawing.Point(449, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(386, 245);
            this.groupBox5.TabIndex = 93;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Constructors:";
            // 
            // richTextBoxCompConst
            // 
            this.richTextBoxCompConst.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxCompConst.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCompConst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.richTextBoxCompConst.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxCompConst.Name = "richTextBoxCompConst";
            this.richTextBoxCompConst.Size = new System.Drawing.Size(374, 220);
            this.richTextBoxCompConst.TabIndex = 91;
            this.richTextBoxCompConst.Text = "";
            // 
            // Primitives
            // 
            this.Primitives.Controls.Add(this.richTextBoxCompPrim);
            this.Primitives.Location = new System.Drawing.Point(6, 6);
            this.Primitives.Name = "Primitives";
            this.Primitives.Size = new System.Drawing.Size(437, 245);
            this.Primitives.TabIndex = 92;
            this.Primitives.TabStop = false;
            this.Primitives.Text = "Definitions:";
            // 
            // richTextBoxCompPrim
            // 
            this.richTextBoxCompPrim.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxCompPrim.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCompPrim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.richTextBoxCompPrim.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxCompPrim.Name = "richTextBoxCompPrim";
            this.richTextBoxCompPrim.Size = new System.Drawing.Size(425, 220);
            this.richTextBoxCompPrim.TabIndex = 84;
            this.richTextBoxCompPrim.Text = "";
            // 
            // tabPageHistoric
            // 
            this.tabPageHistoric.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageHistoric.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistoric.Name = "tabPageHistoric";
            this.tabPageHistoric.Size = new System.Drawing.Size(1243, 255);
            this.tabPageHistoric.TabIndex = 2;
            this.tabPageHistoric.Text = "Historic";
            // 
            // tabPageVector
            // 
            this.tabPageVector.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageVector.Controls.Add(this.buttonEvalMatrix);
            this.tabPageVector.Controls.Add(this.buttonEval2Vectors);
            this.tabPageVector.Controls.Add(this.buttonEvalVector);
            this.tabPageVector.Controls.Add(this.buttonEvalSelected);
            this.tabPageVector.Controls.Add(this.groupBox8);
            this.tabPageVector.Controls.Add(this.groupBox7);
            this.tabPageVector.Controls.Add(this.listViewMonitor);
            this.tabPageVector.Location = new System.Drawing.Point(4, 22);
            this.tabPageVector.Name = "tabPageVector";
            this.tabPageVector.Size = new System.Drawing.Size(1243, 255);
            this.tabPageVector.TabIndex = 4;
            this.tabPageVector.Text = "Monitor";
            // 
            // buttonEvalMatrix
            // 
            this.buttonEvalMatrix.Location = new System.Drawing.Point(1144, 105);
            this.buttonEvalMatrix.Name = "buttonEvalMatrix";
            this.buttonEvalMatrix.Size = new System.Drawing.Size(90, 32);
            this.buttonEvalMatrix.TabIndex = 41;
            this.buttonEvalMatrix.Text = "Run Matrix";
            this.buttonEvalMatrix.UseVisualStyleBackColor = true;
            // 
            // buttonEval2Vectors
            // 
            this.buttonEval2Vectors.Location = new System.Drawing.Point(1048, 105);
            this.buttonEval2Vectors.Name = "buttonEval2Vectors";
            this.buttonEval2Vectors.Size = new System.Drawing.Size(90, 32);
            this.buttonEval2Vectors.TabIndex = 40;
            this.buttonEval2Vectors.Text = "Run 2 Vectors";
            this.buttonEval2Vectors.UseVisualStyleBackColor = true;
            // 
            // buttonEvalVector
            // 
            this.buttonEvalVector.Location = new System.Drawing.Point(952, 105);
            this.buttonEvalVector.Name = "buttonEvalVector";
            this.buttonEvalVector.Size = new System.Drawing.Size(90, 32);
            this.buttonEvalVector.TabIndex = 39;
            this.buttonEvalVector.Text = "Run Vector";
            this.buttonEvalVector.UseVisualStyleBackColor = true;
            // 
            // buttonEvalSelected
            // 
            this.buttonEvalSelected.Location = new System.Drawing.Point(856, 105);
            this.buttonEvalSelected.Name = "buttonEvalSelected";
            this.buttonEvalSelected.Size = new System.Drawing.Size(90, 32);
            this.buttonEvalSelected.TabIndex = 38;
            this.buttonEvalSelected.Text = "Run Selected";
            this.buttonEvalSelected.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.richTextBoxMonitorOutput);
            this.groupBox8.Location = new System.Drawing.Point(850, 143);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(390, 104);
            this.groupBox8.TabIndex = 37;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Run Feedback";
            // 
            // richTextBoxMonitorOutput
            // 
            this.richTextBoxMonitorOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxMonitorOutput.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxMonitorOutput.Location = new System.Drawing.Point(6, 16);
            this.richTextBoxMonitorOutput.Name = "richTextBoxMonitorOutput";
            this.richTextBoxMonitorOutput.Size = new System.Drawing.Size(381, 82);
            this.richTextBoxMonitorOutput.TabIndex = 29;
            this.richTextBoxMonitorOutput.Text = "";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.richTextBoxMonitorScript);
            this.groupBox7.Location = new System.Drawing.Point(850, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(390, 96);
            this.groupBox7.TabIndex = 36;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Script";
            // 
            // richTextBoxMonitorScript
            // 
            this.richTextBoxMonitorScript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxMonitorScript.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxMonitorScript.Location = new System.Drawing.Point(6, 16);
            this.richTextBoxMonitorScript.Name = "richTextBoxMonitorScript";
            this.richTextBoxMonitorScript.Size = new System.Drawing.Size(378, 74);
            this.richTextBoxMonitorScript.TabIndex = 29;
            this.richTextBoxMonitorScript.Text = "";
            // 
            // listViewMonitor
            // 
            this.listViewMonitor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listViewMonitor.FullRowSelect = true;
            this.listViewMonitor.HideSelection = false;
            this.listViewMonitor.Location = new System.Drawing.Point(3, 3);
            this.listViewMonitor.Name = "listViewMonitor";
            this.listViewMonitor.Size = new System.Drawing.Size(841, 253);
            this.listViewMonitor.TabIndex = 14;
            this.listViewMonitor.UseCompatibleStateImageBehavior = false;
            this.listViewMonitor.View = System.Windows.Forms.View.Details;
            this.listViewMonitor.SelectedIndexChanged += new System.EventHandler(this.listViewMonitor_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // deleteColummToolStripMenuItem
            // 
            this.deleteColummToolStripMenuItem.Name = "deleteColummToolStripMenuItem";
            this.deleteColummToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteColummToolStripMenuItem.Text = "Dele&te Columm";
            this.deleteColummToolStripMenuItem.Click += new System.EventHandler(this.deleteColummToolStripMenuItem_Click);
            // 
            // FormFeeSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 933);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormFeeSheet";
            this.Text = "FormFeeSheet";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFee)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCellDetails.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.groupBoxValue.ResumeLayout(false);
            this.groupBoxValue.PerformLayout();
            this.groupBoxCellTape.ResumeLayout(false);
            this.groupBoxCellTape.PerformLayout();
            this.tabPageHeaders.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPagePrimitives.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.Primitives.ResumeLayout(false);
            this.tabPageVector.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewFee;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCellDetails;
        private System.Windows.Forms.TabPage tabPagePrimitives;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addColomnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageHistoric;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.TextBox textBoxCycle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMainStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxValue;
        private System.Windows.Forms.TextBox textBoxCellValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCurrentCellValue;
        private System.Windows.Forms.GroupBox groupBoxCellTape;
        private System.Windows.Forms.CheckBox checkBoxIsOver;
        private System.Windows.Forms.RadioButton radioButtonInput;
        private System.Windows.Forms.RadioButton radioButtonScript;
        private System.Windows.Forms.RichTextBox richTextBoxScript;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxEvaluation;
        private System.Windows.Forms.TabPage tabPageHeaders;
        private System.Windows.Forms.ListView listViewField;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBoxHeaderDescription;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBoxHeaderScript;
        private System.Windows.Forms.RichTextBox richTextBoxCompPrim;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox richTextBoxCompConst;
        private System.Windows.Forms.GroupBox Primitives;
        private System.Windows.Forms.RichTextBox richTextBoxCompVar;
        private System.Windows.Forms.ToolStripMenuItem showCellDetailsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageVector;
        private System.Windows.Forms.Button buttonEvalMatrix;
        private System.Windows.Forms.Button buttonEval2Vectors;
        private System.Windows.Forms.Button buttonEvalVector;
        private System.Windows.Forms.Button buttonEvalSelected;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RichTextBox richTextBoxMonitorOutput;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox richTextBoxMonitorScript;
        private System.Windows.Forms.ListView listViewMonitor;
        private System.Windows.Forms.ToolStripMenuItem deleteColummToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}