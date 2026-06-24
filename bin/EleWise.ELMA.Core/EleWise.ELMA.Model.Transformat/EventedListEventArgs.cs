using System;

namespace EleWise.ELMA.Model.Transformations;

public class EventedListEventArgs<T> : EventArgs
{
	private T _003CItem_003Ek__BackingField;

	public T Item
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
