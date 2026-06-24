using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;

namespace EleWise.ELMA.UIBuilder.CodeGeneration.Types;

[Component]
internal abstract class BaseUITypeGeneration<T> : IUITypeGenerationInfoExtension where T : ITypeDescriptor
{
	public virtual bool UIBuilderSupports(ITypeDescriptor typeDescriptor)
	{
		return typeDescriptor is T;
	}

	public virtual ISyntaxNode GetPropertyTypeReference(ITypeDescriptor typeDescriptor, ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		return ((ITypeGenerationInfo)typeDescriptor).GetPropertyTypeReference(classMetadata, propertyMetadata, forFilter);
	}

	public virtual ISyntaxNode GetPropertyInitExpression(ITypeDescriptor typeDescriptor, ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		return ((ITypeGenerationInfo)typeDescriptor).GetPropertyInitExpression(classMetadata, propertyMetadata, forFilter);
	}

	protected bool ShouldSerialize(PropertyMetadata propertyMetadata)
	{
		if (propertyMetadata is IViewModelPropertyMetadata viewModelPropertyMetadata)
		{
			return !viewModelPropertyMetadata.ClientOnly;
		}
		return true;
	}
}
