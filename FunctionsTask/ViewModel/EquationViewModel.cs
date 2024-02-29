using FunctionsTask.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsTask.ViewModel
{
    public class FunctionViewModel
    {
        public ObservableCollection<FunctionModel> Equations { get; set; } = new ObservableCollection<FunctionModel>();

        private double _CoefficientA;
        public double CoefficientA;

        private double _CoefficientB;
        public double CoefficientB;

        private double _CoefficientC;
        public double CoefficientC;

        private void RecognitionDegrees()
        {
            // EquationDegreeX = Type * ...
            // EquationDegreeY = Type * ...
        }

        private void AddCoefficients()
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
