namespace Nemerle.Core;

public static class ValueOptionStatic
{
	public static ValueOption<T> VSome<T>(T value)
	{
		return new ValueOption<T>(value);
	}

	public static ValueOption<T> VNone<T>()
	{
		return default(ValueOption<T>);
	}
}
