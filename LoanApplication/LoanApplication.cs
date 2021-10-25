using System;

namespace LoanApplicationDemo
{
	class RegionalProvince : Item
	{
		public RegionalProvince(string name) : base(name)
		{
			ItemType = ItemTypes.RegionalProvince;
		}
	}

	class Purpose : Item
	{
		public Purpose(string name) : base(name)
		{
			ItemType = ItemTypes.Purpose;
		}
	}

	class IndustryType : Item
	{
		public IndustryType(string name) : base(name)
		{
			ItemType = ItemTypes.IndustryType;
		}
	}

	class LoanApplication
	{
		public Guid Id;
		private RegionalProvince regionalProvince;
		public RegionalProvince RegionalProvince
		{
			get { return regionalProvince; }
		}

		private Purpose purpose;
		public Purpose Purpose
		{
			get { return purpose; }
		}

		private IndustryType industryType;
		public IndustryType IndustryType
		{
			get { return industryType; }
		}

		public LoanApplication(RegionalProvince regionalProvince, Purpose purpose, IndustryType industryType)
		{
			this.Id = Guid.NewGuid();
			this.regionalProvince = regionalProvince;
			this.purpose = purpose;
			this.industryType = industryType;
		}

		public void setRegionalProvince(RegionalProvince regionalProvince)
		{
			Console.WriteLine($"Updating Regional Province from '{ this.regionalProvince.Name }' to '{ regionalProvince.Name }' for Loan Application { this.Id }");
			this.regionalProvince = regionalProvince;
		}

		public void setPurpose(Purpose purpose)
		{
			Console.WriteLine($"Updating Purpose from '{ this.purpose.Name }' to '{ purpose.Name }' for Loan Application { this.Id }");
			this.purpose = purpose;
		}

		public void setIndustryType(IndustryType industryType)
		{
			Console.WriteLine($"Updating Industry Type from '{ this.industryType.Name }' to '{ industryType.Name }' for Loan Application { this.Id }");
			this.industryType = industryType;
		}

		public void printLoanApplication()
		{
			Console.WriteLine($"Loan application { this.Id } from { this.RegionalProvince.Name } with purpose '{this.purpose.Name}' and industry type '{ this.industryType.Name }'");
		}

	}
}
