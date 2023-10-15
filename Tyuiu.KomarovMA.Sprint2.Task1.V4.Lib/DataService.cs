using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KomarovMA.Sprint2.Task1.V4.Lib
{
    public class DataService : ISprint2Task1V4
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c > d + 1); // f f = f
            res[1] = (a < b) & (c > d + 1); // t f = f
            res[2] = (a > b) || (c > d + 1);// f f = f
            res[3] = (a > b) && (c < d + 1); //
            res[4] = !res[0]; //
            res[5] = (a > b) ^ (c > d + 1); //

            return res;

        }
    }
}