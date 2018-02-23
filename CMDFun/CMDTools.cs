using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDFun
{
    class CMDTools
    {

        internal void GetDataFromCMD()
        {

        }

        public void Ping()
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Arguments = "/C ping 127.0.0.1";
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.CreateNoWindow = true;
            info.FileName = "cmd.exe";
            info.UseShellExecute = false;
            info.RedirectStandardInput = true;

            using (Process process = Process.Start(info))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.WriteLine(result);
                }
            }
        }

        public static void WelcomeScreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to CMDFun version 0.1\n##############################\n");
        }

        public static void ShowOptionsOnScreen()
        {
            Console.WriteLine("We have some options to you:");
            Console.WriteLine("1) - Dir");
            Console.WriteLine("2) - Get IP adresse");
            Console.WriteLine("3) - Get list of known networks");
            Console.WriteLine("4) - Get code from specific known network");
            Console.WriteLine("0) - Close the application");
        }

    }
}
