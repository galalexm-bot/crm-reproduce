using System;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Converters;

internal sealed class Int32RangeValueConverter : BaseValueConverter<Int32Range, int?>
{
	public override bool CanConvert(ITypeDescriptor typeDescriptor, System.Type convertType)
	{
		if (base.CanConvert(typeDescriptor, convertType))
		{
			return typeDescriptor is Int32RangeDescriptor;
		}
		return false;
	}

	public override Int32Range ConvertTo(int? value, IPropertyMetadata propertyMetadata)
	{
		return default(Int32Range);
	}

	public override int? ConvertFrom(Int32Range value)
	{
		return null;
	}
}
