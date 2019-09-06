using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirketOtomasyonu
{
    public class Person
    {
        public string Name { get; set; }
        public string Lastame { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public virtual int noOrSAlary { get; set; }


    }
}
