namespace add_parameter.beforeadd
{
	internal class CarFactory
	{
		private CarFactory()
		{
		}

		public static Car BuildCar(CarType type)
		{
			Location location = Location.USA;
			
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
