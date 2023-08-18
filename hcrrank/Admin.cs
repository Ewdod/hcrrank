using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hcrrank
{
    public class Admin : User
    {
        public Admin(string isim, Gender cins, int yas) : base(tip:"Admin", isim, cins, yas)
        {
        }
    }
}
