namespace Demo02
{
    class Point
    {
        public int x;
        public int y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            #region Comment
            // single comment

            /*
             *multi
             *line
             *comment
             * 
             * 
             */
            #endregion

            //int Id = 12;
            //Console.WriteLine(Id);

            #region ValueType
            //int x;

            //x = 5;

            //Int32 y = 10;

            //y = x;

            //x++;
            //Console.WriteLine(y);
            #endregion

            #region Reference Type
            //Point p1;

            //p1 = new Point();
            //Point p2 = new Point(); // unreachable object
            //p2 = p1;

            //Console.WriteLine(p1.x);
            #endregion

            #region ObjectBehaviors
            //Point p3 = new Point();
            //Point p4 = new Point();

            //Console.WriteLine(p3.ToString());

            //Console.WriteLine(p3.GetHashCode());

            //Console.WriteLine(p3.GetType());

            //Console.WriteLine(p3.Equals(p4));
            #endregion

            #region Object
            //object O1;

            //O1 = "mark";
            //O1 = 2;
            //O1 = 3.2;
            //O1 = DateTime.UtcNow;
            #endregion

            #region Fraction and Discard
            //double D = 3.2;
            //float F = 3.2f;
            //decimal DL = 3.2m;

            //int num = 100_000_000; 
            #endregion

            #region Example 01
            //int x = 5;

            //long y = /*(long)*/ x; // Implicit casting

            //long z = 2342342343243243;

            //int m = (int)z; // overflow will occure // explicit casting 
            #endregion

            #region example 02
            //int x = 3;

            //double y = x; // implicit casting

            //double z = 3.2;
            //int m = (int) z; // Emplicit casting (unsafe) 
            #endregion

            #region Convert
            //Console.Write("enter your name: ");
            //string Name = Console.ReadLine() ?? "NA";

            //Console.Write("enter your age: ");
            //int Age = Convert.ToInt32(Console.ReadLine() ?? "0");

            //Console.Write("enter your salary: ");
            //double Salary = Convert.ToDouble(Console.ReadLine() ?? "0");

            //Console.Clear();

            //Console.WriteLine($"Your Name Is {Name}");
            //Console.WriteLine($"Your Age Is {Age}");
            //Console.WriteLine($"Your Salary Is {Salary}"); 
            #endregion

            #region Parse
            //Console.Write("enter your name: ");
            //string Name = Console.ReadLine() ?? "NA";

            //Console.Write("enter your age: ");
            //int Age = int.Parse(Console.ReadLine() ?? "0");

            //Console.Write("enter your salary: ");
            //double Salary = double.Parse(Console.ReadLine() ?? "0");

            //Console.Clear();

            //Console.WriteLine($"Your Name Is {Name}");
            //Console.WriteLine($"Your Age Is {Age}");
            //Console.WriteLine($"Your Salary Is {Salary}"); 
            #endregion

            #region TryParse
            //string x = "10";

            //int y;

            //bool flag = int.TryParse(x, out y);

            //Console.WriteLine(flag); // true, if fales it will assign default value to y because it is out parameter
            //Console.WriteLine(y); // 10 
            #endregion

            #region String Formatting
            //    int x = 2, y = 4;

            //    string Message = string.Format("equation : x + y = {0}",x + y);

            //    Message = $"Equation : x + y = {x + y}";
            #endregion
        }
    }
}
