using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Events.Audit;

[ExtensionPoint(ComponentType.Server)]
public interface IAuditObjectProvider
{
	IEnumerable<IAuditObject> GetObjects();

	IAuditObject GetObject(Guid uid);
}
