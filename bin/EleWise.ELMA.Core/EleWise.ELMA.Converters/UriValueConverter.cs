using System;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Converters;

internal sealed class UriValueConverter : BaseValueConverter<Uri, string>
{
	public override bool CanConvert(ITypeDescriptor typeDescriptor, System.Type convertType)
	{
		if (base.CanConvert(typeDescriptor, convertType))
		{
			return typeDescriptor is UrlDescriptor;
		}
		return false;
	}

	public override Uri ConvertTo(string value, IPropertyMetadata propertyMetadata)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Uri(value);
	}

	public override string ConvertFrom(Uri value)
	{
		if (!(value == (Uri)null))
		{
			return value.get_AbsoluteUri();
		}
		return null;
	}
}
