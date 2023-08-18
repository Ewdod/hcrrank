using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hcrrank
{
     abstract public class User
    {
        public User(string tip, string isim, Gender cins, int yas)
        {
            type = tip;
            name = isim;
            gender = cins;
            age = yas;
        }
        public string type { get; set; }
        public string name { get; set; }
        public Gender gender { get; set; }
        public int age { get; set; }
        public int MyProperty { get; set; }

        public string GetUserName()
        {
            return name;
        }
        public string GetUserType()
        {
            return type;
        }
        public int GetAge()
        {
            return age;
        }
        public Gender GetGender()
        {
            return gender;
        }
    }
}
