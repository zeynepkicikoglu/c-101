// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;


namespace Name
{
    class Program {
        public static void Main(string[] args){
            Console.WriteLine("Hello, zey!");
            // Console.WriteLine("İsminizi girin:");
            // string? name = null;
            // string? surname = null;
            // name = Console.ReadLine();
            // Console.WriteLine("Soyisminizi girin:");
            // surname = Console.ReadLine();
            // Console.WriteLine("Hello,"+name+" "+surname);

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            string dt1 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dt1);
            string dt2 = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(dt2);

            // Atama ve İşlemli Atama Operatörleri (=, +=, -=, *=, /=)
            // Mantıksal Operatörler (||, &&, !)
            // İlişkisel Operatörler (==,!=, <, >, >=,<=)
            // Aritmetik (+, -, *, /, %, ++, --)


        }


    }
}