using System.Security.Cryptography.X509Certificates;

namespace Demo
{
    class Program
    {
       
        //Entry Point
        static void Main()
        {

            #region Comments

            // Single line Comment

            /*
             * 
             * 
             * Multi
             * line
             * Comments
             * 
             *
             **/

            #endregion

            #region Variable Declaration

            //int Id = 10;

            //// PascalCase => FirstName
            //// camalCase  => firstName
            //// kabab-case => file-name
            //// snake_case => first_name

            //Console.WriteLine(Id);

            #endregion

            #region Application Memory

            /*
             * Any Application Memory depend on its Server RAM Memory.
             * Operating system Responsible for Handling Memory on Server.
             * CLR (Common Language Runtime) [tiny operating system] Responsible for handling Application Memory, through Garbage Collector.
             * Garbage collector manage the application memory by distruting it for two parts [Stack , HEAP].
             * Stack approach LIFO | FILO.
             * Stack size depend on OS, If OS 32 bit stack size will be 1 MB, If OS 64 bit stack size will be 4 MB on Console Application.
             * HEAP Memory is Flexable Shrink or Expand depend on needs, by CLR Calling OS and asked to increase memory for HEAP.
             * in HEAP after application done any rest of memory unused in HEAP OS return it back by CLR.
             */

            #endregion

            #region Value Type

            // ValueType (Primitive Datatype)
            //int X;
            //// CLR Will Allocate 4 Uninitialized Bytes at STACK
            //// int: C# Keyword

            //X = 5;

            //Int32 Y = 10;
            //// CLR Will Allocate 4 Uninitialized Bytes at STACK
            //// int32: BCL
            //Y = X; // 5

            //X++; // 6

            //Console.WriteLine(Y); // 5;

            #endregion

            #region Refrence Type

            // ReferenceType (non-Primitive Datatype)
            //Point P1;
            //// Declare for Refrence of type "Point", Refering to NULL.
            //// This Refrence 'P1' Can Refer to an Object from type "Point" OR another type "Inherting" From Class "Point".
            //// CLR will allocate 4 Bytes for the Refrence at Stack.
            //// CLR will allocate 0 Bytes at HEAP

            //P1 = new Point(); /* has 2 References[P1,P2] */
            ///// new
            ///// 01. Allocate Required Number of Bytes in HEAP ( Object Size + CLR Overhead Variables ).
            ///// 02. Initialize Allocated Bytes With Default Values Of its Datatype.
            ///// 03. Call User-Defind Constructor [if exists].
            ///// 04. Assign The Allocated Object to The Reference 'P1'.

            //Console.WriteLine(P1.x); // 0
            //Console.WriteLine(P1.y); // 0 

            //Point P2 = new Point(); /* Unreachable Object */

            //P2 = P1;


            #endregion

            #region Object

            #region Part 01

            //// Generic Parameter: its a Variable accept any data types.
            //// Generic method: its method has Generic Parameter.
            //static void Print<T,T2>(T item,T2 item02)
            //{

            //    Console.Write(item);
            //    Console.Write(' ');
            //    Console.WriteLine(item02);
            //}
            //Print<string,int>("Ahmed",2024);
            //Print<char,bool>('A', true);


            //// Object before Generics solve two Main problem:
            //// 01. Build Flixable Method (Before Generics Method in 2005);
            ////build method flexable before Generic Method With Object as a Data type Params [Pass By Reference]:

            //static void Display(Object item)
            //{

            //    Console.WriteLine(item);

            //}
            //Display("Ahmed Nasr");
            //Display(2024);

            //// "Not Recommanded" Because this way of creating flixable method create [Boxing Problem],
            //// When we send value of Primative DataType as an argument to store it in Object NonPrimative DataType.
            //// by doing this we store value of varible datatype should to stored in Stack memory, we store it in HEAP
            //// Build Box and put it in it and this box created in The HEAP memory.
            //// Another issue Can't put any constrait for reciving data type, must create Defensive code.

            ///// 02. Set Of Behaviours (Functions):
            /////    01. toString() Default value returned the Type of instance attached with its namespace.
            /////    02. GetHashCode() return Unique code Generated based on address <new Point()> of object used in HashTables. 
            /////    03. Equals() Default behaviour Comapring two object based on Adress. return boolen Value [True | False]
            /////    04. GetType() returned Datatype of Object  return namespace.DatatypeName [Can't override on it]

            //Point P1 = new Point();
            //Point P2 = new Point();

            //// toString();
            //Console.WriteLine(P1.ToString()); // Default Value => Demo.Point
            ////After override
            //Console.WriteLine(P1.ToString()); // States values as a Sting 0 , 0 

            //// GetHashCode();
            //Console.WriteLine($"P1 hashCode: {P1.GetHashCode()}");
            //Console.WriteLine($"P2 hashCode: {P2.GetHashCode()}");

            //// Equals();
            //Console.WriteLine(P1.Equals(P2)); // false

            //// GetType();
            //Console.WriteLine(P1.GetType()); // Demo.Point
            //Console.WriteLine(P1.GetType().Name); // Point
            //Console.WriteLine(P1.GetType().Namespace); // Demo

            //object O1;
            ///// Declare for Refernce of Type "Object", Refering to NULL.
            ///// 4 Bytes have been Allocated at STACK for the Refernce "O1".
            ///// 0 Bytes have been Allocated at HEAP.
            ///// The Reference 'O1' can refer to an instance of type "object" OR of another type "Inherting from Object".


            //O1 = new object();
            ///// <new> Generates 4 steps:
            ///// 01. Allocate required number of bytes for the object at HEAP (Object size + CLR overhead Variables )
            ///// 02. Initialize that allocated bytes with the Default value of its Datatype.
            ///// 03. Call user-defind Constructor() [if exist].
            ///// 04. Return the Address of allocated object to the Refernece 'P1'.
            ///// 


            //O1 = new string("Ahmed Nasr");
            //O1 = "Ahmed Nasr"; // Syntax Sugar

            //// Boxing Problem
            //O1 = 5;
            //O1 = 'A';
            //O1 = true;
            //O1 = new DateTime();
            //O1 = new DateOnly();
            //O1 = new TimeOnly();

            #endregion

            #region Part 02

            //// string is a object
            //object O1 = new string("Ahmed Nasr");
            //// Parent = Child

            //// Dog is a Animal
            //// Animal = Dog
            //// Animal = Cat
            //// Animal = Fox

            //// Fox = Animal <ERROR>
            //// Fox = (Fox) Animal  [Unsafe Casting] in this example i promise compiler the Animal refer to a Fox now. 


            #endregion

            #endregion

            #region Fractions and Discard

            //float X = 5.4F;       //  4 Byte
            //double Y = 4.34;      //  8 Byte
            //decimal Z = 3323.34M; // 24 Byte

            //// Discard => Just for Readability
            //long Number = 100_000_000_000;

            #endregion

            #region Implicit Casting Vs Explicit Casting

            /// Casting Operator: [With Condations]
            /// (int)
            /// (double)
            /// (long)
            ///.........

            #region Example 01
            /// int X = 8;
            /// 
            /// long Y =  /* (long) */ X; // 01. Implicit Casting [Safe Casting]
            ///
            ///Console.WriteLine(Y);// 8
            ///

            /// 1st way to Check [Unsafe Casting]
            /// long X = 2234253534646;
            ///  checked
            ///  {
            ///     int Y = (int)X; // 02. Explicit Casting [Unsafe Casting]
            ///     unchecked
            ///     {
            ///       Console.WriteLine(Y); // Garbadge Value -55356464564
            ///     }
            ///  }

            /// 2nd Way to Check [Unsafe Casting] by create Difenive Code.
            /// long X = 2234253534646;
            /// int Y = X.GetType() == typeof(int) ? (int) X : 0;
            /// Console.WriteLine(Y); // 0

            #endregion

            #region Example 02

            //int X = 8;
            //double Y = /*(double)*/ X; // 01. Implicit Casting
            //Console.WriteLine(Y); // 5

            //double X = 10.5;
            //int Y = (int) X; // 02. Explicit Casting [Unsafe Casting]
            //Console.WriteLine(Y);   // 10


            #endregion

            #endregion

            #region Convert

            ////Convert: [is a Class Containing Set Of Methods used used for casting from datatype to another].

            //Console.Write("Please Enter Your Name: ");

            //// ?? coalesce operator
            //string Name = Console.ReadLine() ?? "N/A";

            //Console.Write("Please Enter Your Age: ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please Enter Your Salary: ");
            //decimal Salary = Convert.ToDecimal(Console.ReadLine());

            //Console.Clear();
            //Console.Beep(324, 3000); // Windows Supported only

            //Console.WriteLine($"Your Name: {Name} | Salary: {Salary} | Age: {Age} |");



            #endregion

            #region Parse

            //// Parse: [is a Method Used for Casting from String to the Caller Datatype.]

            //Console.Write("Please Enter Your Name: ");

            //// ?? coalesce operator
            //string Name = Console.ReadLine() ?? "N/A";

            //Console.Write("Please Enter Your Age: ");
            //int Age = int.Parse(Console.ReadLine() ?? "0");

            //Console.Write("Please Enter Your Salary: ");
            //decimal Salary = decimal.Parse(Console.ReadLine() ?? "0");

            //Console.Clear();
            //Console.Beep(324, 3000); // Windows Supported only

            //Console.WriteLine($"Your Name: {Name} | Salary: {Salary} | Age: {Age} |");

            #endregion

            #region Try Parse

            //string X = "10";

            //int Y;

            //bool flag = int.TryParse(X, out Y);

            //Console.WriteLine(flag); // True
            //Console.WriteLine(Y); // 10

            //X = "Ahmed";

            //flag = int.TryParse(X, out Y); // With TryParse If Casting failed, No Exceptions (Errors) will be Through it.

            //Console.WriteLine(flag); // false
            //Console.WriteLine(Y); // 0 [Default value for int]

            #endregion

            #region Operators

            #region Unary Operators

            //// Unary Operators => Works On One Operand (Variable) 
            //int X = 10;

            // 1. ++
            //// 1.1 PreFix [Increment and then Print]
            //Console.WriteLine(++X); // Print 11
            //// 1.2 PostFix [Print and then Increment] 
            //Console.WriteLine(X++); // Print 10

            // 2. --
            //// 2.1 PreFix [Decrement and then Print]
            //Console.WriteLine(--X); // Print 9
            //// 2.2 PostFix [Print and then Decrement] 
            //Console.WriteLine(X--); // Print 10

            #endregion

            #region Binary Operators

            //// Binary Operators => Works On Two Operands (Variables) 
            // int Sum, Mul, Div, Sub, Mod;
            // int Num01 = 2, Num02 = 6;
            // Sum = Num01 + Num02;
            // Sub = Num02 Num01;
            //Mul = Num01 * Num02;
            //Div = Num01 / Num02;
            //Mod = Num02 % Num01; // 6 % 4 = 2

            #endregion

            #region Assignment Operators

            //int X;
            //X = 4;
            //X += 2; // 6
            //X -= 2; // 4
            //X *= 2; // 8
            //X /= 2; // 4
            //X %= 2; // 0

            #endregion

            #region Relational Operators [Comparsion Operator]

            //int X = 6, Y = 5;
            //Console.WriteLine(X == Y); // Equal
            //Console.WriteLine(X != Y); // Not Equal
            //Console.WriteLine(X > Y);   // More Than 
            //Console.WriteLine(X >= Y);  // More Than Or Equal
            //Console.WriteLine(X < Y);   // Less Than
            //Console.WriteLine(X <= Y);  // Less Than Or Equal 

            #endregion

            #region Logical Operators

            //Console.WriteLine(!false); // True
            //Console.WriteLine(false && true); // Short Circuit
            //Console.WriteLine(true || false);
            //Console.WriteLine(4 < 5 && 7 < 9 );

            #endregion

            #region Bitwise Operators

            //Console.WriteLine(~0);
            //Console.WriteLine(false & true); // false // Long Circuit
            ////                 0000 & 0001 = 0000
            //Console.WriteLine(true | false); // true
            //Console.WriteLine(4 < 8 &  7 < 9); // true

            #endregion

            #region Ternary Operators [Condational Operators]

            //int X = 10, Y = 5;
            //string Message = X > Y ? "X is more than Y" : X < Y ? "X is less than Y" : "X equals Y";
            //Console.WriteLine(Message);

            #endregion


            #endregion

            #region Operators Priority [Precedence] and Associtivity

            //// 01. Unary Operator (PreFix)
            //// 02. Round Braces ()
            //// 03. * , /  , %
            //// 04. + , -

            //int a = 20, b = 10, c = 15, d = 5, equation;

            //equation = (a + b) * c / d;      // (30 * 15) / 5
            //equation = ((a + b) * c) / d;    // (450) / 5
            //equation = (a + b) * (c / d);    // (30) * (15/5)
            //equation = a + (b*c) / d;        // 20 + (150/5)

            #endregion

            #region String Formatting

            //int X = 3, Y = 4;

            //string Message = "Equation: " + X + " + " + Y + " = " + (X + Y);

            ////01. Composite String

            //Message = string.Format("Equation: {0} + {1} = {2}",X,Y,(X+Y));


            ////02. String Interpolation
            //// $: Manpulation Operator

            //Message = $"Equation: {X} + {Y} = {X + Y}";
            //Console.WriteLine(Message);

            #endregion

        }
    }
}
