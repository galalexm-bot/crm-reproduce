using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.CodeGeneration;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UIBuilder.CodeGeneration.Types;

namespace EleWise.ELMA.UIBuilder.CodeGeneration;

internal class ComponentWebContextGenerator : ComponentContextGenerator
{
	private readonly IUITypeGenerationFacade uiTypeGenerationFacade;

	private const string Context = "_Context";

	public ComponentWebContextGenerator(IUITypeGenerationFacade uiTypeGenerationFacade)
	{
		this.uiTypeGenerationFacade = uiTypeGenerationFacade;
	}

	protected override IEnumerable<ISyntaxNode> GenerateMainFile()
	{
		ISyntaxNode syntaxNode = ignoreNamespaces.WithIgnoreNamespaces(() => "_Context".ClassDeclaration(Accessibility.Private, DeclarationModifiers.None, GetBaseClass(), GetBaseInterfaces(), GetMembers()));
		WriteComments(syntaxNode);
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

	protected override IEnumerable<ISyntaxNode> WriteProperty(PropertyMetadata propertyMetadata, List<ISyntaxNode> ctorStatements, bool writeAttributes = true, Action<ISyntaxNode> propertyAction = null)
	{
		Contract.ArgumentNotNull(propertyMetadata, "propertyMetadata");
		ITypeDescriptor propertyTypeDescriptor = GetPropertyTypeDescriptor(propertyMetadata);
		if (propertyTypeDescriptor == null)
		{
			return Enumerable.Empty<ISyntaxNode>();
		}
		ISyntaxNode propertyTypeReference = GetPropertyTypeReference(propertyMetadata, (ITypeGenerationInfo)propertyTypeDescriptor);
		if (propertyTypeReference == null)
		{
			return Enumerable.Empty<ISyntaxNode>();
		}
		ISyntaxNode syntaxNode = PropertyDeclaration(propertyMetadata, propertyTypeReference);
		WritePropertyComments(syntaxNode, propertyMetadata);
		return new ISyntaxNode[1] { syntaxNode };
	}

	protected override ISyntaxNode GetPropertyTypeReference(PropertyMetadata propertyMetadata, ITypeGenerationInfo typeDescriptor)
	{
		if (uiTypeGenerationFacade.UIBuilderSupports((ITypeDescriptor)typeDescriptor))
		{
			return uiTypeGenerationFacade.GetPropertyTypeReference((ITypeDescriptor)typeDescriptor, metadata, propertyMetadata, forFilter: false);
		}
		return null;
	}

	protected override ISyntaxNode PropertyDeclaration(PropertyMetadata propertyMetadata, ISyntaxNode propertyType, IEnumerable<ISyntaxNode> getAccessorStatements = null, IEnumerable<ISyntaxNode> setAccessorStatements = null)
	{
		bool flag = false;
		if (propertyMetadata.TypeUid == ListOfSimpleTypeDescriptor.UID)
		{
			flag = true;
		}
		else
		{
			RelationType? relationType = GetRelationType(propertyMetadata);
			if (relationType.HasValue && relationType != RelationType.OneToOne)
			{
				flag = true;
			}
		}
		if (propertyMetadata is IViewModelPropertyMetadata viewModelPropertyMetadata)
		{
			ComputedValue computedValue = viewModelPropertyMetadata.ComputedValue;
			bool flag2 = computedValue != null && (computedValue.ComputedValueType == ComputedValueType.Function || computedValue.ComputedValueType == ComputedValueType.CalculateScript);
			if (viewModelPropertyMetadata.Input || flag2)
			{
				return propertyMetadata.Name.PropertyDeclaration(propertyType, Accessibility.Public, DeclarationModifiers.Virtual, getAccessorStatements, setAccessorStatements, Accessibility.NotApplicable, Accessibility.Private);
			}
		}
		return propertyMetadata.Name.PropertyDeclaration(propertyType, Accessibility.Public, DeclarationModifiers.Virtual, getAccessorStatements, setAccessorStatements, Accessibility.NotApplicable, flag ? Accessibility.Private : Accessibility.NotApplicable);
	}
}
