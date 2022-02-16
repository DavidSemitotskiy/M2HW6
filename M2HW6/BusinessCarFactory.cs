using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW6
{
    public class BusinessCarFactory : ICarFactory
    {
        public Car CreateCar(Enum carType)
        {
            if (carType is BusinessCars)
            {
                switch (carType)
                {
                    case BusinessCars.FordMondeo:
                        return new BusinessCar(BusinessCars.FordMondeo.ToString(), 23432.1m, 9.2m, 4, Rating.ThreeStar);
                    case BusinessCars.KIAK5:
                        return new BusinessCar(BusinessCars.KIAK5.ToString(), 25432.1m, 11.2m, 4, Rating.TwoStar);
                    case BusinessCars.ToyotaCamry:
                        return new BusinessCar(BusinessCars.ToyotaCamry.ToString(), 20332.1m, 12.2m, 4, Rating.OneStar);
                }
            }

            throw new ArgumentException("Необходимо передавать переменную типа BusinessCars!!");
        }
    }
}
