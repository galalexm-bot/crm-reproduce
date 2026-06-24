using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Common.ExtensionPoints;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public abstract class BasePaperPinProvider : IPaperPinProvider
{
	public virtual bool IsAvailable(Guid typeUid, object entityId = null)
	{
		return AvailableTypes().Any((Guid uid) => uid == typeUid);
	}

	public abstract List<Guid> AvailableTypes();

	public virtual bool OnlyOneInstance()
	{
		return false;
	}

	public abstract string TooltipText(Guid typeUid, object entityId = null);

	public abstract string TooltipTextPin(Guid typeUid, object entityId = null);

	public abstract string ConfirmText(Guid typeUid, object entityId = null);
}
