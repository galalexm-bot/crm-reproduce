using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types;

public interface IValidatableTypeDescriptor
{
	MetadataItemValidationError[] Validate(IPropertyMetadata propertyMetadata);
}
