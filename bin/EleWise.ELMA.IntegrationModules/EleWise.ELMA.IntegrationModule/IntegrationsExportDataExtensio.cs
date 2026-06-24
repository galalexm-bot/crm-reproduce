using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.Entities;
using EleWise.ELMA.IntegrationModules.Metadata;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.IntegrationModules.Deplpoy.Import;

[Component(Order = 900)]
internal sealed class IntegrationsExportDataExtension : EntitiesExport
{
	public override bool CheckMetadata(IMetadata metadata)
	{
		return metadata is IntegrationModuleMetadata;
	}

	protected override IEntityFilter GetFilter()
	{
		IIntegrationModuleFilter integrationModuleFilter = InterfaceActivator.Create<IIntegrationModuleFilter>();
		integrationModuleFilter.IsTemplate = true;
		return integrationModuleFilter;
	}
}
