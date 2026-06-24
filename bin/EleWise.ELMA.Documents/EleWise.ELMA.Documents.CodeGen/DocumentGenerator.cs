using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Documents.CodeGeneration;

public class DocumentGenerator : EntityDynamicGenerator
{
	protected new DocumentMetadata metadata;

	protected override ISyntaxNode GetBaseClass()
	{
		if (metadata.Type != EntityMetadataType.InterfaceExtension && metadata.BaseClassUid == Guid.Empty)
		{
			metadata.BaseClassUid = ((metadata.Type == EntityMetadataType.Interface) ? DocumentMetadata.D_UID : DocumentMetadata.D_IMP_UID);
		}
		return base.GetBaseClass();
	}

	protected override IEnumerable<ISyntaxNode> GetBaseInterfaces()
	{
		return base.GetBaseInterfaces().If(metadata.ControlOnSending, (IEnumerable<ISyntaxNode> i) => i.Concat(typeof(ISendableDocument).CreateTypeSyntax()));
	}

	protected override void InitInternal(IMetadata metadata)
	{
		Contract.ArgumentNotNull(metadata, "metadata");
		Contract.CheckArgument(metadata is DocumentMetadata, "metadata is DocumentMetadata");
		base.InitInternal(metadata);
		this.metadata = (DocumentMetadata)metadata;
	}

	protected override IEnumerable<ISyntaxNode> GetNamespaces()
	{
		return base.GetNamespaces().Concat("EleWise.ELMA.Documents.Extensions".NamespaceImportDeclaration());
	}

	protected override IEnumerable<ISyntaxTrivia> Resources()
	{
		return base.Resources().If(!string.IsNullOrEmpty(metadata.TemplateName), (IEnumerable<ISyntaxTrivia> r) => r.Concat(GetLocalizableText(metadata.TemplateName).TextComment()));
	}

	protected override void WriteTypeAttributes(ISyntaxNode type)
	{
		Contract.ArgumentNotNull(type, "type");
		Contract.NotNull(metadata, "metadata");
		base.WriteTypeAttributes(type);
		List<ISyntaxNode> list = new List<ISyntaxNode>();
		list.Add(typeof(DisableCreateAttribute).CreateAttribute(metadata.DisableCreate));
		list.Add(typeof(ControlOnSendingValueAttribute).CreateAttribute(metadata.ControlOnSending));
		list.Add(typeof(IsAllowRenameAttribute).CreateAttribute(metadata.IsAllowRename));
		list.Add(typeof(TemplateNameAttribute).CreateAttribute(metadata.TemplateName));
		list.Add(typeof(MultipleRegistrationAttribute).CreateAttribute(metadata.MultipleRegistration));
		list.Add(typeof(UploadButtonAttribute).CreateAttribute(metadata.UploadButton));
		list.Add(typeof(ScanButtonAttribute).CreateAttribute(metadata.ScanButton));
		list.Add(typeof(TemplateButtonAttribute).CreateAttribute(metadata.TemplateButton));
		list.Add(typeof(NeedAnswerAttribute).CreateAttribute(metadata.NeedAnswer));
		list.Add(typeof(AnswerDocumentPropertyAttribute).CreateAttribute(metadata.AnswerDocumentProperty.ToString()));
		list.Add(typeof(DefaultManagerAttribute).CreateAttribute(typeof(DocumentManagerMaker)));
		list.Add(typeof(EnableCryptoAttribute).CreateAttribute(metadata.EnableCrypto));
		list.Add(typeof(UseLifeCycleAttribute).CreateAttribute(metadata.UseLifeCycle));
		if (metadata.CryptoSettings != null)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary["CryptoEntityTypeUidStr"] = metadata.CryptoSettings.CryptoEntityTypeUidStr;
			dictionary["CryptoAttributesStr"] = metadata.CryptoSettings.CryptoAttributesStr;
			dictionary["CryptoTableName"] = metadata.CryptoSettings.CryptoTableName;
			list.Add(typeof(CryptoSettings).CreateAttribute(dictionary.ToArray()));
		}
		type.AddAttributes(list);
	}

	protected override void WritePropertyAttributes(ISyntaxNode property, PropertyMetadata propertyMetadata, string resourcePrefix = null)
	{
		base.WritePropertyAttributes(property, propertyMetadata, resourcePrefix);
		if (propertyMetadata is DocumentAttributeMetadata documentAttributeMetadata && documentAttributeMetadata.RegistrationCardProperty != null)
		{
			property.AddAttributes(typeof(MapAttribute).CreateAttribute(documentAttributeMetadata.RegistrationCardProperty.PropertyUid.ToString(), documentAttributeMetadata.RegistrationCardProperty.ClassUid.ToString()));
		}
	}

	protected override IEnumerable<ISyntaxNode> GetProperties(List<ISyntaxNode> ctorStatements)
	{
		foreach (ISyntaxNode property in base.GetProperties(ctorStatements))
		{
			yield return property;
		}
		if (!metadata.IsInterfaceType && metadata.ControlOnSending)
		{
			PropertyMetadata propertyMetadata = metadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "SendDocumentType");
			if (propertyMetadata != null)
			{
				yield return AddPropertyInterface(propertyMetadata, typeof(ISendDocumentType));
			}
			PropertyMetadata propertyMetadata2 = metadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "SendUser");
			if (propertyMetadata2 != null)
			{
				yield return AddPropertyInterface(propertyMetadata2, typeof(IUser));
			}
		}
	}

	private ISyntaxNode AddPropertyInterface(PropertyMetadata propertyMetadata, Type entityType)
	{
		ISyntaxNode type = entityType.CreateTypeSyntax();
		ISyntaxNode syntaxNode = propertyMetadata.Name.IdentifierName();
		ISyntaxNode propertyTypeReference = ((ITypeGenerationInfo)GetPropertyTypeDescriptor(propertyMetadata)).GetPropertyTypeReference(metadata, propertyMetadata, forFilter: false);
		return propertyMetadata.Name.PropertyDeclaration(type, Accessibility.NotApplicable, DeclarationModifiers.None, new ISyntaxNode[1] { syntaxNode.CastExpression(type).ReturnStatement() }, new ISyntaxNode[1] { syntaxNode.AssignmentStatement(SyntaxGeneratorExtensions.Value.CastExpression(propertyTypeReference)) }).AsPrivateInterfaceImplementation(typeof(ISendableDocument).CreateTypeSyntax());
	}
}
