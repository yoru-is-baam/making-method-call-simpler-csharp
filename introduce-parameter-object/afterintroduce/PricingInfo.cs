using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduce_parameter_object.afterintroduce
{
	internal class PricingInfo
	{
		private double taxRate;
		private double discountRate;

		public PricingInfo(double taxRate, double discountRate)
		{
			this.taxRate = taxRate;
			this.discountRate = discountRate;
		}

		public double TaxRate
		{
			get { return taxRate; }
		}

		public double DiscountRate
		{
			get { return discountRate; }
		}
	}
}
