using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoSalon autoSalon = new AutoSalon();
            AbstractCarBuilder carBuilder = new LuxCarBuilder();

            Car luxCar = autoSalon.BuildCar(carBuilder);
            Console.WriteLine(luxCar.ToString());

            carBuilder = new CommonCarBuilder();
            Car commonCar = autoSalon.BuildCar(carBuilder);
            Console.WriteLine(commonCar.ToString());

            Console.ReadLine();
        }
    }
}
