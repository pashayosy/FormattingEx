using System;
namespace FormattingEx.Models
{
	public class Product
	{
		public string Name { private set; get; }
		public double Price
		{
			set
			{
				if (value >= 0)
					_price = value;
			}
			get { return _price; }
		}
		private double _price;

		public DateTime WarrantyDate { set; get; }
		private DateTime _warrantyDate;


		public Product(string name, double price, double numOfWarrantyDays)
		{
			Name = name;
			_price = price >= 0 ? price : 100;
			_warrantyDate = DateTime.Now;
			_warrantyDate = _warrantyDate.AddDays(numOfWarrantyDays);
		}

        public override string ToString()
        {
			return $"\nName: {Name}\nPrice : {Price}\nWarranty until: {_warrantyDate.ToString()}\n";
        }

		/// <summary>
		/// Print the invoice using String Forrmating
		/// </summary>
		public void PrintInvoice(string userName)
		{
			string message;

			message = $"Customer Name: {userName}\n" +
					  $"Product Name: {Name}\n" +
					  $"Product Price: {_price:c}\n" +
					  $"Warranty Expire: {_warrantyDate:f}";

			Console.WriteLine($"\n{message}\n");
		}
    }
}

