using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class GameSaleManager : IGameSaleService
    {
        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            double newPrice = game.GamePrice - game.GamePrice*campaign.CampaignDiscount;
            Console.WriteLine(game.GameName + " isimli oyun " + gamer.FirstName + " isimli kullanıcıya %" + campaign.CampaignDiscount + 
                " indirim oranıyla" + newPrice +"TL ye satıldı.");
        }
    }
}
