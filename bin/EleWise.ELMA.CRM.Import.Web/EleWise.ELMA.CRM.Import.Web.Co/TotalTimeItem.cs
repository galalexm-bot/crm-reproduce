namespace EleWise.ELMA.CRM.Import.Web.Code;

public class TotalTimeItem
{
	public TimerType Type { get; set; }

	public double Duration { get; set; }

	public TotalTimeItem(TimerType type, double duration)
	{
		Type = type;
		Duration = duration;
	}
}
