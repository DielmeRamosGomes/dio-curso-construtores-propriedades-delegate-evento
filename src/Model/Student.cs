
namespace dio_curso_cpde.src.Model
{
    public class Student : Person
    {
        public Student(string FirstName, string LastName, string disciplina) : base(FirstName, LastName)
        {
            Console.WriteLine("Construtor classe Student!");
        }

    }
}
