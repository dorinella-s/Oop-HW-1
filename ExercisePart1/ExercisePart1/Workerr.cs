using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisePart1
{
    class Workerr
    {
        private string _name;
        private int _age;
        private int _salary;



        public string SetName(string name)
        {
            _name = name;
            return _name;
        }

        public void GetName()
        {
            Console.WriteLine(_name);
        }

        public int SetAge(int age)
        {
            _age = CheckAge(age);
            return _age;
        }

        public int GetAge()
        {
            Console.WriteLine(_name + "'s age is: " + _age);
            return _age;
            
        }
        public int SetSalary(int salary)
        {
            _salary = salary;
            return _salary;
        }
        public int GetSalary()
        {
            Console.WriteLine(_name+"'s salary is: "+_salary);
            return _salary;

        }

        public void CalculateSum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("Method 2: the sum of John's and Sam's salaries: " + sum);
        }

        public void CalculateSumAge(int x, int y)
        {
            if (x > 0)
            {
                int sum = x + y;
                Console.WriteLine("Method 2: the sum of John's and Sam's ages: " + sum);
            }
            else Console.WriteLine("The age of one person is incorrect, age should be between 1 and 100");
            
        }

        private int CheckAge(int x)
        {
            if (x >= 1 && x <= 100)
                return x;
            else return 0;
        }
        }


}
