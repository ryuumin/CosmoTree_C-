namespace CosmoTree
{
    partial class Regist
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
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.LogInLabel = new System.Windows.Forms.Label();
            this.RegistButton = new System.Windows.Forms.Button();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(36, 50);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(343, 19);
            this.UserNameTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(36, 119);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(343, 19);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(34, 24);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(191, 12);
            this.UserNameLabel.TabIndex = 2;
            this.UserNameLabel.Text = "ユーザ名を入力してください（半角英数）";
            // 
            // LogInLabel
            // 
            this.LogInLabel.AutoSize = true;
            this.LogInLabel.Location = new System.Drawing.Point(34, 94);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(196, 12);
            this.LogInLabel.TabIndex = 3;
            this.LogInLabel.Text = "パスワードを入力してください（半角英数）";
            // 
            // RegistButton
            // 
            this.RegistButton.Location = new System.Drawing.Point(36, 189);
            this.RegistButton.Name = "RegistButton";
            this.RegistButton.Size = new System.Drawing.Size(75, 23);
            this.RegistButton.TabIndex = 4;
            this.RegistButton.Text = "登録";
            this.RegistButton.UseVisualStyleBackColor = true;
            this.RegistButton.Click += new System.EventHandler(this.RegistButton_Click);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(36, 157);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(0, 12);
            this.ErrorMessageLabel.TabIndex = 5;
            // 
            // Regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 772);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.RegistButton);
            this.Controls.Add(this.LogInLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Name = "Regist";
            this.Text = "Regist";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Regist_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label LogInLabel;
        private System.Windows.Forms.Button RegistButton;
        private System.Windows.Forms.Label ErrorMessageLabel;
    }
}