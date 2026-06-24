using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc.Razor;
using System.Web.Razor;
using System.Web.Razor.Parser.SyntaxTree;
using System.Web.Razor.Text;
using System.Web.WebPages.Razor;

namespace EleWise.ELMA.WebCompiler;

public class RazorCompiler
{
	internal const string ViewengineExtension = ".viewengine";

	private readonly ICompiler compiler;

	private readonly ICompilerConsole console;

	private readonly List<FileCompileResult> fileResults = new List<FileCompileResult>();

	private readonly List<HttpParseException> parseExceptions = new List<HttpParseException>();

	private readonly List<WebCompileDiagnostic> compilationDiagnostics = new List<WebCompileDiagnostic>();

	private static readonly PropertyInfo setGlobalAsaxProperty = typeof(MvcWebPageRazorHost).GetProperty("GlobalAsaxTypeName", BindingFlags.Instance | BindingFlags.NonPublic);

	public string AssemblyName { get; set; }

	public bool Debug { get; set; }

	public string DefaultBaseClass { get; set; }

	public List<string> Assemblies { get; private set; }

	public List<string> Namespaces { get; set; }

	public bool IgnoreParseError { get; set; }

	public HttpParseException[] ParseFileExceptions => parseExceptions.ToArray();

	public WebCompileDiagnostic[] CompilationDiagnostics => compilationDiagnostics.ToArray();

	public FileCompileResult[] FileResults => fileResults.ToArray();

	public RazorCompiler(ICompiler compiler, ICompilerConsole console, string assemblyName = "Razor", string defaultNamespace = "ASP")
	{
		AssemblyName = assemblyName;
		Assemblies = new List<string>();
		Namespaces = new List<string>();
		this.compiler = compiler;
		this.console = console;
	}

	public byte[] Compile(IEnumerable<CompilingFileInfo> fileInfos, out byte[] pdbRaw)
	{
		Dictionary<string, FileCompileResult> dictionary = new Dictionary<string, FileCompileResult>(StringComparer.OrdinalIgnoreCase);
		List<Tuple<string, string>> list = new List<Tuple<string, string>>();
		foreach (CompilingFileInfo fileInfo in fileInfos)
		{
			FileCompileResult fileCompileResult = new FileCompileResult(fileInfo);
			fileResults.RemoveAll((FileCompileResult f) => f.FileInfo == fileInfo);
			fileResults.Add(fileCompileResult);
			try
			{
				console.WriteDebug($"Compiling file {fileInfo.VirtualPath} ...");
				compilationDiagnostics.RemoveAll((WebCompileDiagnostic d) => d.Position != null && d.Position.FilePath == fileInfo.PhysicalPath);
				Tuple<string, string> razorView = GetRazorView(fileCompileResult);
				list.Add(razorView);
				FileCompileResult fileCompileResult4 = (dictionary[razorView.Item2] = (dictionary[GetPhysicalPath(fileInfo)] = fileCompileResult));
			}
			catch (Exception ex)
			{
				console.WriteDebug($"Error: {ex.Message}");
				if (fileCompileResult.Compiled.Errors == null)
				{
					fileCompileResult.Compiled.Errors = new List<WebCompileDiagnostic>();
				}
				if (ex is HttpParseException ex2)
				{
					fileCompileResult.Compiled.Errors.Add(new WebCompileDiagnostic
					{
						Message = ex2.Message,
						Position = new WebCompileDiagnosticPosition
						{
							Line = ex2.Line
						}
					});
					if (IgnoreParseError)
					{
						continue;
					}
					throw;
				}
				parseExceptions.RemoveAll((HttpParseException e) => e.VirtualPath == fileInfo.VirtualPath);
				HttpParseException ex3 = new HttpParseException(ex.Message, ex, fileInfo.VirtualPath.Replace("~", ""), null, 0);
				parseExceptions.Add(ex3);
				if (!IgnoreParseError)
				{
					throw ex3;
				}
				fileCompileResult.Compiled.Errors.Add(new WebCompileDiagnostic
				{
					Message = ex.Message
				});
			}
		}
		byte[] peRaw;
		IEnumerable<WebCompileDiagnostic> diagnostics;
		bool num = compiler.Compile(AssemblyName, list, Assemblies, Debug, out peRaw, out pdbRaw, out diagnostics);
		compilationDiagnostics.AddRange(diagnostics);
		if (!num)
		{
			WebCompileException ex4 = new WebCompileException();
			foreach (WebCompileDiagnostic item in diagnostics.Where((WebCompileDiagnostic x) => x.IsError))
			{
				if (item.Position != null && item.Position.FilePath != null && dictionary.TryGetValue(item.Position.FilePath, out var value))
				{
					CompilingFileInfo fileInfo2 = value.FileInfo;
					ex4.FilesWithErrors.Add(fileInfo2);
					if (value.Compiled.Errors == null)
					{
						value.Compiled.Errors = new List<WebCompileDiagnostic>();
					}
					if (value.FileInfo.PhysicalPath == null && item.Position.FilePath.Equals(GetPhysicalPath(value.FileInfo), StringComparison.OrdinalIgnoreCase))
					{
						item.Position.FilePath = fileInfo2.VirtualPath;
					}
					value.Compiled.Errors.Add(item);
				}
			}
			throw ex4;
		}
		return peRaw;
	}

