using GameProjectDemo.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Entities
{
    class Game : GameManager
    {
        public String GameName { get; set; }
        public double GamePrice { get; set; }
        public String GameCategory { get; set; }
    }
}
