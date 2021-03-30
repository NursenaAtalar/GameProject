using GameProject.Business.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName +" Campaing is added");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Campaing is deleted");
        }

        public void UpDate(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " Campaing is updated");
        }
    }
}
