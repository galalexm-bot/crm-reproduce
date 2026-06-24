using System;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB.SmartParts;

public class SmartPartPlaceHolderEventArgs : EventArgs
{
	private readonly object smartPart;

	public object SmartPart => smartPart;

	public SmartPartPlaceHolderEventArgs(object smartPart)
	{
		Guard.ArgumentNotNull(smartPart, "smartPart");
		this.smartPart = smartPart;
	}
}
