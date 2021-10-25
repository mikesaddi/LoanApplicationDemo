using System;

namespace LoanApplicationDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			//intialize list of regional provinces
			var britishcolumbia = new RegionalProvince("British Columbia");
			var alberta = new RegionalProvince("Alberta");
			var ontario = new RegionalProvince("Ontario");
			var quebec = new RegionalProvince("Quebecc");
			var manitoba = new RegionalProvince("Manitoba");
			ItemList regionalprovinces = new ItemList(ItemTypes.RegionalProvince);
			regionalprovinces.addItem(britishcolumbia);
			regionalprovinces.addItem(alberta);
			regionalprovinces.addItem(ontario);
			regionalprovinces.addItem(quebec);
			regionalprovinces.addItem(manitoba);

			//intialize list of purposes
			var rfe = new Purpose("Refinance Existing Loans");
			var wc = new Purpose("Working Capital");
			var ef = new Purpose("Emergency Funds");
			ItemList purposes = new ItemList(ItemTypes.Purpose);
			purposes.addItem(rfe);
			purposes.addItem(wc);
			purposes.addItem(ef);

			//intialize list of industry types
			var acc = new IndustryType("Accounting / Bookkeeping");
			var auto = new IndustryType("Automotive / Auto Repair");
			var sales = new IndustryType("Equipment Sales / Rental");
			ItemList industrytypes = new ItemList(ItemTypes.IndustryType);
			industrytypes.addItem(acc);
			industrytypes.addItem(auto);
			industrytypes.addItem(sales);

			LoanApplication loanApplication0 = new LoanApplication(alberta, rfe, auto);
			LoanApplication loanApplication1 = new LoanApplication(quebec, wc, sales);

			//display all active regional provinces
			regionalprovinces.printList();
			Console.WriteLine();

			//"visually" remove Alberta
			loanApplication0.printLoanApplication();
			regionalprovinces.hideItem(alberta);
			regionalprovinces.printList();
			loanApplication0.printLoanApplication();
			Console.WriteLine();

			//fixed typo for Quebec
			loanApplication1.printLoanApplication();
			quebec.setName("Quebec");
			loanApplication1.printLoanApplication();
			Console.WriteLine();

			//changed purpose of LoanApplication0
			loanApplication0.printLoanApplication();
			loanApplication0.setPurpose(ef);
			loanApplication0.printLoanApplication();
			Console.WriteLine();

			Console.ReadLine();
		}
	}
}
