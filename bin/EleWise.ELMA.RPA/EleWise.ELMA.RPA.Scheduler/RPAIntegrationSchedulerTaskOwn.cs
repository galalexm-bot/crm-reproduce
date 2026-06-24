using System;
using EleWise.ELMA.Scheduling;

namespace EleWise.ELMA.RPA.Scheduler;

internal sealed class RPAIntegrationSchedulerTaskOwner : ISchedulerTaskOwner
{
	public static readonly Guid UID = new Guid("{2AA6F807-CC09-4B90-8E94-D5DD7E8E1F14}");

	public Guid Uid => UID;

	public string Name => SR.T("RPA-интеграция");
}
