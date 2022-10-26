using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static int weapon;
        static string[] weaponName;
        static int[] ammo;
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays");
            Console.WriteLine();

            //0 pistol
            //1 shotgun
            //2 rocket launcher

            //current weapon
            weapon = 0; //0...2 init

            weaponName = new string[3];
            weaponName[0] = "Pistol";
            weaponName[1] = "Shotgun";
            weaponName[2] = "Rocket Launcher";

            //ammo
            int pistolAmmo = 6;
            int spreaderAmmo = 80;

            // 

            //int[] ammo; //array of integers; declaration
            ammo = new int[3]; // instantiation
            ammo[0] = 6; //pistol declaration ..
            ammo[1] = 2; // shotgun
            ammo[2] = 3; //rocket launcher



            //show cuurent weapon
            //Console.WriteLine(weaponName[weapon]);// shows current weapon
            //Console.WriteLine(ammo[weapon]); // shows current ammo
            //ShowHUD();
            //weapon = 1;
            //ShowHUD();
            //weapon = 2;
            //ShowHUD();
            //weapon = 3;
            CurrentWeapon(0);
            Fire(2);
            ShowHUD();



            Console.ReadKey(true);
        }
        static void ShowHUD()
        {
            Console.WriteLine(weaponName[weapon]); // shows current weapon
            Console.WriteLine(ammo[weapon]);
        }

        static void Fire(int shoot)
        {

            ammo[weapon] = ammo[weapon] - shoot;
        }

        static void Reload(int relAmmo)
        {
            ammo[weapon] = ammo[weapon] + relAmmo;
        }

        static void CurrentWeapon(int currWeap)
        {
            if (currWeap == 0)
            {
                weapon = currWeap;
            }
            if (currWeap == 1)
            {
                weapon = currWeap;
            }
            if (currWeap == 2)
            {
                weapon = currWeap;
            }
        }
    }
}
