using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.UIBuilder.CodeGeneration.Types;

internal sealed class EntityUITypeGeneration : BaseUITypeGeneration<EntityDescriptor>
{
	private MethodInfo getTypeNameMethod;

	public override ISyntaxNode GetPropertyInitExpression(ITypeDescriptor typeDescriptor, ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		Contract.ArgumentNotNull(propertyMetadata, "propertyMetadata");
		if (GetRelationType(propertyMetadata) == RelationType.OneToOne)
		{
			return null;
		}
		ISyntaxNode propertyType = GetPropertyType(typeDescriptor, classMetadata, propertyMetadata, forFilter);
		return "EleWise.ELMA.Collections.ReactiveCollection".CreateTypeSyntax(false, propertyType).ObjectCreationExpression();
	}

	public override ISyntaxNode GetPropertyTypeReference(ITypeDescriptor typeDescriptor, ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		Contract.ArgumentNotNull(propertyMetadata, "propertyMetadata");
		RelationType relationType = GetRelationType(propertyMetadata);
		ISyntaxNode propertyType = GetPropertyType(typeDescriptor, classMetadata, propertyMetadata, forFilter);
		if (relationType == RelationType.OneToOne)
		{
			return propertyType;
		}
		if (classMetadata is EntityMetadata)
		{
			return TypeOf.ISet.Raw.CreateTypeSyntax(false, propertyType);
		}
		return typeof(ICollection<>).CreateTypeSyntax(false, propertyType);
	}

	private static RelationType GetRelationType(PropertyMetadata propertyMetadata)
	{
		Contract.ArgumentNotNull(propertyMetadata, "propertyMetadata");
		Contract.ArgumentNotNull(propertyMetadata.Settings, "propertyMetadata.Settings");
		return ((propertyMetadata.Settings as EntitySettings) ?? throw new ArgumentException(SR.T("Неверный тип настроек свойства"))).RelationType;
	}

	private ISyntaxNode GetPropertyType(ITypeDescriptor typeDescriptor, ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		if (getTypeNameMethod == null)
		{
			getTypeNameMethod = typeDescriptor.GetType().GetMethod("GetTypeName", BindingFlags.Instance | BindingFlags.NonPublic);
		}
		return ((string)getTypeNameMethod.Invoke(typeDescriptor, new object[3] { classMetadata, propertyMetadata, forFilter })).CreateTypeSyntax(useGlobal: false);
	}
}
