namespace QuanNet4_0
{
    partial class MainClient
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
            lbName = new Label();
            lbAmount = new Label();
            lbAmountNumber = new Label();
            lbWelcome = new Label();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbName.Location = new Point(1072, 26);
            lbName.Name = "lbName";
            lbName.Size = new Size(80, 32);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            // 
            // lbAmount
            // 
            lbAmount.AutoSize = true;
            lbAmount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAmount.Location = new Point(1158, 26);
            lbAmount.Name = "lbAmount";
            lbAmount.Size = new Size(112, 32);
            lbAmount.TabIndex = 1;
            lbAmount.Text = "Amount: ";
            lbAmount.Click += lbAmount_Click;
            // 
            // lbAmountNumber
            // 
            lbAmountNumber.AutoSize = true;
            lbAmountNumber.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAmountNumber.Location = new Point(1276, 26);
            lbAmountNumber.Name = "lbAmountNumber";
            lbAmountNumber.Size = new Size(28, 32);
            lbAmountNumber.TabIndex = 2;
            lbAmountNumber.Text = "0";
            // 
            // lbWelcome
            // 
            lbWelcome.AutoSize = true;
            lbWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbWelcome.Location = new Point(941, 26);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(125, 32);
            lbWelcome.TabIndex = 4;
            lbWelcome.Text = "Welcome, ";
            // 
            // MainClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 705);
            Controls.Add(lbWelcome);
            Controls.Add(lbAmountNumber);
            Controls.Add(lbAmount);
            Controls.Add(lbName);
            Name = "MainClient";
            Text = "MainClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private Label lbAmount;
        private Label lbAmountNumber;
        private Label lbWelcome;
    }
}