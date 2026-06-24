using System;
using System.Web;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Converters;

internal sealed class HtmlStringValueConverter : BaseValueConverter<HtmlString, string>
{
	public override bool CanConvert(ITypeDescriptor typeDescriptor, System.Type convertType)
	{
		if (base.CanConvert(typeDescriptor, convertType))
		{
			return typeDescriptor is HtmlStringDescriptor;
		}
		return false;
	}

	public override HtmlString ConvertTo(string value, IPropertyMetadata propertyMetadata)
	{
		return new HtmlString(value);
	}

	public override string ConvertFrom(HtmlString value)
	{
		return value?.Value;
	}
}
