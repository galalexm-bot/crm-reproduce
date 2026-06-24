using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.IntegrationModules.Constants;
using EleWise.ELMA.IntegrationModules.Metadata;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using NHibernate.Criterion;

namespace EleWise.ELMA.IntegrationModules.Db;

public class IntegrationModulesDbStructure : DbStructureExtension
{
	private IMetadataRuntimeService metadataRuntimeService;

	private ISessionProvider sessionProvider;

	private ISessionProvider SessionProvider => sessionProvider ?? (sessionProvider = Locator.GetServiceNotNull<ISessionProvider>());

	public override Guid ProviderUid => Guid.Empty;

	public IntegrationModulesDbStructure(IMetadataRuntimeService metadataRuntimeService)
	{
		this.metadataRuntimeService = metadataRuntimeService;
	}

	internal void CreateDeletedIntegrationFolder()
	{
		IIntegrationModulesGroup integrationModulesGroup = InterfaceActivator.Create<IIntegrationModulesGroup>();
		integrationModulesGroup.Name = SR.T("Корзина");
		integrationModulesGroup.Uid = IntegrationsConstants.DeletedModulesGroupUid;
		integrationModulesGroup.Save();
	}

	internal void ReplaceActivityUids()
	{
		IEnumerable<IntegrationModuleActivityMetadata> source = from m in metadataRuntimeService.GetMetadataList().OfType<IntegrationModuleActivityMetadata>()
			where m.Type == EntityMetadataType.Interface
			select m;
		if (!source.Any())
		{
			return;
		}
		foreach (IMetadataItemHeader item in SessionProvider.GetSession("").CreateCriteria(InterfaceActivator.TypeOf<IMetadataItemHeader>()).Add((ICriterion)(object)Restrictions.In("Uid", (ICollection)source.Select((IntegrationModuleActivityMetadata a) => a.Uid).ToArray()))
			.List<IMetadataItemHeader>())
		{
			if (item.Current != null && item.Current.Metadata != null && item.Current.Metadata is IntegrationModuleActivityMetadata integrationModuleActivityMetadata && item.Current.Uid != integrationModuleActivityMetadata.Uid)
			{
				item.Current.Uid = integrationModuleActivityMetadata.Uid;
				item.Current.Save();
			}
		}
	}
}
