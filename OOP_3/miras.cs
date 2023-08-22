
using System;
namespace ConsoleApplication1
{

    // Base class
    class FKA
    {

        // verilerin tanımlandığı kısım
        public string name;
        public string subject;

        // base class ın public metodu
        public void readers(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("Ben: " + name);
            Console.WriteLine("Uzmanlık alanım: " + subject);
        }
    }

    // FKA sınıfından miras alma :
    class Firatkalkinma : FKA
    {

        // Türetilmiş class ın constructor 
        public Firatkalkinma()
        {
            Console.WriteLine("Fıratkalkınmaajansı");
        }
    }

    // Driver class
    class Sudo
    {

        // Main Method
        static void Main(string[] args)
        {

            // türetilmiş sınıfın nesnesini oluşturma
            Firatkalkinma f = new Firatkalkinma();

            // Türetilmiş sınıf nesnesini kullanarak 
            // temel sınıf metodunu çağırma
            f.readers("Caner", "Python");
        }
    }
}
