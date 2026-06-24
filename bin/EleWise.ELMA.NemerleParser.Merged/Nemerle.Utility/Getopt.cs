using System;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Utility;

public static class Getopt
{
	[Variant("Nemerle.Utility.Getopt.CliOption.Flag,Nemerle.Utility.Getopt.CliOption.Boolean,Nemerle.Utility.Getopt.CliOption.String,Nemerle.Utility.Getopt.CliOption.Int,Nemerle.Utility.Getopt.CliOption.NonOption,Nemerle.Utility.Getopt.CliOption.Unhandled,Nemerle.Utility.Getopt.CliOption.SubstitutionString,Nemerle.Utility.Getopt.CliOption.PreHelp,Nemerle.Utility.Getopt.CliOption.PostHelp")]
	public abstract class CliOption
	{
		[VariantOption]
		public class Flag : CliOption
		{
			public readonly FunctionVoid handler;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 0;
			}

			[RecordCtor]
			public Flag(string name, list<string> aliases, string help, bool required, [MappedMember("handler")] FunctionVoid handler)
				: base(name, aliases, help, required)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Flag(string name, [MappedMember("handler")] FunctionVoid handler)
				: base(name)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Flag(string name, list<string> aliases, [MappedMember("handler")] FunctionVoid handler)
				: base(name, aliases)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Flag(string name, string help, [MappedMember("handler")] FunctionVoid handler)
				: base(name, help)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Flag(string name, bool required, [MappedMember("handler")] FunctionVoid handler)
				: base(name, required)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Flag(string name, list<string> aliases, string help, [MappedMember("handler")] FunctionVoid handler)
				: base(name, aliases, help)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Flag(string name, list<string> aliases, bool required, [MappedMember("handler")] FunctionVoid handler)
				: base(name, aliases, required)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Flag(string name, string help, bool required, [MappedMember("handler")] FunctionVoid handler)
				: base(name, help, required)
			{
				this.handler = handler;
			}
		}

		[VariantOption]
		public class Boolean : CliOption
		{
			public readonly FunctionVoid<bool> handler;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 1;
			}

