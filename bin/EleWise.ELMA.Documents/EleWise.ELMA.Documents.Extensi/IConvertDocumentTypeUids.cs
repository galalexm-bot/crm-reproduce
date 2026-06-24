using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Documents.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IConvertDocumentTypeUids
{
	Guid GetTypesDescriptor();

	object GetUid(object obj);
}
