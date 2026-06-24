using System;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Documents.FullTextSearch.Model;

[AutoImplement(typeof(IFullTextSearchObject))]
public interface IDocumentsFullTextSearchObject : IFullTextSearchObject, IAutoImplement
{
	string Name { get; set; }

	string CreationAuthor { get; set; }

	long CreationAuthorId { get; set; }

	DateTime? CreationDate { get; set; }

	DateTime? ChangeDate { get; set; }

	string[] UserSecuritySetCacheId { get; set; }

	string[] Versions { get; set; }

	long CurrentVersionId { get; set; }

	string CurrentVersionFile { get; set; }

	long FolderId { get; set; }

	string FolderName { get; set; }

	bool IsDeleted { get; set; }

	bool IsArchived { get; set; }

	bool IsEncrypt { get; set; }
}
