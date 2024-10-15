
//Gerəksiz olan Namespace-lər CTRL + R + G vasitəsi ilə silinir.
namespace AB108VehicleTask;

public class Vehicle
{
    public string color;
    public int year;


    public Vehicle(int year)
    {
        this.year = year;
        Console.WriteLine(year);
    }
}

public class Car : Vehicle
{
    public string brand;
    public string model;
    public double fuelCapacity;
    public double fuelForOneKm;
    public double currentFuel;

    public Car(string model, string brand, double fuelCapacity, double fuelForOneKm, int year) : base(year)
    {
        this.brand = brand;
        this.model = model;
        this.fuelCapacity = fuelCapacity;
        this.fuelForOneKm = fuelForOneKm;
    }


    public void ShowInfo()
    {
        Console.WriteLine($"Car brand: {brand}");
    }

    public void Drive(double distance)
    {

        double totalDistanceWithCurrentFuel = currentFuel / fuelForOneKm;
        if (totalDistanceWithCurrentFuel - distance >= 0)
        {
            currentFuel = (totalDistanceWithCurrentFuel - distance) * fuelForOneKm;
            Console.WriteLine($"{distance}KM yol qət edildi. Qalan yanacaq:{currentFuel}l");
        }
        else
        {
            Console.WriteLine($"Hazirdaki benzinle({currentFuel}) yalnızca {currentFuel / fuelForOneKm} KM yol qət edə bilərsiniz. Əgər hələ də bu yolu getmək istəyirsinizsə {(distance - totalDistanceWithCurrentFuel) * fuelForOneKm}l benzinə ehtiyyacınız var");

            Console.WriteLine("Daççik özünü öldürür, zəhmət olmasa benzin vur.");
        }

    }


}
