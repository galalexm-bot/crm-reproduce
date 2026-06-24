using Bridge;

namespace EleWise.ELMA.Model.ViewModel;

[ObjectLiteral]
public sealed class DragEventArgs<T>
{
	private T _003CElement_003Ek__BackingField;

	private T _003CSource_003Ek__BackingField;

	private DraggedObjectInfo _003CDraggedObjectInfo_003Ek__BackingField;

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

	[Name("objectInfo")]
	public DraggedObjectInfo DraggedObjectInfo
	{
		get
		{
			return _003CDraggedObjectInfo_003Ek__BackingField;
		}
		set
		{
			_003CDraggedObjectInfo_003Ek__BackingField = value;
		}
	}
}
