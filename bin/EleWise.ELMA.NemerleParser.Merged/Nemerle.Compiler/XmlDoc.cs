using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;
using Nemerle.Internal;
using Nemerle.Utility;

namespace Nemerle.Compiler;

public class XmlDoc : ISupportRelocation
{
	[Variant("Nemerle.Compiler.XmlDoc.XToken.EmptyLine,Nemerle.Compiler.XmlDoc.XToken.EOF,Nemerle.Compiler.XmlDoc.XToken.Text,Nemerle.Compiler.XmlDoc.XToken.XmlStart,Nemerle.Compiler.XmlDoc.XToken.XmlEnd,Nemerle.Compiler.XmlDoc.XToken.WhiteSpace")]
	private abstract class XToken : ISupportRelocation
	{
		[ConstantVariantOption]
		public class EmptyLine : XToken
		{
			public static readonly EmptyLine _N_constant_object;

			[SpecialName]
			public static EmptyLine _N_constant_object_generator()
			{
				return _N_constant_object;
			}

			static EmptyLine()
			{
				_N_constant_object = new EmptyLine();
			}

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 0;
			}

			[RecordCtor]
			private EmptyLine()
			{
			}
		}

		[ConstantVariantOption]
		public class EOF : XToken
		{
			public static readonly EOF _N_constant_object;

			[SpecialName]
			public static EOF _N_constant_object_generator()
			{
				return _N_constant_object;
			}

			static EOF()
			{
				_N_constant_object = new EOF();
			}

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 1;
			}

