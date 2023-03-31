namespace replace_constructor_with_factory_method.afterreplace
{
	internal class Employee
	{
		private int type;

		private Employee(int type)
		{
			this.type = type;
		}

		public static Employee Create(int type)
		{
			Employee employee = new Employee(type);
			// do some heavy lifting.
			return employee;
		}
	}
}
