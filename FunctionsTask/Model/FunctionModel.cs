using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsTask.Model
{
    public class FunctionModel
    {
        private string _type;
        private double _coefficientA;
        private double _coefficientB;
        private double _coefficientC;
        private double _x;
        private double _functionDegreeX;
        private double _y;
        private double _functionDegreeY;
        private double _result;

        /// <summary>
        /// Тип функции
        /// </summary>
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        /// <summary>
        /// Коэффициент A в функции
        /// </summary>
        public double CoefficientA
        {
            get { return _coefficientA; }
            set { _coefficientA = value; }
        }

        /// <summary>
        /// Коэффициент B в функции
        /// </summary>
        public double CoefficientB
        {
            get { return _coefficientB; }
            set { _coefficientB = value; }
        }

        /// <summary>
        /// Коэффициент C в функции
        /// </summary>
        public double CoefficientC
        {
            get { return _coefficientC; }
            set { _coefficientC = value; }
        }

        /// <summary>
        /// X в функции
        /// </summary>
        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// Степень X в функции
        /// </summary>
        public double FunctionDegreeX
        {
            get { return _functionDegreeX;  }
            set { _functionDegreeX = value; }
        }

        /// <summary>
        /// Y в функции
        /// </summary>
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// Степень X в функции
        /// </summary>
        public double FunctionDegreeY
        {
            get { return _functionDegreeY; }
            set { _functionDegreeY = value; }
        }

        /// <summary>
        /// Результат функции
        /// </summary>
        public double Result
        {
            get { return _result; }
            set { _result = value; }
        }
    }
}
