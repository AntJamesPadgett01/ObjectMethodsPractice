using System;

namespace ObjectMethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Jim", "Business", 2.8);// created students and (objects)
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.hasHonors());
            Console.WriteLine(student2.hasHonors());
        }
    }
}
