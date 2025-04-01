using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_YS
{
    public class ItemDatabase
    {
        private static List<Item> _items = new List<Item>
        {

            new Item(1, "스마트폰", "모든 면에서 유용하다.")

        };

        public static Item GetItemById(int id)
        {
            return _items.FirstOrDefault(i => i.Id == id);

        }

        public static List<Item> GetAllItems()
        {
            return _items;

        }
    }
}
