using System;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.ExtensionPoints.HeaderButtonsServices;

public interface IHeaderButtonsPaperPinIsAvailableService
{
	bool IsAvailable(Guid typeUid, object entityId);

	bool IsAvailable(IEntity entity);
}
