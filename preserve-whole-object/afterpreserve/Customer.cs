namespace preserve_whole_object.afterpreserve
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
			return restaurant.IsWithinDeliveryRange(address);
		}
	}
}
