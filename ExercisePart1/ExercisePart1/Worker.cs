using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisePart1
{
    class Worker
    {
        public string name;
        public int age;
        public int salary;

       
        public void CalculateSum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("the sum of John's and Sam's salaries: " + sum);
        }
        public void CalculateSumAge(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("the sum of John's and Sam's ages: " + sum);
        }

    }
}
