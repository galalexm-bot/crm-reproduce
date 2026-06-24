using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Emit;

namespace EleWise.ELMA.Orleans.CodeGeneration;

internal static class CodeGeneratorCommon
{
	private static readonly ILogger logger = Logger.GetLogger(typeof(CodeGeneratorCommon));

	private const string CodeGeneratorName = "ELMA-Orleans-CodeGenerator";

	internal const string ClassPrefix = "OrleansCodeGen";

	private static readonly string CodeGeneratorVersion = "1.0";

	public static Assembly CompileAssembly(CompilationUnitSyntax code, string assemblyName, bool emitDebugSymbols, byte[] assemblyPublicKey = null)
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		MetadataReference[] array = (from asm in AppDomain.CurrentDomain.GetAssemblies()
			where !asm.IsDynamic && !string.IsNullOrWhiteSpace(asm.Location)
			select MetadataReference.CreateFromFile(asm.Location, default(MetadataReferenceProperties), (DocumentationProvider)null)).Cast<MetadataReference>().ToArray();
		CSharpCompilationOptions val = new CSharpCompilationOptions((OutputKind)2, false, (string)null, (string)null, (string)null, (IEnumerable<string>)null, (OptimizationLevel)0, false, false, (string)null, (string)null, default(System.Collections.Immutable.ImmutableArray<byte>), (bool?)null, (Platform)0, (ReportDiagnostic)0, 4, (IEnumerable<KeyValuePair<string, ReportDiagnostic>>)null, true, false, (XmlReferenceResolver)null, (SourceReferenceResolver)null, (MetadataReferenceResolver)null, (AssemblyIdentityComparer)null, (StrongNameProvider)null, false, (MetadataImportOptions)0, (NullableContextOptions)0);
		if (assemblyPublicKey != null && assemblyPublicKey.Length != 0)
		{
			val = val.WithCryptoPublicKey(System.Collections.Immutable.ImmutableArray.ToImmutableArray<byte>((IEnumerable<byte>)assemblyPublicKey)).WithPublicSign(true);
		}
		string text = null;
		CSharpCompilation val2 = CSharpCompilation.Create(assemblyName, (IEnumerable<SyntaxTree>)null, (IEnumerable<MetadataReference>)null, (CSharpCompilationOptions)null).AddSyntaxTrees((SyntaxTree[])(object)new SyntaxTree[1] { ((SyntaxNode)code).get_SyntaxTree() }).AddReferences(array)
			.WithOptions(val);
		string tempFileName = IOExtensions.GetTempFileName();
		using (FileStream fileStream = new FileStream(tempFileName, FileMode.Create, FileAccess.Write))
		{
			using MemoryStream memoryStream = (emitDebugSymbols ? MemoryHelper.GetMemoryStream() : null);
			EmitOptions val3 = new EmitOptions(false, (DebugInformationFormat)0, (string)null, (string)null, 0, 0uL, false, default(SubsystemVersion), (string)null, false, true, default(System.Collections.Immutable.ImmutableArray<InstrumentationKind>), (HashAlgorithmName?)null).WithDebugInformationFormat((DebugInformationFormat)2);
			EmitResult val4 = ((Compilation)val2).Emit((Stream)fileStream, (Stream)memoryStream, (Stream)null, (Stream)null, (IEnumerable<ResourceDescription>)null, val3, (IMethodSymbol)null, (Stream)null, (IEnumerable<EmbeddedText>)null, (Stream)null, default(CancellationToken));
			if (!val4.get_Success())
			{
				text = text ?? GenerateSourceCode(code);
				string text2 = string.Join("\n", ImmutableArrayExtensions.Select<Diagnostic, string>(val4.get_Diagnostics(), (Func<Diagnostic, string>)((Diagnostic _) => ((object)_).ToString())));
				logger.WarnFormat("Compilation of assembly {0} failed with errors:\n{1}\nGenerated Source Code:\n{2}", assemblyName, text2, text);
				throw new CodeGenerationException(text2);
			}
		}
		logger.VerboseFormat("Compilation of assembly {0} succeeded.", assemblyName);
		return Assembly.LoadFrom(tempFileName);
	}

	internal static AttributeSyntax GetGeneratedCodeAttributeSyntax()
	{
		return SyntaxFactory.Attribute(typeof(GeneratedCodeAttribute).GetNameSyntax()).AddArgumentListArguments((AttributeArgumentSyntax[])(object)new AttributeArgumentSyntax[2]
		{
			SyntaxFactory.AttributeArgument((ExpressionSyntax)(object)"ELMA-Orleans-CodeGenerator".GetLiteralExpression()),
			SyntaxFactory.AttributeArgument((ExpressionSyntax)(object)CodeGeneratorVersion.GetLiteralExpression())
		});
	}

	internal static string GenerateSourceCode(CompilationUnitSyntax code)
	{
		return ((SyntaxNode)SyntaxNodeExtensions.NormalizeWhitespace<CompilationUnitSyntax>(code, "    ", "\r\n", false)).ToFullString();
	}
}
