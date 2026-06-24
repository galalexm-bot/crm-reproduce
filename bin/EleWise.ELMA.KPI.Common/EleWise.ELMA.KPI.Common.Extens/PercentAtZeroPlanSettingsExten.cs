namespace EleWise.ELMA.KPI.Common.Extensions;

public class PercentAtZeroPlanSettingsExtension
{
	private static PercentAtZeroPlanSettingsExtension instance { get; set; }

	public static PercentAtZeroPlanSettingsExtension Instance => instance ?? (instance = new PercentAtZeroPlanSettingsExtension());

	public double PercentAtZeroPlan { get; private set; }

	public PercentAtZeroPlanSettingsExtension()
	{
	}

	private PercentAtZeroPlanSettingsExtension(double percentAtZeroPlan)
	{
		PercentAtZeroPlan = percentAtZeroPlan;
	}

	public static void RecreateInstance(double percentAtZeroPlan)
	{
		instance = new PercentAtZeroPlanSettingsExtension(percentAtZeroPlan);
	}
}
