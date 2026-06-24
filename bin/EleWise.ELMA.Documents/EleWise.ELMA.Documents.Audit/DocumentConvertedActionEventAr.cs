using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Documents.Audit;

[Uid("{B8974050-8C70-44F5-98AF-153D8A664E79}")]
public class DocumentConvertedActionEventArgs : ConvertedActionEventArgs
{
	public DocumentConvertedActionEventArgs(IEntity entity, Guid objectUid, Guid actionUid)
		: base(entity, objectUid, actionUid)
	{
	}
}
