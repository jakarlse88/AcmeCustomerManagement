using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
	public enum PaymentTypeOptions
	{
		CreditCard = 1,
		PayPal = 2
	}

    public class Payment
    {
		public int PaymentType { get; set; }

		public void ProcessPayment()
		{
			// -- Process the payment --
			// If credit card,
			// process the credit card payment
			// If paypal, 
			// process the paypal payment.
			// If there is a payment problem, notify the user
			// Open a connection
			// Set stored parameters with the payment data.
			// Call the save stored procedure
		}
	}
}
