using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types;

public interface IConvertableTypeDescriptor
{
	object ConvertFrom(object value, PropertyMetadata propertyMetadata);
}
