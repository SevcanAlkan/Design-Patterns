using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    public class CDType
    {
        private List<IPacking> Items = new List<IPacking>();

        public void AddItem(IPacking packs)
        {
            Items.Add(packs);
        }

        public void GetCost()
        {
            foreach (var item in Items)
            {
                item.Price();
            }
        }

        public void ShowItems()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(@$"
                    CD Name: {item.Pack()}
                    Price: {item.Price()}
                ");
            }
        }
    }
}
