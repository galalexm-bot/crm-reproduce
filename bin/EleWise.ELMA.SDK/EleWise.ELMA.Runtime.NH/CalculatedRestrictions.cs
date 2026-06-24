using NHibernate.Criterion;

namespace EleWise.ELMA.Runtime.NH;

public static class CalculatedRestrictions
{
	internal static CalculatedRestrictions I3cFxNWthbDpL3Kn2sJF;

	public static IProjection Addition(string firstPropertyName, string secondPropertyName)
	{
		return (IProjection)(object)new CalculatedProjection(CalculatedProjection.CalculationType.Addition, firstPropertyName, secondPropertyName);
	}

	public static IProjection Addition(IProjection firstProjection, IProjection secondProjection)
	{
		return (IProjection)(object)new CalculatedProjection(CalculatedProjection.CalculationType.Addition, firstProjection, secondProjection);
	}

	public static IProjection Subtraction(string firstPropertyName, string secondPropertyName)
	{
		return (IProjection)(object)new CalculatedProjection(CalculatedProjection.CalculationType.Subtraction, firstPropertyName, secondPropertyName);
	}

	public static IProjection Subtraction(IProjection firstProjection, IProjection secondProjection)
	{
		return (IProjection)(object)new CalculatedProjection(CalculatedProjection.CalculationType.Subtraction, firstProjection, secondProjection);
	}

	public static IProjection Multiplication(string firstPropertyName, string secondPropertyName)
	{
		return (IProjection)(object)new CalculatedProjection(CalculatedProjection.CalculationType.Multiplication, firstPropertyName, secondPropertyName);
	}

	public static IProjection Multiplication(IProjection firstProjection, IProjection secondProjection)
	{
		return (IProjection)(object)new CalculatedProjection(CalculatedProjection.CalculationType.Multiplication, firstProjection, secondProjection);
	}

	public static IProjection Division(string firstPropertyName, string secondPropertyName)
	{
		return (IProjection)(object)new CalculatedProjection(CalculatedProjection.CalculationType.Division, firstPropertyName, secondPropertyName);
	}

	public static IProjection Division(IProjection firstProjection, IProjection secondProjection)
	{
		return (IProjection)(object)new CalculatedProjection(CalculatedProjection.CalculationType.Division, firstProjection, secondProjection);
	}

	public static IProjection Minus(string propertyName)
	{
		return (IProjection)(object)new CalculatedProjection(CalculatedProjection.CalculationType.Minus, propertyName, null);
	}

	public static IProjection Minus(IProjection projection)
	{
		return (IProjection)(object)new CalculatedProjection(CalculatedProjection.CalculationType.Minus, projection, null);
	}

	internal static bool JGNA7eWtGK8N95jubf1V()
	{
		return I3cFxNWthbDpL3Kn2sJF == null;
	}

	internal static CalculatedRestrictions LdLHcSWtERC4o9fJFWIE()
	{
		return I3cFxNWthbDpL3Kn2sJF;
	}
}
