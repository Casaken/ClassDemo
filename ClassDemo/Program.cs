using ClassDemo;

Musteri musteri1= new Musteri();
musteri1.adi = "Mehmek";
musteri1.soyadi = "Ceynan";
musteri1.yasi = 31;

Musteri musteri2 = new Musteri();
musteri2.adi = "Berkey";
musteri2.soyadi = "Yakisikli";
musteri2.yasi = 40;

Musteri musteri3 = new Musteri();
musteri3.adi = "Kemir";
musteri3.soyadi = "Ocak";
musteri3.yasi = 10;


Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

MusteriManagement MusteriManagement = new MusteriManagement();

MusteriManagement.MusteriEkle(musteri3);
MusteriManagement.MusteriListeleme(musteriler);
MusteriManagement.MusteriSilme(musteri2);

