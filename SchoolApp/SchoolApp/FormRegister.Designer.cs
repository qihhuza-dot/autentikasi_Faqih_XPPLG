namespace SchoolApp
{
    partial class FormRegister
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
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            btnSubmitRegister = new Button();
            btnNavToLogin = new Button();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(198, 108);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Full Name...";
            txtFullName.Size = new Size(413, 51);
            txtFullName.TabIndex = 0;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(198, 165);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username...";
            txtUsername.Size = new Size(413, 51);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(198, 222);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password...";
            txtPassword.Size = new Size(413, 51);
            txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 27);
            label1.Name = "label1";
            label1.Size = new Size(303, 44);
            label1.TabIndex = 3;
            label1.Text = "Form Register";
            // 
            // btnSubmitRegister
            // 
            btnSubmitRegister.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitRegister.Location = new Point(198, 291);
            btnSubmitRegister.Name = "btnSubmitRegister";
            btnSubmitRegister.Size = new Size(413, 55);
            btnSubmitRegister.TabIndex = 4;
            btnSubmitRegister.Text = "Register";
            btnSubmitRegister.UseVisualStyleBackColor = true;
            btnSubmitRegister.Click += btnSubmitRegister_Click;
            // 
            // btnNavToLogin
            // 
            btnNavToLogin.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavToLogin.Location = new Point(198, 352);
            btnNavToLogin.Name = "btnNavToLogin";
            btnNavToLogin.Size = new Size(413, 55);
            btnNavToLogin.TabIndex = 5;
            btnNavToLogin.Text = "To Login";
            btnNavToLogin.UseVisualStyleBackColor = true;
            btnNavToLogin.Click += btnNavToLogin_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNavToLogin);
            Controls.Add(btnSubmitRegister);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtFullName);
            Name = "FormRegister";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Button btnSubmitRegister;
        private Button btnNavToLogin;
    }
}