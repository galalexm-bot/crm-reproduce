using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using NHibernate;

namespace EleWise.ELMA.UIBuilder.Db;

internal sealed class DesignerDbStructure : DbStructureExtension
{
	public override Guid ProviderUid => Guid.Empty;

	internal void RemoveDesignerModules()
	{
		ISession session = Locator.GetServiceNotNull<ISessionProvider>().GetSession("");
		ISet<Guid> designerModules = ModuleMetadataItemHeaderManager.DesignerModules;
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string text = "designerModules";
		((IQuery)session.CreateSQLQuery(string.Format("\r\nDELETE FROM {0}\r\nWHERE {1} in (:{2})", serviceNotNull.Dialect.QuoteIfNeeded("ModuleReference"), serviceNotNull.Dialect.QuoteIfNeeded("ModuleUid"), text))).SetParameterList(text, (IEnumerable)designerModules).CleanUpCache(cleanUpCache: false).ExecuteUpdate();
		ModuleMetadataItemHeaderManager instance = ModuleMetadataItemHeaderManager.Instance;
		_ = ModuleMetadataItemManager.Instance;
		ICollection<ModuleMetadataItemHeader> source = instance.Find("Uid in (" + string.Join(",", designerModules.Select((Guid x) => $"Guid('{x}')")) + ")");
		string[] array = source.Select((ModuleMetadataItemHeader a) => a.Name).ToArray();
		if (array.Length != 0)
		{
			string text2 = "designerModulesNames";
			((IQuery)session.CreateSQLQuery(string.Format("\r\nDELETE FROM {0}\r\nWHERE {1} in (:{2})", serviceNotNull.Dialect.QuoteIfNeeded("Sys_Components"), serviceNotNull.Dialect.QuoteIfNeeded("Id"), text2))).SetParameterList(text2, (IEnumerable)array).CleanUpCache(cleanUpCache: false).ExecuteUpdate();
			((IQuery)(object)session.CreateSQLQuery(string.Format("\r\nUPDATE {0}\r\nSET {1} = null, {2} = null", serviceNotNull.Dialect.QuoteIfNeeded("ModuleMetadataItemHeader"), serviceNotNull.Dialect.QuoteIfNeeded("Published"), serviceNotNull.Dialect.QuoteIfNeeded("Draft")))).CleanUpCache(cleanUpCache: false).ExecuteUpdate();
			long[] array2 = source.Select((ModuleMetadataItemHeader a) => a.Id).ToArray();
			string text3 = "designerModulesNames";
			((IQuery)session.CreateSQLQuery(string.Format("\r\nDELETE FROM {0}\r\nWHERE {1} in (select {2} from {3} where {4} in (:{5}))", serviceNotNull.Dialect.QuoteIfNeeded("DataClassTypeReference"), serviceNotNull.Dialect.QuoteIfNeeded("ItemUid"), serviceNotNull.Dialect.QuoteIfNeeded("Uid"), serviceNotNull.Dialect.QuoteIfNeeded("ModuleMetadataItem"), serviceNotNull.Dialect.QuoteIfNeeded("Header"), text3))).SetParameterList(text3, (IEnumerable)array2).CleanUpCache(cleanUpCache: false).ExecuteUpdate();
			((IQuery)session.CreateSQLQuery(string.Format("\r\nDELETE FROM {0}\r\nWHERE {1} in (:{2})", serviceNotNull.Dialect.QuoteIfNeeded("ModuleMetadataItem"), serviceNotNull.Dialect.QuoteIfNeeded("Header"), text3))).SetParameterList(text3, (IEnumerable)array2).CleanUpCache(cleanUpCache: false).ExecuteUpdate();
			((IQuery)session.CreateSQLQuery(string.Format("\r\nDELETE FROM {0}\r\nWHERE {1} in (:{2})", serviceNotNull.Dialect.QuoteIfNeeded("ModuleMetadataItemHeader"), serviceNotNull.Dialect.QuoteIfNeeded("Id"), text3))).SetParameterList(text3, (IEnumerable)array2).CleanUpCache(cleanUpCache: false).ExecuteUpdate();
		}
	}

	internal void CheckAndUpdateWrongModuleHeaders()
	{
		List<ModuleVersion> list = ModuleMetadataItemManager.Instance.GetLastPublished(Enumerable.Empty<Guid>()).Select(ModuleVersion.FromItem).ToList();
		List<Guid> list2 = new List<Guid>();
		IModuleMetadataLoader serviceNotNull = Locator.GetServiceNotNull<IModuleMetadataLoader>();
		foreach (ModuleVersion item in list)
		{
			foreach (LinkToModule dependencyModule in item.Metadata.DependencyModules)
			{
				if (serviceNotNull.GetModuleVersionHeaders(dependencyModule.ModuleUid).Count == 0)
				{
					list2.Add(item.Header.HeaderUid);
					break;
				}
			}
		}
		if (list2.Count != 0)
		{
			ISession session = Locator.GetServiceNotNull<ISessionProvider>().GetSession("");
			ITransformationProvider serviceNotNull2 = Locator.GetServiceNotNull<ITransformationProvider>();
			((IQuery)session.CreateSQLQuery(string.Format("\r\nUPDATE {0} SET {1} = null\r\nWHERE {2} in (:{3})", serviceNotNull2.Dialect.QuoteIfNeeded("ModuleMetadataItemHeader"), serviceNotNull2.Dialect.QuoteIfNeeded("Published"), serviceNotNull2.Dialect.QuoteIfNeeded("Uid"), "modules"))).SetParameterList("modules", (IEnumerable)list2).CleanUpCache(cleanUpCache: false).ExecuteUpdate();
		}
	}
}
