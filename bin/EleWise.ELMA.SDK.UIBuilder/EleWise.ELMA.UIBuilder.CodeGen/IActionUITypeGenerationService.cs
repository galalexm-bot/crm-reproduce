using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.UIBuilder.CodeGeneration.Types;

internal interface IActionUITypeGenerationService
{
	bool UIBuilderSupports(ITypeDescriptor typeDescriptor);

	ISyntaxNode GetPropertyTypeReference(PropertyMetadata propertyMetadata);
}
