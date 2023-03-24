using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_parameter.beforeadd
{
	internal class UsaCarFactory
	{
		private UsaCarFactory()
		{

		}

		public static Car BuildCar(CarType model)
		{
			Car car = model switch
			{
				CarType.MICRO => (Car)new MicroCar(Location.USA),
				CarType.MINI => (Car)new MiniCar(Location.USA),
				CarType.LUXURY => (Car)new LuxuryCar(Location.USA),
				_ => throw new Exception("Don't have this model"),
			};

			return car;
		}
	}
}
