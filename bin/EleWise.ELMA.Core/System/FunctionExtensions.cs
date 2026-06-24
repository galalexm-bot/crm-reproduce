using EleWise.ELMA.Extensions;

namespace System;

public static class FunctionExtensions
{
	private const string IsEmptyAction = "IsEmptyAction";

	public static bool IsEmpty<TResult>(this Func<TResult> function)
	{
		if (function == null)
		{
			return true;
		}
		object plainPropertyValue;
		if ((plainPropertyValue = function.GetPlainPropertyValue("IsEmptyAction")) is bool)
		{
			return (bool)plainPropertyValue;
		}
		return false;
	}

	public static bool IsEmpty<TParam, TResult>(this Func<TParam, TResult> function)
	{
		if (function == null)
		{
			return true;
		}
		object plainPropertyValue;
		if ((plainPropertyValue = function.GetPlainPropertyValue("IsEmptyAction")) is bool)
		{
			return (bool)plainPropertyValue;
		}
		return false;
	}
}
