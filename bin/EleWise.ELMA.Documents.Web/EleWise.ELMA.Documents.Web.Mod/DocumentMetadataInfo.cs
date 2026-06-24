using System;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Documents.Web.Models;

public class DocumentMetadataInfo : EntityModel<DocumentMetadata>
{
	public IUser CreationAuthor { get; set; }

	public DateTime? CreationDate { get; set; }

	public DateTime? DateModified { get; set; }

	public DateTime? PublishedCreationDate { get; set; }
}
