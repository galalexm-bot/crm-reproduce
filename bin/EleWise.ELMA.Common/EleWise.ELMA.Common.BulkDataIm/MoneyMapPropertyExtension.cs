using System;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Providers.Components;

[Component]
internal class MoneyMapPropertyExtension : MapPropertyExtensionBase
{
	public override bool Can(PropertyMetadata propertyMetadata)
	{
		return propertyMetadata.Settings is MoneySettings;
	}

	public override Type GetPropertyDbType(PropertyMetadata propertyMetadata)
	{
		return typeof(double);
	}

	public override void SetValue(PropertyValue propertyValue, object value, SetPropertyInfo mapSettings)
	{
		SimpleTypeSettings simpleTypeSettings = (SimpleTypeSettings)propertyValue.PropertyInfo.PropertyMetadata.Settings;
		Money? money = value as Money?;
		if (money.HasValue)
		{
			propertyValue.Columns[simpleTypeSettings.FieldName] = money.Value.Value;
		}
		else
		{
			propertyValue.Columns[simpleTypeSettings.FieldName] = value;
		}
	}
}
