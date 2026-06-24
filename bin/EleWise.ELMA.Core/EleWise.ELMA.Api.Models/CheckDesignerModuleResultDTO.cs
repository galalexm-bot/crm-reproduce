namespace EleWise.ELMA.Api.Models;

public sealed class CheckDesignerModuleResultDTO
{
	private string _003CModuleName_003Ek__BackingField;

	private string _003CVersion_003Ek__BackingField;

	private string _003CCheckResult_003Ek__BackingField;

	public string ModuleName
	{
		get
		{
			return _003CModuleName_003Ek__BackingField;
		}
		set
		{
			_003CModuleName_003Ek__BackingField = value;
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

	public string CheckResult
	{
		get
		{
			return _003CCheckResult_003Ek__BackingField;
		}
		set
		{
			_003CCheckResult_003Ek__BackingField = value;
		}
	}
}
