namespace NDDD.WinForm.Views
{
    partial class LoginView
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
            LoginButton = new Button();
            PasswordTextBox = new TextBox();
            label3 = new Label();
            LoginTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(53, 119);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(270, 28);
            LoginButton.TabIndex = 13;
            LoginButton.Text = "ログイン";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(148, 72);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(150, 23);
            PasswordTextBox.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 77);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 11;
            label3.Text = "パスワード";
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(148, 36);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(150, 23);
            LoginTextBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 41);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 7;
            label1.Text = "ログインID";
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 187);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(label3);
            Controls.Add(LoginTextBox);
            Controls.Add(label1);
            Name = "LoginView";
            Text = "LoginView";
            FormClosed += LoginView_FormClosed;
            Load += LoginView_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(LoginTextBox, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(PasswordTextBox, 0);
            Controls.SetChildIndex(LoginButton, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private TextBox PasswordTextBox;
        private Label label3;
        private TextBox LoginTextBox;
        private Label label1;
    }
}