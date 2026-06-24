using System;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Providers;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IMapPropertyExtension
{
	bool Can(PropertyMetadata propertyMetadata);

	MapPropertyInfo CreatePropertyInfo(PropertyMetadata propertyMetadata, string tableName, bool isKey);

	void SetValue(PropertyValue propertyValue, object value, SetPropertyInfo mapSettings);

	Type GetPropertyDbType(PropertyMetadata propertyMetadata);
}
