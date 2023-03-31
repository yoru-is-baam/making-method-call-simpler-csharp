namespace replace_error_code_with_exception.afterreplace
{
	internal class Calculator
	{
		public int Divide(int a, int b)
		{
			if (b == 0)
			{
				throw new DivideByZeroException("Cannot divide by zero");
			}
			return a / b;
		}
	}
}
