using EleWise.ELMA.Core.Model;

namespace EleWise.ELMA.Model;

public class Data : IData
{
	private object _003CItem_003Ek__BackingField;

	public object Item
	{
		get
		{
			return _003CItem_003Ek__BackingField;
		}
		set
		{
			_003CItem_003Ek__BackingField = value;
		}
	}
}
public class Data<T> : Data, IData<T>, IData
{
	public new T Item
	{
		get
		{
			return (T)base.Item;
		}
		set
		{
			base.Item = value;
		}
	}
}
