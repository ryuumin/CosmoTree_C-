namespace CosmoTree
{
    partial class MyPage
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
            this.Regist = new System.Windows.Forms.Button();
            this.LogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Regist
            // 
            this.Regist.Location = new System.Drawing.Point(31, 29);
            this.Regist.Name = "Regist";
            this.Regist.Size = new System.Drawing.Size(75, 23);
            this.Regist.TabIndex = 0;
            this.Regist.Text = "Regist";
            this.Regist.UseVisualStyleBackColor = true;
            this.Regist.Click += new System.EventHandler(this.Regist_Click);
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(31, 74);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(75, 23);
            this.LogIn.TabIndex = 1;
            this.LogIn.Text = "LogIn";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // MyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 772);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.Regist);
            this.Name = "MyPage";
            this.Text = "MyPage";
            this.ResumeLayout(false);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyBaseForm_FormClosed);

        }

        #endregion

        private System.Windows.Forms.Button Regist;
        private System.Windows.Forms.Button LogIn;
    }
}