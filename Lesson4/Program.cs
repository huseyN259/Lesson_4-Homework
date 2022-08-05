using System;

struct Point
{
	public int X { get; set; }
	public int Y { get; set; }	

	public Point(int x, int y)
	{
		X = x;
		Y = y;
	}

	public override string ToString()
	{
		return $"X = {X}\nY = {Y}";
	}
}

class Counter
{
	private int Min;
	private int Max;
	private int Current;

	public Counter(int min, int max)
	{
		Min = min;
		Max = max;
		Current = min;
	}

	public void Increment()
	{
		if (Current < Max)
			Current++;
		else
			Current = Min;
	}

	public void Decrement()
	{
		if (Current > Min)
			Current--;
		else
			Current = Max;
	}

	public int getCurrent()
	{
		return Current;
	}
}

class Fraction
{
	private int _numerator { get; set; }
	private int _denominator { get; set; }

	public Fraction()
	{
		_numerator = 0;
		_denominator = 0;
	}

	public Fraction(int numerator, int denominator)
	{
		_numerator = numerator;
		_denominator = denominator;
	}

	public Fraction Sum(in Fraction other)
	{
		Fraction result = new Fraction(_numerator + other._numerator, _denominator + other._denominator);

		return result;
	}

	public Fraction Diff(in Fraction other)
	{
		Fraction result = new Fraction(_numerator - other._numerator, _denominator - other._denominator);

		return result;
	}

	public Fraction Mult(in Fraction other)
	{
		Fraction result = new Fraction(_numerator * other._numerator, _denominator * other._denominator);

		return result;
	}

	public Fraction Div(in Fraction other)
	{
		if (_denominator != 0)
		{
			Fraction result = new Fraction(_numerator / other._numerator, _denominator / other._denominator);

			return result;
		}

		return this;
	}

	public override string ToString()
	{
		return $"{_numerator} / {_denominator}";
	}
}

class Program
{
	static void Main()
	{
		#region Point

		Point point = new Point(5, 2);
		Console.WriteLine("Point");
		Console.WriteLine($"{point}");
		Console.WriteLine();

		#endregion



		#region Counter

		Counter counter = new Counter(9, 25);
		Console.WriteLine("Counter");

		//counter.Increment();
		//counter.Increment();
		//Console.WriteLine(counter.getCurrent());

		counter.Decrement();
		counter.Decrement();
		counter.Decrement();
		Console.WriteLine(counter.getCurrent());
		Console.WriteLine();

		#endregion



		#region Fraction

		Fraction fraction = new Fraction(1, 13);
		Fraction fraction1 = new Fraction(20, 0);
		Console.WriteLine("Fraction");

		Console.WriteLine(fraction.Sum(fraction1).ToString());
		Console.WriteLine(fraction.Diff(fraction1).ToString());
		Console.WriteLine(fraction.Mult(fraction1).ToString());
		Console.WriteLine(fraction.Div(fraction1).ToString());

		#endregion
	}
}
