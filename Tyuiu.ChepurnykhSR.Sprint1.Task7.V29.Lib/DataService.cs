using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ChepurnykhSR.Sprint1.Task7.V29.Lib
{
    public class DataService : ISprint1Task7V29
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Round((x - ((Math.Cos(x * x * x)) / ((x * y) - 3)) + ((Math.Sin(x * x * x * x * x)) / ((x * y) + 5))), 3);
            return res;
        }
    }
}
