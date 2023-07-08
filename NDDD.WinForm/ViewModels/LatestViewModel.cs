using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.Infrastructure;

namespace NDDD.WinForm.ViewModels
{
    public class LatestViewModel : ViewModelBase
    {
        private IMeasureRepository _measureRepository;
        //private MeasureEntity _measure;

        private string _areaIdText = string.Empty;
        private string _measureDateText = string.Empty;
        private string _measureValueText = string.Empty;

        public LatestViewModel():this(Factories.CreateMeasure()) {

        }
        public LatestViewModel(IMeasureRepository measureRepository)
        {
            _measureRepository = measureRepository;
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
            var measure = _measureRepository.GetLatest();
            AreaIdText = measure.AreaId.DisplaValue;
            MeasureDateText = measure.MeasureDate.DisplaValue;
            MeasureValueText = measure.MeasureValue.DisplaValue;
            base.OnPropertyChanged();
        }
    }
}
