using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = 'y';
            do
            {
                

                Console.WriteLine("Enter details of new employee below: ");
                Console.Write("First Name: ");
                string firstname = Console.ReadLine();
                Console.Write("Last Name: ");
                string lastname = Console.ReadLine();
                Console.Write("Creating new Employee record...");
                Console.Write("\nYear employee started working for the company: ");
                int yearstarted = int.Parse(Console.ReadLine());
                Employee e1 = new Employee(firstname, lastname);
                
                e1.Yearstarted = yearstarted;

               

                Console.WriteLine($"{e1.GetfullName()} has worked {e1.GetYearsWorked()} years");

                Console.Write("\nEnter vehicle employee is driving: ");
                string vehicle = Console.ReadLine();

                Console.WriteLine("Creating new Employee record...");
                Console.WriteLine($"Adding Employee as a new Driver to drive {vehicle}");

                Console.Write("\nPlease enter license number for this employee:");
                string licenseNo = Console.ReadLine();
                Driver d1 = new Driver(firstname, lastname, licenseNo, vehicle);

                Console.WriteLine($"\nThe following details have been entered:\n{d1.ProcessDriver()}");


                Console.WriteLine("Would you like to add another employee? y/n");
                input = char.Parse(Console.ReadLine());

            } while (input == 'y');

            Console.WriteLine("press any key to exit the program");
            Console.ReadLine();





        }

    }
    class Employee
    {


        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Yearstarted { get; set; }

        public Employee()
         {}

        public Employee(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
            

        }

        public string GetfullName()
        {
            return ($"{Firstname} {Lastname}");
        }
        public int GetYearsWorked()
        {
            return 2019 - Yearstarted;

        }

       

        }
    class Driver : Employee
    {
        public string Vehicle { get; set; }
        public string DriversLicenceNo { get; set; }

        public Driver()
        { }

        public Driver(string firstname, string lastname, string vehicle, string licenseNo)
        {
            Firstname = firstname;
            Lastname = lastname;
            Vehicle = vehicle;
            DriversLicenceNo = licenseNo;

        }

        public string ProcessDriver()
        {
            return ($"Driver name: {Firstname} {Lastname}\nDriver license No: {Vehicle}\nVehicle: {DriversLicenceNo}");
        }

    }
}
