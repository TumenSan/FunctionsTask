using FunctionsTask;
using FunctionsTask.Model;
using FunctionsTask.ViewModel;

namespace FunctionTest
{
    [TestFixture]
    public class FunctionViewModelTests
    {
        private FunctionViewModel _viewModel;

        [SetUp]
        public void Setup()
        {
            _viewModel = new FunctionViewModel();
        }

        [Test]
        public void CalculateResult_LinearFunction()
        {
            var function = new FunctionModel
            {
                Type = "Линейная",
                CoefficientA = 1,
                CoefficientB = 2,
                CoefficientC = 3,
                X = 1,
                Y = 1
            };

            var result = _viewModel.CalculateResult(function);

            Assert.That(result, Is.EqualTo(6));
        }
    }
}