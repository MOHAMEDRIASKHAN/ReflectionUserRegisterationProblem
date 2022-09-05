using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPracticeProblem
{
    public class EnterPersonDetails : Attribute
    {
       // [EnterPersonDetails("Riyas")]
        public string FirstName
        {
            get
            {
                return
                    FirstName;
            }
            set { FirstName = "RIYAS"; }
        }

        public string LastName
        {
            get
            {
                return LastName;
            }

            set { LastName = "KHAN"; }

        }
        public string Email
        {
            get {
                return Email;
                    }
            set { Email = "mohamedriaskhan@gmail.com"; }
        }

        public int Number
        {
            get
            {
                return Number;
            }
            set { Number = 1234567890; }
        }
        public string Password
        {
            get
            {
                return Password;
            }
            set { Password = "Riyaskhan@9420"; }
        }
    }
}
