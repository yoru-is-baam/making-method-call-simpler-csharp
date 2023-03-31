namespace remove_setting_method.beforeremove
{
	internal class Customer
	{
		private string name;
		private int age;

		public Customer(string name)
		{
			this.name = name;
		}

		public void SetAge(int age)
		{
			this.age = age;
		}
	}
}
