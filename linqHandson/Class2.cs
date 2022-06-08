using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqHandson
{
    internal class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }

        public Person(string Fname, string Lname, int Age)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            this.Age = Age;
        }
    }
}
