using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IDocumentActionDefaultVisibility
{
	bool CheckType(Guid documentType);

	bool CheckVisibility(DocumentActionInfo action, IDocumentMetadataProfile profile);
}
