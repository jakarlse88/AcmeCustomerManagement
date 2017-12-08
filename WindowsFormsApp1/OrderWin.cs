using ACM.BL;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class OrderWin : Form
	{
		public OrderWin()
		{
			InitializeComponent();
		}

		private void button1_Click_1(object sender, EventArgs e)
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

			try
			{
				var op = orderController.PlaceOrder(customer, order, payment,
					allowSplitOrders: false,
					emailReceipt: true);
			}
			catch (ArgumentNullException ex)
			{
				// Log issue
				// Display message to user that the order was not succesful
			}
		}
	}
}
