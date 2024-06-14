﻿using System;
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

        //Constructor
        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
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
