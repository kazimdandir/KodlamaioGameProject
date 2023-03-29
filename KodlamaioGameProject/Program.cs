using KodlamaioGameProject.Concrete;
using KodlamaioGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CampaingManager campaingManager = new CampaingManager();
            GameSellingManager gameSellingManager = new GameSellingManager();
            PlayerManager playerManager = new PlayerManager();
            Player player = new Player("1", "Kazım", "Dandır", new DateTime(1996, 7, 13));
            Game game = new Game("FIFA 2023", 400);
            Campaing campaing = new Campaing("FIFA 2023 on Sale!", 40);

            playerManager.SignUp(player);
            playerManager.UpdateInfo(player);
            playerManager.DeleteAccount(player);
            playerManager.CheckIfRealPlayer(player);

            Console.WriteLine("--------------------");

            gameSellingManager.SellGame(player, game, campaing);

            Console.WriteLine("--------------------");

            campaingManager.AddCampaing(campaing);
            campaingManager.UpdateCampaing(campaing);
            campaingManager.DeleteCampaing(campaing);

            Console.ReadLine();
        }
    }
}
