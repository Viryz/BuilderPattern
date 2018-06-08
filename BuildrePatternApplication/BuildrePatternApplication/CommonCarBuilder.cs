using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternApplication
{
    class CommonCarBuilder : AbstractCarBuilder
    {
        public override void SetCarDoors()
        {
            BuildedCar.Doors = "CommonDoors";
        }

        public override void SetCarEngine()
        {
            BuildedCar.Engine = "CommonEngine";
        }

        public override void SetCarWheels()
        {
            BuildedCar.Wheels = "CommonWheels";
        }
    }
}
