﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestLib
{
    /// <summary>
    /// Define a simple settings file that can be injected to the receivers.
    /// This type and its values must be registered in the application.json file.
    /// </summary>
    public class Settings
    {
        public string Key1 { get; set; }

        public int Key2 { get; set; }
    }
}
