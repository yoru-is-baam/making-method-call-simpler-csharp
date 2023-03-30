namespace preserve_whole_object.beforepreserve
{
	internal class Customer
	{
		private Address address;

		public Customer(Address address)
		{
			this.address = address;
		}

		public bool IsWithinDeliveryRange(Restaurant restaurant)
		{
			int customerZipCode = address.ZipCode;
			int customerAreaCode = address.AreaCode;
			return restaurant.IsWithinDeliveryRange(customerZipCode, customerAreaCode);
		}
	}
}
