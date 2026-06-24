namespace EleWise.ELMA.Api.Models;

public sealed class ExportExcelResultDto
{
	private string _003CFileHref_003Ek__BackingField;

	private bool _003CReady_003Ek__BackingField;

	private string _003CError_003Ek__BackingField;

	public string FileHref
	{
		get
		{
			return _003CFileHref_003Ek__BackingField;
		}
		set
		{
			_003CFileHref_003Ek__BackingField = value;
		}
	}

	public bool Ready
	{
		get
		{
			return _003CReady_003Ek__BackingField;
		}
		set
		{
			_003CReady_003Ek__BackingField = value;
		}
	}

	public string Error
	{
		get
		{
			return _003CError_003Ek__BackingField;
		}
		set
		{
			_003CError_003Ek__BackingField = value;
		}
	}
}
