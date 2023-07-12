using NDDD.Domain;

namespace NDDD.WinForm.Views
{
    public partial class LoginView : BaseForm
    {
        private static log4net.ILog _logger =
            log4net.LogManager.GetLogger(
                System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Shared.LoginId = LoginTextBox.Text;

            using (var f = new LatestView())
            {
                f.ShowDialog();
            }
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            _logger.Info("open:" + this.Name);
        }

        private void LoginView_FormClosed(object sender, FormClosedEventArgs e)
        {
            _logger.Info("close:" + this.Name);
        }
    }
}
