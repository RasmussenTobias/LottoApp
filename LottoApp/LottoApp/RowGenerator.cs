using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoApp
{
    class RowGenerator
    {
        public void RowGen(int amount)
        {
            Random Winningrnd = new Random();
            Random Starrnd = new Random();
            Winningrnd.Next(10000000, 99999999);
            Starrnd.Next(0,9);


        }
    }
}
