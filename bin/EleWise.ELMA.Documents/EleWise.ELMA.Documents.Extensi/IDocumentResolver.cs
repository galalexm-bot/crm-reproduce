using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IDocumentResolver
{
	IEnumerable<IDocument> GetDocuments(object value);

	IEnumerable<Guid> GetContextVarTypes();
}
