using System;
using System.Collections.Generic;

// Cart to track customers shopping list
namespace ShoppingCart {

	// Price for each item in stock
	static class StockPrice {
		public static Dictionary<string, decimal> allStock = new Dictionary<string, decimal> {
			{"apple", 0.60m},
			{"orange", 0.25m}
		};
	}

	// Special offer for item. 
	static class SimpleOffer {
		public static Dictionary<string, string> offerForItem = new Dictionary<string, string> {
			{"apple", "BuyOneGetOneFree"},
			{"orange", "ThreeForTwo"}
		};
	}

	class Cart {
		private Dictionary<string, int> _scannedItems = new Dictionary<string, int>();

		// Item scanner adds shopping to cart. Can take multiple items with delimeter ,
		public void ScanItems(string items) {
			foreach (string item in items.Split(",")) {
				AddItemToCart(item.Trim().ToLower());
			}
		}

		// Adds an available item to the cart
		private void AddItemToCart(string item) {
			if (!StockPrice.allStock.ContainsKey(item))
				return;

			_scannedItems[item] = _scannedItems.ContainsKey(item) ? _scannedItems[item] + 1 : 1;
		}

		public void PrintCart() {
			foreach (var item in _scannedItems.Keys) {
				Console.WriteLine($"{item}: {_scannedItems[item] }. Price: {_scannedItems[item] * StockPrice.allStock[item]}");
			}

			Console.WriteLine($"Total Price: {CalculatedTotalPrice()}");
		}

		// Returns total price of cart
		private decimal CalculatedTotalPrice() {
			decimal tmp = 0m;

			foreach (var item in _scannedItems.Keys) {
				tmp =+ _scannedItems[item] * StockPrice.allStock[item];
			}

			return tmp;
		}
	}
}
