using Microsoft.Extensions.Logging;

namespace OOP_ecommerce.Utils
{
    public class LogManager
    {
        private static LogManager _instance;
        private string _logFilePath = "log.txt";

        private LogManager() { }

        public static LogManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LogManager();
            }
            return _instance;
        }

        public void Log(string message)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_logFilePath, true))
                {
                    writer.WriteLine($"{DateTime.Now}: {message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir en el log: {ex.Message}");
            }
        }

        public string ReadLog()
        {
            try
            {
                return File.ReadAllText(_logFilePath);
            }
            catch (Exception ex)
            {
                return $"Error al leer el log: {ex.Message}";
            }
        }
    }
}
