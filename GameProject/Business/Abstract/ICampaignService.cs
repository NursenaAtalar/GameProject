using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void UpDate(Campaign campaign);
    }
}
