using Bridge;

namespace EleWise.ELMA.Model.ViewModel;

[ObjectLiteral]
public sealed class DropEventArgs<T>
{
	private T _003CElement_003Ek__BackingField;

	private T _003CSource_003Ek__BackingField;

	private T _003CTarget_003Ek__BackingField;

	private int _003CDropzoneIndex_003Ek__BackingField;

	private DroppedObjectInfo _003CDroppedObjectInfo_003Ek__BackingField;

	[Name("element")]
	public T Element
	{
		get
		{
			return _003CElement_003Ek__BackingField;
		}
		set
		{
			_003CElement_003Ek__BackingField = value;
		}
	}

	[Name("source")]
	public T Source
	{
		get
		{
			return _003CSource_003Ek__BackingField;
		}
		set
		{
			_003CSource_003Ek__BackingField = value;
		}
	}

	[Name("target")]
	public T Target
	{
		get
		{
			return _003CTarget_003Ek__BackingField;
		}
		set
		{
			_003CTarget_003Ek__BackingField = value;
		}
	}

	[Name("dropzoneIndex")]
	public int DropzoneIndex
	{
		get
		{
			return _003CDropzoneIndex_003Ek__BackingField;
		}
		set
		{
			_003CDropzoneIndex_003Ek__BackingField = value;
		}
	}

	[Name("objectInfo")]
	public DroppedObjectInfo DroppedObjectInfo
	{
		get
		{
			return _003CDroppedObjectInfo_003Ek__BackingField;
		}
		set
		{
			_003CDroppedObjectInfo_003Ek__BackingField = value;
		}
	}
}
