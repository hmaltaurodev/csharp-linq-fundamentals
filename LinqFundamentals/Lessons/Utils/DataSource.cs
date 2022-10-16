namespace LinqFundamentals.Lessons.Utils
{
    public class DataSource
    {
        public static List<int> GetNumbers()
        {
            List<int> numbers = new()
            {
                1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384
            };

            return numbers;
        }

        public static List<int> GetBlackListNumbers()
        {
            List<int> blackList = new()
            {
                16, 128, 512, 4096
            };

            return blackList;
        }

        public static List<Student> GetStudents()
        {
            List<Student> students = new()
            {
                new Student() { Name = "Henrique", Age = 28 },
                new Student() { Name = "Maria", Age = 34 },
                new Student() { Name = "Amanda", Age = 21 },
                new Student() { Name = "Manoel", Age = 34 },
                new Student() { Name = "Carlos", Age = 18 },
                new Student() { Name = "Alicia", Age = 15 }
            };

            return students;
        }
    }
}
