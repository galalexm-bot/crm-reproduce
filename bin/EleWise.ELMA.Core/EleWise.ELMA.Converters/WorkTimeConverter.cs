using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Converters;

internal sealed class WorkTimeConverter : BaseValueConverter<WorkTime, long?>
{
	public override bool CanConvert(ITypeDescriptor typeDescriptor, System.Type convertType)
	{
		if (base.CanConvert(typeDescriptor, convertType))
		{
			return typeDescriptor is WorkTimeDescriptor;
		}
		return false;
	}

	public override WorkTime ConvertTo(long? value, IPropertyMetadata propertyMetadata)
	{
		return new WorkTime(value);
	}

	public override long? ConvertFrom(WorkTime value)
	{
		if (!value.HasValue)
		{
			return null;
		}
		return value.Value;
	}
}
