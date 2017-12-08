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
		private CustomerRepository customerRepository { get; set; }
		private OrderRepository orderRepository { get; set; }
		private InventoryRepository inventoryRepository { get; set; }
		private EmailLibrary emailLibrary { get; set; }

		public OrderController()
		{
			this.customerRepository = new CustomerRepository();
			this.orderRepository = new OrderRepository();
			this.inventoryRepository = new InventoryRepository();
			this.emailLibrary = new EmailLibrary();
		}
		
		public void PlaceOrder(Customer customer, 
										Order order,
										Payment payment,
										bool allowSplitOrders, 
										bool emailReceipt)
		{
			
			customerRepository.Add(customer);
			
			orderRepository.Add(order);
			
			inventoryRepository.OrderItems(order, allowSplitOrders);

			payment.ProcessPayment();

			if (emailReceipt)
			{
				var op = customer.ValidateEmail();

				if (op.Success == true)
				{
					customerRepository.Update();

					emailLibrary.SendEmail(customer.EmailAddress,
											"Please find attached the requested receipt.");
				}
			}
		}
	}
}
