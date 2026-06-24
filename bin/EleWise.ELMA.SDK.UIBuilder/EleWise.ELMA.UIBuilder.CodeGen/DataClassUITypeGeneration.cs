using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.UIBuilder.CodeGeneration.Types;

internal sealed class DataClassUITypeGeneration : BaseUITypeGeneration<DataClassDescriptor>
{
	private readonly DataClassDescriptor dataClassDescriptor;

	private readonly MethodInfo getTypeNameMethod;

	public DataClassUITypeGeneration(DataClassDescriptor dataClassDescriptor)
	{
		this.dataClassDescriptor = dataClassDescriptor;
		getTypeNameMethod = dataClassDescriptor.GetType().GetMethod("GetTypeName", BindingFlags.Instance | BindingFlags.NonPublic);
	}

	public override ISyntaxNode GetPropertyInitExpression(ITypeDescriptor typeDescriptor, ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter = false)
	{
		Contract.ArgumentNotNull(propertyMetadata, "propertyMetadata");
		Contract.ArgumentNotNull(propertyMetadata.Settings, "propertyMetadata.Settings");
		if (GetRelationType(propertyMetadata) == RelationType.OneToOne)
		{
			return null;
		}
		ISyntaxNode syntaxNode = ((string)getTypeNameMethod.Invoke(dataClassDescriptor, new object[3] { classMetadata, propertyMetadata, forFilter })).CreateTypeSyntax(useGlobal: false);
		return "EleWise.ELMA.Collections.ReactiveCollection".CreateTypeSyntax(false, syntaxNode).ObjectCreationExpression();
	}

	public override ISyntaxNode GetPropertyTypeReference(ITypeDescriptor typeDescriptor, ClassMetadata classMetadata, PropertyMetadata propertyMetadata, bool forFilter)
	{
		Contract.ArgumentNotNull(propertyMetadata, "propertyMetadata");
		Contract.ArgumentNotNull(propertyMetadata.Settings, "propertyMetadata.Settings");
		RelationType relationType = GetRelationType(propertyMetadata);
		ISyntaxNode syntaxNode = ((string)getTypeNameMethod.Invoke(dataClassDescriptor, new object[3] { classMetadata, propertyMetadata, forFilter })).CreateTypeSyntax(useGlobal: false);
		if (relationType == RelationType.OneToOne)
		{
			return syntaxNode;
		}
		return typeof(ICollection<>).CreateTypeSyntax(false, syntaxNode);
	}

	private RelationType GetRelationType(PropertyMetadata propertyMetadata)
	{
		if (propertyMetadata.Settings is DataClassSettings dataClassSettings)
		{
			return dataClassSettings.RelationType;
		}
		throw new ArgumentException(SR.T("Неверный тип настроек свойства"));
	}
}
