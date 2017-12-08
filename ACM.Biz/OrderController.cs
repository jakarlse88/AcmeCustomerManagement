using Core.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
		
		/// <summary>
		/// Places an order.
		/// </summary>
		/// <param name="customer"></param>
		/// <param name="order"></param>
		/// <param name="payment"></param>
		/// <param name="allowSplitOrders"></param>
		/// <param name="emailReceipt"></param>
		/// <returns></returns>
		public OperationResult PlaceOrder(Customer customer, 
										Order order,
										Payment payment,
										bool allowSplitOrders, 
										bool emailReceipt)
		{
			Debug.Assert(CustomerRepository != null, "Missing CustomerRepository instance");
			Debug.Assert(OrderRepository != null, "Missing OrderRepository instance");
			Debug.Assert(InventoryRepository != null, "Missing InventoryRepository instance");
			Debug.Assert(EmailLibrary != null, "Missing EmailLibrary instance");

			if (customer == null) throw new ArgumentException("Customer instance is null");
			if (order == null) throw new ArgumentException("Order instance is null");
			if (payment == null) throw new ArgumentException("Payment instance is null");

			var op = new OperationResult();

			CustomerRepository.Add(customer);
			
			OrderRepository.Add(order);
			
			InventoryRepository.OrderItems(order, allowSplitOrders);

			payment.ProcessPayment();

			if (emailReceipt)
			{
				var emailValidationResult = customer.ValidateEmail();

				if (emailValidationResult.Success == true)
				{
					CustomerRepository.Update();

					EmailLibrary.SendEmail(customer.EmailAddress,
											"Please find attached the requested receipt.");
				}
				else if (emailValidationResult.MessageList.Any())
				{
					op.AddMessage(emailValidationResult.MessageList[0]);
				}
				
			}

			return op;
		}
	}
}
