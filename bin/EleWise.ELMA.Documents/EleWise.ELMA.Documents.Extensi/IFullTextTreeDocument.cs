using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Documents.Extensions;

[ExtensionPoint(ComponentType.All)]
public interface IFullTextTreeDocument
{
	Guid GetDocumentTreeProviderUid { get; }
}
