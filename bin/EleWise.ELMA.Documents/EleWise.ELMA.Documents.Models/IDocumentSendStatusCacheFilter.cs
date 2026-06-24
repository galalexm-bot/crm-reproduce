using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Documents.Models;

[FilterFor(typeof(IDocumentSendStatusCache))]
public interface IDocumentSendStatusCacheFilter : IEntityFilter
{
	IDocument Document { get; set; }

	SendStatus? SendStatus { get; set; }

	RelativeDateTime SendDate { get; set; }

	IUser SendUser { get; set; }

	string SendNumber { get; set; }
}
