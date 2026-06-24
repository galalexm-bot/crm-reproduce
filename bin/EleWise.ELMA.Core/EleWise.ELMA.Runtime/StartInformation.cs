using EleWise.ELMA.Model;

namespace EleWise.ELMA.Runtime;

public class StartInformation : Reactive
{
	private StartStatus _003CStatus_003Ek__BackingField;

	private double _003CPercent_003Ek__BackingField;

	private bool _003CHasErrors_003Ek__BackingField;

	public StartStatus Status
	{
		get
		{
			return _003CStatus_003Ek__BackingField;
		}
		set
		{
			_003CStatus_003Ek__BackingField = value;
		}
	}

	public double Percent
	{
		get
		{
			return _003CPercent_003Ek__BackingField;
		}
		set
		{
			_003CPercent_003Ek__BackingField = value;
		}
	}

	public bool HasErrors
	{
		get
		{
			return _003CHasErrors_003Ek__BackingField;
		}
		set
		{
			_003CHasErrors_003Ek__BackingField = value;
		}
	}
}
