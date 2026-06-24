using System;
using Bridge.QUnit;
using EleWise.ELMA.TestFramework.Core;

namespace EleWise.ELMA.TestFramework;

public sealed class Assert
{
	private static Func<Assert> assert => TestContext.Current.Assert;

	public static void Equal(object actual, object expected, string message = null)
	{
		assert.Invoke().StrictEqual(actual, expected, message);
	}

	public static void NotEqual(object actual, object expected, string message = null)
	{
		assert.Invoke().NotStrictEqual(actual, expected, message);
	}

	public static void DeepEqual(object actual, object expected, string message = null)
	{
		assert.Invoke().DeepEqual(actual, expected, message);
	}

	public static void NotDeepEqual(object actual, object expected, string message = null)
	{
		assert.Invoke().NotDeepEqual(actual, expected, message);
	}

	public static void True(object actual, string message = null)
	{
		Equal(actual, true, message);
	}

	public static void False(object actual, string message = null)
	{
		Equal(actual, false, message);
	}

	public static void Throws(Action action, string message = null)
	{
		assert.Invoke().Throws(action, message);
	}

	public static void Throws(Action action, object expected, string message = null)
	{
		assert.Invoke().Throws(action, expected, message);
	}

	public static void Throws(Action action, Func<object, bool> expected, string message = null)
	{
		assert.Invoke().Throws(action, expected, message);
	}

	public static void Null(object actual, string message = null)
	{
		assert.Invoke().Equal(actual, (object)null, message);
	}

	public static void NotNull(object actual, string message = null)
	{
		assert.Invoke().NotEqual(actual, (object)null, message);
	}
}
