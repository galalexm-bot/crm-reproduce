using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler;
using Nemerle.Compiler.Parsetree;
using Nemerle.Core;

namespace Nemerle.Peg;

internal static class IntelliSenseSupport
{
	private sealed class _N_closureOf_MakeGotoInfos_17108
	{
		internal Grammar _N_grammar_17117;

		internal TypeBuilder _N_tb_17115;

		internal Hashtable<Nemerle.Compiler.Location, Nemerle.Compiler.Location> _N_gotoMap_17113;

		internal _N_closureOf_MakeGotoInfos_17108()
		{
		}
	}

	private sealed class _N_closureOf_makeGotoRuleDef_17126
	{
		internal string _N_scopeBeginName_17133;

		internal string _N_scopeEndName_17131;

		internal _N_closureOf_makeGotoRuleDef_17126()
		{
		}
	}

	private sealed class _N_isScopeHendler__17161 : Function<ClassMember, bool>
	{
		[SpecialName]
		private _N_closureOf_makeGotoRuleDef_17126 _N_makeGotoRuleDef_closure_17165;

		public _N_isScopeHendler__17161(_N_closureOf_makeGotoRuleDef_17126 _N_makeGotoRuleDef_closure_17165)
		{
			this._N_makeGotoRuleDef_closure_17165 = _N_makeGotoRuleDef_closure_17165;
		}

		[SpecialName]
		public sealed override bool apply(ClassMember m)
		{
			int result;
			if (m is ClassMember.Function)
			{
				ClassMember.Function function = (ClassMember.Function)m;
				result = ((function.Name == _N_makeGotoRuleDef_closure_17165._N_scopeBeginName_17133 || function.Name == _N_makeGotoRuleDef_closure_17165._N_scopeEndName_17131) ? 1 : 0);
			}
			else
			{
				result = 0;
			}
			return (byte)result != 0;
		}
	}

	private sealed class _N__N_lambda__17099__17176 : Function<ClassMember, ClassMember.Function>
	{
		[SpecialName]
		public static readonly _N__N_lambda__17099__17176 Instance = new _N__N_lambda__17099__17176();

		[SpecialName]
		public sealed override ClassMember.Function apply(ClassMember _N__17098)
		{
			return (ClassMember.Function)_N__17098;
		}
	}

	public static void AddIntelliSenseSupport(GrammarCompiler compiler, Grammar parsedGrammar, Typer typer, TypeBuilder tb)
	{
		list<NameRef> list = parsedGrammar.Names;
		while (list is list<NameRef>.Cons)
		{
			NameRef hd = ((list<NameRef>.Cons)list).hd;
			list<NameRef> list2 = ((list<NameRef>.Cons)list).tl;
			NameRef ruleName = hd;
			MakeGotoInfos(ruleName, parsedGrammar, tb, typer);
			list = list2;
		}
		Hashtable<Nemerle.Compiler.Location, Nemerle.Compiler.Location> gotoMap = GetGotoMap(tb);
		foreach (KeyValuePair<NameRef, ClassMember.Function> handlerMethod in compiler.GetHandlerMethods())
		{
			KeyValuePair<NameRef, ClassMember.Function> keyValuePair = handlerMethod;
			gotoMap[keyValuePair.Key.Location] = keyValuePair.Value.NameLocation;
			gotoMap[keyValuePair.Value.NameLocation] = keyValuePair.Key.Location;
		}
	}

	public static Hashtable<Nemerle.Compiler.Location, Nemerle.Compiler.Location> GetGotoMap(TypeBuilder tb)
	{
		Hashtable<Nemerle.Compiler.Location, Nemerle.Compiler.Location> hashtable = null;
		hashtable = (Hashtable<Nemerle.Compiler.Location, Nemerle.Compiler.Location>)tb.UserData["GoToInfoMap"];
		if (hashtable == null)
		{
			hashtable = new Hashtable<Nemerle.Compiler.Location, Nemerle.Compiler.Location>();
			tb.UserData["GoToInfoMap"] = hashtable;
		}
		return hashtable;
	}

