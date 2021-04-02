namespace PerformanceFees
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewFees = new System.Windows.Forms.DataGridView();
            this.ColumnTotalNav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRedemption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFeeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRatioMTM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVarNav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBoxScript = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCompilerOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxUserOutputs = new System.Windows.Forms.RichTextBox();
            this.buttonCheckSyntax = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxHeader = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBoxHeaderDescr = new System.Windows.Forms.RichTextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxScriptHeader = new System.Windows.Forms.RichTextBox();
            this.dataGridViewDyn = new System.Windows.Forms.DataGridView();
            this.buttonLoadStructure = new System.Windows.Forms.Button();
            this.buttonAddColumn = new System.Windows.Forms.Button();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.buttonSaveDataGrid = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonResetGrif = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonRefreshGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFees)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDyn)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFees
            // 
            this.dataGridViewFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTotalNav,
            this.ColumnSubscription,
            this.ColumnRedemption,
            this.ColumnFeeRate,
            this.ColumnRatioMTM,
            this.ColumnVarNav});
            this.dataGridViewFees.Location = new System.Drawing.Point(8, 15);
            this.dataGridViewFees.Name = "dataGridViewFees";
            this.dataGridViewFees.Size = new System.Drawing.Size(707, 104);
            this.dataGridViewFees.TabIndex = 0;
            this.dataGridViewFees.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewFees_CellFormatting);
            this.dataGridViewFees.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFees_ColumnHeaderMouseClick);
            // 
            // ColumnTotalNav
            // 
            this.ColumnTotalNav.HeaderText = "TotalNav";
            this.ColumnTotalNav.Name = "ColumnTotalNav";
            // 
            // ColumnSubscription
            // 
            this.ColumnSubscription.HeaderText = "Subscription";
            this.ColumnSubscription.Name = "ColumnSubscription";
            // 
            // ColumnRedemption
            // 
            this.ColumnRedemption.HeaderText = "Redemption";
            this.ColumnRedemption.Name = "ColumnRedemption";
            // 
            // ColumnFeeRate
            // 
            this.ColumnFeeRate.HeaderText = "FeeRate";
            this.ColumnFeeRate.Name = "ColumnFeeRate";
            // 
            // ColumnRatioMTM
            // 
            this.ColumnRatioMTM.HeaderText = "RatioMTM";
            this.ColumnRatioMTM.Name = "ColumnRatioMTM";
            // 
            // ColumnVarNav
            // 
            this.ColumnVarNav.HeaderText = "VarNav";
            this.ColumnVarNav.Name = "ColumnVarNav";
            // 
            // richTextBoxScript
            // 
            this.richTextBoxScript.Location = new System.Drawing.Point(24, 634);
            this.richTextBoxScript.Name = "richTextBoxScript";
            this.richTextBoxScript.Size = new System.Drawing.Size(366, 225);
            this.richTextBoxScript.TabIndex = 1;
            this.richTextBoxScript.Text = resources.GetString("richTextBoxScript.Text");
            // 
            // richTextBoxCompilerOutput
            // 
            this.richTextBoxCompilerOutput.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBoxCompilerOutput.Location = new System.Drawing.Point(408, 634);
            this.richTextBoxCompilerOutput.Name = "richTextBoxCompilerOutput";
            this.richTextBoxCompilerOutput.Size = new System.Drawing.Size(336, 105);
            this.richTextBoxCompilerOutput.TabIndex = 2;
            this.richTextBoxCompilerOutput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 618);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Script:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 618);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Compiler Outputs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data area:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Inject Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 750);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "User Outputs:";
            // 
            // richTextBoxUserOutputs
            // 
            this.richTextBoxUserOutputs.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBoxUserOutputs.Location = new System.Drawing.Point(408, 766);
            this.richTextBoxUserOutputs.Name = "richTextBoxUserOutputs";
            this.richTextBoxUserOutputs.Size = new System.Drawing.Size(336, 105);
            this.richTextBoxUserOutputs.TabIndex = 9;
            this.richTextBoxUserOutputs.Text = "";
            // 
            // buttonCheckSyntax
            // 
            this.buttonCheckSyntax.Location = new System.Drawing.Point(24, 867);
            this.buttonCheckSyntax.Name = "buttonCheckSyntax";
            this.buttonCheckSyntax.Size = new System.Drawing.Size(166, 45);
            this.buttonCheckSyntax.TabIndex = 11;
            this.buttonCheckSyntax.Text = "Check Syntax";
            this.buttonCheckSyntax.UseVisualStyleBackColor = true;
            this.buttonCheckSyntax.Click += new System.EventHandler(this.buttonCheckSyntax_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 867);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Precompile and Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Header
            // 
            this.Header.Controls.Add(this.button5);
            this.Header.Controls.Add(this.textBoxHeader);
            this.Header.Controls.Add(this.label8);
            this.Header.Controls.Add(this.richTextBox1);
            this.Header.Controls.Add(this.button4);
            this.Header.Controls.Add(this.label7);
            this.Header.Controls.Add(this.richTextBoxHeaderDescr);
            this.Header.Controls.Add(this.textBoxName);
            this.Header.Controls.Add(this.label6);
            this.Header.Controls.Add(this.label5);
            this.Header.Controls.Add(this.richTextBoxScriptHeader);
            this.Header.Location = new System.Drawing.Point(16, 305);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(750, 298);
            this.Header.TabIndex = 14;
            this.Header.TabStop = false;
            this.Header.Text = "Header details";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(193, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 37);
            this.button5.TabIndex = 18;
            this.button5.Text = "Check Syntax";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBoxHeader
            // 
            this.textBoxHeader.Location = new System.Drawing.Point(233, 30);
            this.textBoxHeader.Name = "textBoxHeader";
            this.textBoxHeader.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeader.TabIndex = 17;
            this.textBoxHeader.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Header:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.Location = new System.Drawing.Point(339, 72);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(368, 219);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 37);
            this.button4.TabIndex = 15;
            this.button4.Text = "Appy modif";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Decr:";
            // 
            // richTextBoxHeaderDescr
            // 
            this.richTextBoxHeaderDescr.Location = new System.Drawing.Point(21, 178);
            this.richTextBoxHeaderDescr.Name = "richTextBoxHeaderDescr";
            this.richTextBoxHeaderDescr.Size = new System.Drawing.Size(312, 70);
            this.richTextBoxHeaderDescr.TabIndex = 7;
            this.richTextBoxHeaderDescr.Text = "";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(58, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Script:";
            // 
            // richTextBoxScriptHeader
            // 
            this.richTextBoxScriptHeader.Location = new System.Drawing.Point(20, 72);
            this.richTextBoxScriptHeader.Name = "richTextBoxScriptHeader";
            this.richTextBoxScriptHeader.Size = new System.Drawing.Size(313, 87);
            this.richTextBoxScriptHeader.TabIndex = 0;
            this.richTextBoxScriptHeader.Text = "";
            // 
            // dataGridViewDyn
            // 
            this.dataGridViewDyn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDyn.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewDyn.Name = "dataGridViewDyn";
            this.dataGridViewDyn.Size = new System.Drawing.Size(707, 141);
            this.dataGridViewDyn.TabIndex = 15;
            this.dataGridViewDyn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDyn_CellDoubleClick);
            this.dataGridViewDyn.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDyn_ColumnHeaderMouseClick);
            this.dataGridViewDyn.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDyn_ColumnHeaderMouseDoubleClick);
            // 
            // buttonLoadStructure
            // 
            this.buttonLoadStructure.Location = new System.Drawing.Point(103, 198);
            this.buttonLoadStructure.Name = "buttonLoadStructure";
            this.buttonLoadStructure.Size = new System.Drawing.Size(80, 35);
            this.buttonLoadStructure.TabIndex = 18;
            this.buttonLoadStructure.Text = "Load Structure";
            this.buttonLoadStructure.UseVisualStyleBackColor = true;
            this.buttonLoadStructure.Click += new System.EventHandler(this.buttonLoadStructure_Click);
            // 
            // buttonAddColumn
            // 
            this.buttonAddColumn.Location = new System.Drawing.Point(13, 153);
            this.buttonAddColumn.Name = "buttonAddColumn";
            this.buttonAddColumn.Size = new System.Drawing.Size(79, 35);
            this.buttonAddColumn.TabIndex = 19;
            this.buttonAddColumn.Text = "Add Column";
            this.buttonAddColumn.UseVisualStyleBackColor = true;
            this.buttonAddColumn.Click += new System.EventHandler(this.buttonAddColumn_Click);
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(297, 198);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(120, 35);
            this.buttonLoadData.TabIndex = 21;
            this.buttonLoadData.Text = "LoadData";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // buttonSaveDataGrid
            // 
            this.buttonSaveDataGrid.Location = new System.Drawing.Point(297, 153);
            this.buttonSaveDataGrid.Name = "buttonSaveDataGrid";
            this.buttonSaveDataGrid.Size = new System.Drawing.Size(120, 35);
            this.buttonSaveDataGrid.TabIndex = 22;
            this.buttonSaveDataGrid.Text = "SaveDataGrid";
            this.buttonSaveDataGrid.UseVisualStyleBackColor = true;
            this.buttonSaveDataGrid.Click += new System.EventHandler(this.buttonSaveDataGrid_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 274);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonRefreshGrid);
            this.tabPage2.Controls.Add(this.buttonResetGrif);
            this.tabPage2.Controls.Add(this.dataGridViewDyn);
            this.tabPage2.Controls.Add(this.buttonSaveDataGrid);
            this.tabPage2.Controls.Add(this.buttonLoadData);
            this.tabPage2.Controls.Add(this.buttonLoadStructure);
            this.tabPage2.Controls.Add(this.buttonAddColumn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Proto 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonResetGrif
            // 
            this.buttonResetGrif.Location = new System.Drawing.Point(13, 198);
            this.buttonResetGrif.Name = "buttonResetGrif";
            this.buttonResetGrif.Size = new System.Drawing.Size(79, 35);
            this.buttonResetGrif.TabIndex = 23;
            this.buttonResetGrif.Text = "Reset Grid";
            this.buttonResetGrif.UseVisualStyleBackColor = true;
            this.buttonResetGrif.Click += new System.EventHandler(this.buttonResetGrif_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewFees);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Proto 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshGrid
            // 
            this.buttonRefreshGrid.Location = new System.Drawing.Point(593, 198);
            this.buttonRefreshGrid.Name = "buttonRefreshGrid";
            this.buttonRefreshGrid.Size = new System.Drawing.Size(120, 35);
            this.buttonRefreshGrid.TabIndex = 24;
            this.buttonRefreshGrid.Text = "Refresh Grid";
            this.buttonRefreshGrid.UseVisualStyleBackColor = true;
            this.buttonRefreshGrid.Click += new System.EventHandler(this.buttonRefreshGrid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 939);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCheckSyntax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBoxUserOutputs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxCompilerOutput);
            this.Controls.Add(this.richTextBoxScript);
            this.Name = "Form1";
            this.Text = "Performance Fees Benchmark";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFees)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDyn)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotalNav;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRedemption;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFeeRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRatioMTM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVarNav;
        private System.Windows.Forms.RichTextBox richTextBoxScript;
        private System.Windows.Forms.RichTextBox richTextBoxCompilerOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxUserOutputs;
        private System.Windows.Forms.Button buttonCheckSyntax;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Header;
        private System.Windows.Forms.RichTextBox richTextBoxScriptHeader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBoxHeaderDescr;
        private System.Windows.Forms.DataGridView dataGridViewDyn;
        private System.Windows.Forms.Button buttonLoadStructure;
        private System.Windows.Forms.TextBox textBoxHeader;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonAddColumn;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Button buttonSaveDataGrid;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonResetGrif;
        private System.Windows.Forms.Button buttonRefreshGrid;
    }
}

