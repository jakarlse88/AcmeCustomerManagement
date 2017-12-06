using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order
    {
		public int OrderId { get; set; }
		public int QuantityOfItems { get; set; }
		public bool AllowSplitOrder { get; set; }

		public Order()
		{

		}

		public Order(int orderId, int quantityOfIterms, bool allowSplitOrder)
		{
			this.OrderId = orderId;
			this.QuantityOfItems = quantityOfIterms;
			this.AllowSplitOrder = allowSplitOrder;
		}
	}
}
