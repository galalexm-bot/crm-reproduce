using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Documents.Models;

[FilterFor(typeof(IDocumentVersion))]
public interface IDocumentVersionFilter : IEntityFilter
{
	IDocument Document { get; set; }

	BinaryFile File { get; set; }

	DateTimeRange CreationDate { get; set; }

	IUser CreationAuthor { get; set; }

	DateTimeRange ChangeDate { get; set; }

	IUser ChangeAuthor { get; set; }

	DocumentVersionStatus? Status { get; set; }
}
