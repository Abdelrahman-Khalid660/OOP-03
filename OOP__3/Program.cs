using System;
using static System.Net.Mime.MediaTypeNames;
using static Employee;

// 1) Part 2
class Person
{
    public String Name;
    public int Age;
}

// 1) Part 3


public class Employee
{
    private int id;
    private string name;
    private SecurityLevel securityLevel;
    private decimal salary;
    private DateTime hireDate;
    private char gender;


    public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, DateTime hireDate, char gender)
    {
        this.id = id;
        this.name = name;
        this.securityLevel = securityLevel;
        this.salary = salary;
        this.hireDate = hireDate;
    }


    // 2) Part 3

    public class HiringDate
    {
        private int day;
        private int month;
        private int year;

        public HiringDate(int day, int month, int year)
        {
            if (!IsValidDate(day, month, year))
            {
                throw new ArgumentException("Invalid date.");
            }

            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int Day { get { return day; } }
        public int Month { get { return month; } }
        public int Year { get { return year; } }

        private bool IsValidDate(int day, int month, int year)
        {
            try
            {
                DateTime date = new DateTime(year, month, day);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{month:00}/{day:00}/{year}";
        }

    }






    // 4) Part 3


    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    public Employees()
    {
        id = 0;
        name = "";
        securityLevel = SecurityLevel;
        salary = 0;
        hireDate = DateTime.Now;
        gender = 'M';
    }






    public class Program
        {

            public static void Main(string[] args)
            {

                // 1) Part 2

                //Person[] persons = new Person[3];


                //persons[0].Name = "Ahmed";
                //persons[0].Age = 25;

                //persons[1].Name = "Boda";
                //persons[1].Age = 20;

                //persons[2].Name = "Aya";
                //persons[2].Age = 35;



                //foreach (Person person in persons)
                //{
                //    Console.WriteLine("Name: {0}, Age: {1}", person.Name, person.Age);
                //}


                // 2) Part 2

                //Person[] persons = new Person[3];

                //for (int i = 0; i < persons.Length; i++)
                //{
                //    Console.WriteLine($"Enter details for person {i + 1}:");
                //    Console.Write("Name: ");
                //    persons[i].Name = Console.ReadLine();

                //    Console.Write("Age: ");
                //    if (!int.TryParse(Console.ReadLine(), out persons[i].Age))
                //    {
                //        Console.WriteLine("Invalid age. Please enter a valid integer.");
                //        i--; 
                //    }
                //}


                //int oldestPersonIndex = 0;
                //for (int i = 1; i < persons.Length; i++)
                //{
                //    if (persons[i].Age > persons[oldestPersonIndex].Age)
                //    {
                //        oldestPersonIndex = i;
                //    }
                //}


                //Console.WriteLine("\nOldest Person:");
                //Console.WriteLine($"Name: {persons[oldestPersonIndex].Name}");
                //Console.WriteLine($"Age: {persons[oldestPersonIndex].Age}");





                // 3) Part 3

                // Validate Gender
                if (char.ToUpper(gender) != 'M' && char.ToUpper(gender) != 'F')
                {
                    throw new ArgumentException("Invalid gender. Gender must be 'M' or 'F'.");
                }
                this.gender = char.ToUpper(gender);
            }

            public int ID { get { return id; } }
            public string Name { get { return name; } }
            public SecurityLevel SecurityLevel { get { return securityLevel; } }
            public decimal Salary { get { return salary; } }
            public DateTime HireDate { get { return hireDate; } }
            public char Gender { get { return gender; } }

            // 5)
            public override string ToString()
            {
                return string.Format("ID: {0}, Name: {1}, Security Level: {2}, Salary: {3:C}, Hire Date: {4}, Gender: {5}",
                                      id, name, securityLevel, salary, hireDate.ToShortDateString(), gender);
            }
        }

    // 6)

    Employee[] empArr = new Employee[3];

    empArr[0] = new Employees
        {
            ID = 1,
            Name = "John Doe",
            SecurityLevel = SecurityLevel.DBA,
            Salary = 8000,
            HireDate = new DateTime(2023, 1, 15),
            Gender = 'M'
        };

empArr[1] = new Employees
{
    ID = 2,
    Name = "Jane Smith",
    SecurityLevel = SecurityLevel.Guest,
    Salary = 2000,
    HireDate = new DateTime(2024, 5, 5),
    Gender = 'F'
};

empArr[2] = new Employees
{
    ID = 3,
    Name = "Admin User",
    SecurityLevel = SecurityLevel.SecurityOfficer, // Full permissions
    Salary = 10000,
    HireDate = new DateTime(2022, 12, 20),
    Gender = 'M'
};

foreach (Employee emp in empArr)
{
    Console.WriteLine(emp);
}

Console.ReadLine();


// 7) 

int boxingUnboxingCount = 0;
Array.Sort(empArr);

Console.WriteLine("Sorted Employees:");
foreach (Employee emp in empArr)
{
    Console.WriteLine(emp);
}

Console.WriteLine($"Boxing/Unboxing occurred {boxingUnboxingCount} times.");
Console.ReadLine();




    }
}

