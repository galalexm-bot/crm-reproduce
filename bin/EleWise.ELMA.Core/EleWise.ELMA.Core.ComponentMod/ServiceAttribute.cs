using System;

namespace EleWise.ELMA.Core.ComponentModel;

[AttributeUsage(/*Could not decode attribute arguments.*/)]
public class ServiceAttribute : System.Attribute
{
	private bool _003CCreateInstancePerResolve_003Ek__BackingField;

	public bool CreateInstancePerResolve
	{
		get
		{
			return _003CCreateInstancePerResolve_003Ek__BackingField;
		}
		set
		{
			_003CCreateInstancePerResolve_003Ek__BackingField = value;
		}
	}
}
