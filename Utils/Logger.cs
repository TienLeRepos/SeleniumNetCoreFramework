using System.IO;

namespace DotNetFramework.Utils
{
    class Logger
    {
        private string logFilePath = @".\test.txt";
        private StreamWriter streamWriter;

        public Logger()
        {
            streamWriter = new StreamWriter(logFilePath);
        }

        public static Logger Instance { get; } = new Logger();

        public void Log(string text) => streamWriter.WriteLine(text);

        public void Close() => streamWriter.Close();
    }
}
