using ChainingAssertion;
using Moq;
using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.WinForm.ViewModels;

namespace NDDDTests.Test.ViewModelTests
{
    [TestClass]
    public class LatestViewModelTest
    {
        [TestMethod]
        public void �V�i���I()
        {
            var entity = new MeasureEntity(
                1,
                Convert.ToDateTime("2012/12/12 12:34:56"),
                12.341f);
            var measureMock = new Mock<IMeasureRepository>();
            measureMock.Setup(x => x.GetLatest()).Returns(entity);
            var vm = new LatestViewModel(measureMock.Object);
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