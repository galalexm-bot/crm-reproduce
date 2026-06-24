using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UIBuilder.CodeGeneration.Types;

namespace EleWise.ELMA.UIBuilder.CodeGeneration;

public sealed class ViewModelContextWebGenerator : ClassGenerator
{
	private readonly string metadataName;

	private readonly IUITypeGenerationFacade uiTypeGenerationFacade;

	private const string DataClass = "DataClass";

	private const string Context = "IContext";

	private string ClassName => metadataName + "ViewModelContext";

	public ViewModelContextWebGenerator(string metadataName, IUITypeGenerationFacade uiTypeGenerationFacade)
	{
		this.metadataName = metadataName;
		this.uiTypeGenerationFacade = uiTypeGenerationFacade;
	}

	public ISyntaxNode Generate()
	{
		return ignoreNamespaces.WithIgnoreNamespaces(() => ClassName.ClassDeclaration(Accessibility.Private, DeclarationModifiers.Sealed, GetBaseClass(), GetBaseInterfaces(), GetMembers()));
	}

	public void AddIgnoreNamespace(string ignoreNamespace)
	{
		ignoreNamespaces?.Add(ignoreNamespace);
	}

	protected override void InitIgnoreNamespaces(IMetadata metadata)
	{
		ignoreNamespaces.Clear();
		ignoreNamespaces.Add("System");
	}

	protected override ISyntaxNode GetBaseClass()
	{
		return "DataClass".CreateTypeSyntax();
	}

	protected override IEnumerable<ISyntaxNode> GetBaseInterfaces()
	{
		return new ISyntaxNode[1] { "IContext".CreateTypeSyntax() };
	}

	protected override IEnumerable<ISyntaxNode> GetMembers()
	{
		return GetProperties(new List<ISyntaxNode>());
	}

	protected override void WritePropertyAttributes(ISyntaxNode property, PropertyMetadata propertyMetadata, string resourcePrefix = null)
	{
		if (metadata is DataClassMetadata dataClassMetadata)
		{
			property.AddAttributes("Bridge.Name".CreateAttribute($"{propertyMetadata.Name}${dataClassMetadata.Uid:n}"));
		}
	}

	protected override IEnumerable<ISyntaxNode> WriteProperty(PropertyMetadata propertyMetadata, List<ISyntaxNode> ctorStatements, bool writeAttributes = true, Action<ISyntaxNode> propertyAction = null)
	{
		Contract.ArgumentNotNull(propertyMetadata, "propertyMetadata");
		ITypeDescriptor propertyTypeDescriptor = GetPropertyTypeDescriptor(propertyMetadata);
		if (propertyTypeDescriptor == null)
		{
			return Enumerable.Empty<ISyntaxNode>();
		}
		if (!uiTypeGenerationFacade.UIBuilderSupports(propertyTypeDescriptor))
		{
			return Enumerable.Empty<ISyntaxNode>();
		}
		ISyntaxNode propertyTypeReference = uiTypeGenerationFacade.GetPropertyTypeReference(propertyTypeDescriptor, metadata, propertyMetadata, forFilter: false);
		ISyntaxNode syntaxNode = propertyMetadata.Name.AutoPropertyDeclaration(propertyTypeReference, Accessibility.Internal);
		if (writeAttributes)
		{
			WritePropertyComments(syntaxNode, propertyMetadata);
			WritePropertyAttributes(syntaxNode, propertyMetadata);
		}
		return new ISyntaxNode[1] { syntaxNode };
	}
}
