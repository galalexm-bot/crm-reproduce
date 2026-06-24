namespace EleWise.ELMA.Runtime;

public enum StartStatus
{
	Running = 0,
	Started = 1,
	NotActivated = 2,
	NotStarted = 3,
	PrerequisitesCheckFault = 100,
	BackupNeeded = 101
}
