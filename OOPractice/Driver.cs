﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public class Driver
    {
        public string Drive(CarBase carBase)
        {
            return carBase.SpeedUp();
        }
    }
}
