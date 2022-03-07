
namespace dio_curso_cpde.src.Model
{
    public class Mathematics
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Mathematics(int X, int Y)
        {
            this.X = X;
            this.Y = Y;

            Calculator.EventCalculator += EventHandler; 
        }

        public void Sum()
        {
            Calculator.Sum(this.X, this.Y);
        }

        public void EventHandler()
        {
            Console.WriteLine("Método executado!");
        }


    }
}