			[RecordCtor]
			public Boolean(string name, list<string> aliases, string help, bool required, [MappedMember("handler")] FunctionVoid<bool> handler)
				: base(name, aliases, help, required)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Boolean(string name, [MappedMember("handler")] FunctionVoid<bool> handler)
				: base(name)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Boolean(string name, list<string> aliases, [MappedMember("handler")] FunctionVoid<bool> handler)
				: base(name, aliases)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Boolean(string name, string help, [MappedMember("handler")] FunctionVoid<bool> handler)
				: base(name, help)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Boolean(string name, bool required, [MappedMember("handler")] FunctionVoid<bool> handler)
				: base(name, required)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Boolean(string name, list<string> aliases, string help, [MappedMember("handler")] FunctionVoid<bool> handler)
				: base(name, aliases, help)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Boolean(string name, list<string> aliases, bool required, [MappedMember("handler")] FunctionVoid<bool> handler)
				: base(name, aliases, required)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Boolean(string name, string help, bool required, [MappedMember("handler")] FunctionVoid<bool> handler)
				: base(name, help, required)
			{
				this.handler = handler;
			}
		}

		[VariantOption]
		public class String : CliOption
		{
			public readonly FunctionVoid<string> handler;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 2;
			}

			[RecordCtor]
			public String(string name, list<string> aliases, string help, bool required, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name, aliases, help, required)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public String(string name, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public String(string name, list<string> aliases, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name, aliases)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public String(string name, string help, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name, help)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public String(string name, bool required, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name, required)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public String(string name, list<string> aliases, string help, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name, aliases, help)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public String(string name, list<string> aliases, bool required, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name, aliases, required)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public String(string name, string help, bool required, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name, help, required)
			{
				this.handler = handler;
			}
		}

		[VariantOption]
		public class Int : CliOption
		{
			public readonly FunctionVoid<int> handler;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 3;
			}

			[RecordCtor]
			public Int(string name, list<string> aliases, string help, bool required, [MappedMember("handler")] FunctionVoid<int> handler)
				: base(name, aliases, help, required)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Int(string name, [MappedMember("handler")] FunctionVoid<int> handler)
				: base(name)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Int(string name, list<string> aliases, [MappedMember("handler")] FunctionVoid<int> handler)
				: base(name, aliases)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Int(string name, string help, [MappedMember("handler")] FunctionVoid<int> handler)
				: base(name, help)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Int(string name, bool required, [MappedMember("handler")] FunctionVoid<int> handler)
				: base(name, required)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Int(string name, list<string> aliases, string help, [MappedMember("handler")] FunctionVoid<int> handler)
				: base(name, aliases, help)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Int(string name, list<string> aliases, bool required, [MappedMember("handler")] FunctionVoid<int> handler)
				: base(name, aliases, required)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Int(string name, string help, bool required, [MappedMember("handler")] FunctionVoid<int> handler)
				: base(name, help, required)
			{
				this.handler = handler;
			}
		}

		[VariantOption]
		public class NonOption : CliOption
		{
			public readonly FunctionVoid<string> handler;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 4;
			}

			[RecordCtor]
			public NonOption(string name, list<string> aliases, string help, bool required, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name, aliases, help, required)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public NonOption(string name, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public NonOption(string name, list<string> aliases, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name, aliases)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public NonOption(string name, string help, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name, help)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public NonOption(string name, bool required, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name, required)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public NonOption(string name, list<string> aliases, string help, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name, aliases, help)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public NonOption(string name, list<string> aliases, bool required, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name, aliases, required)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public NonOption(string name, string help, bool required, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name, help, required)
			{
				this.handler = handler;
			}
		}

		[VariantOption]
		public class Unhandled : CliOption
		{
			public readonly FunctionVoid<string> handler;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 5;
			}

			[RecordCtor]
			public Unhandled(string name, list<string> aliases, string help, bool required, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name, aliases, help, required)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Unhandled(string name, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Unhandled(string name, list<string> aliases, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name, aliases)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Unhandled(string name, string help, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name, help)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Unhandled(string name, bool required, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name, required)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Unhandled(string name, list<string> aliases, string help, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name, aliases, help)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Unhandled(string name, list<string> aliases, bool required, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name, aliases, required)
			{
				this.handler = handler;
			}

			[RecordCtor]
			public Unhandled(string name, string help, bool required, [MappedMember("handler")] FunctionVoid<string> handler)
				: base(name, help, required)
			{
				this.handler = handler;
			}
		}

		[VariantOption]
		public class SubstitutionString : CliOption
		{
			public readonly Function<string, list<string>> substitute;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 6;
			}

			[RecordCtor]
			public SubstitutionString(string name, list<string> aliases, string help, bool required, [MappedMember("substitute")] Function<string, list<string>> substitute)
				: base(name, aliases, help, required)
			{
				this.substitute = substitute;
			}

			[RecordCtor]
			public SubstitutionString(string name, [MappedMember("substitute")] Function<string, list<string>> substitute)
				: base(name)
			{
				this.substitute = substitute;
			}

			[RecordCtor]
			public SubstitutionString(string name, list<string> aliases, [MappedMember("substitute")] Function<string, list<string>> substitute)
				: base(name, aliases)
			{
				this.substitute = substitute;
			}

			[RecordCtor]
			public SubstitutionString(string name, string help, [MappedMember("substitute")] Function<string, list<string>> substitute)
				: base(name, help)
			{
				this.substitute = substitute;
			}

			[RecordCtor]
			public SubstitutionString(string name, bool required, [MappedMember("substitute")] Function<string, list<string>> substitute)
				: base(name, required)
			{
				this.substitute = substitute;
			}

			[RecordCtor]
			public SubstitutionString(string name, list<string> aliases, string help, [MappedMember("substitute")] Function<string, list<string>> substitute)
				: base(name, aliases, help)
			{
				this.substitute = substitute;
			}

			[RecordCtor]
			public SubstitutionString(string name, list<string> aliases, bool required, [MappedMember("substitute")] Function<string, list<string>> substitute)
				: base(name, aliases, required)
			{
				this.substitute = substitute;
			}

			[RecordCtor]
			public SubstitutionString(string name, string help, bool required, [MappedMember("substitute")] Function<string, list<string>> substitute)
				: base(name, help, required)
			{
				this.substitute = substitute;
			}
		}

		[VariantOption]
		public class PreHelp : CliOption
		{
			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 7;
			}

			[RecordCtor]
			public PreHelp(string name, list<string> aliases, string help, bool required)
				: base(name, aliases, help, required)
			{
			}

			[RecordCtor]
			public PreHelp(string name)
				: base(name)
			{
			}

			[RecordCtor]
			public PreHelp(string name, list<string> aliases)
				: base(name, aliases)
			{
			}

			[RecordCtor]
			public PreHelp(string name, string help)
				: base(name, help)
			{
			}

			[RecordCtor]
			public PreHelp(string name, bool required)
				: base(name, required)
			{
			}

			[RecordCtor]
			public PreHelp(string name, list<string> aliases, string help)
				: base(name, aliases, help)
			{
			}

			[RecordCtor]
			public PreHelp(string name, list<string> aliases, bool required)
				: base(name, aliases, required)
			{
			}

			[RecordCtor]
			public PreHelp(string name, string help, bool required)
				: base(name, help, required)
			{
			}
		}

		[VariantOption]
		public class PostHelp : CliOption
		{
			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 8;
			}

			[RecordCtor]
			public PostHelp(string name, list<string> aliases, string help, bool required)
				: base(name, aliases, help, required)
			{
			}

			[RecordCtor]
			public PostHelp(string name)
				: base(name)
			{
			}

			[RecordCtor]
			public PostHelp(string name, list<string> aliases)
				: base(name, aliases)
			{
			}

			[RecordCtor]
			public PostHelp(string name, string help)
				: base(name, help)
			{
			}

			[RecordCtor]
			public PostHelp(string name, bool required)
				: base(name, required)
			{
			}

			[RecordCtor]
			public PostHelp(string name, list<string> aliases, string help)
				: base(name, aliases, help)
			{
			}

			[RecordCtor]
			public PostHelp(string name, list<string> aliases, bool required)
				: base(name, aliases, required)
			{
			}

			[RecordCtor]
			public PostHelp(string name, string help, bool required)
				: base(name, help, required)
			{
			}
		}

		public readonly string name;

		public readonly list<string> aliases;

		public readonly string help;

		public readonly bool required;

		public CliOption(string name, list<string> aliases, string help, bool required)
		{
			this.name = name;
			this.aliases = aliases;
			this.help = help;
			this.required = required;
		}

		public CliOption(string name)
			: this(name, list<string>.Nil._N_constant_object, string.Empty, required: false)
		{
		}

		public CliOption(string name, list<string> aliases)
			: this(name, aliases, string.Empty, required: false)
		{
		}

		public CliOption(string name, string help)
			: this(name, list<string>.Nil._N_constant_object, help, required: false)
		{
		}

		public CliOption(string name, bool required)
			: this(name, list<string>.Nil._N_constant_object, string.Empty, required)
		{
		}

		public CliOption(string name, list<string> aliases, string help)
			: this(name, aliases, help, required: false)
		{
		}

		public CliOption(string name, list<string> aliases, bool required)
			: this(name, aliases, string.Empty, required)
		{
		}

		public CliOption(string name, string help, bool required)
			: this(name, list<string>.Nil._N_constant_object, help, required)
		{
		}

		[SpecialName]
		public abstract override int _N_GetVariantCode();

		[SpecialName]
		public static int _N_GetVariantCodeSafe(CliOption x)
		{
			return ((object)x != null) ? x._N_GetVariantCode() : (-1);
		}

		[SpecialName]
		public static int _N_GetVariantCodeObject(object x)
		{
			return (!(x is CliOption)) ? (-1) : ((CliOption)x)._N_GetVariantCode();
		}
	}

	private sealed class _N_closureOf_Usage_11541
	{
		internal _N_closureOf_Usage_11541()
		{
		}
	}

	private sealed class _N_describe__11556 : Function<CliOption, string, string>
	{
		[SpecialName]
		private _N_closureOf_Usage_11541 _N_Usage_closure_11560;

		public _N_describe__11556(_N_closureOf_Usage_11541 _N_Usage_closure_11560)
		{
			this._N_Usage_closure_11560 = _N_Usage_closure_11560;
		}

		[SpecialName]
		public sealed override string apply(CliOption opt, string acc)
		{
			_N_closureOf_describe_11565 n_closureOf_describe_ = new _N_closureOf_describe_11565();
			n_closureOf_describe_._N_opt_11570 = opt;
			object obj;
			if (n_closureOf_describe_._N_opt_11570 is CliOption.Flag)
			{
				obj = string.Concat(_N_stdpref_11574(n_closureOf_describe_, _N_Usage_closure_11560) + "  ", _N_stdsuff_11582(n_closureOf_describe_));
			}
			else if (n_closureOf_describe_._N_opt_11570 is CliOption.Boolean)
			{
				obj = string.Concat(_N_stdpref_11574(n_closureOf_describe_, _N_Usage_closure_11560) + "+/-  ", _N_stdsuff_11582(n_closureOf_describe_));
			}
			else
			{
				if (n_closureOf_describe_._N_opt_11570 is CliOption.String)
				{
					goto IL_0137;
				}
				if (n_closureOf_describe_._N_opt_11570 is CliOption.Int)
				{
					obj = string.Concat(_N_stdpref_11574(n_closureOf_describe_, _N_Usage_closure_11560) + ":INT  ", _N_stdsuff_11582(n_closureOf_describe_));
				}
				else if (n_closureOf_describe_._N_opt_11570 is CliOption.NonOption)
				{
					obj = ((!(n_closureOf_describe_._N_opt_11570.help != "")) ? "" : ("    STRING  " + _N_stdsuff_11582(n_closureOf_describe_)));
				}
				else if (n_closureOf_describe_._N_opt_11570 is CliOption.Unhandled)
				{
					obj = "";
				}
				else
				{
					if (n_closureOf_describe_._N_opt_11570 is CliOption.SubstitutionString)
					{
						goto IL_0137;
					}
					if (!(n_closureOf_describe_._N_opt_11570 is CliOption.PreHelp) && !(n_closureOf_describe_._N_opt_11570 is CliOption.PostHelp))
					{
						throw new MatchFailureException();
					}
					obj = _N_stdsuff_11582(n_closureOf_describe_);
				}
			}
			goto IL_0193;
			IL_0137:
			obj = string.Concat(_N_stdpref_11574(n_closureOf_describe_, _N_Usage_closure_11560) + ":STRING  ", _N_stdsuff_11582(n_closureOf_describe_));
			goto IL_0193;
			IL_0193:
			string text = (string)obj;
			return (!(n_closureOf_describe_._N_opt_11570.help == "NOHELP")) ? (acc + text) : acc;
		}
	}

	private sealed class _N_closureOf_describe_11565
	{
		internal CliOption _N_opt_11570;

		internal _N_closureOf_describe_11565()
		{
		}
	}

	private sealed class _N_closureOf_Parse_11697
	{
		internal FunctionVoid<string> _N_error_fn_11714;

		internal list<CliOption> _N_desc_11712;

		internal FunctionVoid<string> _N_unhandled_11710;

		internal FunctionVoid<string> _N_non_option_11708;

		internal Hashtable<string, CliOption> _N_options_11706;

		internal Hashtable<CliOption, bool> _N_defined_11704;

		internal bool _N_do_parse_options_11702;

		internal _N_closureOf_Parse_11697()
		{
		}
	}

	private sealed class _N_stdunhandled__11716 : FunctionVoid<string>
	{
		[SpecialName]
		private _N_closureOf_Parse_11697 _N_Parse_closure_11720;

		public _N_stdunhandled__11716(_N_closureOf_Parse_11697 _N_Parse_closure_11720)
		{
			this._N_Parse_closure_11720 = _N_Parse_closure_11720;
		}

		[SpecialName]
		public sealed override void apply_void(string s)
		{
			_N_Parse_closure_11720._N_error_fn_11714.apply_void(string.Concat(string.Concat("unhandled command line argument: " + s, "\n"), Usage(_N_Parse_closure_11720._N_desc_11712)));
		}
	}

	private sealed class _N_static_proxy_12529 : FunctionVoid<string>
	{
		[SpecialName]
		public static readonly _N_static_proxy_12529 single_instance = new _N_static_proxy_12529();

		[SpecialName]
		public sealed override void apply_void(string _N_sp_parm_12536)
		{
			Error(_N_sp_parm_12536);
		}

		private _N_static_proxy_12529()
		{
		}
	}

	public static string Usage(list<CliOption> args)
	{
		_N_closureOf_Usage_11541 n_Usage_closure_ = new _N_closureOf_Usage_11541();
		Function<CliOption, string, string> f = new _N_describe__11556(n_Usage_closure_);
		return args.FoldLeft("", f);
	}

	public static void Parse(FunctionVoid<string> error_fn, list<CliOption> desc, list<string> args)
	{
		_N_closureOf_Parse_11697 n_closureOf_Parse_ = new _N_closureOf_Parse_11697();
		n_closureOf_Parse_._N_error_fn_11714 = error_fn;
		n_closureOf_Parse_._N_desc_11712 = desc;
		n_closureOf_Parse_._N_non_option_11708 = (n_closureOf_Parse_._N_unhandled_11710 = new _N_stdunhandled__11716(n_closureOf_Parse_));
		n_closureOf_Parse_._N_options_11706 = new Hashtable<string, CliOption>();
		n_closureOf_Parse_._N_defined_11704 = new Hashtable<CliOption, bool>();
		list<CliOption> list;
		for (list = n_closureOf_Parse_._N_desc_11712; list is list<CliOption>.Cons; list = list)
		{
			CliOption hd = ((list<CliOption>.Cons)list).hd;
			list = ((list<CliOption>.Cons)list).tl;
			hd = hd;
			if (!(hd is CliOption.Flag) && !(hd is CliOption.Boolean) && !(hd is CliOption.String) && !(hd is CliOption.Int))
			{
				if (hd is CliOption.NonOption)
				{
					FunctionVoid<string> functionVoid = (n_closureOf_Parse_._N_non_option_11708 = ((CliOption.NonOption)hd).handler);
					continue;
				}
				if (hd is CliOption.Unhandled)
				{
					FunctionVoid<string> functionVoid = (n_closureOf_Parse_._N_unhandled_11710 = ((CliOption.Unhandled)hd).handler);
					continue;
				}
				if (!(hd is CliOption.SubstitutionString))
				{
					if (hd is CliOption.PreHelp || hd is CliOption.PostHelp)
					{
						continue;
					}
					throw new MatchFailureException();
				}
			}
			n_closureOf_Parse_._N_defined_11704.Add(hd, value: false);
			list<string> list2 = new list<string>.Cons(hd.name, hd.aliases);
			while (list2 is list<string>.Cons)
			{
				string hd2 = ((list<string>.Cons)list2).hd;
				list2 = ((list<string>.Cons)list2).tl;
				n_closureOf_Parse_._N_options_11706.Add(hd2, hd);
				list2 = list2;
			}
		}
		n_closureOf_Parse_._N_do_parse_options_11702 = true;
		_N_parse_opts_11824(n_closureOf_Parse_, args);
	}

	public static void Error(string message)
	{
		string text = Environment.GetCommandLineArgs()[0];
		Console.Error.WriteLine(string.Concat(text + ": ", message));
		Environment.Exit(1);
	}

	public static void Parse(list<CliOption> desc)
	{
		list<string> list = NList.FromArray(Environment.GetCommandLineArgs());
		if (list is list<string>.Cons)
		{
			list = ((list<string>.Cons)list).tl;
			Parse(_N_static_proxy_12529.single_instance, desc, list);
		}
		else if ((object)list != list<string>.Nil._N_constant_object)
		{
			throw new MatchFailureException();
		}
	}

	private static string _N_concat_11547(_N_closureOf_Usage_11541 _N_Usage_cp_11546, string sep, list<string> lst)
	{
		object result;
		if ((object)lst == list<string>.Nil._N_constant_object)
		{
			result = "";
		}
		else
		{
			if (!(lst is list<string>.Cons))
			{
				throw new MatchFailureException();
			}
			string hd = ((list<string>.Cons)lst).hd;
			list<string> lst2 = ((list<string>.Cons)lst).tl;
			result = string.Concat(hd + sep, _N_concat_11547(_N_Usage_cp_11546, sep, lst2));
		}
		return (string)result;
	}

	private static string _N_stdpref_11574(_N_closureOf_describe_11565 _N_describe_cp_11572, _N_closureOf_Usage_11541 _N_Usage_cp_11573)
	{
		return string.Concat("    " + _N_concat_11547(_N_Usage_cp_11573, ", ", _N_describe_cp_11572._N_opt_11570.aliases), _N_describe_cp_11572._N_opt_11570.name);
	}

	private static string _N_stdsuff_11582(_N_closureOf_describe_11565 _N_describe_cp_11581)
	{
		return _N_describe_cp_11581._N_opt_11570.help + "\n";
	}

	private static string _N_option_name_11744(string s)
	{
		if (s[0] == '/')
		{
			s = "-" + s.Substring(1);
		}
		return checked((s.IndexOf('@') != -1) ? s.Substring(0, s.IndexOf('@') + 1) : ((s.IndexOf(':') != -1) ? s.Substring(0, s.IndexOf(':')) : ((!s.EndsWith("+") && !s.EndsWith("-")) ? s : s.Substring(0, s.Length - 1))));
	}

	private static option<string> _N_argument_name_11764(string opt)
	{
		return checked((opt.IndexOf('@') != -1) ? new option<string>.Some(opt.Substring(opt.IndexOf('@') + 1)) : ((opt.IndexOf(':') != -1) ? new option<string>.Some(opt.Substring(opt.IndexOf(':') + 1)) : (opt.EndsWith("+") ? new option<string>.Some("+") : ((!opt.EndsWith("-")) ? ((option<string>)option<string>.None._N_constant_object) : ((option<string>)new option<string>.Some("-"))))));
	}

	private static bool _N_is_option_11782(_N_closureOf_Parse_11697 _N_Parse_cp_11781, string s)
	{
		int result;
		if (_N_Parse_cp_11781._N_do_parse_options_11702)
		{
			switch (s[0])
			{
			case '-':
			case '@':
				result = 1;
				break;
			case '/':
				result = (_N_Parse_cp_11781._N_options_11706.Contains(_N_option_name_11744(s)) ? 1 : 0);
				break;
			default:
				result = 0;
				break;
			}
		}
		else
		{
			result = 0;
		}
		return (byte)result != 0;
	}

	private static bool _N_need_following_arg_11798(_N_closureOf_Parse_11697 _N_Parse_cp_11797, string s)
	{
		int result;
		if (_N_is_option_11782(_N_Parse_cp_11797, s))
		{
			option<CliOption> option = _N_Parse_cp_11797._N_options_11706.Get(_N_option_name_11744(s));
			result = ((option is option<CliOption>.Some && (((option<CliOption>.Some)option).val is CliOption.String || ((option<CliOption>.Some)option).val is CliOption.Int || ((option<CliOption>.Some)option).val is CliOption.SubstitutionString) && s.IndexOf(':') == -1 && s.IndexOf('@') == -1) ? 1 : 0);
		}
		else
		{
			result = 0;
		}
		return (byte)result != 0;
	}

	private static void _N_parse_opt_11818(_N_closureOf_Parse_11697 _N_Parse_cp_11817, string name, option<string> arg)
	{
		option<CliOption> option = _N_Parse_cp_11817._N_options_11706.Get(name);
		CliOption val;
		FunctionVoid<bool> functionVoid;
		if (option is option<CliOption>.Some)
		{
			val = ((option<CliOption>.Some)option).val;
			_N_Parse_cp_11817._N_defined_11704[val] = true;
			Nemerle.Builtins.Tuple<CliOption, option<string>> tuple = new Nemerle.Builtins.Tuple<CliOption, option<string>>(val, arg);
			if (tuple.Field0 is CliOption.Flag)
			{
				if (tuple.Field1 == option<string>.None._N_constant_object)
				{
					FunctionVoid handler = ((CliOption.Flag)tuple.Field0).handler;
					handler.apply_void();
					return;
				}
				if (tuple.Field1 is option<string>.Some)
				{
					_N_Parse_cp_11817._N_error_fn_11714.apply_void(string.Concat("option " + val.name, " cannot accept an argument"));
					return;
				}
			}
			else
			{
				if (tuple.Field0 is CliOption.Boolean)
				{
					if (tuple.Field1 == option<string>.None._N_constant_object)
					{
						functionVoid = ((CliOption.Boolean)tuple.Field0).handler;
						goto IL_00f0;
					}
					if (tuple.Field1 is option<string>.Some)
					{
						functionVoid = ((CliOption.Boolean)tuple.Field0).handler;
						if (((option<string>.Some)tuple.Field1).val == "+")
						{
							goto IL_00f0;
						}
						if (((option<string>.Some)tuple.Field1).val == "-")
						{
							FunctionVoid<bool> functionVoid2 = ((CliOption.Boolean)tuple.Field0).handler;
							functionVoid2.apply_void(_N_wildcard_2422: false);
							return;
						}
					}
					_N_Parse_cp_11817._N_error_fn_11714.apply_void(string.Concat("option " + val.name, " requires `+' or `-'"));
					return;
				}
				if (tuple.Field0 is CliOption.String)
				{
					if (tuple.Field1 is option<string>.Some)
					{
						FunctionVoid<string> functionVoid3 = ((CliOption.String)tuple.Field0).handler;
						string val2 = ((option<string>.Some)tuple.Field1).val;
						functionVoid3.apply_void(val2);
						return;
					}
					if (tuple.Field1 == option<string>.None._N_constant_object)
					{
						goto IL_0397;
					}
				}
				else if (tuple.Field0 is CliOption.Int)
				{
					if (tuple.Field1 is option<string>.Some)
					{
						FunctionVoid<int> functionVoid4 = ((CliOption.Int)tuple.Field0).handler;
						string val3 = ((option<string>.Some)tuple.Field1).val;
						option<int> option2;
						try
						{
							option2 = new option<int>.Some(int.Parse(val3));
						}
						catch (Exception)
						{
							_N_Parse_cp_11817._N_error_fn_11714.apply_void(string.Concat("option " + val.name, " requires an integer argument"));
							option2 = option<int>.None._N_constant_object;
						}
						option<int> option3 = option2;
						if (option3 is option<int>.Some)
						{
							int val4 = ((option<int>.Some)option3).val;
							functionVoid4.apply_void(val4);
						}
						else if (option3 != option<int>.None._N_constant_object)
						{
							throw new MatchFailureException();
						}
						return;
					}
					if (tuple.Field1 == option<string>.None._N_constant_object)
					{
						goto IL_0397;
					}
				}
				else if (tuple.Field0 is CliOption.SubstitutionString)
				{
					if (tuple.Field1 is option<string>.Some)
					{
						Function<string, list<string>> function = ((CliOption.SubstitutionString)tuple.Field0).substitute;
						string val5 = ((option<string>.Some)tuple.Field1).val;
						_N_parse_opts_11824(_N_Parse_cp_11817, function.apply(val5));
						return;
					}
					if (tuple.Field1 == option<string>.None._N_constant_object)
					{
						goto IL_0397;
					}
				}
			}
			throw new AssertionException("lib\\getopt.n", 257, "", "");
		}
		if (name == "--")
		{
			_N_Parse_cp_11817._N_do_parse_options_11702 = false;
		}
		else
		{
			_N_Parse_cp_11817._N_unhandled_11710.apply_void(name);
		}
		return;
		IL_0397:
		_N_Parse_cp_11817._N_error_fn_11714.apply_void(string.Concat("option " + val.name, " requires an argument"));
		return;
		IL_00f0:
		functionVoid.apply_void(_N_wildcard_2422: true);
	}

	private static void _N_parse_opts_11824(_N_closureOf_Parse_11697 _N_Parse_cp_11823, list<string> args)
	{
		int num = 0;
		list<string> args2;
		string hd;
		if (args is list<string>.Cons)
		{
			if (((list<string>.Cons)args).tl is list<string>.Cons)
			{
				hd = ((list<string>.Cons)args).hd;
				string hd2 = ((list<string>.Cons)((list<string>.Cons)args).tl).hd;
				args2 = ((list<string>.Cons)((list<string>.Cons)args).tl).tl;
				if (_N_need_following_arg_11798(_N_Parse_cp_11823, hd))
				{
					_N_parse_opt_11818(_N_Parse_cp_11823, _N_option_name_11744(hd), new option<string>.Some(hd2));
					_N_parse_opts_11824(_N_Parse_cp_11823, args2);
					goto IL_016e;
				}
				hd = ((list<string>.Cons)args).hd;
				args2 = ((list<string>.Cons)args).tl;
				if (_N_is_option_11782(_N_Parse_cp_11823, hd))
				{
					goto IL_00b2;
				}
			}
			else
			{
				hd = ((list<string>.Cons)args).hd;
				args2 = ((list<string>.Cons)args).tl;
				if (_N_is_option_11782(_N_Parse_cp_11823, hd))
				{
					goto IL_00b2;
				}
			}
			hd = ((list<string>.Cons)args).hd;
			args2 = ((list<string>.Cons)args).tl;
			_N_Parse_cp_11823._N_non_option_11708.apply_void(hd);
			_N_parse_opts_11824(_N_Parse_cp_11823, args2);
		}
		else if ((object)args != list<string>.Nil._N_constant_object)
		{
			throw new MatchFailureException();
		}
		goto IL_016e;
		IL_016e:
		Nemerle.Builtins.Tuple<CliOption, bool>[] keyValuePairs = _N_Parse_cp_11823._N_defined_11704.KeyValuePairs;
		for (num = 0; num < keyValuePairs.Length; num = checked(num + 1))
		{
			Nemerle.Builtins.Tuple<CliOption, bool> tuple = keyValuePairs[num];
			CliOption field = tuple.Field0;
			if (!tuple.Field1 && field.required)
			{
				_N_Parse_cp_11823._N_error_fn_11714.apply_void(string.Concat(string.Concat("missing required command line argument: " + field.name, "\n"), Usage(_N_Parse_cp_11823._N_desc_11712)));
			}
		}
		return;
		IL_00b2:
		hd = ((!hd.StartsWith("--")) ? hd : hd.Substring(1));
		_N_parse_opt_11818(_N_Parse_cp_11823, _N_option_name_11744(hd), _N_argument_name_11764(hd));
		_N_parse_opts_11824(_N_Parse_cp_11823, args2);
		goto IL_016e;
	}
}
