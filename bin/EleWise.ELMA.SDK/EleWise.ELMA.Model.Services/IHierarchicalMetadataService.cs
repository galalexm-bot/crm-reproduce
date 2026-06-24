using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Model.Services;

[ExtensionPoint(ComponentType.All)]
public interface IHierarchicalMetadataService
{
	string ProcessingParentForForm(Guid propertyUid, Guid propertyTypeUid, Guid propertySubTypeUid, RelationType? relationType, EntityMetadata entityMd);

	List<KeyValuePair<string, int>> ProcessingChildsForForm(Guid propertyUid, Guid propertyTypeUid, Guid propertySubTypeUid, RelationType? relationType, EntityMetadata entityMd);

	Dictionary<Guid, string> CanBeParentForChild(Guid propertyUid, Guid propertyTypeUid, Guid propertySubTypeUid, RelationType? relationType, ClassMetadata entityMd);

	bool CanBeChild(Guid propertyTypeUid, Guid propertySubTypeUid, RelationType? relationType);

	Dictionary<Guid, string> CanBeParentForChild(PropertyMetadata propertyMetadata, ClassMetadata entityMd);

	bool CanBeChild(PropertyMetadata propertyMetadata);

	Dictionary<long, string> GetAllHierarchicalEntities(IEntityMetadata metadata, long? parentId, int indent, int deep);
}
