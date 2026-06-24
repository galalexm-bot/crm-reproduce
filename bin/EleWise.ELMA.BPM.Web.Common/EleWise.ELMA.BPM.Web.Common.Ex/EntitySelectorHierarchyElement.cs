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
internal sealed class EntitySelectorHierarchyElementResolver : IEntitySelectResolver
{
	public bool CheckType(Guid typeUid)
	{
		EntityMetadata metadata = MetadataLoader.LoadMetadata(typeUid) as EntityMetadata;
		return IsElementMetadata(metadata);
	}

	public IEnumerable<EntitySelectModel> GetItems(Guid typeUid, IEnumerable<IEntity> entities)
	{
		Dictionary<IEntity, EntitySelectModel> groups = new Dictionary<IEntity, EntitySelectModel>();
		EntityMetadata metadata = MetadataLoader.LoadMetadata(typeUid) as EntityMetadata;
		if (!IsElementMetadata(metadata))
		{
			return Enumerable.Empty<EntitySelectModel>();
		}
		foreach (IEntity entity in entities)
		{
			EntitySelectModel value = new EntitySelectModel
			{
				Entity = entity,
				Priority = 10,
				GetParent = () => (!(entity.GetPropertyValue(metadata.ParentPropertyUid) is IEntity key) || !groups.ContainsKey(key)) ? null : groups[key]
			};
			groups.Add(entity, value);
		}
		return BuildHierarchyList(null, groups.Select((KeyValuePair<IEntity, EntitySelectModel> g) => g.Value).ToList());
	}

	private IEnumerable<EntitySelectModel> BuildHierarchyList(EntitySelectModel current, IEnumerable<EntitySelectModel> list)
	{
		List<EntitySelectModel> list2 = new List<EntitySelectModel>();
		foreach (EntitySelectModel item in from item in list
			where item.GetParent() == current
			select item into g
			orderby g.Level
			select g)
		{
			list2.Add(item);
			list2.AddRange(BuildHierarchyList(item, list));
		}
		return list2;
	}

	private bool IsElementMetadata(EntityMetadata metadata)
	{
		if (metadata != null && metadata.Hierarchical && metadata.HierarchyType == HierarchyType.Elements)
		{
			return metadata.ParentPropertyUid != Guid.Empty;
		}
		return false;
	}
}
