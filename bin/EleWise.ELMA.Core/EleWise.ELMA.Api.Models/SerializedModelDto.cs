using Bridge;

namespace EleWise.ELMA.Api.Models;

[ObjectLiteral]
public sealed class SerializedModelDto
{
	private string _003CName_003Ek__BackingField;

	private string _003CModel_003Ek__BackingField;

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

	public string Model
	{
		get
		{
			return _003CModel_003Ek__BackingField;
		}
		set
		{
			_003CModel_003Ek__BackingField = value;
		}
	}
}
