using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject

{
    class PlayerManager
    {
        List<IPlayer> players = new List<IPlayer>() { };
        public void Add(IPlayer player)
        {
            players.Add(player);
            Console.WriteLine("kullanıcı eklendi.");
            
        }

        public void Delete(IPlayer player)
        {
            Console.WriteLine("kullanıcı silindi.");
        }

        public void Update(IPlayer player)
        {
            Console.WriteLine("kullanıcı güncellendi.");
        }
    }

}
