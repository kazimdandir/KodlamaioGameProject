using KodlamaioGameProject.Abstract;
using KodlamaioGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Concrete
{
    public class PlayerManager : IPlayerService, IPlayerCheckService
    {
        public void DeleteAccount(Player player)
        {
            Console.WriteLine("Player : " + player.FirstName + "'s Account Had Been Deleted");
        }

        public void Login(Player player)
        {
            Console.WriteLine("Player : " + player.FirstName + "'s Account Had Been Logined");
        }

        public void SignUp(Player player)
        {
            Console.WriteLine("Player : " + player.FirstName + " Signed Up");
        }

        public void UpdateInfo(Player player)
        {
            Console.WriteLine("Player : " + player.FirstName + "'s Informations Had Been Updated");
        }
        public void CheckIfRealPlayer(Player player)
        {
            Console.WriteLine(player.FirstName + " Has Been Verified");
        }
    }
}
