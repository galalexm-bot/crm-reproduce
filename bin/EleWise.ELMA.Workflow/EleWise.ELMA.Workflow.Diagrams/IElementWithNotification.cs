using System.Collections.Generic;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Workflow.Diagrams.Elements;

public interface IElementWithNotification
{
	List<Recipient> Recipients { get; }

	bool NoCheckOrganizationItem { get; }
}
