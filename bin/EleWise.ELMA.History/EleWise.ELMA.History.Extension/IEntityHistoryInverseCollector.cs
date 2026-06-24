using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.History.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.History.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IEntityHistoryInverseCollector
{
	bool CanUse(IEntity entity);

	IEnumerable<InverseRelatedEntityModel> RelatedTo(IEntity entity);
}
