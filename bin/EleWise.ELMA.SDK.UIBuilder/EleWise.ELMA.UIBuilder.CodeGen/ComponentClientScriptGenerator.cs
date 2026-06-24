using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UIBuilder.CodeGeneration.Types;

namespace EleWise.ELMA.UIBuilder.CodeGeneration;

internal sealed class ComponentClientScriptGenerator : AbstractClientScriptGenerator
{
	private readonly ScriptModule scriptModule;

	private readonly IUITypeGenerationFacade uiTypeGenerationFacade;

	private ComponentMetadata componentMetadata;

	protected override string ControllerName => "ComponentController";

	protected override string ContextName => "_Context";

	public ComponentClientScriptGenerator(ScriptModule scriptModule, IUITypeGenerationFacade uiTypeGenerationFacade)
		: base(uiTypeGenerationFacade)
	{
		this.scriptModule = scriptModule;
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

	protected override string GetClassName()
	{
		return componentMetadata.Name;
	}

	protected override IEnumerable<ISyntaxNode> GetServerInterfaceMembers()
	{
		List<ISyntaxNode> list = new List<ISyntaxNode>();
		if (scriptModule == null)
		{
			return list;
		}
		string pattern = "(\\w+\\.)*(?<typeName>\\w+)";
		foreach (ScriptMethodDeclaration scriptMethod in scriptModule.ScriptMethods)
		{
			if (!(scriptMethod.ReturnType != "void") && scriptMethod.Parameters.Count == 1)
			{
				Match match = Regex.Match(scriptMethod.Parameters[0].Type, pattern);
				if (match.Success && !(match.Groups["typeName"].Value != "ViewModel"))
				{
					list.Add(scriptMethod.Name.MethodDeclaration(null, null, typeof(Task).CreateTypeSyntax(useGlobal: false)));
				}
			}
		}
		return list;
	}

	protected override AdditionalMethodsGenerationParameters GetParameters()
	{
		return new AdditionalMethodsGenerationParameters(componentMetadata.Content.Context, componentMetadata.Content.View, componentMetadata.ViewScriptUid.HasValue);
	}

	protected override IEnumerable<ISyntaxNode> GetViewModelContextCollection()
	{
		using (MetadataServiceContext.Extend(componentMetadata.GetMetadataToRegister()))
		{
			return GenerateContext().Concat(GenerateDataClasses());
		}
	}

	protected override IEnumerable<ISyntaxNode> GetNamespaces()
	{
		if (componentMetadata.CustomTypeImplementation == null || componentMetadata.CustomTypeImplementation.TypeUid == Guid.Empty)
		{
			return base.GetNamespaces();
		}
		return base.GetNamespaces().Concat(new ISyntaxNode[1] { "EleWise.ELMA.SDK.DTO.Model.Types.Settings".NamespaceImportDeclaration() });
	}

	protected override ISyntaxNode GetBaseControllerType()
	{
		if (componentMetadata.CustomTypeImplementation == null || componentMetadata.CustomTypeImplementation.TypeUid == Guid.Empty)
		{
			return base.GetBaseControllerType();
		}
		ITypeDescriptor typeDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(componentMetadata.CustomTypeImplementation.TypeUid, componentMetadata.CustomTypeImplementation.SubTypeUid);
		if (typeDescriptor == null)
		{
			return base.GetBaseControllerType();
		}
		if (generationParams.Mode == GenerationMode.Publish)
		{
			return ("BaseCustomController<IServer," + ContextName + ">").CreateTypeSyntax();
		}
		ISyntaxNode syntaxNode;
		if (typeDescriptor is IRuntimeTypeDescriptor runtimeTypeDescriptor)
		{
			syntaxNode = runtimeTypeDescriptor.RuntimeType.CreateTypeSyntax();
		}
		else
		{
			PropertyMetadata propertyMetadata = componentMetadata.Content.Context.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "Value");
			if (propertyMetadata == null)
			{
				return base.GetBaseControllerType();
			}
			syntaxNode = GetPropertyTypeReference(propertyMetadata, (ITypeGenerationInfo)typeDescriptor);
		}
		string text = string.Concat(typeDescriptor.SettingsType.Name.CreateTypeSyntax(useGlobal: false), "DTO");
		return string.Format("BaseCustomController<{0},{1},{2},{3}>", "IServer", syntaxNode, text, ContextName).CreateTypeSyntax();
	}

	protected override ISyntaxNode GetPropertyTypeReference(PropertyMetadata propertyMetadata, ITypeGenerationInfo typeDescriptor)
	{
		if (uiTypeGenerationFacade.UIBuilderSupports((ITypeDescriptor)typeDescriptor))
		{
			return uiTypeGenerationFacade.GetPropertyTypeReference((ITypeDescriptor)typeDescriptor, componentMetadata.Content.Context, propertyMetadata, forFilter: false);
		}
		return null;
	}

	private IEnumerable<ISyntaxNode> GenerateContext()
	{
		ComponentWebContextGenerator componentWebContextGenerator = new ComponentWebContextGenerator(UITypeGenerationFacade);
		ComponentContextMetadata context = componentMetadata.Content.Context;
		EntityMetadata entityMetadata = (EntityMetadata)(((ICodeGenerator)componentWebContextGenerator).Metadata = new EntityMetadata
		{
			Properties = context.Properties,
			Namespace = GetNamespace(),
			Name = context.Name,
			DisplayName = context.DisplayName,
			Uid = context.Uid,
			Type = EntityMetadataType.Entity
		});
		return componentWebContextGenerator.Generate();
	}

	private IEnumerable<ISyntaxNode> GenerateDataClasses()
	{
		List<ISyntaxNode> list = new List<ISyntaxNode>();
		foreach (DataClassMetadata dataClass in componentMetadata.DataClasses)
		{
			DataClassWebGenerator dataClassWebGenerator = new DataClassWebGenerator(UITypeGenerationFacade);
			((ICodeGenerator)dataClassWebGenerator).Metadata = dataClass;
			dataClassWebGenerator.AddIgnoreNamespace(GetNamespace());
			list.AddRange(dataClassWebGenerator.Generate());
		}
		return list;
	}
}
