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
            AddEquationCommand = new RelayCommand(AddCoefficients);
            Equations = new ObservableCollection<FunctionModel>();
        }

        private ObservableCollection<FunctionModel> _equations { get; set; } = new ObservableCollection<FunctionModel>();
        public ObservableCollection<FunctionModel> Equations
        {
            get { return _equations; }
            set
            {
                _equations = value;
                OnPropertyChanged(nameof(Equations)); // Передаем имя свойства "Equations"
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

        public ICommand AddEquationCommand { get; }

        private void RecognitionDegrees()
        {
            // EquationDegreeX = Type * ...
            // EquationDegreeY = Type * ...
        }

        private void AddCoefficients(object parameter)
        {
            Equations.Add(new FunctionModel { CoefficientA = CoefficientA, CoefficientB = CoefficientB, CoefficientC = CoefficientC });
        }

        private void Calculate()
        {
            // Реализация вычисления результата для каждого уравнения    
            // Result = (CoefficientA * X ^ EquationDegreeX) + (CoefficientB * Y ^ EquationDegreeY) + CoefficientC
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
