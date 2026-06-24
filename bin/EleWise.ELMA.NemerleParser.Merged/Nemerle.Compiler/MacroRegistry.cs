using System;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Parsetree;
using Nemerle.Core;
using Nemerle.Utility;

namespace Nemerle.Compiler;

public class MacroRegistry : ISupportRelocation
{
	private readonly Hashtable<NamespaceTree.Node, list<SyntaxDefinition>> extensions;

	internal readonly Name implicit_ctx_name;

	public readonly ManagerClass Manager;

	public InternalTypeClass InternalType => Manager.InternalType;

	public SystemTypeClass SystemTypeCache => Manager.SystemTypeCache;

	public Name GetImplicitCTXName()
	{
		return implicit_ctx_name;
	}

	internal MacroRegistry(ManagerClass man)
	{
		extensions = new Hashtable<NamespaceTree.Node, list<SyntaxDefinition>>(50);
		Manager = man;
		implicit_ctx_name = Macros.NewSymbol();
	}

	internal list<SyntaxDefinition> GetSyntaxExtensions(NamespaceTree.Node name_space)
	{
		return extensions.Get(name_space).WithDefault(list<SyntaxDefinition>.Nil._N_constant_object);
	}

	public void AddOperatorDefinition(OperatorDefinition info)
	{
		NamespaceTree.Node macroNamespace = info.MacroNamespace;
		option<list<SyntaxDefinition>> option = extensions.Get(macroNamespace);
		if (option is option<list<SyntaxDefinition>>.Some)
		{
			list<SyntaxDefinition> tl = ((option<list<SyntaxDefinition>>.Some)option).val;
			extensions.Set(macroNamespace, new list<SyntaxDefinition>.Cons(info, tl));
			return;
		}
		if (option == option<list<SyntaxDefinition>>.None._N_constant_object)
		{
			extensions.Set(macroNamespace, new list<SyntaxDefinition>.Cons(info, list<SyntaxDefinition>.Nil._N_constant_object));
			return;
		}
		throw new MatchFailureException();
	}

	public void RegisterMacro(IMacro m)
	{
		string @namespace = m.GetNamespace();
		NamespaceTree.Node node = ((!(@namespace == "")) ? Manager.NameTree.ExactPath(NString.Split(@namespace, '.')) : Manager.NameTree.ExactPath(new list<string>.Cons("Nemerle", new list<string>.Cons("Core", list<string>.Nil._N_constant_object))));
		list<string>.Cons cons = new list<string>.Cons(m.GetName(), list<string>.Nil._N_constant_object);
		option<IMacro> option = node.LookupMacro(cons);
		if (option is option<IMacro>.Some)
		{
			Message.Error(string.Concat(string.Concat("macro `" + @namespace, m.GetName()), "' already defined"));
			return;
		}
		if (option == option<IMacro>.None._N_constant_object)
		{
			NamespaceTree.Node node2 = node.Path(cons);
			Nemerle.Builtins.Tuple<GrammarElement, Function<list<SyntaxElement>, list<SyntaxElement>>> tuple = m.SyntaxExtension();
			if ((object)tuple.Field0 != null)
			{
				GrammarElement field = tuple.Field0;
				Function<list<SyntaxElement>, list<SyntaxElement>> permute = tuple.Field1;
				@namespace = field.ToString();
				SyntaxDefinition hd = new SyntaxDefinition(@namespace, m.Keywords, node2, field.Next, permute);
				option<list<SyntaxDefinition>> option2 = extensions.Get(node);
				if (option2 is option<list<SyntaxDefinition>>.Some)
				{
					list<SyntaxDefinition> tl = ((option<list<SyntaxDefinition>>.Some)option2).val;
					extensions.Set(node, new list<SyntaxDefinition>.Cons(hd, tl));
				}
				else
				{
					if (option2 != option<list<SyntaxDefinition>>.None._N_constant_object)
					{
						throw new MatchFailureException();
					}
					extensions.Set(node, new list<SyntaxDefinition>.Cons(hd, list<SyntaxDefinition>.Nil._N_constant_object));
				}
			}
			NamespaceTree.AddMacro(node2, m);
			return;
		}
		throw new MatchFailureException();
	}

