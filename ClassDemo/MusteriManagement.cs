using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class MusteriManagement
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Musteri Basariyla Eklendi : " + musteri.adi);
        }

        public void MusteriListeleme(Musteri[] musteriler)
        {              
           Console.WriteLine("Musteriler Listelendi: ");

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.adi);
            }
        }

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Musteri Silindi! : " + musteri.adi);
        }
    }   
}
 