﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ChepurnykhSR.Sprint1.Task6.V18.Lib
{
    public class DataService : ISprint1Task6V18
    {       
        public bool CheckNumber(string value)
        {
            foreach (char c in value)
                if (Char.IsNumber(c))
                    return true;
            return false;
        }
    }
}