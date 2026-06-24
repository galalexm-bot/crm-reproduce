using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UIBuilder.CodeGeneration.Types;

namespace EleWise.ELMA.UIBuilder.CodeGeneration;

internal sealed class EntityClientScriptGenerator : AbstractClientScriptGenerator
{
	private readonly ScriptModule scriptModule;

	private readonly IEntityFormsService entityFormsService;

	internal EntityClientScriptGenerator(ScriptModule scriptModule, IEntityFormsService entityFormsService, IUITypeGenerationFacade uiTypeGenerationFacade)
		: base(uiTypeGenerationFacade)
	{
		this.scriptModule = scriptModule;
		this.entityFormsService = entityFormsService;
	}

	protected override string GetClassName()
	{
		return metadata.Name + "Scripts";
	}

	protected override IEnumerable<ISyntaxNode> GetServerInterfaceMembers()
	{
		List<ISyntaxNode> list = new List<ISyntaxNode>();
		if (scriptModule == null)
		{
			return list;
		}
		ITablePartContainer tablePartContainer;
		Lazy<Dictionary<string, ITablePartMetadata>> lazy = (((tablePartContainer = metadata as ITablePartContainer) != null) ? new Lazy<Dictionary<string, ITablePartMetadata>>(() => tablePartContainer.TableParts.SelectRecursive((ITablePartMetadata m) => (!(m is ITablePartContainer tablePartContainer2)) ? Enumerable.Empty<ITablePartMetadata>() : tablePartContainer2.TableParts).ToDictionary((ITablePartMetadata tp) => metadata.Namespace + ".I" + tp.Name)) : null);
		string text = "I" + MetadataName;
		string pattern = "(\\w+\\.)*(?<typeName>\\w+)";
		foreach (ScriptMethodDeclaration scriptMethod in scriptModule.ScriptMethods)
		{
			if (scriptMethod.ReturnType != "void")
			{
				continue;
			}
			List<ScriptMethodParameter> parameters = scriptMethod.Parameters;
			if (parameters.Count != 1 && parameters.Count != 2 && parameters.Count != 3)
			{
				continue;
			}
			Match match = Regex.Match(parameters[0].Type, pattern);
			if (!match.Success || match.Groups["typeName"].Value != text)
			{
				continue;
			}
			if (parameters.Count == 2)
			{
				ScriptMethodParameter scriptMethodParameter = parameters[1];
				if (scriptMethodParameter.Name != "form")
				{
					continue;
				}
				Match match2 = Regex.Match(scriptMethodParameter.Type, pattern);
				if (!match2.Success)
				{
					continue;
				}
				string value = match2.Groups["typeName"].Value;
				if (value == "FormViewBuilder")
				{
					Match match3 = match2.NextMatch();
					if (!match3.Success)
					{
						continue;
					}
					value = match3.Groups["typeName"].Value;
					if (value != text)
					{
						continue;
					}
				}
				else if (value != "ViewModel")
				{
					continue;
				}
			}
			if (parameters.Count == 3 && lazy != null)
			{
				ScriptMethodParameter scriptMethodParameter2 = parameters[1];
				if (scriptMethodParameter2.Name != "item" || !lazy.Value.TryGetValue(scriptMethodParameter2.Type, out var value2))
				{
					continue;
				}
				ScriptMethodParameter scriptMethodParameter3 = parameters[2];
				if (scriptMethodParameter3.Name != "form")
				{
					continue;
				}
				Match match4 = Regex.Match(scriptMethodParameter3.Type, pattern);
				if (!match4.Success)
				{
					continue;
				}
				string name = value2.Name;
				string value3 = match4.Groups["typeName"].Value;
				if (value3 == "FormViewBuilder")
				{
					Match match5 = match4.NextMatch();
					if (!match5.Success)
					{
						continue;
					}
					value3 = match5.Groups["typeName"].Value;
					if (value3 != "I" + name)
					{
						continue;
					}
				}
				else if (value3 != "I" + name + "_ViewModel")
				{
					continue;
				}
			}
			list.Add(scriptMethod.Name.MethodDeclaration(null, null, typeof(Task).CreateTypeSyntax(useGlobal: false)));
		}
		return list;
	}

	protected override AdditionalMethodsGenerationParameters GetParameters()
	{
		if (entityFormsService == null)
		{
			return null;
		}
		if (metadata is EntityMetadata entityMetadata && entityMetadata.ViewModelMetadata != null)
		{
			IEnumerable<FormViewItem> allForms = entityFormsService.GetAllForms(metadata);
			return new AdditionalMethodsGenerationParameters(entityMetadata.ViewModelMetadata, allForms.Where((FormViewItem form) => form.RuntimeVersion == RuntimeVersion.Version2));
		}
		return null;
	}

