using System;
using System.Runtime.CompilerServices;
using System.Text;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Parsetree;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;
using Nemerle.Internal;
using Nemerle.Utility;

namespace Nemerle.Compiler;

public static class PrettyPrint
{
	private sealed class _N_closureOf_SprintExpr_91161
	{
		internal option<Typer> _N_ctx_91174;

		internal string _N_indentation_91172;

		internal LocatableTextWriter _N_acc_91170;

		internal FunctionVoid<PParameter> _N_print_funparm_91168;

		internal list<SyntaxElement> _N_parms_left_91166;

		internal _N_closureOf_SprintExpr_91161()
		{
		}
	}

	private sealed class _N_print_funparm__91189 : FunctionVoid<PParameter>
	{
		[SpecialName]
		private _N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91193;

		public _N_print_funparm__91189(_N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91193)
		{
			this._N_SprintExpr_closure_91193 = _N_SprintExpr_closure_91193;
		}

		[SpecialName]
		public sealed override void apply_void(PParameter p)
		{
			Name body;
			PExpr type;
			PExpr pExpr;
			if (p.name is Splicable.Name)
			{
				if (p.modifiers.mods == NemerleModifiers.None)
				{
					body = ((Splicable.Name)p.name).body;
					type = p.Type;
					if (p.modifiers.custom_attrs is list<PExpr>.Cons)
					{
						if (((list<PExpr>.Cons)p.modifiers.custom_attrs).hd is PExpr.Member)
						{
							if (((PExpr.Member)((list<PExpr>.Cons)p.modifiers.custom_attrs).hd).obj is PExpr.Ref)
							{
								if (((PExpr.Ref)((PExpr.Member)((list<PExpr>.Cons)p.modifiers.custom_attrs).hd).obj).name.idl == "System")
								{
									if (((PExpr.Member)((list<PExpr>.Cons)p.modifiers.custom_attrs).hd).member is Splicable.Name)
									{
										if (((Splicable.Name)((PExpr.Member)((list<PExpr>.Cons)p.modifiers.custom_attrs).hd).member).body.idl == "ParamArrayAttribute")
										{
											if ((object)((list<PExpr>.Cons)p.modifiers.custom_attrs).tl == list<PExpr>.Nil._N_constant_object)
											{
												_N_SprintExpr_closure_91193._N_acc_91170.Write("params ");
												PrintName(body, _N_SprintExpr_closure_91193._N_acc_91170);
												_N_SprintExpr_closure_91193._N_acc_91170.Write(" : ");
												SprintExpr(_N_SprintExpr_closure_91193._N_ctx_91174, type, _N_SprintExpr_closure_91193._N_indentation_91172, _N_SprintExpr_closure_91193._N_acc_91170);
												return;
											}
											if (p.DefaultValue is option<PExpr>.Some)
											{
												body = ((Splicable.Name)p.name).body;
												type = p.Type;
												goto IL_01e7;
											}
										}
										else
										{
											if (p.DefaultValue is option<PExpr>.Some)
											{
												body = ((Splicable.Name)p.name).body;
												type = p.Type;
												goto IL_01e7;
											}
											if ((object)((list<PExpr>.Cons)p.modifiers.custom_attrs).tl == list<PExpr>.Nil._N_constant_object)
											{
												body = ((Splicable.Name)p.name).body;
												type = p.Type;
												pExpr = ((list<PExpr>.Cons)p.modifiers.custom_attrs).hd;
												goto IL_01f8;
											}
										}
									}
									else
									{
										if (p.DefaultValue is option<PExpr>.Some)
										{
											body = ((Splicable.Name)p.name).body;
											type = p.Type;
											goto IL_01e7;
										}
										if ((object)((list<PExpr>.Cons)p.modifiers.custom_attrs).tl == list<PExpr>.Nil._N_constant_object)
										{
											body = ((Splicable.Name)p.name).body;
											type = p.Type;
											pExpr = ((list<PExpr>.Cons)p.modifiers.custom_attrs).hd;
											goto IL_01f8;
										}
									}
								}
								else
								{
									if (p.DefaultValue is option<PExpr>.Some)
									{
										body = ((Splicable.Name)p.name).body;
										type = p.Type;
										goto IL_01e7;
									}
									if ((object)((list<PExpr>.Cons)p.modifiers.custom_attrs).tl == list<PExpr>.Nil._N_constant_object)
									{
										body = ((Splicable.Name)p.name).body;
										type = p.Type;
										pExpr = ((list<PExpr>.Cons)p.modifiers.custom_attrs).hd;
										goto IL_01f8;
									}
								}
							}
							else
							{
								if (p.DefaultValue is option<PExpr>.Some)
								{
									body = ((Splicable.Name)p.name).body;
									type = p.Type;
									goto IL_01e7;
								}
								if ((object)((list<PExpr>.Cons)p.modifiers.custom_attrs).tl == list<PExpr>.Nil._N_constant_object)
								{
									body = ((Splicable.Name)p.name).body;
									type = p.Type;
									pExpr = ((list<PExpr>.Cons)p.modifiers.custom_attrs).hd;
									goto IL_01f8;
								}
							}
						}
						else
						{
							if (p.DefaultValue is option<PExpr>.Some)
							{
								body = ((Splicable.Name)p.name).body;
								type = p.Type;
								goto IL_01e7;
							}
							if ((object)((list<PExpr>.Cons)p.modifiers.custom_attrs).tl == list<PExpr>.Nil._N_constant_object)
							{
								body = ((Splicable.Name)p.name).body;
								type = p.Type;
								pExpr = ((list<PExpr>.Cons)p.modifiers.custom_attrs).hd;
								goto IL_01f8;
							}
						}
					}
					else
					{
						if (p.DefaultValue is option<PExpr>.Some)
						{
							body = ((Splicable.Name)p.name).body;
							type = p.Type;
							goto IL_01e7;
						}
						if ((object)p.modifiers.custom_attrs == list<PExpr>.Nil._N_constant_object)
						{
							body = ((Splicable.Name)p.name).body;
							if (p.Type is PExpr.Wildcard)
							{
								pExpr = null;
								type = null;
							}
							else
							{
								body = ((Splicable.Name)p.name).body;
								type = p.Type;
								pExpr = null;
							}
							goto IL_01f8;
						}
					}
				}
				else
				{
					if (p.DefaultValue is option<PExpr>.Some)
					{
						body = ((Splicable.Name)p.name).body;
						type = p.Type;
						goto IL_01e7;
					}
					if (p.modifiers.custom_attrs is list<PExpr>.Cons)
					{
						body = ((Splicable.Name)p.name).body;
						type = p.Type;
						if ((object)((list<PExpr>.Cons)p.modifiers.custom_attrs).tl == list<PExpr>.Nil._N_constant_object)
						{
							pExpr = ((list<PExpr>.Cons)p.modifiers.custom_attrs).hd;
							goto IL_01f8;
						}
					}
				}
			}
			_N_SprintExpr_closure_91193._N_acc_91170.Write(p.ToString());
			return;
			IL_01e7:
			pExpr = ((option<PExpr>.Some)p.DefaultValue).val;
			goto IL_01f8;
			IL_01f8:
			PrintName(body, _N_SprintExpr_closure_91193._N_acc_91170);
			if (type != null)
			{
				_N_SprintExpr_closure_91193._N_acc_91170.Write(" : ");
				SprintExpr(_N_SprintExpr_closure_91193._N_ctx_91174, type, _N_SprintExpr_closure_91193._N_indentation_91172, _N_SprintExpr_closure_91193._N_acc_91170);
			}
			if (pExpr != null)
			{
				_N_SprintExpr_closure_91193._N_acc_91170.Write(" = ");
				SprintExpr(_N_SprintExpr_closure_91193._N_ctx_91174, pExpr, _N_SprintExpr_closure_91193._N_indentation_91172, _N_SprintExpr_closure_91193._N_acc_91170);
			}
		}
	}

	private sealed class _N_print_case__91300 : FunctionVoid<MatchCase>
	{
		[SpecialName]
		private _N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91304;

		public _N_print_case__91300(_N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91304)
		{
			this._N_SprintExpr_closure_91304 = _N_SprintExpr_closure_91304;
		}

		[SpecialName]
		public sealed override void apply_void(MatchCase c)
		{
			list<PExpr> list = c.patterns;
			PExpr body = c.body;
			list = list;
			string text;
			while (list is list<PExpr>.Cons)
			{
				PExpr hd = ((list<PExpr>.Cons)list).hd;
				list = ((list<PExpr>.Cons)list).tl;
				LocatableTextWriter n_acc_ = _N_SprintExpr_closure_91304._N_acc_91170;
				text = _N_SprintExpr_closure_91304._N_indentation_91172 + "  ";
				n_acc_.Write("\n" + text + "| ");
				SprintExpr(_N_SprintExpr_closure_91304._N_ctx_91174, hd, _N_SprintExpr_closure_91304._N_indentation_91172, _N_SprintExpr_closure_91304._N_acc_91170);
				list = list;
			}
			LocatableTextWriter n_acc_2 = _N_SprintExpr_closure_91304._N_acc_91170;
			text = _N_SprintExpr_closure_91304._N_indentation_91172 + "    ";
			n_acc_2.Write(" => \n" + text);
			SprintExpr(_N_SprintExpr_closure_91304._N_ctx_91174, body, _N_SprintExpr_closure_91304._N_indentation_91172 + "    ", _N_SprintExpr_closure_91304._N_acc_91170);
		}
	}

	private sealed class _N_print_parm__91317 : FunctionVoid<PExpr>
	{
		[SpecialName]
		private _N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91321;

		public _N_print_parm__91317(_N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91321)
		{
			this._N_SprintExpr_closure_91321 = _N_SprintExpr_closure_91321;
		}

		[SpecialName]
		public sealed override void apply_void(PExpr p)
		{
			if (p is PExpr.Assign && ((PExpr.Assign)p).target is PExpr.Ref)
			{
				Name name = ((PExpr.Ref)((PExpr.Assign)p).target).name;
				PExpr source = ((PExpr.Assign)p).source;
				_N_SprintExpr_closure_91321._N_acc_91170.Write(name.Id + " = ");
				SprintExpr(_N_SprintExpr_closure_91321._N_ctx_91174, source, _N_SprintExpr_closure_91321._N_indentation_91172 + "  ", _N_SprintExpr_closure_91321._N_acc_91170);
			}
			else
			{
				SprintExpr(_N_SprintExpr_closure_91321._N_ctx_91174, p, _N_SprintExpr_closure_91321._N_indentation_91172 + "  ", _N_SprintExpr_closure_91321._N_acc_91170);
			}
		}
	}

	private sealed class _N__N_lambda__91102__91336 : FunctionVoid<PExpr>
	{
		[SpecialName]
		private _N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91340;

		public _N__N_lambda__91102__91336(_N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91340)
		{
			this._N_SprintExpr_closure_91340 = _N_SprintExpr_closure_91340;
		}

		[SpecialName]
		public sealed override void apply_void(PExpr x)
		{
			SprintExpr(_N_SprintExpr_closure_91340._N_ctx_91174, x, _N_SprintExpr_closure_91340._N_indentation_91172, _N_SprintExpr_closure_91340._N_acc_91170);
		}
	}

	private sealed class _N__N_lambda__91042__91345 : FunctionVoid<PExpr>
	{
		[SpecialName]
		private _N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91349;

		public _N__N_lambda__91042__91345(_N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91349)
		{
			this._N_SprintExpr_closure_91349 = _N_SprintExpr_closure_91349;
		}

		[SpecialName]
		public sealed override void apply_void(PExpr x)
		{
			SprintExpr(_N_SprintExpr_closure_91349._N_ctx_91174, x, _N_SprintExpr_closure_91349._N_indentation_91172 + " ", _N_SprintExpr_closure_91349._N_acc_91170);
		}
	}

	private sealed class _N_print_fun__91360 : FunctionVoid<Function_decl>
	{
		[SpecialName]
		private _N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91364;

		public _N_print_fun__91360(_N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91364)
		{
			this._N_SprintExpr_closure_91364 = _N_SprintExpr_closure_91364;
		}

		[SpecialName]
		public sealed override void apply_void(Function_decl f)
		{
			try
			{
				if (f == null)
				{
					_N_SprintExpr_closure_91364._N_acc_91170.Write("(null :> Function_decl)");
				}
				else if (f.header == null)
				{
					_N_SprintExpr_closure_91364._N_acc_91170.Write("_()");
					if (f.body == null)
					{
						_N_SprintExpr_closure_91364._N_acc_91170.Write(" _ ");
					}
					else
					{
						SprintExpr(_N_SprintExpr_closure_91364._N_ctx_91174, f.body, _N_SprintExpr_closure_91364._N_indentation_91172, _N_SprintExpr_closure_91364._N_acc_91170);
					}
				}
				else if (f.header.SplicableName is Splicable.Name)
				{
					list<Splicable> list = f.header.TypeParameters.tyvars;
					list<Constraint> cts = f.header.TypeParameters.constraints;
					Name body;
					list<PParameter> fps;
					PExpr body2;
					PExpr pExpr;
					if (f.header.ReturnType is PExpr.Wildcard)
					{
						body = ((Splicable.Name)f.header.SplicableName).body;
						fps = f.header.Parameters;
						body2 = f.body;
						pExpr = null;
					}
					else
					{
						list = f.header.TypeParameters.tyvars;
						cts = f.header.TypeParameters.constraints;
						body = ((Splicable.Name)f.header.SplicableName).body;
						pExpr = f.header.ReturnType;
						fps = f.header.Parameters;
						body2 = f.body;
					}
					_N_SprintExpr_closure_91364._N_acc_91170.Write(body.Id);
					_N_SprintExpr_closure_91364._N_acc_91170.Write(" ");
					if (list != null && !list.IsEmpty)
					{
						_N_SprintExpr_closure_91364._N_acc_91170.Write(list.ToString());
					}
					_N_SprintExpr_closure_91364._N_acc_91170.Write("(");
					_N_print_funparms_91218(_N_SprintExpr_closure_91364, fps);
					_N_SprintExpr_closure_91364._N_acc_91170.Write(") ");
					_N_print_tconstraints_91180(_N_SprintExpr_closure_91364, cts);
					_N_SprintExpr_closure_91364._N_acc_91170.Write(" ");
					if (pExpr != null)
					{
						_N_SprintExpr_closure_91364._N_acc_91170.Write(" : ");
						SprintExpr(_N_SprintExpr_closure_91364._N_ctx_91174, pExpr, _N_SprintExpr_closure_91364._N_indentation_91172, _N_SprintExpr_closure_91364._N_acc_91170);
					}
					if (body2 is PExpr.Sequence)
					{
						SprintExpr(_N_SprintExpr_closure_91364._N_ctx_91174, body2, _N_SprintExpr_closure_91364._N_indentation_91172, _N_SprintExpr_closure_91364._N_acc_91170);
					}
					else
					{
						SprintExpr(_N_SprintExpr_closure_91364._N_ctx_91174, new PExpr.Sequence(new list<PExpr>.Cons(Macros.QuotationChoose(body2), list<PExpr>.Nil._N_constant_object)), _N_SprintExpr_closure_91364._N_indentation_91172, _N_SprintExpr_closure_91364._N_acc_91170);
					}
				}
				else
				{
					_N_SprintExpr_closure_91364._N_acc_91170.Write("spliced fun name");
				}
			}
			catch (NullReferenceException)
			{
				_N_SprintExpr_closure_91364._N_acc_91170.Write(" NRE!!! ");
			}
		}
	}

	private sealed class _N__N_lambda__91078__91418 : FunctionVoid<PExpr>
	{
		[SpecialName]
		private _N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91422;

		public _N__N_lambda__91078__91418(_N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91422)
		{
			this._N_SprintExpr_closure_91422 = _N_SprintExpr_closure_91422;
		}

