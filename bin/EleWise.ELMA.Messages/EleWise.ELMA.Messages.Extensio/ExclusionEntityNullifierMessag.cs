using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Nullifier;

namespace EleWise.ELMA.Messages.ExtensionPoints;

[Component]
internal class ExclusionEntityNullifierMessages : IExclusionEntityNullifier
{
	public List<Guid> SetExclusion()
	{
		return new List<Guid>
		{
			InterfaceActivator.UID<IBaseMessage>(),
			InterfaceActivator.UID<IMessageQueueChannelItem>(),
			InterfaceActivator.UID<IDiscussionObject>(),
			InterfaceActivator.UID<IMessageException>(),
			InterfaceActivator.UID<IInternalMailMessage>(),
			InterfaceActivator.UID<IMessageQueueItem>(),
			InterfaceActivator.UID<IInformationChannel>(),
			InterfaceActivator.UID<IMessageNotAssignedUser>()
		};
	}
}
