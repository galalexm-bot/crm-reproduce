using System;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.Documents.Web.History;

public abstract class RenderInDocumentHistoryBase : IRenderInDocumentHistory
{
	public abstract Guid ActionUid { get; }

	public virtual Guid PrepareActionUidForHistory => ActionUid;

	public virtual Guid? CustomHistoryChapter => null;

	public abstract bool CanRender(EntityActionEventArgs args);

	public abstract IHistoryBaseModel RenderAction(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader);

	public abstract HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event);

	protected virtual void ApplySettings(EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		foreach (IRenderSettingsDocumentHistory item in from p in ComponentManager.Current.GetExtensionPoints<IRenderSettingsDocumentHistory>()
			where p.CheckType(@event, historyLoader)
			select p)
		{
			item.Apply(@event, historyLoader);
		}
	}
}
