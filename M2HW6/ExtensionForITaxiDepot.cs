using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW6
{
    public static class ExtensionForITaxiDepot
    {
        public static Car[] SearchCarByRating(this ITaxiDepot taxiDepot, Rating rating)
        {
            if (taxiDepot == null || taxiDepot.Cars == null)
            {
                return null;
            }

            Car[] newCars = Array.Empty<Car>();
            for (int i = 0; i < taxiDepot.Cars.Length; i++)
            {
                if (taxiDepot.Cars[i] is BusinessCar car)
                {
                    if (car.Rating == rating)
                    {
                        newCars = newCars.AddCar(taxiDepot.Cars[i]);
                    }
                }
            }

            return newCars;
        }
    }
}
