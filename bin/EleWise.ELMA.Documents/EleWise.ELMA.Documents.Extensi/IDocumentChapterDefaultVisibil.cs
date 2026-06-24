using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IDocumentChapterDefaultVisibility
{
	bool CheckType(Guid documentType);

	bool CheckVisibility(DocumentActionChapterInfo chapter, IDocumentMetadataProfile profile);
}
