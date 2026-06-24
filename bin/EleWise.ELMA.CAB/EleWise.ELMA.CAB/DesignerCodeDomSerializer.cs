using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;

namespace EleWise.ELMA.CAB;

internal class DesignerCodeDomSerializer : CodeDomSerializer
{
	protected static TMember FindMember<TMember>(CodeTypeDeclaration declaration, string memberName) where TMember : CodeObject
	{
		foreach (CodeTypeMember member in declaration.Members)
		{
			if (member is TMember result && member.Name == memberName)
			{
				return result;
			}
		}
		return null;
	}

	protected static CodeMemberMethod FindInitializeComponent(CodeTypeDeclaration declaration)
	{
		return FindMember<CodeMemberMethod>(declaration, "InitializeComponent");
	}

	protected static void AddStatementToInitializeComponent(CodeTypeDeclaration declaration, CodeStatement statement)
	{
		FindInitializeComponent(declaration)?.Statements.Add(statement);
	}

	protected static List<string> GetComponentsOnDesignerSurface(IDesignerSerializationManager manager, object rootComponent)
	{
		IDesignerHost designerHost = (IDesignerHost)manager.GetService(typeof(IDesignerHost));
		List<string> list = new List<string>(designerHost.Container.Components.Count);
		foreach (IComponent component in designerHost.Container.Components)
		{
			if (component != rootComponent)
			{
				list.Add(component.Site.Name);
			}
		}
		return list;
	}

	protected static void RemoveFromStatements<TCodeObject>(CodeStatementCollection statements, Predicate<TCodeObject> shouldRemove) where TCodeObject : CodeObject
	{
		List<CodeStatement> list = new List<CodeStatement>();
		foreach (CodeStatement statement in statements)
		{
			TCodeObject val = statement as TCodeObject;
			CodeExpressionStatement codeExpressionStatement = statement as CodeExpressionStatement;
			if (val == null && codeExpressionStatement != null)
			{
				val = codeExpressionStatement.Expression as TCodeObject;
			}
			if (val != null && shouldRemove(val))
			{
				list.Add(statement);
			}
		}
		foreach (CodeStatement item in list)
		{
			statements.Remove(item);
		}
	}

	protected static void RemoveFromInitializeComponent<TCodeObject>(CodeTypeDeclaration declaration, Predicate<TCodeObject> shouldRemove) where TCodeObject : CodeObject
	{
		CodeMemberMethod codeMemberMethod = FindInitializeComponent(declaration);
		if (codeMemberMethod != null)
		{
			RemoveFromStatements(codeMemberMethod.Statements, shouldRemove);
		}
	}

	protected static List<TCodeObject> FindCode<TCodeObject>(CodeStatementCollection statements, Predicate<TCodeObject> matchesFilter) where TCodeObject : CodeObject
	{
		List<TCodeObject> list = new List<TCodeObject>();
		foreach (CodeStatement statement in statements)
		{
			TCodeObject val = statement as TCodeObject;
			CodeExpressionStatement codeExpressionStatement = statement as CodeExpressionStatement;
			if (val == null && codeExpressionStatement != null)
			{
				val = codeExpressionStatement.Expression as TCodeObject;
			}
			if (val != null && matchesFilter(val))
			{
				list.Add(val);
			}
		}
		return list;
	}

	protected static TCodeObject FindFirstCode<TCodeObject>(CodeStatementCollection statements, Predicate<TCodeObject> matchesFilter) where TCodeObject : CodeObject
	{
		foreach (CodeStatement statement in statements)
		{
			TCodeObject val = statement as TCodeObject;
			CodeExpressionStatement codeExpressionStatement = statement as CodeExpressionStatement;
			if (val == null && codeExpressionStatement != null)
			{
				val = codeExpressionStatement.Expression as TCodeObject;
			}
			if (val != null && matchesFilter(val))
			{
				return val;
			}
		}
		return null;
	}
}
