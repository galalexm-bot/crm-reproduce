using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Export.Components;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.IntegrationModules.Constants;
using EleWise.ELMA.IntegrationModules.Managers;
using EleWise.ELMA.IntegrationModules.Metadata;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.IntegrationModules.Deplpoy.Export;

[Component(Order = 1000)]
internal sealed class IntegrationsExportExtension : MetadataConfigurationExportExtension
{
	private ExportRuleBuilder<IIntegrationModuleHeader> customExportRuleBuilderIh = new ExportRuleBuilder<IIntegrationModuleHeader>(new ExportRuleList());

	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	public IntegrationModuleHeaderManager IntegrationModuleHeaderManager { get; set; }

	public override void AddExportObjects(ExportExtensionParams parameters)
	{
		AddExportObjectsCustom(parameters.Parameters, parameters.Objects, parameters.ServiceData, parameters.PacketMetadatas);
	}

	public override Dictionary<Guid, object> GetNewSettingObj()
	{
		return new Dictionary<Guid, object> { 
		{
			IntegrationsConstants.ExportExtensionUid,
			new IntegrationsExportSettings()
		} };
	}

	private void AddExportObjectsCustom(Dictionary<Guid, object> parameters, Dictionary<IGroupedMetadata, bool> objects, Dictionary<string, object> serviceData, List<PacketMetadata> packetMetadatas)
	{
		if (!(parameters[IntegrationsConstants.ExportExtensionUid] is IntegrationsExportSettings integrationsExportSettings))
		{
			return;
		}
		SerializableDictionary<Guid, bool> integrations = integrationsExportSettings.Integrations;
		if (integrations == null)
		{
			return;
		}
		foreach (KeyValuePair<Guid, bool> item in integrations)
		{
			IntegrationModuleMetadata integrationModuleMetadata = MetadataRuntimeService.GetMetadata(item.Key, loadImplementation: false) as IntegrationModuleMetadata;
			if (integrationModuleMetadata != null)
			{
				foreach (Guid item2 in integrationModuleMetadata.IntegrationModuleActivity)
				{
					IMetadata metadata = MetadataRuntimeService.GetMetadata(item2, loadImplementation: false);
					CreatePacket(metadata, serviceData, packetMetadatas, objects, withData: false);
				}
			}
			CreatePacket(integrationModuleMetadata, serviceData, packetMetadatas, objects, item.Value);
		}
	}

	private void CreatePacket(IMetadata md, Dictionary<string, object> serviceData, List<PacketMetadata> packetMetadatas, IDictionary<IGroupedMetadata, bool> objects, bool withData)
	{
		IGroupedMetadata groupedMetadata = md as IGroupedMetadata;
		ClassMetadata classMetadata = md as ClassMetadata;
		if (md == null || groupedMetadata == null || classMetadata == null)
		{
			return;
		}
		if (withData)
		{
			if (objects.ContainsKey(groupedMetadata))
			{
				objects[groupedMetadata] = true;
			}
			else
			{
				objects.Add(groupedMetadata, value: true);
			}
		}
		PacketMetadata item = CreatePacketMetadata(md, serviceData);
		packetMetadatas.Add(item);
	}

	private List<IEntity> GetEntities(IIntegrationModuleHeader header)
	{
		ExportHelperBuilder<IIntegrationModuleHeader> exportHelperBuilder = ExportHelperBuilder.Create(header);
		exportHelperBuilder.ExportRuleList = customExportRuleBuilderIh.ExportRules;
		return exportHelperBuilder.EntityExportList();
	}

	protected override void AddInfoForUserMetadata(PacketMetadata packetMetadata, IMetadata metadata, Dictionary<string, object> serviceData)
	{
		if (!(metadata is IntegrationModuleMetadata))
		{
			return;
		}
		List<IIntegrationModuleHeader> list = IntegrationModuleHeaderManager.Find((IIntegrationModuleHeader h) => h.IntegrationModuleTyeUid == metadata.Uid).ToList();
		if (list == null || !list.Any() || list[0] == null)
		{
			return;
		}
		IIntegrationModuleHeader integrationModuleHeader = list[0];
		foreach (IEntity entity in GetEntities(integrationModuleHeader))
		{
			packetMetadata.SubEntitiesAfter.Add(entity, null);
		}
		if (integrationModuleHeader.Group != null)
		{
			string key = $"IntegrationGroupForIntegrationHeader_{integrationModuleHeader.Uid.ToString().ToLower()}_{integrationModuleHeader.Group.Uid.ToString().ToLower()}";
			if (!serviceData.ContainsKey(key))
			{
				serviceData.Add(key, integrationModuleHeader.Group.Name);
			}
		}
	}
}
