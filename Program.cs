//Tom Ellner NET23
namespace GenericCollections
{
    class Employee
    {
        // Create essential fields.
        public int _id;
        public string _name;
        public char _gender;
        public double _salary;
    }

    class Program
    {
        static void Main()
        {
            Stack<Employee> employeeStack = new Stack<Employee>();

            // Create five objects and push them to the stack.
            for (int i = 1; i <= 5; i++)
            {
                Employee emp = new Employee
                {
                    _id = i,
                    _name = "Medarbetare" + i,
                    _gender = (i % 2 == 0) ? 'M' : 'K',
                    _salary = 10000 * i
                };
                employeeStack.Push(emp);
            }
            Console.WriteLine();
            // Print all objects in the stack.
            foreach (Employee emp in employeeStack)
            {
                Console.WriteLine($"Id: {emp._id}, Namn: {emp._name}, Kön: {emp._gender}, Lön: {emp._salary}");
                Console.WriteLine($"Kvar i stacken: {employeeStack.Count}");
            }
            Console.WriteLine();
            // Retrieve objects using the Pop()-method.
            while (employeeStack.Count > 0)
            {
                Employee emp = employeeStack.Pop();
                Console.WriteLine($"Poppa - Id: {emp._id}, Namn: {emp._name}, Kön: {emp._gender}, Lön: {emp._salary}");
                Console.WriteLine($"Kvar i stacken: {employeeStack.Count}");
            }
            Console.WriteLine();
            // Add all objects again using the Push()-method
            for (int i = 1; i <= 5; i++)
            {
                Employee emp = new Employee
                {
                    _id = i,
                    _name = "Medarbetare" + i,
                    _gender = (i % 2 == 0) ? 'M' : 'K',
                    _salary = 10000 * i
                };
                employeeStack.Push(emp);
            }

            // Retrieve objects using the Peek()-method.
            Console.WriteLine("Kikar på de två översta: ");
            Employee peek1 = employeeStack.Peek();
            Console.WriteLine($"Id: {peek1._id}, Namn: {peek1._name}, Kön: {peek1._gender}, Lön: {peek1._salary}");
            Console.WriteLine($"Kvar i stacken: {employeeStack.Count}");

            Employee peek2 = employeeStack.Peek();
            Console.WriteLine($"Id: {peek2._id}, Namn: {peek2._name}, Kön: {peek2._gender}, Lön: {peek2._salary}");
            Console.WriteLine($"Kvar i stacken: {employeeStack.Count}");
            Console.WriteLine();

            // Checking if "Medarbetare3" exists in the stack.
            Employee searchEmployeeThree = new Employee
            {
                _id = 3,
                _name = "Medarbetare3",
                _gender = 'M',
                _salary = 30000
            };
            bool containsEmployeeThree = employeeStack.Contains(searchEmployeeThree);

            Console.WriteLine($"Finns Medarbetare3 med i stacken?");
            if (containsEmployeeThree)
            {
                Console.WriteLine($"Medarbetare3 finns med i stacken!");
            }
            else
            {
                Console.WriteLine($"Medarbetare3 finns inte med i stacken!");
            }
            Console.WriteLine();




            List<Employee> employeeList = new List<Employee>();
            // Adding 5 objects to the list.
            for (int i = 1; i <= 5; i++)
            {
                Employee emp = new Employee
                {
                    _id = i,
                    _name = "Medarbetare" + i,
                    _gender = (i % 2 == 0) ? 'M' : 'K',
                    _salary = 10000 * i
                };
                employeeList.Add(emp);
            }

            // Checking if "Medarbetare2" exists in the list.
            Employee searchEmployeeTwo = new Employee
            {
                _id = 2,
                _name = "Medarbetare2",
                _gender = 'K',
                _salary = 20000
            };
            Console.WriteLine($"Finns Medarbetare2 med i listan?");
            if (employeeList.Contains(searchEmployeeTwo))
            {
                Console.WriteLine("Medarbetare2 finns med i listan!");
            }
            else
            {
                Console.WriteLine("Medarbetare2 finns inte med i listan!");
            }
            Console.WriteLine();

            // Using Find()-method to find and print the first male object.
            Employee maleEmployee = employeeList.Find(emp => emp._gender == 'M');
            Console.WriteLine($"Första manliga medarbetaren - Id: {maleEmployee._id}, Namn: {maleEmployee._name}, Kön: {maleEmployee._gender}, Lön: {maleEmployee._salary}");
            Console.WriteLine();

            // Using FindAll()-method to find and print all male objects.
            List<Employee> maleEmployees = employeeList.FindAll(emp => emp._gender == 'M');
            Console.WriteLine("Alla manliga medarbetare:");
            foreach (Employee maleEmp in maleEmployees)
            {
                Console.WriteLine($"Id: {maleEmp._id}, Namn: {maleEmp._name}, Kön: {maleEmp._gender}, Lön: {maleEmp._salary}");
            }
        }
    }
}