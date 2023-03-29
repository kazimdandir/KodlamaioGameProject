using KodlamaioGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Abstract
{
    public interface ICampaingService
    {
        void AddCampaing(Campaing campaing);
        void UpdateCampaing(Campaing campaing);
        void DeleteCampaing(Campaing campaing);
    }
}
