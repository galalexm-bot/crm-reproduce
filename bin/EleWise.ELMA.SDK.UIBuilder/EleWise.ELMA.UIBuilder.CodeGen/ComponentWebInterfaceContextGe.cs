using System.Collections.Generic;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UIBuilder.CodeGeneration.Types;

namespace EleWise.ELMA.UIBuilder.CodeGeneration;

internal sealed class ComponentWebInterfaceContextGenerator : ComponentWebContextGenerator
{
	internal const string InterfaceContext = "IComponentContext";

	public ComponentWebInterfaceContextGenerator(IUITypeGenerationFacade uiTypeGenerationFacade)
		: base(uiTypeGenerationFacade)
	{
	}

	protected override IEnumerable<ISyntaxNode> GenerateMainFile()
	{
		ISyntaxNode syntaxNode = ignoreNamespaces.WithIgnoreNamespaces(() => "IComponentContext".InterfaceDeclaration(Accessibility.Private, DeclarationModifiers.None, GetBaseInterfaces(), GetMembers()));
		WriteTypeAttributes(syntaxNode);
		return new ISyntaxNode[1] { syntaxNode };
	}

	protected override IEnumerable<ISyntaxNode> GetMembers()
	{
		return GetProperties(new List<ISyntaxNode>());
	}

	protected override IEnumerable<ISyntaxNode> GetBaseInterfaces()
	{
		return new ISyntaxNode[1] { "EleWise.ELMA.Model.ViewModel.IContext".CreateTypeSyntax(useGlobal: false) };
	}

	protected override void WriteTypeAttributes(ISyntaxNode type)
	{
	}

	protected override void WritePropertyAttributes(ISyntaxNode property, PropertyMetadata propertyMetadata, string resourcePrefix = null)
	{
	}

	protected override ISyntaxNode PropertyDeclaration(PropertyMetadata propertyMetadata, ISyntaxNode propertyType, IEnumerable<ISyntaxNode> getAccessorStatements = null, IEnumerable<ISyntaxNode> setAccessorStatements = null)
	{
		getAccessorStatements = new ISyntaxNode[1] { "property".CreateTypeSyntax() };
		return propertyMetadata.Name.PropertyDeclaration(propertyType, Accessibility.NotApplicable, DeclarationModifiers.Virtual, getAccessorStatements);
	}
}
