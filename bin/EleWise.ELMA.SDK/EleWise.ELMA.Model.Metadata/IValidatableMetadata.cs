namespace EleWise.ELMA.Model.Metadata;

public interface IValidatableMetadata
{
	MetadataItemValidationError[] Validate();
}
