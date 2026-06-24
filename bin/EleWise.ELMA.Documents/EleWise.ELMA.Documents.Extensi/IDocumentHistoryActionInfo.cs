using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Documents.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IDocumentHistoryActionInfo
{
	Guid ActionUid { get; }

	string ActionName { get; }

	Guid ActionChapterUid { get; }

	string CustomImage { get; }
}
