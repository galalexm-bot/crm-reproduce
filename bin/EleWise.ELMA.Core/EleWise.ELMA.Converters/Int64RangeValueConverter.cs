using System;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Converters;

internal sealed class Int64RangeValueConverter : BaseValueConverter<Int64Range, long?>
{
	public override bool CanConvert(ITypeDescriptor typeDescriptor, System.Type convertType)
	{
		if (base.CanConvert(typeDescriptor, convertType))
		{
			return typeDescriptor is Int64RangeDescriptor;
		}
		return false;
	}

	public override Int64Range ConvertTo(long? value, IPropertyMetadata propertyMetadata)
	{
		return default(Int64Range);
	}

	public override long? ConvertFrom(Int64Range value)
	{
		return null;
	}
}
