using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit.Impl;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Audit;

[Component]
internal class EntityActionAuditHandler : BaseEntityActionHandler
{
	public const string EventListContextKeyConst = "EleWise.ELMA.Events.Audit.Impl.EntityActionAuditHandler.EventsList";

	protected override string EventListContextKey => "EleWise.ELMA.Events.Audit.Impl.EntityActionAuditHandler.EventsList";

	public EntityActionAuditHandler([NotNull] IContextBoundVariableService contextBoundVariableService, [NotNull] IUnitOfWorkManager unitOfWorkManager)
		: base(contextBoundVariableService, unitOfWorkManager)
	{
	}

	protected override bool NeedPersistEvent(EntityActionEventArgs e)
	{
		if (e == null || e.Object == null || e.Action == null)
		{
			return false;
		}
		IEntity entity = e.New ?? e.Old;
		if (entity == null)
		{
			return false;
		}
		if (!(MetadataLoader.LoadMetadata(entity.GetType()) is EntityMetadata entityMetadata) || !entityMetadata.SaveHistory)
		{
			return false;
		}
		return true;
	}
}
