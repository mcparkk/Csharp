using EventLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Maserati = new Car("삼지창", 150, "white");

            Maserati.SpeedChanged += Car_SpeedChanged;
            Maserati.SpeedChanging += Car_SpeedChanging;
            Maserati.ColorChanged += Car_ColorChanged;
            Maserati.ColorChanging += Car_ColorChanging;


            Console.WriteLine("before upgrade speed: " + Maserati._speed + " / before upgrade color : " + Maserati._color);

            Maserati.Upgrade();
        }

        private static void Car_ColorChanging(object sender, Car.ColorChangingEventArgs e)
        {
            Console.WriteLine("Color 변경 ? : yes->1 or no->2");
            string answer = Console.ReadLine();
            if (answer == "2")
            { e.No = true; }
            else
            {
                Console.WriteLine("색상을 입력해주세요 :");
                string colorAnswer = Console.ReadLine();
                e.UserColor = colorAnswer;
            }
        }

        private static void Car_ColorChanged(object sender, Car.ColorChangedEventArgs e)
        {
            Console.WriteLine($"색상이 {e.DefultColor}에서 {e.NewColor}로 변경되었습니다.");
        }

        private static void Car_SpeedChanging(object sender, Car.SpeedChangingEventArgs e)
        {
            Console.WriteLine("Speed 업그래이드 진행 ? : yes->1 or no->2");
            string answer = Console.ReadLine();
            if (answer == "2")
                e.Cancel = true;

        }

        private static void Car_SpeedChanged(object sender, Car.SpeedChangedEventArgs e)
        {
            Console.WriteLine($"최고속도가 {e.BeforeSpeed}에서 {e.AfterSpeed}로 업그래이드 되었습니다.");
        }
    }
}
