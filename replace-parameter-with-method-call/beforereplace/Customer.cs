namespace replace_parameter_with_method_call.beforereplace
{
	internal class Customer
	{
		private Address address;

		public Customer(Address address)
		{
			this.address = address;
		}

		public double CalculateDiscount(double discountRate)
		{
			int customerZipCode = address.ZipCode;
			int customerAreaCode = address.AreaCode;
			return CalculateDiscount(discountRate, customerZipCode, customerAreaCode);
		}

		private double CalculateDiscount(double discountRate, int customerZipCode, int customerAreaCode)
		{
			// logic to calculate the discount based on the discount rate, zip code and area code
			return 0.0;
		}
	}
}
