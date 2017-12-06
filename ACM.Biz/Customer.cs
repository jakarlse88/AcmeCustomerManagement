using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
	/// <summary>
	/// Manages a single customer.
	/// </summary>
    public class Customer
    {
		public int CustomerId { get; set; }
		public string EmailAddress { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public Customer()
		{

		}

		public Customer(int customerId, string emailAddress, string firstName, string lastName)
		{
			this.CustomerId = customerId;
			this.EmailAddress = emailAddress;
			this.FirstName = firstName;
			this.LastName = lastName;
		}

		public void ValidateEmail()
		{
			// -- Send an email receipt --
			// If the user requested a receipt,
			// get the customer data.
			// Ensure a valid email address was provided.
			// If not, request an email address from the user.
		}
	}
}