	internal static Nemerle.Builtins.Tuple<PExpr, option<Nemerle.Builtins.Tuple<IMacro, PExpr>>> expand_one_macro(Typer ctx, PExpr expr)
	{
		//Discarded unreachable code: IL_0349, IL_0352, IL_035b, IL_0364
		try
		{
			Nemerle.Builtins.Tuple<PExpr, option<Nemerle.Builtins.Tuple<IMacro, PExpr>>> result;
			if (expr is PExpr.Call)
			{
				PExpr func = ((PExpr.Call)expr).func;
				list<PExpr> n_wildcard_ = ((PExpr.Call)expr).parms;
				option<Nemerle.Builtins.Tuple<list<string>, Name>> option = Util.QidOfExpr(func);
				if (option is option<Nemerle.Builtins.Tuple<list<string>, Name>>.Some)
				{
					list<string> field = ((option<Nemerle.Builtins.Tuple<list<string>, Name>>.Some)option).val.Field0;
					Name field2 = ((option<Nemerle.Builtins.Tuple<list<string>, Name>>.Some)option).val.Field1;
					option<IMacro> option2 = field2.GetEnv(ctx.Env).LookupMacro(field);
					if (option2 is option<IMacro>.Some)
					{
						IMacro val = ((option<IMacro>.Some)option2).val;
						PExpr pExpr2;
						try
						{
							ctx.Manager.MacroColors.PushNewColor(field2.color, field2.GetEnv(ctx.Env));
							Location location = expr.Location;
							bool flag = location.FileIndex != 0;
							if (flag)
							{
								LocationStack.Push(location);
							}
							PExpr pExpr;
							try
							{
								pExpr = val.Run(ctx, val.CallTransform(n_wildcard_));
							}
							finally
							{
								if (flag)
								{
									LocationStack.RemoveTop();
								}
							}
							pExpr2 = pExpr;
						}
						finally
						{
							ctx.Manager.MacroColors.PopColor();
						}
						PExpr field3 = pExpr2;
						result = new Nemerle.Builtins.Tuple<PExpr, option<Nemerle.Builtins.Tuple<IMacro, PExpr>>>(field3, new option<Nemerle.Builtins.Tuple<IMacro, PExpr>>.Some(new Nemerle.Builtins.Tuple<IMacro, PExpr>(val, expr)));
					}
					else
					{
						if (option2 != option<IMacro>.None._N_constant_object)
						{
							throw new MatchFailureException();
						}
						result = new Nemerle.Builtins.Tuple<PExpr, option<Nemerle.Builtins.Tuple<IMacro, PExpr>>>(expr, option<Nemerle.Builtins.Tuple<IMacro, PExpr>>.None._N_constant_object);
					}
				}
				else
				{
					if (option != option<Nemerle.Builtins.Tuple<list<string>, Name>>.None._N_constant_object)
					{
						throw new MatchFailureException();
					}
					result = new Nemerle.Builtins.Tuple<PExpr, option<Nemerle.Builtins.Tuple<IMacro, PExpr>>>(expr, option<Nemerle.Builtins.Tuple<IMacro, PExpr>>.None._N_constant_object);
				}
			}
			else if (expr is PExpr.MacroCall)
			{
				Name name = ((PExpr.MacroCall)expr).name;
				NamespaceTree.Node ns = ((PExpr.MacroCall)expr).ns;
				list<SyntaxElement> args = ((PExpr.MacroCall)expr).parms;
				NamespaceTree.TypeInfoCache value = ns.Value;
				if (!(value is NamespaceTree.TypeInfoCache.MacroCall))
				{
					if (!Message.SeenError)
					{
						string text = string.Concat("failed to resolve macro name `" + ns.GetDisplayName(), "'").ToString();
						Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
					}
					throw new AssertionException("ncc\\typing\\MacroRegistry.n", 131, "", string.Concat("failed to resolve macro name `" + ns.GetDisplayName(), "'").ToString());
				}
				IMacro m = ((NamespaceTree.TypeInfoCache.MacroCall)value).m;
				PExpr pExpr4;
				try
				{
					ctx.Manager.MacroColors.PushNewColor(name.color, name.GetEnv(ctx.Env));
					Location location2 = expr.Location;
					bool flag2 = location2.FileIndex != 0;
					if (flag2)
					{
						LocationStack.Push(location2);
					}
					PExpr pExpr3;
					try
					{
						pExpr3 = m.Run(ctx, args);
					}
					finally
					{
						if (flag2)
						{
							LocationStack.RemoveTop();
						}
					}
					pExpr4 = pExpr3;
				}
				finally
				{
					ctx.Manager.MacroColors.PopColor();
				}
				PExpr field4 = pExpr4;
				result = new Nemerle.Builtins.Tuple<PExpr, option<Nemerle.Builtins.Tuple<IMacro, PExpr>>>(field4, new option<Nemerle.Builtins.Tuple<IMacro, PExpr>>.Some(new Nemerle.Builtins.Tuple<IMacro, PExpr>(m, expr)));
			}
			else
			{
				result = new Nemerle.Builtins.Tuple<PExpr, option<Nemerle.Builtins.Tuple<IMacro, PExpr>>>(expr, option<Nemerle.Builtins.Tuple<IMacro, PExpr>>.None._N_constant_object);
			}
			return result;
		}
		catch (Typer.SwitchToYielding)
		{
			throw;
		}
		catch (RestartInErrorMode)
		{
			throw;
		}
		catch (CompletionResult)
		{
			throw;
		}
		catch (Recovery)
		{
			throw;
		}
		catch (Exception ex)
		{
			ParsedBase parsedBase;
			object obj;
			if (expr is PExpr.Call)
			{
				parsedBase = ((PExpr.Call)expr).func;
			}
			else
			{
				if (!(expr is PExpr.MacroCall))
				{
					obj = "<<unknown>>";
					goto IL_03c6;
				}
				parsedBase = ((PExpr.MacroCall)expr).name;
			}
			obj = string.Concat(Convert.ToString(parsedBase));
			goto IL_03c6;
			IL_03c6:
			string text2 = (string)obj;
			Message.Error(expr.Location, Convert.ToString(ex.GetType().Name) + " has occurred when expanding macro '" + Convert.ToString(text2) + "'");
			return new Nemerle.Builtins.Tuple<PExpr, option<Nemerle.Builtins.Tuple<IMacro, PExpr>>>(expr, option<Nemerle.Builtins.Tuple<IMacro, PExpr>>.None._N_constant_object);
		}
	}

