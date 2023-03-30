namespace replace_parameter_with_explicit_methods.afterreplace
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

		public void SetWidth(int width)
		{
			_width = width;
		}

		public void SetHeight(int height)
		{
			_height = height;
		}
	}
}
