namespace HitungBelanja
{
    partial class FrmTampilSignIn
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
            this.SignIn = new System.Windows.Forms.Button();
            this.TextPass = new System.Windows.Forms.TextBox();
            this.TextUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignIn
            // 
            this.SignIn.Location = new System.Drawing.Point(220, 320);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(306, 48);
            this.SignIn.TabIndex = 0;
            this.SignIn.Text = "Sign In";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextPass
            // 
            this.TextPass.Location = new System.Drawing.Point(166, 246);
            this.TextPass.Multiline = true;
            this.TextPass.Name = "TextPass";
            this.TextPass.Size = new System.Drawing.Size(426, 37);
            this.TextPass.TabIndex = 1;
            this.TextPass.TextChanged += new System.EventHandler(this.TextPass_TextChanged);
            // 
            // TextUser
            // 
            this.TextUser.Location = new System.Drawing.Point(166, 152);
            this.TextUser.Multiline = true;
            this.TextUser.Name = "TextUser";
            this.TextUser.Size = new System.Drawing.Size(426, 35);
            this.TextUser.TabIndex = 2;
            this.TextUser.TextChanged += new System.EventHandler(this.TextUser_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password :";
            // 
            // FrmTampilSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextUser);
            this.Controls.Add(this.TextPass);
            this.Controls.Add(this.SignIn);
            this.Name = "FrmTampilSignIn";
            this.Text = "FrmTampilSignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.TextBox TextPass;
        private System.Windows.Forms.TextBox TextUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}