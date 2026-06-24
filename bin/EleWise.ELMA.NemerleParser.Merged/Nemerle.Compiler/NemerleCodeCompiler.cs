using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Core;
using Nemerle.Internal;
using Nemerle.Utility;

namespace Nemerle.Compiler;

public class NemerleCodeCompiler : NemerleCodeGenerator, ICodeCompiler
{
	private sealed class _N_closureOf_CompileAssemblyFromFileBatch_51711
	{
		internal CompilerResults _N_results_51726;

		internal bool _N_succeeded_51724;

		internal bool _N_failed_51722;

		internal CompilationOptions _N_cOptions_51720;

		internal ManagerClass _N_man_51718;

		internal List<ISource> _N_sources_51716;

		internal _N_closureOf_CompileAssemblyFromFileBatch_51711()
		{
		}
	}

	private sealed class _N__N_lambda__50995__51744 : FunctionVoid<Location, string>
	{
		[SpecialName]
		private _N_closureOf_CompileAssemblyFromFileBatch_51711 _N_CompileAssemblyFromFileBatch_closure_51748;

		public _N__N_lambda__50995__51744(_N_closureOf_CompileAssemblyFromFileBatch_51711 _N_CompileAssemblyFromFileBatch_closure_51748)
		{
			this._N_CompileAssemblyFromFileBatch_closure_51748 = _N_CompileAssemblyFromFileBatch_closure_51748;
		}

		[SpecialName]
		public sealed override void apply_void(Location loc, string msg)
		{
			_N_err_event_51735(_N_CompileAssemblyFromFileBatch_closure_51748, is_warning: false, loc, msg);
			_N_CompileAssemblyFromFileBatch_closure_51748._N_failed_51722 = true;
		}
	}

	private sealed class _N__N_lambda__51001__51753 : FunctionVoid<Location, string>
	{
		[SpecialName]
		private _N_closureOf_CompileAssemblyFromFileBatch_51711 _N_CompileAssemblyFromFileBatch_closure_51757;

		public _N__N_lambda__51001__51753(_N_closureOf_CompileAssemblyFromFileBatch_51711 _N_CompileAssemblyFromFileBatch_closure_51757)
		{
			this._N_CompileAssemblyFromFileBatch_closure_51757 = _N_CompileAssemblyFromFileBatch_closure_51757;
		}

		[SpecialName]
		public sealed override void apply_void(Location loc, string msg)
		{
			_N_err_event_51735(_N_CompileAssemblyFromFileBatch_closure_51757, is_warning: true, loc, msg);
		}
	}

	private sealed class _N__N_lambda__51008__51762 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_CompileAssemblyFromFileBatch_51711 _N_CompileAssemblyFromFileBatch_closure_51766;

		public _N__N_lambda__51008__51762(_N_closureOf_CompileAssemblyFromFileBatch_51711 _N_CompileAssemblyFromFileBatch_closure_51766)
		{
			this._N_CompileAssemblyFromFileBatch_closure_51766 = _N_CompileAssemblyFromFileBatch_closure_51766;
		}

