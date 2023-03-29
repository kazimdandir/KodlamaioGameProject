using KodlamaioGameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Entities
{
    public class Game : IEntity
    {
        public string GameName { get; set; }
        public double GamePrice { get; set; }
        public Game(string gameName, double gamePrice)
        {
            GameName = gameName;
            GamePrice = gamePrice;
        }
    }
}
