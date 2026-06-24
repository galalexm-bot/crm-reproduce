using System;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Converters;

internal sealed class Int16RangeValueConverter : BaseValueConverter<Int16Range, short?>
{
	public override bool CanConvert(ITypeDescriptor typeDescriptor, System.Type convertType)
	{
		if (base.CanConvert(typeDescriptor, convertType))
		{
			return typeDescriptor is Int16RangeDescriptor;
		}
		return false;
	}

	public override Int16Range ConvertTo(short? value, IPropertyMetadata propertyMetadata)
	{
		return default(Int16Range);
	}

	public override short? ConvertFrom(Int16Range value)
	{
		return null;
	}
}
