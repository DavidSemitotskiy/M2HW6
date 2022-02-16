using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW6
{
    public class PassengerCar : Car
    {
        public PassengerCar(string name, decimal price, decimal fuelConsumption, int countPassengerPlace)
            : base(name, price, fuelConsumption)
        {
            CountPassengerPlace = countPassengerPlace;
        }

        public int CountPassengerPlace { get; }

        public override void ChangeGear()
        {
            Random random = new Random();
            Console.WriteLine($"Человек включил - {(Gear)random.Next(3)} передачу");
        }

        public override void Move()
        {
            Console.WriteLine("Я еду с среднестатистической скоростью!");
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()} : Количество пас мест - {CountPassengerPlace}";
        }
    }
}
