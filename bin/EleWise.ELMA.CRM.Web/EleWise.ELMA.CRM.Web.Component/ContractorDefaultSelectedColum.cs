using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class ContractorDefaultSelectedColumnsProvider : IDefaultSelectedColumnsProvider
{
	public Type EntityType => typeof(IContractor);

	public List<KeyValuePair<PropertyMetadata, EntityMetadata>> GetProperties()
	{
		List<KeyValuePair<PropertyMetadata, EntityMetadata>> list = new List<KeyValuePair<PropertyMetadata, EntityMetadata>>();
		EntityMetadata entityMetadata = (EntityMetadata)InterfaceActivator.LoadMetadata<IContractor>();
		PropertyMetadata propertyMetadata = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "MarketingGroup");
		if (propertyMetadata != null)
		{
			list.Add(new KeyValuePair<PropertyMetadata, EntityMetadata>(propertyMetadata, entityMetadata));
		}
		PropertyMetadata propertyMetadata2 = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "MarketingActivity");
		if (propertyMetadata2 != null)
		{
			list.Add(new KeyValuePair<PropertyMetadata, EntityMetadata>(propertyMetadata2, entityMetadata));
		}
		PropertyMetadata propertyMetadata3 = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "MarketingEffect");
		if (propertyMetadata3 != null)
		{
			list.Add(new KeyValuePair<PropertyMetadata, EntityMetadata>(propertyMetadata3, entityMetadata));
		}
		return list;
	}
}
