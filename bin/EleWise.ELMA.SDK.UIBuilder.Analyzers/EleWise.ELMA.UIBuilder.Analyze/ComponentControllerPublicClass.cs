using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using EleWise.ELMA.UIBuilder.Analyzers.Properties;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace EleWise.ELMA.UIBuilder.Analyzers;

[DiagnosticAnalyzer("C#", new string[] { })]
public sealed class ComponentControllerPublicClassesAnalyzer : DiagnosticAnalyzer
{
	private const string Category = "Class Design";

	private static readonly DiagnosticDescriptor PublicClassRule = new DiagnosticDescriptor("PublicClassUsage", (LocalizableString)new LocalizableResourceString("ELMAPublicClass_title", Resources.ResourceManager, typeof(Resources)), (LocalizableString)new LocalizableResourceString("ELMAPublicClass_messageFormat", Resources.ResourceManager, typeof(Resources)), "Class Design", (DiagnosticSeverity)3, true, (LocalizableString)null, (string)null, Array.Empty<string>());

	public override System.Collections.Immutable.ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => System.Collections.Immutable.ImmutableArray.Create<DiagnosticDescriptor>(PublicClassRule);

	public override void Initialize(AnalysisContext context)
	{
		context.RegisterSyntaxNodeAction<SyntaxKind>((Action<SyntaxNodeAnalysisContext>)AnalyzeNode, (SyntaxKind[])(object)new SyntaxKind[1] { (SyntaxKind)8855 });
	}

	private static void AnalyzeNode(SyntaxNodeAnalysisContext context)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		if ((int)((SyntaxNodeAnalysisContext)(ref context)).get_ContainingSymbol().get_DeclaredAccessibility() == 6)
		{
			ClassDeclarationSyntax val = (ClassDeclarationSyntax)((SyntaxNodeAnalysisContext)(ref context)).get_Node();
			DiagnosticDescriptor publicClassRule = PublicClassRule;
			SyntaxToken val2 = ((IEnumerable<SyntaxToken>)(object)((MemberDeclarationSyntax)val).get_Modifiers()).Append(((TypeDeclarationSyntax)val).get_Keyword()).First();
			((SyntaxNodeAnalysisContext)(ref context)).ReportDiagnostic(Diagnostic.Create(publicClassRule, ((SyntaxToken)(ref val2)).GetLocation(), new object[1] { ((SyntaxNodeAnalysisContext)(ref context)).get_ContainingSymbol() }));
		}
	}
}
