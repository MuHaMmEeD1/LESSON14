using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON_14
{
    public class Xestexana
    {

        public List<Pediatriya> pediatriyas { get; set; }
        public List<Travmatologiya> travmatologiyas { get; set; }
        public List<Stamotologiya> stamotologiyas { get; set; }


        public Xestexana(List<Pediatriya> pediatriyas, List<Travmatologiya> travmatologiyas, List<Stamotologiya> stamotologiyas)
        {
            this.pediatriyas = pediatriyas;
            this.travmatologiyas = travmatologiyas;
            this.stamotologiyas = stamotologiyas;
        }

        public void showPediatriya(){for (int i = 0; i < pediatriyas.Count; i++){Console.WriteLine($"\n\n({i+1})");pediatriyas[i].show();}}
        public void showTravmatologiya() { for (int i = 0; i < travmatologiyas.Count; i++) { Console.WriteLine("\n\n(" + i + 1 + ")"); travmatologiyas[i].show(); } }
        public void showStamotologiya() { for (int i = 0; i < stamotologiyas.Count; i++) { Console.WriteLine("\n\n(" + i + 1 + ")"); stamotologiyas[i].show(); } }





    }
}
