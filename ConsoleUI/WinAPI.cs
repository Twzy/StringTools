using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleUI
{
    public class WinAPI
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool LockWindowUpdate(IntPtr hWndLock);

//LockWindowUpdate(this.Handle);  
//do   something  
//LockWindowUpdate((System.IntPtr)0);  



        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, IntPtr lParam);
        public const int WM_SETREDRAW = 0xB;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
    }
}
