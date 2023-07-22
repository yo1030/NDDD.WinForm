using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Threading;

namespace NDDD.WinForm.ViewModels
{
    /// <summary>
    /// ViewModelの基底クラス
    /// </summary>
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        private readonly Dispatcher _dispatcher;

        protected ViewModelBase(Dispatcher dispatcher)
        {
            _dispatcher = dispatcher;
        }

        /// <summary>
        /// PropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// SetProperty
        /// </summary>
        /// <typeparam name="T">T</typeparam>
        /// <param name="field">field</param>
        /// <param name="value">value</param>
        /// <param name="propertyName">propertyName</param>
        /// <returns>returns</returns>
        protected bool SetProperty<T>(
            ref T field,
            T value,
            [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value))
            {
                return false;
            }

            field = value;
            var h = this.PropertyChanged;
            if (h != null)
            {
                _dispatcher.Invoke(delegate ()
                {
                    h(this, new PropertyChangedEventArgs(propertyName));
                });
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual DateTime GetDateTime()
        {
            return DateTime.Now;
        }

        /// <summary>
        /// 変更時にイベント呼び出し
        /// </summary>
        public void OnPropertyChanged()
        {
            PropertyChanged.Invoke(
                this,
                new PropertyChangedEventArgs(""));
        }
    }
}
