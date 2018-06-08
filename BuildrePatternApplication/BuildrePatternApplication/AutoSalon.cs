using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternApplication
{
    class AutoSalon
    {
        public Car BuildCar(AbstractCarBuilder carBuilder)
        {
            carBuilder.SetCarEngine();
            carBuilder.SetCarDoors();
            carBuilder.SetCarWheels();

            return carBuilder.BuildedCar;
        }
    }
}
