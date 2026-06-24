using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Extensions;

[ExtensionPoint(ComponentType.WebServer)]
public interface IDocumentLinksCountExtension
{
	long LinksCount(IDocument document);

	string StringLinksCount(IDocument document);
}
