using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Messages.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IDiscussionCollectHistoryResolver
{
	bool CheckType(Guid actionObject);

	bool IsCollect(long id, Guid actionObject);
}
