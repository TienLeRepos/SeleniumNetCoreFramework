using System.IO;

namespace DotNetFramework.Utils
{
    class Logger
    {
        private string logFilePath = @".\test.txt";
        private StreamWriter streamWriter;
        private static Logger logger = new Logger();

        public Logger()
        {
            streamWriter = new StreamWriter(logFilePath);
        }

        public static Logger Instance => logger;

        public void Log(string text) => streamWriter.WriteLine(text);

        public void Close() => streamWriter.Close();
    }
}
