using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_parameter.beforeadd
{
	internal class IndiaCarFactory
	{
		private IndiaCarFactory()
		{

		}

		public static Car BuildCar(CarType model)
		{
			Car car = model switch
			{
				CarType.MICRO => (Car)new MicroCar(Location.INDIA),
				CarType.MINI => (Car)new MiniCar(Location.INDIA),
				CarType.LUXURY => (Car)new LuxuryCar(Location.INDIA),
				_ => throw new Exception("Don't have this model"),
			};

			return car;
		}
	}
}
