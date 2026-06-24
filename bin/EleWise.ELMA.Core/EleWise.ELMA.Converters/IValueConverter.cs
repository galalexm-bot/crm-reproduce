using System;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Converters;

[ExtensionPoint]
public interface IValueConverter
{
	bool CanConvert(ITypeDescriptor typeDescriptor, System.Type convertType);

	object ConvertToObject(object value, IPropertyMetadata propertyMetadata);

	object ConvertFromObject(object value);
}
[ExtensionPoint]
public interface IValueConverter<TToConvert, TFromConvert> : IValueConverter
{
	TToConvert ConvertTo(TFromConvert value, IPropertyMetadata propertyMetadata);

	TFromConvert ConvertFrom(TToConvert value);
}
