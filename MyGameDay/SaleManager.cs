using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameDay
    {
    class SaleManager : ISaleManager
    {
        public void discount(Game game, Player player)
        {
            Console.WriteLine("Discount APPLİED !");
        }
    }
}
