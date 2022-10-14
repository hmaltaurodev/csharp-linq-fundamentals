namespace LinqFundamentals.Lessons
{
    public class LessonI
    {
        public static void Execute()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\r\nLesson I");
            Console.ForegroundColor = ConsoleColor.DarkGray;

            IList<string> fruits = new List<string>() { "Banana", "Apple", "Pear", "Orange", "Grape" };

            // Query Syntax
            var queryResult = from f in fruits
                              where f.Contains('r')
                              select f;

            Console.WriteLine("\r\nQuery Syntax:");
            Console.WriteLine(String.Join(" ", queryResult));

            // Method Syntax
            var methodResult = fruits.Where(f => f.Contains('r'));

            Console.WriteLine("\r\nMethod Syntax:");
            Console.WriteLine(String.Join(" ", methodResult));
        }
    }
}
