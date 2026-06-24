using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Compiler.Parsetree;
using Nemerle.Core;

namespace Nemerle.Compiler;

public class EventBuilder : MemberBuilder, IEvent
{
	private sealed class _N_closureOf_Compile_72664
	{
		internal EventBuilder _N__N_closurised_this_ptr_72669;

		internal _N_closureOf_Compile_72664()
		{
		}
	}

	private sealed class _N__N_lambda__72640__72674 : Function<AttributeTargets, CustomAttributeBuilder, bool, string>
	{
		[SpecialName]
		private _N_closureOf_Compile_72664 _N_Compile_closure_72678;

		public _N__N_lambda__72640__72674(_N_closureOf_Compile_72664 _N_Compile_closure_72678)
		{
			this._N_Compile_closure_72678 = _N_Compile_closure_72678;
		}

		[SpecialName]
		public sealed override string apply(AttributeTargets target, CustomAttributeBuilder a, bool shouldEmit)
		{
			object result;
			if ((target & AttributeTargets.Event) != 0)
			{
				if (shouldEmit)
				{
					_N_Compile_closure_72678._N__N_closurised_this_ptr_72669.event_builder.SetCustomAttribute(a);
				}
				result = null;
			}
			else
			{
				result = "event " + _N_Compile_closure_72678._N__N_closurised_this_ptr_72669.ToString();
			}
			return (string)result;
		}
	}

	private sealed class _N_closureOf__ctor_72713
	{
		internal ClassMember.Event _N_eventAst_72722;

		internal EventBuilder _N__N_closurised_this_ptr_72720;

		internal EventBuilder _N_self_72718;

		internal _N_closureOf__ctor_72713()
		{
		}
	}

	private readonly MethodBuilder adder;

	private readonly MethodBuilder remover;

	internal System.Reflection.Emit.EventBuilder event_builder;

	internal readonly FieldBuilder storage_field;

	public new ClassMember.Event Ast => (ClassMember.Event)base.Ast;

	public override MemberTypes MemberKind => MemberTypes.Event;

	protected override AttributeTargets MacroTarget => AttributeTargets.Event;

	protected override list<SyntaxElement> MacroSelfParams => new list<SyntaxElement>.Cons(new SyntaxElement.TypeBuilder(declaring_type), new list<SyntaxElement>.Cons(new SyntaxElement.EventBuilder(this), list<SyntaxElement>.Nil._N_constant_object));

	internal override void CreateEmitBuilder(System.Reflection.Emit.TypeBuilder tb)
	{
		Type systemType = GetMemType().GetSystemType();
		event_builder = tb.DefineEvent(Name, EventAttributes.None, systemType);
	}

	internal override void Compile()
	{
		_N_closureOf_Compile_72664 n_closureOf_Compile_ = new _N_closureOf_Compile_72664();
		n_closureOf_Compile_._N__N_closurised_this_ptr_72669 = this;
		base.Compile();
		if (!modifiers.IsEmpty)
		{
			AttributesAndModifiers attributesAndModifiers = modifiers;
			TypeBuilder ti = declaring_type;
			Function<AttributeTargets, CustomAttributeBuilder, bool, string> function = new _N__N_lambda__72640__72674(n_closureOf_Compile_);
			attributesAndModifiers.SaveCustomAttributes(ti, function);
		}
		event_builder.SetAddOnMethod(adder.GetMethodInfo());
		event_builder.SetRemoveOnMethod(remover.GetMethodInfo());
	}

	public EventBuilder(TypeBuilder par, ClassMember.Event eventAst)
	{
		_N_closureOf__ctor_72713 n_closureOf__ctor_ = new _N_closureOf__ctor_72713
		{
			_N_eventAst_72722 = eventAst
		};
		base._002Ector(par, n_closureOf__ctor_._N_eventAst_72722);
		n_closureOf__ctor_._N__N_closurised_this_ptr_72720 = this;
		ty = par.BindFixedType(n_closureOf__ctor_._N_eventAst_72722.ty);
		n_closureOf__ctor_._N_self_72718 = this;
		if (n_closureOf__ctor_._N_eventAst_72722.field != null)
		{
			if (!declaring_type.IsInterface)
			{
				if (IsStatic)
				{
					AttributesAndModifiers attributesAndModifiers = n_closureOf__ctor_._N_eventAst_72722.field.modifiers;
					attributesAndModifiers.mods |= NemerleModifiers.Static;
				}
				storage_field = new FieldBuilder(par, n_closureOf__ctor_._N_eventAst_72722.field);
				declaring_type.AddMember(storage_field);
			}
			_N_update_mfunction_72728(n_closureOf__ctor_, n_closureOf__ctor_._N_eventAst_72722.add, "add");
			_N_update_mfunction_72728(n_closureOf__ctor_, n_closureOf__ctor_._N_eventAst_72722.remove, "remove");
		}
		adder = _N_make_method_72750(n_closureOf__ctor_, n_closureOf__ctor_._N_eventAst_72722.add);
		remover = _N_make_method_72750(n_closureOf__ctor_, n_closureOf__ctor_._N_eventAst_72722.remove);
		Manager.MarkAsUsed(remover);
		ty.CheckAccessibility(this, accessibility);
	}

