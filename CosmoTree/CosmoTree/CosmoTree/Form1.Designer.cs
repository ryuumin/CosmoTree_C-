namespace CosmoTree
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
            this.UserRegistration = new System.Windows.Forms.Button();
            this.LogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserRegistration
            // 
            this.UserRegistration.Location = new System.Drawing.Point(83, 38);
            this.UserRegistration.Name = "UserRegistration";
            this.UserRegistration.Size = new System.Drawing.Size(400, 50);
            this.UserRegistration.TabIndex = 0;
            this.UserRegistration.Text = "ユーザ登録";
            this.UserRegistration.UseVisualStyleBackColor = true;
            this.UserRegistration.Click += new System.EventHandler(this.ユーザ登録_Click);
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(83, 125);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(400, 50);
            this.LogIn.TabIndex = 1;
            this.LogIn.Text = "ログイン";
            this.LogIn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 772);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.UserRegistration);
            this.Name = "Form1";
            this.Text = "Welcome to Cosmo Tree!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserRegistration;
        private System.Windows.Forms.Button LogIn;
    }
}

