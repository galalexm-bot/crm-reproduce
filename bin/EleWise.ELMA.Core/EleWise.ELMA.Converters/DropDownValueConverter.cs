using System;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Converters;

internal class DropDownValueConverter : BaseValueConverter<DropDownItem, object>
{
	public override bool CanConvert(ITypeDescriptor typeDescriptor, System.Type convertType)
	{
		if (base.CanConvert(typeDescriptor, convertType))
		{
			return typeDescriptor is DropDownListDescriptor;
		}
		return false;
	}

	public override DropDownItem ConvertTo(object value, IPropertyMetadata propertyMetadata)
	{
		if (value is DropDownItem result)
		{
			return result;
		}
		if (value is string stringValue)
		{
			return new DropDownItem(stringValue);
		}
		return null;
	}

	public override object ConvertFrom(DropDownItem value)
	{
		return value;
	}
}
