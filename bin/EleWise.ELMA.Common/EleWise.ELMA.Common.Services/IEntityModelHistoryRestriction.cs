using System;

namespace EleWise.ELMA.Common.Services;

[Obsolete("Use IEntityHistoryRestrictionService")]
public interface IEntityModelHistoryRestrictionService
{
	bool IsSupported(Guid typeUid, Guid? actionUid);
}
