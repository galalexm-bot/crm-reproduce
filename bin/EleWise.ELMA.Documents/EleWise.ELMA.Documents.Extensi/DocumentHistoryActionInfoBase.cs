using System;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Extensions;

public abstract class DocumentHistoryActionInfoBase : IDocumentHistoryActionInfo
{
	public IAuditManager AuditManager => Locator.GetServiceNotNull<IAuditManager>();

	public abstract Guid ActionUid { get; }

	public abstract Guid ActionChapterUid { get; }

	public virtual string ActionName
	{
		get
		{
			if (ActionUid == Guid.Empty)
			{
				return string.Empty;
			}
			IAuditAction action = AuditManager.GetAction(ActionUid);
			if (action == null)
			{
				return string.Empty;
			}
			return action.DisplayName;
		}
	}

	public virtual string CustomImage => null;
}
