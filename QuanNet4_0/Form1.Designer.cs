namespace QuanNet4_0
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameTxt = new TextBox();
            passwordTxt = new TextBox();
            lbUsername = new Label();
            lbPassword = new Label();
            loginBt = new Button();
            createAccBt = new Button();
            lbLogin = new Label();
            lbLanguage = new Label();
            languageCb = new ComboBox();
            ckbIsShowPassword = new CheckBox();
            btnClose = new Button();
            btnMinimize = new Button();
            SuspendLayout();
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(115, 155);
            usernameTxt.MaxLength = 30;
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(294, 23);
            usernameTxt.TabIndex = 0;
            usernameTxt.KeyPress += usernameTxt_KeyPress;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(115, 204);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(294, 23);
            passwordTxt.TabIndex = 1;
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(18, 158);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(60, 15);
            lbUsername.TabIndex = 2;
            lbUsername.Text = "Username";
            lbUsername.Click += lbUsername_Click;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(18, 212);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password";
            // 
            // loginBt
            // 
            loginBt.Location = new Point(249, 296);
            loginBt.Name = "loginBt";
            loginBt.Size = new Size(148, 47);
            loginBt.TabIndex = 4;
            loginBt.Text = "Login";
            loginBt.UseVisualStyleBackColor = true;
            loginBt.Click += loginBt_Click;
            // 
            // createAccBt
            // 
            createAccBt.Location = new Point(75, 296);
            createAccBt.Name = "createAccBt";
            createAccBt.Size = new Size(148, 48);
            createAccBt.TabIndex = 5;
            createAccBt.Text = "Create Account";
            createAccBt.UseVisualStyleBackColor = true;
            createAccBt.Click += createAccBt_Click;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLogin.Location = new Point(170, 83);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(102, 40);
            lbLogin.TabIndex = 6;
            lbLogin.Text = "LOGIN";
            // 
            // lbLanguage
            // 
            lbLanguage.AutoSize = true;
            lbLanguage.Location = new Point(283, 66);
            lbLanguage.Name = "lbLanguage";
            lbLanguage.Size = new Size(59, 15);
            lbLanguage.TabIndex = 8;
            lbLanguage.Text = "Language";
            // 
            // languageCb
            // 
            languageCb.DropDownStyle = ComboBoxStyle.DropDownList;
            languageCb.FormattingEnabled = true;
            languageCb.Items.AddRange(new object[] { "Tiếng Việt", "English" });
            languageCb.Location = new Point(348, 62);
            languageCb.Name = "languageCb";
            languageCb.Size = new Size(121, 23);
            languageCb.TabIndex = 9;
            languageCb.SelectedIndexChanged += languageCb_SelectedIndexChanged;
            // 
            // ckbIsShowPassword
            // 
            ckbIsShowPassword.AutoSize = true;
            ckbIsShowPassword.Location = new Point(110, 251);
            ckbIsShowPassword.Name = "ckbIsShowPassword";
            ckbIsShowPassword.Size = new Size(113, 19);
            ckbIsShowPassword.TabIndex = 10;
            ckbIsShowPassword.Text = "Show passsword";
            ckbIsShowPassword.UseVisualStyleBackColor = true;
            ckbIsShowPassword.CheckedChanged += ckbIsShowPassword_CheckedChanged;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(428, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(41, 23);
            btnClose.TabIndex = 11;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimize.Location = new Point(381, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(41, 23);
            btnMinimize.TabIndex = 12;
            btnMinimize.Text = "-";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 355);
            ControlBox = false;
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            Controls.Add(ckbIsShowPassword);
            Controls.Add(languageCb);
            Controls.Add(lbLanguage);
            Controls.Add(lbLogin);
            Controls.Add(createAccBt);
            Controls.Add(loginBt);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Controls.Add(passwordTxt);
            Controls.Add(usernameTxt);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTxt;
        private TextBox passwordTxt;
        private Label lbUsername;
        private Label lbPassword;
        private Button loginBt;
        private Button createAccBt;
        private Label lbLogin;
        private Label lbLanguage;
        private ComboBox languageCb;
        private CheckBox ckbIsShowPassword;
        private Button btnClose;
        private Button btnMinimize;
    }
}
