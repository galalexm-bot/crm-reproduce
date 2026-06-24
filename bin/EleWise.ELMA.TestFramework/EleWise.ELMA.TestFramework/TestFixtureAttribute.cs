using System;

namespace EleWise.ELMA.TestFramework;

[AttributeUsage(/*Could not decode attribute arguments.*/)]
public sealed class TestFixtureAttribute : System.Attribute
{
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
}
