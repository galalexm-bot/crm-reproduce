using System;
using System.Collections.Generic;
using System.IO;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Providers;

public class MapPropertyExtensionBase : IMapPropertyExtension
{
	public virtual bool Can(PropertyMetadata propertyMetadata)
	{
		return propertyMetadata.Settings is SimpleTypeSettings;
	}

	public virtual MapPropertyInfo CreatePropertyInfo(PropertyMetadata propertyMetadata, string tableName, bool isKey)
	{
		SimpleTypeSettings simpleTypeSettings = (SimpleTypeSettings)propertyMetadata.Settings;
		List<string> list = new List<string>();
		if (!string.IsNullOrEmpty(simpleTypeSettings.FieldName))
		{
			list.Add(simpleTypeSettings.FieldName);
		}
		if (isKey && propertyMetadata.TypeUid == StringDescriptor.UID && ((StringSettings)simpleTypeSettings).MaxValueString == null)
		{
			using BulkDataImportLogger bulkDataImportLogger = new BulkDataImportLogger("BulkDataImport", "CreatePropertyInfo");
			bulkDataImportLogger.Warn(SR.T("Ключевое поле для свойства {0} таблицы {1} является строковым полем неограниченной длины. Поиск по таким полям может замедлить импорт", propertyMetadata.Name, tableName));
		}
		return new MapPropertyInfo(propertyMetadata, list, isKey, tableName, this);
	}

	public virtual Type GetPropertyDbType(PropertyMetadata propertyMetadata)
	{
		if (propertyMetadata == null)
		{
			return typeof(object);
		}
		ITypeDescriptor typeDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(propertyMetadata.TypeUid, propertyMetadata.SubTypeUid);
		if (typeDescriptor is ListOfSimpleTypeDescriptor)
		{
			return typeof(byte[]);
		}
		if (!(typeDescriptor is IRuntimeTypeDescriptor runtimeTypeDescriptor))
		{
			return typeof(object);
		}
		return runtimeTypeDescriptor.RuntimeType;
	}

	public virtual void SetValue(PropertyValue propertyValue, object value, SetPropertyInfo mapSettings)
	{
		SimpleTypeSettings simpleTypeSettings = (SimpleTypeSettings)propertyValue.PropertyInfo.PropertyMetadata.Settings;
		if (MetadataServiceContext.Service.GetTypeDescriptor(propertyValue.PropertyInfo.PropertyMetadata.TypeUid, propertyValue.PropertyInfo.PropertyMetadata.SubTypeUid) is ListOfSimpleTypeDescriptor)
		{
			value = listOfSimpleTypeSerialize(value, propertyValue);
		}
		if (!string.IsNullOrEmpty(simpleTypeSettings.FieldName) && propertyValue.Columns.ContainsKey(simpleTypeSettings.FieldName))
		{
			propertyValue.Columns[simpleTypeSettings.FieldName] = value;
		}
	}

	private object listOfSimpleTypeSerialize(object value, PropertyValue propertyValue)
	{
		if (value != null)
		{
			string value2 = ClassSerializationHelper.SerializeObjectByXml(value);
			using MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
			using StreamWriter streamWriter = new StreamWriter(memoryStream);
			streamWriter.WriteLine(value.GetType().AssemblyQualifiedName);
			streamWriter.Write(value2);
			streamWriter.Flush();
			return memoryStream.ToArray();
		}
		return DBNull.Value;
	}
}
