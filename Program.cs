using System;

namespace OPP2
{
	class Program
	{
		static void Main(string[] args)
		{
			MusteriManager musteriManager = new MusteriManager();
			GercekMusteri musteri1 = new GercekMusteri();
			musteri1.Id = 2;
			musteri1.Adi = "murat";
			musteri1.SoyAdi = "kara";
			musteri1.TcNo = "25165105";
			musteri1.MusteriNo = "515";
			Console.WriteLine(musteri1.TcNo);

			TuzelMusteri musteri2 = new TuzelMusteri();
			musteri2.Id = 2;
			musteri2.SirketAdi = "kodlama i.o";
			musteri2.MusteriNo = "100";
			musteri2.VergiNo = "20";

			Musteri musteri3 = new GercekMusteri();
			
			Musteri musteri4 = new TuzelMusteri();
		}
	}
}
