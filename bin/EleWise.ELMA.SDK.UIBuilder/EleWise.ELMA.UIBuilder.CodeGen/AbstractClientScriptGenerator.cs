using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbar;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UIBuilder.CodeGeneration.Types;

namespace EleWise.ELMA.UIBuilder.CodeGeneration;

public abstract class AbstractClientScriptGenerator : ClassGenerator
{
	private const string ValidationResultName = "EleWise.ELMA.Model.Validation.ValidationResult";

	private const string ControllerFileExtension = ".Controller.designer";

	private const string ServerControllerFileExtension = ".ServerController.designer";

	private const string ContextFileExtension = ".Context.designer";

	protected readonly IUITypeGenerationFacade UITypeGenerationFacade;

	protected virtual string MetadataName => metadata.Name;

	protected virtual string ControllerName => "ViewModelController";

	protected virtual string ContextName => MetadataName + "ViewModelContext";

	protected AbstractClientScriptGenerator(IUITypeGenerationFacade uiTypeGenerationFacade)
	{
		UITypeGenerationFacade = uiTypeGenerationFacade;
	}

	protected abstract string GetClassName();

	protected abstract IEnumerable<ISyntaxNode> GetServerInterfaceMembers();

	protected abstract AdditionalMethodsGenerationParameters GetParameters();

