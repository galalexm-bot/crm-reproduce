using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Components.SettingsChecker;
using EleWise.ELMA.Converters;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Services;

[Service]
internal sealed class CheckMetadataService : ICheckMetadataService
{
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public ITypeDescriptor typeDescriptor;
	}

	private sealed class _003C_003Ec__DisplayClass5_1
	{
		public System.Type defaultValueType;

		public _003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals1;

		internal bool _003CCheckProperty_003Eb__1(IValueConverter a)
		{
			return a.CanConvert(CS_0024_003C_003E8__locals1.typeDescriptor, defaultValueType);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<PropertyMetadata, bool> _003C_003E9__5_0;

		internal bool _003CCheckProperty_003Eb__5_0(PropertyMetadata a)
		{
			return ((INamedMetadata)a).get_Name() == "DefaultValue";
		}
	}

	private readonly IDescriptorService descriptorService;

	private readonly IMetadataServiceContext metadataServiceContext;

	private readonly System.Collections.Generic.IEnumerable<IValueConverter> valueConverters;

	private readonly System.Collections.Generic.IEnumerable<ISettingsChecker> settingsCheckers;

	public CheckMetadataService(IDescriptorService descriptorService, IMetadataServiceContext metadataServiceContext, System.Collections.Generic.IEnumerable<IValueConverter> valueConverters, System.Collections.Generic.IEnumerable<ISettingsChecker> settingsCheckers)
	{
		this.descriptorService = descriptorService;
		this.metadataServiceContext = metadataServiceContext;
		this.valueConverters = valueConverters;
		this.settingsCheckers = settingsCheckers;
	}

	public CheckMetadataResult CheckProperty(ClassMetadata metadataDto, PropertyMetadata property)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		List<string> val = new List<string>();
		if (string.IsNullOrWhiteSpace(((INamedMetadata)property).get_Name()))
		{
			val.Add(SR.T("Свойство имеет незаполненный атрибут \"Имя\""));
		}
		if (!((INamedMetadata)property).get_Name().IsValidIdentifier())
		{
			val.Add(SR.T("Имя свойства должно быть корректным идентификатором (допускаются только буквы английского алфавита, цифры и знак подчеркивания)"));
		}
		if (string.IsNullOrWhiteSpace(((INamedMetadata)property).get_DisplayName()))
		{
			val.Add(SR.T("Свойство имеет незаполненный атрибут \"Отображаемое имя\""));
		}
		if (((IPropertyMetadata)property).get_TypeUid() == Guid.Empty)
		{
			val.Add(SR.T("Свойство имеет незаполненный атрибут \"Тип\""));
		}
		System.Collections.Generic.IEnumerator<PropertyMetadata> enumerator = ((System.Collections.Generic.IEnumerable<PropertyMetadata>)metadataDto.get_Properties()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				PropertyMetadata current = enumerator.get_Current();
				bool flag = ((IMetadata)current).get_Uid() == ((IMetadata)property).get_Uid();
				if (!flag && ((INamedMetadata)current).get_Name() == ((INamedMetadata)property).get_Name())
				{
					val.Add(SR.T("В метаданных уже существует свойство с указанным именем \"{0}\"", ((INamedMetadata)property).get_Name()));
				}
				if (!flag && ((INamedMetadata)current).get_DisplayName() == ((INamedMetadata)property).get_DisplayName())
				{
					val.Add(SR.T("В метаданных уже существует свойство с указанным отображаемым именем \"{0}\"", ((INamedMetadata)property).get_Name()));
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		ViewModelPropertyMetadata val2;
		if ((val2 = (ViewModelPropertyMetadata)(object)((property is ViewModelPropertyMetadata) ? property : null)) != null)
		{
			_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
			bool required = ((PropertyMetadata)val2).get_Required();
			_003C_003Ec__DisplayClass5_.typeDescriptor = descriptorService.GetTypeDescriptor(((IPropertyMetadata)val2).get_TypeUid(), ((IPropertyMetadata)val2).get_SubTypeUid());
			bool flag2 = IsInput(_003C_003Ec__DisplayClass5_.typeDescriptor, val2);
			if (((IPropertyMetadata)property).get_TypeUid() == ActionDescriptor.UID && (!flag2 || (flag2 && !required)))
			{
				if (((IPropertyMetadata)property).get_Settings() is IHasDefaultValue && DefaultValueHelper.GetCurrentDefaultValue(metadataServiceContext, (IPropertyMetadata)(object)property) == null)
				{
					val.Add(SR.T("Свойство имеет незаполненный обязательный атрибут \"Значение по умолчанию\""));
				}
			}
			else if (!required && flag2)
			{
				TypeSettings settings = ((IPropertyMetadata)val2).get_Settings();
				if (settings != null && settings is IHasDefaultValue)
				{
					object currentDefaultValue = DefaultValueHelper.GetCurrentDefaultValue(metadataServiceContext, (IPropertyMetadata)(object)val2);
					if (currentDefaultValue == null)
					{
						if (_003C_003Ec__DisplayClass5_.typeDescriptor == null || !DefaultValueHelper.TryGetInitValue(metadataServiceContext, descriptorService, (IPropertyMetadata)(object)val2, valueConverters, out var result))
						{
							val.Add(SR.T("Свойство имеет незаполненный обязательный атрибут \"Значение по умолчанию\""));
						}
						else
						{
							bool flag3 = false;
							IMetadata metadataByHash = metadataServiceContext.GetMetadataByHash(settings.GetPlainPropertyValue<string>("$t"));
							DataClassMetadata dataClassMetadata;
							if ((dataClassMetadata = (DataClassMetadata)(object)((metadataByHash is DataClassMetadata) ? metadataByHash : null)) != null)
							{
								PropertyMetadata val3 = Enumerable.First<PropertyMetadata>(dataClassMetadata.GetPropertiesWithInclude(metadataServiceContext), (Func<PropertyMetadata, bool>)((PropertyMetadata a) => ((INamedMetadata)a).get_Name() == "DefaultValue"));
								if (descriptorService.GetTypeDescriptor(((IPropertyMetadata)val3).get_TypeUid(), ((IPropertyMetadata)val3).get_SubTypeUid()) is IRuntimeTypeDescriptor runtimeTypeDescriptor)
								{
									_003C_003Ec__DisplayClass5_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_1();
									CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass5_;
									CS_0024_003C_003E8__locals0.defaultValueType = runtimeTypeDescriptor.RuntimeType;
									if (val3.get_Nullable() && CS_0024_003C_003E8__locals0.defaultValueType.get_IsValueType() && !CS_0024_003C_003E8__locals0.defaultValueType.get_IsGenericType())
									{
										CS_0024_003C_003E8__locals0.defaultValueType = typeof(System.Nullable<>).MakeGenericType(new System.Type[1] { CS_0024_003C_003E8__locals0.defaultValueType });
									}
									IValueConverter valueConverter = Enumerable.FirstOrDefault<IValueConverter>(valueConverters, (Func<IValueConverter, bool>)((IValueConverter a) => a.CanConvert(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.typeDescriptor, CS_0024_003C_003E8__locals0.defaultValueType)));
									if (valueConverter != null)
									{
										DefaultValueHelper.SetDefaultValue(metadataServiceContext, (IPropertyMetadata)(object)val2, valueConverter.ConvertFromObject(currentDefaultValue));
										flag3 = true;
									}
								}
							}
							if (!flag3)
							{
								DefaultValueHelper.SetDefaultValue(metadataServiceContext, (IPropertyMetadata)(object)val2, result);
							}
						}
					}
				}
			}
		}
		System.Collections.Generic.IEnumerator<ISettingsChecker> enumerator2 = settingsCheckers.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator2).MoveNext())
			{
				ISettingsChecker current2 = enumerator2.get_Current();
				val.AddRange((System.Collections.Generic.IEnumerable<string>)current2.Check(((IPropertyMetadata)property).get_Settings()));
			}
		}
		finally
		{
			((System.IDisposable)enumerator2)?.Dispose();
		}
		return new CheckMetadataResult(val.get_Count() == 0, (System.Collections.Generic.IEnumerable<string>)val);
	}

	private static bool IsInput(ITypeDescriptor typeDescriptor, ViewModelPropertyMetadata viewModelPropertyMetadata)
	{
		if (PropertyMetadataSettingsHelper.IsInput(viewModelPropertyMetadata))
		{
			return !IsNullable(typeDescriptor, (PropertyMetadata)(object)viewModelPropertyMetadata);
		}
		return false;
	}

	private static bool IsNullable(ITypeDescriptor typeDescriptor, PropertyMetadata propertyMetadata)
	{
		if (typeDescriptor != null && typeDescriptor.CanBeNullable)
		{
			return propertyMetadata.get_Nullable();
		}
		return false;
	}
}
