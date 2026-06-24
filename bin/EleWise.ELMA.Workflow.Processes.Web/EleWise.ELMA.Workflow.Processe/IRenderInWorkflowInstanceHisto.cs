using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.Workflow.Processes.Web.History;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IRenderInWorkflowInstanceHistory
{
	Guid ActionUid { get; }

	IHistoryBaseModel RenderAction(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader);

	HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event);
}
