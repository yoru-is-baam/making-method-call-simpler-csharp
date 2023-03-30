namespace replace_parameter_with_explicit_methods.beforereplace
{
	internal class Rectangle
	{
		private int _width;
		private int _height;

		public Rectangle(int width, int height)
		{
			_width = width;
			_height = height;
		}

		public void SetValue(String attr, int value)
		{
			if (attr.Equals("height"))
			{
				_height = value;
				return;
			}

			if (attr.Equals("width"))
			{
				_width = value;
			}
		}
	}
}
