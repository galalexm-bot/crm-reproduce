using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Documents.Web.Components;

[Component]
public class DocumentReferenceDefaultSelectedColumnsProvider : IDefaultSelectedColumnsProvider
{
	public Type EntityType => typeof(IDocumentReference);

	public List<KeyValuePair<PropertyMetadata, EntityMetadata>> GetProperties()
	{
		List<KeyValuePair<PropertyMetadata, EntityMetadata>> list = new List<KeyValuePair<PropertyMetadata, EntityMetadata>>();
		EntityMetadata entityMetadata = (EntityMetadata)InterfaceActivator.LoadMetadata<IDocumentReference>();
		PropertyMetadata propertyMetadata = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "Reference");
		if (propertyMetadata != null)
		{
			list.Add(new KeyValuePair<PropertyMetadata, EntityMetadata>(propertyMetadata, entityMetadata));
		}
		return list;
	}
}
