using System;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Common.Services;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Web.Models;

public class DocumentFilterModel : FolderBaseModel<IFilterDocumentFolder>
{
	private readonly Lazy<bool> anyFiles;

	public bool AnyFiles => anyFiles.Value;

	public bool UseFullTextSearch { get; set; }

	public string UseFullTextSearchErrors { get; set; }

	public bool SerachOnOpen { get; set; }

	public bool EQLSearch { get; set; }

	public GridDataFilter<IDocument> GridData { get; set; }

	public DocumentFilterModel()
	{
		anyFiles = new Lazy<bool>(() => Locator.GetServiceNotNull<ICheckAnyAttachmentService>().CheckAnyFile(base.Entity.TypeUid, base.Entity));
	}
}
