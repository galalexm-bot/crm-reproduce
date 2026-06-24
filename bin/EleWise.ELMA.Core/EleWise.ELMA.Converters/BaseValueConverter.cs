using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Converters;

[Component]
internal abstract class BaseValueConverter<TToConvert, TFromConvert> : IValueConverter<TToConvert, TFromConvert>, IValueConverter
{
	public virtual bool CanConvert(ITypeDescriptor typeDescriptor, System.Type convertType)
	{
		if (typeDescriptor != null)
		{
			return CanConvert(convertType);
		}
		return false;
	}

	public virtual object ConvertToObject(object value, IPropertyMetadata propertyMetadata)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (value == null)
		{
			return null;
		}
		if (!(value is TFromConvert value2))
		{
			throw new InvalidCastException(SR.T("Тип значения не соответствует ожидаемому {0}", typeof(TFromConvert)));
		}
		return ConvertTo(value2, propertyMetadata);
	}

	public virtual object ConvertFromObject(object value)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (value == null)
		{
			return null;
		}
		if (!(value is TToConvert value2))
		{
			throw new InvalidCastException(SR.T("Тип значения не соответствует ожидаемому {0}", typeof(TToConvert)));
		}
		return ConvertFrom(value2);
	}

	public abstract TToConvert ConvertTo(TFromConvert value, IPropertyMetadata propertyMetadata);

	public abstract TFromConvert ConvertFrom(TToConvert value);

	protected virtual bool CanConvert(System.Type type)
	{
		return typeof(TFromConvert).IsAssignableFrom(type);
	}
}
