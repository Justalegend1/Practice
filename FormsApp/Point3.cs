using System;
using System.Collections.Generic;
using System.Text;
using Pointlib;


namespace FormsApp
{
    [Serializable]
    public class  Point3: Point
    {
        public int Z { get; set; }


        public Point3() : base() {
            Z = rnd.Next(10);
        }
       
        public Point3(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public override double Metric()

        {

            return Math.Sqrt(X * X + Y * Y + Z * Z);

        }

        public override string ToString()

        {

            return string.Format($"({X} , {Y}, {Z})");

        }
    }
}
