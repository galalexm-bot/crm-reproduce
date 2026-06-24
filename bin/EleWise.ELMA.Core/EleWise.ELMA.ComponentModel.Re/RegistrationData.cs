using Bridge;

namespace EleWise.ELMA.ComponentModel.Registration;

[ObjectLiteral]
internal sealed class RegistrationData
{
	private string _003CTypeName_003Ek__BackingField;

	private RegistrationType _003CRegistrationType_003Ek__BackingField;

	private int _003COrder_003Ek__BackingField;

	private RegistrationData[] _003CRegisterAs_003Ek__BackingField;

	private Constructor _003CConstructor_003Ek__BackingField;

	public string TypeName
	{
		get
		{
			return _003CTypeName_003Ek__BackingField;
		}
		set
		{
			_003CTypeName_003Ek__BackingField = value;
		}
	}

	public RegistrationType RegistrationType
	{
		get
		{
			return _003CRegistrationType_003Ek__BackingField;
		}
		set
		{
			_003CRegistrationType_003Ek__BackingField = value;
		}
	}

	public int Order
	{
		get
		{
			return _003COrder_003Ek__BackingField;
		}
		set
		{
			_003COrder_003Ek__BackingField = value;
		}
	}

	public RegistrationData[] RegisterAs
	{
		get
		{
			return _003CRegisterAs_003Ek__BackingField;
		}
		set
		{
			_003CRegisterAs_003Ek__BackingField = value;
		}
	}

	public Constructor Constructor
	{
		get
		{
			return _003CConstructor_003Ek__BackingField;
		}
		set
		{
			_003CConstructor_003Ek__BackingField = value;
		}
	}
}
