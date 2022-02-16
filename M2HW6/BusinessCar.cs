using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW6
{
    public class BusinessCar : AutomaticTransmissionCar
    {
        public BusinessCar(string name, decimal price, decimal fuelConsumption, int countPassengerPlace, Rating rating)
            : base(name, price, fuelConsumption, countPassengerPlace)
        {
            Rating = rating;
        }

        public Rating Rating { get; }

        public override void Move()
        {
            Console.WriteLine("Еду быстрее среднестатистической скорости!");
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()} : Рейтинг - {Rating}";
        }
    }
}
