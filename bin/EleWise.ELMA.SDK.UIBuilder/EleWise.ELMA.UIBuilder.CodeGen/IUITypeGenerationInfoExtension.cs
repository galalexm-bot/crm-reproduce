using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.UIBuilder.CodeGeneration.Types;

[ExtensionPoint(ComponentType.All)]
public interface IUITypeGenerationInfoExtension
{
	bool UIBuilderSupports(ITypeDescriptor typeDescriptor);

	ISyntaxNode GetPropertyTypeReference(ITypeDescriptor typeDescriptor, ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter);

	ISyntaxNode GetPropertyInitExpression(ITypeDescriptor typeDescriptor, ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false);
}
