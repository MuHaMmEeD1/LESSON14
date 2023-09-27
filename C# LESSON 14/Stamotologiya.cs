using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__LESSON_14
{
    public class Stamotologiya : Hekim
    {
        public Stamotologiya() : base()
        {
        }

        public Stamotologiya(string name, string surname, DateTime isTecrubesi, string[] isSaati) : base(name, surname, isTecrubesi, isSaati)
        {
        }



    }
}
