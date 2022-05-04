using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace HideConsoleApp
{
    class Program
    {
        [DllImport("Kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();
        [DllImport("User32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int cmdShow);
        static void Main(string[] args)
        {
            Console.WriteLine("press any key to hide console window");
            Console.ReadKey();
            VsConsoleWindow(0);
            Console.ReadKey();
        }

        public static void VsConsoleWindow(int i)
        {
           
            IntPtr hWnd = GetConsoleWindow();
            if (hWnd != IntPtr.Zero)
            {
                // value of cv = 0 hide console window  
                // value of cv = 1 show console window
                ShowWindow(hWnd, i);
                Thread.Sleep(5000);
                ShowWindow(hWnd, 1);
            }
            return;
        }



    }
}
