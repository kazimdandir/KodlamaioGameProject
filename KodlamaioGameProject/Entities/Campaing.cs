using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioGameProject.Entities
{
    public class Campaing
    {
        public string CampaingName { get; set; }
        public double CampaingRate { get; set; }

        public Campaing(string campaingName, double campaingRate)
        {
            CampaingName = campaingName;    
            CampaingRate = campaingRate;
        }
    }
}
