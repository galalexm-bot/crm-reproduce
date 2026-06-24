using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IDuplicateHandler
{
	Guid? EntityType();

	bool IsScoringEnabled(Guid TypeUid);

	List<PossibleDuplicate> GetPossibleDuplicates(IEntity entity);
}
