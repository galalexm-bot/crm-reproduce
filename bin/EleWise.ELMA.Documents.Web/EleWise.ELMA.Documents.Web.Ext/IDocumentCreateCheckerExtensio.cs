using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Documents.Web.ExtensionPoints;

[Obsolete("Устарел. Перенесено в серверную часть EleWise.ELMA.Documents.ExtensionPoint.IDocumentCreateCheckerExtension")]
[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IDocumentCreateCheckerExtension
{
	void Check(Type type);
}
