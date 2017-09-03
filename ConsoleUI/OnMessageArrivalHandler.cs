﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleUI
{
    public delegate void OnMessageArrivalHandler(object sender, ConsoleEditEventArgs e);


    public class ConsoleEditEventArgs : EventArgs
    {
        public string Message { get; set; }

        public static ConsoleEditEventArgs CreatEventArgs(string msg)
      {
          return new ConsoleEditEventArgs
          {
               Message=msg
          };
      }
    }
}

