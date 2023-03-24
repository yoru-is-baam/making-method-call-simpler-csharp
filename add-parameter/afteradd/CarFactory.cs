namespace add_parameter.afteradd
{
	internal class CarFactory
	{
		private CarFactory()
		{
		}

		public static Car BuildCar(CarType type, Location location)
		{
			Car car = location switch
			{
				Location.USA => (Car)UsaCarFactory.BuildCar(type),
				Location.INDIA => (Car)IndiaCarFactory.BuildCar(type),
				_ => (Car)DefaultCarFactory.BuildCar(type),
			};

			return car;
		}
	}
}
