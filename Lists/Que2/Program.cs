using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Que2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> employees = new List<string>();
            int menuChoice = 0;

            do
            {               
                Console.WriteLine("Safari Travel Employees");
                Console.WriteLine("=======================");
                Console.WriteLine("1. Create new employee list\n2. View all employees\n3. Edit employee\n4. Search employee\n5. Quit");
                Console.Write("Choice: ");
                menuChoice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("Create new employee list");
                        Console.WriteLine("========================");

                        Console.WriteLine("\nEnter all the employee names and press on * when ready...\n");
                        string newName = "";
                        do
                        {
                            Console.Write("Employee Name: ");
                            newName = Console.ReadLine().ToLower();
                            employees.Add(newName);//add it to the list
                        } while (newName != "*");

                        //we can remove the * by using RemoveAt to remove the last item:
                        //-->employees.RemoveAt(employees.Count - 1); // remove last item
                        //or we can remove by using Remove to remove the item which matches a value
                        employees.Remove("*");
                        break;
                    case 2:
                        Console.WriteLine("View all employees");
                        Console.WriteLine("==================\n");
                        if (employees.Count == 0)
                        {
                            Console.WriteLine("There are no employees yet. Go to option1 to add employees.");
                        }
                        else
                        {
                            foreach (string employee in employees)
                            {
                                Console.WriteLine(employee);
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Edit employee");
                        Console.WriteLine("=============\n");
                        if (employees.Count == 0)
                        {
                            Console.WriteLine("There are no employees yet. Go to option1 to add employees.");
                        }
                        else
                        {
                            Console.WriteLine("Here are all the employees. Choose the number corresponding to the employee to edit.\n");
                            for (int i = 0; i < employees.Count; i++)
                            {
                                Console.WriteLine($"{i+1}. {employees[i]}");
                            }
                            int employeeIndex = 0;
                            do
                            {
                                Console.Write("Choose: ");
                                employeeIndex = Convert.ToInt32(Console.ReadLine());
                            } while (employeeIndex < 1 || employeeIndex > employees.Count);
                            employeeIndex--;

                            Console.Write("\nNew name: ");
                            string edittedName = Console.ReadLine().ToLower();
                            employees[employeeIndex] = edittedName;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Search employee");
                        Console.WriteLine("===============\n");
                        if (employees.Count == 0)
                        {
                            Console.WriteLine("There are no employees yet. Go to option1 to add employees.");
                        }
                        else
                        {
                            Console.Write("\nEnter employee name to search: ");
                            string nameToSearch = Console.ReadLine().ToLower();

                            int index = employees.IndexOf(nameToSearch);

                            if (index == -1)
                            {
                                Console.WriteLine($"{nameToSearch} is not in the system.");
                            }
                            else
                            {
                                Console.WriteLine($"{nameToSearch} has been found and the system ID is {index}");
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Thank you for using our app!");
                        break;
                    default:
                        Console.WriteLine("Incorrect menu choice!");
                        break;
                }
                Console.ReadKey();
                Console.Clear();

            } while (menuChoice != 5);

        }
    }
}
