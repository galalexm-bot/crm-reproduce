using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.UIBuilder.CodeGeneration.Types;

internal sealed class EnumUITypeGeneration : BaseUITypeGeneration<EnumDescriptor>
{
	private const string Enum = "Enum";

	public override ISyntaxNode GetPropertyTypeReference(ITypeDescriptor typeDescriptor, ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		Contract.ArgumentNotNull(propertyMetadata, "propertyMetadata");
		EnumMetadata enumMetadata = (EnumMetadata)MetadataServiceContext.Service.GetMetadata(propertyMetadata.SubTypeUid);
		EnumSettings enumSettings = (EnumSettings)propertyMetadata.Settings;
		if (!forFilter || enumSettings.RelationType != EnumRelationType.Many)
		{
			if (!propertyMetadata.Nullable || enumMetadata.Type != 0)
			{
				return enumMetadata.FullTypeName.CreateTypeSyntax(useGlobal: false);
			}
			return typeof(Nullable<>).CreateTypeSyntax(enumMetadata.FullTypeName.CreateTypeSyntax(useGlobal: false));
		}
		return typeof(List<>).CreateTypeSyntax(enumMetadata.FullTypeName.CreateTypeSyntax(useGlobal: false));
	}
}
