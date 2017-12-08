using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTests
{
	[TestClass]
	public class CustomerTests
	{
		[TestMethod]
		public void CalculatePercentageOfGoalStepsTestValid()
		{
			// -- Arrange --
			var customer = new Customer();
			string goalSteps = "5000";
			string actualSteps = "2000";
			decimal expected = 40M;

			// -- Act --
			var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

			// -- Assert --
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CalculatePercentageOfGoalStepsTestValidAndSame()
		{
			// -- Arrange --
			var customer = new Customer();
			string goalSteps = "5000";
			string actualSteps = "5000";
			decimal expected = 100M;

			// -- Act --
			var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

			// -- Assert --
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void CalculatePercentageOfGoalStepsTestValidActualIsZero()
		{
			// -- Arrange --
			var customer = new Customer();
			string goalSteps = "5000";
			string actualSteps = "0";
			decimal expected = 0M;

			// -- Act --
			var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

			// -- Assert --
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void CalculatePercentOfGoalStepsGoalIsNull()
		{
			// -- Arrange --
			var customer = new Customer();
			string goalSteps = null;
			string actualSteps = "2000";

			// -- Act --
			var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

			// -- Assert --
			// Unnecessary
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void CalculatePercentOfGoalStepsGoalIsNotNumeric()
		{
			// -- Arrange --
			var customer = new Customer();
			string goalSteps = "one";
			string actualSteps = "2000";

			// -- Act --
			try
			{
				var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);
			}
			catch (Exception e)
			{

				Assert.AreEqual("Goal must be numeric", e.Message);
				throw;
			}
			
			// -- Assert --
			// Unnecessary
		}
	}
}
