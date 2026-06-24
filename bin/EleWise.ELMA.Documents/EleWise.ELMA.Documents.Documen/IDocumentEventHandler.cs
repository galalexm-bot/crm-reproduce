using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Events;

namespace EleWise.ELMA.Documents.DocumentAuditEvents;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IDocumentEventHandler : IEventHandler
{
	void BrowseDocument(IDocument document);
}
