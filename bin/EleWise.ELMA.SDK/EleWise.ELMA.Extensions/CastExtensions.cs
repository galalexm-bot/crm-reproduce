using EleWise.ELMA.DataClasses;

namespace EleWise.ELMA.Extensions;

public static class CastExtensions
{
	public static T As<T>(this object obj) where T : class
	{
		if (obj is DataClass dataClass)
		{
			return (T)dataClass.As(typeof(T));
		}
		return obj as T;
	}

	public static bool Is<T>(this object obj) where T : class
	{
		if (obj is DataClass dataClass)
		{
			return dataClass.Is(typeof(T));
		}
		return obj is T;
	}
}
