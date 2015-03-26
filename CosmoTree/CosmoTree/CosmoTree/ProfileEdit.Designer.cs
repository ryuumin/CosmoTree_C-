namespace CosmoTree
{
    partial class ProfileEdit
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
            this.Agelabel = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.DisssionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Agelabel
            // 
            this.Agelabel.AutoSize = true;
            this.Agelabel.Location = new System.Drawing.Point(30, 24);
            this.Agelabel.Name = "Agelabel";
            this.Agelabel.Size = new System.Drawing.Size(44, 18);
            this.Agelabel.TabIndex = 0;
            this.Agelabel.Text = "年齢";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(33, 59);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 25);
            this.AgeTextBox.TabIndex = 1;
            // 
            // DisssionButton
            // 
            this.DisssionButton.Location = new System.Drawing.Point(33, 178);
            this.DisssionButton.Name = "DisssionButton";
            this.DisssionButton.Size = new System.Drawing.Size(190, 31);
            this.DisssionButton.TabIndex = 2;
            this.DisssionButton.Text = "上記内容で登録する";
            this.DisssionButton.UseVisualStyleBackColor = true;
            this.DisssionButton.Click += new System.EventHandler(this.DisssionButton_Click);
            // 
            // ProfileEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 754);
            this.Controls.Add(this.DisssionButton);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.Agelabel);
            this.Name = "ProfileEdit";
            this.Text = "ProfileEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyBaseForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Agelabel;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Button DisssionButton;
    }
}