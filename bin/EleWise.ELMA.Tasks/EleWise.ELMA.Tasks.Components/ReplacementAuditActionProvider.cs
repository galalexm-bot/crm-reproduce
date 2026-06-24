using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events.Audit;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

[Component]
public class ReplacementAuditActionProvider : IAuditActionProvider
{
	public Guid? ObjectUid => null;

	public IEnumerable<IAuditAction> GetActions(IAuditObject obj)
	{
		IAuditObject @object = Locator.GetServiceNotNull<EntityAuditObjectProvider>().GetObject(InterfaceActivator.LoadMetadata<IReplacementTask>().Uid);
		yield return Locator.GetServiceNotNull<EntityAuditActionProvider>().GetAction(@object, ReplacementTaskActions.ReplacementGuid);
	}

	public IAuditAction GetAction(IAuditObject obj, Guid uid)
	{
		if (!(uid == ReplacementTaskActions.ReplacementGuid))
		{
			return null;
		}
		return GetActions(obj).First();
	}
}
