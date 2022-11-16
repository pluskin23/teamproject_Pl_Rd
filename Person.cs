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
        public void SetDateTime(DateTime date) { 
            this.DateTime = date;
        }
        public DateTime GetDateTime()
        {
            return this.DateTime;   
        }

        public Person (string name, string surname, DateTime date)
        {
            this.Name = name;
            this.Surname = surname;
            this.DateTime = date;
        }
        public Person ()
        {
            this.Name = "Man";
            this.Surname = "Manov";
            this.DateTime = DateTime.Today;
        }
        public override string ToString()
        {
            string s = this.Name + " " + this.Surname + " " + this.DateTime;
            return s;
        }
        public string ToShortString()
        {
            string s = Name.ToString() + Surname.ToString();
            return s;
        }
    }
}
