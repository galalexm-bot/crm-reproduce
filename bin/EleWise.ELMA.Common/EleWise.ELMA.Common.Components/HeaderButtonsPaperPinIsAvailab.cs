using System;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints.HeaderButtonsServices;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Common.Components.HeaderButtonsServices;

[Service]
public class HeaderButtonsPaperPinIsAvailableService : IHeaderButtonsPaperPinIsAvailableService
{
	public bool IsAvailable(Guid typeUid, object entityId)
	{
		return ComponentManager.Current.GetExtensionPoints<IPaperPinProvider>().Any((IPaperPinProvider p) => p.IsAvailable(typeUid, entityId));
	}

	public bool IsAvailable(IEntity entity)
	{
		Guid typeUid = InterfaceActivator.UID(entity.CastAsRealType().GetType());
		return ComponentManager.Current.GetExtensionPoints<IPaperPinProvider>().Any((IPaperPinProvider p) => p.IsAvailable(typeUid, entity.GetId()));
	}
}
