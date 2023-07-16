using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.Domain.StaticValues;
using NDDD.Domain.ValueObjects;
using NDDD.Infrastructure;
using System.Transactions;

namespace NDDD.WinForm.ViewModels
{
    public class LatestViewModel : ViewModelBase
    {
        private MeasureRepository _measureRepository;
        //private MeasureEntity _measure;

        private string _areaIdText = string.Empty;
        private string _measureDateText = string.Empty;
        private string _measureValueText = string.Empty;

        public LatestViewModel():this(Factories.CreateMeasure()) {

        }
        public LatestViewModel(IMeasureRepository measureRepository)
        {
            _measureRepository = new MeasureRepository(measureRepository);
        }

        public string AreaIdText {
            get { return _areaIdText; }
            set { SetProperty(ref _areaIdText, value); }
        }
        public string MeasureDateText {
            get{ return _measureDateText; }
            set { SetProperty(ref _measureDateText, value); }
        }
        public string MeasureValueText {
            get{ return _measureValueText; }
            set { SetProperty(ref _measureValueText, value); }
        }

        public void Search()
        {
            //var measure = _measureRepository.GetLatest();
            var measure = Measures.GetLatest(new AreaId(20));
            AreaIdText = measure.AreaId.DisplaValue;
            MeasureDateText = measure.MeasureDate.DisplaValue;
            MeasureValueText = measure.MeasureValue.DisplaValue;
            base.OnPropertyChanged();
        }
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
