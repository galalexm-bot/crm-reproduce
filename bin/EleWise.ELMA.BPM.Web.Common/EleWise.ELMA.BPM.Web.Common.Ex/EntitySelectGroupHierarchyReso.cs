using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[Component(Order = 10)]
internal sealed class EntitySelectGroupHierarchyResolver : IEntitySelectGroupResolver
{
	public bool CheckType(Guid typeUid)
	{
		EntityMetadata metadata = MetadataLoader.LoadMetadata(typeUid) as EntityMetadata;
		return IsGroupMetadata(metadata);
	}

	public IEnumerable<EntitySelectGroup> GetGroups(Guid typeUid, IEnumerable<IEntity> entities)
	{
		Dictionary<IEntity, EntitySelectGroup> groups = new Dictionary<IEntity, EntitySelectGroup>();
		EntityMetadata metadata = MetadataLoader.LoadMetadata(typeUid) as EntityMetadata;
		if (!IsGroupMetadata(metadata))
		{
			return groups.Select((KeyValuePair<IEntity, EntitySelectGroup> g) => g.Value).ToList();
		}
		foreach (KeyValuePair<IEntity, List<IEntity>> group in (from k in entities
			group k by k.GetPropertyValue(metadata.ParentPropertyUid) as IEntity into k
			where k.Key != null
			select k).ToDictionary((IGrouping<IEntity, IEntity> k) => k.Key, (IGrouping<IEntity, IEntity> v) => v.ToList()))
		{
			EntitySelectGroup value = new EntitySelectGroup
			{
				Id = group.Key.GetId().ToString(),
				Header = group.Key.GetTitleOrDefault(),
				ShowHeader = true,
				ShowOnTop = false,
				Entities = group.Value,
				GetParent = () => (!(group.Key.GetPropertyValue(metadata.ParentPropertyUid) is IEntity key) || !groups.ContainsKey(key)) ? null : groups[key]
			};
			groups.Add(group.Key, value);
		}
		Dictionary<EntitySelectGroup, List<KeyValuePair<IEntity, EntitySelectGroup>>> dictionary = (from g in groups
			group g by GetRoot(g.Value)).ToDictionary((IGrouping<EntitySelectGroup, KeyValuePair<IEntity, EntitySelectGroup>> k) => k.Key, (IGrouping<EntitySelectGroup, KeyValuePair<IEntity, EntitySelectGroup>> v) => v.ToList());
		List<EntitySelectGroup> list = new List<EntitySelectGroup>();
		foreach (KeyValuePair<EntitySelectGroup, List<KeyValuePair<IEntity, EntitySelectGroup>>> item in dictionary)
		{
			list.AddRange(from v in item.Value
				select v.Value into g
				orderby g.Level
				select g);
		}
		return list;
	}

	private EntitySelectGroup GetRoot(EntitySelectGroup current)
	{
		EntitySelectGroup entitySelectGroup = current.GetParent();
		if (entitySelectGroup == null)
		{
			return current;
		}
		return GetRoot(entitySelectGroup);
	}

	private bool IsGroupMetadata(EntityMetadata metadata)
	{
		if (metadata != null && metadata.Hierarchical && metadata.HierarchyType == HierarchyType.GroupAndElements)
		{
			return metadata.IsGroupPropertyUid != Guid.Empty;
		}
		return false;
	}
}
