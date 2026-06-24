using System;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit.Impl;
using EleWise.ELMA.History.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.History.Components;

[Component(Order = 1000000)]
internal sealed class EntityActionAuditUnitOfWorkListener : BaseEntityActionUnitOfWorkListener
{
	private readonly EntityActionHistoryManager historyManager;

	private readonly IHistoryService historyService;

	protected override string EventListContextKey => "EleWise.ELMA.Events.Audit.Impl.EntityActionAuditHandler.EventsList";

	public EntityActionAuditUnitOfWorkListener([NotNull] IContextBoundVariableService contextBoundVariableService, [NotNull] ISessionProvider sessionProvider, [NotNull] ILogger logger, [NotNull] EntityActionHistoryManager historyManager, [NotNull] IHistoryService historyService)
		: base(contextBoundVariableService, sessionProvider, logger)
	{
		if (historyManager == null)
		{
			throw new ArgumentNullException("historyManager");
		}
		this.historyManager = historyManager;
		this.historyService = historyService;
	}

	protected override void PersistEvent(EntityActionEventArgs e)
	{
		IEntityActionHistory entityActionHistory = historyManager.CreateFromEvent(e);
		if (entityActionHistory != null)
		{
			historyManager.Save(entityActionHistory);
			historyService.UpdateTables(entityActionHistory.ActionObjectId ?? 0, entityActionHistory.ActionObjectUid, e.New ?? e.Old);
		}
	}
}
