using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroi
{
    internal interface IPowers
    { 
        public void hurt(Hero attacked);
        public void heal(Hero cured);
    }
}
