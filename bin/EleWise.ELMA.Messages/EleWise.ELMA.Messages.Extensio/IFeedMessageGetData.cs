using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Messages.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFeedMessageGetData
{
	string Name { get; }

	bool IsSupport(Guid objectUid, Guid actionUid);

	List<long> GetRecipients(IEntity entity, Guid actionUid);

	List<Pair<long, List<WebDataItem>>> GetData(FeedMessageInfoParameters info, List<long> recipients);
}
