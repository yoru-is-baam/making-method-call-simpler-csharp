namespace hide_method.beforehide
{
	internal class Calculator
	{
		private double result;

		public void Add(double a, double b)
		{
			result = a + b;
			PrintResult();
		}

		public void PrintResult()
		{
			Console.WriteLine("Result: " + result);
		}
	}
}
