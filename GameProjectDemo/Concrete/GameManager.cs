using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class GameManager : IGameService
    {
      
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " isimli oyun eklendi. \n" +
                 "Fiyat : " + game.GamePrice +
                 "\nKategori : " + game.GameCategory);
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " isimli oyun kaldırıldı. ");
        }

        public void Update(Game game)
        { 
            Console.WriteLine(game.GameName + " isimli oyun güncellendi. \n");
        }
    }
}
