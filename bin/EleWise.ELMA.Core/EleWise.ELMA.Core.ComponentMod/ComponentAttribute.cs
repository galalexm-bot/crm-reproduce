using System;

namespace EleWise.ELMA.Core.ComponentModel;

[AttributeUsage(/*Could not decode attribute arguments.*/)]
public class ComponentAttribute : System.Attribute
{
	private int _003COrder_003Ek__BackingField;

	private bool _003CCreateInstancePerResolve_003Ek__BackingField;

	public int Order
	{
		get
		{
			return _003COrder_003Ek__BackingField;
		}
		set
		{
			_003COrder_003Ek__BackingField = value;
		}
	}

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
