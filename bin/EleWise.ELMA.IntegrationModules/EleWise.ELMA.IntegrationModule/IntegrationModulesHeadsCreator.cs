using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.IntegrationModules.Metadata;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.IntegrationModules.Components;

[Component]
internal class IntegrationModulesHeadsCreatorModuleContainerEvents : IModuleContainerEvents
{
	private IMetadataRuntimeService metadataRuntimeService;

	private ISessionProvider sessionProvider;

	public IntegrationModulesHeadsCreatorModuleContainerEvents(IMetadataRuntimeService metadataRuntimeService, ISessionProvider sessionProvider)
	{
		this.metadataRuntimeService = metadataRuntimeService;
		this.sessionProvider = sessionProvider;
	}

	public void Activated()
	{
		List<IntegrationModuleMetadata> list = (from m in metadataRuntimeService.GetMetadataList().OfType<IntegrationModuleMetadata>()
			where m.Type == EntityMetadataType.Interface
			select m).ToList();
		ICriteria val = sessionProvider.GetSession("").CreateCriteria(InterfaceActivator.TypeOf<IIntegrationModuleHeader>());
		val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property("IntegrationModuleTyeUid") });
		IList<Guid> source = val.List<Guid>();
		foreach (IntegrationModuleMetadata module in list)
		{
			if (!source.Any((Guid a) => a == module.Uid))
			{
				InstanceOf<IIntegrationModuleHeader> instanceOf = new InstanceOf<IIntegrationModuleHeader>();
				instanceOf.New.IntegrationModuleTyeUid = module.Uid;
				instanceOf.New.Name = module.DisplayName;
				instanceOf.New.Save();
			}
		}
	}

	public void Terminating()
	{
	}
}
