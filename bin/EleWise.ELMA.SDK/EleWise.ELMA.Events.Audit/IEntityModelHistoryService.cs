using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Events.Audit;

[DeveloperApi(DeveloperApiType.Service)]
public interface IEntityModelHistoryService
{
	long Count(Guid objectTypeUid, DateTime? from, string eqlQuery = null);

	IEnumerable<IEntityModelHistoryItem> Find(Guid objectTypeUid, DateTime? from, string eqlQuery = null);

	IEnumerable<IEntityModelHistoryItem> Find(Guid objectTypeUid, DateTime? from, string filterKey, IEntityFilter filter);
}
