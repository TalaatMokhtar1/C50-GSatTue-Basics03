using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Text;


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


            //string t1 = "Clean Code";
            //string t2 = "Clean Code";

            //Console.WriteLine(object.ReferenceEquals(t1, t2));

            #endregion

            #region Question 3 
            //3 - Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            //object.Print the final result.


            //StringBuilder sb = new StringBuilder();

            //sb.Append("Book List");

            //sb.Append(" - Updated");

            //Console.WriteLine(sb.ToString());

            #endregion

            #region Question 4 
            //4 - Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            //Print the result.

            StringBuilder sb = new StringBuilder();

            sb.Append("Book List");

            sb.Append(" - Updated");

            sb.Replace("Book List", "Library");

            Console.WriteLine(sb.ToString());
            #endregion

        }
    }
}
