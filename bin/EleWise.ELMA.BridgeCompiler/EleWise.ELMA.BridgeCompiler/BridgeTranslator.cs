using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Bridge.Contract;
using Bridge.Translator;
using ICSharpCode.NRefactory.CSharp;
using Mono.Cecil;
using Mono.Collections.Generic;

namespace EleWise.ELMA.BridgeCompiler;

internal sealed class BridgeTranslator : Translator
{
	private class CecilAssemblyResolver : DefaultAssemblyResolver
	{
		public ILogger Logger { get; set; }

		public CecilAssemblyResolver(ILogger logger, string location)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			Logger = logger;
			((BaseAssemblyResolver)this).add_ResolveFailure(new AssemblyResolveEventHandler(CecilAssemblyResolver_ResolveFailure));
			((BaseAssemblyResolver)this).AddSearchDirectory(Path.GetDirectoryName(location));
		}

		private AssemblyDefinition CecilAssemblyResolver_ResolveFailure(object sender, AssemblyNameReference reference)
		{
			string text = ((reference != null) ? reference.get_FullName() : "");
			Logger.Trace("CecilAssemblyResolver: ResolveFailure " + text);
			return null;
		}

		public override AssemblyDefinition Resolve(string fullName)
		{
			Logger.Trace("CecilAssemblyResolver: Resolve(string) " + fullName);
			return ((BaseAssemblyResolver)this).Resolve(fullName);
		}

		public override AssemblyDefinition Resolve(AssemblyNameReference name)
		{
			string text = ((name != null) ? name.get_FullName() : "");
			Logger.Trace("CecilAssemblyResolver: Resolve(AssemblyNameReference) " + text);
			return ((DefaultAssemblyResolver)this).Resolve(name);
		}

