using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;

namespace EleWise.ELMA.Model.Managers;

[ExtensionPoint(ComponentType.Server)]
public interface IEntityChangesLoader
{
	bool IsTypeSupported(Guid typeUid);

	IEnumerable<IEntityModelHistoryItem> LoadChanges(Guid typeUid, DateTime? fromDateTime, string selectExpression = null);
}
