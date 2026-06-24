using EleWise.ELMA.Model.Signatures;

namespace EleWise.ELMA.Model.Views;

public sealed class ActionInputComputedValue : InputComputedValue
{
	private TypeSignature _003CReturnType_003Ek__BackingField;

	private TypeSignature _003CParameterType_003Ek__BackingField;

	public TypeSignature ReturnType
	{
		get
		{
			return _003CReturnType_003Ek__BackingField;
		}
		set
		{
			_003CReturnType_003Ek__BackingField = value;
		}
	}

	public TypeSignature ParameterType
	{
		get
		{
			return _003CParameterType_003Ek__BackingField;
		}
		set
		{
			_003CParameterType_003Ek__BackingField = value;
		}
	}

	public ActionInputComputedValue()
	{
		ReturnType = new TypeSignature();
		ParameterType = new TypeSignature();
	}
}
