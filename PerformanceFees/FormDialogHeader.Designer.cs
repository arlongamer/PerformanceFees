namespace PerformanceFees
{
    partial class FormDialogHeader
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
            this.Header = new System.Windows.Forms.GroupBox();
            this.groupBoxCellTape = new System.Windows.Forms.GroupBox();
            this.radioButtonInupt = new System.Windows.Forms.RadioButton();
            this.radioButtonScript = new System.Windows.Forms.RadioButton();
            this.buttonClose = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxHeader = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBoxHeaderDescr = new System.Windows.Forms.RichTextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxScriptHeader = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Header.SuspendLayout();
            this.groupBoxCellTape.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Controls.Add(this.groupBox1);
            this.Header.Controls.Add(this.groupBoxCellTape);
            this.Header.Controls.Add(this.buttonClose);
            this.Header.Controls.Add(this.button5);
            this.Header.Controls.Add(this.button4);
            this.Header.Controls.Add(this.label7);
            this.Header.Controls.Add(this.richTextBoxHeaderDescr);
            this.Header.Controls.Add(this.label5);
            this.Header.Controls.Add(this.richTextBoxScriptHeader);
            this.Header.Location = new System.Drawing.Point(12, 12);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(693, 515);
            this.Header.TabIndex = 15;
            this.Header.TabStop = false;
            this.Header.Enter += new System.EventHandler(this.Header_Enter);
            // 
            // groupBoxCellTape
            // 
            this.groupBoxCellTape.Controls.Add(this.radioButtonInupt);
            this.groupBoxCellTape.Controls.Add(this.radioButtonScript);
            this.groupBoxCellTape.Location = new System.Drawing.Point(232, 29);
            this.groupBoxCellTape.Name = "groupBoxCellTape";
            this.groupBoxCellTape.Size = new System.Drawing.Size(155, 88);
            this.groupBoxCellTape.TabIndex = 22;
            this.groupBoxCellTape.TabStop = false;
            this.groupBoxCellTape.Text = "Column Type";
            // 
            // radioButtonInupt
            // 
            this.radioButtonInupt.AutoSize = true;
            this.radioButtonInupt.Location = new System.Drawing.Point(6, 27);
            this.radioButtonInupt.Name = "radioButtonInupt";
            this.radioButtonInupt.Size = new System.Drawing.Size(49, 17);
            this.radioButtonInupt.TabIndex = 25;
            this.radioButtonInupt.Text = "Input";
            this.radioButtonInupt.UseVisualStyleBackColor = true;
            this.radioButtonInupt.CheckedChanged += new System.EventHandler(this.radioButtonInupt_CheckedChanged);
            // 
            // radioButtonScript
            // 
            this.radioButtonScript.AutoSize = true;
            this.radioButtonScript.Location = new System.Drawing.Point(6, 56);
            this.radioButtonScript.Name = "radioButtonScript";
            this.radioButtonScript.Size = new System.Drawing.Size(52, 17);
            this.radioButtonScript.TabIndex = 26;
            this.radioButtonScript.Text = "Script";
            this.radioButtonScript.UseVisualStyleBackColor = true;
            this.radioButtonScript.CheckedChanged += new System.EventHandler(this.radioButtonScript_CheckedChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(161, 443);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(140, 37);
            this.buttonClose.TabIndex = 60;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(508, 443);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 37);
            this.button5.TabIndex = 80;
            this.button5.Text = "Check Syntax";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // textBoxHeader
            // 
            this.textBoxHeader.Location = new System.Drawing.Point(65, 58);
            this.textBoxHeader.Name = "textBoxHeader";
            this.textBoxHeader.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeader.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Header:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 443);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 37);
            this.button4.TabIndex = 50;
            this.button4.Text = "Appy modif";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Description :";
            // 
            // richTextBoxHeaderDescr
            // 
            this.richTextBoxHeaderDescr.Location = new System.Drawing.Point(16, 148);
            this.richTextBoxHeaderDescr.Name = "richTextBoxHeaderDescr";
            this.richTextBoxHeaderDescr.Size = new System.Drawing.Size(633, 87);
            this.richTextBoxHeaderDescr.TabIndex = 30;
            this.richTextBoxHeaderDescr.Text = "";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(65, 26);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Script:";
            // 
            // richTextBoxScriptHeader
            // 
            this.richTextBoxScriptHeader.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxScriptHeader.Location = new System.Drawing.Point(15, 266);
            this.richTextBoxScriptHeader.Name = "richTextBoxScriptHeader";
            this.richTextBoxScriptHeader.Size = new System.Drawing.Size(633, 157);
            this.richTextBoxScriptHeader.TabIndex = 40;
            this.richTextBoxScriptHeader.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxHeader);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(16, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 88);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Column details :";
            // 
            // FormDialogHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 539);
            this.Controls.Add(this.Header);
            this.Name = "FormDialogHeader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Header detals";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.groupBoxCellTape.ResumeLayout(false);
            this.groupBoxCellTape.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Header;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxHeader;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBoxHeaderDescr;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxScriptHeader;
        private System.Windows.Forms.GroupBox groupBoxCellTape;
        private System.Windows.Forms.RadioButton radioButtonInupt;
        private System.Windows.Forms.RadioButton radioButtonScript;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}