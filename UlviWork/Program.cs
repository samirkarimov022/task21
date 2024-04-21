using UlviWork.Moduls;

namespace UlviWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group ab106 = new("AB106");
            Group ab105 = new("AB105");

            List<Student> students = new();
            students.Add(new Student("Garib", "Garibzada", 16, 300, ab106));
            students.Add(new Student("Samir", "Karimov", 20, 160, ab106));
            students.Add(new Student("Kenan", "Pasayev", 20, 400, ab105));
            students.Add(new Student("Emil", "Pasayev", 17, 200, ab106));

            students.FindAll(s => s.Group == ab106)
                .ForEach(s => Console.WriteLine(s.Id + " " + s.Name));
            Console.WriteLine(" ");


            students.FindAll(s => s.Credits < 300)
            .ForEach(s => Console.WriteLine(s.Id + " " + s.Name));
            Console.WriteLine(" ");


            students.FindAll(s => s == s)
                .ForEach(s => Console.WriteLine(s.Id + " " + s.Name + " " + s.Surname));
            Console.WriteLine(" ");


            students.FindAll(s => s.Name.ToLower().Contains("b"))
                      .ForEach(s => Console.WriteLine(s.Id + " " + s.Name + " " + s.Surname));
            Console.WriteLine(" ");


            students.OrderBy(s => s.Credits)
                .ToList().ForEach(s => Console.WriteLine(s.Id + " " + s.Name + " " + s.Credits));
            Console.WriteLine(" ");


            Console.WriteLine(students.Sum(s => s.Credits));
            Console.WriteLine(" ");


            Console.WriteLine(students.Any(s => s.Age < 18));
            Console.WriteLine(" ");

            Console.WriteLine(students.Any(s => s.Credits >= 200));

        }
    }
}
