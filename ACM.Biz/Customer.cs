﻿using System;
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
	}
}
