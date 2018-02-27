using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using System.Diagnostics;

namespace CMDFun
{
    class CMDTools
    {

        internal void GetDataFromCMD()
        {

        }

        public CMDTools()
        {
            WelcomeScreen();
            ChooseOption();
        }

        public void Dir()
        {
            ExecuteCMDCommand("dir");
        }

        private void ExecuteCMDCommand(string strCommandToCMD)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(strCommandToCMD);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }

        public void Ping()
        {
            ExecuteCMDCommand("ping google.dk");
        }

        public static void WelcomeScreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to CMDFun version 0.1\n##############################\n");
        }

        public void ShowOptionsOnScreen()
        {
            Console.WriteLine("We have some options to you:");
            Console.WriteLine("1) - Dir");
            Console.WriteLine("2) - Get IP adresse");
            Console.WriteLine("3) - Get list of known networks");
            Console.WriteLine("4) - Get code from specific known network");
            Console.WriteLine("5) - Execute Test methods");
            Console.WriteLine("0) - Close the application");
        }

        private void ChooseOption()
        {
            int numberOption;
            string strOptionInput = Console.ReadLine();
            numberOption = Convert.ToInt32(strOptionInput);

            // Lambda Expression ~

            switch (numberOption)
            {
                case 1:
                    Dir();
                    break;

                default:
                    Console.WriteLine("Default Case - Indtast et rigtigt tal");
                    break;
            }
        }
    }
}
