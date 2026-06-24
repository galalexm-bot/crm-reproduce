using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.UIBuilder.CodeGeneration.Types;

public interface IUITypeGenerationFacade
{
	bool UIBuilderSupports(ITypeDescriptor typeDescriptor);

	ISyntaxNode GetPropertyTypeReference(ITypeDescriptor typeDescriptor, ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter);
}
