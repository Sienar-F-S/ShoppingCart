using System;
using System.Collections.Generic;

// Simple Shopping Cart feature

namespace ShoppingCart
{
    class Program
    {

		private Cart cart;

        static void Main(string[] args)
        {
			Console.WriteLine($"Args {args.Length}");
			Cart cart = new Cart();

			if (args.Length > 0) {
				cart.ScanItems(args[0]);
			} else {
				cart.ScanItems("Apple, Apple, apple, orange, apple");
			}
		}

    }
}
