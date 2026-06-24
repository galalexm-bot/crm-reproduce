using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[Component(Order = 10)]
internal sealed class EntitySelectorHierarchyGroupsResolver : IEntitySelectResolver
{
	public bool CheckType(Guid typeUid)
	{
		if (!EntitySelectGroupResolverHelper.SortGroupsWithEntitiesEnabled())
		{
			return false;
		}
		EntityMetadata metadata = MetadataLoader.LoadMetadata(typeUid) as EntityMetadata;
		return IsGroupAndElementsMetadata(metadata);
	}

	public IEnumerable<EntitySelectModel> GetItems(Guid typeUid, IEnumerable<IEntity> entities)
	{
		List<EntitySelectModel> list = new List<EntitySelectModel>();
		EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(typeUid) as EntityMetadata;
		if (!IsGroupAndElementsMetadata(entityMetadata))
		{
			return Enumerable.Empty<EntitySelectModel>();
		}
		foreach (IEntity item2 in entities.OrderBy((IEntity e) => GetTitle(e)))
		{
			EntitySelectModel item = CreateModel(item2, entityMetadata.ParentPropertyUid);
			list.Add(item);
		}
		return list;
	}

	private string GetTitle(IEntity entity)
	{
		string text = entity.ToString();
		if (text.IsNullOrEmpty())
		{
			return SR.Untitled;
		}
		return text;
	}

	private EntitySelectModel CreateModel(IEntity entity, Guid parentPropertyUid)
	{
		return new EntitySelectModel
		{
			Entity = entity,
			Priority = 10,
			GetParent = () => (!(entity.GetPropertyValue(parentPropertyUid) is IEntity entity2)) ? null : CreateModel(entity2, parentPropertyUid)
		};
	}

	private bool IsGroupAndElementsMetadata(EntityMetadata metadata)
	{
		if (metadata != null && metadata.Hierarchical && metadata.HierarchyType == HierarchyType.GroupAndElements)
		{
			return metadata.ParentPropertyUid != Guid.Empty;
		}
		return false;
	}
}
