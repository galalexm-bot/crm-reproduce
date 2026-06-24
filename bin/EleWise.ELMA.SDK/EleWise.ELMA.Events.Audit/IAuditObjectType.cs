using System;

namespace EleWise.ELMA.Events.Audit;

public interface IAuditObjectType
{
	Guid Uid { get; }
}
