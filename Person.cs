using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teamProject_Pilipchuk_Radkevich
{
    internal class Person
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private System.DateTime DateTime { get; set; }

        public Person (string name, string surname, DateTime date)
        {
            this.Name = name;
            this.Surname = surname;
            this.DateTime = date;
        }
    }
}
