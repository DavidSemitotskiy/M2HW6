using M2HW6;
public class Program
{
    public void Main(string[] args)
    {
        PassengerCarFactory passengerCarFactory = new PassengerCarFactory();
        AutomaticTransmissionCarFactory automaticTransmissionCarFactory = new AutomaticTransmissionCarFactory();
        BusinessCarFactory businessCarFactory = new BusinessCarFactory();
        CabrioletFactory cabrioletFactory = new CabrioletFactory();
        TaxiDepot taxiDepot = new TaxiDepot(passengerCarFactory.CreateCar(PassengerCars.OpelComboLife), cabrioletFactory.CreateCar(CabrioletCars.BMWM4), businessCarFactory.CreateCar(BusinessCars.FordMondeo), automaticTransmissionCarFactory.CreateCar(AutomaticTransmissionCars.HyundaiAccent), passengerCarFactory.CreateCar(PassengerCars.VolkswagenCaddyIV));
        taxiDepot.AddCar(automaticTransmissionCarFactory.CreateCar(AutomaticTransmissionCars.Bmwm140I));
        Console.WriteLine("Массив автомобилей до сортировки:");
        taxiDepot.GetDescriptionCars();
        Array.Sort(taxiDepot.Cars);
        Console.WriteLine("Массив автомобилей после сортировки:");
        taxiDepot.GetDescriptionCars();
        taxiDepot.DeleteCar();
        Console.WriteLine("Массив после удаления автомобиля:");
        taxiDepot.GetDescriptionCars();
        Random random = new Random();
        Rating rating = (Rating)random.Next(1, 6);
        var result = taxiDepot.SearchCarByRating(rating);
        if (result == null || result.Length == 0)
        {
            Console.WriteLine($"Не было найдено машин с рейтингом - {rating}");
        }
        else
        {
            Console.WriteLine($"Автомобили с рейтингом - {rating}");
            foreach (var car in result)
            {
                Console.WriteLine(car.GetDescription());
            }
        }

        Console.WriteLine($"Стоимость таксопарка - {taxiDepot.TotalPrice}$");
    }
}
