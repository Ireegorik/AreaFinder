using System;
using System.Collections.Generic;
using System.Text;

namespace AreaFinder
{

    public abstract class Figure
    {
        string name { get; set; }

        public Figure(string Name)
        {
            name = Name;
        }

        abstract public float CalcArea();
    }

    public class Circle : Figure
    {

        float radius { get; set; }

        public Circle(string Name, float Radius) : base(Name)
        {
            radius = Radius;
        }

        public override float CalcArea()
        {
            return 3.14f * (radius * radius);
        }

    }

    public class Triangle : Figure
    {
        float a { get; set; }
        float b { get; set; }
        float c { get; set; }

        public Triangle(string Name, float A, float B, float C) : base(Name)
        {
            a = A;
            b = B;
            c = C;
        }
        public Triangle(string Name, float A, float C) : base(Name)
        {
            a = A;
            b = A;
            c = C;
        }
        public Triangle(string Name, float A) : base(Name)
        {
            a = A;
            b = A;
            c = A;
        }

        public override float CalcArea()
        {
            float maxSide = c,
                  firstSide = a,
                  secondSide = b;

            if (c > a && c > b)
            {
                maxSide = c;
                firstSide = a;
                secondSide = b;
            }
            else if (a > c && a > b)
            {
                maxSide = a;
                firstSide = c;
                secondSide = b;
            }
            else if (a > c && a > b)
            {
                maxSide = b;
                firstSide = a;
                secondSide = c;
            }
            else if (a == b && b == c)
            {
                maxSide = a;
                firstSide = a;
                secondSide = a;
            }


            if (firstSide * firstSide + secondSide * secondSide == maxSide * maxSide)
            {
                return (firstSide * secondSide) / 2;
            }
            else
            {
                float p = (maxSide + firstSide + secondSide) / 2;

                return (float)Math.Sqrt(p * ((p - maxSide) * (p - firstSide) * (p - secondSide)));
            }


        }

    }


}
