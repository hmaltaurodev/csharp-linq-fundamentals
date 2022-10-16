using LinqFundamentals.Lessons;

namespace LinqFundamentals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("LINQ Fundamentals");

            //LessonI.Execute();
            LessonII.Execute();

            Console.ResetColor();
            Console.WriteLine("\r\nPress any key to end execution . . .");
            Console.ReadKey();
        }
    }
}
