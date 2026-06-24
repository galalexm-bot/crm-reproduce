using Bridge;

namespace EleWise.ELMA.Model.Types.Models;

[ObjectLiteral]
public sealed class SetterInfo : TargetInfo
{
	private object _003CValue_003Ek__BackingField;

	public object Value
	{
		get
		{
			return _003CValue_003Ek__BackingField;
		}
		set
		{
			_003CValue_003Ek__BackingField = value;
		}
	}
}
