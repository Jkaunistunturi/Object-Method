using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Method
{
    internal class Student
    {
        public string name;
        public string major;
        public double gpa;
        //we can access the private letter through getter
        private string letter;

        public static int studentCount = 0;


        //Constructor
        public Student(string aName, string aMajor, double aGpa, string aLetter)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
            // letter = aLetter;
            //we make the Letter be equal to aLetter
            Letter = aLetter;
            studentCount++;
        }

        //Getter / Setter
        public string Letter
        {
            get { return letter; }
            set
            {
                if (value == "A" || value == "B" || value == "C")
                {
                    letter = value;
                }
                else
                {
                    letter = "No letter";
                }

            }
            



        }



        //Object method
        public bool HasHonors()
        {
            if (gpa >= 3.1)
            {
                return true;
            }
            return false;
        }
    }
}
