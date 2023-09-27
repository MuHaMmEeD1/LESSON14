using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON_14
{
    public class Hekim
    {
    
        public string name { get; set; }
        public string surname { get; set; } 
        public DateTime isTecrubesi { get; set; } 
        public string[] isSaati { get; set; }

        public Hekim(string name, string surname,DateTime isTecrubesi, string[] isSaati)
        {
            this.name = name;
            this.surname = surname;
            this.isTecrubesi = isTecrubesi;
            this.isSaati = isSaati;
        }

        public Hekim()
        {
        }
          

        public void show()
        {
            Console.WriteLine($"name {name}");
            Console.WriteLine($"surname {surname}");
            Console.WriteLine($"is tecrubesi {isTecrubesi.Date}");
            Console.WriteLine($"is vaxtlari{{");
            for (int i = 0; i < isSaati.Length; i++) { Console.WriteLine($"{(i+1)}  {isSaati[i]}"); }
            Console.WriteLine("}\n");

        }


    }
}
