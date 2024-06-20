namespace Demo
{
    class Program
    {
        //Entry Point
        static void Main()
        {

            // ==========  Part 04 Variable Declaration and Comments ========== //

            Console.WriteLine("Hello, World!");

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

            int Id = 10;

            // PascalCase => FirstName
            // camalCase  => firstName
            // kabab-case => file-name
            // snake_case => first_name

            Console.WriteLine(Id);

            #endregion


            // ========== Part 10 ValueType Vs ReferenceType [Code] ========== //

            #region Value Type

            int X;
            // CLR Will Allocate 4 Uninitialized Bytes at STACK
            // int: C# Keyword

            X = 5;

            Int32 Y = 10;
            // CLR Will Allocate 4 Uninitialized Bytes at STACK
            // int32: BCL
            Y = X; // 5

            X++; // 6

            Console.WriteLine(Y); // 5;

            #endregion



        }
    }
}
