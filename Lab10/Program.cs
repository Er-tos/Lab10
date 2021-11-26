using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение градусов Вашего угла:");
            int angle_grad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение минут Вашего угла:");
            int angle_min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение секунд Вашего угла:");
            int angle_sec = Convert.ToInt32(Console.ReadLine());
            MyDegrees experimentWithMyDegrees = new MyDegrees(angle_grad, angle_min, angle_sec); 
            double myDegreesInRadians = experimentWithMyDegrees.ToRadians();
            Console.WriteLine("Значение Вашего угла в радианах: {0}", Math.Round(myDegreesInRadians, 3));
            Console.ReadKey();
        }
    }
    class MyDegrees
    {
        static int grad;
        static int min;
        static int sec;
        public int Gradus
        {
            set
            {
                if ((value >= 0) && (value < 360))
                {
                    grad = value;
                }
                else
                {
                    Console.WriteLine("Значение угла может быть в диапозоне от 0 до 359 градусов");
                }
            }
            get
            {
                return grad;
            }
        }
        public int Min
        {
            set
            {
                if ((value >= 0) && (value < 60))
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Значение может быть в диапозоне от 0 до 59 минут");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if ((value >= 0) && (value < 60))
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Значение может быть в диапозоне от 0 до 59 секунд");
                }
            }
            get
            {
                return sec;
            }
        }
        public MyDegrees(int gradusForCalculations = 0, int minForCalculations = 0, int secForCalculations = 0)
        {
            if ((gradusForCalculations >= 0) && (gradusForCalculations < 360))
            {
                grad = gradusForCalculations;
            }
            else
            {
                Console.WriteLine("Значение может быть в диапозоне от 0 до 359 градусов!");
                Console.ReadKey();
                Environment.Exit(1);
            }
            if ((minForCalculations >= 0) && (minForCalculations < 60))
            {
                min = minForCalculations;
            }
            else
            {
                Console.WriteLine("Значение может быть в диапозоне от 0 до 59 минут!");
                Console.ReadKey();
                Environment.Exit(1);
            }
            if ((secForCalculations >= 0) && (secForCalculations < 60))
            {
                sec = secForCalculations;
            }
            else
            {
                Console.WriteLine("Значение может быть в диапозоне от 0 до 59 секунд!");
                Console.ReadKey();
                Environment.Exit(1);
            }
        }
        public double ToRadians()
        {
            double radians;
            radians = (grad * Math.PI / 180) + (min * Math.PI / (180 * 60)) + (sec * Math.PI / (180 * 60 * 60));
            return radians;
        }
    }
}
