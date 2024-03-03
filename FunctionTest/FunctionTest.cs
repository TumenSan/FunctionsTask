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


        [Test]
        public void CalculateResult_QuadraticFunction()
        {
            var function = new FunctionModel
            {
                Type = "Квадратичная",
                CoefficientA = 1,
                CoefficientB = 2,
                CoefficientC = 3,
                X = 2,
                Y = 2
            };

            var result = _viewModel.CalculateResult(function);

            Assert.That(result, Is.EqualTo(15));
        }


        [Test]
        public void CalculateResult_CubicFunction()
        {
            var function = new FunctionModel
            {
                Type = "Кубическая",
                CoefficientA = 1,
                CoefficientB = 2,
                CoefficientC = 3,
                X = 3,
                Y = 3
            };

            var result = _viewModel.CalculateResult(function);

            Assert.That(result, Is.EqualTo(42));
        }
    }
}