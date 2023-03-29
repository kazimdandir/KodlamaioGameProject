using KodlamaioGameProject.Abstract;
using KodlamaioGameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Concrete
{
    public class CampaingManager : ICampaingService
    {
        public void AddCampaing(Campaing campaing)
        {
            Console.WriteLine("Campaing : " + campaing.CampaingName + " Is Now For " + campaing.CampaingRate + " Off!");
        }

        public void DeleteCampaing(Campaing campaing)
        {
            Console.WriteLine("Campaing : " + campaing.CampaingName + " Had Been Deleted");
        }

        public void UpdateCampaing(Campaing campaing)
        {
            Console.WriteLine("Campaing : " + campaing.CampaingName + " Had Been Updated");
        }
    }
}
