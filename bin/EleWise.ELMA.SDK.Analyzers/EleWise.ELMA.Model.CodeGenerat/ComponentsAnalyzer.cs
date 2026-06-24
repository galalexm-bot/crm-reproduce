using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using EleWise.ELMA.Analyzers.Properties;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace EleWise.ELMA.Model.CodeGeneration.Analyzers;

[DiagnosticAnalyzer("C#", new string[] { })]
internal class ComponentsAnalyzer : DiagnosticAnalyzer
{
	private const string SDKAssemblyName = "EleWise.ELMA.SDK";

	private const string ComponentAttributeTypeName = "EleWise.ELMA.ComponentModel.ComponentAttribute";

	private const string ServiceAttributeTypeName = "EleWise.ELMA.ComponentModel.ServiceAttribute";

	private const string Category = "Class Design";

	private static readonly DiagnosticDescriptor ComponentRule = new DiagnosticDescriptor("ELMA9001", (LocalizableString)new LocalizableResourceString("ELMA9001_title", Resources.ResourceManager, typeof(Resources)), (LocalizableString)new LocalizableResourceString("ELMA9001_messageFormat", Resources.ResourceManager, typeof(Resources)), "Class Design", (DiagnosticSeverity)3, true, (LocalizableString)new LocalizableResourceString("ELMA9001_description", Resources.ResourceManager, typeof(Resources)), (string)null, Array.Empty<string>());

	private static readonly DiagnosticDescriptor ServiceRule = new DiagnosticDescriptor("ELMA9002", (LocalizableString)new LocalizableResourceString("ELMA9002_title", Resources.ResourceManager, typeof(Resources)), (LocalizableString)new LocalizableResourceString("ELMA9002_messageFormat", Resources.ResourceManager, typeof(Resources)), "Class Design", (DiagnosticSeverity)3, true, (LocalizableString)new LocalizableResourceString("ELMA9002_description", Resources.ResourceManager, typeof(Resources)), (string)null, Array.Empty<string>());

	private INamedTypeSymbol componentAttributeTypeSymbol;

	private INamedTypeSymbol serviceAttributeTypeSymbol;

	private IEnumerable<INamedTypeSymbol> ignoredTypeSymbols = Enumerable.Empty<INamedTypeSymbol>();

	public override System.Collections.Immutable.ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => System.Collections.Immutable.ImmutableArray.Create<DiagnosticDescriptor>(ComponentRule, ServiceRule);

	public override void Initialize(AnalysisContext context)
	{
		context.RegisterCompilationStartAction((Action<CompilationStartAnalysisContext>)CompilationStartAction);
		context.RegisterSyntaxNodeAction<SyntaxKind>((Action<SyntaxNodeAnalysisContext>)AnalyzeNode, (SyntaxKind[])(object)new SyntaxKind[1] { (SyntaxKind)8855 });
	}

	protected virtual IEnumerable<string> GetIgnoredTypes()
	{
		return Enumerable.Empty<string>();
	}

	private void CompilationStartAction(CompilationStartAnalysisContext context)
	{
		IAssemblySymbol assembly = context.get_Compilation().get_References().Select((Func<MetadataReference, ISymbol>)context.get_Compilation().GetAssemblyOrModuleSymbol)
			.OfType<IAssemblySymbol>()
			.First((IAssemblySymbol assemblySymbol) => ((ISymbol)assemblySymbol).get_MetadataName() == "EleWise.ELMA.SDK");
		componentAttributeTypeSymbol = assembly.GetTypeByMetadataName("EleWise.ELMA.ComponentModel.ComponentAttribute");
		serviceAttributeTypeSymbol = assembly.GetTypeByMetadataName("EleWise.ELMA.ComponentModel.ServiceAttribute");
		ignoredTypeSymbols = from a in GetIgnoredTypes()
			select assembly.GetTypeByMetadataName(a) into ts
			where ts != null
			select ts;
	}

	private void AnalyzeNode(SyntaxNodeAnalysisContext context)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		INamedTypeSymbol typeSymbol;
		for (typeSymbol = (INamedTypeSymbol)((SyntaxNodeAnalysisContext)(ref context)).get_ContainingSymbol(); typeSymbol != null; typeSymbol = ((ITypeSymbol)typeSymbol).get_BaseType())
		{
			SyntaxToken val2;
			if (ImmutableArrayExtensions.Any<AttributeData>(((ISymbol)typeSymbol).GetAttributes(), (Func<AttributeData, bool>)((AttributeData a) => object.Equals(a.get_AttributeClass(), componentAttributeTypeSymbol))) && (!typeSymbol.get_IsGenericType() || !ignoredTypeSymbols.Any((INamedTypeSymbol a) => object.Equals(a, typeSymbol.get_ConstructedFrom()))))
			{
				ClassDeclarationSyntax val = (ClassDeclarationSyntax)((SyntaxNodeAnalysisContext)(ref context)).get_Node();
				DiagnosticDescriptor componentRule = ComponentRule;
				val2 = ((IEnumerable<SyntaxToken>)(object)((MemberDeclarationSyntax)val).get_Modifiers()).Append(((TypeDeclarationSyntax)val).get_Keyword()).First();
				((SyntaxNodeAnalysisContext)(ref context)).ReportDiagnostic(Diagnostic.Create(componentRule, ((SyntaxToken)(ref val2)).GetLocation(), new object[1] { ((SyntaxNodeAnalysisContext)(ref context)).get_ContainingSymbol() }));
				break;
			}
			if (ImmutableArrayExtensions.Any<AttributeData>(((ISymbol)typeSymbol).GetAttributes(), (Func<AttributeData, bool>)((AttributeData a) => object.Equals(a.get_AttributeClass(), serviceAttributeTypeSymbol))))
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
