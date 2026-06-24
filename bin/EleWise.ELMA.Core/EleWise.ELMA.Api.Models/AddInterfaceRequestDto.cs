namespace EleWise.ELMA.Api.Models;

public sealed class AddInterfaceRequestDto
{
	private string _003CSourceCode_003Ek__BackingField;

	private string _003CClassName_003Ek__BackingField;

	private string _003CInterfaceName_003Ek__BackingField;

	public string SourceCode
	{
		get
		{
			return _003CSourceCode_003Ek__BackingField;
		}
		set
		{
			_003CSourceCode_003Ek__BackingField = value;
		}
	}

	public string ClassName
	{
		get
		{
			return _003CClassName_003Ek__BackingField;
		}
		set
		{
			_003CClassName_003Ek__BackingField = value;
		}
	}

	public string InterfaceName
	{
		get
		{
			return _003CInterfaceName_003Ek__BackingField;
		}
		set
		{
			_003CInterfaceName_003Ek__BackingField = value;
		}
	}
}
