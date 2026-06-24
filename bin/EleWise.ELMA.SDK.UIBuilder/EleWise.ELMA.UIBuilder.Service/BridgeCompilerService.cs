using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Templates;
using EleWise.ELMA.UIBuilder.CodeGeneration;
using EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;
using EleWise.ELMA.UIBuilder.Model;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Emit;
using Mono.Cecil;

namespace EleWise.ELMA.UIBuilder.Services;

[Service]
internal sealed class BridgeCompilerService : IJavaScriptCompilerService, IJavaScriptCompilerServiceBase
{
	private readonly IJavaScriptAssemblyBuilder javaScriptAssemblyBuilder;

	private const string CompileFormat = "<Compile Include=\"{0}\" />";

	private const string BridgeScript = "BridgeScript";

	private readonly string bridgePackagesPath;

	private readonly string scriptApiPackagesPath;

	private readonly LanguageVersion defaultLanguageVersion = (LanguageVersion)7;

	private static readonly ConcurrentDictionary<string, string> AssemblyNames = new ConcurrentDictionary<string, string>();

	private readonly byte[] defaultReferenceBridge;

	private readonly byte[] defaultReferenceBridgeQUnit;

	private readonly byte[] defaultReferenceEleWiseELMACore;

	private readonly byte[] defaultReferenceEleWiseELMATestFramework;

	private readonly byte[] defaultScriptApiReferenceBridge;

	private readonly byte[] defaultScriptApiReferenceEleWiseELMACore;

	private readonly byte[] defaultScriptApiReferenceEleWiseELMATestFramework;

	private static readonly ILogger BridgeCompilerServiceLogger = Logger.GetLogger(typeof(BridgeCompilerService));

