using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_parameter.beforeadd
{
	internal class MicroCar : Car
	{
		public MicroCar(Location location) : base(CarType.MICRO, location)
		{
			Construct();
		}

		public override void Construct()
		{
			Console.WriteLine("Connecting to micro car");
		}
	}
}
