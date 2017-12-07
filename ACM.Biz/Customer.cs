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

		public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
		{
			// Try 3
			if (string.IsNullOrWhiteSpace(goalSteps)) throw new ArgumentException("Goal must be entered", "goalSteps");
			if (string.IsNullOrWhiteSpace(actualSteps)) throw new ArgumentException("Goal must be entered", "actualSteps");

			if (!decimal.TryParse(goalSteps, out decimal goalStepsCount)) throw new ArgumentException("Goal must be numeric", "goalSteps");
			if (!decimal.TryParse(actualSteps, out decimal actualStepsCount)) throw new ArgumentException("Actual steps must be numeric", "actualSteps");

			return CalculatePercentOfGoalSteps(goalStepsCount, actualStepsCount);
		}

		public decimal CalculatePercentOfGoalSteps(decimal goalStepsCount, decimal actualStepsCount)
		{
			if (goalStepsCount <= 0) throw new ArgumentException("Goal must be greater than 0", "goalSteps");

			return (actualStepsCount / goalStepsCount) * 100;
		}
	}
}
