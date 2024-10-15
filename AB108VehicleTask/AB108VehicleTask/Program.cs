
#region Notes

//Constructor - Object instance alınan zaman(yəni obbyekt new-lanan zaman başqa bir dildə desək Class-dan obyekt yaranan zaman) işə düşən return type-ı OLMAYAN bir kod blokudur.

//Parameterless - Default - Boş Constructor.

//Constructor bir başa olaraq yalnız 1 constructor-u call edə bilər.

//This keyword-ü işlətdiyimiz class-ın obyektini işarə edir.
#endregion


using AB108VehicleTask;


Car myNewCar = new("M5", "BMW", 65, 0.35, 2005);

myNewCar.currentFuel = 5;
myNewCar.Drive(100);
