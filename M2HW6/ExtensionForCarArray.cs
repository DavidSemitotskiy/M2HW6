using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW6
{
    public static class ExtensionForCarArray
    {
        public static Car[] AddCar(this Car[] cars, Car car)
        {
            if (cars == null)
            {
                return null;
            }

            if (car == null)
            {
                return cars;
            }

            Car[] newCars = new Car[cars.Length + 1];
            Array.Copy(cars, newCars, cars.Length);
            newCars[cars.Length] = car;
            return newCars;
        }

        public static Car[] DeleteCar(this Car[] cars, Car car)
        {
            if (cars == null)
            {
                return null;
            }

            if (car == null)
            {
                return cars;
            }

            Car[] newCars = new Car[cars.Length - 1];
            int count = 0;
            for (int i = 0, j = 0; j < cars.Length; j++)
            {
                if (cars[i].Name == car.Name)
                {
                    if (count == 0)
                    {
                        count++;
                        continue;
                    }
                }

                newCars[i] = cars[j];
                i++;
            }

            return newCars;
        }
    }
}
