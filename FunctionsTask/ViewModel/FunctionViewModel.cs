using FunctionsTask.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using FunctionsTask.View;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsTask.ViewModel
{
    public class FunctionViewModel
    {
        public FunctionViewModel()
        {
            // Инициализируем список типов уравнений
            FunctionTypes = new ObservableCollection<string>
            {
                "линейная",
                "квадратичная",
                "кубическая",
                "4-ой степени",
                "5-ой степени"
            };

            AddFunctionCommand = new RelayCommand(AddCoefficients);
            Functions = new ObservableCollection<FunctionModel>();
        }

        // Список типов уравнений
        public ObservableCollection<string> FunctionTypes { get; set; }

        // Данные уравнений
        private ObservableCollection<FunctionModel> _functions { get; set; } = new ObservableCollection<FunctionModel>();
        public ObservableCollection<FunctionModel> Functions
        {
            get { return _functions; }
            set
            {
                _functions = value;
                OnPropertyChanged(nameof(Functions)); // Передаем имя свойства "Equations"
            }
        }

        private double _type;
        public double Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type)); // Передача имени свойства "Type"
            }
        }


        private double _coefficientA;
        public double CoefficientA
        {
            get { return _coefficientA; }
            set
            {
                _coefficientA = value;
                OnPropertyChanged(nameof(CoefficientA)); // Передача имени свойства "CoefficientA"
            }
        }


        private double _coefficientB;
        public double CoefficientB
        {
            get { return _coefficientB; }
            set
            {
                _coefficientB = value;
                OnPropertyChanged(nameof(CoefficientB)); // Передача имени свойства "CoefficientB"
            }
        }

        private double _coefficientC;
        public double CoefficientC
        {
            get { return _coefficientC; }
            set
            {
                _coefficientC = value;
                OnPropertyChanged(nameof(CoefficientC)); // Передача имени свойства "CoefficientC"
            }
        }

        private double _result;
        public double Result
        {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result)); // Передача имени свойства "Result"
            }
        }

        public ICommand AddFunctionCommand { get; }

        private void RecognitionDegrees()
        {
            // EquationDegreeX = Type * ...
            // EquationDegreeY = Type * ...
        }

        private void AddCoefficients(object parameter)
        {
            Functions.Add(new FunctionModel { CoefficientA = CoefficientA, CoefficientB = CoefficientB, CoefficientC = CoefficientC, X = 1, Y = 1 });
            Calculate(Functions);
        }

        private void Calculate(IEnumerable<FunctionModel> functions)
        {
            // Реализация вычисления результата для каждого уравнения    
            //Result = (CoefficientA * X ^ EquationDegreeX) + (CoefficientB * Y ^ EquationDegreeY) + CoefficientC
            foreach (var function in functions)
            {
                double result = CalculateResult(function);
                function.Result = result;
            }
        }

        private double CalculateResult(FunctionModel function)
        {
            // Вычисление результата для каждого уравнения
            double result = (function.CoefficientA * Math.Pow(function.X, 1))
                          + (function.CoefficientB * Math.Pow(function.Y, 1))
                          + function.CoefficientC;
            return result;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
