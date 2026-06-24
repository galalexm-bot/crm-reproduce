using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Compiler.Parsetree;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler;

[Nemerle.Internal.Extension]
public static class Completion
{
	public class RelocationFailedException : Exception, ISupportRelocation
	{
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

	private sealed class _N_closureOf_Relocate_52056
	{
		internal Location _N_loc_52061;

		internal _N_closureOf_Relocate_52056()
		{
		}
	}

	private sealed class _N_closureOf_MatchName_52131
	{
		internal _N_closureOf_MatchName_52131()
		{
		}
	}

	private sealed class _N_closureOf_AddTypesAndNamespaces_52274
	{
		internal List<Elem> _N_elems_52287;

		internal bool _N_noMacros_52285;

		internal bool _N_noMembers_52283;

		internal string _N_pattern_52281;

		internal bool _N_isAll_52279;

		internal _N_closureOf_AddTypesAndNamespaces_52274()
		{
		}
	}

	private const StringComparison CmpOptions = StringComparison.InvariantCultureIgnoreCase;

	public static Location Relocate(Location loc, RelocationInfo info)
	{
		_N_closureOf_Relocate_52056 n_closureOf_Relocate_ = new _N_closureOf_Relocate_52056();
		n_closureOf_Relocate_._N_loc_52061 = loc;
		if (!(n_closureOf_Relocate_._N_loc_52061.Begin <= n_closureOf_Relocate_._N_loc_52061.End))
		{
		}
		Location result;
		if (n_closureOf_Relocate_._N_loc_52061.FileIndex != info.FileIndex)
		{
			result = n_closureOf_Relocate_._N_loc_52061;
		}
		else if (n_closureOf_Relocate_._N_loc_52061.End < info.Begin)
		{
			result = n_closureOf_Relocate_._N_loc_52061;
		}
		else if (n_closureOf_Relocate_._N_loc_52061.End == info.Begin)
		{
			if (n_closureOf_Relocate_._N_loc_52061.Begin == info.Begin)
			{
				TextPoint textPoint = _N_relocatePoint_52064(n_closureOf_Relocate_, n_closureOf_Relocate_._N_loc_52061.Begin, info);
				Location location = new Location(n_closureOf_Relocate_._N_loc_52061, textPoint, textPoint);
				if (!(location.Begin <= location.End))
				{
				}
				result = location;
			}
			else
			{
				result = n_closureOf_Relocate_._N_loc_52061;
			}
		}
		else
		{
			TextPoint begin = _N_relocatePoint_52064(n_closureOf_Relocate_, n_closureOf_Relocate_._N_loc_52061.Begin, info);
			TextPoint textPoint = _N_relocatePoint_52064(n_closureOf_Relocate_, n_closureOf_Relocate_._N_loc_52061.End, info);
			Location location = new Location(n_closureOf_Relocate_._N_loc_52061, begin, textPoint);
			if (!(location.Begin <= location.End))
			{
			}
			result = location;
		}
		return result;
	}

	public static Location RelocateFile(Location loc, RelocationInfo info)
	{
		return (loc.FileIndex != info.FileIndex) ? loc : Relocate(loc, info);
	}

	public static bool MatchName(string name, string pattern)
	{
		_N_closureOf_MatchName_52131 n_MatchName_cp_ = new _N_closureOf_MatchName_52131();
		return name.Length >= pattern.Length && (name.StartsWith(pattern, StringComparison.InvariantCultureIgnoreCase) || _N_loop_52144(n_MatchName_cp_, name, 0, pattern.ToUpperInvariant(), 0));
	}

