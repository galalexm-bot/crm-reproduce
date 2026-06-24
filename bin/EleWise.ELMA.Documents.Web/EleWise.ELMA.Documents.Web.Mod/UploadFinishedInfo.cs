using System.Collections.Generic;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Web.Models;

public class UploadFinishedInfo
{
	public List<IDocumentVersion> AddedVersions { get; set; }

	public List<RenameDocumentnfo> Documents { get; set; }

	public bool HideDocuments { get; set; }

	public string PopupId { get; set; }

	public bool SelectOne { get; set; }
}
