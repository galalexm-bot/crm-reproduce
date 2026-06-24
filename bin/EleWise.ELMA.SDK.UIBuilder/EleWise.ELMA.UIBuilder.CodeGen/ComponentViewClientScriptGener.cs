using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UIBuilder.CodeGeneration.Types;

namespace EleWise.ELMA.UIBuilder.CodeGeneration;

internal sealed class ComponentViewClientScriptGenerator : ClassGenerator
{
	private const string ControllerFileExtension = ".View.designer";

	private const string ViewModelParamName = "viewModel";

	private ComponentMetadata componentMetadata;

	private readonly ScriptModule clientScriptModule;

	private readonly IUITypeGenerationFacade uiTypeGenerationFacade;

	protected string MetadataName => componentMetadata.Name;

	public ComponentViewClientScriptGenerator(ScriptModule clientScriptModule, IUITypeGenerationFacade uiTypeGenerationFacade)
	{
		this.clientScriptModule = clientScriptModule;
		this.uiTypeGenerationFacade = uiTypeGenerationFacade;
	}

	protected override void InitInternal(IMetadata metadata)
	{
		Contract.ArgumentNotNull(metadata, "metadata");
		Contract.CheckArgument(metadata is ComponentMetadata, "metadata is ComponentMetadata");
		componentMetadata = (ComponentMetadata)metadata;
	}

	protected override string GetNamespace()
	{
		return componentMetadata.Namespace;
	}

	protected string GetClassName()
	{
		return componentMetadata.Name;
	}

	protected override void InitIgnoreNamespaces(IMetadata metadata)
	{
		ignoreNamespaces.Clear();
	}

	protected override IEnumerable<ISyntaxNode> GenerateMainFile()
	{
		return new ISyntaxNode[1] { GetClassName().ClassDeclaration(Accessibility.Internal, DeclarationModifiers.Sealed | DeclarationModifiers.Partial, null, null, GetMembers()) };
	}

	protected override GeneratedFileInfo GenerateMainFileInternal()
	{
		try
		{
			IEnumerable<ISyntaxNode> declarations = GenerateMainFile();
			string @namespace = GetNamespace();
			if (!string.IsNullOrWhiteSpace(@namespace))
			{
				declarations = GetNamespaces().Concat(@namespace.NamespaceDeclaration(declarations)).ToArray();
			}
			return GenerateMainFileHelper(".View.designer", declarations);
		}
		catch (Exception innerException)
		{
			throw new CodeGenerationException(SR.T("Ошибка генерации класса \"{0}\"", MetadataName), innerException);
		}
	}

	protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal()
	{
		return new GeneratedFileInfo[0];
	}

	protected override IEnumerable<ISyntaxNode> GetNamespaces()
	{
		return new ISyntaxNode[12]
		{
			"System".NamespaceImportDeclaration(),
			"System.Collections.Generic".NamespaceImportDeclaration(),
			"System.Threading.Tasks".NamespaceImportDeclaration(),
			"System.Linq".NamespaceImportDeclaration(),
			"Bridge.React".NamespaceImportDeclaration(),
			"EleWise.ELMA.Core".NamespaceImportDeclaration(),
			"EleWise.ELMA.Core.Controllers".NamespaceImportDeclaration(),
			"EleWise.ELMA.Core.Services".NamespaceImportDeclaration(),
			"EleWise.ELMA.Model.Validation".NamespaceImportDeclaration(),
			"EleWise.ELMA.Core.React.Models".NamespaceImportDeclaration(),
			"EleWise.ELMA.Model.ViewModel".NamespaceImportDeclaration(),
			"EleWise.ELMA.DataClasses".NamespaceImportDeclaration()
		};
	}

	protected override IEnumerable<ISyntaxNode> GetMembers()
	{
		return new ISyntaxNode[2]
		{
			GetViewModelController(),
			GetInterfaceController()
		}.Concat(GetInterfaceContext());
	}

	private ISyntaxNode GetViewModelController()
	{
		return "Renderer".ClassDeclaration(Accessibility.Private, DeclarationModifiers.Sealed | DeclarationModifiers.Partial, GetBaseCustomViewType(), null, new ISyntaxNode[1] { GetCtor() });
	}

	private static ISyntaxNode GetCtor()
	{
		return SyntaxGeneratorExtensions.ConstructorDeclaration(new ISyntaxNode[1] { "viewModel".ParameterDeclaration("IComponentViewItemViewModel".CreateTypeSyntax()) }, Accessibility.Public, DeclarationModifiers.None, new ISyntaxNode[1] { "viewModel".CreateTypeSyntax() });
	}

	private ISyntaxNode GetBaseCustomViewType()
	{
		if (generationParams.Mode == GenerationMode.Publish)
		{
			return "BaseCustomView<_Context, ComponentController>".CreateTypeSyntax(useGlobal: false);
		}
		return "BaseCustomView<IComponentContext, IComponentController>".CreateTypeSyntax(useGlobal: false);
	}

	private ISyntaxNode GetInterfaceController()
	{
		return "IComponentController".InterfaceDeclaration(Accessibility.Private, DeclarationModifiers.None, null, GetControllerMethods());
	}

	private IEnumerable<ISyntaxNode> GetInterfaceContext()
	{
		using (MetadataServiceContext.Extend(componentMetadata.GetMetadataToRegister()))
		{
			ComponentContextMetadata context = componentMetadata.Content.Context;
			EntityMetadata obj = new EntityMetadata
			{
				Properties = context.Properties,
				Namespace = GetNamespace(),
				Name = context.Name,
				DisplayName = context.DisplayName,
				Uid = context.Uid,
				Type = EntityMetadataType.Entity
			};
			return new ComponentWebInterfaceContextGenerator(uiTypeGenerationFacade)
			{
				Metadata = ClassSerializationHelper.CloneObjectByXml(obj)
			}.Generate();
		}
	}

	private IEnumerable<ISyntaxNode> GetControllerMethods()
	{
		List<ISyntaxNode> list = new List<ISyntaxNode>();
		foreach (ScriptMethodDeclaration scriptMethod in clientScriptModule.ScriptMethods)
		{
			list.Add(scriptMethod.Name.MethodDeclaration(scriptMethod.Parameters.Select((ScriptMethodParameter p) => p.Name.ParameterDeclaration(p.Type.CreateTypeSyntax())), null, scriptMethod.ReturnType.CreateTypeSyntax()));
		}
		return list;
	}
}
