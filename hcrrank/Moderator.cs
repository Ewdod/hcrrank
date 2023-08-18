using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hcrrank
{
    public class Moderator : User
    {
        public Moderator(string isim, Gender cins, int yas) : base(tip:"Moderator", isim, cins, yas)
        {
        }
    }
}
