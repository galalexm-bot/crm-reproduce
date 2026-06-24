namespace EleWise.ELMA.UIBuilder.Model;

public class InstallationState
{
	public bool TestRunning { get; private set; }

	public bool InstallationRunning { get; private set; }

	public int Progress { get; private set; }

	internal static InstallationState NotStarted()
	{
		return new InstallationState
		{
			Progress = 0,
			InstallationRunning = false
		};
	}

	internal static InstallationState Running(int progress)
	{
		return new InstallationState
		{
			Progress = progress,
			InstallationRunning = true
		};
	}

	internal static InstallationState Testing(int progress)
	{
		return new InstallationState
		{
			Progress = progress,
			TestRunning = true
		};
	}
}
