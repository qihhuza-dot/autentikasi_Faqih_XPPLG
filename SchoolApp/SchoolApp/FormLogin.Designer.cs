namespace SchoolApp
{
    partial class FormLogin
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSubmitLogin = new Button();
            label1 = new Label();
            btnNavToRegister = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(169, 107);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username...";
            txtUsername.Size = new Size(419, 51);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(169, 183);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password...";
            txtPassword.Size = new Size(419, 51);
            txtPassword.TabIndex = 1;
            // 
            // btnSubmitLogin
            // 
            btnSubmitLogin.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitLogin.Location = new Point(169, 263);
            btnSubmitLogin.Name = "btnSubmitLogin";
            btnSubmitLogin.Size = new Size(419, 55);
            btnSubmitLogin.TabIndex = 2;
            btnSubmitLogin.Text = "Login";
            btnSubmitLogin.UseVisualStyleBackColor = true;
            btnSubmitLogin.Click += btnSubmitLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(264, 28);
            label1.Name = "label1";
            label1.Size = new Size(246, 44);
            label1.TabIndex = 4;
            label1.Text = "Form Login";
            // 
            // btnNavToRegister
            // 
            btnNavToRegister.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavToRegister.Location = new Point(174, 340);
            btnNavToRegister.Name = "btnNavToRegister";
            btnNavToRegister.Size = new Size(414, 57);
            btnNavToRegister.TabIndex = 5;
            btnNavToRegister.Text = "Register";
            btnNavToRegister.UseVisualStyleBackColor = true;
            btnNavToRegister.Click += btnNavToRegister_Click_1;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNavToRegister);
            Controls.Add(label1);
            Controls.Add(btnSubmitLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "FormLogin";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnNavToRegister_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnSubmitLogin;
        private Label label1;
        private Button btnNavToRegister;
    }
}