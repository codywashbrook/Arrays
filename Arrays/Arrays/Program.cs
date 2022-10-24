using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays");
            Console.WriteLine();

            //0 pistol
            //1 shotgun
            //2 rocket launcher

            //current weapon
            int weapon; // declaration
            weapon = 0; //0...2 init

            string[] weaponName;
            weaponName = new string[3];
            weaponName[0] = "Pistol";
            weaponName[1] = "Shotgun";
            weaponName[2] = "Rocket Launcher";

            //ammo
            int pistolAmmo = 6;
            int spreaderAmmo = 80;

            // 

            int[] ammo; //array of integers; declaration
            ammo = new int[3]; // instantiation
            ammo[0] = 6; //pistol declaration ..
            ammo[1] = 2; // shotgun
            ammo[2] = 3; //rocket launcher

            //show cuurent weapon
            Console.WriteLine(weaponName[weapon]); // shows current weapon
            weapon = 1;
            Console.WriteLine(weaponName[weapon]);
            weapon = 2;
            Console.WriteLine(weaponName[weapon]);

            Console.ReadKey(true);
        }
        static void ShowCurrentWeaponAmmo()
        {

        }

        static void Fire()
        {

        }
    }
}
