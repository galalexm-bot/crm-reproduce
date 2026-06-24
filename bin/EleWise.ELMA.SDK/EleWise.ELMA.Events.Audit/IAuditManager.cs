using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Events.Audit;

[DeveloperApi(DeveloperApiType.Service)]
public interface IAuditManager
{
	IEnumerable<IAuditObject> GetObjects();

	IAuditObject GetObject(Guid uid);

	IEnumerable<IAuditAction> GetActions(IAuditObject obj);

	IAuditAction GetAction(IAuditObject obj, Guid uid);

	IAuditAction GetAction(Guid uid);
}
