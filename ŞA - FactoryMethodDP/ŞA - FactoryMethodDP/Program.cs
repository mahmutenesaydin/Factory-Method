using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŞA___FactoryMethodDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dokuman[] dokumanlar = new Dokuman[]
            {
                new Rapor(),
                new Ozgecmis()
            };
            foreach (Dokuman d in dokumanlar)
            {
                Console.WriteLine("{0} --", d.ToString());
                foreach (Sayfa s in d.Sayfalar)
                {
                    Console.WriteLine(" " + s.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
