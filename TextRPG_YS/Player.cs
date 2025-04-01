using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_YS
{
    public class Player
    {
        private string _playerName;
        public Inventory Inventory { get; }
        

        private int heart;

        public Player(string name = "YS")
        {

            _playerName = name;
            Inventory = new Inventory();


        }
        

    }
}
