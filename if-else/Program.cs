using System;

namespace Conditions
{
	public class Program
	{
		static void Main(string[] args)
		{

            // bool condition = true;

            // if (condition)
            // {
            //     Console.WriteLine("Değişken: true");
            // }
            // else
            // {
            //     Console.WriteLine("Değişken: false");
            // }

			int time = DateTime.Now.Hour;
			if (time >= 6 && time < 11)
			{
				Console.WriteLine("Günaydın!");
			}
			else if (time <= 18)
			{
				Console.WriteLine("İyi Günler!");
			}
			else
			{ 
			Console.WriteLine("İyi Geceler!");
            
			string sonuc = time <= 18 ? "İyi Günler!" : "İyi Geceler!";
			sonuc = time >= 6 && time < 11 ? "Günaydın!" : time <= 18 ? "İyi Günler!" : "İyi Geceler!";
			Console.WriteLine(sonuc);
			}
		}
	}
}