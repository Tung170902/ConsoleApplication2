using System;

namespace ConsoleApplication2.Program
{
    public class Cylinder
    {
        public double Radius;
        public double Height;
        public double BaseArea;
        public double LateralArea;
        public double TotalArea;
        public double Volume;

        
        
        public void Process()
        {
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }

        public void Result()
        {
            Console.WriteLine("Base: " + BaseArea + "; " + "Lateral: " + LateralArea + "; " + "Total: " + TotalArea + "; " + "Volume: " + Volume);
        }

        public static void Main(string[] args)
        {
            Cylinder cl = new Cylinder();
            Console.WriteLine("Radius: ");
            cl.Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Height: ");
            cl.Height = Convert.ToDouble(Console.ReadLine());
            cl.Process();
            cl.Result();
        }
    }
}