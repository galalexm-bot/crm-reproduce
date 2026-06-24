using System;

namespace EleWise.ELMA.Api.Models;

internal sealed class InitDataModel
{
	private Guid[] _003CModules_003Ek__BackingField;

	public Guid[] Modules
	{
		get
		{
			return _003CModules_003Ek__BackingField;
		}
		set
		{
			_003CModules_003Ek__BackingField = value;
		}
	}

	public InitDataModel()
	{
		Modules = (Guid[])(object)new Guid[0];
	}
}
