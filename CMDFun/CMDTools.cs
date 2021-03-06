﻿using System;
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
