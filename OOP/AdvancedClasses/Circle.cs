using System;

namespace AdvancedClasses
{
    /*public class DenseTriangle : Triangle
    {
        public DenseTriangle(double sideA, double sideB, double sideC) : base(sideA, sideB, sideC)
        {

        }
    }*/

    public class Circle : Shape
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        public override double Area() => Math.PI * _radius * _radius;
    }
}
