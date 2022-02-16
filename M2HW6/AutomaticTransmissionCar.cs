using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW6
{
    public class AutomaticTransmissionCar : PassengerCar
    {
        public AutomaticTransmissionCar(string name, decimal price, decimal fuelConsumption, int countPassengerPlace)
            : base(name, price, fuelConsumption, countPassengerPlace)
        {
        }

        public bool ReadyToChangeGear { get; private set; } = false;

        public override void ChangeGear()
        {
            ReadyToChangeGear = true;
            Random random = new Random();
            Console.WriteLine($"Меняю передачу на {(Gear)random.Next(3)}");
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()} : Готовность переключать передачу - {ReadyToChangeGear}";
        }
    }
}
