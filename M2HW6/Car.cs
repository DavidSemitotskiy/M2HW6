using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW6
{
    public abstract class Car : IComparable<Car>
    {
        public Car(string name, decimal price, decimal fuelConsumption)
        {
            Name = name;
            Price = price;
            FuelConsumption = fuelConsumption;
        }

        public string Name { get; }
        public decimal Price { get; }
        public decimal FuelConsumption { get; }
        public Gear Gear { get; private set; } = Gear.N;
        public abstract void ChangeGear();

        public virtual void Move()
        {
            ChangeGear();
            Console.WriteLine("Я еду!");
        }

        public int CompareTo(Car? other)
        {
            return FuelConsumption.CompareTo(other.FuelConsumption);
        }

        public virtual string GetDescription()
        {
            return $"Марка - {Name} : Цена - {Price}$ : Расход топлива на 100 км - {FuelConsumption} л";
        }
    }
}
