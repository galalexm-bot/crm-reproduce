using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Workflow.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IDocumentChangePermissions
{
	List<IDocument> GetAllDocuments(IDocument document, bool applyToRelated);
}
