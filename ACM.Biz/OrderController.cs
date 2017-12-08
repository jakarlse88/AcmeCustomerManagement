using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	public class OrderController
	{
		private CustomerRepository CustomerRepository { get; set; }
		private OrderRepository OrderRepository { get; set; }
		private InventoryRepository InventoryRepository { get; set; }
		private EmailLibrary EmailLibrary { get; set; }

		public OrderController()
		{
			this.CustomerRepository = new CustomerRepository();
			this.OrderRepository = new OrderRepository();
			this.InventoryRepository = new InventoryRepository();
			this.EmailLibrary = new EmailLibrary();
		}
		
		public void PlaceOrder(Customer customer, 
										Order order,
										Payment payment,
										bool allowSplitOrders, 
										bool emailReceipt)
		{
			
			CustomerRepository.Add(customer);
			
			OrderRepository.Add(order);
			
			InventoryRepository.OrderItems(order, allowSplitOrders);

			payment.ProcessPayment();

			if (emailReceipt)
			{
				var op = customer.ValidateEmail();

				if (op.Success == true)
				{
					CustomerRepository.Update();

					EmailLibrary.SendEmail(customer.EmailAddress,
											"Please find attached the requested receipt.");
				}
			}
		}
	}
}
