namespace System.Reflection.Extensions;

public static class RipeTypeExtension
{
	public static RipeType ToRipeType(this Type type)
	{
		return new RipeType(type);
	}
}
