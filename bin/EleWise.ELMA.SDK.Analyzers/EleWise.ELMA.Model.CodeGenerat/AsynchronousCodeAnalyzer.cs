using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using EleWise.ELMA.Analyzers.Properties;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace EleWise.ELMA.Model.CodeGeneration.Analyzers;

[DiagnosticAnalyzer("C#", new string[] { })]
public sealed class AsynchronousCodeAnalyzer : DiagnosticAnalyzer
{
	private const string Category = "Class Design";

	private static readonly DiagnosticDescriptor AsyncVoidRule = new DiagnosticDescriptor("AsyncVoid", (LocalizableString)new LocalizableResourceString("ELMAAsyncVoid_title", Resources.ResourceManager, typeof(Resources)), (LocalizableString)new LocalizableResourceString("ELMAAsyncVoid_messageFormat", Resources.ResourceManager, typeof(Resources)), "Class Design", (DiagnosticSeverity)3, true, (LocalizableString)null, (string)null, Array.Empty<string>());

	public override System.Collections.Immutable.ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => System.Collections.Immutable.ImmutableArray.Create<DiagnosticDescriptor>(AsyncVoidRule);

	public override void Initialize(AnalysisContext context)
	{
		context.RegisterSyntaxNodeAction<SyntaxKind>((Action<SyntaxNodeAnalysisContext>)AnalyzeMethodNode, (SyntaxKind[])(object)new SyntaxKind[1] { (SyntaxKind)8875 });
		context.RegisterSyntaxNodeAction<SyntaxKind>((Action<SyntaxNodeAnalysisContext>)AnalyzeLocalFunctionNode, (SyntaxKind[])(object)new SyntaxKind[1] { (SyntaxKind)8830 });
	}

	private static void AnalyzeMethodNode(SyntaxNodeAnalysisContext context)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		if (AnalyzeAsyncVoid((IMethodSymbol)((SyntaxNodeAnalysisContext)(ref context)).get_ContainingSymbol()))
		{
			MethodDeclarationSyntax val = (MethodDeclarationSyntax)((SyntaxNodeAnalysisContext)(ref context)).get_Node();
			DiagnosticDescriptor asyncVoidRule = AsyncVoidRule;
			SyntaxToken val2 = ((IEnumerable<SyntaxToken>)(object)((MemberDeclarationSyntax)val).get_Modifiers()).Append(val.get_Identifier()).First();
			((SyntaxNodeAnalysisContext)(ref context)).ReportDiagnostic(Diagnostic.Create(asyncVoidRule, ((SyntaxToken)(ref val2)).GetLocation(), new object[1] { ((SyntaxNodeAnalysisContext)(ref context)).get_ContainingSymbol() }));
		}
	}

	private static void AnalyzeLocalFunctionNode(SyntaxNodeAnalysisContext context)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		SemanticModel semanticModel = ((SyntaxNodeAnalysisContext)(ref context)).get_SemanticModel();
		LocalFunctionStatementSyntax val = (LocalFunctionStatementSyntax)((SyntaxNodeAnalysisContext)(ref context)).get_Node();
		IMethodSymbol val2 = (IMethodSymbol)ModelExtensions.GetDeclaredSymbol(semanticModel, (SyntaxNode)(object)val, default(CancellationToken));
		if (val2 != null && AnalyzeAsyncVoid(val2))
		{
			DiagnosticDescriptor asyncVoidRule = AsyncVoidRule;
			SyntaxToken val3 = ((IEnumerable<SyntaxToken>)(object)val.get_Modifiers()).Append(val.get_Identifier()).First();
			((SyntaxNodeAnalysisContext)(ref context)).ReportDiagnostic(Diagnostic.Create(asyncVoidRule, ((SyntaxToken)(ref val3)).GetLocation(), new object[1] { ((SyntaxNodeAnalysisContext)(ref context)).get_ContainingSymbol() }));
		}
	}

	private static bool AnalyzeAsyncVoid(IMethodSymbol methodSymbol)
	{
		if (!methodSymbol.get_IsAsync())
		{
			return false;
		}
		if (!methodSymbol.get_ReturnsVoid())
		{
			return false;
		}
		return true;
	}
}
