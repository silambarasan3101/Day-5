using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Day_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int noc, nos;
            Console.WriteLine("Enter Number of Classes");
            noc = int.Parse(Console.ReadLine());
            string[][] students = new string[noc][];
            for(int i=0;i<noc;i++)
            {
                Console.WriteLine("Enter Number of Student in Class "+(i+1));
                nos = int.Parse(Console.ReadLine());
                students[i] = new string[nos];
                for (int j = 0; j < nos; j++)
                {
                    Console.WriteLine($"Enter Student{j + 1}\'s name");
                    students[i][j] = Console.ReadLine();
                }
            }
            for(int i=0;i<students.Length;i++)
            {
                Console.WriteLine($"Students List of Class {i + 1}");
                Console.WriteLine("***********************");
                for(int j = 0; j < students[i].Length;j++)
                {
                    Console.WriteLine(students[i][j]);
                }
                Console.WriteLine("**********************");
            }
            Console.ReadKey();*/




            /* Console.WriteLine("Enter the number of employees:");
             int numEmployees = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter the number of working days for each employee:");
             int numWorkingDays = int.Parse(Console.ReadLine());
             int[][] salary = new int[numEmployees][];
             for (int i = 0; i < numEmployees; i++)
             {
                 salary[i] = new int[numWorkingDays];
                 Console.WriteLine($"Enter the salary for each working day of Employee {i + 1}:");
                 for (int j = 0; j < numWorkingDays; j++)
                 {
                     Console.Write($"Day {j + 1}: ");
                     salary[i][j] = int.Parse(Console.ReadLine());
                 }            
             }
             Console.WriteLine("\nWeekly Salary Calculation:");
             for (int i = 0; i < numEmployees; i++)
             {
                 int totalSalary = 0;
                 Console.WriteLine($"\nEmployee {i + 1}:");
                 for (int j = 0; j < numWorkingDays; j++)
                 {
                     Console.WriteLine($"Day {j + 1}: {salary[i][j]}");
                     totalSalary += salary[i][j];
                 }
                 Console.WriteLine($"Total Salary: {totalSalary}");
             }
             Console.ReadLine();*/


            /*
                        int[][,] myJArray = new int[3][,];
                        myJArray[0] = new int[2, 2] { { 1, 2 }, { 2, 3 } };
                        myJArray[1] = new int[3, 2] { { 1, 2 }, { 2, 3 }, { 5, 4 } };
                        myJArray[2] = new int[3, 3] { { 1, 2, 6 }, { 2, 3, 7 }, { 5, 4, 8 } } ;
                        Console.WriteLine("Stored values are");
                        for(int i=0;i<myJArray.Length;i++)
                        {
                            for(int r = 0; r < myJArray[i].GetLength(0);i++)
                            {
                                for (int c = 0; c < myJArray[i].GetLength(1); i++)
                                {
                                    Console.Write(myJArray[i][r, c] + "\t");
                                }
                                Console.WriteLine("\n");
                            }
                            Console.WriteLine("**************");
                        }
                        Console.ReadKey();*/



            /*
                        Console.WriteLine("Welcome to Collection!!!");
                        ArrayList arrayList = new ArrayList
                        {
                            "Sam",
                            "Ravi",
                            "Amit"
                        };
                        Console.WriteLine("Number of Element in Array List are:\t " + arrayList.Count);
                        Console.WriteLine("Capacity of Array list is: \t " + arrayList.Capacity);
                        foreach (var item in arrayList)
                        {
                            Console.WriteLine(item);
                        }
                        arrayList.Add("ram");
                        arrayList.Add("guru");
                        Console.WriteLine("After add two elements list");
                        Console.WriteLine("Number of Element in Array List are:\t " + arrayList.Count);
                        Console.WriteLine("Capacity of Array list is: \t " + arrayList.Capacity);
                        foreach (var item in arrayList)
                        {
                            Console.WriteLine(item);

                        }
                        arrayList.Sort();
                        Console.WriteLine("*** Sorted Array List ***");
                        foreach (var item in arrayList)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Reverse the List");
                        arrayList.Reverse();
                        Console.WriteLine("*** Sorted Array List in Dse ***");
                        foreach (var item in arrayList)
                        {
                            Console.WriteLine(item);
                        }
                            Console.ReadKey();*/




            /*ArrayList hardwareList = new ArrayList();
            hardwareList.Add("CD");
            hardwareList.Add("Printer");
            hardwareList.Add("KeyBoard");
            hardwareList.Add("Mouse");
            hardwareList.Add("Network Card");
            Console.WriteLine("Intial Hardware List");
            for (int i = 0; i < hardwareList.Count; i++)
            {
                Console.WriteLine(hardwareList[i]);
            }
            Console.WriteLine("Enter item to search & update");
            string searchItem = Console.ReadLine();
            int index = hardwareList.IndexOf(searchItem);
            if(index==-1)
            {
                Console.WriteLine($"No Such item{searchItem} exist in hardware List");
            }
            else
            {
                Console.WriteLine("Enter update item");
                hardwareList[index] = Console.ReadLine();
                Console.WriteLine("Update Hardware List is as follows!!!");
                for(int i=0;i<hardwareList.Count;i++)
                {
                    Console.WriteLine(hardwareList[i]);
                }
            }*/

            

                        ArrayList hardwareList = new ArrayList();
                        hardwareList.Add("CD");
                        hardwareList.Add("Printer");
                        hardwareList.Add("KeyBoard");
                        hardwareList.Add("Mouse");
                        hardwareList.Add("Network Card");
                        Console.WriteLine("Intial Hardware List");
                        for (int i = 0; i < hardwareList.Count; i++)
                        {
                            Console.WriteLine(hardwareList[i]);
                        }
                        string newItem;
                        Console.WriteLine("Enetr new item");
                        newItem = Console.ReadLine();
                        hardwareList.Add(newItem);
                        Console.WriteLine("List after adding new hardware");
                        for(int i=0;i<hardwareList.Count;i++)
                        {
                            Console.WriteLine(hardwareList[i]);
                        }



           /* Hashtable hardware = new Hashtable() { { 1, "Compact Disc" }, { 2, "DVD" }, { 3, "KeyBoard" }, { 4, "Mouse" } };
            Console.WriteLine("List of Keys");
            foreach(var k in hardware.Keys)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("List of Values");
            foreach (var v in hardware.Values)
            {
                Console.WriteLine(v);
                {
                    Console.WriteLine("Hardware Key \t Name of Hardware");
                    foreach (var k in hardware.Keys)
                    {
                        Console.WriteLine(k + "\t \t" + hardware[k]);
                    }
                }
            }*/
                Console.ReadKey();
        }
    }
}
    

