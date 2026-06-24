using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.UIBuilder.CodeGeneration.Types;

[Service]
internal sealed class ActionUITypeGenerationService : IActionUITypeGenerationService
{
	private readonly IEnumerable<IUITypeGenerationInfoExtension> uiTypeGenerationInfoExtensions;

	public ActionUITypeGenerationService(IEnumerable<IUITypeGenerationInfoExtension> uiTypeGenerationInfoExtensions)
	{
		this.uiTypeGenerationInfoExtensions = uiTypeGenerationInfoExtensions;
	}

	public bool UIBuilderSupports(ITypeDescriptor typeDescriptor)
	{
		return typeDescriptor is ActionDescriptor;
	}

	public ISyntaxNode GetPropertyTypeReference(PropertyMetadata propertyMetadata)
	{
		return GetTypeReference(propertyMetadata);
	}

	private ISyntaxNode GetTypeReference(IPropertyMetadata propertyMetadata)
	{
		ActionSettings obj = (propertyMetadata.Settings as ActionSettings) ?? throw new ArgumentException(SR.T("Неверный тип настроек свойства"));
		Type typeFromHandle = typeof(Task);
		TypeSignature parameterType = obj.ParameterType;
		TypeSignature returnType = obj.ReturnType;
		ISyntaxNode syntaxNode = ((returnType.TypeUid != Guid.Empty) ? typeFromHandle.CreateTypeSyntax(GetSignatureTypeReference(returnType)) : typeFromHandle.CreateTypeSyntax());
		if (parameterType.TypeUid == Guid.Empty)
		{
			return typeof(Func<>).CreateTypeSyntax(false, syntaxNode);
		}
		ISyntaxNode signatureTypeReference = GetSignatureTypeReference(parameterType);
		return typeof(Func<>).CreateTypeSyntax(false, signatureTypeReference, syntaxNode);
	}

	private ISyntaxNode GetSignatureTypeReference(TypeSignature typeSignature)
	{
		ITypeDescriptor typeDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(typeSignature.TypeUid, typeSignature.SubTypeUid);
		PropertyMetadata propertyMetadata = new PropertyMetadata
		{
			TypeUid = typeSignature.TypeUid,
			SubTypeUid = typeSignature.SubTypeUid,
			Nullable = typeSignature.Nullable
		};
		ClassMetadata classMetadata = new ClassMetadata
		{
			Properties = new List<PropertyMetadata> { propertyMetadata }
		};
		IUITypeGenerationInfoExtension iUITypeGenerationInfoExtension = uiTypeGenerationInfoExtensions.FirstOrDefault((IUITypeGenerationInfoExtension d) => d.UIBuilderSupports(typeDescriptor));
		ISyntaxNode syntaxNode;
		if (iUITypeGenerationInfoExtension != null)
		{
			if (typeSignature.TypeUid == ListOfSimpleTypeDescriptor.UID)
			{
				ITypeDescriptor subDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(typeSignature.SubTypeUid, Guid.Empty);
				IUITypeGenerationInfoExtension iUITypeGenerationInfoExtension2 = uiTypeGenerationInfoExtensions.FirstOrDefault((IUITypeGenerationInfoExtension d) => d.UIBuilderSupports(subDescriptor));
				PropertyMetadata propertyMetadata2 = new PropertyMetadata
				{
					TypeUid = typeSignature.SubTypeUid,
					Nullable = typeSignature.Nullable
				};
				classMetadata.Properties.Clear();
				classMetadata.Properties.Add(propertyMetadata2);
				syntaxNode = ((iUITypeGenerationInfoExtension2 != null) ? iUITypeGenerationInfoExtension2.GetPropertyTypeReference(subDescriptor, classMetadata, propertyMetadata2, forFilter: false) : ((ITypeGenerationInfo)subDescriptor).GetPropertyTypeReference(classMetadata, propertyMetadata2, forFilter: false));
			}
			else
			{
				syntaxNode = iUITypeGenerationInfoExtension.GetPropertyTypeReference(typeDescriptor, classMetadata, propertyMetadata, forFilter: false);
			}
		}
		else
		{
			syntaxNode = ((ITypeGenerationInfo)typeDescriptor).GetPropertyTypeReference(classMetadata, propertyMetadata, forFilter: false);
		}
		if (typeSignature.RelationType == RelationType.ManyToMany)
		{
			syntaxNode = syntaxNode.CreateArrayTypeSyntax();
		}
		return syntaxNode;
	}
}
