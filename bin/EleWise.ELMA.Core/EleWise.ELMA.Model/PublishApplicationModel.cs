using EleWise.ELMA.Api.Attributes;

namespace EleWise.ELMA.Model;

[SimpleSerialize]
public sealed class PublishApplicationModel : Reactive
{
	private string _003CId_003Ek__BackingField;

	private string _003CAuthor_003Ek__BackingField;

	private string _003CName_003Ek__BackingField;

	private string _003CDescription_003Ek__BackingField;

	private string _003CVersion_003Ek__BackingField;

	public string Id
	{
		get
		{
			return _003CId_003Ek__BackingField;
		}
		set
		{
			_003CId_003Ek__BackingField = value;
		}
	}

	public string Author
	{
		get
		{
			return _003CAuthor_003Ek__BackingField;
		}
		set
		{
			_003CAuthor_003Ek__BackingField = value;
		}
	}

	public string Name
	{
		get
		{
			return _003CName_003Ek__BackingField;
		}
		set
		{
			_003CName_003Ek__BackingField = value;
		}
	}

	public string Description
	{
		get
		{
			return _003CDescription_003Ek__BackingField;
		}
		set
		{
			_003CDescription_003Ek__BackingField = value;
		}
	}

	public string Version
	{
		get
		{
			return _003CVersion_003Ek__BackingField;
		}
		set
		{
			_003CVersion_003Ek__BackingField = value;
		}
	}

	public PublishApplicationModel()
	{
		Version = "1.0.0.0";
	}
}
