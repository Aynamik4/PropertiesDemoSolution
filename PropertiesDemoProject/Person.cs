using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesDemoProject
{
    class Person
    {
        //// .NET ver 1.
        //private string name;

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        //// An "automatic property" is transformed by the compiler to a full property.
        //public string Name { get; set; }

        //// Private set:er with full property.
        //private string name;

        //public string Name
        //{
        //    get { return name; }
        //    private set { name = value; }
        //}

        //public Person(string aName)
        //{
        //    Name = aName;
        //}

        // Private set:er with automatic property.
        public string Name { get; private set; }

        public Person(string aName)
        {
            Name = aName;
        }

    }
}
