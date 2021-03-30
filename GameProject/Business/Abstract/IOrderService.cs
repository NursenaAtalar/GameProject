using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Abstract
{
    public interface IOrderService
    {
        void Order(Game game, User user);

        void CampaignOrder(Game game, User user, Campaign campaign);
    }
}