	private string GetPhysicalPath(CompilingFileInfo fileInfo)
	{
		return fileInfo.PhysicalPath ?? Path.GetFullPath("v:\\" + fileInfo.VirtualPath.Replace('/', '\\'));
	}

	private Tuple<string, string> GetRazorView(FileCompileResult result)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		CompilingFileInfo fileInfo = result.FileInfo;
		MvcWebPageRazorHost val = new MvcWebPageRazorHost(fileInfo.VirtualPath, fileInfo.PhysicalPath);
		((RazorEngineHost)val).set_DefaultBaseClass(DefaultBaseClass);
		((WebPageRazorHost)val).set_DefaultPageBaseClass(DefaultBaseClass);
		((RazorEngineHost)val).set_DefaultClassName(((RazorEngineHost)val).get_DefaultClassName() + "_" + fileInfo.VirtualPath.GetHashCode().ToString("x"));
		if (setGlobalAsaxProperty != null)
		{
			setGlobalAsaxProperty.SetValue(val, typeof(HttpApplication).FullName, null);
		}
		foreach (string @namespace in Namespaces)
		{
			((RazorEngineHost)val).get_NamespaceImports().Add(@namespace);
		}
		GeneratorResults val2 = RunRazorGenerator(fileInfo, (WebPageRazorHost)(object)val);
		using CodeDomProvider codeDomProvider = CodeDomProvider.CreateProvider(((RazorEngineHost)val).get_CodeLanguage().get_LanguageName());
		using MemoryStream memoryStream = new MemoryStream();
		using StreamWriter streamWriter = new StreamWriter(memoryStream);
		using StreamReader streamReader = new StreamReader(memoryStream);
		codeDomProvider.GenerateCodeFromCompileUnit(val2.get_GeneratedCode(), streamWriter, new CodeGeneratorOptions());
		streamWriter.Flush();
		memoryStream.Position = 0L;
		result.Compiled.ClassName = ((RazorEngineHost)val).get_DefaultNamespace() + "." + ((RazorEngineHost)val).get_DefaultClassName();
		return new Tuple<string, string>(streamReader.ReadToEnd(), Path.ChangeExtension(((WebPageRazorHost)val).get_VirtualPath(), ".viewengine"));
	}

	private GeneratorResults RunRazorGenerator(CompilingFileInfo fileInfo, WebPageRazorHost host)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		RazorTemplateEngine val = new RazorTemplateEngine((RazorEngineHost)(object)host);
		using Stream stream = fileInfo.Open();
		using StreamReader streamReader = new StreamReader(stream);
		GeneratorResults val2 = val.GenerateCode((TextReader)streamReader, (string)null, (string)null, GetPhysicalPath(fileInfo));
		if (!((ParserResults)val2).get_Success())
		{
			RazorError val3 = ((ParserResults)val2).get_ParserErrors().Last();
			string message = val3.get_Message() + Environment.NewLine;
			string virtualPath = fileInfo.VirtualPath;
			SourceLocation location = val3.get_Location();
			throw new HttpParseException(message, null, virtualPath, null, ((SourceLocation)(ref location)).get_LineIndex() + 1);
		}
		return val2;
	}
}
