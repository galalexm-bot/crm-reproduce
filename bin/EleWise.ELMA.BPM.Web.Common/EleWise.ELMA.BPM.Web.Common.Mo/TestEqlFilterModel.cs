using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class TestEqlFilterModel : EntityModel<IEntity>
{
	public FilterModel Filter { get; set; }

	public string GridId { get; set; }

	public IEnumerable<EqlObject> GetObjects()
	{
		IEnumerable<IEntityMetadataSearcher> extensionPoints = ComponentManager.Current.GetExtensionPoints<IEntityMetadataSearcher>();
		HashSet<Guid> entity = new HashSet<Guid>();
		foreach (IEntityMetadataSearcher item in extensionPoints)
		{
			IEnumerable<EntityMetadata> entityMetadataList = item.GetEntityMetadataList();
			IEnumerable<EntityMetadata> entityMetadata = entityMetadataList.Where((EntityMetadata m) => m != null && (m.Type == EntityMetadataType.InterfaceImplementation || m.Type == EntityMetadataType.Entity) && m.ShowInTypeTree);
			yield return new EqlObject
			{
				DisplayName = item.DisplayName,
				Uid = default(Guid),
				IsObject = false
			};
			foreach (EntityMetadata item2 in entityMetadata.OrderBy((EntityMetadata o) => o.DisplayName))
			{
				if (entity.Add(item2.Uid) && !string.IsNullOrWhiteSpace(item2.DisplayName))
				{
					yield return new EqlObject
					{
						DisplayName = item2.DisplayName,
						Uid = item2.Uid,
						IsObject = true
					};
				}
			}
		}
	}
}
