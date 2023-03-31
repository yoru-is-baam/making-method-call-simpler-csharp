namespace replace_exception_with_test.beforereplace
{
	internal class Example
	{
		public static void Main(string[] args)
		{
			Calculator calculator = new Calculator();
			try
			{
				int result = calculator.SquareRoot(-1);
				Console.WriteLine(result);
			}
			catch (ArgumentException e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
