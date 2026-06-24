using System.Collections.Generic;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Providers.Components;

[Component(Order = 90000)]
internal class RelationEntityMapPropertyExtension : MapPropertyExtensionBase
{
	public override bool Can(PropertyMetadata propertyMetadata)
	{
		if (propertyMetadata.Settings is EntitySettings entitySettings)
		{
			return entitySettings.RelationType == RelationType.ManyToMany;
		}
		return false;
	}

	public override MapPropertyInfo CreatePropertyInfo(PropertyMetadata propertyMetadata, string tableName, bool isKey)
	{
		EntitySettings entitySettings = (EntitySettings)propertyMetadata.Settings;
		return new MapPropertyInfo(propertyMetadata, new List<string>
		{
			GenerateObjectIdName(entitySettings.ParentColumnName),
			GenerateObjectIdName(entitySettings.ChildColumnName)
		}, isImportKey: false, entitySettings.RelationTableName, this)
		{
			IsRelations = true
		};
	}

	public override void SetValue(PropertyValue propertyValue, object value, SetPropertyInfo mapSettings)
	{
		if (value is MapRelationManyToMany mapRelationManyToMany)
		{
			EntitySettings entitySettings = (EntitySettings)propertyValue.PropertyInfo.PropertyMetadata.Settings;
			propertyValue.Columns[GenerateObjectIdName(entitySettings.ParentColumnName)] = mapRelationManyToMany.Relation.TargetObject;
			propertyValue.Columns[GenerateObjectIdName(entitySettings.ChildColumnName)] = mapRelationManyToMany.Objects;
		}
		else
		{
			base.SetValue(propertyValue, value, mapSettings);
		}
	}

	private string GenerateObjectIdName(string columnName)
	{
		return "@" + columnName;
	}
}
