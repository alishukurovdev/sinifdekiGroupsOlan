using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Model
{
    public class Book
    {
        public static int Count=0;
        int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 2)
                    _name = value;
            }
        }
        string _author;
        public string Author { get {
                return _author; }
            set
            {
                if (value.Length > 2)
                    _author = value;
            }
        }

        public Book(string name, string author)
        {
            Name = name;
            Author = author;
            Count++;
            Id = Count;
        }
    }
}
