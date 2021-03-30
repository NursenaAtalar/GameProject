using GameProject.Business.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        public void CampaignOrder(Game game, User user, Campaign campaign)
        {
            decimal finalPrice = game.GamePrice - (game.GamePrice * campaign.DiscountRate);
            Console.WriteLine("dear user you can buy " +  " " + game.GameName + " game  " + " for "+finalPrice +" with" + campaign.CampaignName );
        }

        public void Order(Game game, User user)
        {
            Console.WriteLine("dear user you can buy " + " " + game.GameName + " game  " + " for " + game.GamePrice);
        }
    }
}

     
