using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Providers.Components;

[Component(Order = 100000)]
internal class ReferenceOnEntityMapPropertyExtension : MapPropertyExtensionBase
{
	public override bool Can(PropertyMetadata propertyMetadata)
	{
		return propertyMetadata.Settings is ReferenceOnEntitySettings;
	}

	public override MapPropertyInfo CreatePropertyInfo(PropertyMetadata propertyMetadata, string tableName, bool isKey)
	{
		ReferenceOnEntitySettings referenceOnEntitySettings = (ReferenceOnEntitySettings)propertyMetadata.Settings;
		return new MapPropertyInfo(propertyMetadata, new List<string>
		{
			GenerateObjectIdName(referenceOnEntitySettings.FieldName),
			ReferenceOnEntityNHType.GenerateObjectTypeName(referenceOnEntitySettings.FieldName)
		}, isKey, tableName, this);
	}

	public override void SetValue(PropertyValue propertyValue, object value, SetPropertyInfo mapSettings)
	{
		ReferenceOnEntity referenceOnEntity = value as ReferenceOnEntity;
		ObjectId objectId = null;
		Guid? guid = null;
		if (referenceOnEntity != null)
		{
			objectId = new ObjectId(ModelHelper.GetEntityType(referenceOnEntity.ObjectTypeUId));
			guid = referenceOnEntity.ObjectTypeUId;
			Type objectType = referenceOnEntity.ObjectType;
			Guid objectUid = referenceOnEntity.ObjectUid;
			if (objectUid != Guid.Empty && MetadataLoader.LoadMetadata(objectType) is EntityMetadata entityMetadata)
			{
				EntityPropertyMetadata uidProperty = entityMetadata.GetUidProperty();
				if (uidProperty != null)
				{
					MapObject mapObject = mapSettings.FindObject(objectType, new Dictionary<string, object> { { uidProperty.Name, objectUid } });
					if (mapObject != null)
					{
						objectId.SetDelegate(mapObject);
					}
				}
			}
		}
		ReferenceOnEntitySettings referenceOnEntitySettings = (ReferenceOnEntitySettings)propertyValue.PropertyInfo.PropertyMetadata.Settings;
		propertyValue.Columns[GenerateObjectIdName(referenceOnEntitySettings.FieldName)] = objectId;
		propertyValue.Columns[ReferenceOnEntityNHType.GenerateObjectTypeName(referenceOnEntitySettings.FieldName)] = guid;
	}

	public override Type GetPropertyDbType(PropertyMetadata propertyMetadata)
	{
		return typeof(object);
	}

	private string GenerateObjectIdName(string columnName)
	{
		return "@" + ReferenceOnEntityNHType.GenerateObjectIdName(columnName);
	}
}
