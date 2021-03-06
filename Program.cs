using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker d1 = new Doctor("John Doe", 120000);
            Worker d2 = new Doctor("David Jones", 100000);
            Worker d3 = new Doctor("Maria Doe", 110000);
            Worker n1 = new Nurse("John Evans", 50000);
            Worker n2 = new Nurse("Maria Evans", 60000);
            Worker n3 = new Nurse("David Evans", 40000);
            List<Worker> workers = new List<Worker>() { d1, d2, d3, n1, n2, n3 };
            foreach (var worker in workers)
            {
                worker.Print();
            }
        }
    }
    class Worker
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public void Print()
        {
            Console.WriteLine($"{Name, -20} {Salary, -15}");
        }
    }
    class Doctor : Worker
    {
        public Doctor(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
    }
    class Nurse : Worker
    {
        public Nurse(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}
