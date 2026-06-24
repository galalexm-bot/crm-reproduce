using EleWise.ELMA.TestFramework.BDD;

namespace EleWise.ELMA.TestFramework.Notification;

internal sealed class StepInfo : IStepInfo
{
	private string _003CName_003Ek__BackingField;

	private int _003CNumber_003Ek__BackingField;

	private int _003CTotal_003Ek__BackingField;

	private StepType _003CType_003Ek__BackingField;

	public string Name
	{
		get
		{
			return _003CName_003Ek__BackingField;
		}
		set
		{
			_003CName_003Ek__BackingField = value;
		}
	}

	public int Number
	{
		get
		{
			return _003CNumber_003Ek__BackingField;
		}
		set
		{
			_003CNumber_003Ek__BackingField = value;
		}
	}

	public int Total
	{
		get
		{
			return _003CTotal_003Ek__BackingField;
		}
		set
		{
			_003CTotal_003Ek__BackingField = value;
		}
	}

	public StepType Type
	{
		get
		{
			return _003CType_003Ek__BackingField;
		}
		set
		{
			_003CType_003Ek__BackingField = value;
		}
	}
}
