using System.Collections.Generic;
using Bridge;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Dispatcher;

[ObjectLiteral]
public sealed class SaveEntitiesModel
{
	private System.Collections.Generic.ICollection<ComputedValue> _003CDynamicProperties_003Ek__BackingField;

	public System.Collections.Generic.ICollection<ComputedValue> DynamicProperties
	{
		get
		{
			return _003CDynamicProperties_003Ek__BackingField;
		}
		set
		{
			_003CDynamicProperties_003Ek__BackingField = value;
		}
	}
}
