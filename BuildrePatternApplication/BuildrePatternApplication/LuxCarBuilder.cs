using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternApplication
{
    class LuxCarBuilder : AbstractCarBuilder
    {
        public override void SetCarDoors()
        {
            BuildedCar.Doors = "LuxDoors";
        }

        public override void SetCarEngine()
        {
            BuildedCar.Engine = "LuxEngine";
        }

        public override void SetCarWheels()
        {
            BuildedCar.Wheels = "LuxWheels";
        }
    }
}
