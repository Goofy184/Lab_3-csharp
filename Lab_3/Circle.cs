using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab_3
{
    public class Point
    {
        private double _pointX;
        private double _pointY;
        public double X
        {
            get
            {
                return _pointX;
            }
            set
            {
                _pointX = value;
            }
        }
        public double Y
        {
            get
            {
                return _pointY;
            }
            set
            {
                _pointY = value;
            }
        }
        public Point(double pointX, double pointY)
        {
            _pointX = pointX;
            _pointY = pointY;
        }
    }
    public class Circle
    {
        private double _radius;
        private Point _centerPoint;
        public Circle(double radius, Point centerPoint)
        {
            _radius = radius;
            _centerPoint = centerPoint;
        }
        public double Area()
        {
            return Math.PI * _radius * _radius;
        }

        public double Circumference()
        {
            return 2 * Math.PI * _radius;
        }

        public bool Check(Point point) {

            double Eps = 0.000001;
            double length = Math.Sqrt(Math.Pow((point.X - _centerPoint.X), 2) + Math.Pow((point.Y - _centerPoint.Y), 2));
            if (Math.Abs(length - _radius) > Eps) {
                if ((length - _radius) > Eps)
                {
                    return false;
                }
                else {
                    return true;
                }
            }
            else 
            {
                return true;
            }
        }
    }
}