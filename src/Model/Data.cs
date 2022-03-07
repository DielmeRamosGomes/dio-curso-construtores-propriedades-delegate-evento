
namespace dio_curso_cpde.src.Model
{
    public class Data
    {
        private int Month;

        private bool ValidMonth = false;
        
        private bool ValidDay = false;

        public int MyProperty { get; set; }
        public int Day
        {
            get
            {
                return this.Day;
            }

            set
            {
                if (value > 0 && value <= 31)
                {
                    //this.Day = value;
                    this.ValidDay = true;
                }
            }
        }

        public int GetMonth()
        {
            return this.Month;
        }

        public void SetMonth(int Month)
        {
            if (Month > 0 && Month <= 12)
            {
                this.Month = Month;
                this.ValidMonth = true;
            }
        }

        public void PresentMonth()
        {
            if (this.ValidMonth)
                Console.WriteLine($"O mês é: {this.Month}");
            else
                Console.WriteLine($"Mês invalido!");
        }

        public void PresentDay()
        {
            if (this.ValidDay)
                Console.WriteLine($"O dia é: {this.Day}");
            else
                Console.WriteLine($"Dia invalido!");
        }
    }
}
