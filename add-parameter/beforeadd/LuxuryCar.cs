using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_parameter.beforeadd
{
	internal class LuxuryCar : Car
	{
		public LuxuryCar(Location location) : base(CarType.LUXURY, location)
		{
			Construct();
		}

		public override void Construct()
		{
			Console.WriteLine("Connecting to luxury car");
		}
	}
}
