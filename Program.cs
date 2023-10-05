using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine($"Todays Date={DateTime.Now}");


            Console.WriteLine("Enter BirthDate");
            DateTime birthdate=Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(birthdate);
            Console.WriteLine(birthdate.Year);
            Console.WriteLine(birthdate.Month);
            Console.WriteLine(birthdate.Day);




            Console.WriteLine("Enter The First No:");
            int fno =Convert.ToInt32( Console.ReadLine());

            //Short
            //Single fno=Convert.ToSingle( Console.ReadLine());
            //Double fno=Convert.ToDouble( Console.ReadLine());


            Console.WriteLine("Enter The Second No:");


            int Sno = Convert.ToInt32(Console.ReadLine());
           // float Sno=Convert.ToSingle( Console.ReadLine());
           // Double Sno=Convert.ToDouble( Console.ReadLine());

            int ans = fno + Sno;
           // double ans=fno+ Sno;

            Console.WriteLine($"The answer of {fno}+{Sno} is {ans}");
            



            string empname;
            Console.WriteLine("enter name");
            empname=Console.ReadLine(); 
            Console.WriteLine(empname);
            Console.WriteLine("Enter a character");
            char c1=Convert.ToChar(Console.ReadLine());
            Console.WriteLine(c1);


            bool IsEmployee;
            Console.WriteLine("enter a boolean value, true for yes, false for no: R u a employee");
            IsEmployee = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(IsEmployee);



            DateTime joiningDate = new DateTime(2023, 10, 03);
            Console.WriteLine(joiningDate);

            Console.ReadLine();


        }

    }
}
