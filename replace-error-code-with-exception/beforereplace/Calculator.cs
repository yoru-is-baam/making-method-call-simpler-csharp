namespace replace_error_code_with_exception.beforereplace
{
	internal class Calculator
	{
		public int Divide(int a, int b)
		{
			if (b == 0)
			{
				throw new ArithmeticException("Cannot divide by zero");
			}
			return a / b;
		}
	}
}
