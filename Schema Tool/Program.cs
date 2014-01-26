// ****************************************
// Assembly : Schema Tool
// File     : Program.cs
// Author   : Alex
// Created  : 26/01/2014
// ****************************************

using System;
using System.Windows.Forms;
using SchemaTool.Windows;

namespace SchemaTool
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
            Application.Run(new Design());
        }
    }
}