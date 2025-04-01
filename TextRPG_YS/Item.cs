using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_YS
{
    public class Item
    {
        public int Id { get; }
        public string name { get; }
        public string Description { get; }
     
        public Item(int id, string name, string description)
        {
            Id = id;
            this.name = name;
            Description = description;
        }
    }
}
