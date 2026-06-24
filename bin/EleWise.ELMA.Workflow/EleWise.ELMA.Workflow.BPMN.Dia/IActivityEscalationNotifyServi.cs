using System.Collections.Generic;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints;

public interface IActivityEscalationNotifyService
{
	IEnumerable<IUser> GetRecipientsForNotification(GetRecipientsParameters getRecipientsParameters);
}
