using System;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Events.Audit;

public interface IEntityModelHistoryItem
{
	DateTime CreationDate { get; set; }

	IUser CreationAuthor { get; set; }

	Guid ObjectTypeUid { get; set; }

	Guid ObjectUid { get; set; }

	long ObjectId { get; set; }

	Guid ActionTypeUid { get; set; }
}
