using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.OmniSharp;
using EleWise.ELMA.OmniSharp.Models;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Scripts.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace EleWise.ELMA.UIBuilder.OmniSharp;

public abstract class AbstractClientCodeEditorExtension : AbstractCodeEditorExtension
{
	public IRuntimeApplication RuntimeApplication { get; set; }

	protected override CodeType CodeType => CodeType.Client;

	public override int GetMethodPosition(string sourceCode, string className, string methodName)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(methodName) || string.IsNullOrEmpty(sourceCode))
		{
			return 0;
		}
		ClassDeclarationSyntax obj = CSharpSyntaxTree.ParseText(sourceCode, CSharpParseOptions.get_Default().WithLanguageVersion((LanguageVersion)7), "", (Encoding)null, (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken)).GetRoot(default(CancellationToken)).DescendantNodes((Func<SyntaxNode, bool>)null, false)
			.OfType<ClassDeclarationSyntax>()
			.FirstOrDefault(delegate(ClassDeclarationSyntax q)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				SyntaxToken identifier3 = ((BaseTypeDeclarationSyntax)q).get_Identifier();
				return ((object)(SyntaxToken)(ref identifier3)).ToString() == className;
			});
		ClassDeclarationSyntax val = ((obj != null) ? ((IEnumerable)(object)((TypeDeclarationSyntax)obj).get_Members()).OfType<ClassDeclarationSyntax>().FirstOrDefault(delegate(ClassDeclarationSyntax q)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			SyntaxToken identifier2 = ((BaseTypeDeclarationSyntax)q).get_Identifier();
			return ((object)(SyntaxToken)(ref identifier2)).ToString() == "ViewModelController";
		}) : null);
		if (val == null)
		{
			return 0;
		}
		MethodDeclarationSyntax obj2 = ((IEnumerable)(object)((TypeDeclarationSyntax)val).get_Members()).OfType<MethodDeclarationSyntax>().FirstOrDefault(delegate(MethodDeclarationSyntax q)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			SyntaxToken identifier = q.get_Identifier();
			return ((object)(SyntaxToken)(ref identifier)).ToString() == methodName;
		});
		if (obj2 == null)
		{
			return 0;
		}
		return ((SyntaxNode)((BaseMethodDeclarationSyntax)obj2).get_Body()).get_SpanStart();
	}

	protected override List<IScriptReference> GetDynamicAssemblies()
	{
		DbPreUpdater dbPreUpdater = RuntimeApplication?.DbPreUpdater;
		if (dbPreUpdater == null)
		{
			return new List<IScriptReference>();
		}
		return dbPreUpdater.GetAssemblyModels(AssemblyModelsMetadataStatus.PublishedDisabled, "ConfigurationUIModel", "DynamicUIModel", "ExternalUIModel").Select(AbstractCodeEditorExtension.CreateScriptReference).ToList();
	}
}
