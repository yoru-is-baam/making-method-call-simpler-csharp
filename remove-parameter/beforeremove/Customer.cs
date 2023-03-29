namespace remove_parameter.beforeremove
{
	internal class Customer
	{
		private string _firstName;
		private string _lastName;

		public Customer(string firstName, string lastName)
		{
			_firstName = firstName;
			_lastName = lastName;
		}

		public string GetFirstName(int age) { return _firstName; }
		public string GetLastName() { return _lastName; }
	}
}
