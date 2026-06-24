using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Model.Types;

public interface IFormatTypeDescriptor
{
	string FormatValue(object value, PropertyMetadata propertyMetadata);

	string FormatValue(object value, TypeSettings settings);
}
