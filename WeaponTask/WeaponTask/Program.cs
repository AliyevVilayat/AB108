using System.IO;

namespace WeaponTask;

#region ForMe

// - Inheritance

// - Encapsulation

// - Access Modifiers

#endregion

#region Notes

/*
 Break keyword - Müəyyən şərt daxilində Loop-u və Switch Statement-i dəyandırmaq üçündür.
 Return keyword - Müəyyən şərt daxilində Method-u dəyandırmaq üçündür və ya Method-un return type-a uyğun olaraq geriyə dəyər döndürmək üçündür.

Default - Switch statement, DEFAULT KEYWORD OLMADAN da yazıla bilər.

 Switch Case-in duzgun islemesi ucun case daxilinde hec olmasa asagidakilardan biri yazilmalidir:
    1.Break
    2.Goto case <value>
    3.Return
    4.Case daxili bos buraxilmalidir

    Extra. Throw Exception
 */



#endregion

#region Task

/*
 Weapon deyə class yaradılır. +

Darağın güllə tutumu, Daraqdakı güllə sayı, Darağın boşalma saniyəsi, 
atış modu (təkli və ya avtomatik) propertyləri verilir. +

Shoot() - metodu hər çağırıldıqda 1 güllə atır(Ekranda bunu bildir) +

Fire() - metodu daraqdakı güllələr hamısı atəşlənir və neçə saniyəyə bitdiyi qeyd olunur. +

GetRemainBulletCount() - darağın tam dolması üçün lazım olan güllə sayını qaytarır.+

Reload() - darağı yenidən doldurur.+

ChangeFireMode() - Atış modunu dəyişir.+

Bütün məlumatları doldurmadan obyekt yaratmaq olmasın.
0 - İnformasiya almaq üçün
1 - Shoot metodu üçün
2 - Fire metodu üçün
3 - GetRemainBulletCount metodu üçün
4 - Reload metodu üçün
5 - ChangeFireMode metodu üçün
6 - Proqramdan dayandırmaq üçün
qısayoldur.

 */

#endregion


public class Program
{
    public static void Main(string[] args)
    {

        //Constructor ilə        
        Weapon weapon = new Weapon(32, 32, 3.6f, "Auto");

        Console.WriteLine(

                   """ 
            Bütün məlumatları doldurmadan obyekt yaratmaq olmasın.
            0 - İnformasiya almaq üçün
            1 - Shoot metodu üçün
            2 - Fire metodu üçün
            3 - GetRemainBulletCount metodu üçün
            4 - Reload metodu üçün
            5 - ChangeFireMode metodu üçün
            6 - Proqramdan dayandırmaq üçün qısayoldur.
            """

                   );

        int code = 0;
        bool isContinue = true;
        while (isContinue)
        {

            Console.Write("\nZehmet olmasa 0 ve 6 araliginda deyer gonderin:");
            code = Convert.ToInt32(Console.ReadLine());  // => int.Parse();

            switch (code)
            {
                case 0:

                    Console.WriteLine("Informasiya verildi");
                    break;

                case 1:
                    {
                        weapon.Shoot();
                        break;
                    }

                case 2:
                    weapon.Fire();
                    break;

                case 3:
                    Console.WriteLine(weapon.GetRemainBulletsCount()); 
                    break;

                case 4:
                    weapon.Reload();
                    break;

                case 5:
                    weapon.ChangeMod();
                    break;

                case 6:
                    Console.WriteLine("Proqram deyandirildi");
                    isContinue = false;
                    break;

                default:
                    Console.WriteLine("Duzgun code daxil edilmedi!\n");
                    Console.WriteLine(

           """ 
            Bütün məlumatları doldurmadan obyekt yaratmaq olmasın.
            0 - İnformasiya almaq üçün
            1 - Shoot metodu üçün
            2 - Fire metodu üçün
            3 - GetRemainBulletCount metodu üçün
            4 - Reload metodu üçün
            5 - ChangeFireMode metodu üçün
            6 - Proqramdan dayandırmaq üçün qısayoldur.
            """

           );
                    break;

            }
        }



    }
}
