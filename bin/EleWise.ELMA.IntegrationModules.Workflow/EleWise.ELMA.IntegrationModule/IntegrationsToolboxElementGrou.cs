using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.IntegrationModules.Managers;
using EleWise.ELMA.IntegrationModules.Metadata;
using EleWise.ELMA.IntegrationModules.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.IntegrationModules.Workflow.BPMN.Diagrams.Shapes;
using EleWise.ELMA.IntegrationModules.Workflow.BPMN.Diagrams.Toolbox;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Toolbox;

namespace EleWise.ELMA.IntegrationModules.Workflow.Components;

[Component]
internal class IntegrationsToolboxElementGroup : IToolboxElementGroup
{
	private IntegrationModuleHeaderManager integrtionModuleHeaderManager;

	public IntegrationsToolboxElementGroup(IntegrationModuleHeaderManager integrtionModuleHeaderManager)
	{
		this.integrtionModuleHeaderManager = integrtionModuleHeaderManager;
	}

	public ICollection<ToolboxElement> GetElements()
	{
		IEnumerable<IntegrationModuleMetadata> integrationModuleMetadataList = integrtionModuleHeaderManager.GetIntegrationModuleMetadataList(true);
		List<ToolboxElement> list = new List<ToolboxElement>();
		foreach (IntegrationModuleMetadata item in integrationModuleMetadataList)
		{
			foreach (Guid item2 in item.IntegrationModuleActivity)
			{
				if (MetadataLoader.LoadMetadata(item2, inherit: false, loadImplementation: false) is IntegrationModuleActivityMetadata integrationModuleActivityMetadata)
				{
					IntegrationModuleElement.ToolboxItem toolboxItem = new IntegrationModuleElement.ToolboxItem(integrationModuleActivityMetadata.DisplayName, item.Uid, null);
					IntegrationModuleElement element = new IntegrationModuleElement
					{
						Name = integrationModuleActivityMetadata.DisplayName,
						ActivityUid = integrationModuleActivityMetadata.Uid,
						IntegrationModuleHeaderMetadataUid = item.Uid
					};
					IntegrationModuleShape shape = new IntegrationModuleShape();
					list.Add(new ToolboxElement
					{
						ToolboxItem = toolboxItem,
						Element = element,
						Shape = shape,
						ElementTypeUid = item2
					});
				}
			}
		}
		return list;
	}

	public ICollection<IBPMNToolboxItemGroup> GetGroups()
	{
		IEnumerable<IntegrationModuleMetadata> integrationModuleMetadataList = integrtionModuleHeaderManager.GetIntegrationModuleMetadataList(true);
		List<IBPMNToolboxItemGroup> list = new List<IBPMNToolboxItemGroup>();
		foreach (IntegrationModuleMetadata item2 in integrationModuleMetadataList)
		{
			IntegrationModulesGroup item = new IntegrationModulesGroup(item2.Uid, Guid.Empty, item2.DisplayName);
			list.Add(item);
		}
		return list;
	}
}
