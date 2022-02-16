using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW6
{
    public class AutomaticTransmissionCarFactory : ICarFactory
    {
        public Car CreateCar(Enum carType)
        {
            if (carType is AutomaticTransmissionCars)
            {
                switch (carType)
                {
                    case AutomaticTransmissionCars.HyundaiAccent:
                        return new AutomaticTransmissionCar(AutomaticTransmissionCars.HyundaiAccent.ToString(), 7321.12m, 5.12m, 4);
                    case AutomaticTransmissionCars.RioSedan:
                        return new AutomaticTransmissionCar(AutomaticTransmissionCars.RioSedan.ToString(), 9321.12m, 3.62m, 4);
                    case AutomaticTransmissionCars.Bmwm140I:
                        return new AutomaticTransmissionCar(AutomaticTransmissionCars.Bmwm140I.ToString(), 8521.12m, 5.22m, 4);
                }
            }

            throw new ArgumentException("Необходимо передавать переменную типа AutomaticTransmissionCars!!");
        }
    }
}
