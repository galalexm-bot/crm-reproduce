using System;

namespace EleWise.ELMA.Common.Services;

public interface IEntityHistoryRestrictionService : IEntityModelHistoryRestrictionService
{
	bool IsSupported(Guid typeUid, Guid? actionUid, int entityHistoryType);
}
