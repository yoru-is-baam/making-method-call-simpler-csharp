namespace introduce_parameter_object.beforeintroduce
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

		public double CalculateTotal(double taxRate, double discountRate)
		{
			double tax = price * quantity * taxRate;
			double discount = price * quantity * discountRate;
			return (price * quantity) + tax - discount;
		}
	}
}
