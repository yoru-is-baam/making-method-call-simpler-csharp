using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_parameter.beforeadd
{
	internal abstract class Car
	{
		private CarType model;
		private Location location;

		public Car(CarType model, Location location)
		{
			this.model = model;
			this.location = location;
		}

		public abstract void Construct();

		public CarType GetModel()
		{
			return model;
		}

		public void SetModel(CarType model)
		{
			this.model = model;
		}

		public Location GetLocation()
		{
			return location;
		}

		public void SetLocation(Location location)
		{
			this.location = location;
		}
	}
}
