using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace EleWise.ELMA.CodeAnalyzers;

[DiagnosticAnalyzer("C#", new string[] { })]
internal class UsageAnalyzer : DiagnosticAnalyzer
{
	private const string Category = "Class Design";

	private const string Empty = "Empty";

	private static readonly DiagnosticDescriptor EmptyRule = new DiagnosticDescriptor("Empty", "Empty", "Empty", "Class Design", (DiagnosticSeverity)3, true, (string)null, (string)null, Array.Empty<string>());

	private readonly Action<SemanticModel, SyntaxNode> checkSymbol;

	private readonly Action<SemanticModel, SyntaxNode, string> processSymbol;

	public override System.Collections.Immutable.ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => System.Collections.Immutable.ImmutableArray.Create<DiagnosticDescriptor>(EmptyRule);

	public UsageAnalyzer(Action<SemanticModel, SyntaxNode> checkSymbol, Action<SemanticModel, SyntaxNode, string> processSymbol)
	{
		this.checkSymbol = checkSymbol;
		this.processSymbol = processSymbol;
	}

	public override void Initialize(AnalysisContext context)
	{
		context.RegisterSyntaxNodeAction<SyntaxKind>((Action<SyntaxNodeAnalysisContext>)VisitTypeArgumentList, (SyntaxKind[])(object)new SyntaxKind[1] { (SyntaxKind)8619 });
		context.RegisterSyntaxNodeAction<SyntaxKind>((Action<SyntaxNodeAnalysisContext>)VisitMethodDeclaration, (SyntaxKind[])(object)new SyntaxKind[1] { (SyntaxKind)8875 });
		context.RegisterSyntaxNodeAction<SyntaxKind>((Action<SyntaxNodeAnalysisContext>)VisitObjectCreationExpression, (SyntaxKind[])(object)new SyntaxKind[1] { (SyntaxKind)8649 });
		context.RegisterSyntaxNodeAction<SyntaxKind>((Action<SyntaxNodeAnalysisContext>)VisitAssignmentExpression, (SyntaxKind[])(object)new SyntaxKind[1] { (SyntaxKind)8714 });
		context.RegisterSyntaxNodeAction<SyntaxKind>((Action<SyntaxNodeAnalysisContext>)VisitMemberAccessExpression, (SyntaxKind[])(object)new SyntaxKind[1] { (SyntaxKind)8689 });
		context.RegisterSyntaxNodeAction<SyntaxKind>((Action<SyntaxNodeAnalysisContext>)VisitIdentifier, (SyntaxKind[])(object)new SyntaxKind[1] { (SyntaxKind)8616 });
	}

	private void VisitTypeArgumentList(SyntaxNodeAnalysisContext context)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		Enumerator<TypeSyntax> enumerator = ((TypeArgumentListSyntax)((SyntaxNodeAnalysisContext)(ref context)).get_Node()).get_Arguments().GetEnumerator();
		while (enumerator.MoveNext())
		{
			TypeSyntax current = enumerator.get_Current();
			checkSymbol(((SyntaxNodeAnalysisContext)(ref context)).get_SemanticModel(), (SyntaxNode)(object)current);
		}
	}

	private void VisitMethodDeclaration(SyntaxNodeAnalysisContext context)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		MethodDeclarationSyntax val = (MethodDeclarationSyntax)((SyntaxNodeAnalysisContext)(ref context)).get_Node();
		checkSymbol(((SyntaxNodeAnalysisContext)(ref context)).get_SemanticModel(), (SyntaxNode)(object)val.get_ReturnType());
	}

	private void VisitObjectCreationExpression(SyntaxNodeAnalysisContext context)
	{
		SyntaxNode node = ((SyntaxNodeAnalysisContext)(ref context)).get_Node();
		checkSymbol(((SyntaxNodeAnalysisContext)(ref context)).get_SemanticModel(), node);
	}

	private void VisitAssignmentExpression(SyntaxNodeAnalysisContext context)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		ExpressionSyntax left = ((AssignmentExpressionSyntax)((SyntaxNodeAnalysisContext)(ref context)).get_Node()).get_Left();
		MemberAccessExpressionSyntax val;
		processSymbol(((SyntaxNodeAnalysisContext)(ref context)).get_SemanticModel(), (SyntaxNode)(object)left, ((val = (MemberAccessExpressionSyntax)(object)((left is MemberAccessExpressionSyntax) ? left : null)) != null) ? ((object)val.get_Name()).ToString() : ((object)left).ToString());
	}

	private void VisitMemberAccessExpression(SyntaxNodeAnalysisContext context)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		MemberAccessExpressionSyntax val = (MemberAccessExpressionSyntax)((SyntaxNodeAnalysisContext)(ref context)).get_Node();
		processSymbol(((SyntaxNodeAnalysisContext)(ref context)).get_SemanticModel(), (SyntaxNode)(object)val, ((object)val.get_Name()).ToString());
	}

	private void VisitIdentifier(SyntaxNodeAnalysisContext context)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		IdentifierNameSyntax arg = (IdentifierNameSyntax)((SyntaxNodeAnalysisContext)(ref context)).get_Node();
		processSymbol(((SyntaxNodeAnalysisContext)(ref context)).get_SemanticModel(), (SyntaxNode)(object)arg, null);
	}
}
