using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_parameter.afteradd
{
	internal class MiniCar : Car
	{
		public MiniCar(Location location) : base(CarType.MINI, location)
		{
			Construct();
		}

		public override void Construct()
		{
			Console.WriteLine("Connecting to mini car");
		}
	}
}
