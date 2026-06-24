using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Converters;

internal sealed class MoneyValueConverter : BaseValueConverter<Money, double?>
{
	public override bool CanConvert(ITypeDescriptor typeDescriptor, System.Type convertType)
	{
		if (base.CanConvert(typeDescriptor, convertType))
		{
			return typeDescriptor is MoneyDescriptor;
		}
		return false;
	}

	public override object ConvertToObject(object value, IPropertyMetadata propertyMetadata)
	{
		return ConvertTo(ObjectExtensions.As<double?>(value), propertyMetadata);
	}

	public override Money ConvertTo(double? value, IPropertyMetadata propertyMetadata)
	{
		return new Money(value);
	}

	public override object ConvertFromObject(object value)
	{
		return ConvertFrom(ObjectExtensions.As<Money>(value));
	}

	public override double? ConvertFrom(Money value)
	{
		if (!value.HasValue)
		{
			return null;
		}
		return value.Value;
	}
}
