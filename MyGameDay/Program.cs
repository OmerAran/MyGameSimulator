using System;

namespace MyGameDay
{
    class Program
    {
        static void Main(string[] args)
        {
         
           Player player1 = new Player() {PlayerId = 1, PlayerName = "Ömer", PlayerLastName = "Aran", PlayerTcNo = "12345678901",PlayerNickname="theomer",DateOfBirth= 2001 };

            Player player2 = new Player() { PlayerId = 2, PlayerName = "Engin", PlayerLastName = "Demiroğ", PlayerTcNo = "109876543212", PlayerNickname = "theengin", DateOfBirth = 2000 };

            Game game1 = new Game() { GameId = 1,GameName="CS:GO",GamePrice=19,Category="war"};

            PlayerCheckManager playerCheckManager = new PlayerCheckManager();
            PlayerManager playerManager = new PlayerManager();

            if (playerCheckManager.CheckRealPlayer(player1))
            {
                playerManager.Add(player1);
            }
            else
            {
                Console.WriteLine("Geçersiz giriş!!!");
            }

            GameManager gameManager = new GameManager();
            CampaignManager campaignManager = new CampaignManager();
            SaleManager saleManager = new SaleManager();

            
            
            
        








        }
    }
}