	internal static Nemerle.Builtins.Tuple<PExpr, list<Nemerle.Builtins.Tuple<IMacro, PExpr>>> expand_macro(Typer ctx, PExpr expr)
	{
		Nemerle.Builtins.Tuple<PExpr, option<Nemerle.Builtins.Tuple<IMacro, PExpr>>> tuple = expand_one_macro(ctx, expr);
		Nemerle.Builtins.Tuple<PExpr, list<Nemerle.Builtins.Tuple<IMacro, PExpr>>> result;
		if (tuple.Field1 is option<Nemerle.Builtins.Tuple<IMacro, PExpr>>.Some)
		{
			PExpr field = tuple.Field0;
			Nemerle.Builtins.Tuple<IMacro, PExpr> val = ((option<Nemerle.Builtins.Tuple<IMacro, PExpr>>.Some)tuple.Field1).val;
			Nemerle.Builtins.Tuple<PExpr, list<Nemerle.Builtins.Tuple<IMacro, PExpr>>> tuple2 = expand_macro(ctx, field);
			field = tuple2.Field0;
			list<Nemerle.Builtins.Tuple<IMacro, PExpr>> tl = tuple2.Field1;
			result = new Nemerle.Builtins.Tuple<PExpr, list<Nemerle.Builtins.Tuple<IMacro, PExpr>>>(field, new list<Nemerle.Builtins.Tuple<IMacro, PExpr>>.Cons(val, tl));
		}
		else
		{
			if (tuple.Field1 != option<Nemerle.Builtins.Tuple<IMacro, PExpr>>.None._N_constant_object)
			{
				throw new MatchFailureException();
			}
			PExpr field = tuple.Field0;
			result = new Nemerle.Builtins.Tuple<PExpr, list<Nemerle.Builtins.Tuple<IMacro, PExpr>>>(field, list<Nemerle.Builtins.Tuple<IMacro, PExpr>>.Nil._N_constant_object);
		}
		return result;
	}

