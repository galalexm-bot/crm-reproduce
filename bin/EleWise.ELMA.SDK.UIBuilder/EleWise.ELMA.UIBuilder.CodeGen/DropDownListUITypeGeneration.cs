using System;
using System.Reflection;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.UIBuilder.CodeGeneration.Types;

internal sealed class DropDownListUITypeGeneration : BaseUITypeGeneration<DropDownListDescriptor>
{
	public override ISyntaxNode GetPropertyTypeReference(ITypeDescriptor typeDescriptor, ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		Type raw = TypeOf<DropDownItem>.Raw;
		if (typeDescriptor.CanBeNullable && propertyMetadata != null && propertyMetadata.Nullable)
		{
			return raw.NullableType().CreateTypeSyntax(useGlobal: false);
		}
		return raw.CreateTypeSyntax(useGlobal: false);
	}
}
