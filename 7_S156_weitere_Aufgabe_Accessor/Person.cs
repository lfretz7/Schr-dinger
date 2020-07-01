using System;
using System.Collections.Generic;
using System.Text;

namespace Schroedinger.Klassen
{
    public class Person
    {
        public string Firstname { get; set; }

        public string Name { get; set; }

        private DateTime birthday;

        public DateTime Birthday
        {
            get { return this.birthday; }
            set
            {
                if (value <= DateTime.Now)
                {
                    this.birthday = value;
                }
            }
        }
        public Sex Sex { get; set; }
    }
}
