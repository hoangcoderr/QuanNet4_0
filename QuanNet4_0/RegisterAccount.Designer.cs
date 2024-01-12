namespace QuanNet4_0
{
    partial class RegisterAccount
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
            lbUserRegister = new Label();
            lbPasswordRegister = new Label();
            lbRetypePasswordRegister = new Label();
            lbRegister = new Label();
            txtUserRegister = new TextBox();
            txtPassRegister = new TextBox();
            txtRetypePassRegister = new TextBox();
            btRegister = new Button();
            ckbIsShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // lbUserRegister
            // 
            lbUserRegister.AutoSize = true;
            lbUserRegister.Location = new Point(48, 149);
            lbUserRegister.Name = "lbUserRegister";
            lbUserRegister.Size = new Size(60, 15);
            lbUserRegister.TabIndex = 0;
            lbUserRegister.Text = "Username";
            // 
            // lbPasswordRegister
            // 
            lbPasswordRegister.AutoSize = true;
            lbPasswordRegister.Location = new Point(48, 197);
            lbPasswordRegister.Name = "lbPasswordRegister";
            lbPasswordRegister.Size = new Size(57, 15);
            lbPasswordRegister.TabIndex = 1;
            lbPasswordRegister.Text = "Password";
            // 
            // lbRetypePasswordRegister
            // 
            lbRetypePasswordRegister.AutoSize = true;
            lbRetypePasswordRegister.Location = new Point(9, 248);
            lbRetypePasswordRegister.Name = "lbRetypePasswordRegister";
            lbRetypePasswordRegister.Size = new Size(96, 15);
            lbRetypePasswordRegister.TabIndex = 2;
            lbRetypePasswordRegister.Text = "Retype password";
            // 
            // lbRegister
            // 
            lbRegister.AutoSize = true;
            lbRegister.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbRegister.Location = new Point(121, 59);
            lbRegister.Name = "lbRegister";
            lbRegister.Size = new Size(99, 32);
            lbRegister.TabIndex = 3;
            lbRegister.Text = "Register";
            // 
            // txtUserRegister
            // 
            txtUserRegister.Location = new Point(134, 141);
            txtUserRegister.MaxLength = 30;
            txtUserRegister.Name = "txtUserRegister";
            txtUserRegister.Size = new Size(197, 23);
            txtUserRegister.TabIndex = 4;
            // 
            // txtPassRegister
            // 
            txtPassRegister.Location = new Point(134, 194);
            txtPassRegister.Name = "txtPassRegister";
            txtPassRegister.Size = new Size(197, 23);
            txtPassRegister.TabIndex = 5;
            txtPassRegister.UseSystemPasswordChar = true;
            // 
            // txtRetypePassRegister
            // 
            txtRetypePassRegister.Location = new Point(134, 248);
            txtRetypePassRegister.Name = "txtRetypePassRegister";
            txtRetypePassRegister.Size = new Size(197, 23);
            txtRetypePassRegister.TabIndex = 6;
            txtRetypePassRegister.UseSystemPasswordChar = true;
            // 
            // btRegister
            // 
            btRegister.Location = new Point(78, 356);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(174, 76);
            btRegister.TabIndex = 8;
            btRegister.Text = "Register";
            btRegister.UseVisualStyleBackColor = true;
            btRegister.Click += txtRegister_Click;
            // 
            // ckbIsShowPassword
            // 
            ckbIsShowPassword.AutoSize = true;
            ckbIsShowPassword.Location = new Point(78, 301);
            ckbIsShowPassword.Name = "ckbIsShowPassword";
            ckbIsShowPassword.Size = new Size(113, 19);
            ckbIsShowPassword.TabIndex = 11;
            ckbIsShowPassword.Text = "Show passsword";
            ckbIsShowPassword.UseVisualStyleBackColor = true;
            ckbIsShowPassword.CheckedChanged += ckbIsShowPassword_CheckedChanged;
            // 
            // RegisterAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 481);
            Controls.Add(ckbIsShowPassword);
            Controls.Add(btRegister);
            Controls.Add(txtRetypePassRegister);
            Controls.Add(txtPassRegister);
            Controls.Add(txtUserRegister);
            Controls.Add(lbRegister);
            Controls.Add(lbRetypePasswordRegister);
            Controls.Add(lbPasswordRegister);
            Controls.Add(lbUserRegister);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterAccount";
            Text = "Register";
            Load += RegisterAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUserRegister;
        private Label lbPasswordRegister;
        private Label lbRetypePasswordRegister;
        private Label lbRegister;
        private TextBox txtUserRegister;
        private TextBox txtPassRegister;
        private TextBox txtRetypePassRegister;
        private Button btRegister;
        private CheckBox ckbIsShowPassword;
    }
}