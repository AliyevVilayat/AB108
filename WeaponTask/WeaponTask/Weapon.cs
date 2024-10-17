namespace WeaponTask;

public class Weapon
{
    public int BulletCapacity { get; set; }
    public int CurrentBulletsCount { get; set; }
    public float DischargeTime { get; set; }
    public string FireMod { get; set; }

    public Weapon()
    {

    }

    public Weapon(int bulletCapacity, int currentBulletsCount, float dischargeTime, string fireMod)
    {
        BulletCapacity = bulletCapacity;
        CurrentBulletsCount = currentBulletsCount;
        DischargeTime = dischargeTime;
        FireMod = fireMod;
    }

    public void Shoot()
    {
        if (CurrentBulletsCount > 0)
        {
            CurrentBulletsCount--; // => CurrentBulletsCount = CurrentBulletsCount - 1;   => CurrentBulletsCount -=1;
            Console.WriteLine("Ates edildi!!!");
            Console.WriteLine($"Daraqda qalan gulle sayi {CurrentBulletsCount}/{BulletCapacity}");
        }
        else
        {
            Console.WriteLine("Hal-hazirda daraqda gulle yoxdur!!!");
            Console.WriteLine("Avtomatik olaraq daraq deyisdirilecek!");
            Reload();

        }

    }

    public void Fire()
    {
        if (CurrentBulletsCount > 0)
        {
            if (FireMod == "Auto")
            {
                Console.WriteLine("Ates basladi!!!");

                float spentTime = (CurrentBulletsCount * DischargeTime) / BulletCapacity;

                Thread.Sleep((int)spentTime * 500);

                Console.WriteLine("Ates davam edir...");

                Thread.Sleep((int)spentTime * 500);  //Sadece proqrami spentTime qeder deyandiracaq

                Console.WriteLine("Ates bitdi!");

                Console.WriteLine($"{CurrentBulletsCount} gulle istifade edildi. Ates {spentTime} saniye davam etdi");

                CurrentBulletsCount = 0;

            }
            else
            {
                Shoot();
            }
        }
        else
        {
            Console.WriteLine("Hal-hazirda daraqda gulle yoxdur!!!");
            Console.WriteLine("Daragi deyismek lazimdir!!!");

            Console.Write("Daragi deyisdirmek isteyirsiniz mi?(y/n):");
            string code = default;
            bool isContinue = true;
            while (isContinue)
            {
                code = Console.ReadLine();
                if (code == "y")
                {
                    Reload();
                    isContinue = false;
                }
                else if (code == "n")
                {
                    Console.WriteLine("Silahin daragi bos olaraq qalir!");
                    isContinue = false;
                }
                else
                {
                    Console.WriteLine("Duzgun code daxil edilmedi!!!");
                    Console.Write("Daragi deyisdirmek isteyirsiniz mi?(y/n):");
                }
            }

        }
    }

    public int GetRemainBulletsCount()
    {
        int remainBulletsCount = BulletCapacity - CurrentBulletsCount;
        return remainBulletsCount;
    }

    public void Reload()
    {
        if (CurrentBulletsCount != BulletCapacity)
        {
            Console.WriteLine("Daraq deyisdirilir...");
            Thread.Sleep(3000);

            Console.WriteLine($"Daraq deyisdirildi.");
            CurrentBulletsCount = BulletCapacity;
        }
        else
        {
            Console.WriteLine("Bos bosuna daraq xercleme!!!");
        }
    }

    public void ChangeMod()
    {
        if (FireMod == "Auto")
        {
            FireMod = "Single";
        }
        else
        {
            FireMod = "Auto";
        }

        Console.WriteLine($"Atis modu {FireMod} olaraq deyisdirildi");
    }
}
