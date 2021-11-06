using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
//using System.Diagnostics;

namespace CMDFun
{
    class CMDTools
    {
        Regex regexNumber = new Regex("^[0-9]+$");

        internal void GetDataFromCMD()
        {

        }

        public CMDTools()
        {
            WelcomeScreen();
            ShowOptionsOnScreen();
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
            Console.ResetColor();
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

        public void ChooseOption()
        {
            int numberOption;
            string strOptionInput = Console.ReadLine();

            // Lambda Expression ~
            
            if (regexNumber.IsMatch(strOptionInput))
            {
                numberOption = Convert.ToInt32(strOptionInput);
                switch (numberOption)
                {
                    case 1:
                        Dir();
                        break;
                    case 3:
                        GetKnownNetWorks();
                        break;
                    case 6:
                        ShowTree();
                        break;
                    case 7:
                        ShutDownComputer();
                        break;
                    case 8:
                        AbortShutdownComputer();
                        break;

                    default:
                        Console.WriteLine("Default Case - Indtast et brugbart tal");
                        break;
                }
            }
            else
            {
                ColoredMessage("Fejl - Skriv et tal");
            }


        }

        private void ShowTree()
        {
            ExecuteCMDCommand("Tree");
        }

        private void GetKnownNetWorks()
        {
            //netsh wlan show networks
            ExecuteCMDCommand("netsh wlan show networks");
        }

        private void GetPassword()
        {
            // netsh wlan show profile "WiFi-name" key=clear
        }

        private void ShutDownComputer()
        {
            int timeInSec;
            string strOptionInput = Console.ReadLine();

            if (regexNumber.IsMatch(strOptionInput))
            {
                timeInSec = Convert.ToInt32(strOptionInput);
                ExecuteCMDCommand("shutdown -s -t " + timeInSec.ToString());
            }
        }

        private void AbortShutdownComputer()
        {
            ExecuteCMDCommand("shutdown -a");
        }

        private void ColoredMessage(string input, ConsoleColor messageColor = ConsoleColor.Red)
        {
            Console.ForegroundColor = messageColor;
            Console.WriteLine(input);
            Console.ResetColor();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace DEV_Tools
{
    public class AutomaticDirCreator
    {

        public AutomaticDirCreator()
        {
            // Automatic Dir Creation ✝
            Console.WriteLine("Automatic Dir Creation");
            //ADC();
            ADC2(5);
        }

        private void ADClean(int limit)
        {
            // For Daily Dir
            string month = DateTime.Now.ToString("MMMM"); month = month.First().ToString().ToUpper() + month.Substring(1);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
            string parentName = DateTime.Now.ToString("Y");
            int creationCounter = 0;

            bool IsWeekend;

            int daysInThisMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            string DeskTopParentFolder = path + parentName.First().ToString().ToUpper() + parentName.Substring(1);

            int dayCounter = DateTime.Now.Day;
            DateTime nowTemp = DateTime.Now;

            System.IO.Directory.CreateDirectory(DeskTopParentFolder);

            for (int i = dayCounter; i < daysInThisMonth; i++)
            {
                IsWeekend = nowTemp.DayOfWeek.ToString() == "Saturday" || nowTemp.DayOfWeek.ToString() == "Sunday";

                //if (!IsWeekend)
                if (!IsWeekend && creationCounter < limit)
                {
                    System.IO.Directory.CreateDirectory($"{path} {i}. {month}"); creationCounter++;
                }

                nowTemp = nowTemp.AddDays(1); // Next Day
            }
        }

        private void ADC2(int limit)
        {
            // For Daily Dir
            string month = DateTime.Now.ToString("MMMM"); month = month.First().ToString().ToUpper() + month.Substring(1);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
            string parentName = DateTime.Now.ToString("Y");
            int creationCounter = 0;

            bool IsWeekend = DateTime.Now.DayOfWeek.ToString() == "Saturday" || DateTime.Now.DayOfWeek.ToString() == "Sunday";

            int daysInThisMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            string DeskTopParentFolder = path + parentName.First().ToString().ToUpper() + parentName.Substring(1);

            int dayCounter = DateTime.Now.Day;
            DateTime nowTemp = DateTime.Now;


            // Create Main Parent Folder
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(DeskTopParentFolder);
            System.IO.Directory.CreateDirectory(DeskTopParentFolder);

            for (int i = dayCounter; i < daysInThisMonth; i++)
            {
                IsWeekend = nowTemp.DayOfWeek.ToString() == "Saturday" || nowTemp.DayOfWeek.ToString() == "Sunday";

                //if (!IsWeekend)
                if (!IsWeekend && creationCounter < limit)
                    {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(nowTemp.DayOfWeek);

                    // Create Child Folder
                    System.IO.Directory.CreateDirectory($"{path} {i}. {month}"); creationCounter++;
                    Console.WriteLine($"{path} {i}. {month}");
                }

                nowTemp = nowTemp.AddDays(1); // Next Day
            }
        }

        private void ADC()
        {

            // For Daily Dir
            string month = DateTime.Now.ToString("MMMM"); month = month.First().ToString().ToUpper() + month.Substring(1);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
            string parentName = DateTime.Now.ToString("Y");

            // The Real Parent Folder
            string DeskTopParentFolder = path + parentName.First().ToString().ToUpper() + parentName.Substring(1);

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(DeskTopParentFolder);
            //Console.WriteLine(DeskTopParentDir);    

            //Console.WriteLine(DateTime.Today.Day); // If Else Logic
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // This one works
            Console.WriteLine(DateTime.Now.ToString("Y")); // This one works - Parent Folder

            Console.WriteLine("Creating Dir on Desktop wait...");

            if (!System.IO.Directory.Exists(@"C:\Folder\Test"))
            {
                //Console.WriteLine(System.IO.Directory.CreateDirectory(""));
            }
            Console.ReadLine();
        }

        private static void ADC_Test()
        {

            bool IsWeekend = DateTime.Now.DayOfWeek.ToString() == "Saturday" || DateTime.Now.DayOfWeek.ToString() == "Sunday";
            Console.WriteLine(IsWeekend);

            int daysInThisMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            string dayOfTheWeek = DateTime.Now.DayOfWeek.ToString();

            int dayCounter = DateTime.Now.Day;
            DateTime date = DateTime.Now.AddDays(1);
            DateTime nowTemp = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine(daysInThisMonth); // Max Cap
                Console.WriteLine(dayOfTheWeek);
                Console.WriteLine(DateTime.Now.Day);
                Console.WriteLine(date.ToString("D"));

            // Create Main Parent Folder
            //System.IO.Directory.CreateDirectory("");


            for (int i = dayCounter; i < daysInThisMonth; i++)
            {
                IsWeekend = nowTemp.DayOfWeek.ToString() == "Saturday" || nowTemp.DayOfWeek.ToString() == "Sunday";

                //if (nowTemp.DayOfWeek.ToString() != "Saturday" || nowTemp.DayOfWeek.ToString() != "Sunday") // Does not work?
                if (!IsWeekend)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(nowTemp.DayOfWeek);

                    // Create Child Folder

                }
                else // This one never works?
                {
                    Console.WriteLine("Weekend!!!!!!!!!!!!!!!!!!!!!!!!! REEEEEEEEEEEEEEEEEEEEE");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(nowTemp.DayOfWeek);
                }

                nowTemp = nowTemp.AddDays(1);
                Console.WriteLine(nowTemp);
                Console.WriteLine(nowTemp.DayOfWeek);
                //nowTemp = DateTime.Now.AddDays(1);
            }

            //Console.WriteLine(DateTime.DaysInMonth().ToString());
        }

        private static void ADC_Test2()
        {

            string month = DateTime.Now.ToString("MMMM");
            month = month.First().ToString().ToUpper() + month.Substring(1);
            Console.WriteLine(month);

            //string path2 = Environment.SpecialFolder.Desktop.ToString();
            //Console.WriteLine(path2);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
            Console.WriteLine(path);

            string parentName = DateTime.Now.ToString("Y");

            //string DeskTopParentDir = path + "\\" + DateTime.Now.ToString("Y");

            string DeskTopParentDir2 = path + parentName[0].ToString().ToUpper() + parentName.Substring(1);
            string DeskTopParentDir3 = path + parentName.First().ToString().ToUpper() + parentName.Substring(1);

            //string DeskTopParentDir = path + month;

            Console.WriteLine(DeskTopParentDir3);
            //Console.WriteLine(DeskTopParentDir);    

            Console.WriteLine(DateTime.Today.Day);
            Console.WriteLine(DateTime.Now.Month.ToString("MMMM"));
            Console.WriteLine(DateTime.Today.Month.ToString("MMMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // This one works
            Console.WriteLine(DateTime.Now.ToString("Y")); // This one works - Parent Folder

            //Console.ForegroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Green;

            //Console.ForegroundColor = ConsoleColor.White;
            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.Clear();

            Console.WriteLine("Creating Dir on Desktop wait...");

            if (!System.IO.Directory.Exists(@"C:\Folder\Test"))
            {
                //Console.WriteLine(System.IO.Directory.CreateDirectory(""));
            }

            Console.ReadLine();
        }

    }
}
