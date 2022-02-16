using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW6
{
    public class PassengerCarFactory : ICarFactory
    {
        public Car CreateCar(Enum carType)
        {
            if (carType is PassengerCars)
            {
                switch (carType)
                {
                    case PassengerCars.OpelComboLife:
                        return new PassengerCar(PassengerCars.OpelComboLife.ToString(), 5321m, 3.9m, 4);
                    case PassengerCars.HyundaiH1:
                        return new PassengerCar(PassengerCars.HyundaiH1.ToString(), 3331m, 3.7m, 5);
                    case PassengerCars.VolkswagenCaddyIV:
                        return new PassengerCar(PassengerCars.VolkswagenCaddyIV.ToString(), 4713m, 4.6m, 5);
                }
            }

            throw new ArgumentException("Необходимо передавать переменную типа PassengerCars!!");
        }
    }
}
