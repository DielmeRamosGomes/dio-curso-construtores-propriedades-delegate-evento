
namespace dio_curso_cpde.src.Model
{
    public class Calculator
    {
        public delegate void DelegateCalculator();

        public static event DelegateCalculator EventCalculator;

        public static void Sum(int X, int Y)
        {
            if (EventCalculator != null)
            {
                Console.WriteLine($"Adição de {X} + {Y} = {X + Y} \n");
                EventCalculator();
            }
            else
            {
                Console.WriteLine("Nenhum inscrito!");
            }
        }

        public static void Subtract(int X, int Y)
        {
            Console.WriteLine($"Subtração de {X} - {Y} = {X - Y} \n");
        }

        public static void Multiply(int X, int Y)
        {
            Console.WriteLine($"Multiplicação de {X} * {Y} = {X * Y} \n");
        }

        public static void Divide(int X, int Y)
        {
            Console.WriteLine($"Divisão de {X} / {Y} = {X / Y} \n");
        }
    }
}
