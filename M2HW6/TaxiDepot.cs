using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW6
{
    public class TaxiDepot : ITaxiDepot
    {
        private Car[] _cars;

        public TaxiDepot(params Car[] cars)
        {
            _cars = cars;
        }

        public Car[] Cars
        {
            get => _cars;
        }

        public decimal TotalPrice
        {
            get
            {
                decimal sum = 0;
                foreach (var car in _cars)
                {
                    sum += car.Price;
                }

                return sum;
            }
        }

        public void DeleteCar()
        {
            Random rand = new Random();
            Car car = _cars[rand.Next(_cars.Length)];
            Console.WriteLine($"Машина {car.Name} выехала с таксопарка");
            car.Move();
            _cars = _cars.DeleteCar(car);
        }

        public void AddCar(Car car)
        {
            Console.WriteLine($"Машина {car.Name} заехала в таксопарка");
            _cars = _cars.AddCar(car);
        }

        public void GetDescriptionCars()
        {
            for (int i = 0; i < _cars.Length; i++)
            {
                Console.WriteLine(_cars[i].GetDescription());
            }
        }
    }
}
