﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_WindowsForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
<<<<<<< Updated upstream
            Application.Run(new DangKyPhong());
=======
            Application.Run(new Login());
>>>>>>> Stashed changes
=======
            Application.Run(new frm_Quan_Ly());
>>>>>>> parent of 53e4625 (Cập nhật Form Đăng Ký)
        }
    }
}
