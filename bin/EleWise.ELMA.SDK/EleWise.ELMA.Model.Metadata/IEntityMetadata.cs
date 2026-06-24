using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Model.Metadata;

public interface IEntityMetadata : IRootMetadata, IMetadata, IXsiType, ICodeItemMetadata, IGroupedMetadata
{
	bool Hierarchical { get; }

	HierarchyType HierarchyType { get; }

	Guid IsGroupPropertyUid { get; }

	Guid ParentPropertyUid { get; }

	IEnumerable<IPropertyMetadata> GetPropertiesAndTableParts();
}
