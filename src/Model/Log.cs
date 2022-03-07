
namespace dio_curso_cpde.src.Model
{
    public class Log
    {
        private static Log _Log;

        public string PropertyLog { get; set; }

        private Log()
        {

        }

        public static Log GetInstance()
        {
            if (_Log == null)
                _Log = new Log();
            return _Log;
        }


    }
}
