using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Documents.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IDocumentHelp
{
	bool CheckType(Guid typeUid);

	IDocument ResolveDocument(ClassMetadata metadata, ITaskBase task);

	string GetDescription(ClassMetadata metadata, ITaskBase task);
}
