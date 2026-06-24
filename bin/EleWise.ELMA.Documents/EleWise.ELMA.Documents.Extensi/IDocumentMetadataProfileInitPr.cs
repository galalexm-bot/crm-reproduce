using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IDocumentMetadataProfileInitProvider
{
	bool CheckType(Guid? documentType);

	void Init(IDocumentMetadataProfile profile);
}
