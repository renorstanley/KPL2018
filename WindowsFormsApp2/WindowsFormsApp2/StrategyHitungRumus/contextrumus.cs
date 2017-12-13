using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePaint
{
    class contextrumus
    {
        private rumusbentukstrategy _rumusbentukstrategy;
        public void pakairumushitung(rumusbentukstrategy rumusbentuk)
        {
            this._rumusbentukstrategy = rumusbentuk;
        }
        public  double luas(int toX, int toY, int fromX, int fromY)
        {
            double finalluas = _rumusbentukstrategy.luas(toX,toY, fromX, fromY);

            return finalluas;
        }
       
    }
}
