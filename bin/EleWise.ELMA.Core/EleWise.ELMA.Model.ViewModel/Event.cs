using Bridge;

namespace EleWise.ELMA.Model.ViewModel;

[ObjectLiteral]
public class Event<T> : IEvent<T>, IEvent
{
	private T _003CValue_003Ek__BackingField;

	private long _003CCaretPosition_003Ek__BackingField;

	public T Value
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

	public long CaretPosition
	{
		get
		{
			return _003CCaretPosition_003Ek__BackingField;
		}
		set
		{
			_003CCaretPosition_003Ek__BackingField = value;
		}
	}
}
