using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Model.Metadata;

public interface ITablePartMetadata : IPropertyMetadata, INamedMetadata, IOrderedMetadata, IMetadata, IXsiType
{
	new string Name { get; set; }

	Guid ParentPropertyUid { get; set; }

	Guid TablePartPropertyUid { get; set; }

	List<PropertyMetadata> Properties { get; set; }

	string TablePartPropertyName { get; set; }

	string OnViewLoadScriptName { get; set; }
}
