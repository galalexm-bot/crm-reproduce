using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.History.Models;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class EntityHistoryViewModel
{
	public IList<EntityActionEventArgs> EventArray { get; set; }

	public IList<IAuditEventRender> Renders { get; set; }

	public IEntityActionHistoryLoader HistoryLoader { get; set; }

	public List<string> DisableButtons { get; set; }

	public bool InPopup { get; set; }

	public IEnumerable<RelatedEntityActionHistoryUnitOfWorkModel> UnitOfWorks { get; set; }

	public EntityHistoryViewModel()
	{
	}

	internal EntityHistoryViewModel(EntityHistoryModel entityHistoryModel, IEnumerable<IAuditEventPermissionChecker> auditEventPermissionCheckers)
		: this()
	{
		if (entityHistoryModel.EventTuples != null && entityHistoryModel.EventTuples.Any())
		{
			EventArray = (from e in entityHistoryModel.EventTuples
				where !e.IsRelatedEvent && !auditEventPermissionCheckers.Any((IAuditEventPermissionChecker c) => !c.HasPermission(e.EntityActionEventArgs))
				select e.EntityActionEventArgs).ToList();
			HistoryLoader = new CachedEntityActionHistoryLoader(entityHistoryModel.EventTuples.Select((EntityActionEventTuple e) => e.EntityActionEventArgs));
		}
		else
		{
			if (entityHistoryModel.EventList != null)
			{
				EventArray = entityHistoryModel.EventList.Where((EntityActionEventArgs e) => !auditEventPermissionCheckers.Any((IAuditEventPermissionChecker c) => !c.HasPermission(e))).ToList();
			}
			else
			{
				EventArray = new List<EntityActionEventArgs>();
			}
			HistoryLoader = new CachedEntityActionHistoryLoader(EventArray);
		}
		UnitOfWorks = entityHistoryModel.UnitOfWorks;
	}
}
