using StudentService;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student 
            {
                Id = 1,
                Name = "Ahmed",
                Address = "Cairo",
                Age = 16,
                Gender = Gender.Male,
            };

            Console.WriteLine(student);
        }
    }
}
