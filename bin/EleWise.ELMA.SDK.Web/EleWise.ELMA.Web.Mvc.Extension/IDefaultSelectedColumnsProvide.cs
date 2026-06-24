using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IDefaultSelectedColumnsProvider
{
	Type EntityType { get; }

	List<KeyValuePair<PropertyMetadata, EntityMetadata>> GetProperties();
}