	protected abstract IEnumerable<ISyntaxNode> GetViewModelContextCollection();

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
			return GenerateMainFileHelper(".Controller.designer", declarations);
		}
		catch (Exception innerException)
		{
			throw new CodeGenerationException(SR.T("Ошибка генерации класса \"{0}\"", MetadataName), innerException);
		}
	}

	protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal()
	{
		return new GeneratedFileInfo[2]
		{
			GenerateServerInterfaceFile(),
			GenerateContextFile()
		};
	}

	protected override IEnumerable<ISyntaxNode> GetNamespaces()
	{
		return new ISyntaxNode[5]
		{
			"System".NamespaceImportDeclaration(),
			"System.Collections.Generic".NamespaceImportDeclaration(),
			"System.Linq".NamespaceImportDeclaration(),
			"EleWise.ELMA.Core.Controllers".NamespaceImportDeclaration(),
			"EleWise.ELMA.Model.Validation".NamespaceImportDeclaration()
		};
	}

	protected override IEnumerable<ISyntaxNode> GetMembers()
	{
		return new ISyntaxNode[1] { GetViewModelController() };
	}

	private GeneratedFileInfo GenerateServerInterfaceFile()
	{
		ISyntaxNode syntaxNode = "IServer".InterfaceDeclaration(Accessibility.Private, DeclarationModifiers.None, new ISyntaxNode[1] { "IServerController".CreateTypeSyntax() }, GetServerInterfaceMembers());
		ISyntaxNode syntaxNode2 = GetClassName().ClassDeclaration(Accessibility.NotApplicable, DeclarationModifiers.Partial, null, null, new ISyntaxNode[1] { syntaxNode });
		ISyntaxNode syntaxNode3 = GetNamespace().NamespaceDeclaration(syntaxNode2);
		ISyntaxNode syntaxNode4 = "System.Threading.Tasks".NamespaceImportDeclaration();
		ISyntaxNode syntaxNode5 = "EleWise.ELMA.Core.Controllers".NamespaceImportDeclaration();
		return GenerateMainFileHelper(".ServerController.designer", syntaxNode4, syntaxNode5, syntaxNode3);
	}

	private GeneratedFileInfo GenerateContextFile()
	{
		IEnumerable<ISyntaxNode> viewModelContextCollection = GetViewModelContextCollection();
		ISyntaxNode item = GetClassName().ClassDeclaration(Accessibility.NotApplicable, DeclarationModifiers.Partial, null, null, viewModelContextCollection);
		ISyntaxNode item2 = "Bridge".NamespaceImportDeclaration();
		ISyntaxNode item3 = "System".NamespaceImportDeclaration();
		ISyntaxNode item4 = "System.Collections.Generic".NamespaceImportDeclaration();
		ISyntaxNode item5 = "System.Linq".NamespaceImportDeclaration();
		ISyntaxNode item6 = "EleWise.ELMA.Model.ViewModel".NamespaceImportDeclaration();
		ISyntaxNode item7 = "EleWise.ELMA.DataClasses".NamespaceImportDeclaration();
		List<ISyntaxNode> list = new List<ISyntaxNode> { item3, item4, item5, item, item6, item7 };
		if (generationParams.Mode == GenerationMode.Publish)
		{
			list.Add(item2);
		}
		ISyntaxNode syntaxNode = GetNamespace().NamespaceDeclaration(list.ToArray());
		return GenerateMainFileHelper(".Context.designer", syntaxNode);
	}

	private ISyntaxNode GetViewModelController()
	{
		return ControllerName.ClassDeclaration(Accessibility.Private, DeclarationModifiers.Sealed | DeclarationModifiers.Partial, GetBaseControllerType(), (generationParams.Mode != 0 || !GetParameters().CustomView) ? null : new ISyntaxNode[1] { "IComponentController".CreateTypeSyntax(useGlobal: false) }, GetViewModelControllerMembers());
	}

	protected virtual ISyntaxNode GetBaseControllerType()
	{
		return ("BaseController<" + ContextName + ",IServer>").CreateTypeSyntax();
	}

	private IEnumerable<ISyntaxNode> GetViewModelControllerMembers()
	{
		if (generationParams.Mode != 0)
		{
			return Enumerable.Empty<ISyntaxNode>();
		}
		AdditionalMethodsGenerationParameters parameters = GetParameters();
		if (parameters == null)
		{
			return Enumerable.Empty<ISyntaxNode>();
		}
		return GenerateAdditionalMethods(parameters.Metadata, parameters.Views);
	}

	private IEnumerable<ISyntaxNode> GenerateAdditionalMethods(ClassMetadata classMetadata, List<FormViewItem> viewItems)
	{
		HashSet<string> generatedMethods = new HashSet<string>();
		return GenerateAdditionalMethods(classMetadata, generatedMethods).Concat(viewItems.SelectMany((FormViewItem viewItem) => GenerateAdditionalMethods(classMetadata, viewItem, generatedMethods)));
	}

	private IEnumerable<ISyntaxNode> GenerateAdditionalMethods(ClassMetadata classMetadata, HashSet<string> generatedMethods)
	{
		ViewModelPropertyMetadata[] array = classMetadata.Properties.OfType<ViewModelPropertyMetadata>().ToArray();
		Type componentType = typeof(ViewModelPropertyMetadata);
		ViewModelPropertyMetadata[] array2 = array;
		foreach (ViewModelPropertyMetadata property in array2)
		{
			Type type = componentType;
			foreach (ComputedValue computedValue in property.ComputedValues)
			{
				ISyntaxNode syntaxNode = GenerateMethod(classMetadata, computedValue, property, type, generatedMethods);
				if (syntaxNode != null)
				{
					yield return syntaxNode;
				}
			}
			if (property.ClientOnly)
			{
				ISyntaxNode syntaxNode2 = GenerateMethod(classMetadata, property.ComputedValue, property, null, generatedMethods);
				if (syntaxNode2 != null)
				{
					yield return syntaxNode2;
				}
			}
		}
	}

	private IEnumerable<ISyntaxNode> GenerateAdditionalMethods(ClassMetadata classMetadata, FormViewItem viewItem, HashSet<string> generatedMethods)
	{
		List<ViewItem> list = viewItem.GetAllItems(ignoreHide: false).Concat(ComponentsFromToolbar(viewItem)).Concat(viewItem)
			.ToList();
		foreach (ViewItem item2 in list)
		{
			Type type2 = item2.GetType();
			foreach (ComputedValue dynamicProperty in item2.DynamicProperties)
			{
				ISyntaxNode syntaxNode = (dynamicProperty.Name.StartsWith("Input___") ? GenerateMethod(classMetadata, dynamicProperty, null, item2, generatedMethods) : GenerateMethod(classMetadata, dynamicProperty, item2, type2, generatedMethods));
				if (syntaxNode != null)
				{
					yield return syntaxNode;
				}
			}
		}
		if (viewItem.Toolbar == null)
		{
			yield break;
		}
		List<ToolbarItem> list2 = viewItem.Toolbar.GetAllItems(ignoreHide: false).ToList();
		foreach (ToolbarItem item in list2)
		{
			Type type2 = item.GetType();
			foreach (ComputedValue dynamicProperty2 in item.DynamicProperties)
			{
				ISyntaxNode syntaxNode2 = (dynamicProperty2.Name.StartsWith("Input___") ? GenerateMethod(classMetadata, dynamicProperty2, null, null, generatedMethods) : GenerateMethod(classMetadata, dynamicProperty2, item, type2, generatedMethods));
				if (syntaxNode2 != null)
				{
					yield return syntaxNode2;
				}
			}
		}
	}

	private ISyntaxNode GenerateMethod(ClassMetadata classMetadata, IComputedValue computedValue, object targetItem, Type targetType, HashSet<string> generatedMethods)
	{
		if (!IsCalculateScript(computedValue))
		{
			return null;
		}
		string name = ScriptMethodInfoHelper.Deserialize(computedValue.MethodName).Name;
		if (generatedMethods.Contains(name))
		{
			return null;
		}
		string[] array = computedValue.Name.Split('.');
		string text = array.Last();
		if (!text.IsValidIdentifier())
		{
			return null;
		}
		array = array.Take(array.Length - 1).ToArray();
		if (array.Length != 0)
		{
			object obj = targetItem;
			string[] array2 = array;
			foreach (string fieldName in array2)
			{
				if (obj == null)
				{
					break;
				}
				obj = obj.GetPropertyValue(fieldName, null);
			}
			if (obj != null)
			{
				targetType = obj.GetType();
			}
		}
		PropertyInfo property = targetType.GetProperty(text, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		if (property == null)
		{
			return null;
		}
		ISyntaxNode returnType = ((targetItem is PropertyViewItem && text == "ValidationScriptName") ? "EleWise.ELMA.Model.Validation.ValidationResult".CreateTypeSyntax() : property.PropertyType.CreateTypeSyntax());
		IEnumerable<ISyntaxNode> parameters = GenerateParameters(classMetadata, targetItem as ViewItem);
		ISyntaxNode syntaxNode = computedValue.CalculateScript.ParseExpression().ReturnStatement();
		generatedMethods.Add(name);
		return name.MethodDeclaration(parameters, null, returnType, Accessibility.Internal, DeclarationModifiers.None, new ISyntaxNode[1] { syntaxNode });
	}

	private ISyntaxNode GenerateMethod(ClassMetadata classMetadata, IComputedValue computedValue, PropertyMetadata property, ViewItem viewItem, HashSet<string> generatedMethods)
	{
		if (!IsCalculateScript(computedValue))
		{
			return null;
		}
		string name = ScriptMethodInfoHelper.Deserialize(computedValue.MethodName).Name;
		if (generatedMethods.Contains(name))
		{
			return null;
		}
		ITypeDescriptor typeDescriptor = null;
		if (property == null)
		{
			if (computedValue is IInputComputedValue inputComputedValue)
			{
				typeDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(inputComputedValue.TypeUid, inputComputedValue.SubTypeUid);
				TypeSettings typeSettings = (TypeSettings)Activator.CreateInstance(typeDescriptor.SettingsType);
				TypeSettings typeSettings2 = typeSettings;
				if (typeSettings2 != null)
				{
					if (!(typeSettings2 is DataClassSettings dataClassSettings))
					{
						if (!(typeSettings2 is EntitySettings entitySettings))
						{
							if (typeSettings2 is ActionSettings actionSettings)
							{
								ActionSettings actionSettings2 = actionSettings;
								if (inputComputedValue is IActionInputComputedValue actionInputComputedValue)
								{
									actionSettings2.ParameterType = actionInputComputedValue.ParameterType;
									actionSettings2.ReturnType = actionInputComputedValue.ReturnType;
								}
							}
						}
						else
						{
							entitySettings.RelationType = inputComputedValue.RelationType;
						}
					}
					else
					{
						dataClassSettings.RelationType = inputComputedValue.RelationType;
					}
				}
				property = new PropertyMetadata
				{
					TypeUid = inputComputedValue.TypeUid,
					SubTypeUid = inputComputedValue.SubTypeUid,
					Nullable = inputComputedValue.Nullable,
					Settings = typeSettings
				};
			}
		}
		else
		{
			typeDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(property.TypeUid, property.SubTypeUid);
		}
		if (typeDescriptor == null)
		{
			return null;
		}
		ISyntaxNode propertyType = GetPropertyType(typeDescriptor, property);
		ISyntaxNode syntaxNode = computedValue.CalculateScript.ParseExpression().ReturnStatement();
		IEnumerable<ISyntaxNode> parameters = GenerateParameters(classMetadata, viewItem);
		generatedMethods.Add(name);
		return name.MethodDeclaration(parameters, null, propertyType, Accessibility.Internal, DeclarationModifiers.None, new ISyntaxNode[1] { syntaxNode });
	}

	private static bool IsCalculateScript(IComputedValue value)
	{
		if (ComputedValueHelper.IsCalculateScript(value))
		{
			return !string.IsNullOrWhiteSpace(value.MethodName);
		}
		return false;
	}

	private static IEnumerable<ComponentViewItem> ComponentsFromToolbar(FormViewItem view)
	{
		if (view?.Toolbar == null)
		{
			return Enumerable.Empty<ComponentViewItem>();
		}
		return view.Toolbar.GetAllItems(ignoreHide: false).OfType<Button>().SelectMany((Button button) => button.RootViewItem?.GetAllItems(ignoreHide: false).OfType<ComponentViewItem>() ?? Enumerable.Empty<ComponentViewItem>());
	}

	private IEnumerable<ISyntaxNode> GenerateParameters(ClassMetadata classMetadata, ViewItem viewItem)
	{
		if (viewItem == null)
		{
			return Enumerable.Empty<ISyntaxNode>();
		}
		RootViewItem parent = viewItem.Parent;
		List<ISyntaxNode> list = new List<ISyntaxNode>();
		int num = 0;
		bool flag = false;
		while (parent != null)
		{
			if (parent is DynamicSlotViewItem)
			{
				flag = true;
			}
			if (parent is IDynamicViewItem || parent is GridViewItem || parent is TableViewItem)
			{
				Guid propertyUid = Guid.Empty;
				if (parent is IDynamicViewItem dynamicViewItem)
				{
					propertyUid = dynamicViewItem.PropertyUid;
				}
				else if (parent is TableViewItem tableViewItem)
				{
					propertyUid = tableViewItem.PropertyUid;
				}
				else if (parent is GridViewItem gridViewItem)
				{
					propertyUid = gridViewItem.EntityUid;
				}
				if (flag)
				{
					ISyntaxNode syntaxNode = null;
					PropertyMetadata propertyMetadata = classMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == propertyUid);
					if (propertyMetadata != null)
					{
						ITypeDescriptor typeDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(propertyMetadata.TypeUid, propertyMetadata.SubTypeUid);
						PropertyMetadata property = new PropertyMetadata
						{
							TypeUid = propertyMetadata.TypeUid,
							SubTypeUid = propertyMetadata.SubTypeUid
						};
						syntaxNode = GetPropertyType(typeDescriptor, property);
					}
					string name = "Item" + ((num == 0) ? string.Empty : num.ToString());
					string typeName = ((syntaxNode == null) ? "object" : syntaxNode.ToString());
					list.Add(name.ParameterDeclaration(typeName.CreateTypeSyntax()));
					num++;
				}
				flag = false;
			}
			parent = parent.Parent;
		}
		return list;
	}

	private ISyntaxNode GetPropertyType(ITypeDescriptor typeDescriptor, PropertyMetadata property)
	{
		ClassMetadata classMetadata = new ClassMetadata
		{
			Properties = new List<PropertyMetadata>()
		};
		return UITypeGenerationFacade.GetPropertyTypeReference(typeDescriptor, classMetadata, property, forFilter: false);
	}
}
