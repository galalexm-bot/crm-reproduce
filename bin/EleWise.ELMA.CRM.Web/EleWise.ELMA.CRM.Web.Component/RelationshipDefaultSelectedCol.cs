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
public class RelationshipDefaultSelectedColumnsProvider : IDefaultSelectedColumnsProvider
{
	public Type EntityType => typeof(IRelationship);

	public List<KeyValuePair<PropertyMetadata, EntityMetadata>> GetProperties()
	{
		List<KeyValuePair<PropertyMetadata, EntityMetadata>> list = new List<KeyValuePair<PropertyMetadata, EntityMetadata>>();
		EntityMetadata entityMetadata = (EntityMetadata)InterfaceActivator.LoadMetadata<IRelationship>();
		PropertyMetadata propertyMetadata = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "Completed");
		if (propertyMetadata != null)
		{
			list.Add(new KeyValuePair<PropertyMetadata, EntityMetadata>(propertyMetadata, entityMetadata));
		}
		PropertyMetadata propertyMetadata2 = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "EndDate");
		if (propertyMetadata2 != null)
		{
			list.Add(new KeyValuePair<PropertyMetadata, EntityMetadata>(propertyMetadata2, entityMetadata));
		}
		PropertyMetadata propertyMetadata3 = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "DoneDate");
		if (propertyMetadata3 != null)
		{
			list.Add(new KeyValuePair<PropertyMetadata, EntityMetadata>(propertyMetadata3, entityMetadata));
		}
		PropertyMetadata propertyMetadata4 = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "Comments");
		if (propertyMetadata4 != null)
		{
			list.Add(new KeyValuePair<PropertyMetadata, EntityMetadata>(propertyMetadata4, entityMetadata));
		}
		return list;
	}
}
