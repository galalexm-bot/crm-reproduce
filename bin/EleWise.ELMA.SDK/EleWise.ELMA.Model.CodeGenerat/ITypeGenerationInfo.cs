using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;

namespace EleWise.ELMA.Model.CodeGeneration;

public interface ITypeGenerationInfo
{
	bool HasPropertyGetter { get; }

	bool HasPropertySetter { get; }

	ISyntaxNode GetPropertyTypeReference(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter);

	ISyntaxNode GetPropertyInitExpression(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false);

	IEnumerable<ISyntaxNode> GetPropertyGetterExpressions(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, string fieldName);

	IEnumerable<ISyntaxNode> GetPropertySetterExpressions(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, string fieldName);

	IEnumerable<ISyntaxNode> GetAdditionalTypeMembers(ClassMetadata classMetadata, PropertyMetadata propertyMetadata);

	IPropertyDefaultValueContainer GetDefaultContainer(ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false);
}
