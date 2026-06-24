using EleWise.ELMA.Api.Attributes;

namespace EleWise.ELMA.OmniSharp.Model;

[SimpleSerialize]
public sealed class WebReferenceInfo
{
	private string _003CWebReferenceName_003Ek__BackingField;

	private string _003CCodeFilePath_003Ek__BackingField;

	public string WebReferenceName
	{
		get
		{
			return _003CWebReferenceName_003Ek__BackingField;
		}
		set
		{
			_003CWebReferenceName_003Ek__BackingField = value;
		}
	}

	public string CodeFilePath
	{
		get
		{
			return _003CCodeFilePath_003Ek__BackingField;
		}
		set
		{
			_003CCodeFilePath_003Ek__BackingField = value;
		}
	}
}
