namespace renamemethod.beforerename
{
	public class Customer
	{
		private string _firstName;
		private string _lastName;
		private int _age;

		public Customer(string firstName, string lastName, int age)
		{
			_firstName = firstName;
			_lastName = lastName;
			_age = age;
		}

		public string GetFn() { return _firstName; }
		public string GetLn() { return _lastName; }
		public int GetA() { return _age; }
	}
}
