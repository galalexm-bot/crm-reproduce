using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Documents.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IDocumentPropertyGuidExtension
{
	bool CheckType(Guid uid);

	List<Guid> GetGuidList();
}
