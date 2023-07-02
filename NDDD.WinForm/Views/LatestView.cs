using NDDD.WinForm.ViewModels;

namespace NDDD.WinForm.Views
{
    public partial class LatestView : BaseForm
    {
        private LatestViewModel _viewModel = new LatestViewModel();
        public LatestView()
        {
            InitializeComponent();

            AreaIdTextBox.DataBindings.Add(
                "Text",
                _viewModel,
                nameof(_viewModel.AreaIdText));
            MeasureDateTextBox.DataBindings.Add(
                "Text",
                _viewModel,
                nameof(_viewModel.MeasureDateText));
            MeasureValueTextBox.DataBindings.Add(
                "Text",
                _viewModel,
                nameof(_viewModel.MeasureValueText));
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            _viewModel.Search();
        }
    }
}
