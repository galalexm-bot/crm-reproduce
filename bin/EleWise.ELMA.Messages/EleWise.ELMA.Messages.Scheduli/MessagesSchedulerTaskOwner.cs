using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling;

namespace EleWise.ELMA.Messages.Scheduling;

[Component]
public class MessagesSchedulerTaskOwner : ISchedulerTaskOwner
{
	public static readonly Guid UID = new Guid("{3581B6D6-B252-4D16-A23A-512F8EAFB6D8}");

	public Guid Uid => UID;

	public string Name => SR.T("Сообщения");
}
