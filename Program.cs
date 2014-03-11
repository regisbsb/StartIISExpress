using System.Diagnostics;

namespace StartIISExpress
{
    class Program
    {
        static void Main(string[] args)
        {

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Program Files (x86)\IIS Express\iisexpress.exe",
                    RedirectStandardError = true,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    Arguments = string.Format("/site:{0}", args[0])
                }
            };
            process.Start();
        }
    }
}
