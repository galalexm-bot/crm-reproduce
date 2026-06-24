using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Messages.API.Feed.Models;

[DataContract(Name = "EntityHeader", Namespace = "http://www.elma-bpm.ru/api/")]
public class EntityHeader
{
	public const string TypeName = "EntityHeader";

	[DataMember]
	public Guid TypeUid;

	[DataMember]
	public string Id;

	[DataMember]
	public Guid? Uid;

	[DataMember]
	public string Name;

	public IEntity ToEntity()
	{
		if (TypeUid == Guid.Empty)
		{
			throw new InvalidDataContractException("TypeUid must be set for EntityHeader reference properties");
		}
		IEntityManager entityManagerOrNull = ModelHelper.GetEntityManagerOrNull(ModelHelper.GetEntityType(TypeUid));
		object obj = null;
		if (Id.IsNullOrWhiteSpace() && Uid.HasValue && Uid.Value != Guid.Empty)
		{
			obj = entityManagerOrNull?.LoadOrNull(Uid.Value);
		}
		if (obj == null && long.TryParse(Id, out var result))
		{
			obj = entityManagerOrNull?.LoadOrNull(result);
		}
		if (obj == null)
		{
			throw new InvalidDataContractException("Deserialized Entity on reference property cannot be null");
		}
		return obj as IEntity;
	}

	public static EntityHeader FromEntity(IEntity entity)
	{
		if (entity != null)
		{
			if (MetadataLoader.LoadMetadata(entity.CastAsRealType().GetType()) is EntityMetadata entityMetadata)
			{
				EntityHeader entityHeader = new EntityHeader
				{
					Id = entity.GetId().ToString(),
					TypeUid = entityMetadata.Uid,
					Name = entity.ToString()
				};
				EntityPropertyMetadata uidProperty = entityMetadata.GetUidProperty();
				if (uidProperty != null)
				{
					entityHeader.Uid = entity.GetPropertyValue<Guid>(uidProperty.Uid);
				}
				return entityHeader;
			}
			throw new InvalidDataContractException($"Entity of type {entity.GetType()} must have EntityMetadata");
		}
		return null;
	}
}
