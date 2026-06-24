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
public class DmsObjectDefaultSelectedColumnsProvider : IDefaultSelectedColumnsProvider
{
	public Type EntityType => typeof(IDmsObject);

	public List<KeyValuePair<PropertyMetadata, EntityMetadata>> GetProperties()
	{
		EntityMetadata metadata = (EntityMetadata)InterfaceActivator.LoadMetadata<IDmsObject>();
		return (from p in metadata.Properties
			where p.Name != "Permissions"
			select new KeyValuePair<PropertyMetadata, EntityMetadata>(p, metadata)).ToList();
	}
}
