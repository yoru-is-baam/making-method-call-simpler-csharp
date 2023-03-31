namespace introduce_parameter_object.afterintroduce
{
	internal class Order
	{
		private string item;
		private int quantity;
		private double price;

		public Order(string item, int quantity, double price)
		{
			this.item = item;
			this.quantity = quantity;
			this.price = price;
		}

		public double CalculateTotal(PricingInfo pricingInfo)
		{
			double tax = price * quantity * pricingInfo.TaxRate;
			double discount = price * quantity * pricingInfo.DiscountRate;
			return (price * quantity) + tax - discount;
		}
	}
}
