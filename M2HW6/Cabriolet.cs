using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW6
{
    public class Cabriolet : BusinessCar
    {
        public Cabriolet(string name, decimal price, decimal fuelConsumption, int countPassengerPlace, Rating rating)
            : base(name, price, fuelConsumption, countPassengerPlace, rating)
        {
        }

        public bool IsOpenRoof { get; private set; }

        public override void Move()
        {
            Random random = new Random();
            IsOpenRoof = random.Next(2) == 0 ? true : false;
            if (IsOpenRoof)
            {
                Console.WriteLine("По велению пассажира крыша автомобиля была открыта!");
            }
            else
            {
                Console.WriteLine("По велению пассажира крыша автомобиля была закрыта!");
            }

            ChangeGear();
            base.Move();
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()} : Открыта ли крыша - {IsOpenRoof}";
        }
    }
}
