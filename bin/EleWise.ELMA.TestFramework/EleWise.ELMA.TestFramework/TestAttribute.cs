using System;

namespace EleWise.ELMA.TestFramework;

[AttributeUsage(/*Could not decode attribute arguments.*/)]
public sealed class TestAttribute : System.Attribute
{
	private int? expectedCount;

	private string _003CName_003Ek__BackingField;

	public string Name
	{
		get
		{
			return _003CName_003Ek__BackingField;
		}
		set
		{
			_003CName_003Ek__BackingField = value;
		}
	}

	public int ExpectedCount
	{
		get
		{
			return expectedCount.GetValueOrDefault();
		}
		set
		{
			expectedCount = value;
		}
	}

	internal bool IsExpectedCountSet => expectedCount.get_HasValue();
}
