using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Converters;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Diagnostics;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Model.Helpers;

public static class DefaultValueHelper
{
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public ITypeDescriptor typeDescriptor;

		public System.Type defaultValueType;

		internal bool _003CTryGetInitValue_003Eb__0(IValueConverter a)
		{
			return a.CanConvert(typeDescriptor, defaultValueType);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<PropertyMetadata, bool> _003C_003E9__7_0;

		internal bool _003CGetDefaultValueExpression_003Eb__7_0(PropertyMetadata a)
		{
			return ((INamedMetadata)a).get_Name() == "DefaultValue";
		}
	}

	private static readonly Dictionary<System.Type, object> DefaultTypeValues = new Dictionary<System.Type, object>();

	public const string DefaultValuePropertyName = "DefaultValue";

	public static bool CanBeNullableProperty(ITypeDescriptor typeDescriptor, IPropertyMetadata propertyMetadata)
	{
		if (typeDescriptor == null || propertyMetadata == null)
		{
			return true;
		}
		bool flag = typeDescriptor.CanBeNullable;
		if (!flag)
		{
			flag = CanBeNullable(typeDescriptor);
		}
		PropertyMetadata val;
		if (flag && (val = (PropertyMetadata)(object)((propertyMetadata is PropertyMetadata) ? propertyMetadata : null)) != null)
		{
			return val.get_Nullable();
		}
		return false;
	}

