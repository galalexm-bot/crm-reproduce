using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Web.Mvc.Portlets;

[Component]
internal sealed class PortletV2ModuleProvider : IPortletProvider
{
	private readonly ISessionProvider sessionProvider;

	private readonly IModuleReferenceManager moduleReferenceManager;

	private readonly ModuleMetadataItemHeaderManager headerManager;

	private ISession Session => sessionProvider.GetSession(string.Empty);

	public PortletV2ModuleProvider(ModuleMetadataItemHeaderManager headerManager, ISessionProvider sessionProvider, IModuleReferenceManager moduleReferenceManager)
	{
		this.sessionProvider = sessionProvider;
		this.moduleReferenceManager = moduleReferenceManager;
		this.headerManager = headerManager;
	}

	public IPortlet GetPortlet(Guid uid)
	{
		ModuleReference moduleReference = moduleReferenceManager.LoadOrNull(uid);
		if (moduleReference == null)
		{
			return null;
		}
		ModuleMetadataItem moduleMetadataItem = headerManager.LoadOrNull(moduleReference.ModuleUid)?.Published;
		if (moduleMetadataItem == null)
		{
			return null;
		}
		ModuleInfoMetadata moduleInfoMetadata = (ModuleInfoMetadata)moduleMetadataItem.Metadata;
		if (!(moduleInfoMetadata.Components.FirstOrDefault((ComponentMetadata c) => c.Uid == uid) is PortletComponentMetadata portletMetadata))
		{
			return null;
		}
		string assemblyName = ScriptExecutionHandlerHelper.CreateFullAssemblyName(moduleMetadataItem.AssemblyName, moduleMetadataItem.Version);
		return new PortletV2(portletMetadata, GetAssembly(moduleMetadataItem.AssemblyRaw, assemblyName), GetCategory(moduleInfoMetadata.DisplayName));
	}

	public IEnumerable<IPortlet> GetPortlets()
	{
		long[] publishedItems = ((IQueryOver<ModuleMetadataItemHeader>)(object)Session.QueryOver<ModuleMetadataItemHeader>().Where((Expression<Func<ModuleMetadataItemHeader, bool>>)((ModuleMetadataItemHeader h) => h.Published != null)).Select(new Expression<Func<ModuleMetadataItemHeader, object>>[1]
		{
			(ModuleMetadataItemHeader h) => h.Published.Id
		})).List<long>().ToArray();
		var enumerable = from props in ((IQueryOver<ModuleMetadataItem>)(object)Session.QueryOver<ModuleMetadataItem>().Where((Expression<Func<ModuleMetadataItem, bool>>)((ModuleMetadataItem i) => RestrictionExtensions.IsIn((object)i.Id, (ICollection)publishedItems))).Select(new Expression<Func<ModuleMetadataItem, object>>[4]
			{
				(ModuleMetadataItem h) => h.Metadata,
				(ModuleMetadataItem h) => h.AssemblyName,
				(ModuleMetadataItem h) => h.AssemblyRaw,
				(ModuleMetadataItem h) => h.Version
			})).List<object[]>()
			select new
			{
				Metadata = (ModuleInfoMetadata)props[0],
				AssemblyName = (string)props[1],
				AssemblyRaw = (byte[])props[2],
				Version = (string)props[3]
			};
		List<IPortlet> list = new List<IPortlet>();
		foreach (var item in enumerable)
		{
			string assemblyName = ScriptExecutionHandlerHelper.CreateFullAssemblyName(item.AssemblyName, item.Version);
			Assembly assembly = GetAssembly(item.AssemblyRaw, assemblyName);
			string category = GetCategory(item.Metadata.DisplayName);
			foreach (ComponentMetadata component in item.Metadata.Components)
			{
				if (component is PortletComponentMetadata portletMetadata)
				{
					list.Add(new PortletV2(portletMetadata, assembly, category));
				}
			}
		}
		return list;
	}

	private Assembly GetAssembly(byte[] assemblyRaw, string assemblyName)
	{
		Assembly assembly = ComponentManager.FindLoadedAssembly(assemblyName, isFullName: true);
		if (assembly == null)
		{
			assembly = ComponentManager.LoadAssembly(assemblyRaw);
		}
		return assembly;
	}

	private string GetCategory(string moduleName)
	{
		return SR.T("Портлеты из модуля {0}", moduleName);
	}
}
