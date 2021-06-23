﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Management.Form3());
            //Application.Run(new Management.frmTitleBook());
            //Application.Run(new frmMain("1", "2", 1));

            Application.Run(new Business.frmImportBook_Add());
        }
    }
}
