using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler
            ////double number;

            ////number = 4.85;





            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("Elma Birim Fiyatı: " + applePrice+" TL");
            //Console.WriteLine("Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("Domates Birim Fiyatı: " + tomatoPrice + " TL");
            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat:"+ applePrice + "TL -" + " Gramaj: "+appleGram +" Kilo "+" Toplam Tutar: "+appleTotalPrice+" TL");
            //Console.WriteLine();

            //double orangeTotalPrice = orangeGram * orangePrice;
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat:" + orangePrice + "TL -" + " Gramaj: " + orangeGram + " Kilo " + " Toplam Tutar: " + orangeTotalPrice + " TL");
            //Console.WriteLine();

            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat:" + strawberryPrice + "TL -" + " Gramaj: " + strawberryGram + " Kilo " + " Toplam Tutar: " + strawberryTotalPrice + " TL");
            //Console.WriteLine();

            //double potatoTotalPrice = potatoGram * potatoPrice;   
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat:" + potatoPrice + "TL -" + " Gramaj: " + potatoGram + " Kilo " + " Toplam Tutar: " + potatoTotalPrice + " TL");
            //Console.WriteLine();

            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat:" + tomatoPrice + "TL -" + " Gramaj: " + tomatoGram + " Kilo " + " Toplam Tutar: " + tomatoTotalPrice + " TL");
            //Console.WriteLine();

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutarı: " + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler

            ////ABCDEFGH
            ////DEFGHIJK
            ////TOPLANTI SAAT 20:00'DE
            ////" '

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri

            //Console.WriteLine(" **** Hava Yolları Yolcu Bilgisi **** ");
            //Console.WriteLine();

            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIDNo;

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passangerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passangerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passangerAge = Console.ReadLine();

            //Console.Write("Yolcu Kimlik Numarası: ");
            //passangerIDNo = Console.ReadLine();


            //Console.WriteLine();

            //Console.WriteLine("______________________________");
            //Console.WriteLine("Yolcu Kimlik No: "+passangerIDNo+" - Yolcu Ad Soyad: " + passangerName + " " + passangerSurname+" "+ passangerDistrict+ " / "+ passangerCity+ " "+passangerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC12D

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000; 
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.WriteLine("Aldığınız Ayakkabı sayısını giriniz: ");
            //shoeCount = int.Parse (Console.ReadLine());

            //Console.WriteLine("Aldığınız Pc sayısını giriniz: ");
            //computerCount = int.Parse (Console.ReadLine());

            //Console.WriteLine("Aldığınız Sandalye sayısını giriniz: ");
            //chairCount = int.Parse (Console.ReadLine());

            //Console.WriteLine("Aldığınız TV sayısını giriniz: ");
            //tvCount = int.Parse (Console.ReadLine());

            //int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;


            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice); Console.WriteLine();


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1 , exam2, exam3, result;

            //Console.Write("1. Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.Write("2. Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.Write("3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
            //Console.WriteLine();

            //result = (exam1+exam2 + exam3)/3;

            //Console.WriteLine();
            //Console.WriteLine("Not Ortalamanız: " + result);


            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.WriteLine("Lütfen Cinsiyet Seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);


            #endregion


            Console.ReadLine();



        }
    }
}
