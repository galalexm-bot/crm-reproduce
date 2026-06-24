using System.Reflection;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.UIBuilder.CodeGeneration.Types;

internal sealed class FormViewItemUITypeGeneration : BaseUITypeGeneration<FormViewItemDescriptor>
{
	public override ISyntaxNode GetPropertyTypeReference(ITypeDescriptor typeDescriptor, ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		if (forFilter)
		{
			return TypeOf<object>.Raw.CreateTypeSyntax();
		}
		return TypeOf<FormViewItem>.Raw.CreateTypeSyntax();
	}
}
