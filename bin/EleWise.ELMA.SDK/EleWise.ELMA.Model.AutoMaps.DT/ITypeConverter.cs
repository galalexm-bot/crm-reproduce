using System;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.Converters;

public interface ITypeConverter
{
	Type Type { get; }

	bool CanConvertTo(Type type);

	object ConvertTo(object value, Type destinationType);
}
