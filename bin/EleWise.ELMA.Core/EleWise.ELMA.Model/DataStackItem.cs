using EleWise.ELMA.Core.Model;

namespace EleWise.ELMA.Model;

public sealed class DataStackItem
{
	private readonly IData _003CData_003Ek__BackingField;

	public IData Data => _003CData_003Ek__BackingField;

	public DataStackItem(IData data)
	{
		_003CData_003Ek__BackingField = data;
	}
}
