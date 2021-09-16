using GameProjectDemo.Abstract;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game();
            game1.GameName = "PES 2020";
            game1.GameCategory = "Sports Game";
            game1.GamePrice= 199.99;
            
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Delete(game1);
            gameManager.Update(game1);

            
            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "Kaan";
            gamer1.LastName = "Kılıç";
            gamer1.BirthYear = 1990 ;
            gamer1.NationalityId = "12345678911";

            GamerManager gamerManager1 = new GamerManager(new VerificationManager());
            gamerManager1.Add(gamer1);
            gamerManager1.Delete(gamer1);
            gamerManager1.Update(gamer1);

            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Summer discount";
            campaign1.CampaignDiscount = 20;

            CampaingManager campaingManager1 = new CampaingManager();
            campaingManager1.Add(campaign1);
            campaingManager1.Delete(campaign1);
            campaingManager1.Update(campaign1);

            GamerManager gamerManager2 = new GamerManager(new VerificationManager());
            gamerManager2.Add(gamer1);
            gamerManager2.Delete(gamer1);
            gamerManager2.Update(gamer1);
            Console.ReadLine();

             
        }
    }
}
