using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACsharp_Assignment_Access_Modifiers
{
    internal class User
    {
        private string adSoyad { get; set; }
        private int yas { get; set; }

        public string email;
        public void bilgileriGoster()
        {
            Console.WriteLine("Kişi ad Soyad : " + adSoyad);
            Console.WriteLine("Kişi yaş : " + yas);
            Console.WriteLine("Kişi email : " + email);
        }


        public string getAdSoyad()
        {
            return adSoyad;
        }

        public void setAdSoyad(string adSoyad)
        {
            this.adSoyad = adSoyad;
        }


        public int getYas()
        {
            return yas;
        }

        public void setYas(int yas)
        {
            this.yas = yas;
        }
    }
}
