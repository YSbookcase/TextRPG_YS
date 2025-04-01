using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_YS
{
    public class Inventory
    {
        private List<Item> _items = new List<Item>();

        public void AddItem(Item item)
        {
            _items.Add(item);
            Console.WriteLine($"{item.name}을(를) 인벤토리에 추가하였습니다.");

        }

        public void ShowInventory()
        {
            Console.WriteLine("====인벤토리====");
            foreach (var item in _items)
            {

                Console.WriteLine($" - {item.name} ({item.Description})");

            }

        }

        public bool HasItem(int itemId)
        {
            return _items.Any(item => item.Id == itemId);
        }

    }
}
