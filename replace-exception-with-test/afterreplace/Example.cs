namespace replace_exception_with_test.afterreplace
{
	internal class Example
	{
		public static void Main(string[] args)
		{
			Calculator calculator = new Calculator();
			if (-1 < 0)
			{
				Console.WriteLine("Cannot take square root of negative number");
			}
			else
			{
				int result = calculator.SquareRoot(-1);
				Console.WriteLine(result);
			}
		}
	}
}
