/*using System;

// Tekli kalıtım
class Hayvanlar
{
    public void Yemek()
    {
        Console.WriteLine("Hayvanlar yemek yer.");
    }
}

class Kopek : Hayvanlar
{
    public void Havlamak()
    {
        Console.WriteLine("Köpek havlar.");
    }
}

// çok seviyeli kalıtım
class Memeli : Hayvanlar
{
    public void Yürümek()
    {
        Console.WriteLine("Memeliler is yürür.");
    }
}

class Atlar : Memeli
{
    public void Kosmak()
    {
        Console.WriteLine("Atlar koşar.");
    }
}

// hiyerarşik kalıtım
class Kuslar : Hayvanlar
{
    public void Ucmak()
    {
        Console.WriteLine("Kuslar ucar.");
    }
}

class Kartal : Kuslar
{
    public void Yuksekucmak()
    {
        Console.WriteLine("Kartallar yüksekten ucar.");
    }
}

class Penguen : Kuslar
{
    public void Yuzmek()
    {
        Console.WriteLine("Penguenler yuzer.");
    }
}

// çoklu kalıtım
interface I1
{
    void Method1();
}

interface I2
{
    void Method2();
}

class MyClass : I1, I2
{
    public void Method1()
    {
        Console.WriteLine("Method1 is cagırıldı.");
    }

    public void Method2()
    {
        Console.WriteLine("Method2 is cagırıldı.");
    }
}

// main bloğu
class Program
{
    static void Main(string[] args)
    {
        // tekli kalıtım 
        Kopek dog = new Kopek();
        dog.Yemek();
        dog.Havlamak();

        // çok seviyeli kalıtım
        Atlar horse = new Atlar();
        horse.Yemek();
        horse.Kosmak();
        horse.Yürümek();

        // hiyerarşik kalıtım
        Kartal kartal = new Kartal();
        Penguen penguen = new Penguen();
        kartal.Ucmak();
        kartal.Yuksekucmak();
        penguen.Ucmak();
        penguen.Yuzmek();

        // çoklu kalıtım
        MyClass myClass = new MyClass();
        myClass.Method1();
        myClass.Method2();

        Console.ReadLine();
    }
}
*/