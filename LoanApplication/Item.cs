using System;

namespace LoanApplicationDemo
{
	public enum ItemTypes
	{
		RegionalProvince,
		Purpose,
		IndustryType
	}

	abstract class Item
	{
		public Guid Id;

		private string name;

		public string Name
		{
			get { return name; }
		}

		public void setName(string name)
		{
			Console.WriteLine($"Updating name from '{ this.name }' to '{ name }' ");
			this.name = name;
		}

		private bool isActive;

		public bool IsActive
		{
			get { return isActive; }
		}

		private ItemTypes itemType;

		public ItemTypes ItemType
		{
			get { return itemType; }
			set { itemType = value; }
		}

		public void setIsActive(bool isActive)
		{
			Console.WriteLine($"Updating isActive from '{ this.isActive }' to '{ isActive }' for {this.name} ");
			this.isActive = isActive;
		}

		public Item(string name)
		{
			this.Id = Guid.NewGuid();	
			this.name = name;
			this.isActive = true;
		}
	}
}
