﻿namespace replace_parameter_with_method_call.beforereplace
{
	internal class Address
	{
		private int zipCode;
		private int areaCode;

		public Address(int zipCode, int areaCode)
		{
			this.zipCode = zipCode;
			this.areaCode = areaCode;
		}

		public int ZipCode
		{
			get { return zipCode; }
		}

		public int AreaCode
		{
			get { return areaCode; }
		}
	}
}
