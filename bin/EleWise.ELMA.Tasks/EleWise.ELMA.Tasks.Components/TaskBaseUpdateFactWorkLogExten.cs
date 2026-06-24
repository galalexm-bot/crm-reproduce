using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.ExtensionPoints.WorkLog;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components.WorkLog;

[Component]
public class TaskBaseUpdateFactWorkLogExtension : IUpdateFactWorkLogExtension
{
	public bool Can(Guid objectUid)
	{
		if (objectUid == Guid.Empty)
		{
			return false;
		}
		Type entityType = ModelHelper.GetEntityType(objectUid);
		return typeof(ITaskBase).IsAssignableFrom(entityType);
	}

	public void UpdateFactWorkLog(long objectId, Guid objectUid, long deltaFactWorkLog, bool fullSumma = false)
	{
		if (!(objectUid == Guid.Empty))
		{
			Type entityType = ModelHelper.GetEntityType(objectUid);
			if (typeof(ITaskBase).IsAssignableFrom(entityType))
			{
				ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				string sql = string.Format("update {0} set {1} = {3} where {2} = {4}Id", serviceNotNull.Dialect.QuoteIfNeeded("TaskBase"), serviceNotNull.Dialect.QuoteIfNeeded("FactWorkLog"), serviceNotNull.Dialect.QuoteIfNeeded("Id"), string.Format(fullSumma ? "{0}FactWorkLog" : "{1} + {0}FactWorkLog", serviceNotNull.ParameterSeparator, serviceNotNull.Dialect.IsNull(serviceNotNull.Dialect.QuoteIfNeeded("FactWorkLog"), "0")), serviceNotNull.ParameterSeparator);
				serviceNotNull.ExecuteNonQuery(sql, new Dictionary<string, object>
				{
					{ "FactWorkLog", deltaFactWorkLog },
					{ "Id", objectId }
				});
			}
		}
	}
}
