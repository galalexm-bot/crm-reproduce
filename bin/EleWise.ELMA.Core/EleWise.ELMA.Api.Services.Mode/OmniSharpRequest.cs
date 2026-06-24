using Bridge;
using EleWise.ELMA.Api.Attributes;

namespace EleWise.ELMA.Api.Services.Models;

[SimpleSerialize]
[ObjectLiteral]
public class OmniSharpRequest
{
	private string _003CCommand_003Ek__BackingField;

	private string _003CPostData_003Ek__BackingField;

	private string _003CFileName_003Ek__BackingField;

	public string Command
	{
		get
		{
			return _003CCommand_003Ek__BackingField;
		}
		set
		{
			_003CCommand_003Ek__BackingField = value;
		}
	}

	public string PostData
	{
		get
		{
			return _003CPostData_003Ek__BackingField;
		}
		set
		{
			_003CPostData_003Ek__BackingField = value;
		}
	}

	public string FileName
	{
		get
		{
			return _003CFileName_003Ek__BackingField;
		}
		set
		{
			_003CFileName_003Ek__BackingField = value;
		}
	}
}
