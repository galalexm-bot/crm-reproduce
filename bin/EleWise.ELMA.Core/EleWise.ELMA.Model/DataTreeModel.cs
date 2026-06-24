namespace EleWise.ELMA.Model;

public class DataTreeModel : TreeModel
{
	private object _003CDataTag_003Ek__BackingField;

	public object DataTag
	{
		get
		{
			return _003CDataTag_003Ek__BackingField;
		}
		set
		{
			_003CDataTag_003Ek__BackingField = value;
		}
	}

	public DataTreeModel(string key, string value)
		: base(key, value)
	{
	}

	public DataTreeModel(string stringValue)
		: base(stringValue)
	{
	}

	public DataTreeModel(string key, string value, string parentKey)
		: base(key, value, parentKey)
	{
	}

	public DataTreeModel(string key, string value, string parentKey, object dataTag)
		: base(key, value, parentKey)
	{
		DataTag = dataTag;
	}
}
