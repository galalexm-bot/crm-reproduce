using System;

namespace EleWise.ELMA.Common.Models;

public class RelatedEntityActionHistoryUnitOfWorkModel
{
	public Guid UnitOfWorkUid { get; set; }

	public DateTime ActionDate { get; set; }

	public long? Id { get; set; }
}
