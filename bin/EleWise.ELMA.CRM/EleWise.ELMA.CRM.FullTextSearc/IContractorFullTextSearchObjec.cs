using System;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.FullTextSearch.Model;

[AutoImplement(typeof(IFullTextSearchObject))]
public interface IContractorFullTextSearchObject : IFullTextSearchObject, IAutoImplement
{
	string Name { get; set; }

	string CreationAuthor { get; set; }

	long ResponsibleId { get; set; }

	[Obsolete("Устарело, индексируется в соответствии с типом", false)]
	string[] Phone { get; set; }

	string[] Email { get; set; }

	string Site { get; set; }

	bool IsDeleted { get; set; }

	string[] AttachmentsName { get; set; }

	string[] AttachmentsText { get; set; }

	long[] DocumentsId { get; set; }

	string[] DocumentsName { get; set; }

	string[] UserSecuritySetCacheId { get; set; }
}
