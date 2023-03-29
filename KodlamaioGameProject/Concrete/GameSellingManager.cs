using KodlamaioGameProject.Abstract;
using KodlamaioGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Concrete
{
    public class GameSellingManager : IGameSellingService
    {
        public void SellGame(Player player, Game game, Campaing campaing)
        {
            Console.WriteLine("Player : " + player.FirstName + " Had Bougth The Game " + game.GameName + " For " + (game.GamePrice - (game.GamePrice * (campaing.CampaingRate / 100))));
        }
    }
}
