using dio_curso_cpde.src.Model;

namespace dio_curso_cpde
{
    public class Program
    {
        public delegate void Operator(int X, int Y);

        static void Main()
        {
            //var person = new Person("Dielme", "Ramos Gomes");
            //person.Introduce();

            //var log = Log.GetInstance();
            //log.PropertyLog = "Teste instancia";

            //var log2 = Log.GetInstance();
            //Console.WriteLine($"log2.PropertyLog = {log2.PropertyLog}");

            //var student = new Student("Dielme", "Ramos Gomes", "Teste1");
            //student.Introduce();

            /*var data = new Data
            {
                Day = 15
            };
            Console.WriteLine($"Dia: {data.Day}");
            data.PresentDay();
            data.SetMonth(12);
            data.PresentMonth();*/

            /*var person = new Person();
            person.Introduce();

            person = new Person("Dielme", "Ramos Gomes");
            person.Introduce();*/

            /*const double PI = 3.14;
            Console.WriteLine($"O valor de PI é: {PI}");*/

            /*Operator op = Calculator.Sum;
            Operator op = new Operator(Calculator.Sum);
            var op = new Operator(Calculator.Sum);
            //op.Invoke(30, 20);
            // ordem FIFO
            op += Calculator.Subtract;
            op += Calculator.Multiply;
            op += Calculator.Divide;
            op(20, 10);*/

            var calculator = new Mathematics(20, 10);
            calculator.Sum();

        }
    }
}
