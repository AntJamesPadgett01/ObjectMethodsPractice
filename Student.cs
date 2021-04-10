using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethodsPractice
{
    class Student

    {
        public string name;
        public string major; // attributes
        public double gpa;


        public Student( string aNAme,string aMajor, double aGpa)// comstructor
        {
            name = aNAme;
            major = aMajor;
            gpa = aGpa;
        }

        public bool hasHonors()
        {
            if (gpa >= 2.6)
            {
                return true;
            }
            return false;
        }




    }
}
