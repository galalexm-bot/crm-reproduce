using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Common.Models;

[FilterFor(typeof(IEntityActionHistory))]
public interface IEntityActionHistoryFilter : IEntityFilter
{
	IUser CreationAuthor { get; set; }

	DateTimeRange ActionDate { get; set; }

	Guid? ActionObjectUid { get; set; }

	Guid? ActionTypeUid { get; set; }

	long? ActionObjectId { get; set; }

	Guid? UnitOfWorkUid { get; set; }
}