		[SpecialName]
		public sealed override void apply_void(PExpr x)
		{
			_N_SprintExpr_closure_91422._N_acc_91170.Write(Environment.NewLine + Convert.ToString(_N_SprintExpr_closure_91422._N_indentation_91172) + "  ");
			SprintExpr(_N_SprintExpr_closure_91422._N_ctx_91174, x, _N_SprintExpr_closure_91422._N_indentation_91172 + "  ", _N_SprintExpr_closure_91422._N_acc_91170);
		}
	}

	private sealed class _N__N_lambda__91084__91427 : FunctionVoid<PExpr>
	{
		[SpecialName]
		private _N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91431;

		public _N__N_lambda__91084__91427(_N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91431)
		{
			this._N_SprintExpr_closure_91431 = _N_SprintExpr_closure_91431;
		}

		[SpecialName]
		public sealed override void apply_void(PExpr x)
		{
			SprintExpr(_N_SprintExpr_closure_91431._N_ctx_91174, x, _N_SprintExpr_closure_91431._N_indentation_91172, _N_SprintExpr_closure_91431._N_acc_91170);
		}
	}

	private sealed class _N__N_lambda__91090__91436 : FunctionVoid<PExpr>
	{
		[SpecialName]
		private _N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91440;

		public _N__N_lambda__91090__91436(_N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91440)
		{
			this._N_SprintExpr_closure_91440 = _N_SprintExpr_closure_91440;
		}

		[SpecialName]
		public sealed override void apply_void(PExpr x)
		{
			SprintExpr(_N_SprintExpr_closure_91440._N_ctx_91174, x, _N_SprintExpr_closure_91440._N_indentation_91172, _N_SprintExpr_closure_91440._N_acc_91170);
		}
	}

	private sealed class _N__N_lambda__91109__91445 : FunctionVoid<PExpr>
	{
		[SpecialName]
		private _N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91449;

		public _N__N_lambda__91109__91445(_N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91449)
		{
			this._N_SprintExpr_closure_91449 = _N_SprintExpr_closure_91449;
		}

		[SpecialName]
		public sealed override void apply_void(PExpr x)
		{
			SprintExpr(_N_SprintExpr_closure_91449._N_ctx_91174, x, _N_SprintExpr_closure_91449._N_indentation_91172, _N_SprintExpr_closure_91449._N_acc_91170);
		}
	}

	private sealed class _N__N_lambda__91146__91492 : FunctionVoid<SyntaxElement>
	{
		[SpecialName]
		private _N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91496;

		public _N__N_lambda__91146__91492(_N_closureOf_SprintExpr_91161 _N_SprintExpr_closure_91496)
		{
			this._N_SprintExpr_closure_91496 = _N_SprintExpr_closure_91496;
		}

		[SpecialName]
		public sealed override void apply_void(SyntaxElement _N_wildcard_3405)
		{
			if (_N_wildcard_3405 is SyntaxElement.Expression)
			{
				PExpr body = ((SyntaxElement.Expression)_N_wildcard_3405).body;
				SprintExpr(_N_SprintExpr_closure_91496._N_ctx_91174, body, _N_SprintExpr_closure_91496._N_indentation_91172, _N_SprintExpr_closure_91496._N_acc_91170);
			}
		}
	}

	private sealed class _N_closureOf_SprintPattern_91609
	{
		internal StringBuilder _N_result_91614;

		internal _N_closureOf_SprintPattern_91609()
		{
		}
	}

	private sealed class _N_closureOf_SprintTyMatch_91795
	{
		internal option<Typer> _N_ctx_91806;

		internal option<string> _N_current_fun_name_91804;

		internal string _N_indentation_91802;

		internal StringBuilder _N_result_91800;

		internal _N_closureOf_SprintTyMatch_91795()
		{
		}
	}

	private sealed class _N_closureOf_SprintTyExpr_92330
	{
		internal option<Typer> _N_ctx_92343;

		internal option<string> _N_current_fun_name_92341;

		internal string _N_indentation_92339;

		internal StringBuilder _N_result_92337;

		internal FunctionVoid<TExpr> _N_recurse_92335;

		internal _N_closureOf_SprintTyExpr_92330()
		{
		}
	}

	private sealed class _N_recurse__92352 : FunctionVoid<TExpr>
	{
		[SpecialName]
		private _N_closureOf_SprintTyExpr_92330 _N_SprintTyExpr_closure_92356;

		public _N_recurse__92352(_N_closureOf_SprintTyExpr_92330 _N_SprintTyExpr_closure_92356)
		{
			this._N_SprintTyExpr_closure_92356 = _N_SprintTyExpr_closure_92356;
		}

		[SpecialName]
		public sealed override void apply_void(TExpr expr)
		{
			SprintTyExpr(_N_SprintTyExpr_closure_92356._N_ctx_92343, expr, _N_SprintTyExpr_closure_92356._N_current_fun_name_92341, is_top_level: false, _N_SprintTyExpr_closure_92356._N_indentation_92339, _N_SprintTyExpr_closure_92356._N_result_92337);
		}
	}

	private sealed class _N__N_lambda__92144__92396 : FunctionVoid<Parm>
	{
		[SpecialName]
		private _N_closureOf_SprintTyExpr_92330 _N_SprintTyExpr_closure_92400;

		public _N__N_lambda__92144__92396(_N_closureOf_SprintTyExpr_92330 _N_SprintTyExpr_closure_92400)
		{
			this._N_SprintTyExpr_closure_92400 = _N_SprintTyExpr_closure_92400;
		}

		[SpecialName]
		public sealed override void apply_void(Parm parm)
		{
			_N_SprintTyExpr_closure_92400._N_recurse_92335.apply_void(parm.expr);
		}
	}

	private sealed class _N_printParam__92449 : Function<TParameter, string>
	{
		[SpecialName]
		private _N_closureOf_SprintTyExpr_92330 _N_SprintTyExpr_closure_92453;

		public _N_printParam__92449(_N_closureOf_SprintTyExpr_92330 _N_SprintTyExpr_closure_92453)
		{
			this._N_SprintTyExpr_closure_92453 = _N_SprintTyExpr_closure_92453;
		}

		[SpecialName]
		public sealed override string apply(TParameter parm)
		{
			option<TExpr> default_value = parm.default_value;
			object obj;
			if (default_value is option<TExpr>.Some)
			{
				TExpr val = ((option<TExpr>.Some)default_value).val;
				obj = " = " + SprintTyExpr(_N_SprintTyExpr_closure_92453._N_ctx_92343, val);
			}
			else
			{
				obj = "";
			}
			string text = (string)obj;
			return Convert.ToString(parm.name) + " : " + Convert.ToString(parm.ty) + Convert.ToString(text);
		}
	}

	private sealed class _N_static_proxy_92691 : Function<TypeVar, PExpr>
	{
		[SpecialName]
		public static readonly _N_static_proxy_92691 single_instance = new _N_static_proxy_92691();

		[SpecialName]
		public sealed override PExpr apply(TypeVar _N_sp_parm_92698)
		{
			return TyVarToParseTree(_N_sp_parm_92698);
		}

		private _N_static_proxy_92691()
		{
		}
	}

	private static void UpdateLocation(Name name, Location loc)
	{
		if (loc != Location.Default)
		{
			name.Location = loc;
		}
	}

	private static void PrintName(Name name, LocatableTextWriter writer)
	{
		Location loc = writer.Loc;
		writer.Write(name.Id);
		UpdateLocation(name, loc + writer.Loc);
	}

