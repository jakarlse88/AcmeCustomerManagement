using ACM.BL;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class OrderWin : Form
	{
		public void Button1_Click(object sender, EventArgs e)
		{
			PlaceOrder();
		}

		private void PlaceOrder()
		{
			// Populate new customer from UI
			var customer = new Customer();

			// Populate the order from UI
			var order = new Order();
			
			// Populate payment info from UI
			var payment = new Payment();

			var orderController = new OrderController();
			orderController.PlaceOrder(customer, 
										order, 
										payment, 
										allowSplitOrders:false, 
										emailReceipt:true);
		}
	}
}
