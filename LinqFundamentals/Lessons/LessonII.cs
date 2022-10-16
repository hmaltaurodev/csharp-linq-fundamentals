using LinqFundamentals.Lessons.Utils;

namespace LinqFundamentals.Lessons
{
    public class LessonII
    {
        private static readonly List<int> _numbers = DataSource.GetNumbers();
        private static readonly List<int> _blackList = DataSource.GetBlackListNumbers();
        private static readonly List<Student> _students = DataSource.GetStudents();

        public static void Execute()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\r\nLesson II");
            Console.ForegroundColor = ConsoleColor.DarkGray;

            var result1 = _numbers.Where(n => n < 10);
            Console.WriteLine("\r\nLess than 10:");
            Console.WriteLine(String.Join(" ", result1));

            var result2 = _numbers.Where(n => n > 1 && n != 4 && n < 20);
            Console.WriteLine("\r\nMore than 1, different than 4 and less than 20:");
            Console.WriteLine(String.Join(" ", result2));

            var result3 = _numbers.Where(n => !_blackList.Contains(n));
            Console.WriteLine("\r\nNot included in the blacklist:");
            Console.WriteLine(String.Join(" ", result3));

            var result4 = _numbers.Where(n => n > 1)
                                 .Where(n => n != 4)
                                 .Where(n => n < 20);
            Console.WriteLine("\r\nMore than 1, different than 4 and less than 20 (Where Nested):");
            Console.WriteLine(String.Join(" ", result4));

            var result5 = _students.Where(a => a.Name.StartsWith('A') && a.Age < 18);
            Console.WriteLine("\r\nStudents that name starts with 'A' and have age less than 18:");
            foreach (var student in result5)
                Console.WriteLine($"{student.Name} : {student.Age}");
        }
    }
}
