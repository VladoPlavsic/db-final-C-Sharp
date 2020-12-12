namespace Shop
{
    partial class LoginPage
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
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginGuestEmailButton = new System.Windows.Forms.Button();
            this.identificationTextBox = new System.Windows.Forms.TextBox();
            this.loginGuestIDButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginUsername
            // 
            this.loginUsername.Location = new System.Drawing.Point(264, 58);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(180, 20);
            this.loginUsername.TabIndex = 0;
            // 
            // loginPassword
            // 
            this.loginPassword.Location = new System.Drawing.Point(264, 108);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.PasswordChar = '*';
            this.loginPassword.Size = new System.Drawing.Size(180, 20);
            this.loginPassword.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(264, 156);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "LogIn";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // loginGuestEmailButton
            // 
            this.loginGuestEmailButton.Location = new System.Drawing.Point(360, 262);
            this.loginGuestEmailButton.Name = "loginGuestEmailButton";
            this.loginGuestEmailButton.Size = new System.Drawing.Size(84, 23);
            this.loginGuestEmailButton.TabIndex = 6;
            this.loginGuestEmailButton.Text = "Enter by email";
            this.loginGuestEmailButton.UseVisualStyleBackColor = true;
            this.loginGuestEmailButton.Click += new System.EventHandler(this.loginGuestEmailButton_Click);
            // 
            // identificationTextBox
            // 
            this.identificationTextBox.Location = new System.Drawing.Point(264, 222);
            this.identificationTextBox.Name = "identificationTextBox";
            this.identificationTextBox.Size = new System.Drawing.Size(180, 20);
            this.identificationTextBox.TabIndex = 7;
            // 
            // loginGuestIDButton
            // 
            this.loginGuestIDButton.Location = new System.Drawing.Point(264, 262);
            this.loginGuestIDButton.Name = "loginGuestIDButton";
            this.loginGuestIDButton.Size = new System.Drawing.Size(75, 23);
            this.loginGuestIDButton.TabIndex = 8;
            this.loginGuestIDButton.Text = "Enter by id";
            this.loginGuestIDButton.UseVisualStyleBackColor = true;
            this.loginGuestIDButton.Click += new System.EventHandler(this.loginGuestIDButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID or E-mail:";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 396);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginGuestIDButton);
            this.Controls.Add(this.identificationTextBox);
            this.Controls.Add(this.loginGuestEmailButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginPassword);
            this.Controls.Add(this.loginUsername);
            this.Name = "LoginPage";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginUsername;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginGuestEmailButton;
        private System.Windows.Forms.TextBox identificationTextBox;
        private System.Windows.Forms.Button loginGuestIDButton;
        private System.Windows.Forms.Label label4;
    }
}

