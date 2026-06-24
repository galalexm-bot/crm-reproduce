using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.IntegrationModules.Metadata;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.IntegrationModules.Managers;

public class IntegrationModuleHeaderManager : EntityManager<IIntegrationModuleHeader, long>
{
	private IMetadataRuntimeService metadataRuntimeService;

	private IntegrationModulesGroupManager integrationModulesGroupManager;

	public IntegrationModuleHeaderManager(IMetadataRuntimeService metadataRuntimeService, IntegrationModulesGroupManager integrationModulesGroupManager)
	{
		this.metadataRuntimeService = metadataRuntimeService;
		this.integrationModulesGroupManager = integrationModulesGroupManager;
	}

	public IEnumerable<IntegrationModuleMetadata> GetIntegrationModuleMetadataList(bool? isPublished)
	{
		IIntegrationModuleHeaderFilter integrationModuleHeaderFilter = InterfaceActivator.Create<IIntegrationModuleHeaderFilter>();
		integrationModuleHeaderFilter.IsDeleted = false;
		integrationModuleHeaderFilter.IsPublished = isPublished;
		IEnumerable<Guid> metadataUids = from a in Find(integrationModuleHeaderFilter, null)
			select a.IntegrationModuleTyeUid;
		if (metadataUids.Any())
		{
			return from a in metadataRuntimeService.GetMetadataList().OfType<IntegrationModuleMetadata>()
				where metadataUids.Contains(a.Uid)
				select a;
		}
		return Enumerable.Empty<IntegrationModuleMetadata>();
	}

	public IEnumerable<IIntegrationModuleHeader> GetIntegrationModuleMetadataHeadersList()
	{
		IIntegrationModuleHeaderFilter integrationModuleHeaderFilter = InterfaceActivator.Create<IIntegrationModuleHeaderFilter>();
		integrationModuleHeaderFilter.IsDeleted = false;
		return Find(integrationModuleHeaderFilter, null);
	}

	public IIntegrationModuleHeader GetIntegrationModuleMetadataHeader(Guid uid)
	{
		IIntegrationModuleHeaderFilter integrationModuleHeaderFilter = InterfaceActivator.Create<IIntegrationModuleHeaderFilter>();
		integrationModuleHeaderFilter.IntegrationModuleTyeUid = uid;
		return Find(integrationModuleHeaderFilter, FetchOptions.First).FirstOrDefault();
	}

	public void DeleteMetadata(Guid uid)
	{
		IIntegrationModuleHeader integrationModuleMetadataHeader = GetIntegrationModuleMetadataHeader(uid);
		if (integrationModuleMetadataHeader != null)
		{
			IIntegrationModulesGroup integrationModulesGroup = (integrationModuleMetadataHeader.Group = integrationModulesGroupManager.GetDeletedModulesGroup());
			integrationModuleMetadataHeader.IsDeleted = true;
			integrationModuleMetadataHeader.Save();
		}
	}

	public void RestoreMetadata(Guid uid)
	{
		IIntegrationModuleHeader integrationModuleMetadataHeader = GetIntegrationModuleMetadataHeader(uid);
		if (integrationModuleMetadataHeader != null)
		{
			integrationModulesGroupManager.GetDeletedModulesGroup();
			integrationModuleMetadataHeader.Group = null;
			integrationModuleMetadataHeader.IsDeleted = false;
			integrationModuleMetadataHeader.Save();
		}
	}
}
