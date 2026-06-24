using System.Collections.Generic;
using EleWise.ELMA.Model.CodeGeneration;

namespace EleWise.ELMA.UIBuilder.CodeGeneration;

internal sealed class EntityClientScriptModuleCodeGenerator : ScriptModuleCodeGenerator
{
	private const string ViewModelController = "ViewModelController";

	protected override IEnumerable<ISyntaxNode> GetNamespaces()
	{
		foreach (ISyntaxNode @namespace in base.GetNamespaces())
		{
			yield return @namespace;
		}
		yield return "System.Collections.Generic".NamespaceImportDeclaration();
		yield return "EleWise.ELMA.Core".NamespaceImportDeclaration();
		yield return "EleWise.ELMA.Core.Controllers".NamespaceImportDeclaration();
		yield return "EleWise.ELMA.Model.ViewModel".NamespaceImportDeclaration();
		yield return "EleWise.ELMA.Model.Views".NamespaceImportDeclaration();
	}

	protected override string GetClassName()
	{
		return metadata.Name + "Scripts";
	}

	protected override void WriteComments(ISyntaxNode type)
	{
		type.XmlComments(SR.T("Клиентский модуль сценариев объекта \"{0}\"", metadata.DisplayName).SummaryComment());
	}

	protected override IEnumerable<ISyntaxNode> GetMembers()
	{
		return new ISyntaxNode[1] { "ViewModelController".ClassDeclaration(Accessibility.NotApplicable, DeclarationModifiers.Partial) };
	}
}
