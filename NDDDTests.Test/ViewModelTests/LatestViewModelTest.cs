using ChainingAssertion;
using Moq;
using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using NDDD.Domain.StaticValues;
using NDDD.WinForm.BackgroundWorkers;
using NDDD.WinForm.ViewModels;
using System.Windows.Threading;

namespace NDDDTests.Test.ViewModelTests
{
    [TestClass]
    public class LatestViewModelTest
    {
        [TestInitialize]
        public void Initialize()
        {
            Measures.Clear();
        }

        [TestMethod]
        public void シナリオ1()
        {
            //Measures.Count.Is(0);

            var entity = new MeasureEntity(
                1,
                Convert.ToDateTime("2012/12/12 12:34:56"),
                12.341f);
            var entities = new List<MeasureEntity>();
            entities.Add(entity);

            var measureMock = new Mock<IMeasureRepository>();
            measureMock.Setup(x => x.GetLatests()).Returns(entities);
            Dispatcher dispatcher = Dispatcher.CurrentDispatcher;


            ///タイマー実行時に行っている処理を実行
            Measures.Create(measureMock.Object);


            var vm = new LatestViewModel(dispatcher);
            //エリアID
            //計測日時
            //計測値

            vm.AreaIdText = "1";
            vm.Search();
            vm.MeasureDateText.Is("2012/12/12 12:34:56");
            vm.MeasureValueText.Is("12.34℃");
        }

        [TestMethod]
        public void シナリオ2()
        {
            //Measures.Count.Is(0);

            var entity = new MeasureEntity(
                1,
                Convert.ToDateTime("2012/12/12 12:34:56"),
                12.341f);
            var entities = new List<MeasureEntity>();
            entities.Add(entity);

            var measureMock = new Mock<IMeasureRepository>();
            measureMock.Setup(x => x.GetLatests()).Returns(entities);
            Dispatcher dispatcher = Dispatcher.CurrentDispatcher;


            ///タイマー実行時に行っている処理を実行
            //Measures.Create(measureMock.Object);
            LatestTimer.SetInterface(measureMock.Object);
            LatestTimer.Callback(null);

            var vm = new LatestViewModel(dispatcher);
            //エリアID
            //計測日時
            //計測値

            vm.AreaIdText = "1";
            vm.Search();
            vm.MeasureDateText.Is("2012/12/12 12:34:56");
            vm.MeasureValueText.Is("12.34℃");
        }
    }
}