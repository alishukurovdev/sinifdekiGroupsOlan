using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Model
{
    public class Student
    {
        string _name;
        string _surname;
        string _finCode;
        public string FinCode
        {
            get
            {
                return _finCode;
            }
           private  set
            {
                if(value.Length==7)
                {
                    _finCode = value.ToUpper();
                }
            }
        }
        public string Name { get {
                return _name;
            }
            set { 
                if(value.Length>2)
                    _name=value;
            }
        }
        public string Surname { get { return _surname;}
            set
            {
                if (value.Length > 2) _surname=value ;
            }
        }

        public Student(string name, string surname, string finCode)
        {
            Name = name;
            Surname = surname;
            FinCode = finCode;
        }
    }
}
