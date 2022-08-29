/*
Partial Class is a unique feature of C#. It can break the functionality of a single class into many files. When the application is compiled, these files are then reassembled into a single class file. The partial keyword is used to build a partial class.
-- partial keyword is use to make a class or method partial class or method.
*/
using System;
namespace Partial_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            /*creating object of the partial class.All the parts of this partial class,
            combined into a single file during compile time */
            CustomerPartial obj=new CustomerPartial();

            Console.WriteLine("enter the customer's FirstName : ");
            obj.FirstName=Console.ReadLine();

            Console.WriteLine("enter the customer's LastName : ");
            obj.LastName=Console.ReadLine();
            
            string fullName=obj.GetFullName();
            Console.WriteLine("First_Name : "+obj.FirstName);
            Console.WriteLine("Last_Name : "+obj.LastName);
            Console.WriteLine("Full_Name : "+fullName);
            Console.ReadKey();
        }
    }
}