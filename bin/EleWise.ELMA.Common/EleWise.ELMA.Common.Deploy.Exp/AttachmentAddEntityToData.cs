using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Common.Deploy.Export.ExtensionPoints;

[Component(Type = ComponentType.Server)]
public class AttachmentAddEntityToData : IAddEntityToData
{
	private List<IEntity> ForeachProperties(EntityMetadata mdE, IEntity entity)
	{
		List<IEntity> list = new List<IEntity>();
		if (entity != null)
		{
			foreach (TablePartMetadata tablePart in mdE.TableParts)
			{
				if (!(entity.GetPropertyValue(tablePart.TablePartPropertyUid) is IEnumerable enumerable))
				{
					continue;
				}
				foreach (IEntity item2 in enumerable)
				{
					list.AddRange(ForeachProperties(tablePart, item2));
				}
			}
			{
				foreach (PropertyMetadata property in mdE.Properties)
				{
					if (!(property.TypeUid == new Guid("72ED98CA-F260-4671-9BCD-FF1D80235F47")) || !(property.SubTypeUid == new Guid("3536c931-154c-4618-93b8-4e35bd8db226")))
					{
						continue;
					}
					PropertyInfo propertyCached = entity.GetType().GetPropertyCached(property.Name);
					EntitySettings entitySettings = property.Settings as EntitySettings;
					if (entitySettings != null && entitySettings.RelationType == RelationType.OneToOne && propertyCached.GetValue(entity, null) is IAttachment item)
					{
						list.Add(item);
					}
					if (entitySettings == null || entitySettings.RelationType != RelationType.ManyToMany)
					{
						continue;
					}
					object value = propertyCached.GetValue(entity, null);
					if (value == null)
					{
						continue;
					}
					foreach (object item3 in (IEnumerable)value)
					{
						if (item3 is IAttachment)
						{
							list.Add(item3 as IAttachment);
						}
					}
				}
				return list;
			}
		}
		return list;
	}

	public List<IEntity> AddEntities(ClassMetadata metadata, IEntity entity)
	{
		List<IEntity> list = new List<IEntity>();
		EntityMetadata entityMetadata = metadata as EntityMetadata;
		if (entity != null && entityMetadata != null)
		{
			list.AddRange(ForeachProperties(entityMetadata, entity));
		}
		return list;
	}
}
