using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Security.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Common.Models;

[FilterFor(typeof(IEntityModelHistory))]
public interface IEntityModelHistoryFilter : IEntityFilter
{
	DateTimeRange CreationDate { get; set; }

	ISet<IUser> CreationAuthor { get; set; }

	Guid? ObjectTypeUid { get; set; }

	Guid? ActionTypeUid { get; set; }

	Guid? ObjectUid { get; set; }

	long? ObjectId { get; set; }
}
