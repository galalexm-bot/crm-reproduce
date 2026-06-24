using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using EleWise.ELMA.UIBuilder.Analyzers.Properties;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace EleWise.ELMA.UIBuilder.CodeAnalyzers;

[DiagnosticAnalyzer("C#", new string[] { })]
public sealed class UIComponentsAnalyzer : DiagnosticAnalyzer
{
	private const string EleWiseELMACore = "EleWise.ELMA.Core";

	private const string EleWiseELMATestFramework = "EleWise.ELMA.TestFramework";

	private const string EleWiseELMATestFrameworkBDDTest = "EleWise.ELMA.TestFramework.BDD.Test";

	private const string ComponentAttributeFullName = "EleWise.ELMA.Core.ComponentModel.ComponentAttribute";

	private const string ServiceAttributeFullName = "EleWise.ELMA.Core.ComponentModel.ServiceAttribute";

	private const string Category = "Class Design";

	private static readonly DiagnosticDescriptor ComponentRule = new DiagnosticDescriptor("ELMA9001", (LocalizableString)new LocalizableResourceString("ELMA9001_title", Resources.ResourceManager, typeof(Resources)), (LocalizableString)new LocalizableResourceString("ELMA9001_messageFormat", Resources.ResourceManager, typeof(Resources)), "Class Design", (DiagnosticSeverity)3, true, (LocalizableString)null, (string)null, Array.Empty<string>());

	private static readonly DiagnosticDescriptor ServiceRule = new DiagnosticDescriptor("ELMA9002", (LocalizableString)new LocalizableResourceString("ELMA9002_title", Resources.ResourceManager, typeof(Resources)), (LocalizableString)new LocalizableResourceString("ELMA9002_messageFormat", Resources.ResourceManager, typeof(Resources)), "Class Design", (DiagnosticSeverity)3, true, (LocalizableString)null, (string)null, Array.Empty<string>());

	private INamedTypeSymbol componentAttributeTypeSymbol;

	private INamedTypeSymbol serviceAttributeTypeSymbol;

	private IEnumerable<INamedTypeSymbol> ignoredTypeSymbols = Enumerable.Empty<INamedTypeSymbol>();

	public override System.Collections.Immutable.ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => System.Collections.Immutable.ImmutableArray.Create<DiagnosticDescriptor>(ComponentRule, ServiceRule);

	public override void Initialize(AnalysisContext context)
	{
		context.RegisterCompilationStartAction((Action<CompilationStartAnalysisContext>)CompilationStartAction);
		context.RegisterSyntaxNodeAction<SyntaxKind>((Action<SyntaxNodeAnalysisContext>)AnalyzeNode, (SyntaxKind[])(object)new SyntaxKind[1] { (SyntaxKind)8855 });
	}

	protected IEnumerable<string> GetIgnoredTypes()
	{
		return new string[1] { "EleWise.ELMA.Core.Controllers.Controller`1" };
	}

	private void CompilationStartAction(CompilationStartAnalysisContext context)
	{
		IAssemblySymbol[] source = context.get_Compilation().get_References().Select((Func<MetadataReference, ISymbol>)context.get_Compilation().GetAssemblyOrModuleSymbol)
			.OfType<IAssemblySymbol>()
			.ToArray();
		IAssemblySymbol coreAssembly = source.First((IAssemblySymbol assemblySymbol) => ((ISymbol)assemblySymbol).get_MetadataName() == "EleWise.ELMA.Core");
		IAssemblySymbol val = source.FirstOrDefault((IAssemblySymbol assemblySymbol) => ((ISymbol)assemblySymbol).get_MetadataName() == "EleWise.ELMA.TestFramework");
		componentAttributeTypeSymbol = coreAssembly.GetTypeByMetadataName("EleWise.ELMA.Core.ComponentModel.ComponentAttribute");
		serviceAttributeTypeSymbol = coreAssembly.GetTypeByMetadataName("EleWise.ELMA.Core.ComponentModel.ServiceAttribute");
		ignoredTypeSymbols = from ts in (from a in GetIgnoredTypes()
				select coreAssembly.GetTypeByMetadataName(a)).Concat((IEnumerable<INamedTypeSymbol>)(object)new INamedTypeSymbol[1] { (val != null) ? val.GetTypeByMetadataName("EleWise.ELMA.TestFramework.BDD.Test") : null })
			where ts != null
			select ts;
	}

	private void AnalyzeNode(SyntaxNodeAnalysisContext context)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		INamedTypeSymbol typeSymbol;
		for (typeSymbol = (INamedTypeSymbol)((SyntaxNodeAnalysisContext)(ref context)).get_ContainingSymbol(); typeSymbol != null; typeSymbol = ((ITypeSymbol)typeSymbol).get_BaseType())
		{
			SyntaxToken val2;
			if (ImmutableArrayExtensions.Any<AttributeData>(((ISymbol)typeSymbol).GetAttributes(), (Func<AttributeData, bool>)((AttributeData a) => a.get_AttributeClass() == componentAttributeTypeSymbol)))
			{
				if (ignoredTypeSymbols.All((INamedTypeSymbol a) => a != typeSymbol.get_ConstructedFrom()))
				{
					ClassDeclarationSyntax val = (ClassDeclarationSyntax)((SyntaxNodeAnalysisContext)(ref context)).get_Node();
					DiagnosticDescriptor componentRule = ComponentRule;
					val2 = ((IEnumerable<SyntaxToken>)(object)((MemberDeclarationSyntax)val).get_Modifiers()).Append(((TypeDeclarationSyntax)val).get_Keyword()).First();
					((SyntaxNodeAnalysisContext)(ref context)).ReportDiagnostic(Diagnostic.Create(componentRule, ((SyntaxToken)(ref val2)).GetLocation(), new object[1] { ((SyntaxNodeAnalysisContext)(ref context)).get_ContainingSymbol() }));
				}
				break;
			}
			if (ImmutableArrayExtensions.Any<AttributeData>(((ISymbol)typeSymbol).GetAttributes(), (Func<AttributeData, bool>)((AttributeData a) => a.get_AttributeClass() == serviceAttributeTypeSymbol)))
			{
				ClassDeclarationSyntax val3 = (ClassDeclarationSyntax)((SyntaxNodeAnalysisContext)(ref context)).get_Node();
				DiagnosticDescriptor serviceRule = ServiceRule;
				val2 = ((IEnumerable<SyntaxToken>)(object)((MemberDeclarationSyntax)val3).get_Modifiers()).Append(((TypeDeclarationSyntax)val3).get_Keyword()).First();
				((SyntaxNodeAnalysisContext)(ref context)).ReportDiagnostic(Diagnostic.Create(serviceRule, ((SyntaxToken)(ref val2)).GetLocation(), new object[1] { ((SyntaxNodeAnalysisContext)(ref context)).get_ContainingSymbol() }));
				break;
			}
		}
	}
}
