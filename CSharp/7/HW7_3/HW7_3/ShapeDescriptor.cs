using System;

namespace HW7_3
{
	class ShapeDescriptor
	{
		public ShapeDescriptor()
		{			
			ShapeType();
			UnTruePoint();
		}
		public ShapeDescriptor(int x)
		{
			Point._x = -1;
			Point.point = true;
			ShapeType();
			UnTruePoint();
		}
		public ShapeDescriptor(int x, int y)
		{
			Point._x = x;
			Point._y = y;
			Point.line = true;
			ShapeType();
			UnTruePoint();
		}
		public ShapeDescriptor(int x, int y, int z)
		{
			Point._x = x;
			Point._y = y;
			Point._z = z;
			Point.triangle = true;
			ShapeType();
			UnTruePoint();
		}
		public ShapeDescriptor(int x, int y, int z, int c)
		{
			Point._x = x;
			Point._y = y;
			Point._z = z;
			Point._c = c;
			Point.quadrangle = true;
			ShapeType();
			UnTruePoint();
		}
		public void UnTruePoint()
		{
			Point.point = false;
			Point.line = false;
			Point.triangle = false;
			Point.quadrangle = false;
		}
		public void ShapeType()
		{
			if (Point.point)
			{
				Console.WriteLine("This is Point");
			}
			else if (Point.line)
			{
				Console.WriteLine("This is LINE");
			}
			else if (Point.triangle)
			{
				Console.WriteLine("This is Triangle");
			}
			else if (Point.quadrangle)
			{
				Console.WriteLine("This is Quadrangle");
			}
			else
			{
				throw new Exception("This figure can not be determined!");
			}
		}
	}
	static class Point
	{
		//типу _x(x,y) _y(x,y) мій велосипед(просто щоб не було як у всіх, а щось інше)
		public static int _x;
		public static int _y;
		public static int _z;
		public static int _c;		
		public static bool point;
		public static bool line;
		public static bool triangle;
		public static bool quadrangle;		
	}
}
