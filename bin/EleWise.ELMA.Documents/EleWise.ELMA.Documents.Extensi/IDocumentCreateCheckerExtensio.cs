using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Documents.ExtensionPoint;

[ExtensionPoint(ComponentType.All)]
public interface IDocumentCreateCheckerExtension
{
	void Check(Type type);
}
