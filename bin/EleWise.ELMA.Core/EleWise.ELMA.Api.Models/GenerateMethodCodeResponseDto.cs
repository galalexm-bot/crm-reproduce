namespace EleWise.ELMA.Api.Models;

public sealed class GenerateMethodCodeResponseDto
{
	private string _003CMethodSourceCode_003Ek__BackingField;

	private int _003CInsertPosition_003Ek__BackingField;

	public string MethodSourceCode
	{
		get
		{
			return _003CMethodSourceCode_003Ek__BackingField;
		}
		set
		{
			_003CMethodSourceCode_003Ek__BackingField = value;
		}
	}

	public int InsertPosition
	{
		get
		{
			return _003CInsertPosition_003Ek__BackingField;
		}
		set
		{
			_003CInsertPosition_003Ek__BackingField = value;
		}
	}
}
