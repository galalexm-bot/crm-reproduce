using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Documents.Web.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IDocumentsDefaultHomePagePortletsProvider
{
	IEnumerable<DocumentDefaultHomePagePortlet> Portlets();
}
