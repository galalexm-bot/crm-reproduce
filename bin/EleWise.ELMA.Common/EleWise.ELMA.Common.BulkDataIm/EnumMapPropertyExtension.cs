using System;
using System.Data;
using System.Linq;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Providers.Components;

[Component(Order = 100000)]
internal class EnumMapPropertyExtension : MapPropertyExtensionBase
{
	public override bool Can(PropertyMetadata propertyMetadata)
	{
		return propertyMetadata.Settings is EnumSettings;
	}

	public override void SetValue(PropertyValue propertyValue, object value, SetPropertyInfo mapSettings)
	{
		MapPropertyInfo propertyInfo = propertyValue.PropertyInfo;
		if (value != null)
		{
			Type propertyType = propertyInfo.PropertyMetadata.DeclaringType.GetProperty(propertyInfo.Name).PropertyType;
			if (value.GetType() != propertyType)
			{
				Type underlyingType = Nullable.GetUnderlyingType(propertyType);
				value = ((!(underlyingType != null) || !underlyingType.IsEnum || !propertyType.IsNullableType()) ? ((value.GetType() == typeof(string)) ? Enum.Parse(propertyType, value.ToString()) : Enum.ToObject(propertyType, value)) : ((value.GetType() == typeof(string)) ? Enum.Parse(underlyingType, value.ToString()) : Enum.ToObject(underlyingType, value)));
			}
			string sVal = value.ToString();
			EnumMetadata obj = InterfaceActivator.LoadMetadata(propertyType) as EnumMetadata;
			EnumValueMetadata enumValueMetadata = obj.Values.FirstOrDefault((EnumValueMetadata v) => v.EnumValue.ToString() == sVal);
			value = ((obj.Type != 0) ? ((object)enumValueMetadata.Uid) : ((object)enumValueMetadata.IntValue));
		}
		EnumSettings enumSettings = (EnumSettings)propertyInfo.PropertyMetadata.Settings;
		propertyValue.Columns[enumSettings.FieldName] = value;
	}

	public override Type GetPropertyDbType(PropertyMetadata propertyMetadata)
	{
		if (propertyMetadata == null)
		{
			return typeof(object);
		}
		if (!(MetadataServiceContext.Service.GetTypeDescriptor(propertyMetadata.TypeUid, propertyMetadata.SubTypeUid) is EnumDescriptor enumDescriptor))
		{
			return typeof(object);
		}
		if (!(MetadataLoader.LoadMetadata(propertyMetadata.DeclaringType) is EntityMetadata entityMetadata))
		{
			return typeof(object);
		}
		if (enumDescriptor.GetDbStructures(entityMetadata, propertyMetadata as EntityPropertyMetadata).Columns[0].ColumnType.DataType != DbType.Int32)
		{
			return typeof(Guid);
		}
		return typeof(long);
	}
}
