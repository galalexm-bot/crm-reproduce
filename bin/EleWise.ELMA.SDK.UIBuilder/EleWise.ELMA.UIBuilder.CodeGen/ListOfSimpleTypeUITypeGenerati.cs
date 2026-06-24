using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.UIBuilder.CodeGeneration.Types;

internal sealed class ListOfSimpleTypeUITypeGeneration : BaseUITypeGeneration<ListOfSimpleTypeDescriptor>
{
	public override ISyntaxNode GetPropertyInitExpression(ITypeDescriptor typeDescriptor, ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		Contract.ArgumentNotNull(propertyMetadata, "propertyMetadata");
		Contract.ArgumentNotNull(propertyMetadata.Settings, "propertyMetadata.Settings");
		ISyntaxNode simpleType = GetSimpleType((ListOfSimpleTypeDescriptor)typeDescriptor, propertyMetadata);
		return "EleWise.ELMA.Collections.ReactiveCollection".CreateTypeSyntax(false, simpleType).ObjectCreationExpression();
	}

	public override ISyntaxNode GetPropertyTypeReference(ITypeDescriptor typeDescriptor, ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		Contract.ArgumentNotNull(propertyMetadata, "propertyMetadata");
		Contract.ArgumentNotNull(propertyMetadata.Settings, "propertyMetadata.Settings");
		ISyntaxNode simpleType = GetSimpleType((ListOfSimpleTypeDescriptor)typeDescriptor, propertyMetadata);
		return typeof(ICollection<>).CreateTypeSyntax(false, simpleType);
	}

	private static ISyntaxNode GetSimpleType(ListOfSimpleTypeDescriptor descriptor, PropertyMetadata property)
	{
		ListOfSimpleTypeSettings listOfSimpleTypeSettings = (ListOfSimpleTypeSettings)property.Settings;
		ITypeDescriptor typeDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(listOfSimpleTypeSettings.SimpleTypeUid, Guid.Empty);
		if (typeDescriptor == null && property.SubTypeUid != Guid.Empty)
		{
			typeDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(property.SubTypeUid, Guid.Empty);
		}
		if (typeDescriptor != null)
		{
			Type firstGenericType = descriptor.GetFirstGenericType(typeDescriptor.GetType());
			if (firstGenericType != null)
			{
				return firstGenericType.GetGenericArguments()[0].CreateTypeSyntax(useGlobal: false);
			}
		}
		return typeof(object).CreateTypeSyntax(useGlobal: false);
	}
}