	public static void AddTypesAndNamespaces([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] List<Elem> elems, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] list<NamespaceTree.Node> nss, PExpr obj, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] Name name, bool noMacros, bool noMembers)
	{
		_N_closureOf_AddTypesAndNamespaces_52274 n_closureOf_AddTypesAndNamespaces_ = new _N_closureOf_AddTypesAndNamespaces_52274();
		n_closureOf_AddTypesAndNamespaces_._N_elems_52287 = elems;
		n_closureOf_AddTypesAndNamespaces_._N_noMacros_52285 = noMacros;
		n_closureOf_AddTypesAndNamespaces_._N_noMembers_52283 = noMembers;
		if (name == null)
		{
			throw new ArgumentNullException("name", "The ``NotNull'' contract of parameter ``name'' has been violated. See ncc\\completion\\CodeCompletionEngine.n:219:17:219:21: .");
		}
		if ((object)nss == null)
		{
			throw new ArgumentNullException("nss", "The ``NotNull'' contract of parameter ``nss'' has been violated. See ncc\\completion\\CodeCompletionEngine.n:217:17:217:20: .");
		}
		if (n_closureOf_AddTypesAndNamespaces_._N_elems_52287 == null)
		{
			throw new ArgumentNullException("elems", "The ``NotNull'' contract of parameter ``elems'' has been violated. See ncc\\completion\\CodeCompletionEngine.n:216:17:216:22: .");
		}
		n_closureOf_AddTypesAndNamespaces_._N_pattern_52281 = name.Id;
		n_closureOf_AddTypesAndNamespaces_._N_isAll_52279 = string.IsNullOrEmpty(n_closureOf_AddTypesAndNamespaces_._N_pattern_52281);
		if ((object)obj == null)
		{
			list<NamespaceTree.Node> list = nss;
			while (list is list<NamespaceTree.Node>.Cons)
			{
				NamespaceTree.Node hd = ((list<NamespaceTree.Node>.Cons)list).hd;
				list = ((list<NamespaceTree.Node>.Cons)list).tl;
				_N_scanAndAdd_52299(n_closureOf_AddTypesAndNamespaces_, hd);
				list = list;
			}
			return;
		}
		option<Nemerle.Builtins.Tuple<list<string>, Name>> option = Util.QidOfExpr(obj);
		if (option is option<Nemerle.Builtins.Tuple<list<string>, Name>>.Some)
		{
			list<string> field = ((option<Nemerle.Builtins.Tuple<list<string>, Name>>.Some)option).val.Field0;
			NamespaceTree.Node hd = NamespaceTree.Node.PassTo(nss, field);
			if ((object)hd != null)
			{
				_N_scanAndAdd_52299(n_closureOf_AddTypesAndNamespaces_, hd);
			}
		}
		else if (option != option<Nemerle.Builtins.Tuple<list<string>, Name>>.None._N_constant_object)
		{
			throw new MatchFailureException();
		}
	}

	[Nemerle.Internal.Extension]
	public static string GetName(this IMember member)
	{
		MemberTypes memberKind = member.MemberKind;
		return (memberKind != MemberTypes.Constructor) ? member.Name : ReplaceSpecialName(member.DeclaringType.Name);
	}

	public static string ReplaceSpecialName(string name)
	{
		object result;
		switch (name)
		{
		case "Nemerle.Core.list":
		case "Nemerle.Core.list+Cons":
		case "Nemerle.Core.list+Nil":
			result = "list";
			break;
		case "System.Byte":
			result = "byte";
			break;
		case "System.SByte":
			result = "sbyte";
			break;
		case "System.Int16":
			result = "short";
			break;
		case "System.UInt16":
			result = "ushort";
			break;
		case "System.Int32":
			result = "int";
			break;
		case "System.UInt32":
			result = "uint";
			break;
		case "System.Int64":
			result = "long";
			break;
		case "System.UInt64":
			result = "ulong";
			break;
		case "System.Single":
			result = "float";
			break;
		case "System.Double":
			result = "double";
			break;
		case "System.Decimal":
			result = "decimal";
			break;
		case "System.String":
			result = "string";
			break;
		case "System.Object":
			result = "object";
			break;
		case "System.Boolean":
			result = "bool";
			break;
		case "System.Char":
			result = "char";
			break;
		default:
			result = name;
			break;
		}
		return (string)result;
	}

	private static TextPoint _N_relocatePoint_52064(_N_closureOf_Relocate_52056 _N_Relocate_cp_52063, TextPoint point, RelocationInfo info)
	{
		TextPoint textPoint = default(TextPoint);
		TextPoint result;
		if (point < info.Begin)
		{
			result = point;
		}
		else
		{
			if (point < info.Old)
			{
				_N_Relocate_cp_52063._N_loc_52061 = Location.Default;
				return new TextPoint(0, 0);
			}
			result = checked((info.Old.Line != point.Line) ? new TextPoint(point.Line - info.Old.Line + info.New.Line, point.Column) : new TextPoint(point.Line - info.Old.Line + info.New.Line, point.Column - info.Old.Column + info.New.Column));
		}
		return result;
	}

	private static bool _N_loop_52144(_N_closureOf_MatchName_52131 _N_MatchName_cp_52143, string name, int nameIndex, string pattern, int patternIndex)
	{
		int result;
		checked
		{
			while (true)
			{
				if (pattern.Length == patternIndex)
				{
					result = 1;
					break;
				}
				if (name.Length == nameIndex)
				{
					result = 0;
					break;
				}
				char c = name[nameIndex];
				if (char.IsUpper(c))
				{
					if (c == pattern[patternIndex])
					{
						string text = name;
						int num = nameIndex;
						string text2 = pattern;
						int num2 = patternIndex;
						while (true)
						{
							if (_N_loop_52144(_N_MatchName_cp_52143, text, num + 1, text2, num2 + 1))
							{
								result = 1;
								break;
							}
							if (text.Length == num + 1 || text2.Length == num2 + 1)
							{
								result = 0;
								break;
							}
							if (char.ToUpperInvariant(text[num + 1]) == text2[num2 + 1])
							{
								string text3 = text;
								int num3 = num + 1;
								string text4 = text2;
								num2++;
								text2 = text4;
								num = num3;
								text = text3;
								continue;
							}
							result = 0;
							break;
						}
					}
					else
					{
						result = 0;
					}
					break;
				}
				string text5 = name;
				int num4 = nameIndex + 1;
				string text6 = pattern;
				patternIndex = patternIndex;
				pattern = text6;
				nameIndex = num4;
				name = text5;
			}
		}
		return (byte)result != 0;
	}

	private static void _N_scanAndAdd_52299(_N_closureOf_AddTypesAndNamespaces_52274 _N_AddTypesAndNamespaces_cp_52298, NamespaceTree.Node subNode)
	{
		if (subNode.Children != null)
		{
			foreach (KeyValuePair<string, NamespaceTree.Node> child in subNode.Children)
			{
				KeyValuePair<string, NamespaceTree.Node> keyValuePair = child;
				if (!_N_AddTypesAndNamespaces_cp_52298._N_isAll_52279 && !MatchName(keyValuePair.Key, _N_AddTypesAndNamespaces_cp_52298._N_pattern_52281))
				{
					continue;
				}
				string key = keyValuePair.Key;
				NamespaceTree.Node value = keyValuePair.Value;
				NamespaceTree.TypeInfoCache value2 = value.Value;
				if (value2 == NamespaceTree.TypeInfoCache.No._N_constant_object)
				{
					continue;
				}
				if (value2 is NamespaceTree.TypeInfoCache.MacroCall)
				{
					IMacro m = ((NamespaceTree.TypeInfoCache.MacroCall)value2).m;
					if (!_N_AddTypesAndNamespaces_cp_52298._N_noMacros_52285)
					{
						string name = ((!m.Keywords.IsEmpty) ? m.Keywords.Head : value.PartName);
						Elem.Node item = new Elem.Node(name, value);
						_N_AddTypesAndNamespaces_cp_52298._N_elems_52287.Add(item);
					}
				}
				else
				{
					_N_AddTypesAndNamespaces_cp_52298._N_elems_52287.Add(new Elem.Node(key, value));
				}
			}
		}
		subNode.EnsureCached();
		if (_N_AddTypesAndNamespaces_cp_52298._N_noMembers_52283)
		{
			return;
		}
		NamespaceTree.TypeInfoCache value3 = subNode.Value;
		if (value3 is NamespaceTree.TypeInfoCache.Cached)
		{
			TypeInfo tycon = ((NamespaceTree.TypeInfoCache.Cached)value3).tycon;
			_N_scanStaticMembers_52333(_N_AddTypesAndNamespaces_cp_52298, tycon);
		}
		else if (value3 is NamespaceTree.TypeInfoCache.CachedAmbiguous)
		{
			list<TypeInfo> list = ((NamespaceTree.TypeInfoCache.CachedAmbiguous)value3).elems;
			list<TypeInfo> list2 = list;
			while (list2 is list<TypeInfo>.Cons)
			{
				TypeInfo hd = ((list<TypeInfo>.Cons)list2).hd;
				list<TypeInfo> list3 = ((list<TypeInfo>.Cons)list2).tl;
				TypeInfo ti = hd;
				_N_scanStaticMembers_52333(_N_AddTypesAndNamespaces_cp_52298, ti);
				list2 = list3;
			}
		}
	}

	private static void _N_scanStaticMembers_52333(_N_closureOf_AddTypesAndNamespaces_52274 _N_AddTypesAndNamespaces_cp_52332, TypeInfo ti)
	{
		list<IMember> list = ti.GetMembers(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
		while (list is list<IMember>.Cons)
		{
			IMember hd = ((list<IMember>.Cons)list).hd;
			list = ((list<IMember>.Cons)list).tl;
			hd = hd;
			if (_N_AddTypesAndNamespaces_cp_52332._N_isAll_52279 || MatchName(hd.GetName(), _N_AddTypesAndNamespaces_cp_52332._N_pattern_52281))
			{
				_N_AddTypesAndNamespaces_cp_52332._N_elems_52287.Add(new Elem.Member(hd));
			}
			list = list;
		}
	}
}
