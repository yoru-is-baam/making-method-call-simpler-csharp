namespace parameterize_method.afterparameterize
{
	internal class Customer
	{
		private string _name;
		private int _age;

		public Customer(string name, int age)
		{
			_name = name;
			_age = age;
		}

		public String GetName() { return _name; }

		public int GetAge()
		{
			return _age;
		}

		public void IncrementAge(int value)
		{
			_age += value;
		}
	}
}
