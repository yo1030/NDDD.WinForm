﻿using NDDD.Domain;

namespace NDDD.WinForm.Views
{
    /// <summary>
    /// ログインView
    /// </summary>
    public partial class LoginView : BaseForm
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public LoginView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ログインボタン押下
        /// </summary>
        /// <param name="sender">コントロール</param>
        /// <param name="e">イベント引数</param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Shared.LoginId = LoginTextBox.Text;

            using (var f = new LatestView())
            {
                f.ShowDialog();
            }
        }
    }
}
