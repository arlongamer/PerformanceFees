namespace PerformanceFees
{
    partial class FormCreationSheet
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxCellTape = new System.Windows.Forms.GroupBox();
            this.radioButtonInupt = new System.Windows.Forms.RadioButton();
            this.radioButtonInhert = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.Header.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxCellTape.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(131, 254);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 32);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(20, 254);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(95, 32);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Header
            // 
            this.Header.Controls.Add(this.groupBox1);
            this.Header.Controls.Add(this.buttonCancel);
            this.Header.Controls.Add(this.buttonOK);
            this.Header.Controls.Add(this.groupBoxCellTape);
            this.Header.Controls.Add(this.label7);
            this.Header.Controls.Add(this.richTextBoxDescription);
            this.Header.Location = new System.Drawing.Point(12, 12);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(682, 319);
            this.Header.TabIndex = 16;
            this.Header.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Location = new System.Drawing.Point(16, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 98);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fee Sheet Name :";
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
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(65, 26);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(199, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // groupBoxCellTape
            // 
            this.groupBoxCellTape.Controls.Add(this.radioButtonInupt);
            this.groupBoxCellTape.Controls.Add(this.radioButtonInhert);
            this.groupBoxCellTape.Controls.Add(this.button5);
            this.groupBoxCellTape.Location = new System.Drawing.Point(310, 29);
            this.groupBoxCellTape.Name = "groupBoxCellTape";
            this.groupBoxCellTape.Size = new System.Drawing.Size(339, 98);
            this.groupBoxCellTape.TabIndex = 22;
            this.groupBoxCellTape.TabStop = false;
            this.groupBoxCellTape.Text = "Inheritance";
            // 
            // radioButtonInupt
            // 
            this.radioButtonInupt.AutoSize = true;
            this.radioButtonInupt.Checked = true;
            this.radioButtonInupt.Location = new System.Drawing.Point(6, 27);
            this.radioButtonInupt.Name = "radioButtonInupt";
            this.radioButtonInupt.Size = new System.Drawing.Size(51, 17);
            this.radioButtonInupt.TabIndex = 25;
            this.radioButtonInupt.TabStop = true;
            this.radioButtonInupt.Text = "None";
            this.radioButtonInupt.UseVisualStyleBackColor = true;
            // 
            // radioButtonInhert
            // 
            this.radioButtonInhert.AutoSize = true;
            this.radioButtonInhert.Location = new System.Drawing.Point(6, 56);
            this.radioButtonInhert.Name = "radioButtonInhert";
            this.radioButtonInhert.Size = new System.Drawing.Size(66, 17);
            this.radioButtonInhert.TabIndex = 26;
            this.radioButtonInhert.Text = "Inherited";
            this.radioButtonInhert.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(99, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 28);
            this.button5.TabIndex = 80;
            this.button5.Text = "Parent";
            this.button5.UseVisualStyleBackColor = true;
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
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(16, 148);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(633, 87);
            this.richTextBoxDescription.TabIndex = 30;
            this.richTextBoxDescription.Text = "";
            // 
            // FormCreationSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 351);
            this.Controls.Add(this.Header);
            this.Name = "FormCreationSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creation of a new Fee Sheet";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxCellTape.ResumeLayout(false);
            this.groupBoxCellTape.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox Header;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBoxCellTape;
        private System.Windows.Forms.RadioButton radioButtonInupt;
        private System.Windows.Forms.RadioButton radioButtonInhert;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
    }
}