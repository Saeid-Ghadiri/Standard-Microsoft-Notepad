namespace Standard_Microsoft_Notepad
{
    partial class Find
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Find));
            this.label1 = new System.Windows.Forms.Label();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.btn_NextFind = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Up = new System.Windows.Forms.RadioButton();
            this.btn_Down = new System.Windows.Forms.RadioButton();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.matchcaseCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find What:";
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(69, 8);
            this.findTextBox.Multiline = true;
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(179, 25);
            this.findTextBox.TabIndex = 1;
            // 
            // btn_NextFind
            // 
            this.btn_NextFind.Location = new System.Drawing.Point(259, 8);
            this.btn_NextFind.Name = "btn_NextFind";
            this.btn_NextFind.Size = new System.Drawing.Size(75, 25);
            this.btn_NextFind.TabIndex = 2;
            this.btn_NextFind.Text = "Next Find";
            this.btn_NextFind.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Down);
            this.groupBox1.Controls.Add(this.btn_Up);
            this.groupBox1.Location = new System.Drawing.Point(139, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 47);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction";
            // 
            // btn_Up
            // 
            this.btn_Up.AutoSize = true;
            this.btn_Up.Location = new System.Drawing.Point(4, 22);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(39, 17);
            this.btn_Up.TabIndex = 0;
            this.btn_Up.TabStop = true;
            this.btn_Up.Text = "Up";
            this.btn_Up.UseVisualStyleBackColor = true;
            // 
            // btn_Down
            // 
            this.btn_Down.AutoSize = true;
            this.btn_Down.Location = new System.Drawing.Point(49, 22);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(53, 17);
            this.btn_Down.TabIndex = 1;
            this.btn_Down.TabStop = true;
            this.btn_Down.Text = "Down";
            this.btn_Down.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(259, 39);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 25);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // matchcaseCheckBox
            // 
            this.matchcaseCheckBox.AutoSize = true;
            this.matchcaseCheckBox.Location = new System.Drawing.Point(7, 77);
            this.matchcaseCheckBox.Name = "matchcaseCheckBox";
            this.matchcaseCheckBox.Size = new System.Drawing.Size(82, 17);
            this.matchcaseCheckBox.TabIndex = 4;
            this.matchcaseCheckBox.Text = "Match case";
            this.matchcaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 101);
            this.Controls.Add(this.matchcaseCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_NextFind);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(358, 140);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(358, 140);
            this.Name = "Find";
            this.Text = "Find";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.Button btn_NextFind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btn_Down;
        private System.Windows.Forms.RadioButton btn_Up;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.CheckBox matchcaseCheckBox;
    }
}