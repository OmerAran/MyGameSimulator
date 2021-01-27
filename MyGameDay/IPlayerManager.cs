using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameDay
{
    interface IPlayerManager
    {
        void Add(Player player);

        void Update(Player player);

        void Delete(Player player);

    }   
}
