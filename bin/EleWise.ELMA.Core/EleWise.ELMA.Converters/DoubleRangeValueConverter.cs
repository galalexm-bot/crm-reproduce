using System;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Converters;

internal sealed class DoubleRangeValueConverter : BaseValueConverter<DoubleRange, double?>
{
	public override bool CanConvert(ITypeDescriptor typeDescriptor, System.Type convertType)
	{
		if (base.CanConvert(typeDescriptor, convertType))
		{
			return typeDescriptor is DoubleRangeDescriptor;
		}
		return false;
	}

	public override DoubleRange ConvertTo(double? value, IPropertyMetadata propertyMetadata)
	{
		return default(DoubleRange);
	}

	public override double? ConvertFrom(DoubleRange value)
	{
		return null;
	}
}
