using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.Domain.StaticValues;
using NDDD.Domain.ValueObjects;
using NDDD.Infrastructure;
using System.Transactions;
using System.Windows.Threading;

namespace NDDD.WinForm.ViewModels
{
    /// <summary>
    /// 直近値のViewModel
    /// </summary>
    public class LatestViewModel : ViewModelBase
    {
        /// <summary>
        /// 計測リポジトリ
        /// </summary>
        private MeasureRepository _measureRepository;
        //private MeasureEntity _measure;

        /// <summary>
        /// エリアID
        /// </summary>
        private string _areaIdText = string.Empty;

        /// <summary>
        /// 計測日時
        /// </summary>
        private string _measureDateText = string.Empty;

        /// <summary>
        /// 計測値
        /// </summary>
        private string _measureValueText = string.Empty;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public LatestViewModel(Dispatcher dispatcher) : this(dispatcher,Factories.CreateMeasure()) {

        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="measureRepository">計測リポジトリ</param>
        public LatestViewModel(Dispatcher dispatcher, IMeasureRepository measureRepository) : base(dispatcher)
        {
            _measureRepository = new MeasureRepository(measureRepository);
        }

        /// <summary>
        /// エリアID
        /// </summary>
        public string AreaIdText {
            get { return _areaIdText; }
            set { SetProperty(ref _areaIdText, value); }
        }

        /// <summary>
        /// 計測日時
        /// </summary>
        public string MeasureDateText {
            get{ return _measureDateText; }
            set { SetProperty(ref _measureDateText, value); }
        }

        /// <summary>
        /// 計測値
        /// </summary>
        public string MeasureValueText {
            get{ return _measureValueText; }
            set { SetProperty(ref _measureValueText, value); }
        }

        /// <summary>
        /// 検索
        /// </summary>
        public void Search()
        {
            //var measure = _measureRepository.GetLatest();
            var measure = Measures.GetLatest(new AreaId(20));
            AreaIdText = measure.AreaId.DisplaValue;
            MeasureDateText = measure.MeasureDate.DisplaValue;
            MeasureValueText = measure.MeasureValue.DisplaValue;
            base.OnPropertyChanged();
        }
        /// <summary>
        /// 保存
        /// </summary>
        public void Save()
        {
            using(TransactionScope scope  = new TransactionScope())
            {
                //ヘッダー
                //明細
                //在庫
                //履歴
                //顧客情報
                scope.Complete();
            }
        }
    }
}
