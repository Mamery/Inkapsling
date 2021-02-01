using System;
using System.Collections.Generic;
using System.Text;

namespace Inkapsling
{
    class Person
    {

       
        private int age;
        private string fName;
        private string lName;


        public int Age
        {
            get 
            { 
                return age; 
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Please input a valid age");
                }
                else
                {
                    age = value;
                }
                
            }
        }

        public string FName
        {
            get 
            { 
                return fName;
            }

            set
            {

                if (value == null)
                {
                    throw new ArgumentNullException(nameof(fName));
            
                }
                else if (value.Length < 3 || value.Length > 15)

                {
                    throw new ArgumentOutOfRangeException(nameof(fName));
                }
                else
                {
                    fName = value;
                }

            }
        }

        public string LName
        {
            get
            {
                return lName;
            }

            set
            {
             
                if(value == null)
                {
                    throw new ArgumentNullException(nameof(lName));

                }else if (value.Length < 2 ||  value.Length > 10)
               
                {
                    throw new ArgumentOutOfRangeException(nameof(lName));
                }else
                {
                    lName = value; 
                }

            }
        }

        public double Weight { get; set; }
        public double Height { get; set; }


        public override string ToString()
        {
            return "Person: " + Age + " " + FName + " " + LName + " "+ Height + " " + Weight;
        }

    }
}
