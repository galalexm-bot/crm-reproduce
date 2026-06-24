using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.Documents.Web.History;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IRenderInDocumentHistory
{
	Guid ActionUid { get; }

	Guid PrepareActionUidForHistory { get; }

	Guid? CustomHistoryChapter { get; }

	bool CanRender(EntityActionEventArgs args);

	IHistoryBaseModel RenderAction(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader);

	HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event);
}