	public static bool TryGetInitValue(IMetadataServiceContext metadataServiceContext, IDescriptorService descriptorService, IPropertyMetadata propertyMetadata, System.Collections.Generic.IEnumerable<IValueConverter> valueConverters, out object result)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		Contract.ArgumentNotNull(propertyMetadata, "propertyMetadata");
		TypeSettings settings = propertyMetadata.get_Settings();
		if (settings == null)
		{
			result = null;
			return false;
		}
		if (!(settings is IHasDefaultValue))
		{
			result = null;
			return false;
		}
		PropertyMetadata defaultValueProperty;
		PropertyInfoExpression defaultValueExpression = GetDefaultValueExpression(metadataServiceContext, settings, out defaultValueProperty);
		if (defaultValueExpression == null)
		{
			result = null;
			return false;
		}
		result = ((object)settings).get_Item(defaultValueExpression.ObjectExpression);
		CS_0024_003C_003E8__locals0.defaultValueType = null;
		ITypeDescriptor typeDescriptor = descriptorService.GetTypeDescriptor(((IPropertyMetadata)defaultValueProperty).get_TypeUid(), ((IPropertyMetadata)defaultValueProperty).get_SubTypeUid());
		if (!(typeDescriptor is IRuntimeTypeDescriptor runtimeTypeDescriptor))
		{
			AnyTypeSettings val;
			if (!(typeDescriptor is AnyTypeDescriptor) || (val = (AnyTypeSettings)/*isinst with value type is only supported in some contexts*/) == null)
			{
				return true;
			}
			CS_0024_003C_003E8__locals0.defaultValueType = System.Type.GetType(val.get_FullTypeName());
		}
		else
		{
			CS_0024_003C_003E8__locals0.defaultValueType = runtimeTypeDescriptor.RuntimeType;
		}
		if (CS_0024_003C_003E8__locals0.defaultValueType == null)
		{
			return true;
		}
		CS_0024_003C_003E8__locals0.typeDescriptor = descriptorService.GetTypeDescriptor(propertyMetadata.get_TypeUid(), propertyMetadata.get_SubTypeUid());
		if (defaultValueProperty.get_Nullable() && CS_0024_003C_003E8__locals0.defaultValueType.get_IsValueType() && !CS_0024_003C_003E8__locals0.defaultValueType.get_IsGenericType())
		{
			CS_0024_003C_003E8__locals0.defaultValueType = typeof(System.Nullable<>).MakeGenericType(new System.Type[1] { CS_0024_003C_003E8__locals0.defaultValueType });
		}
		if (result == null && !CanBeNullableProperty(CS_0024_003C_003E8__locals0.typeDescriptor, propertyMetadata))
		{
			result = GetTypeDefaultValue(CS_0024_003C_003E8__locals0.defaultValueType);
		}
		IValueConverter valueConverter = Enumerable.FirstOrDefault<IValueConverter>(valueConverters, (Func<IValueConverter, bool>)((IValueConverter a) => a.CanConvert(CS_0024_003C_003E8__locals0.typeDescriptor, CS_0024_003C_003E8__locals0.defaultValueType)));
		if (valueConverter != null)
		{
			result = valueConverter.ConvertToObject(result, propertyMetadata);
		}
		return true;
	}

	public static void SetDefaultValue(IMetadataServiceContext metadataServiceContext, IPropertyMetadata propertyMetadata, object value)
	{
		TypeSettings settings = propertyMetadata.get_Settings();
		if (settings != null && settings is IHasDefaultValue)
		{
			PropertyMetadata defaultValueProperty;
			PropertyInfoExpression defaultValueExpression = GetDefaultValueExpression(metadataServiceContext, settings, out defaultValueProperty);
			((object)settings).set_Item(defaultValueExpression.ObjectExpression, value);
		}
	}

	public static object GetTypeDefaultValue(System.Type type)
	{
		object result = default(object);
		if (DefaultTypeValues.TryGetValue(type, ref result))
		{
			return result;
		}
		if (type.IsNullableType())
		{
			System.Type type2 = type.GetGenericArguments()[0];
			result = ((!type2.IsNullableType()) ? type2.GetDefault() : type2.GetGenericArguments()[0].GetDefault());
		}
		else
		{
			result = type.GetDefault();
		}
		DefaultTypeValues.Add(type, result);
		return result;
	}

	public static object GetCurrentDefaultValue(IMetadataServiceContext metadataServiceContext, IPropertyMetadata propertyMetadata)
	{
		TypeSettings settings = propertyMetadata.get_Settings();
		PropertyMetadata defaultValueProperty;
		PropertyInfoExpression defaultValueExpression = GetDefaultValueExpression(metadataServiceContext, settings, out defaultValueProperty);
		return settings.GetPlainPropertyValue(defaultValueExpression.ObjectExpression);
	}

	private static PropertyInfoExpression GetDefaultValueExpression(IMetadataServiceContext metadataServiceContext, TypeSettings settings, out PropertyMetadata defaultValueProperty)
	{
		ReactiveProxy reactiveProxy = ObjectExtensions.As<ReactiveProxy>((object)settings);
		ClassMetadata metadata = reactiveProxy.Metadata;
		DataClassMetadata val = (DataClassMetadata)(object)((metadata is DataClassMetadata) ? metadata : null);
		if (val == null)
		{
			string plainPropertyValue = reactiveProxy.GetPlainPropertyValue<string>("$t");
			IMetadata metadataByHash = metadataServiceContext.GetMetadataByHash(plainPropertyValue);
			val = (DataClassMetadata)(object)((metadataByHash is DataClassMetadata) ? metadataByHash : null);
		}
		defaultValueProperty = null;
		if (val == null)
		{
			return null;
		}
		System.Collections.Generic.IEnumerable<PropertyMetadata> propertiesWithInclude = val.GetPropertiesWithInclude(metadataServiceContext);
		defaultValueProperty = Enumerable.FirstOrDefault<PropertyMetadata>(propertiesWithInclude, (Func<PropertyMetadata, bool>)((PropertyMetadata a) => ((INamedMetadata)a).get_Name() == "DefaultValue"));
		if (defaultValueProperty == null)
		{
			return null;
		}
		return metadataServiceContext.GetPropertyExpression((IPropertyMetadata)(object)defaultValueProperty, (ClassMetadata)(object)val);
	}

	private static bool CanBeNullable(ITypeDescriptor descriptor)
	{
		if (descriptor is MoneyDescriptor)
		{
			return true;
		}
		return false;
	}
}
