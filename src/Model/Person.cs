
namespace dio_curso_cpde.src.Model
{
    public class Person
    {
        private readonly string FirstName = "Felipe";
        private readonly string LastName = "Neto";

        public Person()
        {
            //FirstName = string.Empty;
            //LastName = string.Empty;
        }

        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            Console.WriteLine("Construtor classe Person!");
        }

        public void Introduce()
        {
            Console.WriteLine($"Olá, meu nome é: {FirstName} {LastName}");
        }


    }
}
