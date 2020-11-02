using System;

namespace PropertiesDemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1.
            //Person aPerson = new Person();
            //aPerson.Name = "Håkan"; // Debug using "Step over properties..." unchecked.
            //string s = aPerson.Name;

            //// 2.
            //Person aPerson = new Person("Håkan");
            //string s = aPerson.Name;

            // 3.
            Person aPerson = new Person("Håkan");
            string s = aPerson.Name;
        }
    }
}
