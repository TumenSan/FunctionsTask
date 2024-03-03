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
using System.Windows;

namespace FunctionsTask.ViewModel
{
    public class FunctionViewModel
    {
        public FunctionViewModel()
        {
            // Инициализируем список типов уравнений
            FunctionTypes = new ObservableCollection<string>
            {
                "Линейная",
                "Квадратичная",
                "Кубическая",
                "4-ой степени",
                "5-ой степени"
            };

            // Инициализируем список значений для коэффициента c для каждой функции
            CoefficientCValues = new ObservableCollection<double>();


            AddFunctionCommand = new RelayCommand(AddCoefficients);
            Functions = new ObservableCollection<FunctionModel>();
        }


        // Список типов уравнений
        public ObservableCollection<string> FunctionTypes { get; set; }

        // Список С зависящий от типов уравнений
        public ObservableCollection<double> CoefficientCValues { get; set; }

        private string _selectedFunctionType;
        public string SelectedFunctionType
        {
            get { return _selectedFunctionType; }
            set
            {
                _selectedFunctionType = value;
                OnPropertyChanged(nameof(SelectedFunctionType));

                // Обновляем список значений коэффициента c при изменении выбранной функции
                UpdateCoefficientCValues();
            }
        }


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

        private double _x;
        public double X
        {
            get { return _x; }
            set
            {
                _x = value;
                OnPropertyChanged(nameof(X)); // Передача имени свойства "X"
            }
        }

        private double _y;
        public double Y
        {
            get { return _y; }
            set
            {
                _y = value;
                OnPropertyChanged(nameof(Y)); // Передача имени свойства "Y"
            }
        }

        private void UpdateCoefficientCValues()
        {
            // Очищаем список значений коэффициента c
            CoefficientCValues.Clear();

            // Заполняем список значений в зависимости от выбранной функции
            switch (SelectedFunctionType)
            {
                case "Линейная":
                    CoefficientCValues.Add(1);
                    CoefficientCValues.Add(2);
                    CoefficientCValues.Add(3);
                    CoefficientCValues.Add(4);
                    CoefficientCValues.Add(5);
                    break;
                case "Квадратичная":
                    CoefficientCValues.Add(10);
                    CoefficientCValues.Add(20);
                    CoefficientCValues.Add(30);
                    CoefficientCValues.Add(40);
                    CoefficientCValues.Add(50);
                    break;
                case "Кубическая":
                    CoefficientCValues.Add(100);
                    CoefficientCValues.Add(200);
                    CoefficientCValues.Add(300);
                    CoefficientCValues.Add(400);
                    CoefficientCValues.Add(500);
                    break;
                case "4-ой степени":
                    CoefficientCValues.Add(1000);
                    CoefficientCValues.Add(2000);
                    CoefficientCValues.Add(3000);
                    CoefficientCValues.Add(4000);
                    CoefficientCValues.Add(5000);
                    break;
                case "5-ой степени":
                    CoefficientCValues.Add(10000);
                    CoefficientCValues.Add(20000);
                    CoefficientCValues.Add(30000);
                    CoefficientCValues.Add(40000);
                    CoefficientCValues.Add(50000);
                    break;
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


        private void RecognitionDegrees(FunctionModel function)
        {
            switch (function.Type)
            {
                case "Линейная":
                    function.FunctionDegreeX = 1;
                    function.FunctionDegreeY = 0;
                    break;
                case "Квадратичная":
                    function.FunctionDegreeX = 2;
                    function.FunctionDegreeY = 1;
                    break;
                case "Кубическая":
                    function.FunctionDegreeX = 3;
                    function.FunctionDegreeY = 2;
                    break;
                case "4-ой степени":
                    function.FunctionDegreeX = 4;
                    function.FunctionDegreeY = 3;
                    break;
                case "5-ой степени":
                    function.FunctionDegreeX = 5;
                    function.FunctionDegreeY = 4;
                    break;
            }
        }

        // Добавление коэффициентов
        public void AddCoefficients(object parameter)
        {
            if (string.IsNullOrEmpty(SelectedFunctionType))
            {
                ShowErrorMessage("Пожалуйста, выберите тип функции.");
                return;
            }

            if (CoefficientC == 0)
            {
                ShowErrorMessage("Пожалуйста, выберите C.");
                return;
            }

            Functions.Add(new FunctionModel 
            { 
                Type = SelectedFunctionType, 
                CoefficientA = CoefficientA, 
                CoefficientB = CoefficientB, 
                CoefficientC = CoefficientC, 
                X = X, 
                Y = Y
            });
            Calculate(Functions);
        }


        private void Calculate(IEnumerable<FunctionModel> functions)
        {
            // Вычисления результата для каждого уравнения    
            foreach (var function in functions)
            {
                RecognitionDegrees(function);
                double result = CalculateResult(function);
                function.Result = result;
            }
        }


        public double CalculateResult(FunctionModel function)
        {
            // Вычисление результата уравнения
            double result = (function.CoefficientA * Math.Pow(function.X, function.FunctionDegreeX))
                          + (function.CoefficientB * Math.Pow(function.Y, function.FunctionDegreeY))
                          + function.CoefficientC;
            return result;
        }


        // Обработчик изменении
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Сообщение об ошибке
        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }
}
