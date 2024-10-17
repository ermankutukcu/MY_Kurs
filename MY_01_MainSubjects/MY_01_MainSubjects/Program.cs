using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)

        {

            #region degiskenler

            //String
            //değişken_türü değişken_Adı

            //string name;
            //name = "Erman";
            //Console.WriteLine(name);



            string customerName;
            string customerSurname;
            string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Erman";
            //customerSurname = "Kutukcu";
            //customerPhone = "+905322104824";
            //customerEmail = "erman@yopmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: "+customerPhone + " " + customerEmail);
            //Console.WriteLine("Adres: "+district + " " + city);



            #endregion

            #region int Degiskenler
            //int
            int number = 24;
            Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonPrice = 50;

            Console.WriteLine("**** Restoran Menü Fiyat Listesi ****");
            Console.WriteLine();
            Console.WriteLine("----- Hamburger Fiyatı: " + hamburgerPrice+" TL");
            Console.WriteLine("----- Pizza: " + pizzaPrice+" TL");
            Console.WriteLine("----- Kola " + cokePrice+ " TL");
            Console.WriteLine("----- Limonata " + lemonPrice+ " TL");
            Console.WriteLine("----- Kızartmalar " + friesPrice+" TL");
            Console.WriteLine("----- Su " + waterPrice+" TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyat Listesi ****");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int lemonCount;
            int pizzaCount;

            int totalPrice = 0;

            totalPrice += hamburgerPrice;

            #endregion

            Console.Read();

        }
    }
}
