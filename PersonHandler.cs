using System;
using System.Collections.Generic;
using System.Text;

namespace Inkapsling
{
    class PersonHandler
    {
        //logik???? personen finns redan????
        public void SetAge(Person pers, int age)
        {

            pers.Age=age;
           
        }

        public Person CreatePerson (int age, string fname,string lname, double height, double weight)
        {
            Person p = new Person();
            p.Age = age;
            p.FName = fname;
            p.LName = lname;
            p.Height = height;
            p.Weight = weight;
            return p;
        }

        public void Sleep()
        {
            Console.WriteLine("I sleep 8 hours a day");
        }
        public void Walk()
        {
            Console.WriteLine("I love walking");
        }

        
    }
}
