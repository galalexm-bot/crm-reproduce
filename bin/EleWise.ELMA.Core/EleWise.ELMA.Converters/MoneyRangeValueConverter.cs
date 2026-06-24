using System;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Converters;

internal sealed class MoneyRangeValueConverter : BaseValueConverter<MoneyRange, double?>
{
	public override bool CanConvert(ITypeDescriptor typeDescriptor, System.Type convertType)
	{
		if (base.CanConvert(typeDescriptor, convertType))
		{
			return typeDescriptor is MoneyRangeDescriptor;
		}
		return false;
	}

	public override MoneyRange ConvertTo(double? value, IPropertyMetadata propertyMetadata)
	{
		return default(MoneyRange);
	}

	public override double? ConvertFrom(MoneyRange value)
	{
		return null;
	}
}
