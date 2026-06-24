using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;
using Nemerle.Utility;

namespace Nemerle.Compiler;

public class CompilationOptions : ISupportRelocation
{
	private sealed class _N_closureOf_GetCommonOptions_25076
	{
		internal CompilationOptions _N__N_closurised_this_ptr_25081;

		internal _N_closureOf_GetCommonOptions_25076()
		{
		}
	}

	private sealed class _N_execute_pkgconfig__25098 : Function<string, list<string>>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25102;

		public _N_execute_pkgconfig__25098(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25102)
		{
			this._N_GetCommonOptions_closure_25102 = _N_GetCommonOptions_closure_25102;
		}

		[SpecialName]
		public sealed override list<string> apply(string opt)
		{
			Process process = new Process();
			process.StartInfo.FileName = "pkg-config";
			process.StartInfo.Arguments = "--libs " + opt;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			string s = "";
			try
			{
				process.Start();
				s = process.StandardOutput.ReadLine();
				if (!process.WaitForExit(5000))
				{
					process.Kill();
					throw new Exception("operation timeouted");
				}
				process.Close();
			}
			catch (Exception ex)
			{
				Message.Warning("pkg-config execution failed: " + Convert.ToString(ex.Message));
			}
			list<string> list = _N_split_opt_25083(s);
			object result;
			if ((object)list == list<string>.Nil._N_constant_object)
			{
				result = new list<string>.Cons("-r", new list<string>.Cons(opt, list<string>.Nil._N_constant_object));
			}
			else
			{
				list<string> list2 = list;
				result = list2;
			}
			return (list<string>)result;
		}
	}

	private sealed class _N_execute_fromfile__25117 : Function<string, list<string>>
	{
		[SpecialName]
		public static readonly _N_execute_fromfile__25117 Instance = new _N_execute_fromfile__25117();

		[SpecialName]
		public sealed override list<string> apply(string s)
		{
			checked
			{
				try
				{
					string text = "";
					list<string> list = list<string>.Nil._N_constant_object;
					StreamReader streamReader = new StreamReader(s);
					try
					{
						StringBuilder stringBuilder = new StringBuilder();
						while (text != null)
						{
							int length = text.Length;
							for (int i = 0; i < length; i++)
							{
								char c = text[i];
								switch (c)
								{
								case '"':
								case '\'':
								{
									i++;
									for (char c2 = c; i < length && text[i] != c2; i++)
									{
										stringBuilder.Append(text[i]);
									}
									break;
								}
								case ' ':
									if (stringBuilder.Length > 0)
									{
										list = new list<string>.Cons(stringBuilder.ToString(), list);
										stringBuilder.Length = 0;
									}
									break;
								default:
									stringBuilder.Append(c);
									break;
								}
							}
							if (stringBuilder.Length > 0)
							{
								list = new list<string>.Cons(stringBuilder.ToString(), list);
								stringBuilder.Length = 0;
							}
							text = streamReader.ReadLine();
						}
						return NList.Rev(list);
					}
					finally
					{
						((IDisposable)streamReader)?.Dispose();
					}
				}
				catch (Exception)
				{
					Message.Error(string.Concat("cannot read response file `" + s, "'"));
					return list<string>.Nil._N_constant_object;
				}
			}
		}
	}

	private sealed class _N_set_target__25158 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25162;

		public _N_set_target__25158(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25162)
		{
			this._N_GetCommonOptions_closure_25162 = _N_GetCommonOptions_closure_25162;
		}

		[SpecialName]
		public sealed override void apply_void(string target)
		{
			string text = target.ToLowerInvariant();
			switch (text)
			{
			case "winexe":
			case "wexe":
			case "win":
				_N_GetCommonOptions_closure_25162._N__N_closurised_this_ptr_25081.TargetIsLibrary = false;
				_N_GetCommonOptions_closure_25162._N__N_closurised_this_ptr_25081.TargetIsWinexe = true;
				_N_GetCommonOptions_closure_25162._N__N_closurised_this_ptr_25081.TargetIsSet = true;
				break;
			case "lib":
			case "library":
			case "dll":
				_N_GetCommonOptions_closure_25162._N__N_closurised_this_ptr_25081.TargetIsLibrary = true;
				_N_GetCommonOptions_closure_25162._N__N_closurised_this_ptr_25081.TargetIsSet = true;
				break;
			case "exe":
			case "console":
				_N_GetCommonOptions_closure_25162._N__N_closurised_this_ptr_25081.TargetIsLibrary = false;
				_N_GetCommonOptions_closure_25162._N__N_closurised_this_ptr_25081.TargetIsWinexe = false;
				_N_GetCommonOptions_closure_25162._N__N_closurised_this_ptr_25081.TargetIsSet = true;
				break;
			default:
				Getopt.Error("invalid target `" + Convert.ToString(text) + "'");
				Environment.Exit(1);
				break;
			}
		}
	}

	private sealed class _N__N_lambda__24272__25174 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25178;

		public _N__N_lambda__24272__25174(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25178)
		{
			this._N_GetCommonOptions_closure_25178 = _N_GetCommonOptions_closure_25178;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_GetCommonOptions_closure_25178._N__N_closurised_this_ptr_25081.IndentationSyntax = true;
		}
	}

	private sealed class _N__N_lambda__24321__25183 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25187;

		public _N__N_lambda__24321__25183(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25187)
		{
			this._N_GetCommonOptions_closure_25187 = _N_GetCommonOptions_closure_25187;
		}

		[SpecialName]
		public sealed override void apply_void(string s)
		{
			_N_GetCommonOptions_closure_25187._N__N_closurised_this_ptr_25081.OutputFileName = s;
		}
	}

	private sealed class _N__N_lambda__24345__25192 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25196;

		public _N__N_lambda__24345__25192(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25196)
		{
			this._N_GetCommonOptions_closure_25196 = _N_GetCommonOptions_closure_25196;
		}

		[SpecialName]
		public sealed override void apply_void(string s)
		{
			_N_GetCommonOptions_closure_25196._N__N_closurised_this_ptr_25081.ProjectPath = s;
		}
	}

	private sealed class _N__N_lambda__24350__25201 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25205;

		public _N__N_lambda__24350__25201(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25205)
		{
			this._N_GetCommonOptions_closure_25205 = _N_GetCommonOptions_closure_25205;
		}

		[SpecialName]
		public sealed override void apply_void(string s)
		{
			_N_GetCommonOptions_closure_25205._N__N_closurised_this_ptr_25081.OutputPath = s;
		}
	}

	private sealed class _N__N_lambda__24355__25210 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25214;

		public _N__N_lambda__24355__25210(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25214)
		{
			this._N_GetCommonOptions_closure_25214 = _N_GetCommonOptions_closure_25214;
		}

		[SpecialName]
		public sealed override void apply_void(string s)
		{
			_N_GetCommonOptions_closure_25214._N__N_closurised_this_ptr_25081.RootNamespace = s;
		}
	}

	private sealed class _N__N_lambda__24360__25219 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25223;

		public _N__N_lambda__24360__25219(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25223)
		{
			this._N_GetCommonOptions_closure_25223 = _N_GetCommonOptions_closure_25223;
		}

		[SpecialName]
		public sealed override void apply_void(string s)
		{
			_N_GetCommonOptions_closure_25223._N__N_closurised_this_ptr_25081.ReferencedLibraries = new list<string>.Cons(s, _N_GetCommonOptions_closure_25223._N__N_closurised_this_ptr_25081.ReferencedLibraries);
		}
	}

	private sealed class _N__N_lambda__24365__25228 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25232;

		public _N__N_lambda__24365__25228(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25232)
		{
			this._N_GetCommonOptions_closure_25232 = _N_GetCommonOptions_closure_25232;
		}

		[SpecialName]
		public sealed override void apply_void(string s)
		{
			_N_GetCommonOptions_closure_25232._N__N_closurised_this_ptr_25081.LibraryPaths = new list<string>.Cons(s, _N_GetCommonOptions_closure_25232._N__N_closurised_this_ptr_25081.LibraryPaths);
		}
	}

	private sealed class _N__N_lambda__24370__25237 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25241;

		public _N__N_lambda__24370__25237(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25241)
		{
			this._N_GetCommonOptions_closure_25241 = _N_GetCommonOptions_closure_25241;
		}

		[SpecialName]
		public sealed override void apply_void(string x)
		{
			int num = 0;
			string[] array = x.Split(';');
			foreach (string name in array)
			{
				_N_GetCommonOptions_closure_25241._N__N_closurised_this_ptr_25081.DefineConstant(name);
			}
		}
	}

	private sealed class _N__N_lambda__24375__25254 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25258;

		public _N__N_lambda__24375__25254(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25258)
		{
			this._N_GetCommonOptions_closure_25258 = _N_GetCommonOptions_closure_25258;
		}

		[SpecialName]
		public sealed override void apply_void(string x)
		{
			_N_GetCommonOptions_closure_25258._N__N_closurised_this_ptr_25081.XmlDocOutputFileName = x;
			_N_GetCommonOptions_closure_25258._N__N_closurised_this_ptr_25081.LexerStoreComments = true;
		}
	}

	private sealed class _N__N_lambda__24380__25263 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25267;

		public _N__N_lambda__24380__25263(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25267)
		{
			this._N_GetCommonOptions_closure_25267 = _N_GetCommonOptions_closure_25267;
		}

		[SpecialName]
		public sealed override void apply_void(string x)
		{
			if (_N_GetCommonOptions_closure_25267._N__N_closurised_this_ptr_25081.UnmanagedResource == null)
			{
				_N_GetCommonOptions_closure_25267._N__N_closurised_this_ptr_25081.UnmanagedResource = x;
			}
			else
			{
				Message.Error("only one unmanaged resource can be embedded");
			}
		}
	}

	private sealed class _N__N_lambda__24385__25275 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25279;

		public _N__N_lambda__24385__25275(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25279)
		{
			this._N_GetCommonOptions_closure_25279 = _N_GetCommonOptions_closure_25279;
		}

		[SpecialName]
		public sealed override void apply_void(string x)
		{
			string text = x.ToLowerInvariant();
			if (new list<string>.Cons("x86", new list<string>.Cons("x64", new list<string>.Cons("anycpu", new list<string>.Cons("ia64", list<string>.Nil._N_constant_object)))).Contains(text))
			{
				_N_GetCommonOptions_closure_25279._N__N_closurised_this_ptr_25081.Platform = text;
			}
			else
			{
				Message.Error("invalid platform `" + Convert.ToString(x) + "'");
			}
		}
	}

	private sealed class _N__N_lambda__24391__25287 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25291;

		public _N__N_lambda__24391__25287(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25291)
		{
			this._N_GetCommonOptions_closure_25291 = _N_GetCommonOptions_closure_25291;
		}

		[SpecialName]
		public sealed override void apply_void(string x)
		{
			_N_GetCommonOptions_closure_25291._N__N_closurised_this_ptr_25081.EmbeddedResources = new list<string>.Cons(x, _N_GetCommonOptions_closure_25291._N__N_closurised_this_ptr_25081.EmbeddedResources);
		}
	}

	private sealed class _N__N_lambda__24396__25296 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25300;

		public _N__N_lambda__24396__25296(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25300)
		{
			this._N_GetCommonOptions_closure_25300 = _N_GetCommonOptions_closure_25300;
		}

		[SpecialName]
		public sealed override void apply_void(string x)
		{
			_N_GetCommonOptions_closure_25300._N__N_closurised_this_ptr_25081.LinkedResources = new list<string>.Cons(x, _N_GetCommonOptions_closure_25300._N__N_closurised_this_ptr_25081.LinkedResources);
		}
	}

	private sealed class _N__N_lambda__24401__25305 : FunctionVoid<bool>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25309;

		public _N__N_lambda__24401__25305(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25309)
		{
			this._N_GetCommonOptions_closure_25309 = _N_GetCommonOptions_closure_25309;
		}

		[SpecialName]
		public sealed override void apply_void(bool x)
		{
			_N_GetCommonOptions_closure_25309._N__N_closurised_this_ptr_25081.EmitDebug = x;
		}
	}

	private sealed class _N__N_lambda__24444__25314 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25318;

		public _N__N_lambda__24444__25314(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25318)
		{
			this._N_GetCommonOptions_closure_25318 = _N_GetCommonOptions_closure_25318;
		}

		[SpecialName]
		public sealed override void apply_void(string x)
		{
			_N_GetCommonOptions_closure_25318._N__N_closurised_this_ptr_25081.MacrosToLoad = new list<string>.Cons(x, _N_GetCommonOptions_closure_25318._N__N_closurised_this_ptr_25081.MacrosToLoad);
		}
	}

	private sealed class _N__N_lambda__24449__25323 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25327;

		public _N__N_lambda__24449__25323(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25327)
		{
			this._N_GetCommonOptions_closure_25327 = _N_GetCommonOptions_closure_25327;
		}

		[SpecialName]
		public sealed override void apply_void(string x)
		{
			WarningOptions warnings = _N_GetCommonOptions_closure_25327._N__N_closurised_this_ptr_25081.Warnings;
			int level;
			switch (x)
			{
			case "0":
				level = 0;
				break;
			case "1":
				level = 1;
				break;
			case "2":
				level = 2;
				break;
			case "3":
				level = 3;
				break;
			case "4":
				level = 4;
				break;
			case "5":
				level = 5;
				break;
			default:
				Message.Error(x + " is not a valid warning level (must be 0-5)");
				level = -1;
				break;
			}
			warnings.Level = level;
		}
	}

	private sealed class _N__N_lambda__24454__25340 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25344;

		public _N__N_lambda__24454__25340(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25344)
		{
			this._N_GetCommonOptions_closure_25344 = _N_GetCommonOptions_closure_25344;
		}

		[SpecialName]
		public sealed override void apply_void(string x)
		{
			string[] array = x.Split(',');
			foreach (string text in array)
			{
				string text2 = text;
				try
				{
					int nr = int.Parse(text2);
					_N_GetCommonOptions_closure_25344._N__N_closurised_this_ptr_25081.Warnings.Disable(nr);
				}
				catch (Exception)
				{
					Message.Error(text2 + " is not a valid warning number format");
				}
			}
		}
	}

	private sealed class _N__N_lambda__24502__25359 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25363;

		public _N__N_lambda__24502__25359(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25363)
		{
			this._N_GetCommonOptions_closure_25363 = _N_GetCommonOptions_closure_25363;
		}

		[SpecialName]
		public sealed override void apply_void(string x)
		{
			string[] array = x.Split(',');
			foreach (string text in array)
			{
				string text2 = text;
				try
				{
					int nr = int.Parse(text2);
					_N_GetCommonOptions_closure_25363._N__N_closurised_this_ptr_25081.Warnings.Enable(nr);
				}
				catch (Exception)
				{
					Message.Error(Location.Default, text2 + " is not a valid warning number format");
				}
			}
		}
	}

	private sealed class _N__N_lambda__24516__25378 : FunctionVoid<bool>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25382;

		public _N__N_lambda__24516__25378(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25382)
		{
			this._N_GetCommonOptions_closure_25382 = _N_GetCommonOptions_closure_25382;
		}

		[SpecialName]
		public sealed override void apply_void(bool val)
		{
			_N_GetCommonOptions_closure_25382._N__N_closurised_this_ptr_25081.Warnings.TreatWarningsAsErrors = val;
		}
	}

	private sealed class _N__N_lambda__24521__25387 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25391;

		public _N__N_lambda__24521__25387(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25391)
		{
			this._N_GetCommonOptions_closure_25391 = _N_GetCommonOptions_closure_25391;
		}

		[SpecialName]
		public sealed override void apply_void(string x)
		{
			_N_GetCommonOptions_closure_25391._N__N_closurised_this_ptr_25081.StrongAssemblyKeyName = x;
		}
	}

	private sealed class _N__N_lambda__24526__25396 : FunctionVoid<bool>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25400;

		public _N__N_lambda__24526__25396(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25400)
		{
			this._N_GetCommonOptions_closure_25400 = _N_GetCommonOptions_closure_25400;
		}

		[SpecialName]
		public sealed override void apply_void(bool val)
		{
			_N_GetCommonOptions_closure_25400._N__N_closurised_this_ptr_25081.GreedyReferences = val;
		}
	}

	private sealed class _N__N_lambda__24531__25405 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25409;

		public _N__N_lambda__24531__25405(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25409)
		{
			this._N_GetCommonOptions_closure_25409 = _N_GetCommonOptions_closure_25409;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_GetCommonOptions_closure_25409._N__N_closurised_this_ptr_25081.GeneralTailCallOpt = true;
		}
	}

	private sealed class _N__N_lambda__24535__25414 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25418;

		public _N__N_lambda__24535__25414(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25418)
		{
			this._N_GetCommonOptions_closure_25418 = _N_GetCommonOptions_closure_25418;
		}

		[SpecialName]
		public sealed override void apply_void(string x)
		{
			int num = 0;
			string[] array = x.Split(',');
			checked
			{
				for (num = 0; num < array.Length; num++)
				{
					string text = array[num];
					text = text;
					if (text.IndexOf('.') == -1)
					{
						_N_GetCommonOptions_closure_25418._N__N_closurised_this_ptr_25081.DisableKeyword(text);
						continue;
					}
					int num2 = text.LastIndexOf('.');
					_N_GetCommonOptions_closure_25418._N__N_closurised_this_ptr_25081.DisableKeyword(text.Substring(num2 + 1), text.Substring(0, num2));
				}
			}
		}
	}

	private sealed class _N__N_lambda__24548__25434 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25438;

		public _N__N_lambda__24548__25434(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25438)
		{
			this._N_GetCommonOptions_closure_25438 = _N_GetCommonOptions_closure_25438;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_GetCommonOptions_closure_25438._N__N_closurised_this_ptr_25081.DoNotLoadMacros = true;
		}
	}

	private sealed class _N__N_lambda__24552__25443 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25447;

		public _N__N_lambda__24552__25443(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25447)
		{
			this._N_GetCommonOptions_closure_25447 = _N_GetCommonOptions_closure_25447;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_GetCommonOptions_closure_25447._N__N_closurised_this_ptr_25081.DoNotLoadStdlib = true;
		}
	}

	private sealed class _N__N_lambda__24556__25452 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25456;

		public _N__N_lambda__24556__25452(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25456)
		{
			this._N_GetCommonOptions_closure_25456 = _N_GetCommonOptions_closure_25456;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_GetCommonOptions_closure_25456._N__N_closurised_this_ptr_25081.UseLoadedCorlib = true;
		}
	}

	private sealed class _N__N_lambda__24560__25461 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25465;

		public _N__N_lambda__24560__25461(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25465)
		{
			this._N_GetCommonOptions_closure_25465 = _N_GetCommonOptions_closure_25465;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_GetCommonOptions_closure_25465._N__N_closurised_this_ptr_25081.IgnoreConfusion = true;
		}
	}

	private sealed class _N__N_lambda__24564__25470 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25474;

		public _N__N_lambda__24564__25470(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25474)
		{
			this._N_GetCommonOptions_closure_25474 = _N_GetCommonOptions_closure_25474;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_GetCommonOptions_closure_25474._N__N_closurised_this_ptr_25081.ThrowOnError = true;
			_N_GetCommonOptions_closure_25474._N__N_closurised_this_ptr_25081.IgnoreConfusion = true;
		}
	}

	private sealed class _N__N_lambda__24568__25479 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25483;

		public _N__N_lambda__24568__25479(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25483)
		{
			this._N_GetCommonOptions_closure_25483 = _N_GetCommonOptions_closure_25483;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_GetCommonOptions_closure_25483._N__N_closurised_this_ptr_25081.EarlyExit = true;
		}
	}

	private sealed class _N__N_lambda__24572__25488 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25492;

		public _N__N_lambda__24572__25488(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25492)
		{
			this._N_GetCommonOptions_closure_25492 = _N_GetCommonOptions_closure_25492;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_GetCommonOptions_closure_25492._N__N_closurised_this_ptr_25081.DumpTypedTree = true;
		}
	}

	private sealed class _N__N_lambda__24576__25497 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25501;

		public _N__N_lambda__24576__25497(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25501)
		{
			this._N_GetCommonOptions_closure_25501 = _N_GetCommonOptions_closure_25501;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_GetCommonOptions_closure_25501._N__N_closurised_this_ptr_25081.PrintExpressionsType = true;
		}
	}

	private sealed class _N__N_lambda__24580__25506 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25510;

		public _N__N_lambda__24580__25506(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25510)
		{
			this._N_GetCommonOptions_closure_25510 = _N_GetCommonOptions_closure_25510;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_GetCommonOptions_closure_25510._N__N_closurised_this_ptr_25081.AdditionalDebug = true;
		}
	}

	private sealed class _N__N_lambda__24584__25515 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25519;

		public _N__N_lambda__24584__25515(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25519)
		{
			this._N_GetCommonOptions_closure_25519 = _N_GetCommonOptions_closure_25519;
		}

		[SpecialName]
		public sealed override void apply_void(string s)
		{
			_N_GetCommonOptions_closure_25519._N__N_closurised_this_ptr_25081.DumpTypedTree = true;
			_N_GetCommonOptions_closure_25519._N__N_closurised_this_ptr_25081.DumpNamedMethod = s;
		}
	}

	private sealed class _N__N_lambda__24589__25524 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25528;

		public _N__N_lambda__24589__25524(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25528)
		{
			this._N_GetCommonOptions_closure_25528 = _N_GetCommonOptions_closure_25528;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_GetCommonOptions_closure_25528._N__N_closurised_this_ptr_25081.DumpDecisionTree = true;
		}
	}

	private sealed class _N__N_lambda__24593__25533 : FunctionVoid
	{
		[SpecialName]
		public static readonly _N__N_lambda__24593__25533 Instance = new _N__N_lambda__24593__25533();

		[SpecialName]
		public sealed override void apply_void()
		{
			Message.Warning("This command line option (-Obcm) has beed removed, it is enabled by default");
		}
	}

	private sealed class _N__N_lambda__24597__25543 : FunctionVoid
	{
		[SpecialName]
		public static readonly _N__N_lambda__24597__25543 Instance = new _N__N_lambda__24597__25543();

		[SpecialName]
		public sealed override void apply_void()
		{
			Message.Warning("This command line option (-Oocm) has been removed, it is  enabled by default");
		}
	}

	private sealed class _N__N_lambda__24601__25553 : FunctionVoid
	{
		[SpecialName]
		public static readonly _N__N_lambda__24601__25553 Instance = new _N__N_lambda__24601__25553();

		[SpecialName]
		public sealed override void apply_void()
		{
			Message.Warning("This command line option (-Oscm) has been removed - it didn't work correctly. If you would like to contribute code for optimized string matching, please contact us.");
		}
	}

	private sealed class _N__N_lambda__24605__25563 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25567;

		public _N__N_lambda__24605__25563(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25567)
		{
			this._N_GetCommonOptions_closure_25567 = _N_GetCommonOptions_closure_25567;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_GetCommonOptions_closure_25567._N__N_closurised_this_ptr_25081.TargetIsLibrary = true;
		}
	}

	private sealed class _N__N_lambda__24609__25572 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25576;

		public _N__N_lambda__24609__25572(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25576)
		{
			this._N_GetCommonOptions_closure_25576 = _N_GetCommonOptions_closure_25576;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_GetCommonOptions_closure_25576._N__N_closurised_this_ptr_25081.TargetIsLibrary = false;
		}
	}

	private sealed class _N__N_lambda__24613__25581 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25585;

		public _N__N_lambda__24613__25581(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25585)
		{
			this._N_GetCommonOptions_closure_25585 = _N_GetCommonOptions_closure_25585;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_GetCommonOptions_closure_25585._N__N_closurised_this_ptr_25081.ProgressBar = false;
		}
	}

	private sealed class _N__N_lambda__24617__25590 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25594;

		public _N__N_lambda__24617__25590(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25594)
		{
			this._N_GetCommonOptions_closure_25594 = _N_GetCommonOptions_closure_25594;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_GetCommonOptions_closure_25594._N__N_closurised_this_ptr_25081.ColorMessages = false;
		}
	}

	private sealed class _N__N_lambda__24621__25599 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25603;

		public _N__N_lambda__24621__25599(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25603)
		{
			this._N_GetCommonOptions_closure_25603 = _N_GetCommonOptions_closure_25603;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_GetCommonOptions_closure_25603._N__N_closurised_this_ptr_25081.Warnings.Enable(10002);
		}
	}

	private sealed class _N__N_lambda__24625__25608 : FunctionVoid<bool>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25612;

		public _N__N_lambda__24625__25608(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25612)
		{
			this._N_GetCommonOptions_closure_25612 = _N_GetCommonOptions_closure_25612;
		}

		[SpecialName]
		public sealed override void apply_void(bool val)
		{
			_N_GetCommonOptions_closure_25612._N__N_closurised_this_ptr_25081.ProgressBar = val;
		}
	}

	private sealed class _N__N_lambda__24630__25617 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25621;

		public _N__N_lambda__24630__25617(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25621)
		{
			this._N_GetCommonOptions_closure_25621 = _N_GetCommonOptions_closure_25621;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_GetCommonOptions_closure_25621._N__N_closurised_this_ptr_25081.ProgressBar = false;
		}
	}

	private sealed class _N__N_lambda__24634__25626 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25630;

		public _N__N_lambda__24634__25626(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25630)
		{
			this._N_GetCommonOptions_closure_25630 = _N_GetCommonOptions_closure_25630;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			Console.Write("Following warning options are available:\n" + _N_GetCommonOptions_closure_25630._N__N_closurised_this_ptr_25081.Warnings.Help);
			Environment.Exit(0);
		}
	}

	private sealed class _N__N_lambda__24999__25635 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25639;

		public _N__N_lambda__24999__25635(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25639)
		{
			this._N_GetCommonOptions_closure_25639 = _N_GetCommonOptions_closure_25639;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_GetCommonOptions_closure_25639._N__N_closurised_this_ptr_25081.DoPrintStats = true;
		}
	}

	private sealed class _N__N_lambda__25003__25644 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25648;

		public _N__N_lambda__25003__25644(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25648)
		{
			this._N_GetCommonOptions_closure_25648 = _N_GetCommonOptions_closure_25648;
		}

		[SpecialName]
		public sealed override void apply_void(string s)
		{
			_N_GetCommonOptions_closure_25648._N__N_closurised_this_ptr_25081.MainClass = s;
		}
	}

	private sealed class _N__N_lambda__25008__25653 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25657;

		public _N__N_lambda__25008__25653(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25657)
		{
			this._N_GetCommonOptions_closure_25657 = _N_GetCommonOptions_closure_25657;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			if (_N_GetCommonOptions_closure_25657._N__N_closurised_this_ptr_25081.Optimize == null)
			{
				_N_GetCommonOptions_closure_25657._N__N_closurised_this_ptr_25081.Optimize = new Hashtable<string, int>();
			}
			_N_GetCommonOptions_closure_25657._N__N_closurised_this_ptr_25081.Optimize["tuple"] = 1;
			_N_GetCommonOptions_closure_25657._N__N_closurised_this_ptr_25081.Optimize["propagate"] = 1;
			_N_GetCommonOptions_closure_25657._N__N_closurised_this_ptr_25081.Optimize["unify"] = 1;
			_N_GetCommonOptions_closure_25657._N__N_closurised_this_ptr_25081.Optimize["print"] = 0;
		}
	}

	private sealed class _N__N_lambda__25012__25665 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25669;

		public _N__N_lambda__25012__25665(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25669)
		{
			this._N_GetCommonOptions_closure_25669 = _N_GetCommonOptions_closure_25669;
		}

		[SpecialName]
		public sealed override void apply_void(string val)
		{
			int num = 0;
			if (_N_GetCommonOptions_closure_25669._N__N_closurised_this_ptr_25081.Optimize == null)
			{
				_N_GetCommonOptions_closure_25669._N__N_closurised_this_ptr_25081.Optimize = new Hashtable<string, int>();
			}
			string[] array = val.Split(',');
			foreach (string text in array)
			{
				string[] array2 = text.Split('=');
				_N_GetCommonOptions_closure_25669._N__N_closurised_this_ptr_25081.Optimize[array2[0]] = ((array2.Length == 1) ? 1 : int.Parse(array2[1]));
			}
		}
	}

	private sealed class _N__N_lambda__25017__25688 : FunctionVoid<bool>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25692;

		public _N__N_lambda__25017__25688(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25692)
		{
			this._N_GetCommonOptions_closure_25692 = _N_GetCommonOptions_closure_25692;
		}

		[SpecialName]
		public sealed override void apply_void(bool val)
		{
			_N_GetCommonOptions_closure_25692._N__N_closurised_this_ptr_25081.CheckIntegerOverflow = val;
		}
	}

	private sealed class _N__N_lambda__25022__25697 : FunctionVoid<int>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25701;

		public _N__N_lambda__25022__25697(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25701)
		{
			this._N_GetCommonOptions_closure_25701 = _N_GetCommonOptions_closure_25701;
		}

		[SpecialName]
		public sealed override void apply_void(int val)
		{
			_N_GetCommonOptions_closure_25701._N__N_closurised_this_ptr_25081.MatchOptions.MinSwitchSizeForVariants = val;
		}
	}

	private sealed class _N__N_lambda__25046__25706 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25710;

		public _N__N_lambda__25046__25706(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25710)
		{
			this._N_GetCommonOptions_closure_25710 = _N_GetCommonOptions_closure_25710;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_GetCommonOptions_closure_25710._N__N_closurised_this_ptr_25081.TryStartDebugger = true;
		}
	}

	private sealed class _N__N_lambda__25050__25715 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25719;

		public _N__N_lambda__25050__25715(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25719)
		{
			this._N_GetCommonOptions_closure_25719 = _N_GetCommonOptions_closure_25719;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_GetCommonOptions_closure_25719._N__N_closurised_this_ptr_25081.ShowCompilerStatistics = true;
		}
	}

	private sealed class _N__N_lambda__25054__25724 : FunctionVoid<int>
	{
		[SpecialName]
		private _N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25728;

		public _N__N_lambda__25054__25724(_N_closureOf_GetCommonOptions_25076 _N_GetCommonOptions_closure_25728)
		{
			this._N_GetCommonOptions_closure_25728 = _N_GetCommonOptions_closure_25728;
		}

		[SpecialName]
		public sealed override void apply_void(int val)
		{
			_N_GetCommonOptions_closure_25728._N__N_closurised_this_ptr_25081.MatchOptions.MinSwitchSizeForOrdinals = val;
		}
	}

	public string OutputFileName;

	public string OutputPath;

	public string ProjectPath;

	public string RootNamespace;

	public string XmlDocOutputFileName;

	public bool DumpTypedTree;

	public bool PrintExpressionsType;

	public string DumpNamedMethod;

	public bool DumpDecisionTree;

	public bool AdditionalDebug;

	public bool TargetIsLibrary;

	public bool TargetIsSet;

	public bool TargetIsWinexe;

	public bool IgnoreConfusion;

	public bool ThrowOnError;

	public bool GeneralTailCallOpt;

	public bool ProgressBar;

	public bool ColorMessages;

	public bool UseLoadedCorlib;

	public bool DoNotLoadMacros;

	public bool DoNotLoadStdlib;

	public bool EmitDebug;

	public bool CompileToMemory;

	public bool EarlyExit;

	public bool GreedyReferences;

	public bool IndentationSyntax;

	public bool PersistentLibraries;

	public string MainClass;

	public bool IsMainClassAutogenerated = false;

	public bool DoPrintStats;

	public bool LexerStoreComments;

	public Hashtable<string, int> Optimize;

	public bool CheckIntegerOverflow = true;

	public bool DisableExternalParsers = false;

	public bool ShowCompilerStatistics = false;

	public string UnmanagedResource;

	public list<string> LinkedResources;

	public list<string> EmbeddedResources;

	public list<string> ReferencedLibraries;

	public list<string> LibraryPaths;

	public list<string> MacrosToLoad;

	public list<ISource> Sources;

	public bool TryStartDebugger;

	public string Platform;

	private readonly Hashtable<string, list<list<string>>> disabled_keywords = new Hashtable<string, list<list<string>>>();

	public readonly WarningOptions Warnings = new WarningOptions();

	public readonly MatchCompilerOptions MatchOptions = new MatchCompilerOptions();

	private string _N_field_filename_embeded_in_StrongAssemblyKeyName_3291;

	public Map<string, bool> CommandDefines { get; private set; }

	public string StrongAssemblyKeyName
	{
		get
		{
			return _N_field_filename_embeded_in_StrongAssemblyKeyName_3291;
		}
		set
		{
			if (value != null && _N_field_filename_embeded_in_StrongAssemblyKeyName_3291 != null)
			{
				Message.Warning("assembly key filename was already specified (`" + Convert.ToString(_N_field_filename_embeded_in_StrongAssemblyKeyName_3291) + "'), ignoring the `" + Convert.ToString(value) + "' one");
			}
			_N_field_filename_embeded_in_StrongAssemblyKeyName_3291 = value;
		}
	}

	internal void Validate()
	{
		if (Path.GetExtension(OutputFileName) == "")
		{
			OutputFileName += ((!TargetIsLibrary) ? ".exe" : ".dll");
		}
		if (EmitDebug && null != Optimize)
		{
			Message.Warning(10010, "compilation options `-debug+' and `-optimize' has poor compatibility: `-debug+' suppresses runtime optimizations");
		}
	}

	public CompilationOptions()
	{
		Clear();
	}

	public void Clear()
	{
		OutputFileName = "out.exe";
		ProjectPath = Directory.GetCurrentDirectory();
		OutputPath = "";
		XmlDocOutputFileName = null;
		DumpTypedTree = false;
		PrintExpressionsType = false;
		TargetIsLibrary = false;
		TargetIsSet = false;
		TargetIsWinexe = false;
		IgnoreConfusion = false;
		ThrowOnError = false;
		GeneralTailCallOpt = false;
		ProgressBar = false;
		ColorMessages = true;
		UseLoadedCorlib = false;
		DoNotLoadMacros = false;
		DoNotLoadStdlib = false;
		EmitDebug = false;
		CompileToMemory = false;
		EarlyExit = false;
		GreedyReferences = true;
		DumpNamedMethod = "";
		AdditionalDebug = false;
		PersistentLibraries = false;
		DumpDecisionTree = false;
		IndentationSyntax = false;
		DoPrintStats = false;
		LexerStoreComments = false;
		Optimize = null;
		CheckIntegerOverflow = true;
		UnmanagedResource = null;
		Platform = "";
		LinkedResources = list<string>.Nil._N_constant_object;
		EmbeddedResources = list<string>.Nil._N_constant_object;
		ReferencedLibraries = list<string>.Nil._N_constant_object;
		LibraryPaths = list<string>.Nil._N_constant_object;
		MacrosToLoad = list<string>.Nil._N_constant_object;
		Sources = list<ISource>.Nil._N_constant_object;
		disabled_keywords.Clear();
		CommandDefines = new Map<string, bool>();
		MainClass = null;
		StrongAssemblyKeyName = null;
		DisableExternalParsers = false;
		MatchOptions.Clear();
	}

	public void DisableKeyword(string key, string in_namespace = null)
	{
		list<string> list = ((!(in_namespace == null)) ? NString.Split(in_namespace, '.').Reverse() : null);
		option<list<list<string>>> option = disabled_keywords.Get(key);
		list<list<string>> list2;
		if (option is option<list<list<string>>>.Some)
		{
			if ((object)((option<list<list<string>>>.Some)option).val == null)
			{
				return;
			}
			list2 = ((option<list<list<string>>>.Some)option).val;
		}
		else
		{
			if (option != option<list<list<string>>>.None._N_constant_object)
			{
				throw new MatchFailureException();
			}
			list2 = list<list<string>>.Nil._N_constant_object;
		}
		if (list == null)
		{
			disabled_keywords[key] = null;
		}
		else if (!list2.Contains(list))
		{
			disabled_keywords[key] = new list<list<string>>.Cons(list, list2);
		}
	}

	public bool IsKeywordDisabled(string key, list<NamespaceTree.Node> in_namespaces)
	{
		bool flag = false;
		option<list<list<string>>> option = disabled_keywords.Get(key);
		int result;
		if (option is option<list<list<string>>>.Some)
		{
			if ((object)((option<list<list<string>>>.Some)option).val == null)
			{
				result = 1;
			}
			else
			{
				list<list<string>> val = ((option<list<list<string>>>.Some)option).val;
				list<NamespaceTree.Node> list = in_namespaces;
				while (true)
				{
					if (list is list<NamespaceTree.Node>.Cons)
					{
						NamespaceTree.Node hd = ((list<NamespaceTree.Node>.Cons)list).hd;
						list = ((list<NamespaceTree.Node>.Cons)list).tl;
						hd = hd;
						list<list<string>> list2 = val;
						while (list2 is list<list<string>>.Cons)
						{
							list<string> hd2 = ((list<list<string>>.Cons)list2).hd;
							list2 = ((list<list<string>>.Cons)list2).tl;
							if (!hd.Equals(hd2))
							{
								list2 = list2;
								continue;
							}
							goto IL_00aa;
						}
						list = list;
						continue;
					}
					flag = false;
					break;
					IL_00aa:
					flag = true;
					break;
				}
				result = (flag ? 1 : 0);
			}
		}
		else
		{
			if (option != option<list<list<string>>>.None._N_constant_object)
			{
				throw new MatchFailureException();
			}
			result = 0;
		}
		return (byte)result != 0;
	}

	public void DefineConstant(string name)
	{
		CommandDefines = CommandDefines.Replace(name, value: true);
	}

	public void UndefineConstant(string name)
	{
		CommandDefines = CommandDefines.Replace(name, value: false);
	}

	public bool IsConstantDefined(string name)
	{
		option<bool> option = CommandDefines.Find(name);
		int result;
		if (option is option<bool>.Some)
		{
			bool val = ((option<bool>.Some)option).val;
			result = (val ? 1 : 0);
		}
		else
		{
			result = 0;
		}
		return (byte)result != 0;
	}

	public bool ShouldDump(TFunHeader fn)
	{
		return DumpTypedTree && (DumpNamedMethod == "" || DumpNamedMethod == fn.Name);
	}

	public list<Getopt.CliOption> GetCommonOptions()
	{
		_N_closureOf_GetCommonOptions_25076 n_closureOf_GetCommonOptions_ = new _N_closureOf_GetCommonOptions_25076();
		n_closureOf_GetCommonOptions_._N__N_closurised_this_ptr_25081 = this;
		Function<string, list<string>> substitute = new _N_execute_pkgconfig__25098(n_closureOf_GetCommonOptions_);
		Function<string, list<string>> instance = _N_execute_fromfile__25117.Instance;
		FunctionVoid<string> handler = new _N_set_target__25158(n_closureOf_GetCommonOptions_);
		list<string>.Cons aliases = new list<string>.Cons("-i", list<string>.Nil._N_constant_object);
		FunctionVoid handler2 = new _N__N_lambda__24272__25174(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd = new Getopt.CliOption.Flag("-indentation-syntax", aliases, "Turn on indentation-based syntax (similar to Python)", handler2);
		list<string>.Cons aliases2 = new list<string>.Cons("-o", list<string>.Nil._N_constant_object);
		FunctionVoid<string> handler3 = new _N__N_lambda__24321__25183(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.String hd2 = new Getopt.CliOption.String("-out", aliases2, "Output file name", handler3);
		list<string>.Cons aliases3 = new list<string>.Cons("-pp", list<string>.Nil._N_constant_object);
		handler3 = new _N__N_lambda__24345__25192(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.String hd3 = new Getopt.CliOption.String("-project-path", aliases3, "Root path of project", handler3);
		list<string>.Nil n_constant_object = list<string>.Nil._N_constant_object;
		handler3 = new _N__N_lambda__24350__25201(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.String hd4 = new Getopt.CliOption.String("-output-path", n_constant_object, handler3);
		list<string>.Cons aliases4 = new list<string>.Cons("-rns", list<string>.Nil._N_constant_object);
		handler3 = new _N__N_lambda__24355__25210(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.String hd5 = new Getopt.CliOption.String("-root-namespace", aliases4, "Root namespace", handler3);
		Getopt.CliOption.String hd6 = new Getopt.CliOption.String("-target", new list<string>.Cons("-t", list<string>.Nil._N_constant_object), "Specifies the target (exe, library, winexe)", handler);
		list<string>.Cons aliases5 = new list<string>.Cons("-r", new list<string>.Cons("-ref", list<string>.Nil._N_constant_object));
		handler = new _N__N_lambda__24360__25219(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.String hd7 = new Getopt.CliOption.String("-reference", aliases5, "Link specified assembly", handler);
		list<string>.Cons aliases6 = new list<string>.Cons("-lib", new list<string>.Cons("-L", list<string>.Nil._N_constant_object));
		handler = new _N__N_lambda__24365__25228(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.String hd8 = new Getopt.CliOption.String("-library-path", aliases6, "Add specified directory to library search path", handler);
		list<string>.Cons aliases7 = new list<string>.Cons("-d", new list<string>.Cons("-def", list<string>.Nil._N_constant_object));
		handler = new _N__N_lambda__24370__25237(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.String hd9 = new Getopt.CliOption.String("-define", aliases7, "Define preprocessor symbol for conditional compilation", handler);
		list<string>.Nil n_constant_object2 = list<string>.Nil._N_constant_object;
		handler = new _N__N_lambda__24375__25254(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.String hd10 = new Getopt.CliOption.String("-doc", n_constant_object2, "Output XML documentation of program's class hierarchy", handler);
		list<string>.Cons aliases8 = new list<string>.Cons("-win32res", list<string>.Nil._N_constant_object);
		handler = new _N__N_lambda__24380__25263(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.String hd11 = new Getopt.CliOption.String("-win32-resource", aliases8, "Embed unmanaged resource file to output (only one allowed)", handler);
		list<string>.Nil n_constant_object3 = list<string>.Nil._N_constant_object;
		handler = new _N__N_lambda__24385__25275(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.String hd12 = new Getopt.CliOption.String("-platform", n_constant_object3, "Specifies the CPU that must be present to host the assembly (x86, x64, anycpu, ia64). The default is anycpu.", handler);
		list<string>.Cons aliases9 = new list<string>.Cons("-res", list<string>.Nil._N_constant_object);
		handler = new _N__N_lambda__24391__25287(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.String hd13 = new Getopt.CliOption.String("-resource", aliases9, "Embed resource file to output", handler);
		list<string>.Cons aliases10 = new list<string>.Cons("-linkres", list<string>.Nil._N_constant_object);
		handler = new _N__N_lambda__24396__25296(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.String hd14 = new Getopt.CliOption.String("-linkresource", aliases10, "Link resource file from output assembly", handler);
		list<string>.Cons aliases11 = new list<string>.Cons("-g", list<string>.Nil._N_constant_object);
		FunctionVoid<bool> handler4 = new _N__N_lambda__24401__25305(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Boolean hd15 = new Getopt.CliOption.Boolean("-debug", aliases11, "Enable debug symbols generation", handler4);
		Getopt.CliOption.SubstitutionString hd16 = new Getopt.CliOption.SubstitutionString("-pkg-config", new list<string>.Cons("-pkg", new list<string>.Cons("-p", list<string>.Nil._N_constant_object)), "Link to assemblies listed by pkg-config run on given string", substitute);
		Getopt.CliOption.SubstitutionString hd17 = new Getopt.CliOption.SubstitutionString("-from-file", new list<string>.Cons("@", list<string>.Nil._N_constant_object), "Read command line options from given file", instance);
		list<string>.Cons aliases12 = new list<string>.Cons("-m", list<string>.Nil._N_constant_object);
		handler = new _N__N_lambda__24444__25314(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.String hd18 = new Getopt.CliOption.String("-macros", aliases12, "Load macros from given library (without loading types from library into the scope)", handler);
		list<string>.Cons aliases13 = new list<string>.Cons("-W", list<string>.Nil._N_constant_object);
		handler = new _N__N_lambda__24449__25323(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.String hd19 = new Getopt.CliOption.String("-warn", aliases13, "Specify warning level", handler);
		list<string>.Nil n_constant_object4 = list<string>.Nil._N_constant_object;
		handler = new _N__N_lambda__24454__25340(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.String hd20 = new Getopt.CliOption.String("-nowarn", n_constant_object4, "Suppress Specified Warnings", handler);
		list<string>.Nil n_constant_object5 = list<string>.Nil._N_constant_object;
		handler = new _N__N_lambda__24502__25359(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.String hd21 = new Getopt.CliOption.String("-dowarn", n_constant_object5, "Enable Specified Warnings", handler);
		list<string>.Nil n_constant_object6 = list<string>.Nil._N_constant_object;
		handler4 = new _N__N_lambda__24516__25378(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Boolean hd22 = new Getopt.CliOption.Boolean("-warnaserror", n_constant_object6, "Treat warnings as errors", handler4);
		list<string>.Nil n_constant_object7 = list<string>.Nil._N_constant_object;
		handler = new _N__N_lambda__24521__25387(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.String hd23 = new Getopt.CliOption.String("-keyfile", n_constant_object7, "Specify a strong name key file", handler);
		list<string>.Cons aliases14 = new list<string>.Cons("-greedy", list<string>.Nil._N_constant_object);
		handler4 = new _N__N_lambda__24526__25396(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Boolean hd24 = new Getopt.CliOption.Boolean("-greedy-references", aliases14, "Recursive loading references of used assemblies", handler4);
		list<string>.Cons aliases15 = new list<string>.Cons("-Ot", list<string>.Nil._N_constant_object);
		handler2 = new _N__N_lambda__24531__25405(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd25 = new Getopt.CliOption.Flag("-general-tail-call-opt", aliases15, "Enable general tail call optimization (programs are slower on MS.NET, but faster on Mono)", handler2);
		list<string>.Cons aliases16 = new list<string>.Cons("-no-keyword", list<string>.Nil._N_constant_object);
		handler = new _N__N_lambda__24535__25414(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.String hd26 = new Getopt.CliOption.String("-disable-keyword", aliases16, "Prevent given identifiers from being reserved as keywords (it only works for keywords introduced by syntax extensions)", handler);
		list<string>.Cons aliases17 = new list<string>.Cons("-nostdmacros", list<string>.Nil._N_constant_object);
		handler2 = new _N__N_lambda__24548__25434(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd27 = new Getopt.CliOption.Flag("-no-stdmacros", aliases17, "Do not load standard macros", handler2);
		list<string>.Cons aliases18 = new list<string>.Cons("-nostdlib", list<string>.Nil._N_constant_object);
		handler2 = new _N__N_lambda__24552__25443(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd28 = new Getopt.CliOption.Flag("-no-stdlib", aliases18, "Do not load Nemerle.dll", handler2);
		handler2 = new _N__N_lambda__24556__25452(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd29 = new Getopt.CliOption.Flag("-use-loaded-corlib", "Use already loaded mscorlib.dll and System.dll", handler2);
		handler2 = new _N__N_lambda__24560__25461(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd30 = new Getopt.CliOption.Flag("-ignore-confusion", "Output stack trace even when seen errors", handler2);
		handler2 = new _N__N_lambda__24564__25470(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd31 = new Getopt.CliOption.Flag("-throw-on-error", "Output stack trace on first error", handler2);
		handler2 = new _N__N_lambda__24568__25479(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd32 = new Getopt.CliOption.Flag("-early-exit", "Exit just after first method with an error", handler2);
		list<string>.Cons aliases19 = new list<string>.Cons("-dt", list<string>.Nil._N_constant_object);
		handler2 = new _N__N_lambda__24572__25488(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd33 = new Getopt.CliOption.Flag("-dump-typed-tree", aliases19, "Pretty prints the typed tree on stdout", handler2);
		list<string>.Cons aliases20 = new list<string>.Cons("-pet", list<string>.Nil._N_constant_object);
		handler2 = new _N__N_lambda__24576__25497(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd34 = new Getopt.CliOption.Flag("-print-expressions-type", aliases20, "Pretty prints types of expressions in dump (use with -dt)", handler2);
		list<string>.Cons aliases21 = new list<string>.Cons("-ad", list<string>.Nil._N_constant_object);
		handler2 = new _N__N_lambda__24580__25506(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd35 = new Getopt.CliOption.Flag("-additional-debug", aliases21, "NOHELP", handler2);
		list<string>.Cons aliases22 = new list<string>.Cons("-dm", list<string>.Nil._N_constant_object);
		handler = new _N__N_lambda__24584__25515(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.String hd36 = new Getopt.CliOption.String("-dump-typed-method", aliases22, "Pretty prints the named typed tree on stdout", handler);
		list<string>.Cons aliases23 = new list<string>.Cons("-dd", list<string>.Nil._N_constant_object);
		handler2 = new _N__N_lambda__24589__25524(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd37 = new Getopt.CliOption.Flag("-dump-decision-trees", aliases23, "NOHELP", handler2);
		list<string>.Cons aliases24 = new list<string>.Cons("-Obcm", list<string>.Nil._N_constant_object);
		handler2 = _N__N_lambda__24593__25533.Instance;
		Getopt.CliOption.Flag hd38 = new Getopt.CliOption.Flag("-boolean-constant-matching-opt", aliases24, "NOHELP", handler2);
		list<string>.Cons aliases25 = new list<string>.Cons("-Oocm", list<string>.Nil._N_constant_object);
		handler2 = _N__N_lambda__24597__25543.Instance;
		Getopt.CliOption.Flag hd39 = new Getopt.CliOption.Flag("-ordinal-constant-matching-opt", aliases25, "NOHELP", handler2);
		list<string>.Cons aliases26 = new list<string>.Cons("-Oscm", list<string>.Nil._N_constant_object);
		handler2 = _N__N_lambda__24601__25553.Instance;
		Getopt.CliOption.Flag hd40 = new Getopt.CliOption.Flag("-string-constant-matching-opt", aliases26, "NOHELP", handler2);
		list<string>.Cons aliases27 = new list<string>.Cons("-tdll", list<string>.Nil._N_constant_object);
		handler2 = new _N__N_lambda__24605__25563(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd41 = new Getopt.CliOption.Flag("-target-library", aliases27, "NOHELP", handler2);
		list<string>.Cons aliases28 = new list<string>.Cons("-texe", list<string>.Nil._N_constant_object);
		handler2 = new _N__N_lambda__24609__25572(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd42 = new Getopt.CliOption.Flag("-target-exe", aliases28, "NOHELP", handler2);
		handler2 = new _N__N_lambda__24613__25581(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd43 = new Getopt.CliOption.Flag("-nologo", "Suppress compiler copyright message", handler2);
		handler2 = new _N__N_lambda__24617__25590(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd44 = new Getopt.CliOption.Flag("-no-color", "Disable ANSI coloring of error/warning/hint messages", handler2);
		handler2 = new _N__N_lambda__24621__25599(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd45 = new Getopt.CliOption.Flag("-pedantic-lexer", "Enable some pedantic checks for illegal characters in input stream (default at warning level 5)", handler2);
		list<string>.Cons aliases29 = new list<string>.Cons("-bar", list<string>.Nil._N_constant_object);
		handler4 = new _N__N_lambda__24625__25608(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Boolean hd46 = new Getopt.CliOption.Boolean("-progress-bar", aliases29, "Enable / disable progress bar for compilation", handler4);
		list<string>.Cons aliases30 = new list<string>.Cons("-q", list<string>.Nil._N_constant_object);
		handler2 = new _N__N_lambda__24630__25617(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd47 = new Getopt.CliOption.Flag("-no-progress-bar", aliases30, "NOHELP", handler2);
		handler2 = new _N__N_lambda__24634__25626(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd48 = new Getopt.CliOption.Flag("-warn-help", "Display help about available warnings.", handler2);
		list<string>.Nil n_constant_object8 = list<string>.Nil._N_constant_object;
		handler2 = new _N__N_lambda__24999__25635(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd49 = new Getopt.CliOption.Flag("-stats", n_constant_object8, "NOHELP", handler2);
		list<string>.Nil n_constant_object9 = list<string>.Nil._N_constant_object;
		handler = new _N__N_lambda__25003__25644(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.String hd50 = new Getopt.CliOption.String("-main", n_constant_object9, "Specify the class that contains the entry point", handler);
		list<string>.Cons aliases31 = new list<string>.Cons("-O", list<string>.Nil._N_constant_object);
		handler2 = new _N__N_lambda__25008__25653(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd51 = new Getopt.CliOption.Flag("-optimize", aliases31, "Enable / disable code optimalizations", handler2);
		list<string>.Cons aliases32 = new list<string>.Cons("-Oopt", list<string>.Nil._N_constant_object);
		handler = new _N__N_lambda__25012__25665(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.String hd52 = new Getopt.CliOption.String("-optimize-options", aliases32, "", handler);
		list<string>.Nil n_constant_object10 = list<string>.Nil._N_constant_object;
		handler4 = new _N__N_lambda__25017__25688(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Boolean hd53 = new Getopt.CliOption.Boolean("-checked", n_constant_object10, "Enable / disable integer overflow check (default: +)", handler4);
		list<string>.Cons aliases33 = new list<string>.Cons("-Oswv", list<string>.Nil._N_constant_object);
		FunctionVoid<int> handler5 = new _N__N_lambda__25022__25697(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Int hd54 = new Getopt.CliOption.Int("-min-switch-size-variants", aliases33, "Minimum size of switch table used for matching variants (0 disables this optimization).", handler5);
		list<string>.Nil n_constant_object11 = list<string>.Nil._N_constant_object;
		handler2 = new _N__N_lambda__25046__25706(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd55 = new Getopt.CliOption.Flag("-debugger", n_constant_object11, "Display assert dialog for user can start debug session", handler2);
		list<string>.Nil n_constant_object12 = list<string>.Nil._N_constant_object;
		handler2 = new _N__N_lambda__25050__25715(n_closureOf_GetCommonOptions_);
		Getopt.CliOption.Flag hd56 = new Getopt.CliOption.Flag("-stats2", n_constant_object12, "Display compilation time for methods with Nemerle.Diagnostics.CompileStatistic attribute", handler2);
		list<string>.Cons aliases34 = new list<string>.Cons("-Oswo", list<string>.Nil._N_constant_object);
		handler5 = new _N__N_lambda__25054__25724(n_closureOf_GetCommonOptions_);
		return new list<Getopt.CliOption>.Cons(hd, new list<Getopt.CliOption>.Cons(hd2, new list<Getopt.CliOption>.Cons(hd3, new list<Getopt.CliOption>.Cons(hd4, new list<Getopt.CliOption>.Cons(hd5, new list<Getopt.CliOption>.Cons(hd6, new list<Getopt.CliOption>.Cons(hd7, new list<Getopt.CliOption>.Cons(hd8, new list<Getopt.CliOption>.Cons(hd9, new list<Getopt.CliOption>.Cons(hd10, new list<Getopt.CliOption>.Cons(hd11, new list<Getopt.CliOption>.Cons(hd12, new list<Getopt.CliOption>.Cons(hd13, new list<Getopt.CliOption>.Cons(hd14, new list<Getopt.CliOption>.Cons(hd15, new list<Getopt.CliOption>.Cons(hd16, new list<Getopt.CliOption>.Cons(hd17, new list<Getopt.CliOption>.Cons(hd18, new list<Getopt.CliOption>.Cons(hd19, new list<Getopt.CliOption>.Cons(hd20, new list<Getopt.CliOption>.Cons(hd21, new list<Getopt.CliOption>.Cons(hd22, new list<Getopt.CliOption>.Cons(hd23, new list<Getopt.CliOption>.Cons(hd24, new list<Getopt.CliOption>.Cons(hd25, new list<Getopt.CliOption>.Cons(hd26, new list<Getopt.CliOption>.Cons(hd27, new list<Getopt.CliOption>.Cons(hd28, new list<Getopt.CliOption>.Cons(hd29, new list<Getopt.CliOption>.Cons(hd30, new list<Getopt.CliOption>.Cons(hd31, new list<Getopt.CliOption>.Cons(hd32, new list<Getopt.CliOption>.Cons(hd33, new list<Getopt.CliOption>.Cons(hd34, new list<Getopt.CliOption>.Cons(hd35, new list<Getopt.CliOption>.Cons(hd36, new list<Getopt.CliOption>.Cons(hd37, new list<Getopt.CliOption>.Cons(hd38, new list<Getopt.CliOption>.Cons(hd39, new list<Getopt.CliOption>.Cons(hd40, new list<Getopt.CliOption>.Cons(hd41, new list<Getopt.CliOption>.Cons(hd42, new list<Getopt.CliOption>.Cons(hd43, new list<Getopt.CliOption>.Cons(hd44, new list<Getopt.CliOption>.Cons(hd45, new list<Getopt.CliOption>.Cons(hd46, new list<Getopt.CliOption>.Cons(hd47, new list<Getopt.CliOption>.Cons(hd48, new list<Getopt.CliOption>.Cons(hd49, new list<Getopt.CliOption>.Cons(hd50, new list<Getopt.CliOption>.Cons(hd51, new list<Getopt.CliOption>.Cons(hd52, new list<Getopt.CliOption>.Cons(hd53, new list<Getopt.CliOption>.Cons(hd54, new list<Getopt.CliOption>.Cons(hd55, new list<Getopt.CliOption>.Cons(hd56, new list<Getopt.CliOption>.Cons(new Getopt.CliOption.Int("-min-switch-size-ordinals", aliases34, "Minimum size of switch table used for matching ordinals (0 disables this optimization).", handler5), list<Getopt.CliOption>.Nil._N_constant_object)))))))))))))))))))))))))))))))))))))))))))))))))))))))));
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (_info.VisitedObjects.ContainsKey(this))
		{
			return;
		}
		_info.VisitedObjects[this] = 0;
		MatchOptions?.RelocateImplInternal(_info);
		Warnings?.RelocateImplInternal(_info);
		list<ISource> sources = Sources;
		if (sources != null)
		{
			sources = sources;
			while (sources is list<ISource>.Cons)
			{
				ISource hd = ((list<ISource>.Cons)sources).hd;
				sources = ((list<ISource>.Cons)sources).tl;
				((ISupportRelocation)hd).RelocateImpl(_info);
				sources = sources;
			}
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}

	private static list<string> _N_split_opt_25083(string s)
	{
		int num = 0;
		list<string> list = null;
		checked
		{
			object result;
			if (s == null)
			{
				result = list<string>.Nil._N_constant_object;
			}
			else
			{
				string[] array = s.Split(' ', '\t', '\n', '\r');
				list = list<string>.Nil._N_constant_object;
				for (num = array.Length - 1; num >= 0; num--)
				{
					string text = array[num].Trim();
					if (text != "")
					{
						list = new list<string>.Cons(text, list);
					}
				}
				result = list;
			}
			return (list<string>)result;
		}
	}
}
