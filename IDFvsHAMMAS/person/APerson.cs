using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFvsHAMMAS.AbstractClasses.Person
{
    public abstract class Person
    {
        protected string Name;
        protected int Age;
        
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public string GetName()
        {
            return this.Name;
        }

        public int GetAge()
        {
            return this.Age;
        }
    }
}