		[SpecialName]
		public sealed override void apply_void(string s)
		{
			_N_CompileAssemblyFromFileBatch_closure_51766._N_sources_51716.Add(new FileSource(s, _N_CompileAssemblyFromFileBatch_closure_51766._N_cOptions_51720.Warnings));
		}
	}

	private sealed class _N_static_proxy_51774 : FunctionVoid<string>
	{
		[SpecialName]
		public static readonly _N_static_proxy_51774 single_instance = new _N_static_proxy_51774();

		[SpecialName]
		public sealed override void apply_void(string _N_sp_parm_51781)
		{
			Message.Error(_N_sp_parm_51781);
		}

		private _N_static_proxy_51774()
		{
		}
	}

	private sealed class _N__N_lambda__51033__51784 : Function<string, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__51033__51784 Instance = new _N__N_lambda__51033__51784();

		[SpecialName]
		public sealed override bool apply(string t)
		{
			return t.Length > 0;
		}
	}

	private sealed class _N_compilerThreadProc__51825 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_CompileAssemblyFromFileBatch_51711 _N_CompileAssemblyFromFileBatch_closure_51829;

		public _N_compilerThreadProc__51825(_N_closureOf_CompileAssemblyFromFileBatch_51711 _N_CompileAssemblyFromFileBatch_closure_51829)
		{
			this._N_CompileAssemblyFromFileBatch_closure_51829 = _N_CompileAssemblyFromFileBatch_closure_51829;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			try
			{
				_N_CompileAssemblyFromFileBatch_closure_51829._N_man_51718.Run();
				_N_CompileAssemblyFromFileBatch_closure_51829._N_succeeded_51724 = !_N_CompileAssemblyFromFileBatch_closure_51829._N_failed_51722;
			}
			catch (FileNotFoundException ex)
			{
				Message.Error(ex.Message);
			}
			catch (Recovery)
			{
				_N_CompileAssemblyFromFileBatch_closure_51829._N_succeeded_51724 = false;
			}
			catch (MatchFailureException ex2)
			{
				Message.Error(ex2.Message);
			}
			catch (ICE iCE)
			{
				Message.Error(iCE.Message);
			}
			catch (AssertionException ex3)
			{
				Message.Error(ex3.Message);
			}
			catch (AssemblyFindException ex4)
			{
				Message.Error(ex4.Message);
			}
			catch (Exception ex5)
			{
				Message.Error(ex5.Message);
			}
		}
	}

	public CompilerResults CompileAssemblyFromDom(CompilerParameters options, CodeCompileUnit e)
	{
		return CompileAssemblyFromDomBatch(options, new CodeCompileUnit[1] { e });
	}

	public CompilerResults CompileAssemblyFromDomBatch(CompilerParameters options, CodeCompileUnit[] ea)
	{
		string[] array = new string[ea.Length];
		int num = 0;
		CompilerParameters compilerParameters = ((options != null) ? options : new CompilerParameters());
		StringCollection referencedAssemblies = compilerParameters.ReferencedAssemblies;
		foreach (CodeCompileUnit codeCompileUnit in ea)
		{
			CodeCompileUnit codeCompileUnit2 = codeCompileUnit;
			array[num] = GetTempFileNameWithExtension(compilerParameters.TempFiles, num + ".n");
			FileStream fileStream = new FileStream(array[num], FileMode.OpenOrCreate);
			try
			{
				StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
				if (codeCompileUnit2.ReferencedAssemblies != null)
				{
					StringEnumerator enumerator = codeCompileUnit2.ReferencedAssemblies.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							string current = enumerator.Current;
							string value = current;
							if (!referencedAssemblies.Contains(value))
							{
								referencedAssemblies.Add(value);
							}
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							IDisposable disposable = (IDisposable)enumerator;
							disposable.Dispose();
						}
					}
				}
				((ICodeGenerator)this).GenerateCodeFromCompileUnit(codeCompileUnit2, streamWriter, new CodeGeneratorOptions());
				streamWriter.Close();
			}
			finally
			{
				((IDisposable)fileStream)?.Dispose();
			}
			num = checked(num + 1);
		}
		return CompileAssemblyFromFileBatch(compilerParameters, array);
	}

	public CompilerResults CompileAssemblyFromFile(CompilerParameters options, string fileName)
	{
		return CompileAssemblyFromFileBatch(options, new string[1] { fileName });
	}

	[Macro("Nemerle.Assertions.Requires:method:postscan", 0, "options != null && fileNames != null")]
	public CompilerResults CompileAssemblyFromFileBatch(CompilerParameters options, string[] fileNames)
	{
		_N_closureOf_CompileAssemblyFromFileBatch_51711 n_closureOf_CompileAssemblyFromFileBatch_ = new _N_closureOf_CompileAssemblyFromFileBatch_51711();
		if (options == null || fileNames == null)
		{
			throw new AssertionException("ncc\\codedom\\NemerleCodeCompiler.n", 104, "options != null && fileNames != null", "The ``Requires'' contract of method `CompileAssemblyFromFileBatch' has been violated.".ToString());
		}
		n_closureOf_CompileAssemblyFromFileBatch_._N_results_51726 = new CompilerResults(options.TempFiles);
		n_closureOf_CompileAssemblyFromFileBatch_._N_succeeded_51724 = false;
		n_closureOf_CompileAssemblyFromFileBatch_._N_failed_51722 = false;
		n_closureOf_CompileAssemblyFromFileBatch_._N_cOptions_51720 = new CompilationOptions();
		n_closureOf_CompileAssemblyFromFileBatch_._N_man_51718 = new ManagerClass(n_closureOf_CompileAssemblyFromFileBatch_._N_cOptions_51720);
		ManagerClass n_man_ = n_closureOf_CompileAssemblyFromFileBatch_._N_man_51718;
		FunctionVoid<Location, string> functionVoid = new _N__N_lambda__50995__51744(n_closureOf_CompileAssemblyFromFileBatch_);
		n_man_.ErrorOccured += functionVoid.apply_void;
		ManagerClass n_man_2 = n_closureOf_CompileAssemblyFromFileBatch_._N_man_51718;
		FunctionVoid<Location, string> functionVoid2 = new _N__N_lambda__51001__51753(n_closureOf_CompileAssemblyFromFileBatch_);
		n_man_2.WarningOccured += functionVoid2.apply_void;
		n_closureOf_CompileAssemblyFromFileBatch_._N_sources_51716 = new List<ISource>();
		list<Getopt.CliOption> commonOptions = n_closureOf_CompileAssemblyFromFileBatch_._N_cOptions_51720.GetCommonOptions();
		FunctionVoid<string> handler = new _N__N_lambda__51008__51762(n_closureOf_CompileAssemblyFromFileBatch_);
		list<Getopt.CliOption> desc = commonOptions + new list<Getopt.CliOption>.Cons(new Getopt.CliOption.NonOption("", "Specify file to compile", handler), list<Getopt.CliOption>.Nil._N_constant_object);
		if (!(options.CompilerOptions == null))
		{
			_N_static_proxy_51774 single_instance = _N_static_proxy_51774.single_instance;
			list<string> list = NList.FromArray(Regex.Split(options.CompilerOptions, "\\s"));
			Function<string, bool> instance = _N__N_lambda__51033__51784.Instance;
			Getopt.Parse(single_instance, desc, list.Filter(instance));
		}
		StringWriter o = new StringWriter();
		n_closureOf_CompileAssemblyFromFileBatch_._N_man_51718.InitOutput(o);
		n_closureOf_CompileAssemblyFromFileBatch_._N_cOptions_51720.ProgressBar = false;
		n_closureOf_CompileAssemblyFromFileBatch_._N_cOptions_51720.IgnoreConfusion = true;
		n_closureOf_CompileAssemblyFromFileBatch_._N_cOptions_51720.ReferencedLibraries = list<string>.Nil._N_constant_object;
		n_closureOf_CompileAssemblyFromFileBatch_._N_cOptions_51720.TargetIsLibrary = !options.GenerateExecutable;
		CompilationOptions n_cOptions_ = n_closureOf_CompileAssemblyFromFileBatch_._N_cOptions_51720;
		bool flag = (n_cOptions_.EmitDebug = n_closureOf_CompileAssemblyFromFileBatch_._N_cOptions_51720.EmitDebug || options.IncludeDebugInformation);
		if (options.OutputAssembly == null)
		{
			options.OutputAssembly = GetTempFileNameWithExtension(options.TempFiles, "dll");
		}
		n_closureOf_CompileAssemblyFromFileBatch_._N_cOptions_51720.OutputFileName = options.OutputAssembly;
		if (null != options.ReferencedAssemblies)
		{
			StringEnumerator enumerator = options.ReferencedAssemblies.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					string hd = current;
					n_closureOf_CompileAssemblyFromFileBatch_._N_cOptions_51720.ReferencedLibraries = new list<string>.Cons(hd, n_closureOf_CompileAssemblyFromFileBatch_._N_cOptions_51720.ReferencedLibraries);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					IDisposable disposable = (IDisposable)enumerator;
					disposable.Dispose();
				}
			}
		}
		checked
		{
			if (fileNames.Length < 1)
			{
				Message.Error("need at least one file to compile");
			}
			else
			{
				foreach (string text in fileNames)
				{
					string filePath = text;
					n_closureOf_CompileAssemblyFromFileBatch_._N_sources_51716.Add(new FileSource(filePath, n_closureOf_CompileAssemblyFromFileBatch_._N_cOptions_51720.Warnings));
				}
				n_closureOf_CompileAssemblyFromFileBatch_._N_cOptions_51720.Sources = n_closureOf_CompileAssemblyFromFileBatch_._N_sources_51716.ToNList();
				FunctionVoid functionVoid3 = new _N_compilerThreadProc__51825(n_closureOf_CompileAssemblyFromFileBatch_);
				int num = 20480;
				int num2 = ((IntPtr.Size != 8) ? 1 : 2);
				int num3 = num * num2;
				Thread thread = new Thread(functionVoid3.apply_void, num3 * 1024);
				thread.Name = "Main compiler thread";
				thread.Start();
				thread.Join();
			}
			if (n_closureOf_CompileAssemblyFromFileBatch_._N_succeeded_51724)
			{
				n_closureOf_CompileAssemblyFromFileBatch_._N_results_51726.NativeCompilerReturnValue = 0;
				n_closureOf_CompileAssemblyFromFileBatch_._N_results_51726.PathToAssembly = options.OutputAssembly;
			}
			else
			{
				n_closureOf_CompileAssemblyFromFileBatch_._N_results_51726.NativeCompilerReturnValue = 1;
				n_closureOf_CompileAssemblyFromFileBatch_._N_results_51726.CompiledAssembly = null;
			}
			return n_closureOf_CompileAssemblyFromFileBatch_._N_results_51726;
		}
	}

	public CompilerResults CompileAssemblyFromSource(CompilerParameters options, string source)
	{
		return CompileAssemblyFromSourceBatch(options, new string[1] { source });
	}

	public CompilerResults CompileAssemblyFromSourceBatch(CompilerParameters options, string[] sources)
	{
		string[] array = new string[sources.Length];
		int num = 0;
		foreach (string text in sources)
		{
			string value = text;
			array[num] = GetTempFileNameWithExtension(options.TempFiles, num + ".n");
			FileStream fileStream = new FileStream(array[num], FileMode.OpenOrCreate);
			try
			{
				StreamWriter streamWriter = new StreamWriter(fileStream);
				streamWriter.Write(value);
				streamWriter.Close();
			}
			finally
			{
				((IDisposable)fileStream)?.Dispose();
			}
			num = checked(num + 1);
		}
		return CompileAssemblyFromFileBatch(options, array);
	}

	private static string GetTempFileNameWithExtension(TempFileCollection temp_files, string extension)
	{
		return temp_files.AddExtension(extension);
	}

	private static void _N_err_event_51735(_N_closureOf_CompileAssemblyFromFileBatch_51711 _N_CompileAssemblyFromFileBatch_cp_51734, bool is_warning, Location loc, string msg)
	{
		Location location = ((!(loc == Location.Default)) ? loc : LocationStack.Top());
		CompilerError compilerError = new CompilerError();
		compilerError.FileName = location.File;
		compilerError.Line = location.Line;
		compilerError.Column = location.Column;
		compilerError.IsWarning = is_warning;
		compilerError.ErrorText = msg;
		int num = _N_CompileAssemblyFromFileBatch_cp_51734._N_results_51726.Errors.Add(compilerError);
	}
}
