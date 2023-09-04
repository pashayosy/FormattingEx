using System;
namespace FormattingEx.Models
{
	public static class Menu
	{
		/// <summary>
		/// Start the menu and ask for choose from the user
		/// </summary>
		/// <param name="name"></param>
		public static void StartMenu(string name)
		{
            Product[] products = new Product[] { new Product("Pc", 200, 50), new Product("Phone", -100, 100), new Product("Mouse", 40, 30) };
			int choose;

            Console.WriteLine($"Hello {name}, Choose one of the product below and write the number of it!");
			PrintProducts(products);

			while (!int.TryParse(Console.ReadLine(), out choose) || choose <= 0 || choose > 3)
			{
				Console.WriteLine("\t!!!Error!!!\nIncorrect number input");
			}

            products[choose - 1].PrintInvoice(name);
        }

		/// <summary>
		/// Print the array of prdoucts with overided ToString of Product
		/// </summary>
		/// <param name="products"></param>
		public static void PrintProducts(Product[] products)
		{
			for (int i = 0; i < products.Length; i++)
			{
				Console.Write($"{i+1}.{products[i].ToString()}");
			}
			Console.WriteLine("\n Choos one of the 3 option and type in");
		}

	}
}

