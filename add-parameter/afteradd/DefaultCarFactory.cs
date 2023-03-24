using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_parameter.afteradd
{
	internal class DefaultCarFactory
	{
		private DefaultCarFactory()
		{

		}

		public static Car BuildCar(CarType model)
		{
			Car car = model switch
			{
				CarType.MICRO => (Car)new MicroCar(Location.DEFAULT),
				CarType.MINI => (Car)new MiniCar(Location.DEFAULT),
				CarType.LUXURY => (Car)new LuxuryCar(Location.DEFAULT),
				_ => throw new Exception("Don't have this model"),
			};

			return car;
		}
	}
}
