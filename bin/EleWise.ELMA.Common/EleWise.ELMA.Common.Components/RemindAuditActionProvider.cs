using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events.Audit;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Components;

[Component]
public class RemindAuditActionProvider : IAuditActionProvider
{
	public Guid? ObjectUid => null;

	public IEnumerable<IAuditAction> GetActions(IAuditObject obj)
	{
		IAuditObject @object = Locator.GetServiceNotNull<EntityAuditObjectProvider>().GetObject(InterfaceActivator.LoadMetadata<IReminder>().Uid);
		IAuditAction action = Locator.GetServiceNotNull<EntityAuditActionProvider>().GetAction(@object, new Guid("5761c647-866e-4a19-9ebd-1b9ac73eb86d"));
		if (action == null)
		{
			return null;
		}
		return new List<IAuditAction> { action };
	}

	public IAuditAction GetAction(IAuditObject obj, Guid uid)
	{
		if (obj == null || obj.Type == null || obj.Type.Uid != EntityAuditObjectType.UID)
		{
			return null;
		}
		return GetActions(obj)?.FirstOrDefault((IAuditAction a) => a.Uid == uid);
	}
}
