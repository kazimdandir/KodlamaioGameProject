using KodlamaioGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Abstract
{
    public interface IPlayerService
    {
        void SignUp(Player player);
        void Login(Player player);
        void UpdateInfo(Player player);
        void DeleteAccount(Player player);
    }
}
