using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UIBuilder.Web.Models;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.UIBuilder.Web.Service;

[Component]
[Uid("{A2497C1B-9665-476D-834F-5B9385DEC6C2}")]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
internal sealed class DataClassMetadataService : IDataClassMetadataService, IInternalAPIWebService
{
	public const string GuidS = "{A2497C1B-9665-476D-834F-5B9385DEC6C2}";

	public Guid GetComponentHeaderUid(SearchComponentHeaderRequest model)
	{
		IEnumerable<ModuleMetadataItem> lastPublished = ModuleMetadataItemManager.Instance.GetLastPublished(model.RuntimeModel.RuntimeModules.Select((ItemRuntimeModel m) => m.HeaderUid));
		Guid result = Guid.Empty;
		foreach (ModuleMetadataItem item in lastPublished)
		{
			if (!(item.Metadata is ModuleInfoMetadata moduleInfoMetadata))
			{
				continue;
			}
			foreach (ComponentMetadata component in moduleInfoMetadata.Components)
			{
				if (component.ImplementationForms.Count == 0 || !component.ImplementationForms.Any((ImplementationForm i) => i.MetadataUid == model.DataClassUid && i.ViewType == (ViewType)model.ViewType))
				{
					continue;
				}
				result = component.Uid;
				break;
			}
		}
		return result;
	}
}
