using System.Drawing;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 
            // 1 - Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle.Print
            // both title and upperTitle to show that title did not change.

            //string title = "clean code";
            //string upperTitle = title.ToUpper();

            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            #endregion

            #region Question 2 
           // 2 - Declare two separate string variables, both set to the literal "Clean Code".Use ReferenceEquals()
            //to check if they point to the same object in memory.


            string t1 = "Clean Code";
            string t2 = "Clean Code";

            Console.WriteLine(object.ReferenceEquals(t1, t2));

            #endregion

        }
    }
}
