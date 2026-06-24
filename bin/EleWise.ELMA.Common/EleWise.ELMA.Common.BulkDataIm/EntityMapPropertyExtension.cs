using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Providers.Components;

[Component(Order = 100000)]
internal class EntityMapPropertyExtension : MapPropertyExtensionBase
{
	public override bool Can(PropertyMetadata propertyMetadata)
	{
		return propertyMetadata.Settings is EntitySettings;
	}

	public override MapPropertyInfo CreatePropertyInfo(PropertyMetadata propertyMetadata, string tableName, bool isKey)
	{
		MapPropertyInfo mapPropertyInfo = base.CreatePropertyInfo(propertyMetadata, tableName, isKey);
		if (mapPropertyInfo.Columns.Count > 0)
		{
			mapPropertyInfo.Columns[0] = GenerateReferenceColumnIdName(mapPropertyInfo.Columns[0]);
		}
		return mapPropertyInfo;
	}

	public override void SetValue(PropertyValue propertyValue, object value, SetPropertyInfo mapSettings)
	{
		EntitySettings entitySettings = (EntitySettings)propertyValue.PropertyInfo.PropertyMetadata.Settings;
		string key = GenerateReferenceColumnIdName(entitySettings.FieldName);
		if (!string.IsNullOrEmpty(entitySettings.FieldName) && propertyValue.Columns.ContainsKey(key))
		{
			IEntity entity = value as IEntity;
			propertyValue.Columns[key] = ((entity != null) ? new ObjectId(value.GetType())
			{
				Id = entity.GetId()
			} : ((value is ObjectId) ? value : null));
		}
	}

	private string GenerateReferenceColumnIdName(string columnName)
	{
		return "@" + columnName;
	}
}
