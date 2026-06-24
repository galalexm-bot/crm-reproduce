using System.Collections.Generic;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Dependencies;

namespace EleWise.ELMA.Scripts;

public sealed class LoadComponentScriptsResult
{
	private System.Collections.Generic.IEnumerable<EntityDependency> _003CEntityDependencies_003Ek__BackingField;

	public System.Collections.Generic.IEnumerable<EntityDependency> EntityDependencies
	{
		get
		{
			return _003CEntityDependencies_003Ek__BackingField;
		}
		set
		{
			_003CEntityDependencies_003Ek__BackingField = value;
		}
	}
}
