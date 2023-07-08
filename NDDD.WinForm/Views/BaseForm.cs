using NDDD.Domain;

namespace NDDD.WinForm.Views
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();

            toolStripStatusLabel1.Visible = false;
#if DEBUG
            toolStripStatusLabel1.Visible = true;
#endif
            UserIdLabel.Text = Shared.LoginId;
        }
    }
}
