
interface IAddition
{
	double Add(double a, double b);
}

interface ISubtraction
{
	double Subtract(double a, double b);
}

interface IMultiplication
{
	double Multiply(double a, double b);
}

interface IDivision
{
	double Divide(double a, double b);
}

internal class Inheritance: IAddition, ISubtraction, IMultiplication, IDivision
{ 
	public double Add(double a, double b)
	{
		return a + b;
	}

	public double Subtract(double a, double b)
	{
		return a - b;
	}

	public double Multiply(double a, double b)
	{
		return a * b;
	}

	public double Divide(double a, double b)
	{
		if (b == 0)
		{
			throw new DivideByZeroException("Cannot divide by zero.");
		}

		return a / b;
	}
}