	protected override IEnumerable<ISyntaxNode> GetViewModelContextCollection()
	{
		List<ISyntaxNode> list = new List<ISyntaxNode>();
		EntityMetadata targetMetadata = (EntityMetadata)ClassSerializationHelper.CloneObjectByXml(metadata);
		Guid baseClassUid;
		do
		{
			if (targetMetadata?.ViewModelMetadata == null)
			{
				if (targetMetadata.Type == EntityMetadataType.Interface && targetMetadata.BaseClassUid != Guid.Empty)
				{
					foreach (EntityMetadata item in from a in MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>()
						where a.Type == EntityMetadataType.InterfaceExtension && a.BaseClassUid == targetMetadata.BaseClassUid
						select a)
					{
						targetMetadata = ClassSerializationHelper.CloneObjectByXml(item);
						GenerateViewModelContext(list, targetMetadata);
					}
				}
			}
			else
			{
				GenerateViewModelContext(list, targetMetadata);
			}
			baseClassUid = targetMetadata.BaseClassUid;
			EntityMetadata entityMetadata = ((baseClassUid != Guid.Empty) ? ((EntityMetadata)MetadataServiceContext.Service.GetMetadata(baseClassUid, loadImplementation: false)) : null);
			targetMetadata = ((entityMetadata != null) ? ClassSerializationHelper.CloneObjectByXml(entityMetadata) : null);
		}
		while (baseClassUid != Guid.Empty);
		if (generationParams.Mode != 0)
		{
			list.Add(GenerateEntityClass());
		}
		return list;
	}

	private void GenerateViewModelContext(List<ISyntaxNode> result, EntityMetadata targetMetadata)
	{
		if (targetMetadata.ViewModelMetadata == null)
		{
			return;
		}
		if (targetMetadata.Uid != metadata.Uid)
		{
			targetMetadata.ViewModelMetadata.Properties.RemoveAll((PropertyMetadata property) => property.Name == "Model");
		}
		using (MetadataServiceContext.Extend(targetMetadata.GetAllTableParts()))
		{
			ViewModelContextWebGenerator viewModelContextWebGenerator = new ViewModelContextWebGenerator(targetMetadata.Name, UITypeGenerationFacade);
			((ICodeGenerator)viewModelContextWebGenerator).Metadata = targetMetadata.ViewModelMetadata;
			viewModelContextWebGenerator.AddIgnoreNamespace(metadata.Namespace);
			result.Add(viewModelContextWebGenerator.Generate());
		}
	}

	private ISyntaxNode GenerateEntityClass()
	{
		return SyntaxGeneratorExtensions.ClassDeclaration(baseType: ((metadata.BaseClassUid != Guid.Empty) ? ((EntityMetadata)MetadataServiceContext.Service.GetMetadata(metadata.BaseClassUid)) : null)?.FullTypeName.CreateTypeSyntax(), name: metadata.Name, accessibility: Accessibility.Private, modifiers: DeclarationModifiers.Sealed, interfaceTypes: null, members: GetEntityClassMembers());
	}

	private IEnumerable<ISyntaxNode> GetEntityClassMembers()
	{
		List<ISyntaxNode> list = new List<ISyntaxNode>();
		if (generationParams.Mode == GenerationMode.Publish || metadata.Properties == null)
		{
			return list;
		}
		foreach (PropertyMetadata property in metadata.Properties)
		{
			ISyntaxNode syntaxNode = WritePropertyGetSet(property);
			if (syntaxNode != null)
			{
				list.Add(syntaxNode);
			}
		}
		EntityMetadata entityMetadata;
		if ((entityMetadata = metadata as EntityMetadata) != null)
		{
			List<TablePartMetadata> tableParts = entityMetadata.TableParts;
			if (tableParts != null && tableParts.Count != 0)
			{
				foreach (ISyntaxNode item in entityMetadata.TableParts.SelectMany((TablePartMetadata t) => WriteTablePartClass(t, entityMetadata)))
				{
					list.Add(item);
				}
				return list;
			}
		}
		return list;
	}

	private IEnumerable<ISyntaxNode> WriteTablePartClass(TablePartMetadata tablePart, EntityMetadata entityMetadata)
	{
		Contract.ArgumentNotNull(tablePart, "tablePart");
		EntityPropertyTablePartMetadata propertyMetadata = new EntityPropertyTablePartMetadata(entityMetadata, tablePart);
		return new ISyntaxNode[1] { WritePropertyGetSet(propertyMetadata) };
	}

	private ISyntaxNode WritePropertyGetSet(PropertyMetadata propertyMetadata)
	{
		Contract.ArgumentNotNull(propertyMetadata, "propertyMetadata");
		ITypeDescriptor propertyTypeDescriptor = GetPropertyTypeDescriptor(propertyMetadata);
		if (!UITypeGenerationFacade.UIBuilderSupports(propertyTypeDescriptor))
		{
			return null;
		}
		ISyntaxNode propertyTypeReference = UITypeGenerationFacade.GetPropertyTypeReference(propertyTypeDescriptor, metadata, propertyMetadata, forFilter: false);
		return propertyMetadata.Name.PropertyDeclaration(propertyTypeReference, Accessibility.Public);
	}
}
