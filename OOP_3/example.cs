/*using System;

class Kisiler
{
    public string Isim { get; set; }
    public string Bolum { get; set; }

    public void KisiBilgileri()
    {
        Console.WriteLine($"Kişi Bilgileri: {Isim} {Bolum}");
    }
}

class Ogrenci : Kisiler
{
    public int OgrenciNo { get; set; }

    public void OgrenciBilgileri()
    {
        Console.WriteLine($"Ogrenci no: {OgrenciNo}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Person sınıfından nesne oluşturma
        Kisiler kisiler = new Kisiler();
        kisiler.Isim = "Caner Sekerci";
        kisiler.Bolum = "Elektrik Elektronik ve Ucak Muhendisligi";
        kisiler.KisiBilgileri();

        Console.WriteLine();

        // Student sınıfından nesne oluşturma
        Ogrenci ogrenci = new Ogrenci();
        ogrenci.Isim = "Sinan";
        ogrenci.Bolum = "Kimya Muhendisligi";
        ogrenci.OgrenciNo = 12345;
        ogrenci.KisiBilgileri();
        ogrenci.OgrenciBilgileri();
    }
}
*/