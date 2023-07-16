using NDDD.Domain;
using NDDD.Domain.Exceptions;

namespace NDDD.WinForm.Views
{
    /// <summary>
    /// Viewの基底クラス
    /// </summary>
    public partial class BaseForm : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BaseForm()
        {
            InitializeComponent();

            toolStripStatusLabel1.Visible = false;
#if DEBUG
            toolStripStatusLabel1.Visible = true;
#endif
            UserIdLabel.Text = Shared.LoginId;
        }

        /// <summary>
        /// ログ
        /// </summary>
        private static log4net.ILog _logger =
            log4net.LogManager.GetLogger(
                System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// 例外共通処理
        /// </summary>
        /// <param name="ex"></param>
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

        private void BaseForm_Load(object sender, EventArgs e)
        {
            _logger.Info("open:" + this.Name);
        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _logger.Info("close:" + this.Name);
        }
    }
}