	private static void MakeGotoInfos(NameRef ruleName, Grammar grammar, TypeBuilder tb, Typer _typer)
	{
		_N_closureOf_MakeGotoInfos_17108 n_closureOf_MakeGotoInfos_ = new _N_closureOf_MakeGotoInfos_17108();
		n_closureOf_MakeGotoInfos_._N_grammar_17117 = grammar;
		n_closureOf_MakeGotoInfos_._N_tb_17115 = tb;
		n_closureOf_MakeGotoInfos_._N_gotoMap_17113 = GetGotoMap(n_closureOf_MakeGotoInfos_._N_tb_17115);
		option<Rule> rule = n_closureOf_MakeGotoInfos_._N_grammar_17117.GetRule(ruleName).Rule;
		if (rule is option<Rule>.Some)
		{
			Rule val = ((option<Rule>.Some)rule).val;
			_N_makeGotoRuleDef_17120(n_closureOf_MakeGotoInfos_, val);
		}
	}

	private static void _N_makeGotoRuleDef_17120(_N_closureOf_MakeGotoInfos_17108 _N_MakeGotoInfos_cp_17119, Rule r)
	{
		while (true)
		{
			_N_closureOf_makeGotoRuleDef_17126 n_closureOf_makeGotoRuleDef_ = new _N_closureOf_makeGotoRuleDef_17126();
			switch (Rule._N_GetVariantCodeSafe(r))
			{
			default:
				throw new MatchFailureException();
			case 0:
			{
				list<Rule> list3 = ((Rule.Choice)r).rules;
				list3 = list3;
				while (list3 is list<Rule>.Cons)
				{
					Rule rule = ((list<Rule>.Cons)list3).hd;
					list3 = ((list<Rule>.Cons)list3).tl;
					_N_makeGotoRuleDef_17120(_N_MakeGotoInfos_cp_17119, rule);
					list3 = list3;
				}
				return;
			}
			case 1:
			{
				list<Rule> list3 = ((Rule.Sequence)r).rules;
				list3 = list3;
				while (list3 is list<Rule>.Cons)
				{
					Rule rule = ((list<Rule>.Cons)list3).hd;
					list3 = ((list<Rule>.Cons)list3).tl;
					_N_makeGotoRuleDef_17120(_N_MakeGotoInfos_cp_17119, rule);
					list3 = list3;
				}
				return;
			}
			case 2:
			{
				NameRef name = ((Rule.Call)r).name;
				_N_MakeGotoInfos_cp_17119._N_gotoMap_17113[name.Location] = _N_MakeGotoInfos_cp_17119._N_grammar_17117.GetRule(name).Location;
				return;
			}
			case 3:
			{
				Rule rule = ((Rule.RepeatMin)r).rule;
				r = rule;
				break;
			}
			case 4:
			{
				Rule rule = ((Rule.RepeatMinMax)r).rule;
				r = rule;
				break;
			}
			case 5:
				return;
			case 6:
				return;
			case 7:
			{
				Rule rule = ((Rule.Not)r).rule;
				r = rule;
				break;
			}
			case 8:
			{
				Rule rule = ((Rule.And)r).rule;
				r = rule;
				break;
			}
			case 9:
			{
				Rule rule = ((Rule.Capture)r).rule;
				r = rule;
				break;
			}
			case 10:
			{
				NameRef name = ((Rule.Scope)r).name;
				Rule rule = ((Rule.Scope)r).rule;
				n_closureOf_makeGotoRuleDef_._N_scopeBeginName_17133 = name.Id + "ScopeBegin";
				n_closureOf_makeGotoRuleDef_._N_scopeEndName_17131 = name.Id + "ScopeEnd";
				Function<ClassMember, bool> f = new _N_isScopeHendler__17161(n_closureOf_makeGotoRuleDef_);
				list<ClassMember> list = _N_MakeGotoInfos_cp_17119._N_tb_17115.GetParsedMembers().Filter(f);
				Function<ClassMember, ClassMember.Function> instance = _N__N_lambda__17099__17176.Instance;
				list<ClassMember.Function> list2 = list.Map(instance);
				if (list2 is list<ClassMember.Function>.Cons)
				{
					ClassMember.Function hd = ((list<ClassMember.Function>.Cons)list2).hd;
					_N_MakeGotoInfos_cp_17119._N_gotoMap_17113[name.Location] = hd.Location;
				}
				else
				{
					Message.Error(name.Location, "You must define scope hendler[s] for this scope: " + Convert.ToString(n_closureOf_makeGotoRuleDef_._N_scopeBeginName_17133) + "() : void and/or " + Convert.ToString(n_closureOf_makeGotoRuleDef_._N_scopeEndName_17131) + "(isFial : bool) : void");
				}
				r = rule;
				break;
			}
			case 11:
				return;
			}
		}
	}
}
