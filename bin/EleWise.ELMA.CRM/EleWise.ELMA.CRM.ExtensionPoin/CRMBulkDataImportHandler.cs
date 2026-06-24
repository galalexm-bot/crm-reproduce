using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.Common.BulkDataImport.Handlers;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Runtime.NH;
using NHibernate;

namespace EleWise.ELMA.CRM.ExtensionPoints;

[Component(Order = 100)]
public class CRMBulkDataImportHandler : IBulkDataImportHandler
{
	private ISessionProvider sessionProvider;

	public CRMBulkDataImportHandler(ISessionProvider sessionProvider)
	{
		this.sessionProvider = sessionProvider;
	}

	public virtual bool CanUse(Type type)
	{
		if (!typeof(IContractor).IsAssignableFrom(type))
		{
			return typeof(ILead).IsAssignableFrom(type);
		}
		return true;
	}

	public virtual void AfterImport(BulkDataImportHandlerData handlerData)
	{
		sessionProvider.GetSession("").GetNamedQuery("CheckInheritedPermission").SetTimeout(0)
			.ExecuteUpdate(cleanUpCache: false);
	}

	public virtual void AfterImportPage(IEnumerable<MapInfo> mapInfos, BulkDataImportHandlerData handlerData)
	{
	}

	public virtual void BeforeMapping(DataTable data, BulkDataImportHandlerData handlerData)
	{
	}
}
