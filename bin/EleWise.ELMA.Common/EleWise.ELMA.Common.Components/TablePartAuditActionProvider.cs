using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events.Audit;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.Components;

[Component]
internal sealed class TablePartAuditActionProvider : IAuditActionProvider
{
	private EnumMetadata defaultActions;

	private IEnumerable<IAuditAction> actions;

	private EnumMetadata DefaultActions
	{
		get
		{
			if (defaultActions == null)
			{
				defaultActions = new EntityActionsMetadata();
				defaultActions.LoadFromType(typeof(DefaultTablePartActions));
			}
			return defaultActions;
		}
	}

	public Guid? ObjectUid => null;

	public TablePartAuditActionProvider()
	{
		List<IAuditAction> list = new List<IAuditAction>();
		foreach (EnumValueMetadata value in DefaultActions.Values)
		{
			EntityAuditAction item = new EntityAuditAction(value.Uid, value.Name, (EntityAuditAction a) => GetDefaultLocalizedMetadata(a.Uid), value.DefaultImage);
			list.Add(item);
		}
		actions = list;
	}

	public IEnumerable<IAuditAction> GetActions(IAuditObject obj)
	{
		if (obj == null || obj.Type == null || obj.Type.Uid != EntityAuditObjectType.UID)
		{
			return null;
		}
		return actions;
	}

	public IAuditAction GetAction(IAuditObject obj, Guid uid)
	{
		if (obj == null || obj.Type == null || obj.Type.Uid != EntityAuditObjectType.UID)
		{
			return null;
		}
		return GetActions(obj)?.FirstOrDefault((IAuditAction a) => a.Uid == uid);
	}

	private EnumValueMetadata GetDefaultLocalizedMetadata(Guid valueUid)
	{
		return DefaultActions.Values.FirstOrDefault((EnumValueMetadata v) => v.Uid == valueUid);
	}
}
