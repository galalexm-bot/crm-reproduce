using System;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.ExtensionPoints.HeaderButtonsServices;

public interface IHeaderButtonsWatchIsAvailableService
{
	bool IsAvailable(Guid typeUid, object entityId);

	bool IsAvailable(IEntity entity);
}
