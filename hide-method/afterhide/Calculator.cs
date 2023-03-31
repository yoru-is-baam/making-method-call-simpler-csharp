namespace hide_method.afterhide
{
	internal class Calculator
	{
		private double result;

		public void Add(double a, double b)
		{
			result = a + b;
			PrintResult();
		}

		private void PrintResult()
		{
			Console.WriteLine("Result: " + result);
		}
	}
}
