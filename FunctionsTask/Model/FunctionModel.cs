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

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public double CoefficientA
        {
            get { return _coefficientA; }
            set { _coefficientA = value; }
        }

        public double CoefficientB
        {
            get { return _coefficientB; }
            set { _coefficientB = value; }
        }

        public double CoefficientC
        {
            get { return _coefficientC; }
            set { _coefficientC = value; }
        }

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        public double FunctionDegreeX
        {
            get { return _functionDegreeX;  }
            set { _functionDegreeX = value; }
        }

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public double FunctionDegreeY
        {
            get { return _functionDegreeY; }
            set { _functionDegreeY = value; }
        }

        public double Result
        {
            get { return _result; }
            set { _result = value; }
        }
    }
}
