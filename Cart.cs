using System;
using System.Collections.Generic;

// Cart to track customers shopping list

namespace ShoppingCart {
	class Cart {
		private Dictionary<string, int> _scannedItems = new Dictionary<string, int>();

		// Item scanner adds shopping to cart. Can take multiple items with delimeter ,
		public void ScanItems(string items) {
			string tmp;

			foreach (string item in items.Split(",")) {
				tmp = item.Trim().ToLower();

				_scannedItems[tmp] = _scannedItems.ContainsKey(tmp) ? _scannedItems[tmp] + 1 : 1;
			}
		}
	}
}
