namespace replace_parameter_with_method_call.afterreplace
{
	internal class Customer
	{
		private Address address;

		public Customer(Address address)
		{
			this.address = address;
		}

		public double CalculateDiscountPublic(double discountRate)
		{
			return CalculateDiscount(discountRate);
		}

		private double CalculateDiscount(double discountRate)
		{
			int customerZipCode = address.ZipCode;
			int customerAreaCode = address.AreaCode;
			// logic to calculate the discount based on the discount rate, zip code and area code
			return 0.0;
		}
	}
}
