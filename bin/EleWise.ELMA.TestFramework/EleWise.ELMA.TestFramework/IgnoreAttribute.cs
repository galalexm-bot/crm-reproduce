using System;

namespace EleWise.ELMA.TestFramework;

[AttributeUsage(/*Could not decode attribute arguments.*/)]
public class IgnoreAttribute : System.Attribute
{
	private string _003CReason_003Ek__BackingField;

	public string Reason
	{
		get
		{
			return _003CReason_003Ek__BackingField;
		}
		private set
		{
			_003CReason_003Ek__BackingField = value;
		}
	}

	public IgnoreAttribute(string reason)
	{
		Reason = reason;
	}
}
