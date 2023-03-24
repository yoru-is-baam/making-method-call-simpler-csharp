namespace renamemethod.afterrename
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

		public string GetFirstName() { return _firstName; }
		public string GetLastName() { return _lastName; }
		public int GetAge() { return _age; }
	}
}
