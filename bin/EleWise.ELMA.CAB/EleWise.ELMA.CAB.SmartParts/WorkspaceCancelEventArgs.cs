namespace EleWise.ELMA.CAB.SmartParts;

public class WorkspaceCancelEventArgs : WorkspaceEventArgs
{
	public bool Cancel { get; set; }

	public WorkspaceCancelEventArgs(object smartPart)
		: base(smartPart)
	{
	}
}
