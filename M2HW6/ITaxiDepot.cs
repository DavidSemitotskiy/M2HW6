using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2HW6
{
    public interface ITaxiDepot
    {
        public Car[] Cars { get; }
        decimal TotalPrice { get; }
        void DeleteCar();
        void AddCar(Car car);
    }
}