		public override AssemblyDefinition Resolve(string fullName, ReaderParameters parameters)
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			ILogger logger = Logger;
			object obj;
			if (parameters == null)
			{
				obj = "";
			}
			else
			{
				ReadingMode readingMode = parameters.get_ReadingMode();
				obj = ((object)(ReadingMode)(ref readingMode)).ToString();
			}
			logger.Trace("CecilAssemblyResolver: Resolve(string, ReaderParameters) " + fullName + ", " + (string)obj);
			return ((BaseAssemblyResolver)this).Resolve(fullName, parameters);
		}

		public override AssemblyDefinition Resolve(AssemblyNameReference name, ReaderParameters parameters)
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			string text = ((name != null) ? name.get_FullName() : "");
			ILogger logger = Logger;
			object obj;
			if (parameters == null)
			{
				obj = "";
			}
			else
			{
				ReadingMode readingMode = parameters.get_ReadingMode();
				obj = ((object)(ReadingMode)(ref readingMode)).ToString();
			}
			logger.Trace("CecilAssemblyResolver: Resolve(AssemblyNameReference, ReaderParameters) " + text + ", " + (string)obj);
			return ((BaseAssemblyResolver)this).Resolve(name, parameters);
		}
	}

	private HashSet<string> sourceFilePaths = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);

	private HashSet<string> referenceNames = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);

	private HashSet<string> references = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);

	private bool firstLoad;

	public BridgeTranslator(string location, string source, bool fromTask = false)
		: base(location)
	{
		((Translator)this).set_FromTask(fromTask);
		((Translator)this).set_Source(source);
	}

	public BridgeTranslator(string location, string source, bool recursive, string lib)
		: this(location, source)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		((Translator)this).set_Recursive(recursive);
		((Translator)this).set_AssemblyLocation(lib);
		((Translator)this).set_FolderMode(true);
		((Translator)this).set_Outputs(new TranslatorOutput());
	}

	public void AddReference(string assemblyFileName)
	{
		if (File.Exists(assemblyFileName))
		{
			string fileName = Path.GetFileName(assemblyFileName);
			if (referenceNames.Add(fileName))
			{
				references.Add(assemblyFileName);
			}
		}
	}

	public void AddSourceFile(string sourceFilePath)
	{
		sourceFilePaths.Add(sourceFilePath);
	}

	protected override List<AssemblyDefinition> InspectReferences()
	{
		((Translator)this).set_SourceFiles((IList<string>)new List<string>());
		foreach (string sourceFilePath in sourceFilePaths)
		{
			((Translator)this).get_SourceFiles().Add(sourceFilePath);
		}
		((Translator)this).set_ParsedSourceFiles((ParsedSourceFile[])(object)new ParsedSourceFile[((Translator)this).get_SourceFiles().Count]);
		return ((Translator)this).InspectReferences();
	}

	public string GenerateSourceMap(string fileName, string content)
	{
		if (!((Translator)this).get_AssemblyInfo().get_SourceMap().get_Enabled())
		{
			return content;
		}
		string projectPath = Path.GetDirectoryName(((Translator)this).get_Location());
		SourceMapGenerator.Generate(fileName, projectPath, ref content, (Action<SourceMapBuilder>)null, (Func<string, string>)delegate(string sourceRelativePath)
		{
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			string path = null;
			try
			{
				path = Path.Combine(projectPath, sourceRelativePath);
				return ((AstNode)((Translator)this).get_ParsedSourceFiles().First((ParsedSourceFile pf) => pf.get_ParsedFile().get_FileName() == path).get_SyntaxTree()).ToString(GetFormatter());
			}
			catch (Exception ex)
			{
				throw (TranslatorException)TranslatorException.Create("Could not get ParsedSourceFile for SourceMap. Exception: {0}; projectPath: {1}; sourceRelativePath: {2}; path: {3}.", new object[4]
				{
					ex.ToString(),
					projectPath,
					sourceRelativePath,
					path
				});
			}
		}, new string[0], ((Translator)this).get_SourceFiles(), ((Translator)this).get_AssemblyInfo().get_SourceMap().get_Eol(), ((Translator)this).get_Log());
		return content;
	}

	private static CSharpFormattingOptions GetFormatter()
	{
		CSharpFormattingOptions obj = FormattingOptionsFactory.CreateSharpDevelop();
		obj.set_AnonymousMethodBraceStyle((BraceStyle)3);
		obj.set_MethodBraceStyle((BraceStyle)3);
		obj.set_StatementBraceStyle((BraceStyle)3);
		obj.set_PropertyBraceStyle((BraceStyle)3);
		obj.set_ConstructorBraceStyle((BraceStyle)3);
		obj.set_NewLineAfterConstructorInitializerColon((NewLinePlacement)1);
		obj.set_NewLineAferMethodCallOpenParentheses((NewLinePlacement)1);
		obj.set_ClassBraceStyle((BraceStyle)3);
		obj.set_ArrayInitializerBraceStyle((BraceStyle)3);
		obj.set_IndentPreprocessorDirectives(false);
		return obj;
	}

	protected override AssemblyDefinition LoadAssembly(string location, List<AssemblyDefinition> references)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		((Translator)this).get_Log().Trace("Assembly definition loading " + location + " ...");
		if (((Translator)this).get_CurrentAssemblyLocationInspected().Contains(location))
		{
			return null;
		}
		((Translator)this).get_CurrentAssemblyLocationInspected().Push(location);
		ReaderParameters val = new ReaderParameters();
		val.set_ReadingMode((ReadingMode)2);
		val.set_AssemblyResolver((IAssemblyResolver)(object)new CecilAssemblyResolver(((Translator)this).get_Log(), ((Translator)this).get_AssemblyLocation()));
		AssemblyDefinition val2 = AssemblyDefinition.ReadAssembly(location, val);
		if (firstLoad)
		{
			string text = ((Translator)this).get_CurrentAssemblyLocationInspected().Pop();
			if (text != location)
			{
				throw new InvalidOperationException($"Current location {location} is not the current location in stack {text}");
			}
			return val2;
		}
		firstLoad = true;
		string directoryName = Path.GetDirectoryName(location);
		Enumerator<AssemblyNameReference> enumerator = val2.get_MainModule().get_AssemblyReferences().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				AssemblyNameReference current = enumerator.get_Current();
				string name = current.get_Name();
				if (name == "mscorlib" || name == "System.Core")
				{
					continue;
				}
				string fullName = current.get_FullName();
				if (!references.Any((AssemblyDefinition a) => ((AssemblyNameReference)a.get_Name()).get_FullName() == fullName))
				{
					string text2 = Path.Combine(directoryName, name) + ".dll";
					if (name.ToLowerInvariant() == "bridge" && (string.IsNullOrWhiteSpace(((Translator)this).get_BridgeLocation()) || !File.Exists(((Translator)this).get_BridgeLocation())))
					{
						((Translator)this).set_BridgeLocation(text2);
					}
					AssemblyDefinition reference = ((Translator)this).LoadAssembly(text2, references);
					if (reference != null && !references.Any((AssemblyDefinition a) => ((AssemblyNameReference)a.get_Name()).get_FullName() == ((AssemblyNameReference)reference.get_Name()).get_FullName()))
					{
						references.Add(reference);
					}
				}
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		((Translator)this).get_Log().Trace("Assembly definition loading " + location + " done");
		string text3 = ((Translator)this).get_CurrentAssemblyLocationInspected().Pop();
		if (text3 != location)
		{
			throw new InvalidOperationException($"Current location {location} is not the current location in stack {text3}");
		}
		return val2;
	}
}
