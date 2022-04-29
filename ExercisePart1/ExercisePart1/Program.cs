using System;

namespace ExercisePart1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker();
            Worker worker2 = new Worker();

            worker1.name = "John";
            worker1.age = 25;
            worker1.salary = 1000;

            worker2.name = "Sam";
            worker2.age = 26;
            worker2.salary = 2000;

            Console.WriteLine("Method 1: the sum of John's and Sam's salaries: " + (worker1.salary + worker2.salary));
            Console.WriteLine("Method 1: the sum of John's and Sam's ages: " + (worker1.age + worker2.age));

            //worker1.CalculateSum(worker1.salary, worker2.salary);

            Workerr worker3 = new Workerr();
            Workerr worker4 = new Workerr();

            worker3.SetName("John");
            worker4.SetName("Sam");

            worker3.SetAge(101);
            worker4.SetAge(26);


            worker3.SetSalary(1000);
            worker4.SetSalary(2000);


            Console.WriteLine("-----------------------------");
            worker3.CalculateSum(worker3.GetSalary(), worker4.GetSalary());
            worker3.CalculateSumAge(worker3.GetAge(), worker4.GetAge());

        }
    }
}
