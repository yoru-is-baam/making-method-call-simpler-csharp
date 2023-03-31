namespace replace_exception_with_test.beforereplace
{
	internal class Calculator
	{
		public int SquareRoot(int x)
		{
			if (x < 0)
			{
				throw new ArgumentException("Cannot take square root of negative number");
			}
			return (int)Math.Sqrt(x);
		}
	}
}