	public BridgeCompilerService(IJavaScriptAssemblyBuilder javaScriptAssemblyBuilder)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		this.javaScriptAssemblyBuilder = javaScriptAssemblyBuilder;
		string text = ConfigurationManager.AppSettings["Bridge.LibsPath"];
		if (string.IsNullOrWhiteSpace(text))
		{
			text = "Modules\\EleWise.ELMA.UIBuilder.Web\\Resources";
		}
		bridgePackagesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, text);
		scriptApiPackagesPath = Path.Combine(bridgePackagesPath, "BridgeScript");
		defaultReferenceBridge = File.ReadAllBytes(bridgePackagesPath + "\\Bridge.dll");
		defaultReferenceBridgeQUnit = File.ReadAllBytes(bridgePackagesPath + "\\Bridge.QUnit.dll");
		defaultReferenceEleWiseELMACore = File.ReadAllBytes(bridgePackagesPath + "\\EleWise.ELMA.Core.dll");
		defaultReferenceEleWiseELMATestFramework = File.ReadAllBytes(bridgePackagesPath + "\\EleWise.ELMA.TestFramework.dll");
		defaultScriptApiReferenceBridge = File.ReadAllBytes(scriptApiPackagesPath + "\\Bridge.dll");
		defaultScriptApiReferenceEleWiseELMACore = File.ReadAllBytes(scriptApiPackagesPath + "\\EleWise.ELMA.Core.dll");
		defaultScriptApiReferenceEleWiseELMATestFramework = File.ReadAllBytes(scriptApiPackagesPath + "\\EleWise.ELMA.TestFramework.dll");
	}

	public IJavaScriptCompilerModel CreateCompilerModel(string projectName, bool scriptApiCheck)
	{
		return new BridgeCompilerModel(projectName, scriptApiCheck);
	}

	public IJavaScriptCompilerModel CreateCompilerModel(string projectName, bool scriptApiCheck, string version)
	{
		return new BridgeCompilerModel(projectName, scriptApiCheck, version);
	}

	public JavaScriptCodeCompilerResult Compile(IJavaScriptCompilerModel bridgeCompiler)
	{
		return Compile(bridgeCompiler, withoutJsOutput: false);
	}

	public JavaScriptCodeCompilerResult Compile(IJavaScriptCompilerModel bridgeCompiler, bool withoutJsOutput)
	{
		return ((IJavaScriptCompilerService)this).Compile(bridgeCompiler, withoutJsOutput, (Action)null);
	}

	JavaScriptCodeCompilerResult IJavaScriptCompilerService.Compile(IJavaScriptCompilerModel bridgeCompiler, bool withoutJsOutput, Action beforeBuildAction)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		Contract.ArgumentNotNull(bridgeCompiler, "bridgeCompiler");
		IDictionary<string, string> sourceCodes = bridgeCompiler.SourceCodes;
		if (sourceCodes.Count == 0)
		{
			return null;
		}
		string projectName = bridgeCompiler.ProjectName;
		string tempFileNameWithoutExtension = IOExtensions.GetTempFileNameWithoutExtension();
		Directory.CreateDirectory(tempFileNameWithoutExtension);
		string text = ((bridgeCompiler.Version == null) ? (projectName + "_" + (uint)bridgeCompiler.GetHashCode()) : Path.Combine(projectName, bridgeCompiler.Version));
		string text2 = Path.Combine(tempFileNameWithoutExtension, text);
		if (Directory.Exists(text2))
		{
			Directory.Delete(text2, recursive: true);
		}
		Directory.CreateDirectory(text2);
		string text3 = Path.Combine(tempFileNameWithoutExtension, "bin");
		if (Directory.Exists(text3))
		{
			Directory.Delete(text3, recursive: true);
		}
		Directory.CreateDirectory(text3);
		IJavaScriptAssemblyModel javaScriptAssemblyModel = javaScriptAssemblyBuilder.CreateModel(projectName, tempFileNameWithoutExtension, text3);
		StringBuilder includesList = new StringBuilder();
		List<SyntaxTree> list = new List<SyntaxTree>();
		CSharpParseOptions val = CSharpParseOptions.get_Default().WithLanguageVersion(defaultLanguageVersion);
		foreach (KeyValuePair<string, string> item2 in sourceCodes)
		{
			string value = item2.Value;
			if (!string.IsNullOrWhiteSpace(value))
			{
				string path = item2.Key + ".cs";
				string text4 = Path.Combine(text2, path);
				javaScriptAssemblyModel.AddSourceCodeFile(text4);
				if (File.Exists(text4))
				{
					File.SetAttributes(text4, FileAttributes.Normal);
					File.Delete(text4);
				}
				File.WriteAllText(text4, value);
				File.SetAttributes(text4, FileAttributes.Normal);
				includesList.Append($"<Compile Include=\"{Path.Combine(text, path)}\" />");
				includesList.AppendLine();
				SyntaxTree item = CSharpSyntaxTree.ParseText(value, val, text4, (Encoding)null, (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken));
				list.Add(item);
			}
		}
		ScriptApiCheck(bridgeCompiler, list);
		AddDefaultReferences(bridgeCompiler);
		Dictionary<string, byte[]> references = new Dictionary<string, byte[]>();
		foreach (byte[] reference in bridgeCompiler.References)
		{
			string assemblyName = GetAssemblyName(reference);
			references[assemblyName] = reference;
		}
		string fileName = Path.Combine(tempFileNameWithoutExtension, projectName + ".csproj");
		GenerateTemplate("BridgeScriptProject.csproj", fileName, (string s) => s.Replace("{PROJECT_GUID}", Guid.NewGuid().ToString()).Replace("{ASSEMBLY_NAME}", projectName).Replace("{REFERENCES}", GenerateBridgeReferencesString(references))
			.Replace("{SOURCECODE}", string.Empty)
			.Replace("{SOURCES}", includesList.ToString()));
		CSharpCompilationOptions val2 = new CSharpCompilationOptions((OutputKind)2, false, (string)null, (string)null, (string)null, (IEnumerable<string>)null, (OptimizationLevel)0, false, false, (string)null, (string)null, default(System.Collections.Immutable.ImmutableArray<byte>), (bool?)null, (Platform)0, (ReportDiagnostic)0, 4, (IEnumerable<KeyValuePair<string, ReportDiagnostic>>)null, true, false, (XmlReferenceResolver)null, (SourceReferenceResolver)null, (MetadataReferenceResolver)null, (AssemblyIdentityComparer)null, (StrongNameProvider)null, false, (MetadataImportOptions)0, (NullableContextOptions)0);
		CSharpCompilation val3 = CSharpCompilation.Create(projectName, (IEnumerable<SyntaxTree>)list, (IEnumerable<MetadataReference>)references.Select((KeyValuePair<string, byte[]> q) => MetadataReference.CreateFromImage((IEnumerable<byte>)q.Value, default(MetadataReferenceProperties), (DocumentationProvider)null, (string)null)), val2);
		if (bridgeCompiler.DiagnosticAnalyzers.Count > 0)
		{
			System.Collections.Immutable.ImmutableArray<Diagnostic> result = DiagnosticAnalyzerExtensions.WithAnalyzers((Compilation)(object)val3, System.Collections.Immutable.ImmutableArray.ToImmutableArray<DiagnosticAnalyzer>((IEnumerable<DiagnosticAnalyzer>)bridgeCompiler.DiagnosticAnalyzers), (AnalyzerOptions)null, default(CancellationToken)).GetAllDiagnosticsAsync().GetAwaiter()
				.GetResult();
			if (ImmutableArrayExtensions.Any<Diagnostic>(result, (Func<Diagnostic, bool>)((Diagnostic d) => (int)d.get_Severity() == 3)))
			{
				StringBuilder builder2 = new StringBuilder("При анализе кода возникли следующие ошибки:");
				builder2.AppendLine();
				ImmutableArrayExtensions.Where<Diagnostic>(result, (Func<Diagnostic, bool>)((Diagnostic q) => (int)q.get_Severity() == 3)).ForEach(delegate(Diagnostic q)
				{
					builder2.AppendLine(((object)q).ToString());
				});
				string message = builder2.ToString();
				Logger.Log.Error(message);
				throw new Exception(message);
			}
		}
		string path2 = Path.Combine(text3, projectName + ".dll");
		string path3 = Path.Combine(text3, projectName + ".xml");
		using (FileStream fileStream = new FileStream(path2, FileMode.Create))
		{
			using FileStream fileStream2 = new FileStream(path3, FileMode.Create);
			EmitResult val4 = ((Compilation)val3).Emit((Stream)fileStream, (Stream)null, (Stream)fileStream2, (Stream)null, (IEnumerable<ResourceDescription>)null, (EmitOptions)null, (IMethodSymbol)null, (Stream)null, (IEnumerable<EmbeddedText>)null, (Stream)null, default(CancellationToken));
			if (!val4.get_Success())
			{
				StringBuilder builder = new StringBuilder("Не удалось сгенерировать сборку:");
				builder.AppendLine();
				ImmutableArrayExtensions.Where<Diagnostic>(val4.get_Diagnostics(), (Func<Diagnostic, bool>)((Diagnostic q) => (int)q.get_Severity() == 3)).ForEach(delegate(Diagnostic q)
				{
					builder.AppendLine(((object)q).ToString());
				});
				string message2 = builder.ToString();
				Logger.Log.Error(message2);
				throw new Exception(message2);
			}
		}
		byte[] assemblyRaw = File.ReadAllBytes(path2);
		byte[] documentationRaw = File.ReadAllBytes(path3);
		if (withoutJsOutput)
		{
			Directory.Delete(tempFileNameWithoutExtension, recursive: true);
			return new JavaScriptCodeCompilerResult
			{
				AssemblyRaw = assemblyRaw,
				DocumentationRaw = documentationRaw
			};
		}
		beforeBuildAction?.Invoke();
		foreach (KeyValuePair<string, byte[]> item3 in references)
		{
			string text5 = Path.Combine(text3, item3.Key + ".dll");
			File.WriteAllBytes(text5, item3.Value);
			javaScriptAssemblyModel.AddReferencePath(text5);
		}
		foreach (IReplaceModelMetadata replaceModelMetadatum in bridgeCompiler.ReplaceModelMetadata)
		{
			ICodeItemMetadata metadata = replaceModelMetadatum.Metadata;
			if (metadata is EnumMetadata enumMetadata)
			{
				string fullTypeName = replaceModelMetadatum.GetFullTypeName();
				javaScriptAssemblyModel.AddReplaceModel(replaceModelMetadatum.ModuleName, fullTypeName, new string[1] { metadata.Uid.ToString() }, new ReplaceModelOptions
				{
					Contract = false,
					Value = false
				});
				foreach (EnumValueMetadata value2 in enumMetadata.Values)
				{
					javaScriptAssemblyModel.AddReplaceModel(replaceModelMetadatum.ModuleName, fullTypeName + "." + value2.Name, new string[3]
					{
						value2.Uid.ToString(),
						value2.IntValue.HasValue ? value2.IntValue.Value.ToString() : null,
						((int)enumMetadata.Type).ToString()
					}, new ReplaceModelOptions
					{
						Contract = false,
						Value = true
					});
				}
			}
			else
			{
				javaScriptAssemblyModel.AddReplaceModel(replaceModelMetadatum.ModuleName, replaceModelMetadatum.GetFullTypeName(), new string[1] { metadata.Uid.ToString() }, new ReplaceModelOptions
				{
					Contract = true,
					Value = false
				});
			}
		}
		if (!javaScriptAssemblyBuilder.Build(javaScriptAssemblyModel, new JavaScriptGeneratorConfiguration
		{
			GenerateSourceMap = true,
			Minify = true,
			JsSourceCode = bridgeCompiler.JsSourceCodes.Select((KeyValuePair<string, string> c) => c.Value)
		}))
		{
			StringBuilder stringBuilder = new StringBuilder("Не удалось сгенерировать сборку:");
			stringBuilder.AppendLine();
			stringBuilder.AppendLine(javaScriptAssemblyBuilder.Errors);
			string message3 = stringBuilder.ToString();
			Logger.Log.Error(message3);
			throw new Exception(message3);
		}
		try
		{
			Directory.Delete(tempFileNameWithoutExtension, recursive: true);
		}
		catch
		{
		}
		return new JavaScriptCodeCompilerResult
		{
			AssemblyRaw = assemblyRaw,
			DocumentationRaw = documentationRaw,
			JsAssemblyRaw = javaScriptAssemblyBuilder.AssemblyRaw,
			MinJsAssemblyRaw = javaScriptAssemblyBuilder.MinAssemblyRaw
		};
	}

	private void ScriptApiCheck(IJavaScriptCompilerModel bridgeCompiler, IEnumerable<SyntaxTree> sources)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		if (!bridgeCompiler.ScriptApiCheck)
		{
			return;
		}
		ClientCodeAttributesRemover dataClassRewriter = new ClientCodeAttributesRemover();
		IReadOnlyCollection<byte[]> second = DefaultScriptApiReferences();
		CSharpCompilationOptions val = new CSharpCompilationOptions((OutputKind)2, false, (string)null, (string)null, (string)null, (IEnumerable<string>)null, (OptimizationLevel)0, false, false, (string)null, (string)null, default(System.Collections.Immutable.ImmutableArray<byte>), (bool?)null, (Platform)0, (ReportDiagnostic)0, 4, (IEnumerable<KeyValuePair<string, ReportDiagnostic>>)null, true, false, (XmlReferenceResolver)null, (SourceReferenceResolver)null, (MetadataReferenceResolver)null, (AssemblyIdentityComparer)null, (StrongNameProvider)null, false, (MetadataImportOptions)0, (NullableContextOptions)0);
		EmitResult val2 = ((Compilation)CSharpCompilation.Create(bridgeCompiler.ProjectName, sources.Select(delegate(SyntaxTree t)
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			SyntaxNode val3 = ((CSharpSyntaxVisitor<SyntaxNode>)(object)dataClassRewriter).Visit(t.GetRoot(default(CancellationToken)));
			return val3.get_SyntaxTree().WithRootAndOptions(val3, (ParseOptions)(object)CSharpParseOptions.get_Default().WithLanguageVersion(defaultLanguageVersion));
		}), (IEnumerable<MetadataReference>)(from r in bridgeCompiler.References.Concat(second)
			select MetadataReference.CreateFromImage((IEnumerable<byte>)r, default(MetadataReferenceProperties), (DocumentationProvider)null, (string)null)), val)).Emit(Stream.Null, (Stream)null, (Stream)null, (Stream)null, (IEnumerable<ResourceDescription>)null, (EmitOptions)null, (IMethodSymbol)null, (Stream)null, (IEnumerable<EmbeddedText>)null, (Stream)null, default(CancellationToken));
		if (val2.get_Success())
		{
			return;
		}
		StringBuilder builder = new StringBuilder("Не удалось скомпилировать:");
		ImmutableArrayExtensions.Where<Diagnostic>(val2.get_Diagnostics(), (Func<Diagnostic, bool>)((Diagnostic q) => (int)q.get_Severity() == 3)).ForEach(delegate(Diagnostic q)
		{
			builder.AppendLine().Append(((object)q).ToString());
		});
		string text = builder.ToString();
		BridgeCompilerServiceLogger.ErrorFormat("{0}{1}{2}", text, Environment.NewLine, new StackTrace(1, fNeedFileInfo: true).ToString().TrimEnd());
		throw new Exception(text);
	}

	private void AddDefaultReferences(IJavaScriptCompilerModel bridgeCompiler)
	{
		bridgeCompiler.AddReference(defaultReferenceBridge);
		bridgeCompiler.AddReference(File.ReadAllBytes(bridgePackagesPath + "\\Bridge.Html5.dll"));
		bridgeCompiler.AddReference(File.ReadAllBytes(bridgePackagesPath + "\\Bridge.React.dll"));
		bridgeCompiler.AddReference(defaultReferenceBridgeQUnit);
		bridgeCompiler.AddReference(defaultReferenceEleWiseELMACore);
		bridgeCompiler.AddReference(File.ReadAllBytes(bridgePackagesPath + "\\EleWise.ELMA.Core.React.dll"));
		bridgeCompiler.AddReference(File.ReadAllBytes(bridgePackagesPath + "\\EleWise.ELMA.Core.React.UI.dll"));
		bridgeCompiler.AddReference(defaultReferenceEleWiseELMATestFramework);
	}

	private IReadOnlyCollection<byte[]> DefaultScriptApiReferences()
	{
		return (IReadOnlyCollection<byte[]>)(object)new byte[3][] { defaultScriptApiReferenceBridge, defaultScriptApiReferenceEleWiseELMACore, defaultScriptApiReferenceEleWiseELMATestFramework };
	}

	private static string GenerateBridgeReferencesString(IDictionary<string, byte[]> references)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (KeyValuePair<string, byte[]> reference in references)
		{
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("  <Reference Include=\"" + reference.Key + "\">");
			stringBuilder.AppendLine("    <HintPath>bin\\" + reference.Key + ".dll</HintPath>");
			stringBuilder.AppendLine("    <Private>True</Private>");
			stringBuilder.Append("  </Reference>");
		}
		return stringBuilder.ToString();
	}

	private static void GenerateTemplate(string resourceName, string fileName, Func<string, string> conversions = null)
	{
		ResourceTemplateGenerator.GenerateTemplate<BridgeCompilerService>("Resources." + resourceName, fileName, conversions);
	}

	private static string GetAssemblyName(byte[] assemblyRaw)
	{
		MemoryStream stream = MemoryHelper.GetMemoryStream(assemblyRaw, writable: false);
		try
		{
			string md5Hash = EncryptionHelper.GetMd5Hash(stream.AsNoClose());
			stream.Seek(0L, SeekOrigin.Begin);
			return AssemblyNames.GetOrAdd(md5Hash, (string v) => ((AssemblyNameReference)AssemblyDefinition.ReadAssembly((Stream)stream).get_Name()).get_Name());
		}
		finally
		{
			if (stream != null)
			{
				((IDisposable)stream).Dispose();
			}
		}
	}
}
