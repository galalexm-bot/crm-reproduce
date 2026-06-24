using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;

namespace EleWise.ELMA.UIBuilder.CodeGeneration;

internal sealed class ComponentTestScriptGenerator : CodeGenerator
{
	private ComponentMetadata componentMetadata;

	private const string TestFileExtension = ".Test.designer";

	protected override void InitInternal(IMetadata metadata)
	{
		Contract.ArgumentNotNull(metadata, "metadata");
		Contract.CheckArgument(metadata is ComponentMetadata, "metadata is ComponentMetadata");
		componentMetadata = (ComponentMetadata)metadata;
	}

	protected override GeneratedFileInfo GenerateMainFileInternal()
	{
		try
		{
			ISyntaxNode[] declarations = GetNamespaces().Concat(componentMetadata.Namespace.NamespaceDeclaration(GenerateClass())).ToArray();
			return GenerateMainFileHelper(".Test.designer", declarations);
		}
		catch (Exception innerException)
		{
			throw new CodeGenerationException(SR.T("Ошибка генерации класса \"{0}\"", componentMetadata.Name), innerException);
		}
	}

	protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal()
	{
		return Enumerable.Empty<GeneratedFileInfo>();
	}

	private ISyntaxNode GenerateClass()
	{
		ISyntaxNode baseType = "ComponentTest<_Context,ComponentController, IServer>".CreateTypeSyntax();
		ISyntaxNode syntaxNode = "ComponentTests".ClassDeclaration(Accessibility.Private, DeclarationModifiers.Sealed | DeclarationModifiers.Partial, baseType, null, new ISyntaxNode[1] { GenerateField() });
		syntaxNode.AddAttributes("TestFixtureAttribute".CreateAttribute());
		return componentMetadata.Name.ClassDeclaration(Accessibility.NotApplicable, DeclarationModifiers.Partial, null, null, new ISyntaxNode[1] { syntaxNode });
	}

	private static IEnumerable<ISyntaxNode> GetNamespaces()
	{
		return new ISyntaxNode[2]
		{
			"EleWise.ELMA.TestFramework".NamespaceImportDeclaration(),
			"EleWise.ELMA.TestFramework.API".NamespaceImportDeclaration()
		};
	}

	private ISyntaxNode GenerateField()
	{
		return "ComponentUid".PropertyDeclaration(typeof(string).CreateTypeSyntax(), Accessibility.Public, DeclarationModifiers.Override, new ISyntaxNode[1] { componentMetadata.Uid.ToString().CreateStringSyntaxNode().ReturnStatement() });
	}
}
