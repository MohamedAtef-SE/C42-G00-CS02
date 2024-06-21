using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            #region 08. Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time) / 100.

            //Console.Write("Enter principal amount:  ");
            //bool flagAmount = decimal.TryParse(Console.ReadLine(), out decimal amount);
            //if (flagAmount)
            //{
            //    Console.Write("Enter rate of interest:  ");
            //    bool flagInterest = decimal.TryParse(Console.ReadLine(), out decimal rate);
            //    if (flagInterest)
            //    {
            //        Console.Write("Enter Duration time:  ");
            //        bool flagTime = int.TryParse(Console.ReadLine(), out int time);
            //        if (flagTime)
            //        {
            //            decimal interest = (rate * time * amount) / 100;
            //            Console.WriteLine($"The Interest is {interest} EGP");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Enter valid Time.");

            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Enter valid Rate.");

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Enter valid Amount."); 
            //}


            #endregion

            #region 09. Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is BMI = (Weight) / (Height * Height)

            ////BMI = (Weight) / (Height * Height)

            //Console.Write("Enter your Body Weight (KG): ");
            //bool flagWeight = float.TryParse(Console.ReadLine(), out float weight);
            //if (flagWeight) 
            //{
            //    Console.Write("Enter your Height (meters): ");
            //    bool flagHeight = float.TryParse(Console.ReadLine(),out float height);
            //    if (flagHeight)
            //    {
            //        Console.Clear();
            //        Console.Beep(324, 3000);
            //        Console.WriteLine($"BMI = {weight / (height * height)}");
            //    }
            //    else Console.WriteLine("Invalid Data");
            //}
            //else Console.WriteLine("Invalid Data");

            #endregion

            #region 10. Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".

            //Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".

            //Console.Write("Enter Degree: ");
            //int degree = Convert.ToInt32(Console.ReadLine());
            //string message = degree <= 10 ? "Just Cold" : degree > 30 ?  "Just Hot" : "Just Good";
            //Console.WriteLine($"Degree today is {message}");

            #endregion

            #region 11. Write a program that takes the date from user and displays it in various formats using string interpolation.

            /// Ex :
            /// Today’s date : 20 , 11 , 2001
            /// Today's date : 20 / 11 / 2001
            /// Today's date : 20 – 11 – 2001
            /// 

            //DateTime date = DateTime.Now;

            //Console.Write("Day: ");
            //int Day = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Month: ");
            //int Month = Convert.ToInt32(Console.ReadLine()); ;

            //Console.Write("Year: ");
            //int Year = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Choose your favorite pattern: ");
            //Console.WriteLine("Press [1] for dd,MM,yyyy");
            //Console.WriteLine("Press [2] for dd/MM/yyyy");
            //Console.WriteLine("Press [3] for dd-MM-yyyy");
            //int pattern = int.Parse(Console.ReadLine() ?? "1");
            //string UserDate = "";
            //if (pattern == 1) UserDate = $"{Day},{Month},{Year}";
            //else if (pattern == 2) UserDate = $"{Day}/{Month}/{Year}";
            //else if (pattern == 3) UserDate = $"{Day}-{Month}-{Year}";

            //Console.WriteLine(UserDate);

            #endregion

            #region 12. What is the output of the following C# code?

            //DateTime date = new DateTime(2024, 6, 14); 
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
            //// Answer is : C )

            #endregion
        }


    }
}
