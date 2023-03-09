using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_3
{
    public class Circle
    {
        private double _radius;
        private double _centerX;
        private double _centerY;
        private double _pointX;
        private double _pointY;

        public Circle(double radius, double centerX, double centerY, double pointX, double pointY)
        {
            _radius = radius;
            _centerX = centerX;
            _centerY = centerY;
            _pointX = pointX;
            _pointY = pointY;
        }
        public double Area()
        {
            return Math.PI * _radius * _radius;
        }

        public double Circumference()
        {
            return 2 * Math.PI * _radius;
        }
        public double Radius { get { return _radius; } }
        public double CenterX { get { return _centerX; } }
        public double CenterY { get { return _centerY; } }

        public string Check() {
            double Eps = 0.000001;
            double length = Math.Sqrt(Math.Pow((_pointX - _centerX), 2) + Math.Pow((_pointY - _centerY), 2));
            if (Math.Abs(length - _radius) > Eps) {
                if ((length - _radius) > Eps)
                {

                    return "Точка поза колом";
                }
                else {
                    return "Точка в колі";
                }
            }
            else 
            {
                return "Точка в крузі";
            }
        }
    }
}