	internal static option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>> lookup_macro(GlobalEnv env, PExpr expr, string suff)
	{
		while (expr is PExpr.Ref || expr is PExpr.Member)
		{
			GlobalEnv globalEnv = env;
			PExpr obj = new PExpr.Call(Macros.QuotationChoose(expr), list<PExpr>.Nil._N_constant_object);
			suff = suff;
			expr = obj;
			env = globalEnv;
		}
		object result;
		if (expr is PExpr.Call)
		{
			PExpr func = ((PExpr.Call)expr).func;
			list<PExpr> n_wildcard_ = ((PExpr.Call)expr).parms;
			option<Nemerle.Builtins.Tuple<list<string>, Name>> option = Util.QidOfExpr(func);
			if (option is option<Nemerle.Builtins.Tuple<list<string>, Name>>.Some)
			{
				list<string> field = ((option<Nemerle.Builtins.Tuple<list<string>, Name>>.Some)option).val.Field0;
				Name field2 = ((option<Nemerle.Builtins.Tuple<list<string>, Name>>.Some)option).val.Field1;
				GlobalEnv env2 = field2.GetEnv(env);
				field = NList.Rev(field);
				if (!(field is list<string>.Cons))
				{
					if ((object)field == list<string>.Nil._N_constant_object)
					{
						throw new AssertionException("ncc\\typing\\MacroRegistry.n", 179, "", "");
					}
					throw new MatchFailureException();
				}
				string hd = ((list<string>.Cons)field).hd;
				field = ((list<string>.Cons)field).tl;
				field = NList.Rev(new list<string>.Cons(hd + suff, field));
				option<IMacro> option2 = env2.LookupMacro(field);
				if (option2 is option<IMacro>.Some)
				{
					IMacro val = ((option<IMacro>.Some)option2).val;
					result = new option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>>.Some(new Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>(field2, val, val.CallTransform(n_wildcard_)));
				}
				else
				{
					if (option2 != option<IMacro>.None._N_constant_object)
					{
						throw new MatchFailureException();
					}
					result = option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>>.None._N_constant_object;
				}
			}
			else
			{
				if (option != option<Nemerle.Builtins.Tuple<list<string>, Name>>.None._N_constant_object)
				{
					throw new MatchFailureException();
				}
				result = option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>>.None._N_constant_object;
			}
		}
		else if (expr is PExpr.MacroCall)
		{
			Name field2 = ((PExpr.MacroCall)expr).name;
			NamespaceTree.Node ns = ((PExpr.MacroCall)expr).ns;
			list<SyntaxElement> field3 = ((PExpr.MacroCall)expr).parms;
			NamespaceTree.TypeInfoCache value = ns.Value;
			if (!(value is NamespaceTree.TypeInfoCache.MacroCall))
			{
				if (!Message.SeenError)
				{
					string hd = string.Concat("failed to resolve macro name `" + ns.GetDisplayName(), "'").ToString();
					Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(hd) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
				}
				throw new AssertionException("ncc\\typing\\MacroRegistry.n", 197, "", string.Concat("failed to resolve macro name `" + ns.GetDisplayName(), "'").ToString());
			}
			IMacro val = ((NamespaceTree.TypeInfoCache.MacroCall)value).m;
			result = ((!val.GetName().EndsWith(suff)) ? ((option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>>)option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>>.None._N_constant_object) : ((option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>>)new option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>>.Some(new Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>(field2, val, field3))));
		}
		else
		{
			result = option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>>.None._N_constant_object;
		}
		return (option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>>)result;
	}

	private void __fake()
	{
		__fake();
		SystemTypeClass systemTypeCache = SystemTypeCache;
		InternalTypeClass internalType = InternalType;
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			_info.VisitedObjects[this] = 0;
			implicit_ctx_name?.RelocateImplInternal(_info);
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
