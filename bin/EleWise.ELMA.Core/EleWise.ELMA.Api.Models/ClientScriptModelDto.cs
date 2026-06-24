using Bridge;

namespace EleWise.ELMA.Api.Models;

[ObjectLiteral]
public class ClientScriptModelDto
{
	private string _003CAssemblyName_003Ek__BackingField;

	private string _003CSourceCode_003Ek__BackingField;

	public string AssemblyName
	{
		get
		{
			return _003CAssemblyName_003Ek__BackingField;
		}
		set
		{
			_003CAssemblyName_003Ek__BackingField = value;
		}
	}

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
}
