using ChainingAssertion;
using NDDD.WinForm.ViewModels;

namespace NDDDTests.Test.ViewModelTests
{
    [TestClass]
    public class LatestViewModelTest
    {
        [TestMethod]
        public void �V�i���I()
        {
            var vm = new LatestViewModel();
            //�G���AID
            //�v������
            //�v���l

            vm.Search();
            vm.AreaIdText.Is("0001");
            vm.MeasureDateText.Is("2012/12/12 12:34:56");
            vm.MeasureValueText.Is("12.34��");
        }
    }
}