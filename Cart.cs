using System;
using System.Collections.Generic;

// Cart to track customers shopping list
namespace ShoppingCart {
	static class Stock {
		public static Dictionary<string, decimal> allStock = new Dictionary<string, decimal> {
			{"apple", 0.60m},
			{"orange", 0.25m}
		};
	}

	class Cart {
		private Dictionary<string, int> _scannedItems = new Dictionary<string, int>();

		// Item scanner adds shopping to cart. Can take multiple items with delimeter ,
		public void ScanItems(string items) {
			foreach (string item in items.Split(",")) {
				AddItemToCart(item.Trim().ToLower());
			}

			PrintCart();
		}

		// Adds an available item to the cart
		private void AddItemToCart(string item) {
			if (!Stock.allStock.ContainsKey(item))
				return;

			_scannedItems[item] = _scannedItems.ContainsKey(item) ? _scannedItems[item] + 1 : 1;
		}

		public void PrintCart() {
			foreach (var item in _scannedItems.Keys) {
				Console.WriteLine($"{item}: {_scannedItems[item] }. Price: {_scannedItems[item] * Stock.allStock[item]}");
			}
		}
	}
}
