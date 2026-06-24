using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IWorkflowActivityGetNotificationRecipients
{
	Type ActivityType { get; }

	IEnumerable<IUser> GetRecipients([NotNull] GetRecipientsParameters parameters);
}
