using Core.Common;
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

		public OperationResult ValidateEmail()
		{
			var op = new OperationResult();

			if (string.IsNullOrWhiteSpace(this.EmailAddress))
			{
				op.Success = false;
				op.AddMessage("Email address is null");
			}

			if (op.Success == true)
			{
				var isValidFormat = true;
				// Code to validate format using regex
				if (!isValidFormat)
				{
					op.Success = false;
					op.AddMessage("Email address uses incorrect format");
				}
			}

			if (op.Success == true)
			{
				var isValidDomain = true;
				// Code to confirm whether domain exists
				if (!isValidDomain)
				{
					op.Success = false;
					op.AddMessage("Email address does not include a valid domain");
				}
			}

			return op;
		}

		public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
		{
			if (string.IsNullOrWhiteSpace(goalSteps)) throw new ArgumentException("Goal must be entered", "goalSteps");
			if (string.IsNullOrWhiteSpace(actualSteps)) throw new ArgumentException("Goal must be entered", "actualSteps");

			if (!decimal.TryParse(goalSteps, out decimal goalStepsCount)) throw new ArgumentException("Goal must be numeric");
			if (!decimal.TryParse(actualSteps, out decimal actualStepsCount)) throw new ArgumentException("Actual steps must be numeric", "actualSteps");

			return CalculatePercentOfGoalSteps(goalStepsCount, actualStepsCount);
		}

		public decimal CalculatePercentOfGoalSteps(decimal goalStepsCount, decimal actualStepsCount)
		{
			if (goalStepsCount <= 0) throw new ArgumentException("Goal must be greater than 0", "goalSteps");

			return Math.Round((actualStepsCount / goalStepsCount), 2) * 100;
		}
	}
}
