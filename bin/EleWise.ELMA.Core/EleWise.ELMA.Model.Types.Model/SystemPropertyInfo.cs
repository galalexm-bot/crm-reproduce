using Bridge;

namespace EleWise.ELMA.Model.Types.Models;

[ObjectLiteral]
public sealed class SystemPropertyInfo
{
	private bool _003CIsCollection_003Ek__BackingField;

	private object _003CServiceInfo_003Ek__BackingField;

	public bool IsCollection
	{
		get
		{
			return _003CIsCollection_003Ek__BackingField;
		}
		set
		{
			_003CIsCollection_003Ek__BackingField = value;
		}
	}

	public object ServiceInfo
	{
		get
		{
			return _003CServiceInfo_003Ek__BackingField;
		}
		set
		{
			_003CServiceInfo_003Ek__BackingField = value;
		}
	}
}
