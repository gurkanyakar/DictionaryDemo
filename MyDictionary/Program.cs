using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> telefonKodlari = new MyDictionary<int,string>();
            telefonKodlari.Add(1, "ABD");
            telefonKodlari.Add(49, "Almanya");
            telefonKodlari.Add(81, "Japonya");
            telefonKodlari.Add(90, "Türkiye");

            telefonKodlari.Print();

        }
    }
}
