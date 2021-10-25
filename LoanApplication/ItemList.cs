using System;
using System.Collections.Generic;
using System.Linq;

namespace LoanApplicationDemo
{
	class ItemList
	{
		private ItemTypes itemtype;
		private List<Item> items;

		public void addItem(Item item)
		{
			if (item.ItemType != this.itemtype)
				return;

			items.Add(item);
		}

		public void hideItem(Item item)
		{
			item.setIsActive(false);
		}

		public List<Item> getList()
		{
			return items.Where(i => i.IsActive == true).ToList();
		}

		public ItemList(ItemTypes itemtype)
		{
			this.items = new List<Item>();
			this.itemtype = itemtype;
		}

		public void printList()
		{
			Console.WriteLine($"List of {itemtype}:");

			foreach (Item item in getList())
			{
				Console.WriteLine(item.Name);
			}
		}
	}
}
