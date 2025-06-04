using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRegistrationApp
{
    public class Ogrenci
    {
        public int ID { get; set; }
        public string Ad { get; set; }

        public string Soyad { get; set; }
        public char Numara { get; set; }
        public string Fotograf { get; set; }

        public int SinifID { get; set; }


    }
}
