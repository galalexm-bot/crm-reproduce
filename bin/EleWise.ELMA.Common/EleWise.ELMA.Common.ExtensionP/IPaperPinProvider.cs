using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IPaperPinProvider
{
	bool IsAvailable(Guid typeUid, object entityId = null);

	List<Guid> AvailableTypes();

	bool OnlyOneInstance();

	string TooltipText(Guid typeUid, object entityId = null);

	string TooltipTextPin(Guid typeUid, object entityId = null);

	string ConfirmText(Guid typeUid, object entityId = null);
}
