namespace parameterize_method.beforeparameterize
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

		public void IncrementAgeToOne()
		{
			_age++;
		}

		public void IncrementAgeToFive()
		{
			_age += 5;
		}
	}
}
