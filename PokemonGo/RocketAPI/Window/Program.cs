﻿using System;
using System.Windows.Forms;

namespace PokemonGo.RocketAPI.Window
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            //Client client = new Client(new MySettings(), new ApiFailureStrategy());
            //Console.write
            //client.Login.DoLogin();

            //Console.ReadLine();
        }
    }
}