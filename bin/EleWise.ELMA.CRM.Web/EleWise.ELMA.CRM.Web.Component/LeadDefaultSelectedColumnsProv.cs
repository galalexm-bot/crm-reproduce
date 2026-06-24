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
public class LeadDefaultSelectedColumnsProvider : IDefaultSelectedColumnsProvider
{
	public Type EntityType => typeof(ILead);

	public List<KeyValuePair<PropertyMetadata, EntityMetadata>> GetProperties()
	{
		List<KeyValuePair<PropertyMetadata, EntityMetadata>> list = new List<KeyValuePair<PropertyMetadata, EntityMetadata>>();
		EntityMetadata entityMetadata = (EntityMetadata)InterfaceActivator.LoadMetadata<ILead>();
		PropertyMetadata propertyMetadata = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "Responsible");
		if (propertyMetadata != null)
		{
			list.Add(new KeyValuePair<PropertyMetadata, EntityMetadata>(propertyMetadata, entityMetadata));
		}
		PropertyMetadata propertyMetadata2 = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "MarketingGroup");
		if (propertyMetadata2 != null)
		{
			list.Add(new KeyValuePair<PropertyMetadata, EntityMetadata>(propertyMetadata, entityMetadata));
		}
		PropertyMetadata propertyMetadata3 = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "MarketingActivity");
		if (propertyMetadata3 != null)
		{
			list.Add(new KeyValuePair<PropertyMetadata, EntityMetadata>(propertyMetadata2, entityMetadata));
		}
		if (entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "MarketingEffect") != null)
		{
			list.Add(new KeyValuePair<PropertyMetadata, EntityMetadata>(propertyMetadata3, entityMetadata));
		}
		return list;
	}
}
