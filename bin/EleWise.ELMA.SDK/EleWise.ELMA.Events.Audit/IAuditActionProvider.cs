using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Events.Audit;

[ExtensionPoint(ComponentType.Server)]
public interface IAuditActionProvider
{
	Guid? ObjectUid { get; }

	IEnumerable<IAuditAction> GetActions(IAuditObject obj);

	IAuditAction GetAction(IAuditObject obj, Guid uid);
}
