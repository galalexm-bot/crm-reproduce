using EleWise.ELMA.Model;

namespace EleWise.ELMA.Core.React.Services;

public sealed class SerializedModelParam
{
	public const string AllMethodName = "$AllMethodName";

	private string _003CMethodName_003Ek__BackingField;

	private AdditionalModel _003CModel_003Ek__BackingField;

	public string MethodName
	{
		get
		{
			return _003CMethodName_003Ek__BackingField;
		}
		set
		{
			_003CMethodName_003Ek__BackingField = value;
		}
	}

	public AdditionalModel Model
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

	public SerializedModelParam(string methodName, AdditionalModel model)
	{
		MethodName = methodName;
		Model = model;
	}
}