			[RecordCtor]
			private EOF()
			{
			}
		}

		[VariantOption]
		public class Text : XToken
		{
			public readonly string t;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 2;
			}

			[RecordCtor]
			public Text([MappedMember("t")] string t)
			{
				this.t = t;
			}
		}

		[VariantOption]
		public class XmlStart : XToken
		{
			public readonly string n;

			public readonly string v;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 3;
			}

			[RecordCtor]
			public XmlStart([MappedMember("n")] string n, [MappedMember("v")] string v)
			{
				this.n = n;
				this.v = v;
			}
		}

		[VariantOption]
		public class XmlEnd : XToken
		{
			public readonly string n;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 4;
			}

			[RecordCtor]
			public XmlEnd([MappedMember("n")] string n)
			{
				this.n = n;
			}
		}

		[VariantOption]
		public class WhiteSpace : XToken
		{
			public readonly string w;

			[SpecialName]
			public override int _N_GetVariantCode()
			{
				return 5;
			}

			[RecordCtor]
			public WhiteSpace([MappedMember("w")] string w)
			{
				this.w = w;
			}
		}

		public override string ToString()
		{
			object result;
			if (this == EmptyLine._N_constant_object)
			{
				result = "[EmptyLine]";
			}
			else if (this == EOF._N_constant_object)
			{
				result = "[EOF]";
			}
			else if (this is Text)
			{
				string t = ((Text)this).t;
				result = string.Concat("\"" + t, "\"");
			}
			else if (this is XmlStart)
			{
				string t = ((XmlStart)this).n;
				string v = ((XmlStart)this).v;
				result = string.Concat(string.Concat(string.Concat("<" + t, " "), v), ">");
			}
			else if (this is XmlEnd)
			{
				string t = ((XmlEnd)this).n;
				result = string.Concat("</" + t, ">");
			}
			else
			{
				if (!(this is WhiteSpace))
				{
					throw new MatchFailureException();
				}
				string t = ((WhiteSpace)this).w;
				result = string.Concat("[" + t, "]");
			}
			return (string)result;
		}

		[SpecialName]
		public abstract override int _N_GetVariantCode();

		[SpecialName]
		public static int _N_GetVariantCodeSafe(XToken x)
		{
			return ((object)x != null) ? x._N_GetVariantCode() : (-1);
		}

		[SpecialName]
		public static int _N_GetVariantCodeObject(object x)
		{
			return (!(x is XToken)) ? (-1) : ((XToken)x)._N_GetVariantCode();
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
		}

		void ISupportRelocation.RelocateImpl(RelocationInfo _info)
		{
			//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
			this.RelocateImplInternal(_info);
		}
	}

	private sealed class _N_closureOf_tokenize_88307
	{
		internal string _N_buf_88314;

		internal int _N_i_88312;

		internal _N_closureOf_tokenize_88307()
		{
		}
	}

	private sealed class _N_closureOf_loop_88340
	{
		internal int _N_start_88345;

		internal _N_closureOf_loop_88340()
		{
		}
	}

	private sealed class _N_space_tab__88350 : Function<char, bool>
	{
		[SpecialName]
		public static readonly _N_space_tab__88350 Instance = new _N_space_tab__88350();

		[SpecialName]
		public sealed override bool apply(char ch)
		{
			return ch == ' ' || ch == '\t';
		}
	}

	private sealed class _N__N_lambda__88279__88390 : Function<char, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__88279__88390 Instance = new _N__N_lambda__88279__88390();

		[SpecialName]
		public sealed override bool apply(char _N__88278)
		{
			return _N__88278 == '\n';
		}
	}

	private sealed class _N__N_lambda__88289__88433 : Function<char, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__88289__88433 Instance = new _N__N_lambda__88289__88433();

		[SpecialName]
		public sealed override bool apply(char _N__88288)
		{
			return _N__88288 != '>';
		}
	}

	private sealed class _N__N_lambda__88301__88458 : Function<char, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__88301__88458 Instance = new _N__N_lambda__88301__88458();

		[SpecialName]
		public sealed override bool apply(char c)
		{
			return c != '<' && c != '\n' && c != ']';
		}
	}

	private sealed class _N_closureOf_parse_comment_88661
	{
		internal Function<string, bool> _N_is_top_tag_88672;

		internal ListEnumerator<XToken> _N_tokens_88670;

		internal list<Nemerle.Builtins.Tuple<string, bool>> _N_tags_88668;

		internal StringBuilder _N_sb_88666;

		internal _N_closureOf_parse_comment_88661()
		{
		}
	}

	private sealed class _N_is_top_tag__88674 : Function<string, bool>
	{
		[SpecialName]
		public static readonly _N_is_top_tag__88674 Instance = new _N_is_top_tag__88674();

		[SpecialName]
		public sealed override bool apply(string _N_wildcard_3401)
		{
			int result;
			switch (_N_wildcard_3401)
			{
			case "summary":
			case "remarks":
			case "example":
			case "exception":
			case "param":
			case "permission":
			case "returns":
			case "seealso":
			case "include":
			case "value":
				result = 1;
				break;
			default:
				result = 0;
				break;
			}
			return (byte)result != 0;
		}
	}

	private sealed class _N__N_lambda__88536__88762 : Function<string, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__88536__88762 Instance = new _N__N_lambda__88536__88762();

		[SpecialName]
		public sealed override bool apply(string _N__88535)
		{
			return _N__88535 == "para";
		}
	}

	private sealed class _N__N_lambda__88543__88772 : Function<string, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__88543__88772 Instance = new _N__N_lambda__88543__88772();

		[SpecialName]
		public sealed override bool apply(string _N__88542)
		{
			return _N__88542 == "summary";
		}
	}

	private sealed class _N__N_lambda__88549__88785 : Function<string, bool, bool>
	{
		[SpecialName]
		private _N_closureOf_parse_comment_88661 _N_parse_comment_closure_88789;

		public _N__N_lambda__88549__88785(_N_closureOf_parse_comment_88661 _N_parse_comment_closure_88789)
		{
			this._N_parse_comment_closure_88789 = _N_parse_comment_closure_88789;
		}

		[SpecialName]
		public sealed override bool apply(string n, bool _N_wildcard_88548)
		{
			return _N_parse_comment_closure_88789._N_is_top_tag_88672.apply(n);
		}
	}

	private sealed class _N__N_lambda__88556__88797 : Function<string, bool, bool>
	{
		[SpecialName]
		private _N_closureOf_parse_comment_88661 _N_parse_comment_closure_88801;

		public _N__N_lambda__88556__88797(_N_closureOf_parse_comment_88661 _N_parse_comment_closure_88801)
		{
			this._N_parse_comment_closure_88801 = _N_parse_comment_closure_88801;
		}

		[SpecialName]
		public sealed override bool apply(string n, bool _N_wildcard_88555)
		{
			return _N_is_text_holding_88687(n);
		}
	}

	private sealed class _N__N_lambda__88565__88812 : Function<string, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__88565__88812 Instance = new _N__N_lambda__88565__88812();

		[SpecialName]
		public sealed override bool apply(string _N__88564)
		{
			return _N__88564 == "para";
		}
	}

	private sealed class _N__N_lambda__88571__88831 : Function<string, bool, bool>
	{
		[SpecialName]
		private _N_closureOf_parse_comment_88661 _N_parse_comment_closure_88835;

		public _N__N_lambda__88571__88831(_N_closureOf_parse_comment_88661 _N_parse_comment_closure_88835)
		{
			this._N_parse_comment_closure_88835 = _N_parse_comment_closure_88835;
		}

		[SpecialName]
		public sealed override bool apply(string n, bool _N_wildcard_88570)
		{
			return _N_parse_comment_closure_88835._N_is_top_tag_88672.apply(n);
		}
	}

	private sealed class _N__N_lambda__88578__88849 : Function<string, bool, bool>
	{
		[SpecialName]
		private _N_closureOf_parse_comment_88661 _N_parse_comment_closure_88853;

		public _N__N_lambda__88578__88849(_N_closureOf_parse_comment_88661 _N_parse_comment_closure_88853)
		{
			this._N_parse_comment_closure_88853 = _N_parse_comment_closure_88853;
		}

		[SpecialName]
		public sealed override bool apply(string n, bool _N_wildcard_88577)
		{
			return _N_is_text_holding_88687(n);
		}
	}

	private sealed class _N__N_lambda__88590__88862 : Function<string, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__88590__88862 Instance = new _N__N_lambda__88590__88862();

		[SpecialName]
		public sealed override bool apply(string _N_wildcard_88589)
		{
			return true;
		}
	}

	private sealed class _N__N_lambda__88603__88882 : Function<string, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__88603__88882 Instance = new _N__N_lambda__88603__88882();

		[SpecialName]
		public sealed override bool apply(string _N_wildcard_88602)
		{
			return true;
		}
	}

	private sealed class _N_closureOf_add_comments_88949
	{
		internal Location _N_curr_88956;

		internal XmlDoc _N__N_closurised_this_ptr_88954;

		internal _N_closureOf_add_comments_88949()
		{
		}
	}

	private sealed class _N_choose__88958 : Function<Location, string, string, string>
	{
		[SpecialName]
		private _N_closureOf_add_comments_88949 _N_add_comments_closure_88962;

		public _N_choose__88958(_N_closureOf_add_comments_88949 _N_add_comments_closure_88962)
		{
			this._N_add_comments_closure_88962 = _N_add_comments_closure_88962;
		}

		[SpecialName]
		public sealed override string apply(Location loc, string com, string acc)
		{
			return (!(loc.File == _N_add_comments_closure_88962._N_curr_88956.File) || loc.CompareTo(_N_add_comments_closure_88962._N_curr_88956) > 0 || (_N_add_comments_closure_88962._N_curr_88956.CompareTo(_N_add_comments_closure_88962._N__N_closurised_this_ptr_88954.last_loc) >= 0 && loc.CompareTo(_N_add_comments_closure_88962._N__N_closurised_this_ptr_88954.last_loc) <= 0)) ? acc : com;
		}
	}

	private sealed class _N_closureOf_DumpType_89005
	{
		internal XmlDoc _N__N_obj_cache_89010;

		internal _N_closureOf_DumpType_89005()
		{
		}
	}

	private sealed class _N__N_method_lambda__89013 : FunctionVoid<IMember>
	{
		[SpecialName]
		private _N_closureOf_DumpType_89005 _N_DumpType_closure_89017;

		public _N__N_method_lambda__89013(_N_closureOf_DumpType_89005 _N_DumpType_closure_89017)
		{
			this._N_DumpType_closure_89017 = _N_DumpType_closure_89017;
		}

		[SpecialName]
		public sealed override void apply_void(IMember _N__89012)
		{
			_N_DumpType_closure_89017._N__N_obj_cache_89010.DumpMember(_N__89012);
		}
	}

	private sealed class _N_closureOf_AppendParmTypeName_89093
	{
		internal IMethod _N_m_89098;

		internal _N_closureOf_AppendParmTypeName_89093()
		{
		}
	}

	private sealed class _N_closureOf_appendTypeNameAndArgs_89107
	{
		internal list<TypeVar> _N_args_89112;

		internal _N_closureOf_appendTypeNameAndArgs_89107()
		{
		}
	}

	private sealed class _N__N_lambda__89052__89114 : Function<StringBuilder, StringBuilder>
	{
		[SpecialName]
		private _N_closureOf_AppendParmTypeName_89093 _N_AppendParmTypeName_closure_89120;

		[SpecialName]
		private _N_closureOf_appendTypeNameAndArgs_89107 _N_appendTypeNameAndArgs_closure_89118;

		public _N__N_lambda__89052__89114(_N_closureOf_appendTypeNameAndArgs_89107 _N_appendTypeNameAndArgs_closure_89118, _N_closureOf_AppendParmTypeName_89093 _N_AppendParmTypeName_closure_89120)
		{
			this._N_appendTypeNameAndArgs_closure_89118 = _N_appendTypeNameAndArgs_closure_89118;
			this._N_AppendParmTypeName_closure_89120 = _N_AppendParmTypeName_closure_89120;
		}

		[SpecialName]
		public sealed override StringBuilder apply(StringBuilder sb)
		{
			StringBuilder builder = sb.Append("{");
			list<TypeVar> n_args_ = _N_appendTypeNameAndArgs_closure_89118._N_args_89112;
			Function<StringBuilder, TypeVar, StringBuilder> append = new _N__N_lambda__89057__89125(_N_AppendParmTypeName_closure_89120);
			return builder.AppendList(n_args_, append, ",").Append("}");
		}
	}

	private sealed class _N__N_lambda__89057__89125 : Function<StringBuilder, TypeVar, StringBuilder>
	{
		[SpecialName]
		private _N_closureOf_AppendParmTypeName_89093 _N_AppendParmTypeName_closure_89129;

		public _N__N_lambda__89057__89125(_N_closureOf_AppendParmTypeName_89093 _N_AppendParmTypeName_closure_89129)
		{
			this._N_AppendParmTypeName_closure_89129 = _N_AppendParmTypeName_closure_89129;
		}

		[SpecialName]
		public sealed override StringBuilder apply(StringBuilder sb, TypeVar e)
		{
			return AppendParmTypeName(sb, e, _N_AppendParmTypeName_closure_89129._N_m_89098);
		}
	}

	private sealed class _N_closureOf_appendArrayType_89183
	{
		internal int _N_rank_89188;

		internal _N_closureOf_appendArrayType_89183()
		{
		}
	}

	private sealed class _N__N_lambda__89077__89190 : Function<StringBuilder, StringBuilder>
	{
		[SpecialName]
		private _N_closureOf_appendArrayType_89183 _N_appendArrayType_closure_89194;

		public _N__N_lambda__89077__89190(_N_closureOf_appendArrayType_89183 _N_appendArrayType_closure_89194)
		{
			this._N_appendArrayType_closure_89194 = _N_appendArrayType_closure_89194;
		}

		[SpecialName]
		public sealed override StringBuilder apply(StringBuilder sb)
		{
			return sb.AppendNTimes(_N_appendArrayType_closure_89194._N_rank_89188, "0:", ",");
		}
	}

	private sealed class _N_closureOf_GetKey_89239
	{
		internal IMethod _N_method_89248;

		internal list<TParameter> _N_parms_89246;

		internal int _N_tyParmsCount_89244;

		internal _N_closureOf_GetKey_89239()
		{
		}
	}

	private sealed class _N__N_lambda__89231__89271 : Function<StringBuilder, StringBuilder>
	{
		[SpecialName]
		private _N_closureOf_GetKey_89239 _N_GetKey_closure_89275;

		public _N__N_lambda__89231__89271(_N_closureOf_GetKey_89239 _N_GetKey_closure_89275)
		{
			this._N_GetKey_closure_89275 = _N_GetKey_closure_89275;
		}

		[SpecialName]
		public sealed override StringBuilder apply(StringBuilder sb)
		{
			return sb.Append("``").Append(_N_GetKey_closure_89275._N_tyParmsCount_89244);
		}
	}

	private sealed class _N__N_lambda__89220__89280 : Function<StringBuilder, StringBuilder>
	{
		[SpecialName]
		private _N_closureOf_GetKey_89239 _N_GetKey_closure_89284;

		public _N__N_lambda__89220__89280(_N_closureOf_GetKey_89239 _N_GetKey_closure_89284)
		{
			this._N_GetKey_closure_89284 = _N_GetKey_closure_89284;
		}

		[SpecialName]
		public sealed override StringBuilder apply(StringBuilder sb)
		{
			StringBuilder builder = sb.Append("(");
			list<TParameter> n_parms_ = _N_GetKey_closure_89284._N_parms_89246;
			Function<StringBuilder, TParameter, StringBuilder> append = new _N__N_lambda__89225__89289(_N_GetKey_closure_89284);
			return builder.AppendList(n_parms_, append, ",").Append(")");
		}
	}

	private sealed class _N__N_lambda__89225__89289 : Function<StringBuilder, TParameter, StringBuilder>
	{
		[SpecialName]
		private _N_closureOf_GetKey_89239 _N_GetKey_closure_89293;

		public _N__N_lambda__89225__89289(_N_closureOf_GetKey_89239 _N_GetKey_closure_89293)
		{
			this._N_GetKey_closure_89293 = _N_GetKey_closure_89293;
		}

		[SpecialName]
		public sealed override StringBuilder apply(StringBuilder sb, TParameter p)
		{
			return AppendParmTypeName(sb, p.ty, _N_GetKey_closure_89293._N_method_89248);
		}
	}

	private sealed class _N__N_lambda__89215__89301 : Function<StringBuilder, StringBuilder>
	{
		[SpecialName]
		private _N_closureOf_GetKey_89239 _N_GetKey_closure_89305;

		public _N__N_lambda__89215__89301(_N_closureOf_GetKey_89239 _N_GetKey_closure_89305)
		{
			this._N_GetKey_closure_89305 = _N_GetKey_closure_89305;
		}

		[SpecialName]
		public sealed override StringBuilder apply(StringBuilder sb)
		{
			return AppendParmTypeName(sb.Append("~"), _N_GetKey_closure_89305._N_method_89248.ReturnType, _N_GetKey_closure_89305._N_method_89248);
		}
	}

	private readonly XmlDocument document;

	private readonly XmlNode docNode;

	private Location last_loc;

	private readonly string OutputFileName;

	private readonly Map<Location, string> Comments;

	internal XmlDoc(Map<Location, string> comments, string output)
	{
		Comments = comments;
		OutputFileName = output;
		document = new XmlDocument();
		XmlNode xmlNode = document.AppendChild(document.CreateXmlDeclaration("1.0", null, null));
		xmlNode = document.AppendChild(document.CreateElement("doc"));
		XmlNode xmlNode2 = xmlNode.AppendChild(document.CreateElement("assembly")).AppendChild(document.CreateElement("name"));
		xmlNode2 = xmlNode2.AppendChild(document.CreateTextNode(OutputFileName));
		docNode = xmlNode.AppendChild(xmlNode.AppendChild(document.CreateElement("members")));
	}

	internal void Save()
	{
		document.Save(OutputFileName);
	}

	private XmlNode CreateMember(string name)
	{
		XmlElement xmlElement = document.CreateElement("member");
		XmlAttribute xmlAttribute = document.CreateAttribute("name");
		xmlAttribute.Value = name;
		xmlAttribute = xmlElement.SetAttributeNode(xmlAttribute);
		return xmlElement;
	}

	private void DumpMember(IMember m)
	{
		XmlNode x = docNode.AppendChild(CreateMember(GetKey(m)));
		add_comments(x, m);
	}

	private static XToken[] tokenize(string comment)
	{
		int num = 0;
		bool flag = false;
		_N_closureOf_tokenize_88307 n_closureOf_tokenize_ = new _N_closureOf_tokenize_88307();
		string[] array = comment.Split('\n');
		flag = true;
		char[] trimChars = new char[4] { ' ', '\t', '\r', '\n' };
		List<XToken> list = new List<XToken>();
		checked
		{
			for (num = 0; num < array.Length; num++)
			{
				array[num] = array[num].TrimEnd(trimChars);
				if (num > 0 && array[num].Trim(trimChars) != "" && !array[num].TrimStart(trimChars).StartsWith("*"))
				{
					flag = false;
				}
			}
			if (flag)
			{
				for (num = 1; num < array.Length; num++)
				{
					if (array[num].Trim(trimChars) != "")
					{
						array[num] = array[num].TrimStart(trimChars).Substring(1);
					}
				}
			}
			n_closureOf_tokenize_._N_buf_88314 = string.Join("\n", array) + "\n";
			n_closureOf_tokenize_._N_i_88312 = 0;
			flag = false;
			while (true)
			{
				_N_closureOf_loop_88340 n_closureOf_loop_ = new _N_closureOf_loop_88340();
				if (n_closureOf_tokenize_._N_i_88312 >= n_closureOf_tokenize_._N_buf_88314.Length)
				{
					break;
				}
				n_closureOf_loop_._N_start_88345 = n_closureOf_tokenize_._N_i_88312;
				Function<char, bool> instance = _N_space_tab__88350.Instance;
				if (instance.apply(n_closureOf_tokenize_._N_buf_88314[n_closureOf_tokenize_._N_i_88312]))
				{
					list.Add(new XToken.WhiteSpace(_N_scan_88365(n_closureOf_loop_, n_closureOf_tokenize_, instance)));
				}
				else if (n_closureOf_tokenize_._N_buf_88314[n_closureOf_tokenize_._N_i_88312] == '\n')
				{
					instance = _N__N_lambda__88279__88390.Instance;
					string text = _N_scan_88365(n_closureOf_loop_, n_closureOf_tokenize_, instance);
					if (text == "\n")
					{
						list.Add(new XToken.WhiteSpace("\n"));
					}
					else
					{
						list.Add(new XToken.WhiteSpace(text));
						list.Add(XToken.EmptyLine._N_constant_object);
					}
					flag = false;
				}
				else if (n_closureOf_tokenize_._N_i_88312 + 1 < n_closureOf_tokenize_._N_buf_88314.Length && n_closureOf_tokenize_._N_buf_88314[n_closureOf_tokenize_._N_i_88312] == '<' && n_closureOf_tokenize_._N_buf_88314[n_closureOf_tokenize_._N_i_88312 + 1] == '[')
				{
					n_closureOf_tokenize_._N_i_88312 += 2;
					if (flag)
					{
						list.Add(new XToken.XmlStart("c", ""));
						continue;
					}
					string text = _N_scan_88365(n_closureOf_loop_, n_closureOf_tokenize_, instance).Substring(2);
					string n = ((n_closureOf_tokenize_._N_i_88312 < n_closureOf_tokenize_._N_buf_88314.Length && n_closureOf_tokenize_._N_buf_88314[n_closureOf_tokenize_._N_i_88312] != '\n') ? "c" : "code");
					list.Add(new XToken.XmlStart(n, ""));
					list.Add(new XToken.WhiteSpace(text));
					flag = true;
				}
				else if (n_closureOf_tokenize_._N_i_88312 + 1 < n_closureOf_tokenize_._N_buf_88314.Length && n_closureOf_tokenize_._N_buf_88314[n_closureOf_tokenize_._N_i_88312] == ']' && n_closureOf_tokenize_._N_buf_88314[n_closureOf_tokenize_._N_i_88312 + 1] == '>')
				{
					n_closureOf_tokenize_._N_i_88312 += 2;
					list.Add(new XToken.XmlEnd(""));
				}
				else if (n_closureOf_tokenize_._N_buf_88314[n_closureOf_tokenize_._N_i_88312] == ']')
				{
					n_closureOf_tokenize_._N_i_88312++;
					flag = true;
					list.Add(new XToken.Text("]"));
				}
				else if (n_closureOf_tokenize_._N_buf_88314[n_closureOf_tokenize_._N_i_88312] == '<')
				{
					flag = true;
					instance = _N__N_lambda__88289__88433.Instance;
					string text = _N_scan_88365(n_closureOf_loop_, n_closureOf_tokenize_, instance);
					if (n_closureOf_tokenize_._N_i_88312 == n_closureOf_tokenize_._N_buf_88314.Length)
					{
						Message.Warning("unfinished XML tag");
					}
					else
					{
						n_closureOf_tokenize_._N_i_88312++;
					}
					text = text.Substring(1).Trim(trimChars);
					if (text.StartsWith("/"))
					{
						list.Add(new XToken.XmlEnd(text.Substring(1)));
						continue;
					}
					num = text.IndexOfAny(new char[2] { ' ', '\t' });
					if (num == -1)
					{
						if (text.EndsWith("/"))
						{
							text = text.Substring(0, text.Length - 1);
							list.Add(new XToken.XmlStart(text, ""));
							list.Add(new XToken.XmlEnd(text));
						}
						else
						{
							list.Add(new XToken.XmlStart(text, ""));
						}
						continue;
					}
					string n = text.Substring(0, num);
					text = text.Substring(num);
					if (text.EndsWith("/"))
					{
						text = text.Substring(0, text.Length - 1);
						list.Add(new XToken.XmlStart(n, text));
						list.Add(new XToken.XmlEnd(n));
					}
					else
					{
						list.Add(new XToken.XmlStart(n, text));
					}
				}
				else
				{
					flag = true;
					instance = _N__N_lambda__88301__88458.Instance;
					list.Add(new XToken.Text(_N_scan_88365(n_closureOf_loop_, n_closureOf_tokenize_, instance)));
				}
			}
			list.Add(XToken.EOF._N_constant_object);
			return list.ToArray();
		}
	}

	private XmlNode parse_comment(string comment)
	{
		_N_closureOf_parse_comment_88661 n_closureOf_parse_comment_ = new _N_closureOf_parse_comment_88661();
		n_closureOf_parse_comment_._N_is_top_tag_88672 = _N_is_top_tag__88674.Instance;
		n_closureOf_parse_comment_._N_tokens_88670 = tokenize(comment).NToList().GetEnumerator();
		n_closureOf_parse_comment_._N_tags_88668 = list<Nemerle.Builtins.Tuple<string, bool>>.Nil._N_constant_object;
		n_closureOf_parse_comment_._N_sb_88666 = new StringBuilder("");
		bool flag = n_closureOf_parse_comment_._N_tokens_88670.MoveNext();
		_N_skip_ws_88696(n_closureOf_parse_comment_);
		XToken current = n_closureOf_parse_comment_._N_tokens_88670.Current;
		if (current is XToken.XmlStart)
		{
			string n = ((XToken.XmlStart)current).n;
			if (n_closureOf_parse_comment_._N_is_top_tag_88672.apply(n))
			{
				_N_output_88708(n_closureOf_parse_comment_, n_closureOf_parse_comment_._N_tokens_88670.Current);
				flag = n_closureOf_parse_comment_._N_tokens_88670.MoveNext();
				_N_skip_ws_88696(n_closureOf_parse_comment_);
				n_closureOf_parse_comment_._N_tags_88668 = new list<Nemerle.Builtins.Tuple<string, bool>>.Cons(new Nemerle.Builtins.Tuple<string, bool>(n, field1: true), n_closureOf_parse_comment_._N_tags_88668);
				goto IL_00df;
			}
		}
		_N_open_fake_88732(n_closureOf_parse_comment_, "summary");
		goto IL_00df;
		IL_00df:
		list<Nemerle.Builtins.Tuple<string, bool>> tl;
		while (true)
		{
			current = n_closureOf_parse_comment_._N_tokens_88670.Current;
			if (current is XToken.EOF)
			{
				break;
			}
			current = n_closureOf_parse_comment_._N_tokens_88670.Current;
			if (current == XToken.EmptyLine._N_constant_object)
			{
				Function<string, bool> instance = _N__N_lambda__88536__88762.Instance;
				_N_possibly_close_88722(n_closureOf_parse_comment_, instance);
				instance = _N__N_lambda__88543__88772.Instance;
				_N_possibly_close_88722(n_closureOf_parse_comment_, instance);
			}
			else if (current != XToken.EOF._N_constant_object)
			{
				if (current is XToken.Text)
				{
					list<Nemerle.Builtins.Tuple<string, bool>> n_tags_ = n_closureOf_parse_comment_._N_tags_88668;
					Function<string, bool, bool> f = new _N__N_lambda__88549__88785(n_closureOf_parse_comment_);
					if (!n_tags_.Exists(f))
					{
						_N_open_fake_88732(n_closureOf_parse_comment_, "remarks");
					}
					list<Nemerle.Builtins.Tuple<string, bool>> n_tags_2 = n_closureOf_parse_comment_._N_tags_88668;
					f = new _N__N_lambda__88556__88797(n_closureOf_parse_comment_);
					if (!n_tags_2.Exists(f))
					{
						_N_open_fake_88732(n_closureOf_parse_comment_, "para");
					}
					_N_output_88708(n_closureOf_parse_comment_, current);
				}
				else if (current is XToken.XmlStart)
				{
					string n = ((XToken.XmlStart)current).n;
					if (_N_is_text_holding_88687(n) || n_closureOf_parse_comment_._N_is_top_tag_88672.apply(n))
					{
						Function<string, bool> instance = _N__N_lambda__88565__88812.Instance;
						_N_possibly_close_88722(n_closureOf_parse_comment_, instance);
					}
					if (n_closureOf_parse_comment_._N_is_top_tag_88672.apply(n))
					{
						_N_possibly_close_88722(n_closureOf_parse_comment_, n_closureOf_parse_comment_._N_is_top_tag_88672);
					}
					if (!n_closureOf_parse_comment_._N_is_top_tag_88672.apply(n))
					{
						list<Nemerle.Builtins.Tuple<string, bool>> n_tags_3 = n_closureOf_parse_comment_._N_tags_88668;
						Function<string, bool, bool> f = new _N__N_lambda__88571__88831(n_closureOf_parse_comment_);
						if (!n_tags_3.Exists(f))
						{
							_N_open_fake_88732(n_closureOf_parse_comment_, "remarks");
						}
					}
					if (!_N_is_text_holding_88687(n) && !n_closureOf_parse_comment_._N_is_top_tag_88672.apply(n))
					{
						list<Nemerle.Builtins.Tuple<string, bool>> n_tags_4 = n_closureOf_parse_comment_._N_tags_88668;
						Function<string, bool, bool> f = new _N__N_lambda__88578__88849(n_closureOf_parse_comment_);
						if (!n_tags_4.Exists(f))
						{
							_N_open_fake_88732(n_closureOf_parse_comment_, "para");
						}
					}
					n_closureOf_parse_comment_._N_tags_88668 = new list<Nemerle.Builtins.Tuple<string, bool>>.Cons(new Nemerle.Builtins.Tuple<string, bool>(n, field1: true), n_closureOf_parse_comment_._N_tags_88668);
					_N_output_88708(n_closureOf_parse_comment_, current);
				}
				else if (current is XToken.XmlEnd)
				{
					string n = ((XToken.XmlEnd)current).n;
					while (n_closureOf_parse_comment_._N_tags_88668 is list<Nemerle.Builtins.Tuple<string, bool>>.Cons && !((list<Nemerle.Builtins.Tuple<string, bool>>.Cons)n_closureOf_parse_comment_._N_tags_88668).hd.Field1)
					{
						Function<string, bool> instance = _N__N_lambda__88590__88862.Instance;
						_N_possibly_close_88722(n_closureOf_parse_comment_, instance);
					}
					if (n_closureOf_parse_comment_._N_tags_88668 is list<Nemerle.Builtins.Tuple<string, bool>>.Cons && ((list<Nemerle.Builtins.Tuple<string, bool>>.Cons)n_closureOf_parse_comment_._N_tags_88668).hd.Field1)
					{
						string field = ((list<Nemerle.Builtins.Tuple<string, bool>>.Cons)n_closureOf_parse_comment_._N_tags_88668).hd.Field0;
						tl = ((list<Nemerle.Builtins.Tuple<string, bool>>.Cons)n_closureOf_parse_comment_._N_tags_88668).tl;
						if (field == n || n == "")
						{
							n_closureOf_parse_comment_._N_tags_88668 = tl;
							_N_output_88708(n_closureOf_parse_comment_, new XToken.XmlEnd(field));
							goto IL_0423;
						}
					}
					Message.Warning("trying to close XML tag <" + Convert.ToString(n) + "> that is not open");
				}
				else
				{
					if (!(current is XToken.WhiteSpace))
					{
						throw new MatchFailureException();
					}
					_N_output_88708(n_closureOf_parse_comment_, current);
				}
			}
			goto IL_0423;
			IL_0423:
			flag = n_closureOf_parse_comment_._N_tokens_88670.MoveNext();
		}
		while (n_closureOf_parse_comment_._N_tags_88668 is list<Nemerle.Builtins.Tuple<string, bool>>.Cons && !((list<Nemerle.Builtins.Tuple<string, bool>>.Cons)n_closureOf_parse_comment_._N_tags_88668).hd.Field1)
		{
			Function<string, bool> instance = _N__N_lambda__88603__88882.Instance;
			_N_possibly_close_88722(n_closureOf_parse_comment_, instance);
		}
		tl = n_closureOf_parse_comment_._N_tags_88668;
		while (tl is list<Nemerle.Builtins.Tuple<string, bool>>.Cons)
		{
			Nemerle.Builtins.Tuple<string, bool> hd = ((list<Nemerle.Builtins.Tuple<string, bool>>.Cons)tl).hd;
			tl = ((list<Nemerle.Builtins.Tuple<string, bool>>.Cons)tl).tl;
			if (hd.Field1)
			{
				string n = hd.Field0;
				Message.Warning("unclosed XML tag <" + Convert.ToString(n) + ">");
			}
			tl = tl;
		}
		XmlDocumentFragment xmlDocumentFragment = document.CreateDocumentFragment();
		xmlDocumentFragment.InnerXml = n_closureOf_parse_comment_._N_sb_88666.ToString();
		return xmlDocumentFragment;
	}

	private void add_comments(XmlNode x, IMember mem)
	{
		_N_closureOf_add_comments_88949 n_closureOf_add_comments_ = new _N_closureOf_add_comments_88949();
		n_closureOf_add_comments_._N__N_closurised_this_ptr_88954 = this;
		n_closureOf_add_comments_._N_curr_88956 = mem.Location;
		Function<Location, string, string, string> fn = new _N_choose__88958(n_closureOf_add_comments_);
		Location n_curr_ = n_closureOf_add_comments_._N_curr_88956;
		bool flag = n_curr_.FileIndex != 0;
		if (flag)
		{
			LocationStack.Push(n_curr_);
		}
		try
		{
			string text = Comments.Fold(null, fn);
			if (text != null && text != "")
			{
				try
				{
					x.AppendChild(parse_comment(text));
				}
				catch (XmlException ex)
				{
					Message.Warning("Cannot parse XML in comment: " + ex.Message);
				}
			}
		}
		finally
		{
			if (flag)
			{
				LocationStack.RemoveTop();
			}
		}
		last_loc = n_closureOf_add_comments_._N_curr_88956;
	}

	internal void DumpType(TypeInfo t)
	{
		_N_closureOf_DumpType_89005 n_closureOf_DumpType_ = new _N_closureOf_DumpType_89005();
		XmlNode x = docNode.AppendChild(CreateMember(GetKey(t)));
		add_comments(x, t);
		list<IMember> members = t.GetMembers(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.DeclaredOnly);
		n_closureOf_DumpType_._N__N_obj_cache_89010 = this;
		FunctionVoid<IMember> f = new _N__N_method_lambda__89013(n_closureOf_DumpType_);
		NList.Iter(members, f);
	}

	private static StringBuilder AppendParmTypeName(StringBuilder sb, TypeVar p, IMethod m)
	{
		_N_closureOf_AppendParmTypeName_89093 n_closureOf_AppendParmTypeName_ = new _N_closureOf_AppendParmTypeName_89093();
		n_closureOf_AppendParmTypeName_._N_m_89098 = m;
		FixedType fixedType = p.Fix();
		object result;
		if (fixedType is FixedType.Class)
		{
			TypeInfo tycon = ((FixedType.Class)fixedType).tycon;
			list<TypeVar> args = ((FixedType.Class)fixedType).args;
			result = _N_appendTypeNameAndArgs_89101(n_closureOf_AppendParmTypeName_, sb, tycon.FullName, args);
		}
		else if (fixedType is FixedType.StaticTypeVarRef)
		{
			StaticTypeVar tyvar = ((FixedType.StaticTypeVarRef)fixedType).tyvar;
			int num = _N_indexOf_89148(n_closureOf_AppendParmTypeName_._N_m_89098.GetHeader().TypeParameters, tyvar);
			if (num == -1)
			{
				num = _N_indexOf_89148(n_closureOf_AppendParmTypeName_._N_m_89098.DeclaringType.Typarms, tyvar);
				if (num == -1)
				{
					Message.Warning("Unknown type parameter " + Convert.ToString(tyvar));
					result = sb.Append("???");
				}
				else
				{
					result = sb.Append("`").Append(num);
				}
			}
			else
			{
				result = sb.Append("``").Append(num);
			}
		}
		else if (fixedType is FixedType.Fun)
		{
			TypeVar from = ((FixedType.Fun)fixedType).from;
			TypeVar to = ((FixedType.Fun)fixedType).to;
			fixedType = from.Fix();
			object obj;
			list<TypeVar> args;
			if (fixedType is FixedType.Void)
			{
				obj = list<TypeVar>.Nil._N_constant_object;
			}
			else if (fixedType is FixedType.Tuple)
			{
				args = ((FixedType.Tuple)fixedType).args;
				obj = args;
			}
			else
			{
				obj = new list<TypeVar>.Cons(from, list<TypeVar>.Nil._N_constant_object);
			}
			args = (list<TypeVar>)obj;
			fixedType = to.Fix();
			result = ((!(fixedType is FixedType.Void)) ? _N_appendTypeNameAndArgs_89101(n_closureOf_AppendParmTypeName_, sb, "Nemerle.Builtins.Function", args.Append(new list<TypeVar>.Cons(to, list<TypeVar>.Nil._N_constant_object))) : _N_appendTypeNameAndArgs_89101(n_closureOf_AppendParmTypeName_, sb, "Nemerle.Builtins.FunctionVoid", args));
		}
		else if (fixedType is FixedType.Tuple)
		{
			list<TypeVar> args = ((FixedType.Tuple)fixedType).args;
			result = _N_appendTypeNameAndArgs_89101(n_closureOf_AppendParmTypeName_, sb, "Nemerle.Builtins.Tuple", args);
		}
		else if (fixedType is FixedType.Array)
		{
			TypeVar to = ((FixedType.Array)fixedType).t;
			int num = ((FixedType.Array)fixedType).rank;
			_N_closureOf_appendArrayType_89183 n_closureOf_appendArrayType_ = new _N_closureOf_appendArrayType_89183();
			n_closureOf_appendArrayType_._N_rank_89188 = num;
			StringBuilder builder = AppendParmTypeName(sb, to, n_closureOf_AppendParmTypeName_._N_m_89098).Append("[");
			bool condition = n_closureOf_appendArrayType_._N_rank_89188 > 1;
			Function<StringBuilder, StringBuilder> append = new _N__N_lambda__89077__89190(n_closureOf_appendArrayType_);
			result = builder.AppendWhen(condition, append).Append("]");
		}
		else
		{
			TypeVar to;
			if (fixedType is FixedType.Ref)
			{
				to = ((FixedType.Ref)fixedType).t;
			}
			else
			{
				if (!(fixedType is FixedType.Out))
				{
					if (fixedType is FixedType.Void)
					{
						result = sb.Append("System.Void");
						goto IL_0333;
					}
					if (fixedType is FixedType.Intersection)
					{
						if (!Message.SeenError)
						{
							string text = "Got FixedType.Intersection for doc comment".ToString();
							Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
						}
						throw new AssertionException("ncc\\hierarchy\\XmlDump.n", 460, "", "Got FixedType.Intersection for doc comment");
					}
					throw new MatchFailureException();
				}
				to = ((FixedType.Out)fixedType).t;
			}
			result = AppendParmTypeName(sb, to, n_closureOf_AppendParmTypeName_._N_m_89098).Append("@");
		}
		goto IL_0333;
		IL_0333:
		return (StringBuilder)result;
	}

	public static string GetKey(IMember m)
	{
		_N_closureOf_GetKey_89239 n_closureOf_GetKey_ = new _N_closureOf_GetKey_89239();
		StringBuilder stringBuilder = new StringBuilder();
		MemberTypes memberKind = m.MemberKind;
		StringBuilder stringBuilder2;
		string value;
		switch (memberKind)
		{
		case MemberTypes.Constructor:
		case MemberTypes.Method:
		{
			n_closureOf_GetKey_._N_method_89248 = (IMethod)m;
			n_closureOf_GetKey_._N_parms_89246 = n_closureOf_GetKey_._N_method_89248.GetParameters();
			n_closureOf_GetKey_._N_tyParmsCount_89244 = n_closureOf_GetKey_._N_method_89248.GetHeader().TypeParameters.Length;
			StringBuilder builder = _N_appendTypeName_89251(n_closureOf_GetKey_, stringBuilder.Append("M:"), n_closureOf_GetKey_._N_method_89248.DeclaringType).Append(".").Append(m.Name.Replace('.', '#'));
			bool condition = n_closureOf_GetKey_._N_tyParmsCount_89244 == 0;
			Function<StringBuilder, StringBuilder> append = new _N__N_lambda__89231__89271(n_closureOf_GetKey_);
			StringBuilder builder2 = builder.AppendUnless(condition, append);
			bool isEmpty = n_closureOf_GetKey_._N_parms_89246.IsEmpty;
			append = new _N__N_lambda__89220__89280(n_closureOf_GetKey_);
			StringBuilder builder3 = builder2.AppendUnless(isEmpty, append);
			bool condition2 = n_closureOf_GetKey_._N_method_89248.Name == "op_Explicit" || n_closureOf_GetKey_._N_method_89248.Name == "op_Implicit";
			append = new _N__N_lambda__89215__89301(n_closureOf_GetKey_);
			stringBuilder2 = builder3.AppendWhen(condition2, append);
			break;
		}
		case MemberTypes.Property:
			value = "P:";
			goto IL_0128;
		case MemberTypes.TypeInfo:
		case MemberTypes.NestedType:
			stringBuilder2 = _N_appendTypeName_89251(n_closureOf_GetKey_, stringBuilder.Append("T:"), (TypeInfo)m);
			break;
		default:
			memberKind = memberKind;
			if (!Message.SeenError)
			{
				value = ("Invalid MemberKinds for doc comment: `" + Convert.ToString(memberKind) + "'").ToString();
				Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(value) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
			}
			throw new AssertionException("ncc\\hierarchy\\XmlDump.n", 512, "", ("Invalid MemberKinds for doc comment: `" + Convert.ToString(memberKind) + "'").ToString());
		case MemberTypes.Event:
			value = "E:";
			goto IL_0128;
		case MemberTypes.Field:
			{
				value = "F:";
				goto IL_0128;
			}
			IL_0128:
			stringBuilder2 = _N_appendTypeName_89251(n_closureOf_GetKey_, stringBuilder.Append(value), m.DeclaringType).Append(".").Append(m.Name.Replace('.', '#'));
			break;
		}
		return stringBuilder2.ToString();
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			last_loc = Completion.Relocate(last_loc, _info);
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}

	private static string _N_scan_88365(_N_closureOf_loop_88340 _N_loop_cp_88363, _N_closureOf_tokenize_88307 _N_tokenize_cp_88364, Function<char, bool> pred)
	{
		checked
		{
			while (_N_tokenize_cp_88364._N_i_88312 < _N_tokenize_cp_88364._N_buf_88314.Length && pred.apply(_N_tokenize_cp_88364._N_buf_88314[_N_tokenize_cp_88364._N_i_88312]))
			{
				_N_tokenize_cp_88364._N_i_88312++;
			}
			return _N_tokenize_cp_88364._N_buf_88314.Substring(_N_loop_cp_88363._N_start_88345, _N_tokenize_cp_88364._N_i_88312 - _N_loop_cp_88363._N_start_88345);
		}
	}

	private static bool _N_is_text_holding_88687(string _N_wildcard_3402)
	{
		int result;
		switch (_N_wildcard_3402)
		{
		case "para":
		case "code":
		case "list":
			result = 1;
			break;
		default:
			result = 0;
			break;
		}
		return (byte)result != 0;
	}

	private static void _N_skip_ws_88696(_N_closureOf_parse_comment_88661 _N_parse_comment_cp_88695)
	{
		while (true)
		{
			XToken current = _N_parse_comment_cp_88695._N_tokens_88670.Current;
			if (current is XToken.WhiteSpace || current == XToken.EmptyLine._N_constant_object)
			{
				bool flag = _N_parse_comment_cp_88695._N_tokens_88670.MoveNext();
				continue;
			}
			break;
		}
	}

	private static void _N_output_88708(_N_closureOf_parse_comment_88661 _N_parse_comment_cp_88707, XToken _N_wildcard_3403)
	{
		if (_N_wildcard_3403 == XToken.EmptyLine._N_constant_object || _N_wildcard_3403 == XToken.EOF._N_constant_object)
		{
			return;
		}
		string value;
		StringBuilder stringBuilder;
		if (_N_wildcard_3403 is XToken.Text)
		{
			value = ((XToken.Text)_N_wildcard_3403).t;
		}
		else
		{
			if (_N_wildcard_3403 is XToken.XmlStart)
			{
				value = ((XToken.XmlStart)_N_wildcard_3403).n;
				string v = ((XToken.XmlStart)_N_wildcard_3403).v;
				stringBuilder = _N_parse_comment_cp_88707._N_sb_88666.Append(string.Concat(string.Concat("<" + value, v), ">"));
				return;
			}
			if (_N_wildcard_3403 is XToken.XmlEnd)
			{
				value = ((XToken.XmlEnd)_N_wildcard_3403).n;
				stringBuilder = _N_parse_comment_cp_88707._N_sb_88666.Append(string.Concat("</" + value, ">"));
				return;
			}
			if (!(_N_wildcard_3403 is XToken.WhiteSpace))
			{
				throw new MatchFailureException();
			}
			value = ((XToken.WhiteSpace)_N_wildcard_3403).w;
		}
		stringBuilder = _N_parse_comment_cp_88707._N_sb_88666.Append(value);
	}

	private static void _N_possibly_close_88722(_N_closureOf_parse_comment_88661 _N_parse_comment_cp_88721, Function<string, bool> pred)
	{
		if (_N_parse_comment_cp_88721._N_tags_88668 is list<Nemerle.Builtins.Tuple<string, bool>>.Cons && !((list<Nemerle.Builtins.Tuple<string, bool>>.Cons)_N_parse_comment_cp_88721._N_tags_88668).hd.Field1)
		{
			string field = ((list<Nemerle.Builtins.Tuple<string, bool>>.Cons)_N_parse_comment_cp_88721._N_tags_88668).hd.Field0;
			list<Nemerle.Builtins.Tuple<string, bool>> tl = ((list<Nemerle.Builtins.Tuple<string, bool>>.Cons)_N_parse_comment_cp_88721._N_tags_88668).tl;
			if (pred.apply(field))
			{
				_N_parse_comment_cp_88721._N_tags_88668 = tl;
				_N_output_88708(_N_parse_comment_cp_88721, new XToken.XmlEnd(field));
			}
		}
	}

	private static void _N_open_fake_88732(_N_closureOf_parse_comment_88661 _N_parse_comment_cp_88731, string name)
	{
		_N_parse_comment_cp_88731._N_tags_88668 = new list<Nemerle.Builtins.Tuple<string, bool>>.Cons(new Nemerle.Builtins.Tuple<string, bool>(name, field1: false), _N_parse_comment_cp_88731._N_tags_88668);
		_N_output_88708(_N_parse_comment_cp_88731, new XToken.XmlStart(name, ""));
	}

	private static StringBuilder _N_appendTypeNameAndArgs_89101(_N_closureOf_AppendParmTypeName_89093 _N_AppendParmTypeName_cp_89100, StringBuilder sb, string typeName, list<TypeVar> args)
	{
		_N_closureOf_appendTypeNameAndArgs_89107 n_closureOf_appendTypeNameAndArgs_ = new _N_closureOf_appendTypeNameAndArgs_89107();
		n_closureOf_appendTypeNameAndArgs_._N_args_89112 = args;
		StringBuilder builder = sb.Append(typeName);
		bool isEmpty = n_closureOf_appendTypeNameAndArgs_._N_args_89112.IsEmpty;
		Function<StringBuilder, StringBuilder> append = new _N__N_lambda__89052__89114(n_closureOf_appendTypeNameAndArgs_, _N_AppendParmTypeName_cp_89100);
		return builder.AppendUnless(isEmpty, append);
	}

	private static int _N_indexOf_89148(list<StaticTypeVar> lst, StaticTypeVar elem)
	{
		list<StaticTypeVar> list = lst;
		StaticTypeVar staticTypeVar = elem;
		int num = 0;
		int result;
		while (true)
		{
			if (list is list<StaticTypeVar>.Cons)
			{
				StaticTypeVar hd = ((list<StaticTypeVar>.Cons)list).hd;
				list = ((list<StaticTypeVar>.Cons)list).tl;
				if (hd.Equals(staticTypeVar))
				{
					result = num;
					break;
				}
				list<StaticTypeVar> obj = list;
				StaticTypeVar staticTypeVar2 = staticTypeVar;
				num = checked(num + 1);
				staticTypeVar = staticTypeVar2;
				list = obj;
				continue;
			}
			if ((object)list == list<StaticTypeVar>.Nil._N_constant_object)
			{
				result = -1;
				break;
			}
			throw new MatchFailureException();
		}
		return result;
	}

	private static StringBuilder _N_appendTypeName_89251(_N_closureOf_GetKey_89239 _N_GetKey_cp_89250, StringBuilder sb, TypeInfo typeInfo)
	{
		int length = typeInfo.Typarms.Length;
		return (length == 0) ? sb.Append(typeInfo.FullName) : ((typeInfo.DeclaringType != null) ? _N_appendTypeName_89251(_N_GetKey_cp_89250, sb, typeInfo.DeclaringType).Append(".").Append(typeInfo.Name).Append("`")
			.Append(checked(length - typeInfo.DeclaringType.Typarms.Length)) : sb.Append(typeInfo.FullName).Append("`").Append(length));
	}
}
