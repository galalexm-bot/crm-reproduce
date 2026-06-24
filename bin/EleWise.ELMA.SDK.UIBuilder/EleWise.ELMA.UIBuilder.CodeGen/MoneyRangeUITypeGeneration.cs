using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.UIBuilder.CodeGeneration.Types;

internal sealed class MoneyRangeUITypeGeneration : BaseUITypeGeneration<MoneyRangeDescriptor>
{
	public override ISyntaxNode GetPropertyInitExpression(ITypeDescriptor typeDescriptor, ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		return null;
	}

	public override ISyntaxNode GetPropertyTypeReference(ITypeDescriptor typeDescriptor, ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		return typeof(MoneyRange).CreateTypeSyntax(useGlobal: false);
	}
}
