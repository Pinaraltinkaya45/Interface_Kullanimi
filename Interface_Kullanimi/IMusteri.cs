using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Kullanimi
{
    public interface IMusteri
    {
        void ekle();  // interface de yazdığımı metotun erişimbelirleyicisi olmaz, birde body yani kıvırcık parantezi olmaz
        void sil();
        void guncelle();
        void getir();

    }
}
