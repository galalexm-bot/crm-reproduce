using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UIBuilder.CodeGeneration;
using EleWise.ELMA.UIBuilder.CodeGeneration.Types;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.UIBuilder.CodeGeneration;

internal sealed class ProcessContextClientScriptGenerator : AbstractClientScriptGenerator
{
	private readonly ScriptModule scriptModule;

	private readonly IEnumerable<FormViewItem> forms;

	private readonly IMetadataService metadataService;

	public ProcessContextClientScriptGenerator(ScriptModule scriptModule, IEnumerable<FormViewItem> forms, IMetadataService metadataService, IUITypeGenerationFacade uiTypeGenerationFacade)
		: base(uiTypeGenerationFacade)
	{
		this.scriptModule = scriptModule;
		this.forms = forms;
		this.metadataService = metadataService;
	}

	protected override string GetClassName()
	{
		return metadata.Name + "_Scripts";
	}

	protected override AdditionalMethodsGenerationParameters GetParameters()
	{
		if (metadata is ProcessContext processContext && processContext.ViewModelMetadata != null)
		{
			return new AdditionalMethodsGenerationParameters(processContext.ViewModelMetadata, forms);
		}
		return null;
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
			if (scriptMethod.ReturnType != "void" || (scriptMethod.Parameters.Count != 1 && scriptMethod.Parameters.Count != 2 && scriptMethod.Parameters.Count != 3))
			{
				continue;
			}
			Match match = Regex.Match(scriptMethod.Parameters[0].Type, pattern);
			if (!match.Success || match.Groups["typeName"].Value != "Context")
			{
				continue;
			}
			if (scriptMethod.Parameters.Count == 2)
			{
				ScriptMethodParameter scriptMethodParameter = scriptMethod.Parameters[1];
				if (scriptMethodParameter.Name == "form")
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
					if (value != "Context")
					{
						continue;
					}
				}
				else if (value != "ViewModel")
				{
					continue;
				}
			}
			if (scriptMethod.Parameters.Count == 3)
			{
				if (scriptMethod.Parameters[1].Name != "item")
				{
					continue;
				}
				ScriptMethodParameter scriptMethodParameter2 = scriptMethod.Parameters[2];
				if (scriptMethodParameter2.Name != "form")
				{
					continue;
				}
				Match match4 = Regex.Match(scriptMethodParameter2.Type, pattern);
				if (!match4.Success)
				{
					continue;
				}
				string value2 = match4.Groups["typeName"].Value;
				if (value2 == "FormViewBuilder")
				{
					if (!match4.NextMatch().Success)
					{
						continue;
					}
				}
				else if (!value2.EndsWith("_ViewModel"))
				{
					continue;
				}
			}
			list.Add(scriptMethod.Name.MethodDeclaration(null, null, typeof(Task).CreateTypeSyntax(useGlobal: false)));
		}
		return list;
	}

	protected override IEnumerable<ISyntaxNode> GetViewModelContextCollection()
	{
		List<ISyntaxNode> list = new List<ISyntaxNode>();
		List<EntityMetadata> list2 = new List<EntityMetadata>();
		EntityMetadata entityMetadata = (EntityMetadata)ClassSerializationHelper.CloneObjectByXml(metadata);
		while (entityMetadata != null)
		{
			list2.Add(entityMetadata);
			Guid baseClassUid = entityMetadata.BaseClassUid;
			EntityMetadata entityMetadata2 = ((baseClassUid != Guid.Empty) ? ((EntityMetadata)metadataService.GetMetadata(baseClassUid, loadImplementation: false)) : null);
			entityMetadata = ((entityMetadata2 != null) ? ClassSerializationHelper.CloneObjectByXml(entityMetadata2) : null);
			if (!(baseClassUid != Guid.Empty))
			{
				break;
			}
		}
		foreach (EntityMetadata item in list2)
		{
			if (item.ViewModelMetadata == null)
			{
				break;
			}
			if (item.Uid != metadata.Uid)
			{
				item.ViewModelMetadata.Properties.RemoveAll((PropertyMetadata property) => property.Name == "Model");
			}
			if (generationParams.Mode == GenerationMode.CodeEditor)
			{
				item.ViewModelMetadata.Properties.RemoveAll((PropertyMetadata property) => property.Name == "WorkflowTask");
			}
			IEnumerable<IMetadata> enumerable = entityMetadata?.GetAllTableParts();
			using (MetadataServiceContext.Extend(enumerable ?? Enumerable.Empty<IMetadata>()))
			{
				ViewModelContextWebGenerator viewModelContextWebGenerator = new ViewModelContextWebGenerator(item.Name, UITypeGenerationFacade);
				((ICodeGenerator)viewModelContextWebGenerator).Metadata = item.ViewModelMetadata;
				viewModelContextWebGenerator.AddIgnoreNamespace(metadata.Namespace);
				list.Add(viewModelContextWebGenerator.Generate());
			}
		}
		list.Add(GenerateProcessClass(metadata.Name, list2));
		foreach (EntityMetadata item2 in list2)
		{
			list.AddRange(WriteTablePartClasses(item2.TableParts));
		}
		return list;
	}

	private ISyntaxNode GenerateProcessClass(string className, List<EntityMetadata> metadataList)
	{
		return className.ClassDeclaration(Accessibility.Private, DeclarationModifiers.Sealed, null, null, GetProcessClassMembers(metadataList));
	}

	private IEnumerable<ISyntaxNode> GetProcessClassMembers(List<EntityMetadata> metadataList)
	{
		List<ISyntaxNode> list = new List<ISyntaxNode>();
		foreach (EntityMetadata entityMetadata in metadataList)
		{
			foreach (PropertyMetadata property in entityMetadata.Properties)
			{
				if (!(entityMetadata.Uid != metadata.Uid) || ((!property.IsSystem || !(property.Name == "Uid")) && !(property.Uid == ProcessContext.DefaultProperties.WorkflowInstance.Uid)))
				{
					ISyntaxNode syntaxNode = WritePropertyGetSet(property, entityMetadata);
					if (syntaxNode != null)
					{
						list.Add(syntaxNode);
					}
				}
			}
			List<TablePartMetadata> tableParts = entityMetadata.TableParts;
			if (tableParts == null || tableParts.Count == 0)
			{
				continue;
			}
			foreach (ISyntaxNode item in entityMetadata.TableParts.SelectMany((TablePartMetadata t) => WriteTablePartProperty(t, entityMetadata)))
			{
				list.Add(item);
			}
		}
		return list;
	}

	private ISyntaxNode WritePropertyGetSet(PropertyMetadata propertyMetadata, EntityMetadata entityMetadata)
	{
		Contract.ArgumentNotNull(propertyMetadata, "propertyMetadata");
		ITypeDescriptor propertyTypeDescriptor = GetPropertyTypeDescriptor(propertyMetadata);
		if (!UITypeGenerationFacade.UIBuilderSupports(propertyTypeDescriptor))
		{
			return null;
		}
		ISyntaxNode propertyTypeReference = UITypeGenerationFacade.GetPropertyTypeReference(propertyTypeDescriptor, entityMetadata, propertyMetadata, forFilter: false);
		ISyntaxNode syntaxNode = propertyMetadata.Name.PropertyDeclaration(propertyTypeReference, Accessibility.Public);
		syntaxNode.XmlComments(propertyMetadata.DisplayName.SummaryComment());
		return syntaxNode;
	}

	private IEnumerable<ISyntaxNode> WriteTablePartClasses(List<TablePartMetadata> tableParts)
	{
		List<ISyntaxNode> list = new List<ISyntaxNode>();
		if (tableParts == null || tableParts.Count == 0)
		{
			return list;
		}
		foreach (TablePartMetadata tablePart in tableParts)
		{
			ISyntaxNode item = WriteTablePartClass(tablePart);
			list.Add(item);
			list.AddRange(WriteTablePartClasses(tablePart.TableParts));
		}
		return list;
	}

	private ISyntaxNode WriteTablePartClass(TablePartMetadata tablePart)
	{
		return tablePart.Name.ClassDeclaration(Accessibility.Private, DeclarationModifiers.Sealed, null, null, GetTablePartMembers(tablePart));
	}

	private IEnumerable<ISyntaxNode> GetTablePartMembers(TablePartMetadata tablePartMetadata)
	{
		List<ISyntaxNode> list = new List<ISyntaxNode>();
		foreach (PropertyMetadata property in tablePartMetadata.Properties)
		{
			if (!(property.Name == "Parent") && WritePropertyGetSet(property, tablePartMetadata) != null)
			{
				list.Add(WritePropertyGetSet(property, tablePartMetadata));
			}
		}
		foreach (TablePartMetadata tablePart in tablePartMetadata.TableParts)
		{
			list.AddRange(WriteTablePartProperty(tablePart, tablePartMetadata));
		}
		return list;
	}

	private IEnumerable<ISyntaxNode> WriteTablePartProperty(TablePartMetadata tablePart, EntityMetadata entityMetadata)
	{
		Contract.ArgumentNotNull(tablePart, "tablePart");
		EntityPropertyTablePartMetadata entityPropertyTablePartMetadata = new EntityPropertyTablePartMetadata(entityMetadata, tablePart);
		ISyntaxNode type = TypeOf.ISet.Raw.CreateTypeSyntax(false, tablePart.Name.CreateTypeSyntax());
		ISyntaxNode syntaxNode = entityPropertyTablePartMetadata.Name.PropertyDeclaration(type, Accessibility.Public);
		syntaxNode.XmlComments(entityPropertyTablePartMetadata.DisplayName.SummaryComment());
		return new ISyntaxNode[1] { syntaxNode };
	}
}
