namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public sealed class CalendarConfigModel
{
	private ConfigDataModel[] days;

	public ProductionScheduleSimpleConfigModel Config { get; set; }

	public ConfigDataModel BaseConfig { get; set; }

	public ConfigDataModel WeekDayCollection { get; set; }

	public ConfigDataModel[] Days => days ?? (days = new ConfigDataModel[7]);

	public ConfigDataModel Sunday
	{
		get
		{
			return Days[0];
		}
		set
		{
			Days[0] = value;
		}
	}

	public ConfigDataModel Monday
	{
		get
		{
			return Days[1];
		}
		set
		{
			Days[1] = value;
		}
	}

	public ConfigDataModel Tuesday
	{
		get
		{
			return Days[2];
		}
		set
		{
			Days[2] = value;
		}
	}

	public ConfigDataModel Wednesday
	{
		get
		{
			return Days[3];
		}
		set
		{
			Days[3] = value;
		}
	}

	public ConfigDataModel Thursday
	{
		get
		{
			return Days[4];
		}
		set
		{
			Days[4] = value;
		}
	}

	public ConfigDataModel Friday
	{
		get
		{
			return Days[5];
		}
		set
		{
			Days[5] = value;
		}
	}

	public ConfigDataModel Saturday
	{
		get
		{
			return Days[6];
		}
		set
		{
			Days[6] = value;
		}
	}
}
