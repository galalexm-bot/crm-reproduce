using System;
using EleWise.ELMA.ComponentModel;
using NHibernate.Event;

namespace EleWise.ELMA.Model.PropertyHandlers;

[ExtensionPoint(ComponentType.All)]
public interface IChangePropertyHandlerIgnoreProvider
{
	bool CheckType(Guid typeUid);

	bool Ignore(PreUpdateEvent @event);
}
