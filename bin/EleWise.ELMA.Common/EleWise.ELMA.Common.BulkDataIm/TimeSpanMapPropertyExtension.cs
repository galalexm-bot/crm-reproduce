using System;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Providers.Components;

[Component]
internal class TimeSpanMapPropertyExtension : MapPropertyExtensionBase
{
	public override bool Can(PropertyMetadata propertyMetadata)
	{
		return propertyMetadata.Settings is TimeSpanSettings;
	}

	public override Type GetPropertyDbType(PropertyMetadata propertyMetadata)
	{
		return typeof(long);
	}

	public override void SetValue(PropertyValue propertyValue, object value, SetPropertyInfo mapSettings)
	{
		SimpleTypeSettings simpleTypeSettings = (SimpleTypeSettings)propertyValue.PropertyInfo.PropertyMetadata.Settings;
		TimeSpan? timeSpan = value as TimeSpan?;
		if (timeSpan.HasValue)
		{
			propertyValue.Columns[simpleTypeSettings.FieldName] = timeSpan.Value.Ticks;
		}
		else
		{
			propertyValue.Columns[simpleTypeSettings.FieldName] = value;
		}
	}
}
