namespace separate_query_from_modifier.beforeseparate
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

		public int GetAgeAndIncrement() {
			int result = _age;
			_age++;

			return result; 
		}
	}
}
