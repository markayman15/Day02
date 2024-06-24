using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssignmentDay02
{
    class Point 
    {
        public int X;
        public int Y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Problem 01
            //string num = Console.ReadLine() ?? "";

            //Console.WriteLine(num); 
            #endregion

            #region Problem 02
            //int num = Convert.ToInt32(Console.ReadLine()); // if the inpute is non-numeric, then exception will thrown
            //Console.WriteLine(num); 
            #endregion

            #region Problem 03
            //float num1 = 3.5f, num2 = 2.5f;// make 2 variables in stack in the memory
            //float answer = num1 + num2;// will add num1, num2 and put the answer to answer in stack
            //Console.WriteLine(answer); 
            #endregion

            #region Problem 04
            //string statment = "C Sharp";
            //string subString = statment.Substring(2);
            //Console.WriteLine(subString); 
            #endregion

            #region Problem 05
            //int x = 4;

            //int y = x;

            //x = 10;
            ////y will have 4 and x's value will change from 4 to 10 without affecting y's value 
            #endregion

            #region Problem 06
            //Point p1;
            ////will take 4 byte in stack to store the address of point object which in heap
            //// currently will hold NULL
            //p1 = new Point();
            ////will make point object (8 Byte) in Heap and store it's address in p1 variable in stack
            //Point p2 = new Point();
            ////make p2 variable in stack with 4 byte size
            ////also make point object in heap with 8 byte size
            ////then take this point object's address and assign it to p2
            //p2 = p1;
            ////p2 now hold the address of the object that p1 hold also
            ////at this time there are point object at heap unreachable 
            #endregion

            #region Problem 07
            //string str1 = "Hello", str2 = "World!";
            //string answer = string.Format("{0} {1}", str1, str2);
            //Console.WriteLine(answer); 
            #endregion

            #region Problem 08
            //int Principal = 500, Time = 3000;
            //double Rate = 3.2;


            //double Interest = (Principal * Rate * Time) / 100;
            //Console.WriteLine(Interest); 
            #endregion

            #region Problem 09
            //double Weight = 75.5, Height = 1.71;
            //double BMI = (Weight) / (Height * Height);
            //Console.WriteLine(BMI); 
            #endregion

            #region Problem 10
            //int Temprature = 25;

            //string Status = Temprature < 10 ? "Just Cold" : Temprature > 30 ? "Just Hot" : "Just Good";
            //Console.WriteLine(Status); 
            #endregion

            #region Problem 11
            //int Day, Month, Year;
            //Console.Write("Enter Day: ");
            //int.TryParse(Console.ReadLine(), out Day);
            //Console.Write("Enter Month: ");
            //int.TryParse(Console.ReadLine(), out Month);
            //Console.Write("Enter Year: ");
            //int.TryParse(Console.ReadLine(), out Year);

            //Console.WriteLine($"{Day} , {Month} , {Year}");
            //Console.WriteLine($"{Day} / {Month} / {Year}");
            //Console.WriteLine($"{Day} - {Month} - {Year}"); 
            #endregion

            #region Problem 12
            //answer is : c) The event is on 06/14/2024 
            #endregion

            #region Problem 13
            // answer : b) A value 1 will be assigned to d. 
            #endregion

            #region Problem 14
            // answer : a) 6.5 1 
            #endregion

            #region Problem 15
            //answer : d) 7 7 
            #endregion
        }
    }
}