	internal static void SprintExpr(option<Typer> ctx, PExpr expr, string indentation, LocatableTextWriter acc)
	{
		bool flag = false;
		_N_closureOf_SprintExpr_91161 n_closureOf_SprintExpr_ = new _N_closureOf_SprintExpr_91161();
		n_closureOf_SprintExpr_._N_ctx_91174 = ctx;
		n_closureOf_SprintExpr_._N_indentation_91172 = indentation;
		n_closureOf_SprintExpr_._N_acc_91170 = acc;
		PExpr pExpr;
		if (n_closureOf_SprintExpr_._N_ctx_91174 is option<Typer>.Some)
		{
			Typer val = ((option<Typer>.Some)n_closureOf_SprintExpr_._N_ctx_91174).val;
			pExpr = MacroRegistry.expand_macro(val, expr).Field0;
		}
		else
		{
			pExpr = expr;
		}
		PExpr pExpr2 = pExpr;
		n_closureOf_SprintExpr_._N_print_funparm_91168 = new _N_print_funparm__91189(n_closureOf_SprintExpr_);
		Location loc = n_closureOf_SprintExpr_._N_acc_91170.Loc;
		flag = true;
		if (pExpr2 == null)
		{
			n_closureOf_SprintExpr_._N_acc_91170.Write("(NULL)");
		}
		else
		{
			string text;
			switch (PExpr._N_GetVariantCodeSafe(pExpr2))
			{
			default:
				throw new MatchFailureException();
			case 0:
				n_closureOf_SprintExpr_._N_acc_91170.Write("_ ");
				break;
			case 1:
				n_closureOf_SprintExpr_._N_acc_91170.Write("void ");
				break;
			case 2:
			{
				PExpr body3 = ((PExpr.As)pExpr2).pat;
				Splicable name = ((PExpr.As)pExpr2).name;
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write(" as ");
				_N_sprint_ss_91225(n_closureOf_SprintExpr_, name);
				break;
			}
			case 3:
			{
				PExpr args = ((PExpr.Is)pExpr2).pat;
				PExpr body3 = ((PExpr.Is)pExpr2).ty;
				n_closureOf_SprintExpr_._N_acc_91170.Write("(");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, args, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write(" is ");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write(")");
				break;
			}
			case 4:
			{
				PExpr body3 = ((PExpr.Where)pExpr2).name;
				PExpr args = ((PExpr.Where)pExpr2).fields;
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write(" where ");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, args, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				break;
			}
			case 5:
			{
				PExpr body3 = ((PExpr.Match)pExpr2).expr;
				list<MatchCase> l7 = ((PExpr.Match)pExpr2).cases;
				n_closureOf_SprintExpr_._N_acc_91170.Write("match (");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write(")" + Environment.NewLine + Convert.ToString(n_closureOf_SprintExpr_._N_indentation_91172));
				FunctionVoid<MatchCase> f2 = new _N_print_case__91300(n_closureOf_SprintExpr_);
				n_closureOf_SprintExpr_._N_acc_91170.Write(Convert.ToString(n_closureOf_SprintExpr_._N_indentation_91172) + "{");
				NList.Iter(l7, f2);
				n_closureOf_SprintExpr_._N_acc_91170.Write(Environment.NewLine + Convert.ToString(n_closureOf_SprintExpr_._N_indentation_91172) + "}");
				break;
			}
			case 6:
			{
				Name body4 = ((PExpr.Ref)pExpr2).name;
				PrintName(body4, n_closureOf_SprintExpr_._N_acc_91170);
				break;
			}
			case 7:
			{
				PExpr body3 = ((PExpr.Member)pExpr2).obj;
				Splicable name = ((PExpr.Member)pExpr2).member;
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write(".");
				_N_sprint_ss_91225(n_closureOf_SprintExpr_, name);
				break;
			}
			case 8:
			{
				PExpr body3;
				if (((PExpr.Call)pExpr2).func is PExpr.Member)
				{
					if (((PExpr.Member)((PExpr.Call)pExpr2).func).obj is PExpr.Ref)
					{
						if (((PExpr.Ref)((PExpr.Member)((PExpr.Call)pExpr2).func).obj).name.idl == "list" && ((PExpr.Member)((PExpr.Call)pExpr2).func).member is Splicable.Name && ((Splicable.Name)((PExpr.Member)((PExpr.Call)pExpr2).func).member).body.idl == "Cons" && ((PExpr.Call)pExpr2).parms is list<PExpr>.Cons && ((list<PExpr>.Cons)((PExpr.Call)pExpr2).parms).tl is list<PExpr>.Cons)
						{
							PExpr args = ((list<PExpr>.Cons)((PExpr.Call)pExpr2).parms).hd;
							if ((object)((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)pExpr2).parms).tl).tl == list<PExpr>.Nil._N_constant_object)
							{
								body3 = ((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)pExpr2).parms).tl).hd;
								SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, args, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
								n_closureOf_SprintExpr_._N_acc_91170.Write(" :: ");
								SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
								break;
							}
						}
					}
					else if (((PExpr.Member)((PExpr.Call)pExpr2).func).obj is PExpr.Member && ((PExpr.Member)((PExpr.Member)((PExpr.Call)pExpr2).func).obj).obj is PExpr.Ref && ((PExpr.Ref)((PExpr.Member)((PExpr.Member)((PExpr.Call)pExpr2).func).obj).obj).name.idl == "Nemerle" && ((PExpr.Member)((PExpr.Member)((PExpr.Call)pExpr2).func).obj).member is Splicable.Name && ((Splicable.Name)((PExpr.Member)((PExpr.Member)((PExpr.Call)pExpr2).func).obj).member).body.idl == "IO" && ((PExpr.Member)((PExpr.Call)pExpr2).func).member is Splicable.Name && ((Splicable.Name)((PExpr.Member)((PExpr.Call)pExpr2).func).member).body.idl == "sprint" && ((PExpr.Call)pExpr2).parms is list<PExpr>.Cons && (object)((list<PExpr>.Cons)((PExpr.Call)pExpr2).parms).tl == list<PExpr>.Nil._N_constant_object)
					{
						body3 = ((list<PExpr>.Cons)((PExpr.Call)pExpr2).parms).hd;
						n_closureOf_SprintExpr_._N_acc_91170.Write("$");
						SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
						break;
					}
				}
				else if (((PExpr.Call)pExpr2).func is PExpr.Ref)
				{
					if (((PExpr.Ref)((PExpr.Call)pExpr2).func).name.idl == "with")
					{
						if (((PExpr.Call)pExpr2).parms is list<PExpr>.Cons && ((list<PExpr>.Cons)((PExpr.Call)pExpr2).parms).tl is list<PExpr>.Cons)
						{
							PExpr args = ((list<PExpr>.Cons)((PExpr.Call)pExpr2).parms).hd;
							if ((object)((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)pExpr2).parms).tl).tl == list<PExpr>.Nil._N_constant_object)
							{
								body3 = ((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)pExpr2).parms).tl).hd;
								SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, args, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
								n_closureOf_SprintExpr_._N_acc_91170.Write(" with ");
								SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
								break;
							}
						}
					}
					else if (((PExpr.Ref)((PExpr.Call)pExpr2).func).name.idl == "when")
					{
						if (((PExpr.Call)pExpr2).parms is list<PExpr>.Cons && ((list<PExpr>.Cons)((PExpr.Call)pExpr2).parms).tl is list<PExpr>.Cons)
						{
							PExpr args = ((list<PExpr>.Cons)((PExpr.Call)pExpr2).parms).hd;
							if ((object)((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)pExpr2).parms).tl).tl == list<PExpr>.Nil._N_constant_object)
							{
								body3 = ((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)pExpr2).parms).tl).hd;
								SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, args, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
								n_closureOf_SprintExpr_._N_acc_91170.Write(" when ");
								SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
								break;
							}
						}
					}
					else if (((PExpr.Ref)((PExpr.Call)pExpr2).func).name.idl == "in" && ((PExpr.Call)pExpr2).parms is list<PExpr>.Cons && ((list<PExpr>.Cons)((PExpr.Call)pExpr2).parms).tl is list<PExpr>.Cons)
					{
						body3 = ((list<PExpr>.Cons)((PExpr.Call)pExpr2).parms).hd;
						if ((object)((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)pExpr2).parms).tl).tl == list<PExpr>.Nil._N_constant_object)
						{
							PExpr args = ((list<PExpr>.Cons)((list<PExpr>.Cons)((PExpr.Call)pExpr2).parms).tl).hd;
							SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
							n_closureOf_SprintExpr_._N_acc_91170.Write(" in ");
							SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, args, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
							break;
						}
					}
				}
				body3 = ((PExpr.Call)pExpr2).func;
				list<PExpr> list = ((PExpr.Call)pExpr2).parms;
				FunctionVoid<PExpr> f = new _N_print_parm__91317(n_closureOf_SprintExpr_);
				if (body3 is PExpr.Ref && list is list<PExpr>.Cons)
				{
					Name body4 = ((PExpr.Ref)body3).name;
					if ((object)((list<PExpr>.Cons)list).tl == list<PExpr>.Nil._N_constant_object)
					{
						PExpr args = ((list<PExpr>.Cons)list).hd;
						if (LexerBase.IsOperator(body4.Id))
						{
							n_closureOf_SprintExpr_._N_acc_91170.Write(body4.Id);
							f.apply_void(args);
							break;
						}
					}
					else if (((list<PExpr>.Cons)list).tl is list<PExpr>.Cons)
					{
						body4 = ((PExpr.Ref)body3).name;
						PExpr hd = ((list<PExpr>.Cons)list).hd;
						if ((object)((list<PExpr>.Cons)((list<PExpr>.Cons)list).tl).tl == list<PExpr>.Nil._N_constant_object)
						{
							PExpr args = ((list<PExpr>.Cons)((list<PExpr>.Cons)list).tl).hd;
							if (LexerBase.IsOperator(body4.Id))
							{
								f.apply_void(hd);
								n_closureOf_SprintExpr_._N_acc_91170.Write(string.Concat(" " + body4.Id, " "));
								f.apply_void(args);
								break;
							}
						}
					}
				}
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write("(");
				SeparatedCalls(", ", list, f, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write(")");
				break;
			}
			case 9:
			{
				PExpr body3 = ((PExpr.GenericSpecifier)pExpr2).func;
				list<PExpr> list = ((PExpr.GenericSpecifier)pExpr2).generic_parms;
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write(".[");
				list<PExpr> l = list;
				FunctionVoid<PExpr> f = new _N__N_lambda__91102__91336(n_closureOf_SprintExpr_);
				SeparatedCalls(", ", l, f, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write("]");
				break;
			}
			case 10:
			{
				list<PExpr> list = ((PExpr.ListLiteral)pExpr2).elements;
				n_closureOf_SprintExpr_._N_acc_91170.Write("[");
				list<PExpr> l2 = list;
				FunctionVoid<PExpr> f = new _N__N_lambda__91042__91345(n_closureOf_SprintExpr_);
				SeparatedCalls(", ", l2, f, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write("]");
				break;
			}
			case 11:
			{
				if (((PExpr.Assign)pExpr2).target is PExpr.Wildcard && ((PExpr.Assign)pExpr2).source is PExpr.Literal)
				{
					if (((PExpr.Literal)((PExpr.Assign)pExpr2).source).val is Literal.String)
					{
						text = ((Literal.String)((PExpr.Literal)((PExpr.Assign)pExpr2).source).val).val;
					}
					else
					{
						Literal val2 = ((PExpr.Literal)((PExpr.Assign)pExpr2).source).val;
						text = val2.ToString();
					}
					goto IL_0ffb;
				}
				PExpr body3 = ((PExpr.Assign)pExpr2).target;
				PExpr args = ((PExpr.Assign)pExpr2).source;
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write(" = ");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, args, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				break;
			}
			case 12:
			{
				PExpr args = ((PExpr.DefMutable)pExpr2).name;
				PExpr body3 = ((PExpr.DefMutable)pExpr2).val;
				n_closureOf_SprintExpr_._N_acc_91170.Write("mutable ");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, args, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				if (body3 != null)
				{
					n_closureOf_SprintExpr_._N_acc_91170.Write(" = ");
					SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				}
				break;
			}
			case 13:
			{
				if (((PExpr.Define)pExpr2).pattern is PExpr.Ref && ((PExpr.Ref)((PExpr.Define)pExpr2).pattern).name.idl == "_N_wildcard_3404" && ((PExpr.Define)pExpr2).val is PExpr.Literal && ((PExpr.Literal)((PExpr.Define)pExpr2).val).val is Literal.String)
				{
					text = ((Literal.String)((PExpr.Literal)((PExpr.Define)pExpr2).val).val).val;
					goto IL_0ffb;
				}
				PExpr body3 = ((PExpr.Define)pExpr2).pattern;
				PExpr args = ((PExpr.Define)pExpr2).val;
				n_closureOf_SprintExpr_._N_acc_91170.Write("def ");
				if (body3 is PExpr.Ref || body3 is PExpr.Tuple)
				{
					SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				}
				else
				{
					n_closureOf_SprintExpr_._N_acc_91170.Write("(");
					SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
					n_closureOf_SprintExpr_._N_acc_91170.Write(")");
				}
				n_closureOf_SprintExpr_._N_acc_91170.Write(" = ");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, args, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				break;
			}
			case 14:
			{
				list<Function_decl> l8 = ((PExpr.DefFunctions)pExpr2).funs;
				FunctionVoid<Function_decl> f3 = new _N_print_fun__91360(n_closureOf_SprintExpr_);
				n_closureOf_SprintExpr_._N_acc_91170.Write("def ");
				SeparatedCalls("\nand ", l8, f3, n_closureOf_SprintExpr_._N_acc_91170);
				break;
			}
			case 15:
			{
				Function_decl decl = ((PExpr.Lambda)pExpr2).decl;
				n_closureOf_SprintExpr_._N_acc_91170.Write("fun ");
				if (!decl.header.TypeParameters.tyvars.IsEmpty())
				{
					n_closureOf_SprintExpr_._N_acc_91170.Write(decl.header.TypeParameters.tyvars.ToString());
				}
				n_closureOf_SprintExpr_._N_acc_91170.Write(" (");
				_N_print_funparms_91218(n_closureOf_SprintExpr_, decl.header.Parameters);
				n_closureOf_SprintExpr_._N_acc_91170.Write(") ");
				n_closureOf_SprintExpr_._N_acc_91170.Write(": ");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, decl.header.ReturnType, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write(" ");
				_N_print_tconstraints_91180(n_closureOf_SprintExpr_, decl.header.TypeParameters.constraints);
				n_closureOf_SprintExpr_._N_acc_91170.Write("\n");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, decl.body, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				break;
			}
			case 16:
			{
				PExpr body3 = ((PExpr.Throw)pExpr2).exn;
				n_closureOf_SprintExpr_._N_acc_91170.Write("throw ");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				break;
			}
			case 17:
			{
				PExpr body3 = ((PExpr.Try)pExpr2).body;
				list<TryCase> list2 = ((PExpr.Try)pExpr2).cases;
				n_closureOf_SprintExpr_._N_acc_91170.Write("try" + Environment.NewLine + Convert.ToString(n_closureOf_SprintExpr_._N_indentation_91172) + "{" + Environment.NewLine + Convert.ToString(n_closureOf_SprintExpr_._N_indentation_91172) + "  ");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172 + "  ", n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write(Environment.NewLine + Convert.ToString(n_closureOf_SprintExpr_._N_indentation_91172) + "}" + Environment.NewLine + Convert.ToString(n_closureOf_SprintExpr_._N_indentation_91172) + "catch" + Environment.NewLine + Convert.ToString(n_closureOf_SprintExpr_._N_indentation_91172) + "{" + Environment.NewLine + Convert.ToString(n_closureOf_SprintExpr_._N_indentation_91172));
				list2 = list2;
				while (list2 is list<TryCase>.Cons)
				{
					TryCase hd2 = ((list<TryCase>.Cons)list2).hd;
					list2 = ((list<TryCase>.Cons)list2).tl;
					_N_print_case_91400(n_closureOf_SprintExpr_, hd2);
					list2 = list2;
				}
				n_closureOf_SprintExpr_._N_acc_91170.Write(Environment.NewLine + Convert.ToString(n_closureOf_SprintExpr_._N_indentation_91172) + "}");
				break;
			}
			case 18:
			{
				PExpr args = ((PExpr.TryFinally)pExpr2).body;
				PExpr body3 = ((PExpr.TryFinally)pExpr2).handler;
				n_closureOf_SprintExpr_._N_acc_91170.Write("try" + Environment.NewLine + Convert.ToString(n_closureOf_SprintExpr_._N_indentation_91172) + "{" + Environment.NewLine);
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, args, n_closureOf_SprintExpr_._N_indentation_91172 + "  ", n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write(Environment.NewLine + Convert.ToString(n_closureOf_SprintExpr_._N_indentation_91172) + "}" + Environment.NewLine + Convert.ToString(n_closureOf_SprintExpr_._N_indentation_91172) + "finally" + Environment.NewLine + Convert.ToString(n_closureOf_SprintExpr_._N_indentation_91172) + "{" + Environment.NewLine + Convert.ToString(n_closureOf_SprintExpr_._N_indentation_91172) + "  ");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172 + "  ", n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write(Environment.NewLine + Convert.ToString(n_closureOf_SprintExpr_._N_indentation_91172) + "}");
				break;
			}
			case 19:
			{
				Literal val2 = ((PExpr.Literal)pExpr2).val;
				n_closureOf_SprintExpr_._N_acc_91170.Write(val2.ToString());
				break;
			}
			case 20:
				n_closureOf_SprintExpr_._N_acc_91170.Write("this");
				break;
			case 21:
				if (((PExpr.Base)pExpr2).ty is option<PExpr>.Some)
				{
					PExpr body3 = ((option<PExpr>.Some)((PExpr.Base)pExpr2).ty).val;
					n_closureOf_SprintExpr_._N_acc_91170.Write("(base : " + Convert.ToString(body3) + ")");
				}
				else
				{
					n_closureOf_SprintExpr_._N_acc_91170.Write("base");
				}
				break;
			case 22:
			{
				PExpr body3 = ((PExpr.Typeof)pExpr2).ty;
				n_closureOf_SprintExpr_._N_acc_91170.Write("typeof (");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write(")");
				break;
			}
			case 23:
			{
				PExpr body3 = ((PExpr.TypeConversion)pExpr2).expr;
				PExpr args = ((PExpr.TypeConversion)pExpr2).ty;
				n_closureOf_SprintExpr_._N_acc_91170.Write("(");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write(" :> ");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, args, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write(")");
				break;
			}
			case 24:
			{
				PExpr args = ((PExpr.TypeEnforcement)pExpr2).expr;
				PExpr body3 = ((PExpr.TypeEnforcement)pExpr2).ty;
				n_closureOf_SprintExpr_._N_acc_91170.Write("(");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, args, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write(" : ");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write(")");
				break;
			}
			case 25:
			{
				list<PExpr> list = ((PExpr.Sequence)pExpr2).body;
				n_closureOf_SprintExpr_._N_acc_91170.Write(Environment.NewLine + Convert.ToString(n_closureOf_SprintExpr_._N_indentation_91172) + "{");
				list<PExpr> l6 = list;
				FunctionVoid<PExpr> f = new _N__N_lambda__91078__91418(n_closureOf_SprintExpr_);
				SeparatedCalls(";", l6, f, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write(Environment.NewLine + Convert.ToString(n_closureOf_SprintExpr_._N_indentation_91172) + "}");
				break;
			}
			case 26:
			{
				list<PExpr> list = ((PExpr.Tuple)pExpr2).args;
				n_closureOf_SprintExpr_._N_acc_91170.Write("(");
				list<PExpr> l5 = list;
				FunctionVoid<PExpr> f = new _N__N_lambda__91084__91427(n_closureOf_SprintExpr_);
				SeparatedCalls(", ", l5, f, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write(")");
				break;
			}
			case 27:
			{
				PExpr body3;
				if (((PExpr.Array)pExpr2).rank is PExpr.Literal && ((PExpr.Literal)((PExpr.Array)pExpr2).rank).val is Literal.Integer && ((Literal.Integer)((PExpr.Literal)((PExpr.Array)pExpr2).rank).val).val == 1 && !((Literal.Integer)((PExpr.Literal)((PExpr.Array)pExpr2).rank).val).is_negative)
				{
					body3 = ((PExpr.Array)pExpr2).args;
					n_closureOf_SprintExpr_._N_acc_91170.Write("array ");
					SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
					break;
				}
				body3 = ((PExpr.Array)pExpr2).rank;
				PExpr args = ((PExpr.Array)pExpr2).args;
				n_closureOf_SprintExpr_._N_acc_91170.Write("array .[");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write("] ");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, args, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				break;
			}
			case 28:
			{
				list<PExpr> list = ((PExpr.EmptyArray)pExpr2).sizes;
				n_closureOf_SprintExpr_._N_acc_91170.Write("array (");
				list<PExpr> l4 = list;
				FunctionVoid<PExpr> f = new _N__N_lambda__91090__91436(n_closureOf_SprintExpr_);
				SeparatedCalls(", ", l4, f, n_closureOf_SprintExpr_._N_acc_91170);
				break;
			}
			case 29:
			{
				PExpr body3 = ((PExpr.Indexer)pExpr2).obj;
				list<PExpr> list = ((PExpr.Indexer)pExpr2).args;
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write("[");
				list<PExpr> l3 = list;
				FunctionVoid<PExpr> f = new _N__N_lambda__91109__91445(n_closureOf_SprintExpr_);
				SeparatedCalls(", ", l3, f, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write("]");
				break;
			}
			case 30:
			{
				PExpr body3 = ((PExpr.ParmByRef)pExpr2).parm;
				n_closureOf_SprintExpr_._N_acc_91170.Write("ref ");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				break;
			}
			case 31:
			{
				PExpr body3 = ((PExpr.ParmOut)pExpr2).parm;
				n_closureOf_SprintExpr_._N_acc_91170.Write("out ");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				break;
			}
			case 32:
			{
				object msg = ((PExpr.Error)pExpr2).msg;
				n_closureOf_SprintExpr_._N_acc_91170.Write("<# Error: " + Convert.ToString(msg) + " #>");
				break;
			}
			case 33:
			{
				NamespaceTree.Node ns = ((PExpr.MacroCall)pExpr2).ns;
				list<SyntaxElement> n_parms_left_ = ((PExpr.MacroCall)pExpr2).parms;
				flag = false;
				NamespaceTree.TypeInfoCache value = ns.Value;
				if (value is NamespaceTree.TypeInfoCache.MacroCall)
				{
					IMacro m = ((NamespaceTree.TypeInfoCache.MacroCall)value).m;
					GrammarElement field = m.SyntaxExtension().Field0;
					n_closureOf_SprintExpr_._N_parms_left_91166 = n_parms_left_;
					n_closureOf_SprintExpr_._N_acc_91170.Write(Convert.ToString(field) + " ");
					field = field.Next;
					if (field != null)
					{
						_N_print_gel_91464(n_closureOf_SprintExpr_, field);
					}
				}
				else
				{
					n_closureOf_SprintExpr_._N_acc_91170.Write("macro_call");
				}
				break;
			}
			case 34:
			{
				SyntaxElement body5 = ((PExpr.Quoted)pExpr2).body;
				n_closureOf_SprintExpr_._N_acc_91170.Write("<[ ");
				n_closureOf_SprintExpr_._N_acc_91170.Write(body5.ToString());
				n_closureOf_SprintExpr_._N_acc_91170.Write(" ]>");
				break;
			}
			case 35:
			{
				PExpr body3 = ((PExpr.Spliced)pExpr2).body;
				n_closureOf_SprintExpr_._N_acc_91170.Write("$(");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				n_closureOf_SprintExpr_._N_acc_91170.Write(")");
				break;
			}
			case 36:
			{
				Name body4 = ((PExpr.ToComplete)pExpr2).body;
				n_closureOf_SprintExpr_._N_acc_91170.Write("<COMPLETE '" + Convert.ToString(body4.Id) + "'>");
				break;
			}
			case 37:
			{
				PExpr body3 = ((PExpr.Ellipsis)pExpr2).body;
				n_closureOf_SprintExpr_._N_acc_91170.Write("..");
				SprintExpr(n_closureOf_SprintExpr_._N_ctx_91174, body3, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170);
				break;
			}
			case 38:
			{
				TExpr body2 = ((PExpr.Typed)pExpr2).body;
				int length = n_closureOf_SprintExpr_._N_acc_91170.Sbuilder.Length;
				SprintTyExpr(n_closureOf_SprintExpr_._N_ctx_91174, body2, option<string>.None._N_constant_object, is_top_level: false, n_closureOf_SprintExpr_._N_indentation_91172, n_closureOf_SprintExpr_._N_acc_91170.Sbuilder);
				n_closureOf_SprintExpr_._N_acc_91170.MoveLocation(length);
				break;
			}
			case 40:
			{
				TypeVar body = ((PExpr.TypedType)pExpr2).body;
				n_closureOf_SprintExpr_._N_acc_91170.Write(body.ToString());
				break;
			}
			case 39:
				break;
				IL_0ffb:
				n_closureOf_SprintExpr_._N_acc_91170.Write(string.Concat("/* " + text, " */"));
				break;
			}
		}
		if (flag)
		{
			n_closureOf_SprintExpr_._N_acc_91170.FetchUpdatedLocation(pExpr2, loc);
		}
	}

	[Macro("Nemerle.Assertions.Ensures:method:postadd", 0, "value != null")]
	public static string SprintExpr(option<Typer> ctx, PExpr expr)
	{
		LocatableTextWriter locatableTextWriter = new LocatableTextWriter(new StringBuilder());
		SprintExpr(ctx, expr, "", locatableTextWriter);
		string text = locatableTextWriter.ToString();
		if (!(text != null))
		{
			throw new AssertionException("ncc\\misc\\PrettyPrint.n", 513, "value != null", "The ``Ensures'' contract of method `SprintExpr' has been violated.".ToString());
		}
		return text;
	}

	public static void PrintExpr(option<Typer> ctx, PExpr expr)
	{
		string value = SprintExpr(ctx, expr);
		Console.Write(value);
		Console.Write("\n");
	}

	private static void SeparatedCalls<T>(string sep, list<T> l, FunctionVoid<T> f, LocatableTextWriter acc)
	{
		T val = default(T);
		list<T> list = l;
		while (list is list<T>.Cons)
		{
			if ((object)((list<T>.Cons)list).tl == list<T>.Nil._N_constant_object)
			{
				val = ((list<T>.Cons)list).hd;
				f.apply_void(val);
				return;
			}
			val = ((list<T>.Cons)list).hd;
			list = ((list<T>.Cons)list).tl;
			f.apply_void(val);
			acc.Write(sep);
			list = list;
		}
		if ((object)list == list<T>.Nil._N_constant_object)
		{
			return;
		}
		throw new MatchFailureException();
	}

	public static string SprintTyMatch(option<Typer> ctx, TExpr expr, list<Match_case> match_cases)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = stringBuilder.Append("\n");
		SprintTyMatch(ctx, expr, option<string>.None._N_constant_object, match_cases, "", stringBuilder);
		stringBuilder2 = stringBuilder.Append("\n");
		return stringBuilder.ToString();
	}

	public static string SprintPattern(Pattern pattern)
	{
		_N_closureOf_SprintPattern_91609 n_closureOf_SprintPattern_ = new _N_closureOf_SprintPattern_91609();
		n_closureOf_SprintPattern_._N_result_91614 = new StringBuilder();
		_N_print_pattern_91624(n_closureOf_SprintPattern_, pattern);
		return n_closureOf_SprintPattern_._N_result_91614.ToString();
	}

	public static void SprintTyMatch(option<Typer> ctx, TExpr expr, option<string> current_fun_name, list<Match_case> match_cases, string indentation, StringBuilder result)
	{
		_N_closureOf_SprintTyMatch_91795 n_closureOf_SprintTyMatch_ = new _N_closureOf_SprintTyMatch_91795();
		n_closureOf_SprintTyMatch_._N_ctx_91806 = ctx;
		n_closureOf_SprintTyMatch_._N_current_fun_name_91804 = current_fun_name;
		n_closureOf_SprintTyMatch_._N_indentation_91802 = indentation;
		n_closureOf_SprintTyMatch_._N_result_91800 = result;
		bool flag = _N_expr_is_bool_91885(expr);
		int num;
		if (match_cases is list<Match_case>.Cons && ((list<Match_case>.Cons)match_cases).tl is list<Match_case>.Cons)
		{
			Match_case hd = ((list<Match_case>.Cons)match_cases).hd;
			if ((object)((list<Match_case>.Cons)((list<Match_case>.Cons)match_cases).tl).tl == list<Match_case>.Nil._N_constant_object)
			{
				Match_case hd2 = ((list<Match_case>.Cons)((list<Match_case>.Cons)match_cases).tl).hd;
				list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>> patterns = hd.patterns;
				bool flag2 = ((patterns is list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons && ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field0 is Pattern.Literal && ((Pattern.Literal)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field0).lit is Literal.Bool && ((Literal.Bool)((Pattern.Literal)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field0).lit).val && ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field1 is TExpr.Literal && ((TExpr.Literal)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field1).val is Literal.Bool && ((Literal.Bool)((TExpr.Literal)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field1).val).val && (object)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field2 == list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Nil._N_constant_object && (object)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).tl == list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Nil._N_constant_object) ? true : false);
				patterns = hd.patterns;
				bool flag3 = ((patterns is list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons && ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field0 is Pattern.Literal && ((Pattern.Literal)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field0).lit is Literal.Bool && !((Literal.Bool)((Pattern.Literal)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field0).lit).val && ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field1 is TExpr.Literal && ((TExpr.Literal)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field1).val is Literal.Bool && ((Literal.Bool)((TExpr.Literal)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field1).val).val && (object)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field2 == list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Nil._N_constant_object && (object)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).tl == list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Nil._N_constant_object) ? true : false);
				patterns = hd.patterns;
				bool flag4 = ((patterns is list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons && ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field0 is Pattern.As && ((Pattern.As)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field0).pat is Pattern.HasType && ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field1 is TExpr.Literal && ((TExpr.Literal)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field1).val is Literal.Bool && ((Literal.Bool)((TExpr.Literal)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field1).val).val && (object)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field2 == list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Nil._N_constant_object && (object)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).tl == list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Nil._N_constant_object) ? true : false);
				patterns = hd2.patterns;
				bool flag5 = ((patterns is list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons && ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field0 is Pattern.Wildcard && ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field1 is TExpr.Literal && ((TExpr.Literal)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field1).val is Literal.Bool && ((Literal.Bool)((TExpr.Literal)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field1).val).val && (object)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field2 == list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Nil._N_constant_object && (object)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).tl == list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Nil._N_constant_object) ? true : false);
				bool flag6 = _N_expr_is_true_91901(hd.body);
				bool flag7 = _N_expr_is_false_91909(hd.body);
				TExpr body = hd2.body;
				bool flag8 = ((body is TExpr.Literal && ((TExpr.Literal)body).val is Literal.Void) ? true : false);
				bool flag9 = _N_expr_is_true_91901(hd2.body);
				bool flag10 = _N_expr_is_false_91909(hd2.body);
				bool flag11 = _N_expr_is_bool_91885(hd2.body);
				int length = hd.patterns.Length;
				int length2 = hd.patterns.Length;
				bool flag12 = flag && flag2 && flag5;
				bool flag13 = flag && flag2 && flag5 && flag8;
				flag8 = flag && flag3 && flag5 && flag8;
				bool flag14 = flag && flag3 && flag7 && flag5 && flag11;
				flag11 = flag && flag2 && flag6 && flag5 && flag11;
				flag4 = flag6 && flag4 && flag5 && flag10;
				bool flag15 = flag6 && flag5 && flag10 && length == 1 && length2 == 1;
				if ((flag && flag2 && flag6 && flag5 && flag10) || (flag3 && flag7 && flag5 && flag9))
				{
					_N_append_91809(n_closureOf_SprintTyMatch_, "(");
					_N_recurse_91823(n_closureOf_SprintTyMatch_, expr);
					_N_append_91809(n_closureOf_SprintTyMatch_, ")");
					num = 1;
				}
				else if (flag11 || flag14)
				{
					_N_append_91809(n_closureOf_SprintTyMatch_, "(");
					_N_recurse_91823(n_closureOf_SprintTyMatch_, expr);
					_N_append_91809(n_closureOf_SprintTyMatch_, (!flag11) ? " && " : " || ");
					_N_recurse_91823(n_closureOf_SprintTyMatch_, hd2.body);
					_N_append_91809(n_closureOf_SprintTyMatch_, ")");
					num = 1;
				}
				else if (flag13 || flag8)
				{
					_N_append_91809(n_closureOf_SprintTyMatch_, ((!flag13) ? "unless" : "when") + " (");
					_N_recurse_91823(n_closureOf_SprintTyMatch_, expr);
					_N_append_91809(n_closureOf_SprintTyMatch_, ") {\n");
					_N_recurse_and_short_indent_91837(n_closureOf_SprintTyMatch_, hd.body);
					_N_append_91809(n_closureOf_SprintTyMatch_, string.Concat("\n" + n_closureOf_SprintTyMatch_._N_indentation_91802, "}"));
					num = 1;
				}
				else if (flag12)
				{
					_N_append_91809(n_closureOf_SprintTyMatch_, "if (");
					_N_recurse_91823(n_closureOf_SprintTyMatch_, expr);
					_N_append_91809(n_closureOf_SprintTyMatch_, ") {\n");
					_N_recurse_and_short_indent_91837(n_closureOf_SprintTyMatch_, hd.body);
					_N_append_91809(n_closureOf_SprintTyMatch_, string.Concat(string.Concat(string.Concat("\n" + n_closureOf_SprintTyMatch_._N_indentation_91802, "}\n"), n_closureOf_SprintTyMatch_._N_indentation_91802), "else {\n"));
					_N_recurse_and_short_indent_91837(n_closureOf_SprintTyMatch_, hd2.body);
					_N_append_91809(n_closureOf_SprintTyMatch_, string.Concat("\n" + n_closureOf_SprintTyMatch_._N_indentation_91802, "}"));
					num = 1;
				}
				else
				{
					if (flag4)
					{
						_N_append_91809(n_closureOf_SprintTyMatch_, "(");
						_N_recurse_91823(n_closureOf_SprintTyMatch_, expr);
						_N_append_91809(n_closureOf_SprintTyMatch_, " is ");
						patterns = hd.patterns;
						if (patterns is list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons && ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field0 is Pattern.As && ((Pattern.As)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field0).pat is Pattern.HasType && (object)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field2 == list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Nil._N_constant_object)
						{
							FixedType typ = ((Pattern.HasType)((Pattern.As)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field0).pat).typ;
							if ((object)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).tl == list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Nil._N_constant_object)
							{
								_N_append_91809(n_closureOf_SprintTyMatch_, strip_nemerle_core_dot_prefix(typ.ToString()));
								_N_append_91809(n_closureOf_SprintTyMatch_, ")");
								num = 1;
								goto IL_0bd4;
							}
						}
						if (!Message.SeenError)
						{
							string text = "SprintTyMatch: is_is".ToString();
							Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
						}
						throw new AssertionException("ncc\\misc\\PrettyPrint.n", 827, "", "SprintTyMatch: is_is");
					}
					if (flag15)
					{
						_N_append_91809(n_closureOf_SprintTyMatch_, "(");
						_N_recurse_91823(n_closureOf_SprintTyMatch_, expr);
						_N_append_91809(n_closureOf_SprintTyMatch_, " matches ");
						patterns = hd.patterns;
						if (patterns is list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons && (object)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field2 == list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Nil._N_constant_object)
						{
							Pattern field = ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field0;
							if ((object)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).tl == list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Nil._N_constant_object)
							{
								_N_print_pattern_91844(n_closureOf_SprintTyMatch_, field);
								_N_append_91809(n_closureOf_SprintTyMatch_, ")");
								num = 1;
								goto IL_0bd4;
							}
						}
						if (!Message.SeenError)
						{
							string text = "SprintTyMatch: is_matches".ToString();
							Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
						}
						throw new AssertionException("ncc\\misc\\PrettyPrint.n", 842, "", "SprintTyMatch: is_matches");
					}
					num = 0;
				}
				goto IL_0bd4;
			}
		}
		num = 0;
		goto IL_0bd4;
		IL_0bd4:
		if (num == 0)
		{
			_N_append_91809(n_closureOf_SprintTyMatch_, "match (");
			_N_recurse_91823(n_closureOf_SprintTyMatch_, expr);
			_N_append_91809(n_closureOf_SprintTyMatch_, ") {\n");
			list<Match_case> list = match_cases;
			while (list is list<Match_case>.Cons)
			{
				list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>> patterns = ((list<Match_case>.Cons)list).hd.patterns;
				TExpr body = ((list<Match_case>.Cons)list).hd.body;
				list = ((list<Match_case>.Cons)list).tl;
				_N_print_patterns_91851(n_closureOf_SprintTyMatch_, patterns);
				_N_recurse_and_indent_91830(n_closureOf_SprintTyMatch_, body);
				_N_append_91809(n_closureOf_SprintTyMatch_, "\n");
				list = list;
			}
			_N_indent_91816(n_closureOf_SprintTyMatch_);
			_N_append_91809(n_closureOf_SprintTyMatch_, "}");
		}
	}

	public static string SprintTyExpr(option<Typer> ctx, TExpr expr)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = stringBuilder.Append("\n");
		SprintTyExpr(ctx, expr, option<string>.None._N_constant_object, is_top_level: false, "", stringBuilder);
		stringBuilder2 = stringBuilder.Append("\n");
		return stringBuilder.ToString();
	}

	public static string SprintTyExpr(TExpr expr)
	{
		StringBuilder stringBuilder = new StringBuilder();
		SprintTyExpr(option<Typer>.None._N_constant_object, expr, option<string>.None._N_constant_object, is_top_level: false, "", stringBuilder);
		return stringBuilder.ToString();
	}

	public static void SprintTyExpr(option<Typer> ctx, TExpr expr, option<string> current_fun_name, bool is_top_level, string indentation, StringBuilder result)
	{
		_N_closureOf_SprintTyExpr_92330 n_closureOf_SprintTyExpr_ = new _N_closureOf_SprintTyExpr_92330();
		n_closureOf_SprintTyExpr_._N_ctx_92343 = ctx;
		n_closureOf_SprintTyExpr_._N_current_fun_name_92341 = current_fun_name;
		n_closureOf_SprintTyExpr_._N_indentation_92339 = indentation;
		n_closureOf_SprintTyExpr_._N_result_92337 = result;
		n_closureOf_SprintTyExpr_._N_recurse_92335 = new _N_recurse__92352(n_closureOf_SprintTyExpr_);
		if (is_top_level)
		{
			_N_append_92346(n_closureOf_SprintTyExpr_, n_closureOf_SprintTyExpr_._N_indentation_92339);
		}
		if (expr == null)
		{
			_N_append_92346(n_closureOf_SprintTyExpr_, "");
		}
		else
		{
			switch (TExpr._N_GetVariantCodeSafe(expr))
			{
			default:
				throw new MatchFailureException();
			case 0:
			{
				FixedType.Class from = ((TExpr.StaticRef)expr).from;
				IMember mem4 = ((TExpr.StaticRef)expr).mem;
				list<TypeVar> list14 = ((TExpr.StaticRef)expr).type_parms;
				string x = strip_nemerle_core_dot_prefix(from.ToString());
				string name4 = mem4.Name;
				if (_N_is_list_nil_92413(mem4))
				{
					_N_append_92346(n_closureOf_SprintTyExpr_, "[]");
				}
				else
				{
					_N_append_92346(n_closureOf_SprintTyExpr_, x);
					if (!(name4 == ".ctor"))
					{
						_N_append_92346(n_closureOf_SprintTyExpr_, "." + name4);
					}
				}
				if (!list14.IsEmpty)
				{
					_N_append_92346(n_closureOf_SprintTyExpr_, "." + Convert.ToString(list14));
				}
				break;
			}
			case 1:
			{
				LocalValue decl2 = ((TExpr.LocalRef)expr).decl;
				_N_append_92346(n_closureOf_SprintTyExpr_, decl2.Name);
				break;
			}
			case 2:
				_N_append_92346(n_closureOf_SprintTyExpr_, expr.Type.ToString() + " ()");
				break;
			case 3:
			{
				TExpr obj = ((TExpr.FieldMember)expr).obj;
				IField fld = ((TExpr.FieldMember)expr).fld;
				n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(obj);
				_N_append_92346(n_closureOf_SprintTyExpr_, "." + fld.Name);
				break;
			}
			case 4:
			{
				TExpr obj2 = ((TExpr.MethodRef)expr).obj;
				IMethod meth = ((TExpr.MethodRef)expr).meth;
				list<TypeVar> list4 = ((TExpr.MethodRef)expr).type_parms;
				n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(obj2);
				_N_append_92346(n_closureOf_SprintTyExpr_, "." + meth.Name);
				if (!list4.IsEmpty)
				{
					_N_append_92346(n_closureOf_SprintTyExpr_, "." + Convert.ToString(list4));
				}
				break;
			}
			case 5:
			{
				if (((TExpr.Call)expr).func is TExpr.OpCode)
				{
					if (((TExpr.Call)expr).parms is list<Parm>.Cons)
					{
						string name = ((TExpr.OpCode)((TExpr.Call)expr).func).name;
						if ((object)((list<Parm>.Cons)((TExpr.Call)expr).parms).tl == list<Parm>.Nil._N_constant_object)
						{
							Parm hd = ((list<Parm>.Cons)((TExpr.Call)expr).parms).hd;
							_N_append_92346(n_closureOf_SprintTyExpr_, name);
							_N_append_92346(n_closureOf_SprintTyExpr_, "(");
							n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(hd.expr);
							_N_append_92346(n_closureOf_SprintTyExpr_, ")");
							break;
						}
						if (((list<Parm>.Cons)((TExpr.Call)expr).parms).tl is list<Parm>.Cons)
						{
							string name2 = ((TExpr.OpCode)((TExpr.Call)expr).func).name;
							Parm hd2 = ((list<Parm>.Cons)((TExpr.Call)expr).parms).hd;
							if ((object)((list<Parm>.Cons)((list<Parm>.Cons)((TExpr.Call)expr).parms).tl).tl == list<Parm>.Nil._N_constant_object)
							{
								Parm hd3 = ((list<Parm>.Cons)((list<Parm>.Cons)((TExpr.Call)expr).parms).tl).hd;
								_N_append_92346(n_closureOf_SprintTyExpr_, "(");
								n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(hd2.expr);
								_N_append_92346(n_closureOf_SprintTyExpr_, string.Concat(" " + name2, " "));
								n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(hd3.expr);
								_N_append_92346(n_closureOf_SprintTyExpr_, ")");
								break;
							}
						}
					}
				}
				else if (((TExpr.Call)expr).func is TExpr.StaticRef)
				{
					IMember mem = ((TExpr.StaticRef)((TExpr.Call)expr).func).mem;
					if (_N_is_list_cons_92405(mem))
					{
						TExpr tExpr = expr;
						list<TExpr> list2 = list<TExpr>.Nil._N_constant_object;
						Nemerle.Builtins.Tuple<list<TExpr>, bool> tuple;
						while (true)
						{
							if (tExpr is TExpr.Call)
							{
								if (((TExpr.Call)tExpr).func is TExpr.StaticRef)
								{
									IMember mem2 = ((TExpr.StaticRef)((TExpr.Call)tExpr).func).mem;
									list<Parm> list3 = ((TExpr.Call)tExpr).parms;
									if (_N_is_list_cons_92405(mem2))
									{
										if (list3 is list<Parm>.Cons && ((list<Parm>.Cons)list3).tl is list<Parm>.Cons)
										{
											Parm hd4 = ((list<Parm>.Cons)list3).hd;
											if ((object)((list<Parm>.Cons)((list<Parm>.Cons)list3).tl).tl == list<Parm>.Nil._N_constant_object)
											{
												Parm hd5 = ((list<Parm>.Cons)((list<Parm>.Cons)list3).tl).hd;
												TExpr expr7 = hd5.expr;
												list2 = new list<TExpr>.Cons(hd4.expr, list2);
												tExpr = expr7;
												continue;
											}
										}
										if (!Message.SeenError)
										{
											string text = "SprintTyExpr/flatten_list/walk_list_tree".ToString();
											Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
										}
										throw new AssertionException("ncc\\misc\\PrettyPrint.n", 968, "", "SprintTyExpr/flatten_list/walk_list_tree");
									}
								}
							}
							else if (tExpr is TExpr.StaticRef)
							{
								IMember mem3 = ((TExpr.StaticRef)tExpr).mem;
								if (_N_is_list_nil_92413(mem3))
								{
									tuple = new Nemerle.Builtins.Tuple<list<TExpr>, bool>(NList.Rev(list2), field1: true);
									break;
								}
							}
							tuple = new Nemerle.Builtins.Tuple<list<TExpr>, bool>(NList.Rev(new list<TExpr>.Cons(tExpr, list2)), field1: false);
							break;
						}
						Nemerle.Builtins.Tuple<list<TExpr>, bool> tuple2 = tuple;
						list<TExpr> args2 = tuple2.Field0;
						if (tuple2.Field1)
						{
							_N_print_expr_list_92383(n_closureOf_SprintTyExpr_, "[", args2, ", ", "]");
						}
						else
						{
							_N_print_expr_list_92383(n_closureOf_SprintTyExpr_, "", args2, " :: ", "");
						}
						break;
					}
				}
				TExpr func = ((TExpr.Call)expr).func;
				list<Parm> parms = ((TExpr.Call)expr).parms;
				n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(func);
				_N_append_92346(n_closureOf_SprintTyExpr_, " (");
				_N_print_fun_call_parms_92390(n_closureOf_SprintTyExpr_, parms);
				_N_append_92346(n_closureOf_SprintTyExpr_, ")");
				break;
			}
			case 6:
			{
				TExpr target2 = ((TExpr.Assign)expr).target;
				TExpr source = ((TExpr.Assign)expr).source;
				n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(target2);
				_N_append_92346(n_closureOf_SprintTyExpr_, " = ");
				n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(source);
				break;
			}
			case 7:
			{
				LocalValue name3 = ((TExpr.DefValIn)expr).name;
				TExpr val4 = ((TExpr.DefValIn)expr).val;
				TExpr body4 = ((TExpr.DefValIn)expr).body;
				if (_N_need_curly_braces_92422(n_closureOf_SprintTyExpr_, val4))
				{
					_N_append_92346(n_closureOf_SprintTyExpr_, string.Concat("def " + name3.Name, " = {\n"));
					_N_recurse_and_indent_92369(n_closureOf_SprintTyExpr_, val4);
					_N_append_92346(n_closureOf_SprintTyExpr_, string.Concat("\n" + n_closureOf_SprintTyExpr_._N_indentation_92339, "};\n"));
					_N_recurse_no_indent_92362(n_closureOf_SprintTyExpr_, body4);
				}
				else
				{
					_N_append_92346(n_closureOf_SprintTyExpr_, string.Concat("def " + name3.Name, " = "));
					n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(val4);
					_N_append_92346(n_closureOf_SprintTyExpr_, ";\n");
					_N_recurse_no_indent_92362(n_closureOf_SprintTyExpr_, body4);
				}
				break;
			}
			case 8:
			{
				TExpr exn = ((TExpr.Throw)expr).exn;
				_N_append_92346(n_closureOf_SprintTyExpr_, "throw ");
				n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(exn);
				break;
			}
			case 9:
			{
				TExpr body5 = ((TExpr.TryFinally)expr).body;
				TExpr handler = ((TExpr.TryFinally)expr).handler;
				_N_append_92346(n_closureOf_SprintTyExpr_, "try {\n");
				_N_recurse_and_indent_92369(n_closureOf_SprintTyExpr_, body5);
				_N_append_92346(n_closureOf_SprintTyExpr_, string.Concat("\n" + n_closureOf_SprintTyExpr_._N_indentation_92339, "} finally {\n"));
				_N_recurse_and_indent_92369(n_closureOf_SprintTyExpr_, handler);
				_N_append_92346(n_closureOf_SprintTyExpr_, string.Concat("\n" + n_closureOf_SprintTyExpr_._N_indentation_92339, "}"));
				break;
			}
			case 10:
			{
				TExpr body2 = ((TExpr.Try)expr).body;
				list<Try_case> list7 = ((TExpr.Try)expr).cases;
				_N_append_92346(n_closureOf_SprintTyExpr_, "try {\n");
				_N_recurse_and_indent_92369(n_closureOf_SprintTyExpr_, body2);
				_N_append_92346(n_closureOf_SprintTyExpr_, string.Concat("\n" + n_closureOf_SprintTyExpr_._N_indentation_92339, "} catch {"));
				list<Try_case> list8 = list7;
				while (list8 is list<Try_case>.Cons)
				{
					Try_case hd6 = ((list<Try_case>.Cons)list8).hd;
					list<Try_case> list9 = ((list<Try_case>.Cons)list8).tl;
					Try_case @case = hd6;
					_N_print_case_92573(n_closureOf_SprintTyExpr_, @case);
					list8 = list9;
				}
				_N_append_92346(n_closureOf_SprintTyExpr_, string.Concat("\n" + n_closureOf_SprintTyExpr_._N_indentation_92339, "}"));
				break;
			}
			case 11:
			{
				Literal val3 = ((TExpr.Literal)expr).val;
				_N_append_92346(n_closureOf_SprintTyExpr_, val3.ToString());
				break;
			}
			case 12:
				_N_append_92346(n_closureOf_SprintTyExpr_, "this");
				break;
			case 13:
				_N_append_92346(n_closureOf_SprintTyExpr_, "base");
				break;
			case 14:
			{
				TExpr expr6 = ((TExpr.TypeConversion)expr).expr;
				TypeVar target_type = ((TExpr.TypeConversion)expr).target_type;
				ConversionKind kind = ((TExpr.TypeConversion)expr).kind;
				_N_append_92346(n_closureOf_SprintTyExpr_, "(");
				n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(expr6);
				if (kind == ConversionKind.Nop._N_constant_object || kind == ConversionKind.UpCast._N_constant_object)
				{
					_N_append_92346(n_closureOf_SprintTyExpr_, " : ");
				}
				else
				{
					_N_append_92346(n_closureOf_SprintTyExpr_, " :> ");
				}
				_N_print_type_92376(n_closureOf_SprintTyExpr_, target_type);
				_N_append_92346(n_closureOf_SprintTyExpr_, ")");
				break;
			}
			case 15:
			{
				TExpr e = ((TExpr.Sequence)expr).e1;
				TExpr e2 = ((TExpr.Sequence)expr).e2;
				n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(e);
				_N_append_92346(n_closureOf_SprintTyExpr_, ";\n");
				_N_recurse_no_indent_92362(n_closureOf_SprintTyExpr_, e2);
				break;
			}
			case 16:
			{
				list<TExpr> args = ((TExpr.Tuple)expr).args;
				_N_print_expr_list_92383(n_closureOf_SprintTyExpr_, "(", args, ", ", ")");
				break;
			}
			case 17:
			{
				list<TExpr> args4 = ((TExpr.Array)expr).args;
				_N_append_92346(n_closureOf_SprintTyExpr_, "array ");
				_N_print_expr_list_92383(n_closureOf_SprintTyExpr_, "[", args4, ", ", "]");
				break;
			}
			case 18:
			{
				TypeVar target_type2 = ((TExpr.TypeOf)expr).target_type;
				_N_append_92346(n_closureOf_SprintTyExpr_, "typeof (");
				_N_print_type_92376(n_closureOf_SprintTyExpr_, target_type2);
				_N_append_92346(n_closureOf_SprintTyExpr_, ")");
				break;
			}
			case 19:
			{
				TypeVar from_type = ((TExpr.MethodOf)expr).from_type;
				IMethod method2 = ((TExpr.MethodOf)expr).method;
				list<TypeVar> list15 = ((TExpr.MethodOf)expr).typars;
				_N_append_92346(n_closureOf_SprintTyExpr_, "methodof (" + Convert.ToString(from_type) + "." + Convert.ToString(method2) + "[" + Convert.ToString(list15) + "])");
				break;
			}
			case 20:
			{
				TypeVar type2 = ((TExpr.CtorOf)expr).type;
				IMethod method = ((TExpr.CtorOf)expr).method;
				_N_append_92346(n_closureOf_SprintTyExpr_, "ctorof (" + Convert.ToString(type2) + "." + Convert.ToString(method) + ")");
				break;
			}
			case 21:
			{
				TypeVar type = ((TExpr.FieldOf)expr).type;
				IField field = ((TExpr.FieldOf)expr).field;
				_N_append_92346(n_closureOf_SprintTyExpr_, "fieldof (" + Convert.ToString(type) + "." + Convert.ToString(field.Name) + ")");
				break;
			}
			case 22:
			{
				TExpr varRef2 = ((TExpr.ClosureObjectOf)expr).varRef;
				_N_append_92346(n_closureOf_SprintTyExpr_, "ClosureObjectOf(");
				n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(varRef2);
				_N_append_92346(n_closureOf_SprintTyExpr_, ")");
				break;
			}
			case 23:
			{
				TExpr varRef = ((TExpr.ClosureFieldOf)expr).varRef;
				_N_append_92346(n_closureOf_SprintTyExpr_, "ClosureFieldOf(");
				n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(varRef);
				_N_append_92346(n_closureOf_SprintTyExpr_, ")");
				break;
			}
			case 24:
			{
				TExpr obj7 = ((TExpr.ArrayIndexer)expr).obj;
				list<TExpr> args3 = ((TExpr.ArrayIndexer)expr).args;
				n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(obj7);
				_N_print_expr_list_92383(n_closureOf_SprintTyExpr_, "[", args3, ", ", "]");
				break;
			}
			case 25:
			{
				TExpr obj6 = ((TExpr.PointerIndexer)expr).obj;
				TExpr index = ((TExpr.PointerIndexer)expr).index;
				n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(obj6);
				_N_append_92346(n_closureOf_SprintTyExpr_, "[");
				n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(index);
				_N_append_92346(n_closureOf_SprintTyExpr_, "]");
				break;
			}
			case 26:
			{
				TExpr obj5 = ((TExpr.TupleIndexer)expr).obj;
				int pos = ((TExpr.TupleIndexer)expr).pos;
				n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(obj5);
				_N_append_92346(n_closureOf_SprintTyExpr_, "[" + Convert.ToString(pos) + "]");
				break;
			}
			case 27:
			{
				string name5 = ((TExpr.OpCode)expr).name;
				_N_append_92346(n_closureOf_SprintTyExpr_, name5);
				break;
			}
			case 28:
			{
				PExpr original = ((TExpr.MacroEnvelope)expr).original;
				IMacro the_macro = ((TExpr.MacroEnvelope)expr).the_macro;
				TExpr expanded = ((TExpr.MacroEnvelope)expr).expanded;
				_N_append_92346(n_closureOf_SprintTyExpr_, "macro_" + Convert.ToString(the_macro) + ":" + Environment.NewLine);
				_N_recurse_and_indent_92369(n_closureOf_SprintTyExpr_, expanded);
				break;
			}
			case 29:
			{
				TExpr obj4 = ((TExpr.PropertyMember)expr).obj;
				IProperty prop2 = ((TExpr.PropertyMember)expr).prop;
				n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(obj4);
				_N_append_92346(n_closureOf_SprintTyExpr_, "." + prop2.Name);
				break;
			}
			case 30:
			{
				IProperty prop = ((TExpr.StaticPropertyRef)expr).prop;
				_N_append_92346(n_closureOf_SprintTyExpr_, string.Concat(prop.DeclaringType.FullName + ".", prop.Name));
				break;
			}
			case 31:
			{
				TExpr obj3 = ((TExpr.EventMember)expr).obj;
				IEvent ev2 = ((TExpr.EventMember)expr).ev;
				n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(obj3);
				_N_append_92346(n_closureOf_SprintTyExpr_, "." + ev2.Name);
				break;
			}
			case 32:
			{
				IEvent ev = ((TExpr.StaticEventRef)expr).ev;
				_N_append_92346(n_closureOf_SprintTyExpr_, string.Concat(ev.DeclaringType.FullName + ".", ev.Name));
				break;
			}
			case 33:
			{
				IField mem5 = ((TExpr.ConstantObjectRef)expr).mem;
				_N_append_92346(n_closureOf_SprintTyExpr_, string.Concat(mem5.DeclaringType.FullName + ".", mem5.Name));
				break;
			}
			case 34:
			{
				LocalValue jump_out = ((TExpr.Block)expr).jump_out;
				TExpr body7 = ((TExpr.Block)expr).body;
				_N_append_92346(n_closureOf_SprintTyExpr_, "block (" + Convert.ToString(jump_out.Name) + ") :" + Environment.NewLine);
				_N_recurse_and_indent_92369(n_closureOf_SprintTyExpr_, body7);
				break;
			}
			case 35:
			{
				Typer.DelayedTyping susp = ((TExpr.Delayed)expr).susp;
				try
				{
					if (susp.IsResolved)
					{
						SprintTyExpr(n_closureOf_SprintTyExpr_._N_ctx_92343, susp.ResolutionResult, n_closureOf_SprintTyExpr_._N_current_fun_name_92341, is_top_level, n_closureOf_SprintTyExpr_._N_indentation_92339, n_closureOf_SprintTyExpr_._N_result_92337);
					}
					else
					{
						_N_append_92346(n_closureOf_SprintTyExpr_, "TExpr.Delayed(" + Convert.ToString(susp) + ")");
					}
				}
				catch (Exception ex)
				{
					_N_append_92346(n_closureOf_SprintTyExpr_, "TExpr.Delayed(<<exception " + Convert.ToString(ex.GetType().Name) + ": " + Convert.ToString(ex.Message) + ">>)");
				}
				break;
			}
			case 36:
			{
				CacheDesc desc2 = ((TExpr.Cache)expr).desc;
				TExpr body6 = ((TExpr.Cache)expr).body;
				_N_append_92346(n_closureOf_SprintTyExpr_, "[[Cache:" + Convert.ToString(desc2.PExpr) + "]]" + Environment.NewLine);
				_N_recurse_no_indent_92362(n_closureOf_SprintTyExpr_, body6);
				break;
			}
			case 37:
			{
				CacheDesc desc = ((TExpr.CacheRef)expr).desc;
				_N_append_92346(n_closureOf_SprintTyExpr_, "[[CacheRef:" + Convert.ToString(desc.PExpr) + "]]");
				break;
			}
			case 38:
				_N_append_92346(n_closureOf_SprintTyExpr_, "(ERROR)");
				break;
			case 39:
			{
				list<TFunHeader> list10 = ((TExpr.DefFunctionsIn)expr).funs;
				TExpr body3 = ((TExpr.DefFunctionsIn)expr).body;
				if (list10 is list<TFunHeader>.Cons)
				{
					TFunHeader hd7 = ((list<TFunHeader>.Cons)list10).hd;
					list<TFunHeader> list11 = ((list<TFunHeader>.Cons)list10).tl;
					_N_print_local_fun_decl_92443(n_closureOf_SprintTyExpr_, "def", hd7);
					list<TFunHeader> list12 = list11;
					while (list12 is list<TFunHeader>.Cons)
					{
						TFunHeader hd8 = ((list<TFunHeader>.Cons)list12).hd;
						list<TFunHeader> list13 = ((list<TFunHeader>.Cons)list12).tl;
						TFunHeader fun_decl = hd8;
						_N_print_local_fun_decl_92443(n_closureOf_SprintTyExpr_, "and", fun_decl);
						list12 = list13;
					}
					_N_recurse_no_indent_92362(n_closureOf_SprintTyExpr_, body3);
					break;
				}
				if (!Message.SeenError)
				{
					string text2 = "TT.TExpr.DefFunctionsIn with no function declarations".ToString();
					Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text2) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
				}
				throw new AssertionException("ncc\\misc\\PrettyPrint.n", 1219, "", "TT.TExpr.DefFunctionsIn with no function declarations");
			}
			case 40:
			{
				TExpr expr8 = ((TExpr.Match)expr).expr;
				list<Match_case> match_cases = ((TExpr.Match)expr).cases;
				SprintTyMatch(n_closureOf_SprintTyExpr_._N_ctx_92343, expr8, n_closureOf_SprintTyExpr_._N_current_fun_name_92341, match_cases, n_closureOf_SprintTyExpr_._N_indentation_92339, n_closureOf_SprintTyExpr_._N_result_92337);
				break;
			}
			case 41:
			{
				list<Parm> parms2 = ((TExpr.SelfTailCall)expr).parms;
				if (n_closureOf_SprintTyExpr_._N_current_fun_name_92341 is option<string>.Some)
				{
					string val = ((option<string>.Some)n_closureOf_SprintTyExpr_._N_current_fun_name_92341).val;
					_N_append_92346(n_closureOf_SprintTyExpr_, val);
				}
				else if (n_closureOf_SprintTyExpr_._N_ctx_92343 is option<Typer>.Some)
				{
					Typer val2 = ((option<Typer>.Some)n_closureOf_SprintTyExpr_._N_ctx_92343).val;
					_N_append_92346(n_closureOf_SprintTyExpr_, val2.CurrentFunction.Name);
				}
				else
				{
					_N_append_92346(n_closureOf_SprintTyExpr_, "SELF");
				}
				_N_append_92346(n_closureOf_SprintTyExpr_, " (");
				_N_print_fun_call_parms_92390(n_closureOf_SprintTyExpr_, parms2);
				_N_append_92346(n_closureOf_SprintTyExpr_, ")");
				break;
			}
			case 42:
			{
				LocalValue decl = ((TExpr.LocalFunRef)expr).decl;
				list<TypeVar> list6 = ((TExpr.LocalFunRef)expr).type_parms;
				_N_append_92346(n_closureOf_SprintTyExpr_, decl.Name);
				if (!list6.IsEmpty)
				{
					_N_append_92346(n_closureOf_SprintTyExpr_, "." + Convert.ToString(list6));
				}
				break;
			}
			case 43:
			{
				IMethod meth2 = ((TExpr.MethodAddress)expr).meth;
				bool is_virt = ((TExpr.MethodAddress)expr).is_virt;
				_N_append_92346(n_closureOf_SprintTyExpr_, "ADDR(" + Convert.ToString(meth2) + ", " + Convert.ToString(is_virt) + ")");
				break;
			}
			case 44:
			{
				list<Nemerle.Builtins.Tuple<LocalValue, TExpr>> list5 = ((TExpr.MultipleAssign)expr).assigns;
				_N_append_92346(n_closureOf_SprintTyExpr_, "ASSIGNS " + Convert.ToString(list5));
				break;
			}
			case 45:
			{
				int id = ((TExpr.Label)expr).id;
				TExpr body = ((TExpr.Label)expr).body;
				string idName2 = GetIdName(expr, id);
				if (idName2 == null)
				{
					_N_append_92346(n_closureOf_SprintTyExpr_, string.Concat("Label_" + Convert.ToString(id) + ":", "\n"));
				}
				else
				{
					_N_append_92346(n_closureOf_SprintTyExpr_, string.Concat(Convert.ToString(idName2) + " /* id: " + Convert.ToString(id) + " */:", "\n"));
				}
				_N_recurse_and_indent_92369(n_closureOf_SprintTyExpr_, body);
				break;
			}
			case 46:
			{
				int target = ((TExpr.Goto)expr).target;
				int try_block = ((TExpr.Goto)expr).try_block;
				string idName = GetIdName(expr, target);
				if (idName == null)
				{
					_N_append_92346(n_closureOf_SprintTyExpr_, "goto Label_" + Convert.ToString(target) + " /* try id: " + Convert.ToString(try_block) + " */");
				}
				else
				{
					_N_append_92346(n_closureOf_SprintTyExpr_, "goto " + Convert.ToString(idName) + " /* id: " + Convert.ToString(target) + " try id: " + Convert.ToString(try_block) + " */");
				}
				break;
			}
			case 47:
				_N_append_92346(n_closureOf_SprintTyExpr_, "DEFAULT");
				break;
			case 48:
			{
				TExpr cond = ((TExpr.If)expr).cond;
				TExpr e_then = ((TExpr.If)expr).e_then;
				TExpr e_else = ((TExpr.If)expr).e_else;
				_N_append_92346(n_closureOf_SprintTyExpr_, "if.real (");
				n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(cond);
				_N_append_92346(n_closureOf_SprintTyExpr_, ") {\n");
				_N_recurse_and_indent_92369(n_closureOf_SprintTyExpr_, e_then);
				_N_append_92346(n_closureOf_SprintTyExpr_, string.Concat(string.Concat(string.Concat("\n" + n_closureOf_SprintTyExpr_._N_indentation_92339, "}\n"), n_closureOf_SprintTyExpr_._N_indentation_92339), "else {\n"));
				_N_recurse_and_indent_92369(n_closureOf_SprintTyExpr_, e_else);
				_N_append_92346(n_closureOf_SprintTyExpr_, string.Concat("\n" + n_closureOf_SprintTyExpr_._N_indentation_92339, "}"));
				break;
			}
			case 49:
			{
				TExpr expr5 = ((TExpr.HasType)expr).expr;
				FixedType test_ty = ((TExpr.HasType)expr).test_ty;
				_N_append_92346(n_closureOf_SprintTyExpr_, "(" + Convert.ToString(expr5) + " is " + Convert.ToString(test_ty) + ")");
				break;
			}
			case 50:
			{
				TExpr indexing_expr = ((TExpr.Switch)expr).indexing_expr;
				option<TExpr> option = ((TExpr.Switch)expr).@default;
				list<Nemerle.Builtins.Tuple<int, TExpr>> list = ((TExpr.Switch)expr).cases;
				_N_append_92346(n_closureOf_SprintTyExpr_, "switch (" + Convert.ToString(indexing_expr) + ") " + Convert.ToString(option) + " " + Convert.ToString(list));
				break;
			}
			case 51:
				if ((object)((TExpr.DebugInfo)expr).expr != null)
				{
					TExpr expr4 = ((TExpr.DebugInfo)expr).expr;
					_N_append_92346(n_closureOf_SprintTyExpr_, "DEBUG_INFO(");
					n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(expr4);
					_N_append_92346(n_closureOf_SprintTyExpr_, ")");
				}
				break;
			case 52:
			{
				TExpr expr3 = ((TExpr.Def)expr).expr;
				TExpr into = ((TExpr.Def)expr).into;
				_N_append_92346(n_closureOf_SprintTyExpr_, "#");
				n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(expr3);
				_N_append_92346(n_closureOf_SprintTyExpr_, "-->");
				n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(into);
				_N_append_92346(n_closureOf_SprintTyExpr_, "#");
				break;
			}
			case 53:
			{
				TExpr expr2 = ((TExpr.Use)expr).expr;
				_N_append_92346(n_closureOf_SprintTyExpr_, "U");
				n_closureOf_SprintTyExpr_._N_recurse_92335.apply_void(expr2);
				break;
			}
			}
		}
		if (n_closureOf_SprintTyExpr_._N_ctx_92343 is option<Typer>.Some)
		{
			Typer val5 = ((option<Typer>.Some)n_closureOf_SprintTyExpr_._N_ctx_92343).val;
			if (val5.Manager.Options.PrintExpressionsType)
			{
				_N_append_92346(n_closureOf_SprintTyExpr_, "{" + Convert.ToString(expr.Type) + "}");
			}
		}
		else if (n_closureOf_SprintTyExpr_._N_ctx_92343 != option<Typer>.None._N_constant_object)
		{
			throw new MatchFailureException();
		}
	}

	public static string GetIdName(TExpr expr, int id)
	{
		ManagerClass managerClass = null;
		TypeVar type = expr.Type;
		if (type != null)
		{
			managerClass = type.Manager;
		}
		ManagerClass managerClass2;
		ManagerClass manager = default(ManagerClass);
		if (managerClass != null)
		{
			type = expr.Type;
			if (type != null)
			{
				manager = type.Manager;
			}
			managerClass2 = manager;
		}
		else
		{
			managerClass2 = ManagerClass.Instance;
		}
		manager = managerClass2;
		if (manager == null)
		{
		}
		return manager.GetIdName(id);
	}

	public static PExpr TyVarToParseTree(TypeVar ty)
	{
		return (!ty.IsFixed) ? MTypeToParseTree(ty.Fix()) : MTypeToParseTree(ty.FixedValue);
	}

	public static PExpr MTypeToParseTree(FixedType ty)
	{
		object result;
		if (ty is FixedType.Class)
		{
			if ((object)((FixedType.Class)ty).args == list<TypeVar>.Nil._N_constant_object)
			{
				TypeInfo tycon = ((FixedType.Class)ty).tycon;
				result = Util.ExprOfQid(tycon.FullName);
			}
			else
			{
				TypeInfo tycon = ((FixedType.Class)ty).tycon;
				list<TypeVar> lst = ((FixedType.Class)ty).args;
				result = new PExpr.Indexer(Util.ExprOfQid(tycon.FullName), NList.Map(lst, _N_static_proxy_92691.single_instance));
			}
		}
		else if (ty is FixedType.StaticTypeVarRef)
		{
			StaticTypeVar tyvar = ((FixedType.StaticTypeVarRef)ty).tyvar;
			result = new PExpr.Ref(new Name(tyvar.Name));
		}
		else if (ty is FixedType.Fun)
		{
			TypeVar from = ((FixedType.Fun)ty).from;
			TypeVar to = ((FixedType.Fun)ty).to;
			result = new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("->", _N_MacroContexts.Get(13, ManagerClass.Instance))), new list<PExpr>.Cons(Macros.QuotationChoose(TyVarToParseTree(from)), new list<PExpr>.Cons(Macros.QuotationChoose(TyVarToParseTree(to)), list<PExpr>.Nil._N_constant_object)));
		}
		else if (ty is FixedType.Tuple)
		{
			list<TypeVar> lst = ((FixedType.Tuple)ty).args;
			result = new PExpr.Call(new PExpr.Ref(Name.NameInCurrentColor("*", _N_MacroContexts.Get(13, ManagerClass.Instance))), Macros.QuotationChoose(NList.Map(lst, _N_static_proxy_92691.single_instance)));
		}
		else if (ty is FixedType.Array)
		{
			TypeVar from = ((FixedType.Array)ty).t;
			int rank = ((FixedType.Array)ty).rank;
			result = new PExpr.Array(new PExpr.Literal(new Literal.Integer(1uL, is_negative: false, null).WithProperType()), new PExpr.ListLiteral(new list<PExpr>.Cons(new PExpr.Literal(Literal.FromInt(rank)), new list<PExpr>.Cons(Macros.QuotationChoose(TyVarToParseTree(from)), list<PExpr>.Nil._N_constant_object))));
		}
		else if (ty is FixedType.Ref)
		{
			TypeVar from = ((FixedType.Ref)ty).t;
			result = new PExpr.ParmByRef(Macros.QuotationChoose(TyVarToParseTree(from)));
		}
		else if (ty is FixedType.Out)
		{
			TypeVar from = ((FixedType.Out)ty).t;
			result = new PExpr.ParmOut(Macros.QuotationChoose(TyVarToParseTree(from)));
		}
		else
		{
			if (!(ty is FixedType.Void))
			{
				if (ty is FixedType.Intersection)
				{
					throw new AssertionException("ncc\\misc\\PrettyPrint.n", 1420, "", "");
				}
				throw new MatchFailureException();
			}
			result = new PExpr.Void();
		}
		return (PExpr)result;
	}

	private static string strip_nemerle_core_dot_prefix(string tyname)
	{
		return (!tyname.StartsWith("Nemerle.Core.")) ? tyname : tyname.Substring(13);
	}

	private static string print_fun_typarms(list<StaticTypeVar> typarms)
	{
		return (!typarms.IsEmpty) ? typarms.ToString() : "";
	}

	private static void _N_print_tconstraints_91180(_N_closureOf_SprintExpr_91161 _N_SprintExpr_cp_91179, list<Constraint> cts)
	{
		while (true)
		{
			if ((object)cts == list<Constraint>.Nil._N_constant_object)
			{
				return;
			}
			if (!(cts is list<Constraint>.Cons))
			{
				break;
			}
			Constraint hd = ((list<Constraint>.Cons)cts).hd;
			list<Constraint> list = ((list<Constraint>.Cons)cts).tl;
			_N_SprintExpr_cp_91179._N_acc_91170.Write("where " + Convert.ToString(hd.tyvar) + " : ");
			SprintExpr(_N_SprintExpr_cp_91179._N_ctx_91174, hd.ty, _N_SprintExpr_cp_91179._N_indentation_91172, _N_SprintExpr_cp_91179._N_acc_91170);
			cts = list;
		}
		throw new MatchFailureException();
	}

	private static void _N_print_funparms_91218(_N_closureOf_SprintExpr_91161 _N_SprintExpr_cp_91217, list<PParameter> fps)
	{
		SeparatedCalls(", ", fps, _N_SprintExpr_cp_91217._N_print_funparm_91168, _N_SprintExpr_cp_91217._N_acc_91170);
	}

	private static void _N_sprint_ss_91225(_N_closureOf_SprintExpr_91161 _N_SprintExpr_cp_91224, Splicable x)
	{
		if (x == null)
		{
			_N_SprintExpr_cp_91224._N_acc_91170.Write("(NULL-MEM)");
			return;
		}
		if (x is Splicable.Name)
		{
			Name body = ((Splicable.Name)x).body;
			_N_SprintExpr_cp_91224._N_acc_91170.Write(body.Id);
			return;
		}
		if (x is Splicable.Expression)
		{
			PExpr expr = ((Splicable.Expression)x).expr;
			_N_SprintExpr_cp_91224._N_acc_91170.Write("$(");
			SprintExpr(_N_SprintExpr_cp_91224._N_ctx_91174, expr, _N_SprintExpr_cp_91224._N_indentation_91172, _N_SprintExpr_cp_91224._N_acc_91170);
			_N_SprintExpr_cp_91224._N_acc_91170.Write(")");
			return;
		}
		if (x is Splicable.HalfId)
		{
			Name body = ((Splicable.HalfId)x).prefix;
			_N_SprintExpr_cp_91224._N_acc_91170.Write("<COMPLETE '" + Convert.ToString(body.Id) + "'>");
			return;
		}
		throw new MatchFailureException();
	}

	private static void _N_print_case_91400(_N_closureOf_SprintExpr_91161 _N_SprintExpr_cp_91399, TryCase @case)
	{
		if (@case is TryCase.Catch)
		{
			Splicable exn = ((TryCase.Catch)@case).exn;
			PExpr exn_ty = ((TryCase.Catch)@case).exn_ty;
			PExpr handler = ((TryCase.Catch)@case).handler;
			_N_SprintExpr_cp_91399._N_acc_91170.Write(Environment.NewLine + Convert.ToString(_N_SprintExpr_cp_91399._N_indentation_91172) + "  |");
			_N_sprint_ss_91225(_N_SprintExpr_cp_91399, exn);
			_N_SprintExpr_cp_91399._N_acc_91170.Write(" is ");
			SprintExpr(_N_SprintExpr_cp_91399._N_ctx_91174, exn_ty, _N_SprintExpr_cp_91399._N_indentation_91172, _N_SprintExpr_cp_91399._N_acc_91170);
			_N_SprintExpr_cp_91399._N_acc_91170.Write("=>" + Environment.NewLine + Convert.ToString(_N_SprintExpr_cp_91399._N_indentation_91172) + "    ");
			SprintExpr(_N_SprintExpr_cp_91399._N_ctx_91174, handler, _N_SprintExpr_cp_91399._N_indentation_91172 + "    ", _N_SprintExpr_cp_91399._N_acc_91170);
		}
		else if (@case is TryCase.Filter)
		{
			Splicable exn = ((TryCase.Filter)@case).exn;
			PExpr handler = ((TryCase.Filter)@case).exn_ty;
			PExpr exn_ty = ((TryCase.Filter)@case).filter;
			PExpr handler2 = ((TryCase.Filter)@case).handler;
			_N_SprintExpr_cp_91399._N_acc_91170.Write(Environment.NewLine + Convert.ToString(_N_SprintExpr_cp_91399._N_indentation_91172) + "  |");
			_N_sprint_ss_91225(_N_SprintExpr_cp_91399, exn);
			_N_SprintExpr_cp_91399._N_acc_91170.Write(" is ");
			SprintExpr(_N_SprintExpr_cp_91399._N_ctx_91174, handler, _N_SprintExpr_cp_91399._N_indentation_91172, _N_SprintExpr_cp_91399._N_acc_91170);
			_N_SprintExpr_cp_91399._N_acc_91170.Write(" when (");
			SprintExpr(_N_SprintExpr_cp_91399._N_ctx_91174, exn_ty, _N_SprintExpr_cp_91399._N_indentation_91172, _N_SprintExpr_cp_91399._N_acc_91170);
			_N_SprintExpr_cp_91399._N_acc_91170.Write(") ");
			_N_SprintExpr_cp_91399._N_acc_91170.Write("=>" + Environment.NewLine + Convert.ToString(_N_SprintExpr_cp_91399._N_indentation_91172) + "    ");
			SprintExpr(_N_SprintExpr_cp_91399._N_ctx_91174, handler2, _N_SprintExpr_cp_91399._N_indentation_91172 + "    ", _N_SprintExpr_cp_91399._N_acc_91170);
		}
		else
		{
			if (!(@case is TryCase.Ellipsis))
			{
				throw new MatchFailureException();
			}
			PExpr handler = ((TryCase.Ellipsis)@case).body;
			_N_SprintExpr_cp_91399._N_acc_91170.Write(Environment.NewLine + Convert.ToString(_N_SprintExpr_cp_91399._N_indentation_91172) + "  ");
			SprintExpr(_N_SprintExpr_cp_91399._N_ctx_91174, handler, _N_SprintExpr_cp_91399._N_indentation_91172 + "  ", _N_SprintExpr_cp_91399._N_acc_91170);
		}
	}

	private static void _N_print_gel_91464(_N_closureOf_SprintExpr_91161 _N_SprintExpr_cp_91463, GrammarElement x)
	{
		while (true)
		{
			if (x is GrammarElement.Operator)
			{
				if (((GrammarElement.Operator)x).name == ")")
				{
					_N_SprintExpr_cp_91463._N_acc_91170.Write(") ");
				}
				else if (((GrammarElement.Operator)x).name == "}")
				{
					_N_SprintExpr_cp_91463._N_acc_91170.Write("} ");
				}
				else
				{
					string name = ((GrammarElement.Operator)x).name;
					_N_SprintExpr_cp_91463._N_acc_91170.Write(name);
				}
			}
			else if (x is GrammarElement.Keyword)
			{
				string name = ((GrammarElement.Keyword)x).name;
				_N_SprintExpr_cp_91463._N_acc_91170.Write(" ");
				_N_SprintExpr_cp_91463._N_acc_91170.Write(name);
				_N_SprintExpr_cp_91463._N_acc_91170.Write(" ");
			}
			else if (x is GrammarElement.Expression)
			{
				if (_N_SprintExpr_cp_91463._N_parms_left_91166 is list<SyntaxElement>.Cons && ((list<SyntaxElement>.Cons)_N_SprintExpr_cp_91463._N_parms_left_91166).hd is SyntaxElement.Expression)
				{
					PExpr body = ((SyntaxElement.Expression)((list<SyntaxElement>.Cons)_N_SprintExpr_cp_91463._N_parms_left_91166).hd).body;
					list<SyntaxElement> n_parms_left_ = ((list<SyntaxElement>.Cons)_N_SprintExpr_cp_91463._N_parms_left_91166).tl;
					SprintExpr(_N_SprintExpr_cp_91463._N_ctx_91174, body, _N_SprintExpr_cp_91463._N_indentation_91172, _N_SprintExpr_cp_91463._N_acc_91170);
					_N_SprintExpr_cp_91463._N_parms_left_91166 = n_parms_left_;
				}
			}
			else if (x is GrammarElement.Parameter)
			{
				if (_N_SprintExpr_cp_91463._N_parms_left_91166 is list<SyntaxElement>.Cons && ((list<SyntaxElement>.Cons)_N_SprintExpr_cp_91463._N_parms_left_91166).hd is SyntaxElement.Parameter)
				{
					PParameter body2 = ((SyntaxElement.Parameter)((list<SyntaxElement>.Cons)_N_SprintExpr_cp_91463._N_parms_left_91166).hd).body;
					list<SyntaxElement> n_parms_left_ = ((list<SyntaxElement>.Cons)_N_SprintExpr_cp_91463._N_parms_left_91166).tl;
					_N_SprintExpr_cp_91463._N_print_funparm_91168.apply_void(body2);
					_N_SprintExpr_cp_91463._N_parms_left_91166 = n_parms_left_;
				}
			}
			else if (x is GrammarElement.RawToken)
			{
				if (_N_SprintExpr_cp_91463._N_parms_left_91166 is list<SyntaxElement>.Cons && ((list<SyntaxElement>.Cons)_N_SprintExpr_cp_91463._N_parms_left_91166).hd is SyntaxElement.RawToken)
				{
					Token body3 = ((SyntaxElement.RawToken)((list<SyntaxElement>.Cons)_N_SprintExpr_cp_91463._N_parms_left_91166).hd).body;
					list<SyntaxElement> n_parms_left_ = ((list<SyntaxElement>.Cons)_N_SprintExpr_cp_91463._N_parms_left_91166).tl;
					_N_SprintExpr_cp_91463._N_acc_91170.Write(body3.ToString());
					_N_SprintExpr_cp_91463._N_parms_left_91166 = n_parms_left_;
				}
			}
			else if (x is GrammarElement.ExpressionList)
			{
				list<SyntaxElement> n_parms_left_2 = _N_SprintExpr_cp_91463._N_parms_left_91166;
				FunctionVoid<SyntaxElement> f = new _N__N_lambda__91146__91492(_N_SprintExpr_cp_91463);
				SeparatedCalls(", ", n_parms_left_2, f, _N_SprintExpr_cp_91463._N_acc_91170);
			}
			else
			{
				if (!(x is GrammarElement.Optional))
				{
					if (x is GrammarElement.Branch || x is GrammarElement.End)
					{
						if (!Message.SeenError)
						{
							string name = "invalid node".ToString();
							Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(name) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
						}
						throw new AssertionException("ncc\\misc\\PrettyPrint.n", 484, "", "invalid node");
					}
					throw new MatchFailureException();
				}
				GrammarElement body4 = ((GrammarElement.Optional)x).body;
				_N_print_gel_91464(_N_SprintExpr_cp_91463, body4);
			}
			if (x.Next != null)
			{
				x = x.Next;
				continue;
			}
			break;
		}
	}

	private static void _N_append_91617(_N_closureOf_SprintPattern_91609 _N_SprintPattern_cp_91616, string x)
	{
		StringBuilder stringBuilder = _N_SprintPattern_cp_91616._N_result_91614.Append(x);
	}

	private static void _N_print_pattern_91624(_N_closureOf_SprintPattern_91609 _N_SprintPattern_cp_91623, Pattern pattern)
	{
		while (true)
		{
			if (pattern is Pattern.Wildcard)
			{
				_N_append_91617(_N_SprintPattern_cp_91623, "_");
				return;
			}
			Pattern pat;
			if (pattern is Pattern.As)
			{
				if (((Pattern.As)pattern).pat is Pattern.HasType)
				{
					FixedType typ = ((Pattern.HasType)((Pattern.As)pattern).pat).typ;
					LocalValue decl = ((Pattern.As)pattern).decl;
					_N_append_91617(_N_SprintPattern_cp_91623, string.Concat(decl.Name + " : ", typ.ToString()));
				}
				else
				{
					pat = ((Pattern.As)pattern).pat;
					LocalValue decl = ((Pattern.As)pattern).decl;
					_N_append_91617(_N_SprintPattern_cp_91623, "(");
					_N_print_pattern_91624(_N_SprintPattern_cp_91623, pat);
					_N_append_91617(_N_SprintPattern_cp_91623, ") as " + decl.Name);
				}
				return;
			}
			if (pattern is Pattern.HasType)
			{
				FixedType typ = ((Pattern.HasType)pattern).typ;
				_N_append_91617(_N_SprintPattern_cp_91623, "_ is " + Convert.ToString(typ));
				return;
			}
			if (pattern is Pattern.Tuple)
			{
				list<Pattern> list = ((Pattern.Tuple)pattern).args;
				_N_append_91617(_N_SprintPattern_cp_91623, "(");
				list = list;
				while ((object)list != list<Pattern>.Nil._N_constant_object)
				{
					if (list is list<Pattern>.Cons)
					{
						if ((object)((list<Pattern>.Cons)list).tl == list<Pattern>.Nil._N_constant_object)
						{
							pat = ((list<Pattern>.Cons)list).hd;
							_N_print_pattern_91624(_N_SprintPattern_cp_91623, pat);
							break;
						}
						pat = ((list<Pattern>.Cons)list).hd;
						list = ((list<Pattern>.Cons)list).tl;
						_N_print_pattern_91624(_N_SprintPattern_cp_91623, pat);
						_N_append_91617(_N_SprintPattern_cp_91623, ", ");
						list = list;
						continue;
					}
					throw new MatchFailureException();
				}
				_N_append_91617(_N_SprintPattern_cp_91623, ")");
				return;
			}
			if (pattern is Pattern.Record)
			{
				list<Nemerle.Builtins.Tuple<IMember, Pattern>> list2 = ((Pattern.Record)pattern).args;
				_N_append_91617(_N_SprintPattern_cp_91623, "{");
				list2 = list2;
				while ((object)list2 != list<Nemerle.Builtins.Tuple<IMember, Pattern>>.Nil._N_constant_object)
				{
					if (list2 is list<Nemerle.Builtins.Tuple<IMember, Pattern>>.Cons)
					{
						IMember field;
						if ((object)((list<Nemerle.Builtins.Tuple<IMember, Pattern>>.Cons)list2).tl == list<Nemerle.Builtins.Tuple<IMember, Pattern>>.Nil._N_constant_object)
						{
							field = ((list<Nemerle.Builtins.Tuple<IMember, Pattern>>.Cons)list2).hd.Field0;
							pat = ((list<Nemerle.Builtins.Tuple<IMember, Pattern>>.Cons)list2).hd.Field1;
							_N_print_record_field_91654(_N_SprintPattern_cp_91623, field, pat);
							break;
						}
						field = ((list<Nemerle.Builtins.Tuple<IMember, Pattern>>.Cons)list2).hd.Field0;
						pat = ((list<Nemerle.Builtins.Tuple<IMember, Pattern>>.Cons)list2).hd.Field1;
						list2 = ((list<Nemerle.Builtins.Tuple<IMember, Pattern>>.Cons)list2).tl;
						_N_print_record_field_91654(_N_SprintPattern_cp_91623, field, pat);
						_N_append_91617(_N_SprintPattern_cp_91623, "; ");
						list2 = list2;
						continue;
					}
					throw new MatchFailureException();
				}
				_N_append_91617(_N_SprintPattern_cp_91623, "}");
				return;
			}
			if (!(pattern is Pattern.Application))
			{
				break;
			}
			TypeInfo name;
			if (((Pattern.Application)pattern).arg is Pattern.Wildcard)
			{
				name = ((Pattern.Application)pattern).name;
				_N_append_91617(_N_SprintPattern_cp_91623, name.FullName);
				return;
			}
			if (((Pattern.Application)pattern).arg is Pattern.Record)
			{
				name = ((Pattern.Application)pattern).name;
				Pattern.Record record = (Pattern.Record)((Pattern.Application)pattern).arg;
				_N_append_91617(_N_SprintPattern_cp_91623, name.FullName + " ");
				pattern = record;
				continue;
			}
			name = ((Pattern.Application)pattern).name;
			pat = ((Pattern.Application)pattern).arg;
			_N_append_91617(_N_SprintPattern_cp_91623, name.FullName + " (");
			_N_print_pattern_91624(_N_SprintPattern_cp_91623, pat);
			_N_append_91617(_N_SprintPattern_cp_91623, ")");
			return;
		}
		if (pattern is Pattern.Enum)
		{
			IField fld = ((Pattern.Enum)pattern).fld;
			_N_append_91617(_N_SprintPattern_cp_91623, fld.Name);
			return;
		}
		if (pattern is Pattern.Literal)
		{
			Literal lit = ((Pattern.Literal)pattern).lit;
			_N_append_91617(_N_SprintPattern_cp_91623, lit.ToString());
			return;
		}
		if (pattern is Pattern.Error)
		{
			_N_append_91617(_N_SprintPattern_cp_91623, "(ERROR)");
			return;
		}
		throw new MatchFailureException();
	}

	private static void _N_print_record_field_91654(_N_closureOf_SprintPattern_91609 _N_SprintPattern_cp_91653, IMember fld, Pattern pat)
	{
		_N_append_91617(_N_SprintPattern_cp_91653, fld.Name + " = ");
		_N_print_pattern_91624(_N_SprintPattern_cp_91653, pat);
	}

	private static void _N_append_91809(_N_closureOf_SprintTyMatch_91795 _N_SprintTyMatch_cp_91808, string x)
	{
		StringBuilder stringBuilder = _N_SprintTyMatch_cp_91808._N_result_91800.Append(x);
	}

	private static void _N_indent_91816(_N_closureOf_SprintTyMatch_91795 _N_SprintTyMatch_cp_91815)
	{
		_N_append_91809(_N_SprintTyMatch_cp_91815, _N_SprintTyMatch_cp_91815._N_indentation_91802);
	}

	private static void _N_recurse_91823(_N_closureOf_SprintTyMatch_91795 _N_SprintTyMatch_cp_91822, TExpr expr)
	{
		SprintTyExpr(_N_SprintTyMatch_cp_91822._N_ctx_91806, expr, _N_SprintTyMatch_cp_91822._N_current_fun_name_91804, is_top_level: false, _N_SprintTyMatch_cp_91822._N_indentation_91802, _N_SprintTyMatch_cp_91822._N_result_91800);
	}

	private static void _N_recurse_and_indent_91830(_N_closureOf_SprintTyMatch_91795 _N_SprintTyMatch_cp_91829, TExpr expr)
	{
		SprintTyExpr(_N_SprintTyMatch_cp_91829._N_ctx_91806, expr, _N_SprintTyMatch_cp_91829._N_current_fun_name_91804, is_top_level: true, _N_SprintTyMatch_cp_91829._N_indentation_91802 + "    ", _N_SprintTyMatch_cp_91829._N_result_91800);
	}

	private static void _N_recurse_and_short_indent_91837(_N_closureOf_SprintTyMatch_91795 _N_SprintTyMatch_cp_91836, TExpr expr)
	{
		SprintTyExpr(_N_SprintTyMatch_cp_91836._N_ctx_91806, expr, _N_SprintTyMatch_cp_91836._N_current_fun_name_91804, is_top_level: true, _N_SprintTyMatch_cp_91836._N_indentation_91802 + "  ", _N_SprintTyMatch_cp_91836._N_result_91800);
	}

	private static void _N_print_pattern_91844(_N_closureOf_SprintTyMatch_91795 _N_SprintTyMatch_cp_91843, Pattern pattern)
	{
		_N_append_91809(_N_SprintTyMatch_cp_91843, SprintPattern(pattern));
	}

	private static void _N_print_patterns_91851(_N_closureOf_SprintTyMatch_91795 _N_SprintTyMatch_cp_91850, list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>> patterns)
	{
		while (patterns is list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)
		{
			Pattern field;
			TExpr field2;
			list<Nemerle.Builtins.Tuple<LocalValue, TExpr>> assigns;
			if ((object)((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).tl == list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Nil._N_constant_object)
			{
				field = ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field0;
				field2 = ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field1;
				assigns = ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field2;
				_N_do_print_91858(_N_SprintTyMatch_cp_91850, field, field2, assigns, " =>\n");
				break;
			}
			field = ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field0;
			field2 = ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field1;
			assigns = ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).hd.Field2;
			list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>> list = ((list<Nemerle.Builtins.Tuple<Pattern, TExpr, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>>>.Cons)patterns).tl;
			_N_do_print_91858(_N_SprintTyMatch_cp_91850, field, field2, assigns, "\n");
			patterns = list;
		}
	}

	private static void _N_do_print_91858(_N_closureOf_SprintTyMatch_91795 _N_SprintTyMatch_cp_91857, Pattern pattern, TExpr guard, list<Nemerle.Builtins.Tuple<LocalValue, TExpr>> assigns, string terminator)
	{
		_N_indent_91816(_N_SprintTyMatch_cp_91857);
		_N_append_91809(_N_SprintTyMatch_cp_91857, "  | ");
		_N_print_pattern_91844(_N_SprintTyMatch_cp_91857, pattern);
		if (!(guard is TExpr.Literal) || !(((TExpr.Literal)guard).val is Literal.Bool) || !((Literal.Bool)((TExpr.Literal)guard).val).val)
		{
			_N_append_91809(_N_SprintTyMatch_cp_91857, " when ");
			_N_recurse_91823(_N_SprintTyMatch_cp_91857, guard);
		}
		if (!assigns.IsEmpty)
		{
			_N_append_91809(_N_SprintTyMatch_cp_91857, " with (");
			list<Nemerle.Builtins.Tuple<LocalValue, TExpr>> list = assigns;
			while (list is list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Cons)
			{
				Nemerle.Builtins.Tuple<LocalValue, TExpr> hd = ((list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Cons)list).hd;
				list = ((list<Nemerle.Builtins.Tuple<LocalValue, TExpr>>.Cons)list).tl;
				LocalValue field = hd.Field0;
				TExpr field2 = hd.Field1;
				_N_append_91809(_N_SprintTyMatch_cp_91857, field.Name);
				_N_append_91809(_N_SprintTyMatch_cp_91857, " = ");
				_N_recurse_91823(_N_SprintTyMatch_cp_91857, field2);
				_N_append_91809(_N_SprintTyMatch_cp_91857, ", ");
				list = list;
			}
		}
		_N_append_91809(_N_SprintTyMatch_cp_91857, terminator);
	}

	private static bool _N_expr_is_bool_91885(TExpr expr)
	{
		int result;
		if (expr.Type.IsFixed)
		{
			FixedType fixedValue = expr.Type.FixedValue;
			if (fixedValue is FixedType.Class && (object)((FixedType.Class)fixedValue).args == list<TypeVar>.Nil._N_constant_object)
			{
				TypeInfo tycon = ((FixedType.Class)fixedValue).tycon;
				result = ((tycon.FullName == "System.Boolean" || tycon.FullName == "Nemerle.Core.bool") ? 1 : 0);
			}
			else
			{
				result = 0;
			}
		}
		else
		{
			result = 0;
		}
		return (byte)result != 0;
	}

	private static bool _N_expr_is_true_91901(TExpr expr)
	{
		return (expr is TExpr.Literal && ((TExpr.Literal)expr).val is Literal.Bool && ((Literal.Bool)((TExpr.Literal)expr).val).val) ? true : false;
	}

	private static bool _N_expr_is_false_91909(TExpr expr)
	{
		return (expr is TExpr.Literal && ((TExpr.Literal)expr).val is Literal.Bool && !((Literal.Bool)((TExpr.Literal)expr).val).val) ? true : false;
	}

	private static void _N_append_92346(_N_closureOf_SprintTyExpr_92330 _N_SprintTyExpr_cp_92345, string x)
	{
		StringBuilder stringBuilder = _N_SprintTyExpr_cp_92345._N_result_92337.Append(x);
	}

	private static void _N_recurse_no_indent_92362(_N_closureOf_SprintTyExpr_92330 _N_SprintTyExpr_cp_92361, TExpr expr)
	{
		SprintTyExpr(_N_SprintTyExpr_cp_92361._N_ctx_92343, expr, _N_SprintTyExpr_cp_92361._N_current_fun_name_92341, is_top_level: true, _N_SprintTyExpr_cp_92361._N_indentation_92339, _N_SprintTyExpr_cp_92361._N_result_92337);
	}

	private static void _N_recurse_and_indent_92369(_N_closureOf_SprintTyExpr_92330 _N_SprintTyExpr_cp_92368, TExpr expr)
	{
		SprintTyExpr(_N_SprintTyExpr_cp_92368._N_ctx_92343, expr, _N_SprintTyExpr_cp_92368._N_current_fun_name_92341, is_top_level: true, _N_SprintTyExpr_cp_92368._N_indentation_92339 + "  ", _N_SprintTyExpr_cp_92368._N_result_92337);
	}

	private static void _N_print_type_92376(_N_closureOf_SprintTyExpr_92330 _N_SprintTyExpr_cp_92375, TypeVar ty)
	{
		_N_append_92346(_N_SprintTyExpr_cp_92375, ty.ToString());
	}

	private static void _N_print_expr_list_92383(_N_closureOf_SprintTyExpr_92330 _N_SprintTyExpr_cp_92382, string begin, list<TExpr> args, string separator, string end)
	{
		_N_append_92346(_N_SprintTyExpr_cp_92382, begin);
		NString.SeparatedCalls(separator, args, _N_SprintTyExpr_cp_92382._N_recurse_92335, _N_SprintTyExpr_cp_92382._N_result_92337);
		_N_append_92346(_N_SprintTyExpr_cp_92382, end);
	}

	private static void _N_print_fun_call_parms_92390(_N_closureOf_SprintTyExpr_92330 _N_SprintTyExpr_cp_92389, list<Parm> parms)
	{
		FunctionVoid<Parm> f = new _N__N_lambda__92144__92396(_N_SprintTyExpr_cp_92389);
		NString.SeparatedCalls(", ", parms, f, _N_SprintTyExpr_cp_92389._N_result_92337);
	}

	private static bool _N_is_list_cons_92405(IMember mem)
	{
		return mem.DeclaringType.FullName == "Nemerle.Core.list.Cons" && mem.Name == ".ctor";
	}

	private static bool _N_is_list_nil_92413(IMember mem)
	{
		return mem.DeclaringType.FullName == "Nemerle.Core.list.Nil" && mem.Name == "_N_constant_object";
	}

	private static bool _N_need_curly_braces_92422(_N_closureOf_SprintTyExpr_92330 _N_SprintTyExpr_cp_92421, TExpr expr)
	{
		int result;
		while (true)
		{
			TExpr obj;
			if (expr is TExpr.FieldMember)
			{
				obj = ((TExpr.FieldMember)expr).obj;
			}
			else if (expr is TExpr.MethodRef)
			{
				obj = ((TExpr.MethodRef)expr).obj;
			}
			else
			{
				if (expr is TExpr.Assign)
				{
					obj = ((TExpr.Assign)expr).target;
					TExpr source = ((TExpr.Assign)expr).source;
					if (_N_need_curly_braces_92422(_N_SprintTyExpr_cp_92421, obj))
					{
						result = 1;
						break;
					}
					expr = source;
					continue;
				}
				if (expr is TExpr.DefValIn)
				{
					result = 1;
					break;
				}
				if (expr is TExpr.Throw)
				{
					obj = ((TExpr.Throw)expr).exn;
					expr = obj;
					continue;
				}
				if (expr is TExpr.Sequence)
				{
					result = 1;
					break;
				}
				if (expr is TExpr.ArrayIndexer)
				{
					obj = ((TExpr.ArrayIndexer)expr).obj;
				}
				else
				{
					if (expr is TExpr.PointerIndexer)
					{
						obj = ((TExpr.PointerIndexer)expr).obj;
						expr = obj;
						continue;
					}
					if (!(expr is TExpr.PropertyMember))
					{
						result = ((expr is TExpr.DefFunctionsIn) ? 1 : 0);
						break;
					}
					obj = ((TExpr.PropertyMember)expr).obj;
				}
			}
			expr = obj;
		}
		return (byte)result != 0;
	}

	private static void _N_print_local_fun_decl_92443(_N_closureOf_SprintTyExpr_92330 _N_SprintTyExpr_cp_92442, string prefix, TFunHeader fun_decl)
	{
		Function<TParameter, string> convert = new _N_printParam__92449(_N_SprintTyExpr_cp_92442);
		string text = print_fun_typarms(fun_decl.TypeParameters);
		string name = fun_decl.Name;
		TypeVar returnType = fun_decl.ReturnType;
		_N_append_92346(_N_SprintTyExpr_cp_92442, Convert.ToString(prefix) + " " + Convert.ToString(name) + Convert.ToString(text) + "(" + string.Join(", ", NCollectionsExtensions.MapToArray(fun_decl.Parameters, convert)) + ") : " + Convert.ToString(returnType));
		_N_append_92346(_N_SprintTyExpr_cp_92442, "\n");
		_N_append_92346(_N_SprintTyExpr_cp_92442, "{\n");
		FunBody body = fun_decl.body;
		if (body is FunBody.Typed)
		{
			TExpr expr = ((FunBody.Typed)body).expr;
			SprintTyExpr(_N_SprintTyExpr_cp_92442._N_ctx_92343, expr, new option<string>.Some(fun_decl.Name), is_top_level: true, _N_SprintTyExpr_cp_92442._N_indentation_92339 + "  ", _N_SprintTyExpr_cp_92442._N_result_92337);
		}
		_N_append_92346(_N_SprintTyExpr_cp_92442, string.Concat("\n" + _N_SprintTyExpr_cp_92442._N_indentation_92339, "}\n"));
	}

	private static void _N_print_case_92573(_N_closureOf_SprintTyExpr_92330 _N_SprintTyExpr_cp_92572, Try_case @case)
	{
		if (@case is Try_case.Fault)
		{
			TExpr handler = ((Try_case.Fault)@case).handler;
			_N_recurse_and_indent_92369(_N_SprintTyExpr_cp_92572, handler);
			return;
		}
		if (@case is Try_case.Catch)
		{
			LocalValue exn = ((Try_case.Catch)@case).exn;
			TExpr handler = ((Try_case.Catch)@case).handler;
			_N_append_92346(_N_SprintTyExpr_cp_92572, string.Concat(string.Concat(string.Concat("\n  " + _N_SprintTyExpr_cp_92572._N_indentation_92339, "| "), exn.Name), " is "));
			_N_print_type_92376(_N_SprintTyExpr_cp_92572, exn.Type);
			_N_append_92346(_N_SprintTyExpr_cp_92572, " =>\n");
			_N_recurse_and_indent_92369(_N_SprintTyExpr_cp_92572, handler);
			return;
		}
		if (@case is Try_case.Filter)
		{
			LocalValue exn = ((Try_case.Filter)@case).exn;
			TExpr handler = ((Try_case.Filter)@case).filter;
			TExpr handler2 = ((Try_case.Filter)@case).handler;
			_N_append_92346(_N_SprintTyExpr_cp_92572, string.Concat(string.Concat(string.Concat("\n  " + _N_SprintTyExpr_cp_92572._N_indentation_92339, "| "), exn.Name), " is "));
			_N_print_type_92376(_N_SprintTyExpr_cp_92572, exn.Type);
			_N_append_92346(_N_SprintTyExpr_cp_92572, " when (");
			_N_SprintTyExpr_cp_92572._N_recurse_92335.apply_void(handler);
			_N_append_92346(_N_SprintTyExpr_cp_92572, ") =>\n");
			_N_recurse_and_indent_92369(_N_SprintTyExpr_cp_92572, handler2);
			return;
		}
		throw new MatchFailureException();
	}
}
