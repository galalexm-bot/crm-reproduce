using System;

namespace EleWise.ELMA.Ioc.Models;

internal sealed class Registration : IRegistration
{
	private readonly object _003CInstance_003Ek__BackingField;

	private readonly System.Type _003CType_003Ek__BackingField;

	public object Instance => _003CInstance_003Ek__BackingField;

	public System.Type Type => _003CType_003Ek__BackingField;

	public Registration(object instance, System.Type type)
	{
		_003CInstance_003Ek__BackingField = instance;
		_003CType_003Ek__BackingField = type;
	}
}
