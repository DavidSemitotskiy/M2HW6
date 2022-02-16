using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW6
{
    public class CabrioletFactory : ICarFactory
    {
        public Car CreateCar(Enum carType)
        {
            if (carType is CabrioletCars)
            {
                switch (carType)
                {
                    case CabrioletCars.LexusLC500:
                        return new Cabriolet(CabrioletCars.LexusLC500.ToString(), 43123.35m, 15m, 4, Rating.FiveStar);
                    case CabrioletCars.MercedesBenzA238:
                        return new Cabriolet(CabrioletCars.MercedesBenzA238.ToString(), 54113m, 13m, 2, Rating.FourStar);
                    case CabrioletCars.BMWM4:
                        return new Cabriolet(CabrioletCars.BMWM4.ToString(), 55553.32m, 10m, 4, Rating.FiveStar);
                }
            }

            throw new ArgumentException("Необходимо передавать переменную типа CabrioletCars!!");
        }
    }
}
