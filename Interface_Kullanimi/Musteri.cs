using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Kullanimi
{
    public class Musteri : IMusteri
    {
        public void ekle()  // interface in içindeki metotları da bu şekilde impemente etmek zorundayızdır
        {
            Console.WriteLine("Müsteri eklendi");
        }

        public void sil()
        {
            Console.WriteLine("Müsteri silindi");
        }

        public void guncelle()
        {
            Console.WriteLine("Müsteri güncellendi");
        }

        public void getir()
        {
            Console.WriteLine("Müsteri getirildi");
        }


    }
}