	private EventInfo GetEventInfo()
	{
		//Discarded unreachable code: IL_001a
		throw new AssertionException("ncc\\hierarchy\\ClassMembers.n", 1613, "", "");
	}

	EventInfo IEvent.GetEventInfo()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetEventInfo
		return this.GetEventInfo();
	}

	public override System.Reflection.MemberInfo GetHandle()
	{
		return null;
	}

	public MethodBuilder GetAdder()
	{
		return adder;
	}

	public MethodBuilder GetRemover()
	{
		return remover;
	}

	public override void CheckAttributes()
	{
		check_method_like_attributes("event", "events");
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			base.RelocateImplInternal(_info);
			_info.VisitedObjects[this] = 0;
			storage_field?.RelocateImplInternal(_info);
			remover?.RelocateImplInternal(_info);
			adder?.RelocateImplInternal(_info);
		}
	}

	private void _N_update_mfunction_72728(_N_closureOf__ctor_72713 _N__ctor_cp_72727, ClassMember.Function meth, string which_accessor)
	{
		if (declaring_type.IsInterface)
		{
			meth.body = FunBody.Abstract._N_constant_object;
			return;
		}
		PExpr expr = ((!IsStatic) ? ((PExpr)new PExpr.This()) : ((PExpr)new PExpr.Typeof(new PExpr.Ref(declaring_type.ParsedName))));
		Name pName = _N__ctor_cp_72727._N_eventAst_72722.field.PName;
		PExpr.MacroCall expr2 = ((!(which_accessor == "add")) ? new PExpr.MacroCall(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("lock", _N_MacroContexts.Get(7, ManagerClass.Instance)), ManagerClass.Instance.NameTree.ExactPath(new list<string>.Cons("Nemerle", new list<string>.Cons("Core", new list<string>.Cons("lock", list<string>.Nil._N_constant_object)))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(Macros.QuotationChoose(expr)), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("-=", _N_MacroContexts.Get(7, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(pName), new list<PExpr>.Cons(new PExpr.Ref(pName.NewName("value")), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object))), list<SyntaxElement>.Nil._N_constant_object))) : new PExpr.MacroCall(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("lock", _N_MacroContexts.Get(7, ManagerClass.Instance)), ManagerClass.Instance.NameTree.ExactPath(new list<string>.Cons("Nemerle", new list<string>.Cons("Core", new list<string>.Cons("lock", list<string>.Nil._N_constant_object)))), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(Macros.QuotationChoose(expr)), new list<SyntaxElement>.Cons(new SyntaxElement.Expression(new PExpr.Sequence(new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("+=", _N_MacroContexts.Get(7, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Ref(pName), new list<PExpr>.Cons(new PExpr.Ref(pName.NewName("value")), list<PExpr>.Nil._N_constant_object))), list<PExpr>.Nil._N_constant_object))), list<SyntaxElement>.Nil._N_constant_object))));
		meth.body = new FunBody.Parsed(expr2);
	}

	private MethodBuilder _N_make_method_72750(_N_closureOf__ctor_72713 _N__ctor_cp_72749, ClassMember.Function mfunc)
	{
		if (mfunc.Env == null)
		{
			mfunc.SetEnv(Env);
		}
		MemberBuilder.UpdateEmbeddedModifiers(_N__ctor_cp_72749._N_self_72718.attributes, ref mfunc.modifiers.mods);
		MethodBuilder methodBuilder = Manager.ComponentsFactory.CreateMethodBuilder(_N__ctor_cp_72749._N_self_72718.declaring_type, mfunc);
		_N__ctor_cp_72749._N_self_72718.declaring_type.AddMember(methodBuilder);
		methodBuilder.MarkWithSpecialName();
		return methodBuilder;
	}

	[SpecialName]
	IMethod IEvent.GetAdder()
	{
		return GetAdder();
	}

	[SpecialName]
	IMethod IEvent.GetRemover()
	{
		return GetRemover();
	}
}
