﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	public class InventoryRepository
	{
		public void OrderItems(Order order, bool allowSplitOrders)
		{
			// -- Order the item from inventory --
			// For each item ordered
			// Locate the item in inventory
			// If no longer available, notify the user
			// If any items are back ordered and
			// the customer doesn't want to split orders,
			// notify the user
			// If the item is available,
			// Decrement the quantity remaining.
			// Open a connection
			// Set stored procedure parameters with the inventory data
			// Call the save stored procedure
		}
	}
}
