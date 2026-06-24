using System;

namespace EleWise.ELMA.CAB.SmartParts;

public class WorkspaceEventArgs : EventArgs
{
	private readonly object smartPart;

	public object SmartPart => smartPart;

	public WorkspaceEventArgs(object smartPart)
	{
		this.smartPart = smartPart;
	}
}
