using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternApplication
{
    abstract class AbstractCarBuilder
    {
        public Car BuildedCar { get; private set; }

        public AbstractCarBuilder()
        {
            BuildedCar = new Car();
        }

        public abstract void SetCarEngine();
        public abstract void SetCarDoors();
        public abstract void SetCarWheels();

    }
}
