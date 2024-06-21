using System.Runtime.InteropServices;

namespace Assignment
{
    class Program
    {
        static void Main()
        {
            #region 01.Write a program that allows the user to enter a number then print it.

            //Console.Write("Enter your number: ");
            //bool flag = int.TryParse(Console.ReadLine(), out int result);

            //if (flag)
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Inavalid Data");
            //}
            #endregion

            #region 02.Write C# program that Convert a string to an integer, but the string contains non-numeric characters. And mention what will happen 

            //Console.Write("Enter your name: ");

            //string? message = Console.ReadLine();

            //int result = Convert.ToInt32(message);
            //// Through Unhandled Exception because i did't use Defense Code or TryParse Method.

            #endregion

            #region 03. Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            // float Number01 = 2.55f, Number02 = 4.25f;
            // float result = Number01 + Number02;

            //Console.WriteLine(result);

            #endregion

            #region 04. Write C# program that Extract a substring from a given string.

            //Console.Write("Enter your full name: ");
            //string? fullName = Console.ReadLine();

            //Console.WriteLine(fullName.Substring(0,fullName.Length - 4));

            #endregion

            #region 05. Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            //int X = 10;
            //int Y = 20;
            //Y = X;
            //X = 5;
            //Console.WriteLine(Y); // 10
            //// Thats because we assigned perimative datatype to another perimative datatype ,so what happend here we just take a copy
            //// from value type variable and store it in perimative data type in stack.

            #endregion

            #region 06. Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            //Test TA = new Test();

            //TA.X = 10;
            //TA.Y = 20;

            //Test TB = new Test();

            //TB.X = 30;
            //TB.Y = 40;
            //int XR = TB.X + TB.Y;

            //TB = TA;

            //TA.X = 100;
            //TA.Y = 200;

            //Console.WriteLine(TB.X + TB.Y); // 300
            //// Because with  Assigning one reference type variable to another we not assign the values we assign
            //// the reference to the object in the HEAP, after assgin operation happend the value of object TB now its Unreachable,
            //// beacuse TA & TB point to the same object in the HEAP.

            #endregion

            #region 07. Write C# program that take two string variables and print them as one variable 
            //Console.Write("Enter your first name: ");
            //string FirstName = Console.ReadLine();
            //Console.Write("Enter your Last name: ");
            //string LastName = Console.ReadLine();
            //Console.WriteLine($"Welcome {FirstName} {LastName}, Back....");

            #endregion

        }
    }
}
