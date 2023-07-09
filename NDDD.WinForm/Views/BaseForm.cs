using NDDD.Domain;
using NDDD.Domain.Exceptions;

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

        protected void ExceptionProc(Exception ex)
        {
            MessageBoxIcon icon = MessageBoxIcon.Error;
            string caption = "エラー";
            var exceptionBase = ex as ExceptionBase;
            if (exceptionBase != null)
            {
                switch (exceptionBase.Kind)
                {
                    case ExceptionBase.ExceptionKind.Info:
                        icon = MessageBoxIcon.Information;
                        caption = "情報";
                        break;
                    case ExceptionBase.ExceptionKind.Warning:
                        icon = MessageBoxIcon.Warning;
                        caption = "警告";
                        break;
                    default:
                        break;
                }
            }
            MessageBox.Show(ex.Message, caption, MessageBoxButtons.OK, icon);
        }
    }
}
