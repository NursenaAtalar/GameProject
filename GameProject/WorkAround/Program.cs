using System;
using GameProject.Adapters;
using GameProject.Business.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new MernisServiceAdapter());
            User user1 = new User
            {
                Id = 1,
                DateOfBirth = 1997,
                FirstName = " Nursena",
                LastName = "  Atalar ",
                IdentityNumber=48016031700 
            };
            userManager.Add(user1);
            

            Console.WriteLine("----------------------------");

            CampaignManager campaingManager = new CampaignManager();
            Campaign campaign1 = new Campaign { Id = 1, CampaignName = "  New Season", DiscountRate = 0.45M };
            Campaign campaign2 = new Campaign { Id = 2, CampaignName = "  BlackFriday ", DiscountRate = 0.50M };
            campaingManager.Add(campaign1);

            Console.WriteLine("----------------------------");

            GameManager gameManager = new GameManager();
            Game game1 = new Game { Id = 1, GameName = "Minecraft", GamePrice = 400 };
            Game game2 = new Game { Id = 2, GameName = "Counter  ", GamePrice = 550 };

            gameManager.Add(game2);
            gameManager.Update(game1);

            Console.WriteLine("----------------------------");

            OrderManager orderManager = new OrderManager();

            orderManager.CampaignOrder(game1, user1, campaign2);
            orderManager.Order(game2, user1);

        }
    }
}
