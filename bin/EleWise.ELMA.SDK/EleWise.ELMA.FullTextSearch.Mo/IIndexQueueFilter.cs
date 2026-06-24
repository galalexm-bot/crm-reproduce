using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.FullTextSearch.Model;

[FilterFor(typeof(IIndexQueue))]
public interface IIndexQueueFilter : IEntityFilter
{
	Int64Range ObjectId { get; set; }

	List<IndexQueueType> QueueType { get; set; }

	Guid? ObjectTypeUid { get; set; }

	Guid? CardTypeUid { get; set; }

	bool? VisualData { get; set; }
}
