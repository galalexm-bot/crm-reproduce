using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using Nemerle.Builtins;
using Nemerle.Collections;
using Nemerle.Compiler.Parsetree;
using Nemerle.Core;
using Nemerle.Internal;
using Nemerle.Utility;

namespace Nemerle.Compiler;

public class TypesManager : IDisposable, ISupportRelocation
{
	protected internal class AttributeMacroExpansion : IComparable<AttributeMacroExpansion>, ISupportRelocation
	{
		public readonly AttributeTargets Target;

		public readonly MacroPhase Phase;

		public readonly PExpr Expression;

		private readonly list<SyntaxElement> InitialParms;

		private readonly TypeBuilder TBuilder;

		private readonly MethodBuilder CurrentMethod;

		internal int AddedNr;

		protected override GlobalEnv GEnv => TBuilder.GlobalEnv;

		protected override TypeVarEnv TEnv => TBuilder.Tenv;

		public int CompareTo(AttributeMacroExpansion other)
		{
			return checked((Phase != other.Phase) ? (other.Phase - Phase) : ((Target == other.Target) ? (other.AddedNr - AddedNr) : (other.Target - Target)));
		}

		public override string ToString()
		{
			string text = ((TBuilder == null) ? "" : TBuilder.ToString());
			return Convert.ToString(text) + ": " + Convert.ToString(Expression) + " - (" + Convert.ToString(AddedNr) + ") - " + Convert.ToString(Target) + " " + Convert.ToString(Phase);
		}

		public bool Expand()
		{
			option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>> option = MacroRegistry.lookup_macro(GEnv, Expression, Suffix(Target, Phase));
			int result;
			if (option == option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>>.None._N_constant_object)
			{
				result = 0;
			}
			else
			{
				if (!(option is option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>>.Some))
				{
					throw new MatchFailureException();
				}
				Name field = ((option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>>.Some)option).val.Field0;
				IMacro field2 = ((option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>>.Some)option).val.Field1;
				list<SyntaxElement> list = ((option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>>.Some)option).val.Field2;
				list<SyntaxElement> args = InitialParms + list;
				TypeVarEnv tenv = ((CurrentMethod != null) ? CurrentMethod.Header.tenv : TEnv);
				GlobalEnv env = field.GetEnv(GEnv);
				try
				{
					GEnv.Manager.MacroColors.PushNewColor(field.color, env);
					Location location = Expression.Location;
					bool flag = location.FileIndex != 0;
					if (flag)
					{
						LocationStack.Push(location);
					}
					PExpr pExpr;
					try
					{
						pExpr = field2.Run(GEnv.Manager.ComponentsFactory.CreateTyper(TBuilder, tenv, CurrentMethod, env), args);
					}
					finally
					{
						if (flag)
						{
							LocationStack.RemoveTop();
						}
					}
					PExpr pExpr2 = pExpr;
					if (pExpr2 != null)
					{
						throw new AssertionException("ncc\\hierarchy\\TypesManager.n", 109, "res == null", "");
					}
				}
				finally
				{
					GEnv.Manager.MacroColors.PopColor();
				}
				result = 1;
			}
			return (byte)result != 0;
		}

		public static string Suffix(AttributeTargets target, MacroPhase stage)
		{
			return target switch
			{
				AttributeTargets.Method => ":method", 
				AttributeTargets.Property => ":property", 
				AttributeTargets.Field => ":field", 
				AttributeTargets.Event => ":event", 
				AttributeTargets.Parameter => ":param", 
				AttributeTargets.Assembly => ":assembly", 
				AttributeTargets.Class => ":type", 
				_ => throw new ArgumentException("macro target " + Convert.ToString(target) + " is not allowed"), 
			} + stage switch
			{
				MacroPhase.BeforeInheritance => ":postscan", 
				MacroPhase.BeforeTypedMembers => ":preadd", 
				MacroPhase.WithTypedMembers => ":postadd", 
				_ => throw new ArgumentException("not allowed " + Convert.ToString(stage) + " stage of macro"), 
			};
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (_info.VisitedObjects.ContainsKey(this))
			{
				return;
			}
			_info.VisitedObjects[this] = 0;
			CurrentMethod?.RelocateImplInternal(_info);
			TBuilder?.RelocateImplInternal(_info);
			list<SyntaxElement> initialParms = InitialParms;
			if (initialParms != null)
			{
				initialParms = initialParms;
				while (initialParms is list<SyntaxElement>.Cons)
				{
					SyntaxElement hd = ((list<SyntaxElement>.Cons)initialParms).hd;
					initialParms = ((list<SyntaxElement>.Cons)initialParms).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					initialParms = initialParms;
				}
			}
			Expression?.RelocateImplInternal(_info);
		}

		void ISupportRelocation.RelocateImpl(RelocationInfo _info)
		{
			//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
			this.RelocateImplInternal(_info);
		}

		[RecordCtor]
		public AttributeMacroExpansion([MappedMember("Target")] AttributeTargets target, [MappedMember("Phase")] MacroPhase phase, [MappedMember("Expression")] PExpr expression, [MappedMember("InitialParms")] list<SyntaxElement> initialParms, [MappedMember("TBuilder")] TypeBuilder tBuilder, [MappedMember("CurrentMethod")] MethodBuilder currentMethod)
		{
			Target = target;
			Phase = phase;
			Expression = expression;
			InitialParms = initialParms;
			TBuilder = tBuilder;
			CurrentMethod = currentMethod;
		}
	}

	protected internal class AssemblyAttributeMacroExpansion : AttributeMacroExpansion
	{
		private readonly GlobalEnv genv;

		protected override GlobalEnv GEnv => genv;

		protected override TypeVarEnv TEnv => (GEnv != null) ? GEnv.Manager.emptyTEnv : null;

		[RecordCtor]
		public AssemblyAttributeMacroExpansion([MappedMember("Target")] AttributeTargets target, [MappedMember("Phase")] MacroPhase phase, [MappedMember("Expression")] PExpr expression, [MappedMember("InitialParms")] list<SyntaxElement> initialParms, [MappedMember("TBuilder")] TypeBuilder tBuilder, [MappedMember("CurrentMethod")] MethodBuilder currentMethod, [MappedMember("genv")] GlobalEnv genv)
			: base(target, phase, expression, initialParms, tBuilder, currentMethod)
		{
			this.genv = genv;
		}
	}

	private sealed class _N_closureOf_CreateAssembly_62053
	{
		internal AssemblyBuilder _N__N_obj_cache_62058;

		internal _N_closureOf_CreateAssembly_62053()
		{
		}
	}

	private sealed class _N__N_method_lambda__62078 : FunctionVoid<CustomAttributeBuilder>
	{
		[SpecialName]
		private _N_closureOf_CreateAssembly_62053 _N_CreateAssembly_closure_62082;

		public _N__N_method_lambda__62078(_N_closureOf_CreateAssembly_62053 _N_CreateAssembly_closure_62082)
		{
			this._N_CreateAssembly_closure_62082 = _N_CreateAssembly_closure_62082;
		}

		[SpecialName]
		public sealed override void apply_void(CustomAttributeBuilder _N__62077)
		{
			_N_CreateAssembly_closure_62082._N__N_obj_cache_62058.SetCustomAttribute(_N__62077);
		}
	}

	private sealed class _N_closureOf_EmitDecls_62299
	{
		internal TypesManager _N__N_closurised_this_ptr_62304;

		internal _N_closureOf_EmitDecls_62299()
		{
		}
	}

	private sealed class _N__N_lambda__62203__62306 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_EmitDecls_62299 _N_EmitDecls_closure_62310;

		public _N__N_lambda__62203__62306(_N_closureOf_EmitDecls_62299 _N_EmitDecls_closure_62310)
		{
			this._N_EmitDecls_closure_62310 = _N_EmitDecls_closure_62310;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_EmitDecls_closure_62310._N__N_closurised_this_ptr_62304.compile_all_tyinfos(aux_phase: false);
			list<Nemerle.Builtins.Tuple<CustomAttributeBuilder, bool>> list = _N_EmitDecls_closure_62310._N__N_closurised_this_ptr_62304.Manager.AttributeCompiler.GetCompiledAssemblyAttributes(_N_EmitDecls_closure_62310._N__N_closurised_this_ptr_62304.assembly_attributes);
			CustomAttributeBuilder field;
			while (list is list<Nemerle.Builtins.Tuple<CustomAttributeBuilder, bool>>.Cons)
			{
				Nemerle.Builtins.Tuple<CustomAttributeBuilder, bool> hd = ((list<Nemerle.Builtins.Tuple<CustomAttributeBuilder, bool>>.Cons)list).hd;
				list = ((list<Nemerle.Builtins.Tuple<CustomAttributeBuilder, bool>>.Cons)list).tl;
				field = hd.Field0;
				if (hd.Field1)
				{
					_N_EmitDecls_closure_62310._N__N_closurised_this_ptr_62304._assembly_builder.SetCustomAttribute(field);
				}
				list = list;
			}
			if (_N_EmitDecls_closure_62310._N__N_closurised_this_ptr_62304.Manager.Options.EmitDebug)
			{
				field = _N_EmitDecls_closure_62310._N__N_closurised_this_ptr_62304.Manager.AttributeCompiler.MakeEmittedAttribute(_N_EmitDecls_closure_62310._N__N_closurised_this_ptr_62304.SystemTypeCache.DebuggableAttribute, new Type[1] { _N_EmitDecls_closure_62310._N__N_closurised_this_ptr_62304.SystemTypeCache.DebuggableAttribute_DebuggingModes }, DebuggableAttribute.DebuggingModes.DisableOptimizations | DebuggableAttribute.DebuggingModes.Default);
				_N_EmitDecls_closure_62310._N__N_closurised_this_ptr_62304._assembly_builder.SetCustomAttribute(field);
			}
			field = _N_EmitDecls_closure_62310._N__N_closurised_this_ptr_62304.Manager.AttributeCompiler.MakeEmittedAttribute(_N_EmitDecls_closure_62310._N__N_closurised_this_ptr_62304.SystemTypeCache.CompilationRelaxationsAttribute, 8);
			_N_EmitDecls_closure_62310._N__N_closurised_this_ptr_62304._assembly_builder.SetCustomAttribute(field);
		}
	}

	private sealed class _N_closureOf_compile_all_tyinfos_62733
	{
		internal bool _N_aux_phase_62740;

		internal TypesManager _N__N_closurised_this_ptr_62738;

		internal _N_closureOf_compile_all_tyinfos_62733()
		{
		}
	}

	private sealed class _N_create_type_emit_builder__62752 : FunctionVoid<TypeBuilder>
	{
		[SpecialName]
		private _N_closureOf_compile_all_tyinfos_62733 _N_compile_all_tyinfos_closure_62756;

		public _N_create_type_emit_builder__62752(_N_closureOf_compile_all_tyinfos_62733 _N_compile_all_tyinfos_closure_62756)
		{
			this._N_compile_all_tyinfos_closure_62756 = _N_compile_all_tyinfos_closure_62756;
		}

		[SpecialName]
		public sealed override void apply_void(TypeBuilder ti)
		{
			if (_N_compile_all_tyinfos_closure_62756._N__N_closurised_this_ptr_62738._N_allow_it_62743(_N_compile_all_tyinfos_closure_62756, ti))
			{
				ti.CreateEmitBuilder();
				if ((ti.Attributes & NemerleModifiers.Macro) != 0)
				{
					CustomAttributeBuilder customAttribute = _N_compile_all_tyinfos_closure_62756._N__N_closurised_this_ptr_62738.Manager.AttributeCompiler.MakeEmittedAttribute(_N_compile_all_tyinfos_closure_62756._N__N_closurised_this_ptr_62738.SystemTypeCache.ContainsMacroAttribute, ti.GetTypeBuilder().FullName);
					_N_compile_all_tyinfos_closure_62756._N__N_closurised_this_ptr_62738._assembly_builder.SetCustomAttribute(customAttribute);
				}
			}
		}
	}

	private sealed class _N_emit_decls__62767 : FunctionVoid<TypeBuilder>
	{
		[SpecialName]
		private _N_closureOf_compile_all_tyinfos_62733 _N_compile_all_tyinfos_closure_62771;

		public _N_emit_decls__62767(_N_closureOf_compile_all_tyinfos_62733 _N_compile_all_tyinfos_closure_62771)
		{
			this._N_compile_all_tyinfos_closure_62771 = _N_compile_all_tyinfos_closure_62771;
		}

		[SpecialName]
		public sealed override void apply_void(TypeBuilder ti)
		{
			if (_N_compile_all_tyinfos_closure_62771._N__N_closurised_this_ptr_62738._N_allow_it_62743(_N_compile_all_tyinfos_closure_62771, ti))
			{
				ti.CreateEmitDeclarations();
			}
		}
	}

	private sealed class _N_emit_impl__62779 : FunctionVoid<TypeBuilder>
	{
		[SpecialName]
		private _N_closureOf_compile_all_tyinfos_62733 _N_compile_all_tyinfos_closure_62783;

		public _N_emit_impl__62779(_N_closureOf_compile_all_tyinfos_62733 _N_compile_all_tyinfos_closure_62783)
		{
			this._N_compile_all_tyinfos_closure_62783 = _N_compile_all_tyinfos_closure_62783;
		}

		[SpecialName]
		public sealed override void apply_void(TypeBuilder ti)
		{
			if (_N_compile_all_tyinfos_closure_62783._N__N_closurised_this_ptr_62738._N_allow_it_62743(_N_compile_all_tyinfos_closure_62783, ti))
			{
				_N_compile_all_tyinfos_closure_62783._N__N_closurised_this_ptr_62738.Manager.MarkTypeBuilderCompiled();
				ti.EmitImplementation();
			}
		}
	}

	private sealed class _N__N_lambda__62711__62794 : FunctionVoid<TypeBuilder>
	{
		[SpecialName]
		private _N_closureOf_compile_all_tyinfos_62733 _N_compile_all_tyinfos_closure_62798;

		public _N__N_lambda__62711__62794(_N_closureOf_compile_all_tyinfos_62733 _N_compile_all_tyinfos_closure_62798)
		{
			this._N_compile_all_tyinfos_closure_62798 = _N_compile_all_tyinfos_closure_62798;
		}

		[SpecialName]
		public sealed override void apply_void(TypeBuilder tb)
		{
			if (_N_compile_all_tyinfos_closure_62798._N__N_closurised_this_ptr_62738._N_allow_it_62743(_N_compile_all_tyinfos_closure_62798, tb))
			{
				tb.UpdateEmittedInheritance();
			}
		}
	}

	private sealed class _N__N_lambda__62716__62809 : Function<TypeBuilder, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__62716__62809 Instance = new _N__N_lambda__62716__62809();

		[SpecialName]
		public sealed override bool apply(TypeBuilder x)
		{
			return x.IsEnum;
		}
	}

	private sealed class _N__N_lambda__62721__62819 : Function<TypeBuilder, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__62721__62819 Instance = new _N__N_lambda__62721__62819();

		[SpecialName]
		public sealed override bool apply(TypeBuilder x)
		{
			return !x.IsEnum;
		}
	}

	private sealed class _N__N_lambda__62726__62832 : Function<TypeBuilder, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__62726__62832 Instance = new _N__N_lambda__62726__62832();

		[SpecialName]
		public sealed override bool apply(TypeBuilder x)
		{
			return x.IsValueType && x.DeclaringType == null;
		}
	}

	private sealed class _N_closureOf_MaybeCompile_62864
	{
		internal MemberBuilder _N_mem_62869;

		internal _N_closureOf_MaybeCompile_62864()
		{
		}
	}

	private sealed class _N__N_lambda__62858__62874 : FunctionVoid
	{
		[SpecialName]
		private _N_closureOf_MaybeCompile_62864 _N_MaybeCompile_closure_62878;

		public _N__N_lambda__62858__62874(_N_closureOf_MaybeCompile_62864 _N_MaybeCompile_closure_62878)
		{
			this._N_MaybeCompile_closure_62878 = _N_MaybeCompile_closure_62878;
		}

		[SpecialName]
		public sealed override void apply_void()
		{
			_N_MaybeCompile_closure_62878._N_mem_62869.Compile();
		}
	}

	private sealed class _N__N_lambda__62978__62985 : FunctionVoid<TypeBuilder>
	{
		[SpecialName]
		public static readonly _N__N_lambda__62978__62985 Instance = new _N__N_lambda__62978__62985();

		[SpecialName]
		public sealed override void apply_void(TypeBuilder typeBuilder)
		{
			typeBuilder.construct_subtyping_map();
		}
	}

	private sealed class _N_closureOf_Iter_63017
	{
		internal FunctionVoid<TypeBuilder> _N_f_63028;

		internal int _N_working_on_63026;

		internal int _N_done_63024;

		internal FunctionVoid<TypeBuilder> _N_maybe_f_63022;

		internal _N_closureOf_Iter_63017()
		{
		}
	}

	private sealed class _N_maybe_f__63030 : FunctionVoid<TypeBuilder>
	{
		[SpecialName]
		private _N_closureOf_Iter_63017 _N_Iter_closure_63034;

		public _N_maybe_f__63030(_N_closureOf_Iter_63017 _N_Iter_closure_63034)
		{
			this._N_Iter_closure_63034 = _N_Iter_closure_63034;
		}

		[SpecialName]
		public sealed override void apply_void(TypeBuilder ti)
		{
			if (ti.phase == _N_Iter_closure_63034._N_done_63024)
			{
				return;
			}
			if (ti.phase == _N_Iter_closure_63034._N_working_on_63026)
			{
				ti.parent_type = null;
				Message.Error(ti.Location, string.Concat("type definition for `" + ti.FullName, "' is cyclic"));
				return;
			}
			ti.phase = _N_Iter_closure_63034._N_working_on_63026;
			Location location = ti.Location;
			bool flag = location.FileIndex != 0;
			if (flag)
			{
				LocationStack.Push(location);
			}
			try
			{
				if (ti.iterate_first != null)
				{
					list<TypeBuilder> list = ti.iterate_first;
					while (list is list<TypeBuilder>.Cons)
					{
						TypeBuilder hd = ((list<TypeBuilder>.Cons)list).hd;
						list<TypeBuilder> list2 = ((list<TypeBuilder>.Cons)list).tl;
						TypeBuilder n_wildcard_ = hd;
						_N_Iter_closure_63034._N_maybe_f_63022.apply_void(n_wildcard_);
						list = list2;
					}
				}
				_N_Iter_closure_63034._N_f_63028.apply_void(ti);
			}
			finally
			{
				if (flag)
				{
					LocationStack.RemoveTop();
				}
			}
			ti.phase = _N_Iter_closure_63034._N_done_63024;
		}
	}

	private sealed class _N_closureOf_IterConditionally_63075
	{
		internal FunctionVoid<TypeBuilder> _N_f_63082;

		internal Function<TypeBuilder, bool> _N_cond_63080;

		internal _N_closureOf_IterConditionally_63075()
		{
		}
	}

	private sealed class _N__N_lambda__63068__63084 : FunctionVoid<TypeBuilder>
	{
		[SpecialName]
		private _N_closureOf_IterConditionally_63075 _N_IterConditionally_closure_63088;

		public _N__N_lambda__63068__63084(_N_closureOf_IterConditionally_63075 _N_IterConditionally_closure_63088)
		{
			this._N_IterConditionally_closure_63088 = _N_IterConditionally_closure_63088;
		}

		[SpecialName]
		public sealed override void apply_void(TypeBuilder b)
		{
			if (_N_IterConditionally_closure_63088._N_cond_63080.apply(b))
			{
				_N_IterConditionally_closure_63088._N_f_63082.apply_void(b);
			}
		}
	}

	private sealed class _N__N_lambda__63097__63104 : Function<TypeBuilder, bool>
	{
		[SpecialName]
		public static readonly _N__N_lambda__63097__63104 Instance = new _N__N_lambda__63097__63104();

		[SpecialName]
		public sealed override bool apply(TypeBuilder x)
		{
			return x.DeclaringType == null;
		}
	}

	private sealed class _N_closureOf_TopIter_63124
	{
		internal FunctionVoid<TypeBuilder> _N_f_63129;

		internal _N_closureOf_TopIter_63124()
		{
		}
	}

	private sealed class _N_wrap__63131 : FunctionVoid<TypeBuilder>
	{
		[SpecialName]
		private _N_closureOf_TopIter_63124 _N_TopIter_closure_63135;

		public _N_wrap__63131(_N_closureOf_TopIter_63124 _N_TopIter_closure_63135)
		{
			this._N_TopIter_closure_63135 = _N_TopIter_closure_63135;
		}

		[SpecialName]
		public sealed override void apply_void(TypeBuilder x)
		{
			if (x.DeclaringType != null)
			{
				return;
			}
			Location location = x.Location;
			bool flag = location.FileIndex != 0;
			if (flag)
			{
				LocationStack.Push(location);
			}
			try
			{
				_N_TopIter_closure_63135._N_f_63129.apply_void(x);
			}
			finally
			{
				if (flag)
				{
					LocationStack.RemoveTop();
				}
			}
		}
	}

	private sealed class _N__N_lambda__63199__63306 : FunctionVoid<TypeBuilder>
	{
		[SpecialName]
		public static readonly _N__N_lambda__63199__63306 Instance = new _N__N_lambda__63199__63306();

		[SpecialName]
		public sealed override void apply_void(TypeBuilder x)
		{
			x.add_special_variant_methods();
		}
	}

	private sealed class _N__N_lambda__63204__63316 : FunctionVoid<TypeBuilder>
	{
		[SpecialName]
		public static readonly _N__N_lambda__63204__63316 Instance = new _N__N_lambda__63204__63316();

		[SpecialName]
		public sealed override void apply_void(TypeBuilder x)
		{
			x.check_bound_types();
		}
	}

	private sealed class _N__N_lambda__63209__63326 : FunctionVoid<TypeBuilder>
	{
		[SpecialName]
		public static readonly _N__N_lambda__63209__63326 Instance = new _N__N_lambda__63209__63326();

		[SpecialName]
		public sealed override void apply_void(TypeBuilder x)
		{
			x.process_macro_attributes(MacroPhase.BeforeTypedMembers);
		}
	}

	private sealed class _N__N_lambda__63214__63336 : FunctionVoid<TypeBuilder>
	{
		[SpecialName]
		public static readonly _N__N_lambda__63214__63336 Instance = new _N__N_lambda__63214__63336();

		[SpecialName]
		public sealed override void apply_void(TypeBuilder x)
		{
			x.AddEnumMembers();
		}
	}

	private sealed class _N__N_lambda__63219__63346 : FunctionVoid<TypeBuilder>
	{
		[SpecialName]
		public static readonly _N__N_lambda__63219__63346 Instance = new _N__N_lambda__63219__63346();

		[SpecialName]
		public sealed override void apply_void(TypeBuilder x)
		{
			x.add_members();
		}
	}

	private sealed class _N__N_lambda__63224__63356 : FunctionVoid<TypeBuilder>
	{
		[SpecialName]
		public static readonly _N__N_lambda__63224__63356 Instance = new _N__N_lambda__63224__63356();

		[SpecialName]
		public sealed override void apply_void(TypeBuilder x)
		{
			x.process_macro_attributes(MacroPhase.WithTypedMembers);
		}
	}

	private sealed class _N__N_lambda__63229__63366 : FunctionVoid<TypeBuilder>
	{
		[SpecialName]
		public static readonly _N__N_lambda__63229__63366 Instance = new _N__N_lambda__63229__63366();

		[SpecialName]
		public sealed override void apply_void(TypeBuilder x)
		{
			x.add_constant_variant_ctors();
		}
	}

	private sealed class _N__N_lambda__63234__63376 : FunctionVoid<TypeBuilder>
	{
		[SpecialName]
		public static readonly _N__N_lambda__63234__63376 Instance = new _N__N_lambda__63234__63376();

		[SpecialName]
		public sealed override void apply_void(TypeBuilder x)
		{
			if ((x.Attributes & NemerleModifiers.SpecialName) != 0)
			{
				x.mark_members_with_special_name();
			}
		}
	}

	private sealed class _N_check_method_implements__63389 : FunctionVoid<TypeBuilder>
	{
		[SpecialName]
		public static readonly _N_check_method_implements__63389 Instance = new _N_check_method_implements__63389();

		[SpecialName]
		public sealed override void apply_void(TypeBuilder ti)
		{
			if (!ti.IsInterface)
			{
				ti.resolve_method_implements();
			}
		}
	}

	private sealed class _N__N_lambda__63243__63402 : FunctionVoid<TypeBuilder>
	{
		[SpecialName]
		public static readonly _N__N_lambda__63243__63402 Instance = new _N__N_lambda__63243__63402();

		[SpecialName]
		public sealed override void apply_void(TypeBuilder x)
		{
			x.check_ctor_constraints();
		}
	}

	private sealed class _N__N_lambda__63467__63474 : FunctionVoid<TypeBuilder>
	{
		[SpecialName]
		public static readonly _N__N_lambda__63467__63474 Instance = new _N__N_lambda__63467__63474();

		[SpecialName]
		public sealed override void apply_void(TypeBuilder x)
		{
			if (x.type_builder != null)
			{
				if (x.CannotFinalize)
				{
					Message.Error(Location.Default, string.Concat("the type " + Convert.ToString(x) + " was not finalized, forgot the ", "TypeBuilder.Compile () on it?"));
					throw new Recovery();
				}
				x.FinalizeType();
			}
		}
	}

	private sealed class _N__N_lambda__63492__63505 : FunctionVoid<TypeBuilder>
	{
		[SpecialName]
		public static readonly _N__N_lambda__63492__63505 Instance = new _N__N_lambda__63492__63505();

		[SpecialName]
		public sealed override void apply_void(TypeBuilder _N__63491)
		{
			_N__63491.check_for_unused_global_symbols();
		}
	}

	private sealed class _N_closureOf_AddAssemblyAttribute_63551
	{
		internal GlobalEnv _N_env_63560;

		internal PExpr _N_attr_63558;

		internal TypesManager _N__N_closurised_this_ptr_63556;

		internal _N_closureOf_AddAssemblyAttribute_63551()
		{
		}
	}

	private sealed class _N_closureOf_GetInformationalAssemblyAttributes_63626
	{
		internal PExpr _N_attr_63635;

		internal List<Type> _N_typeList_63633;

		internal List<CustomAttributeBuilder> _N__N_obj_cache_63631;

		internal _N_closureOf_GetInformationalAssemblyAttributes_63626()
		{
		}
	}

	private sealed class _N__N_method_lambda__63691 : FunctionVoid<CustomAttributeBuilder>
	{
		[SpecialName]
		private _N_closureOf_GetInformationalAssemblyAttributes_63626 _N_GetInformationalAssemblyAttributes_closure_63695;

		public _N__N_method_lambda__63691(_N_closureOf_GetInformationalAssemblyAttributes_63626 _N_GetInformationalAssemblyAttributes_closure_63695)
		{
			this._N_GetInformationalAssemblyAttributes_closure_63695 = _N_GetInformationalAssemblyAttributes_closure_63695;
		}

		[SpecialName]
		public sealed override void apply_void(CustomAttributeBuilder _N__63690)
		{
			_N_GetInformationalAssemblyAttributes_closure_63695._N__N_obj_cache_63631.Add(_N__63690);
		}
	}

	private sealed class _N__N_lambda__63707__63734 : Function<string, int>
	{
		[SpecialName]
		public static readonly _N__N_lambda__63707__63734 Instance = new _N__N_lambda__63707__63734();

		[SpecialName]
		public sealed override int apply(string x)
		{
			return (!(x == "*")) ? ushort.Parse(x) : (-1);
		}
	}

	private sealed class _N_closureOf_CreateAssemblyName_63780
	{
		internal PExpr _N_attr_63785;

		internal _N_closureOf_CreateAssemblyName_63780()
		{
		}
	}

	private AssemblyName _assembly_name;

	private AssemblyBuilder _assembly_builder;

	internal ModuleBuilder _module_builder;

	public ISymbolWriter _debug_emit;

	internal bool contains_nemerle_specifics = false;

	internal readonly bool _need_entry_point;

	internal option<MethodInfo> _entry_point;

	private readonly string _OutputFileName;

	private int _cgil_phase;

	public list<TypeBuilder> infos = list<TypeBuilder>.Nil._N_constant_object;

	private List<Nemerle.Builtins.Tuple<GlobalEnv, PExpr>> assembly_attributes = new List<Nemerle.Builtins.Tuple<GlobalEnv, PExpr>>();

	internal int run_phase;

	private LocatingTextWriter _codeWriter;

	private readonly Heap<AttributeMacroExpansion> attribute_macros_queue = new Heap<AttributeMacroExpansion>(100);

	private bool is_expanding = false;

	public readonly ManagerClass Manager;

	public bool IsEmitting => _assembly_builder != null;

	public Assembly GeneratedAssembly => _assembly_builder;

	private MacroPhase current_macro_phase
	{
		get
		{
			int result;
			switch (run_phase)
			{
			default:
				result = 3;
				break;
			case 0:
			case 1:
			case 2:
			case 3:
			case 4:
				result = 1;
				break;
			case 5:
			case 6:
				result = 2;
				break;
			}
			return (MacroPhase)result;
		}
	}

	public InternalTypeClass InternalType => Manager.InternalType;

	public SystemTypeClass SystemTypeCache => Manager.SystemTypeCache;

	private Assembly resolve_hack(object _N_wildcard_3348, ResolveEventArgs _N_wildcard_3349)
	{
		return _assembly_builder;
	}

	public TypesManager(ManagerClass man)
	{
		Manager = man;
		_OutputFileName = Manager.Options.OutputFileName;
		if (!Manager.Options.TargetIsLibrary)
		{
			_need_entry_point = true;
			_entry_point = option<MethodInfo>.None._N_constant_object;
		}
		if (!Manager.IsIntelliSenseMode)
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.TypeResolve += resolve_hack;
		}
	}

	public void Dispose()
	{
		if (!Manager.IsIntelliSenseMode)
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.TypeResolve -= resolve_hack;
		}
	}

	public void CreateAssembly()
	{
		PermissionSet permissionSet = null;
		PermissionSet permissionSet2 = null;
		PermissionSet permissionSet3 = null;
		_N_closureOf_CreateAssembly_62053 n_closureOf_CreateAssembly_ = new _N_closureOf_CreateAssembly_62053();
		_assembly_name = CreateAssemblyName();
		_assembly_name.Name = Path.GetFileNameWithoutExtension(_OutputFileName);
		AssemblyBuilderAccess access = (Manager.Options.CompileToMemory ? AssemblyBuilderAccess.Run : AssemblyBuilderAccess.Save);
		string directoryName = Path.GetDirectoryName(Path.GetFullPath(_OutputFileName));
		if (!Directory.Exists(directoryName))
		{
			Message.Error(Location.Default, "specified output directory `" + Convert.ToString(directoryName) + "' does not exist");
			throw new Recovery();
		}
		permissionSet2 = null;
		permissionSet = null;
		permissionSet3 = null;
		list<Nemerle.Builtins.Tuple<SecurityAction, PermissionSet>> list = Manager.AttributeCompiler.GetPermissionSets(assembly_attributes);
		while (list is list<Nemerle.Builtins.Tuple<SecurityAction, PermissionSet>>.Cons)
		{
			Nemerle.Builtins.Tuple<SecurityAction, PermissionSet> hd = ((list<Nemerle.Builtins.Tuple<SecurityAction, PermissionSet>>.Cons)list).hd;
			list = ((list<Nemerle.Builtins.Tuple<SecurityAction, PermissionSet>>.Cons)list).tl;
			SecurityAction field = hd.Field0;
			PermissionSet field2 = hd.Field1;
			switch (field)
			{
			case SecurityAction.RequestMinimum:
				permissionSet2 = field2;
				break;
			case SecurityAction.RequestOptional:
				permissionSet = field2;
				break;
			case SecurityAction.RequestRefuse:
				permissionSet3 = field2;
				break;
			default:
				Message.Error(Location.Default, Convert.ToString(field) + " is not valid here");
				throw new Recovery();
			}
			list = list;
		}
		_assembly_builder = AppDomain.CurrentDomain.DefineDynamicAssembly(_assembly_name, access, directoryName, permissionSet2, permissionSet, permissionSet3);
		list<CustomAttributeBuilder> informationalAssemblyAttributes = GetInformationalAssemblyAttributes();
		n_closureOf_CreateAssembly_._N__N_obj_cache_62058 = _assembly_builder;
		FunctionVoid<CustomAttributeBuilder> f = new _N__N_method_lambda__62078(n_closureOf_CreateAssembly_);
		informationalAssemblyAttributes.Iter(f);
		if (_assembly_name.Name == "")
		{
			Message.Error(Location.Default, "name of output assembly cannot be empty");
			throw new Recovery();
		}
		_module_builder = ((!Manager.Options.CompileToMemory) ? _assembly_builder.DefineDynamicModule(_assembly_name.Name, Path.GetFileName(_OutputFileName), Manager.Options.EmitDebug) : _assembly_builder.DefineDynamicModule(_assembly_name.Name, Manager.Options.EmitDebug));
		if (Manager.Options.EmitDebug)
		{
			_debug_emit = _module_builder.GetSymWriter();
		}
	}

	private void add_resources_to_assembly()
	{
		list<string> list = Manager.Options.EmbeddedResources;
		checked
		{
			while (list is list<string>.Cons)
			{
				string hd = ((list<string>.Cons)list).hd;
				list<string> tl = ((list<string>.Cons)list).tl;
				string x = hd;
				Nemerle.Builtins.Tuple<string, string> tuple = _N_escape_resource_62146(x);
				string field = tuple.Field0;
				string field2 = tuple.Field1;
				try
				{
					if (File.Exists(field))
					{
						FileStream fileStream = File.OpenRead(field);
						MethodInfo method = _module_builder.GetType().GetMethod("DefineManifestResource");
						if (method == null)
						{
							try
							{
								byte[] array = new byte[(int)fileStream.Length];
								for (int i = 0; array.Length != i; i += fileStream.Read(array, i, array.Length - i))
								{
								}
								MethodInfo method2 = _assembly_builder.GetType().GetMethod("EmbedResource", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
								if (method2 == null)
								{
									Message.Error("cannot find API for saving resources");
								}
								else
								{
									method2.Invoke(_assembly_builder, new object[3]
									{
										field2,
										array,
										ResourceAttributes.Public
									});
								}
							}
							finally
							{
								fileStream.Dispose();
							}
						}
						else
						{
							method.Invoke(_module_builder, new object[3]
							{
								field2,
								fileStream,
								ResourceAttributes.Public
							});
						}
					}
					else
					{
						Message.Error("Could not find resource " + field);
					}
				}
				catch (Exception ex)
				{
					Message.Error("Could not embed resource: " + ex.Message);
				}
				list = tl;
			}
			list<string> list2 = Manager.Options.LinkedResources;
			while (list2 is list<string>.Cons)
			{
				string hd2 = ((list<string>.Cons)list2).hd;
				list<string> tl2 = ((list<string>.Cons)list2).tl;
				string x2 = hd2;
				Nemerle.Builtins.Tuple<string, string> tuple2 = _N_escape_resource_62146(x2);
				string field3 = tuple2.Field0;
				string field4 = tuple2.Field1;
				try
				{
					_assembly_builder.AddResourceFile(field4, field3);
				}
				catch (FileNotFoundException)
				{
					Message.Error("Could not find resource " + field3);
				}
				catch (ArgumentException ex3)
				{
					Message.Error("Could not link resource: " + ex3.Message);
				}
				list2 = tl2;
			}
			string unmanagedResource = Manager.Options.UnmanagedResource;
			if (unmanagedResource != null)
			{
				try
				{
					_module_builder.DefineUnmanagedResource(unmanagedResource);
					return;
				}
				catch (FileNotFoundException)
				{
					Message.Error("Could not find resource" + unmanagedResource);
					return;
				}
				catch (ArgumentException ex5)
				{
					Message.Error("Could not embed unmanaged resource " + Convert.ToString(unmanagedResource) + ": " + Convert.ToString(ex5.Message));
					return;
				}
			}
			_assembly_builder.DefineVersionInfoResource();
		}
	}

	public void EmitAuxDecls()
	{
		compile_all_tyinfos(aux_phase: true);
	}

	public void EmitDecls()
	{
		_N_closureOf_EmitDecls_62299 n_closureOf_EmitDecls_ = new _N_closureOf_EmitDecls_62299();
		n_closureOf_EmitDecls_._N__N_closurised_this_ptr_62304 = this;
		Solver solver = Manager.Solver;
		FunctionVoid action = new _N__N_lambda__62203__62306(n_closureOf_EmitDecls_);
		solver.Enqueue(action);
	}

	public void SaveAssembly()
	{
		add_resources_to_assembly();
		if (contains_nemerle_specifics)
		{
			CustomAttributeBuilder customAttribute = Manager.AttributeCompiler.MakeEmittedAttribute(SystemTypeCache.Reflection_AssemblyConfigurationAttribute, "ContainsNemerleTypes");
			_assembly_builder.SetCustomAttribute(customAttribute);
		}
		Nemerle.Builtins.Tuple<bool, option<MethodInfo>> tuple = new Nemerle.Builtins.Tuple<bool, option<MethodInfo>>(_need_entry_point, _entry_point);
		if (tuple.Field0)
		{
			if (tuple.Field1 is option<MethodInfo>.Some)
			{
				MethodInfo val = ((option<MethodInfo>.Some)tuple.Field1).val;
				MethodInfo entryMethod = val;
				PEFileKinds fileKind = ((!Manager.Options.TargetIsWinexe) ? PEFileKinds.ConsoleApplication : PEFileKinds.WindowApplication);
				_assembly_builder.SetEntryPoint(entryMethod, fileKind);
			}
			else if (tuple.Field1 == option<MethodInfo>.None._N_constant_object)
			{
				Message.Error("no suitable entry point (Main function) found");
			}
		}
		try
		{
			Nemerle.Builtins.Tuple<PortableExecutableKinds, ImageFileMachine> tuple2 = make_platform_flags(Manager.Options.Platform);
			PortableExecutableKinds field = tuple2.Field0;
			ImageFileMachine field2 = tuple2.Field1;
			_assembly_builder.Save(Path.GetFileName(_OutputFileName), field, field2);
		}
		catch (UnauthorizedAccessException ex)
		{
			Message.Error(string.Concat("could not write to output file `" + Convert.ToString(_OutputFileName) + "'", " -- `" + Convert.ToString(ex.Message) + "'"));
		}
		catch (IOException ex2)
		{
			Message.Error(string.Concat("could not write to output file `" + Convert.ToString(_OutputFileName) + "'", " -- `" + Convert.ToString(ex2.Message) + "'"));
		}
		catch (COMException ex3)
		{
			Message.Error("Problems saving assembly: " + Convert.ToString(ex3.Message));
		}
		catch (ApplicationException ex4)
		{
			Message.Error(ex4.Message);
		}
	}

	protected override void compile_all_tyinfos(bool aux_phase)
	{
		_N_closureOf_compile_all_tyinfos_62733 n_closureOf_compile_all_tyinfos_ = new _N_closureOf_compile_all_tyinfos_62733();
		n_closureOf_compile_all_tyinfos_._N_aux_phase_62740 = aux_phase;
		n_closureOf_compile_all_tyinfos_._N__N_closurised_this_ptr_62738 = this;
		FunctionVoid<TypeBuilder> f = new _N_create_type_emit_builder__62752(n_closureOf_compile_all_tyinfos_);
		FunctionVoid<TypeBuilder> f2 = new _N_emit_decls__62767(n_closureOf_compile_all_tyinfos_);
		FunctionVoid<TypeBuilder> f3 = new _N_emit_impl__62779(n_closureOf_compile_all_tyinfos_);
		if (!n_closureOf_compile_all_tyinfos_._N_aux_phase_62740)
		{
			_cgil_phase = 1;
		}
		Iter(f);
		f = new _N__N_lambda__62711__62794(n_closureOf_compile_all_tyinfos_);
		Iter(f);
		if (!n_closureOf_compile_all_tyinfos_._N_aux_phase_62740)
		{
			_cgil_phase = 2;
		}
		Function<TypeBuilder, bool> instance = _N__N_lambda__62716__62809.Instance;
		IterConditionally(f2, instance);
		instance = _N__N_lambda__62721__62819.Instance;
		IterConditionally(f2, instance);
		if (!n_closureOf_compile_all_tyinfos_._N_aux_phase_62740)
		{
			_cgil_phase = 3;
		}
		instance = _N__N_lambda__62726__62832.Instance;
		IterConditionally(f3, instance);
		Iter(f3);
		if (!n_closureOf_compile_all_tyinfos_._N_aux_phase_62740)
		{
			_cgil_phase = 4;
		}
	}

	internal void EnsureEmitProgress(TypeBuilder ti)
	{
		if (_cgil_phase >= 1)
		{
			ti.CreateEmitBuilder();
			ti.UpdateEmittedInheritance();
		}
	}

	internal void MaybeCompile(TypeBuilder ti, MemberBuilder mem)
	{
		_N_closureOf_MaybeCompile_62864 n_closureOf_MaybeCompile_ = new _N_closureOf_MaybeCompile_62864();
		n_closureOf_MaybeCompile_._N_mem_62869 = mem;
		n_closureOf_MaybeCompile_._N_mem_62869.CreateEmitBuilder(ti.GetTypeBuilder());
		if (_cgil_phase >= 3)
		{
			FunctionVoid action = new _N__N_lambda__62858__62874(n_closureOf_MaybeCompile_);
			ti.DoBeforeFinalization(action);
		}
	}

	private static bool is_aux_decl(TypeBuilder ti)
	{
		return ti.FullName.StartsWith("Nemerle.Internal.");
	}

	private static Nemerle.Builtins.Tuple<PortableExecutableKinds, ImageFileMachine> make_platform_flags(string platform)
	{
		Nemerle.Builtins.Tuple<PortableExecutableKinds, ImageFileMachine> result;
		switch (platform)
		{
		case "x86":
			result = new Nemerle.Builtins.Tuple<PortableExecutableKinds, ImageFileMachine>(PortableExecutableKinds.ILOnly | PortableExecutableKinds.Required32Bit, ImageFileMachine.I386);
			break;
		case "x64":
			result = new Nemerle.Builtins.Tuple<PortableExecutableKinds, ImageFileMachine>(PortableExecutableKinds.ILOnly | PortableExecutableKinds.PE32Plus, ImageFileMachine.AMD64);
			break;
		case "":
		case "anycpu":
			result = new Nemerle.Builtins.Tuple<PortableExecutableKinds, ImageFileMachine>(PortableExecutableKinds.ILOnly, ImageFileMachine.I386);
			break;
		case "ia64":
			result = new Nemerle.Builtins.Tuple<PortableExecutableKinds, ImageFileMachine>(PortableExecutableKinds.ILOnly | PortableExecutableKinds.PE32Plus, ImageFileMachine.IA64);
			break;
		default:
			throw new AssertionException("ncc\\generation\\HierarchyEmitter.n", 461, "", "");
		}
		return result;
	}

	public void Init()
	{
		RemoveProgramTypes();
		infos = list<TypeBuilder>.Nil._N_constant_object;
		assembly_attributes.Clear();
		run_phase = 0;
		_codeWriter = null;
	}

	internal void AddMacroExpansion(AttributeMacroExpansion exp)
	{
		exp.AddedNr = Manager.AttributeMacroExpansion_global_nr;
		ManagerClass manager = Manager;
		manager.AttributeMacroExpansion_global_nr++;
		attribute_macros_queue.Add(exp);
	}

	internal void ExpandMacros()
	{
		if (is_expanding)
		{
			return;
		}
		MacroPhase macroPhase = current_macro_phase;
		is_expanding = true;
		try
		{
			while (!attribute_macros_queue.IsEmpty)
			{
				AttributeMacroExpansion attributeMacroExpansion = attribute_macros_queue.Top();
				if (attributeMacroExpansion.Phase > macroPhase)
				{
					break;
				}
				attribute_macros_queue.ExtractFirst().Expand();
			}
		}
		finally
		{
			is_expanding = false;
		}
	}

	public TypeBuilder CreateTypeBuilder(TypeBuilder par, TopDeclaration td, NamespaceTree.Node ns_node)
	{
		TypeBuilder typeBuilder = new TypeBuilder(this, par, td, ns_node);
		infos = new list<TypeBuilder>.Cons(typeBuilder, infos);
		return typeBuilder;
	}

	public void RemoveProgramTypes()
	{
		list<TypeBuilder> list = infos;
		while (list is list<TypeBuilder>.Cons)
		{
			TypeBuilder hd = ((list<TypeBuilder>.Cons)list).hd;
			list = ((list<TypeBuilder>.Cons)list).tl;
			hd.NamespaceNode.CleanUp();
			list = list;
		}
	}

	private void determine_subtyping()
	{
		FunctionVoid<TypeBuilder> instance = _N__N_lambda__62978__62985.Instance;
		Iter(instance);
	}

	private void Iter(list<TypeBuilder> builders, FunctionVoid<TypeBuilder> f)
	{
		_N_closureOf_Iter_63017 n_closureOf_Iter_ = new _N_closureOf_Iter_63017();
		n_closureOf_Iter_._N_f_63028 = f;
		n_closureOf_Iter_._N_working_on_63026 = Manager.GetNewId();
		n_closureOf_Iter_._N_done_63024 = Manager.GetNewId();
		n_closureOf_Iter_._N_maybe_f_63022 = new _N_maybe_f__63030(n_closureOf_Iter_);
		builders.Iter(n_closureOf_Iter_._N_maybe_f_63022);
	}

	public void Iter(FunctionVoid<TypeBuilder> f)
	{
		Iter(infos.Reverse(), f);
	}

	public void IterConditionally(FunctionVoid<TypeBuilder> f, Function<TypeBuilder, bool> cond)
	{
		_N_closureOf_IterConditionally_63075 n_closureOf_IterConditionally_ = new _N_closureOf_IterConditionally_63075();
		n_closureOf_IterConditionally_._N_f_63082 = f;
		n_closureOf_IterConditionally_._N_cond_63080 = cond;
		list<TypeBuilder> builders = infos.Reverse();
		FunctionVoid<TypeBuilder> f2 = new _N__N_lambda__63068__63084(n_closureOf_IterConditionally_);
		Iter(builders, f2);
	}

	public list<TypeBuilder> TopTypeBuilders()
	{
		list<TypeBuilder> list = infos;
		Function<TypeBuilder, bool> instance = _N__N_lambda__63097__63104.Instance;
		return list.RevFilter(instance);
	}

	public void TopIter(FunctionVoid<TypeBuilder> f)
	{
		_N_closureOf_TopIter_63124 n_closureOf_TopIter_ = new _N_closureOf_TopIter_63124();
		n_closureOf_TopIter_._N_f_63129 = f;
		FunctionVoid<TypeBuilder> f2 = new _N_wrap__63131(n_closureOf_TopIter_);
		Iter(f2);
	}

	public void Run()
	{
		list<TypeBuilder> list = infos.Reverse();
		while (list is list<TypeBuilder>.Cons)
		{
			TypeBuilder hd = ((list<TypeBuilder>.Cons)list).hd;
			list<TypeBuilder> list2 = ((list<TypeBuilder>.Cons)list).tl;
			TypeBuilder typeBuilder = hd;
			typeBuilder.CalcAccessibility();
			list = list2;
		}
		ExpandMacros();
		list<TypeBuilder> list3 = infos.Reverse();
		while (list3 is list<TypeBuilder>.Cons)
		{
			TypeBuilder hd2 = ((list<TypeBuilder>.Cons)list3).hd;
			list<TypeBuilder> list4 = ((list<TypeBuilder>.Cons)list3).tl;
			TypeBuilder typeBuilder2 = hd2;
			Location location = typeBuilder2.Location;
			bool flag = location.FileIndex != 0;
			if (flag)
			{
				LocationStack.Push(location);
			}
			try
			{
				typeBuilder2.process_macro_attributes(MacroPhase.BeforeInheritance);
			}
			finally
			{
				if (flag)
				{
					LocationStack.RemoveTop();
				}
			}
			list3 = list4;
		}
		run_phase = 1;
		list<TypeBuilder> list5 = TopTypeBuilders();
		while (list5 is list<TypeBuilder>.Cons)
		{
			TypeBuilder hd3 = ((list<TypeBuilder>.Cons)list5).hd;
			list<TypeBuilder> list6 = ((list<TypeBuilder>.Cons)list5).tl;
			TypeBuilder typeBuilder3 = hd3;
			Location location2 = typeBuilder3.Location;
			bool flag2 = location2.FileIndex != 0;
			if (flag2)
			{
				LocationStack.Push(location2);
			}
			try
			{
				typeBuilder3.make_tyenvs();
			}
			finally
			{
				if (flag2)
				{
					LocationStack.RemoveTop();
				}
			}
			list5 = list6;
		}
		run_phase = 2;
		List<TypeBuilder> list7 = new List<TypeBuilder>(TopTypeBuilders());
		while (list7.Count > 0)
		{
			foreach (TypeBuilder item in list7)
			{
				TypeBuilder typeBuilder4 = item;
				Location location3 = typeBuilder4.Location;
				bool flag3 = location3.FileIndex != 0;
				if (flag3)
				{
					LocationStack.Push(location3);
				}
				try
				{
					typeBuilder4.bind_types();
				}
				finally
				{
					if (flag3)
					{
						LocationStack.RemoveTop();
					}
				}
			}
			List<TypeBuilder> list8 = new List<TypeBuilder>();
			foreach (TypeBuilder item2 in list7)
			{
				TypeBuilder typeBuilder5 = item2;
				list8.AddRange(typeBuilder5.DeclaredNestedTypes);
			}
			list7 = list8;
		}
		FunctionVoid<TypeBuilder> instance = _N__N_lambda__63199__63306.Instance;
		Iter(instance);
		run_phase = 3;
		determine_subtyping();
		run_phase = 4;
		FunctionVoid<TypeBuilder> instance2 = _N__N_lambda__63204__63316.Instance;
		Iter(instance2);
		run_phase = 5;
		ExpandMacros();
		FunctionVoid<TypeBuilder> instance3 = _N__N_lambda__63209__63326.Instance;
		Iter(instance3);
		Manager.OnBeforeAddMembers();
		run_phase = 6;
		FunctionVoid<TypeBuilder> instance4 = _N__N_lambda__63214__63336.Instance;
		Iter(instance4);
		FunctionVoid<TypeBuilder> instance5 = _N__N_lambda__63219__63346.Instance;
		Iter(instance5);
		Manager.OnBeforeWithTypedMembers();
		run_phase = 7;
		ExpandMacros();
		FunctionVoid<TypeBuilder> instance6 = _N__N_lambda__63224__63356.Instance;
		Iter(instance6);
		FunctionVoid<TypeBuilder> instance7 = _N__N_lambda__63229__63366.Instance;
		Iter(instance7);
		FunctionVoid<TypeBuilder> instance8 = _N__N_lambda__63234__63376.Instance;
		Iter(instance8);
		FunctionVoid<TypeBuilder> instance9 = _N_check_method_implements__63389.Instance;
		Iter(instance9);
		FunctionVoid<TypeBuilder> instance10 = _N__N_lambda__63243__63402.Instance;
		Iter(instance10);
		SaveGeneratedSourceFile();
	}

	private void SaveGeneratedSourceFile()
	{
		if (_codeWriter == null)
		{
			return;
		}
		try
		{
			string nameForGeneratedSourceFile = GetNameForGeneratedSourceFile();
			string contents = _codeWriter.ToString();
			if (File.Exists(nameForGeneratedSourceFile))
			{
				File.SetAttributes(nameForGeneratedSourceFile, FileAttributes.Normal);
				File.Delete(nameForGeneratedSourceFile);
			}
			else
			{
				string directoryName = Path.GetDirectoryName(nameForGeneratedSourceFile);
				if (!string.IsNullOrEmpty(directoryName) && !Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
			}
			File.WriteAllText(nameForGeneratedSourceFile, contents, Encoding.UTF8);
			File.SetAttributes(nameForGeneratedSourceFile, FileAttributes.ReadOnly);
		}
		catch (Exception ex)
		{
			Message.Warning("could not save generated source code file: " + ex.Message);
		}
	}

	private string GetNameForGeneratedSourceFile()
	{
		string outputFileName = Manager.Options.OutputFileName;
		string text = ((!Path.IsPathRooted(outputFileName)) ? Path.GetTempPath() : Path.GetFullPath(Path.GetDirectoryName(outputFileName)));
		text = ((!Manager.IsIntelliSenseMode) ? text : Path.Combine(text, "IDE"));
		return Path.Combine(text, string.Concat("_N_GeneratedSource_" + Path.GetFileNameWithoutExtension(outputFileName), ".n"));
	}

	internal void CheckFinalization()
	{
		FunctionVoid<TypeBuilder> instance = _N__N_lambda__63467__63474.Instance;
		Iter(instance);
	}

	internal void CheckForUnusedGlobalSymbols()
	{
		if (Manager.Options.Warnings.IsEnabled(10003) || Manager.Options.Warnings.IsEnabled(649))
		{
			FunctionVoid<TypeBuilder> instance = _N__N_lambda__63492__63505.Instance;
			Iter(instance);
		}
	}

	public void GenerateFakeSourceCode(TypeBuilder owner, ClassMember member)
	{
		if (_codeWriter == null)
		{
			_codeWriter = new LocatingTextWriter(new StringBuilder(), new Location(GetNameForGeneratedSourceFile(), 1, 1, 1, 1).AsFakeSorceAvailable());
		}
		Location loc = _codeWriter.Loc;
		if (null != owner)
		{
			_codeWriter.Write(string.Concat("// " + owner.ToString(), "\n"));
		}
		_codeWriter.Write(member.HeaderToString());
		_codeWriter.FetchUpdatedLocation(member, loc);
		member.PrintBody(_codeWriter);
		_codeWriter.Write("\n\n");
	}

	private static StrongNameKeyPair read_keypair(Location loc, string name)
	{
		//Discarded unreachable code: IL_0035, IL_005c
		try
		{
			return new StrongNameKeyPair(File.Open(name, FileMode.Open, FileAccess.Read));
		}
		catch (DirectoryNotFoundException)
		{
			Message.Error(loc, string.Concat("could not find directory of `" + name, "' with key pair for assembly"));
			throw new Recovery();
		}
		catch (FileNotFoundException)
		{
			Message.Error(loc, string.Concat("could not find file `" + name, "' with key pair for assembly"));
			throw new Recovery();
		}
	}

	public void AddAssemblyAttribute([Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] GlobalEnv env, [Macro("Nemerle.Assertions.NotNull:param:postadd", 0, "")] PExpr attr)
	{
		_N_closureOf_AddAssemblyAttribute_63551 n_closureOf_AddAssemblyAttribute_ = new _N_closureOf_AddAssemblyAttribute_63551();
		n_closureOf_AddAssemblyAttribute_._N_env_63560 = env;
		n_closureOf_AddAssemblyAttribute_._N_attr_63558 = attr;
		n_closureOf_AddAssemblyAttribute_._N__N_closurised_this_ptr_63556 = this;
		if (n_closureOf_AddAssemblyAttribute_._N_attr_63558 == null)
		{
			throw new ArgumentNullException("attr", "The ``NotNull'' contract of parameter ``attr'' has been violated. See ncc\\hierarchy\\CustomAttribute.n:640:71:640:75: .");
		}
		if (n_closureOf_AddAssemblyAttribute_._N_env_63560 == null)
		{
			throw new ArgumentNullException("env", "The ``NotNull'' contract of parameter ``env'' has been violated. See ncc\\hierarchy\\CustomAttribute.n:640:44:640:47: .");
		}
		bool flag = _N_add_63569(n_closureOf_AddAssemblyAttribute_, MacroPhase.BeforeInheritance);
		bool flag2 = _N_add_63569(n_closureOf_AddAssemblyAttribute_, MacroPhase.BeforeTypedMembers);
		bool flag3 = _N_add_63569(n_closureOf_AddAssemblyAttribute_, MacroPhase.WithTypedMembers);
		if (!flag && !flag2 && !flag3)
		{
			assembly_attributes.Add(new Nemerle.Builtins.Tuple<GlobalEnv, PExpr>(n_closureOf_AddAssemblyAttribute_._N_env_63560, n_closureOf_AddAssemblyAttribute_._N_attr_63558));
		}
	}

	internal list<CustomAttributeBuilder> GetInformationalAssemblyAttributes()
	{
		_N_closureOf_GetInformationalAssemblyAttributes_63626 n_closureOf_GetInformationalAssemblyAttributes_ = new _N_closureOf_GetInformationalAssemblyAttributes_63626();
		List<CustomAttributeBuilder> list = new List<CustomAttributeBuilder>();
		n_closureOf_GetInformationalAssemblyAttributes_._N_typeList_63633 = new List<Type>();
		Type[] types = new Type[1] { typeof(string) };
		bool flag = false;
		bool flag2 = false;
		string versionString = null;
		Location location = default(Location);
		foreach (Nemerle.Builtins.Tuple<GlobalEnv, PExpr> assembly_attribute in assembly_attributes)
		{
			GlobalEnv field = assembly_attribute.Field0;
			n_closureOf_GetInformationalAssemblyAttributes_._N_attr_63635 = assembly_attribute.Field1;
			Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>> tuple = Manager.AttributeCompiler.CheckAttribute(field, n_closureOf_GetInformationalAssemblyAttributes_._N_attr_63635);
			TypeInfo field2 = tuple.Field0;
			list<PExpr> list2 = tuple.Field1;
			if (field2.Equals(InternalType.AssemblyCompanyAttribute_tc))
			{
				_N_addAttributeForType_63650(n_closureOf_GetInformationalAssemblyAttributes_, typeof(AssemblyCompanyAttribute));
			}
			else if (field2.Equals(InternalType.AssemblyCopyrightAttribute_tc))
			{
				_N_addAttributeForType_63650(n_closureOf_GetInformationalAssemblyAttributes_, typeof(AssemblyCopyrightAttribute));
			}
			else if (field2.Equals(InternalType.AssemblyDescriptionAttribute_tc))
			{
				_N_addAttributeForType_63650(n_closureOf_GetInformationalAssemblyAttributes_, typeof(AssemblyDescriptionAttribute));
			}
			else if (field2.Equals(InternalType.AssemblyFileVersionAttribute_tc))
			{
				flag = true;
				_N_addAttributeForType_63650(n_closureOf_GetInformationalAssemblyAttributes_, typeof(AssemblyFileVersionAttribute));
			}
			else if (field2.Equals(InternalType.AssemblyProductAttribute_tc))
			{
				_N_addAttributeForType_63650(n_closureOf_GetInformationalAssemblyAttributes_, typeof(AssemblyProductAttribute));
			}
			else if (field2.Equals(InternalType.AssemblyTitleAttribute_tc))
			{
				_N_addAttributeForType_63650(n_closureOf_GetInformationalAssemblyAttributes_, typeof(AssemblyTitleAttribute));
			}
			else if (field2.Equals(InternalType.AssemblyVersionAttribute_tc))
			{
				flag2 = true;
				list<PExpr> list3 = list2;
				if (!(list3 is list<PExpr>.Cons) || !(((list<PExpr>.Cons)list3).hd is PExpr.Literal) || !(((PExpr.Literal)((list<PExpr>.Cons)list3).hd).val is Literal.String) || (object)((list<PExpr>.Cons)list3).tl != list<PExpr>.Nil._N_constant_object)
				{
					Message.Error(n_closureOf_GetInformationalAssemblyAttributes_._N_attr_63635.Location, "given attribute must have single string as parameter");
					throw new Recovery();
				}
				string val = ((Literal.String)((PExpr.Literal)((list<PExpr>.Cons)list3).hd).val).val;
				versionString = val;
				location = n_closureOf_GetInformationalAssemblyAttributes_._N_attr_63635.Location;
			}
		}
		if (!flag && flag2)
		{
			Type typeFromHandle = typeof(AssemblyFileVersionAttribute);
			ConstructorInfo constructor = typeFromHandle.GetConstructor(types);
			string text = ParseVersion(versionString, location).ToString();
			object[] constructorArgs = new object[1] { text };
			CustomAttributeBuilder a = new CustomAttributeBuilder(constructor, constructorArgs);
			n_closureOf_GetInformationalAssemblyAttributes_._N__N_obj_cache_63631 = list;
			FunctionVoid<CustomAttributeBuilder> fac = new _N__N_method_lambda__63691(n_closureOf_GetInformationalAssemblyAttributes_);
			Function<CustomAttributeBuilder, object>._007C_003E(a, fac);
		}
		return list.NToList();
	}

	private Version ParseVersion(string versionString, Location location)
	{
		list<string> list = NString.Split(versionString, '.');
		Version version = null;
		checked
		{
			try
			{
				Function<string, int> instance = _N__N_lambda__63707__63734.Instance;
				list<int> list2 = list.Map(instance);
				object result;
				int hd5;
				int hd6;
				int hd7;
				int hd8;
				int hd9;
				int hd10;
				int hd11;
				if (list2 is list<int>.Cons)
				{
					if ((object)((list<int>.Cons)list2).tl == list<int>.Nil._N_constant_object)
					{
						result = new Version(((list<int>.Cons)list2).hd.ToString());
					}
					else
					{
						if (!(((list<int>.Cons)list2).tl is list<int>.Cons))
						{
							goto IL_02b2;
						}
						int hd = ((list<int>.Cons)list2).hd;
						if ((object)((list<int>.Cons)((list<int>.Cons)list2).tl).tl == list<int>.Nil._N_constant_object)
						{
							int hd2 = ((list<int>.Cons)((list<int>.Cons)list2).tl).hd;
							result = new Version(hd, hd2);
						}
						else
						{
							if (!(((list<int>.Cons)((list<int>.Cons)list2).tl).tl is list<int>.Cons))
							{
								goto IL_02b2;
							}
							int hd3 = ((list<int>.Cons)list2).hd;
							int hd4 = ((list<int>.Cons)((list<int>.Cons)list2).tl).hd;
							if (((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)list2).tl).tl).hd == -1)
							{
								if ((object)((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)list2).tl).tl).tl != list<int>.Nil._N_constant_object)
								{
									if (((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)list2).tl).tl).tl is list<int>.Cons)
									{
										hd5 = ((list<int>.Cons)list2).hd;
										hd6 = ((list<int>.Cons)((list<int>.Cons)list2).tl).hd;
										hd7 = ((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)list2).tl).tl).hd;
										if (((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)list2).tl).tl).tl).hd == -1)
										{
											goto IL_024b;
										}
										if ((object)((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)list2).tl).tl).tl).tl == list<int>.Nil._N_constant_object)
										{
											hd8 = ((list<int>.Cons)list2).hd;
											hd9 = ((list<int>.Cons)((list<int>.Cons)list2).tl).hd;
											hd10 = ((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)list2).tl).tl).hd;
											hd11 = ((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)list2).tl).tl).tl).hd;
											goto IL_036a;
										}
									}
									goto IL_02b2;
								}
								TimeSpan timeSpan = DateTime.Now.Subtract(new DateTime(2000, 1, 1));
								result = new Version(revision: (int)unchecked(DateTime.Now.Subtract(DateTime.Today).Ticks / 20000000L), major: hd3, minor: hd4, build: timeSpan.Days);
							}
							else
							{
								if ((object)((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)list2).tl).tl).tl != list<int>.Nil._N_constant_object)
								{
									if (((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)list2).tl).tl).tl is list<int>.Cons)
									{
										hd5 = ((list<int>.Cons)list2).hd;
										hd6 = ((list<int>.Cons)((list<int>.Cons)list2).tl).hd;
										hd7 = ((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)list2).tl).tl).hd;
										if (((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)list2).tl).tl).tl).hd == -1)
										{
											goto IL_024b;
										}
										if ((object)((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)list2).tl).tl).tl).tl == list<int>.Nil._N_constant_object)
										{
											hd8 = ((list<int>.Cons)list2).hd;
											hd9 = ((list<int>.Cons)((list<int>.Cons)list2).tl).hd;
											hd10 = ((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)list2).tl).tl).hd;
											hd11 = ((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)list2).tl).tl).tl).hd;
											goto IL_036a;
										}
									}
									goto IL_02b2;
								}
								int hd12 = ((list<int>.Cons)list2).hd;
								int hd13 = ((list<int>.Cons)((list<int>.Cons)list2).tl).hd;
								int hd14 = ((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)list2).tl).tl).hd;
								result = new Version(hd12, hd13, hd14);
							}
						}
					}
					goto IL_0580;
				}
				goto IL_02b2;
				IL_024b:
				if ((object)((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)((list<int>.Cons)list2).tl).tl).tl).tl != list<int>.Nil._N_constant_object)
				{
					goto IL_02b2;
				}
				result = new Version(hd5, hd6, hd7, (int)unchecked(DateTime.Now.Subtract(DateTime.Today).Ticks / 20000000L));
				goto IL_0580;
				IL_0580:
				return (Version)result;
				IL_036a:
				result = new Version(hd8, hd9, hd10, hd11);
				goto IL_0580;
				IL_02b2:
				Message.Error(location, "invalid format of version attribute");
				result = new Version();
				goto IL_0580;
			}
			catch (OverflowException)
			{
				Message.Error(location, "wrong format of version attribute");
				return new Version();
			}
		}
	}

	internal AssemblyName CreateAssemblyName()
	{
		_N_closureOf_CreateAssemblyName_63780 n_closureOf_CreateAssemblyName_ = new _N_closureOf_CreateAssemblyName_63780();
		AssemblyName assemblyName = new AssemblyName();
		assemblyName.CodeBase = "file:///" + Directory.GetCurrentDirectory();
		if (Manager.Options.StrongAssemblyKeyName != null)
		{
			assemblyName.KeyPair = read_keypair(Location.Default, Manager.Options.StrongAssemblyKeyName);
		}
		foreach (Nemerle.Builtins.Tuple<GlobalEnv, PExpr> assembly_attribute in assembly_attributes)
		{
			GlobalEnv field = assembly_attribute.Field0;
			n_closureOf_CreateAssemblyName_._N_attr_63785 = assembly_attribute.Field1;
			Nemerle.Builtins.Tuple<TypeInfo, list<PExpr>> tuple = Manager.AttributeCompiler.CheckAttribute(field, n_closureOf_CreateAssemblyName_._N_attr_63785);
			TypeInfo field2 = tuple.Field0;
			list<PExpr> pars = tuple.Field1;
			if (field2.Equals(InternalType.AssemblyVersionAttribute_tc))
			{
				assemblyName.Version = ParseVersion(_N_take_string_63803(n_closureOf_CreateAssemblyName_, pars), n_closureOf_CreateAssemblyName_._N_attr_63785.Location);
			}
			else if (field2.Equals(InternalType.AssemblyKeyFileAttribute_tc))
			{
				string text = _N_take_string_63803(n_closureOf_CreateAssemblyName_, pars);
				if (assemblyName.KeyPair != null)
				{
					Message.Warning(n_closureOf_CreateAssemblyName_._N_attr_63785.Location, "AssemblyKeyFile attribute will be ignored, as key file was already specified");
				}
				else if (text != "")
				{
					assemblyName.KeyPair = read_keypair(n_closureOf_CreateAssemblyName_._N_attr_63785.Location, text);
				}
			}
			else if (field2.Equals(InternalType.AssemblyCultureAttribute_tc))
			{
				assemblyName.CultureInfo = new CultureInfo(_N_take_string_63803(n_closureOf_CreateAssemblyName_, pars));
			}
		}
		return assemblyName;
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
		if (_info.VisitedObjects.ContainsKey(this))
		{
			return;
		}
		_info.VisitedObjects[this] = 0;
		Heap<AttributeMacroExpansion> heap = attribute_macros_queue;
		if (heap != null)
		{
			IEnumerator<AttributeMacroExpansion> enumerator = heap.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					AttributeMacroExpansion current = enumerator.Current;
					AttributeMacroExpansion attributeMacroExpansion = current;
					((ISupportRelocation)attributeMacroExpansion).RelocateImpl(_info);
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
		}
		_codeWriter?.RelocateImplInternal(_info);
		list<TypeBuilder> list = infos;
		if (list != null)
		{
			list<TypeBuilder> list2 = list;
			while (list2 is list<TypeBuilder>.Cons)
			{
				TypeBuilder hd = ((list<TypeBuilder>.Cons)list2).hd;
				list<TypeBuilder> list3 = ((list<TypeBuilder>.Cons)list2).tl;
				TypeBuilder typeBuilder = hd;
				((ISupportRelocation)typeBuilder).RelocateImpl(_info);
				list2 = list3;
			}
		}
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}

	private static Nemerle.Builtins.Tuple<string, string> _N_escape_resource_62146(string x)
	{
		int num = x.IndexOf(',');
		return (num == -1) ? new Nemerle.Builtins.Tuple<string, string>(x, Path.GetFileName(x)) : new Nemerle.Builtins.Tuple<string, string>(x.Substring(0, num), x.Substring(checked(num + 1)));
	}

	private bool _N_allow_it_62743(_N_closureOf_compile_all_tyinfos_62733 _N_compile_all_tyinfos_cp_62742, TypeBuilder ti)
	{
		return !ti.IsFinalized && is_aux_decl(ti) == _N_compile_all_tyinfos_cp_62742._N_aux_phase_62740;
	}

	private bool _N_add_63569(_N_closureOf_AddAssemblyAttribute_63551 _N_AddAssemblyAttribute_cp_63568, MacroPhase phase)
	{
		string suff = AttributeMacroExpansion.Suffix(AttributeTargets.Assembly, phase);
		option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>> option = MacroRegistry.lookup_macro(_N_AddAssemblyAttribute_cp_63568._N_env_63560, _N_AddAssemblyAttribute_cp_63568._N_attr_63558, suff);
		int result;
		if (option == option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>>.None._N_constant_object)
		{
			result = 0;
		}
		else
		{
			if (!(option is option<Nemerle.Builtins.Tuple<Name, IMacro, list<SyntaxElement>>>.Some))
			{
				throw new MatchFailureException();
			}
			AssemblyAttributeMacroExpansion exp = new AssemblyAttributeMacroExpansion(AttributeTargets.Assembly, phase, _N_AddAssemblyAttribute_cp_63568._N_attr_63558, list<SyntaxElement>.Nil._N_constant_object, null, null, _N_AddAssemblyAttribute_cp_63568._N_env_63560);
			AddMacroExpansion(exp);
			result = 1;
		}
		return (byte)result != 0;
	}

	private static void _N_addAttributeForType_63650(_N_closureOf_GetInformationalAssemblyAttributes_63626 _N_GetInformationalAssemblyAttributes_cp_63649, Type type)
	{
		if (_N_GetInformationalAssemblyAttributes_cp_63649._N_typeList_63633.Contains(type))
		{
			Message.Warning(_N_GetInformationalAssemblyAttributes_cp_63649._N_attr_63635.Location, "given attribute is occurred more than once");
		}
		else
		{
			_N_GetInformationalAssemblyAttributes_cp_63649._N_typeList_63633.Add(type);
		}
	}

	private static string _N_take_string_63803(_N_closureOf_CreateAssemblyName_63780 _N_CreateAssemblyName_cp_63802, list<PExpr> pars)
	{
		if (pars is list<PExpr>.Cons && ((list<PExpr>.Cons)pars).hd is PExpr.Literal && ((PExpr.Literal)((list<PExpr>.Cons)pars).hd).val is Literal.String && (object)((list<PExpr>.Cons)pars).tl == list<PExpr>.Nil._N_constant_object)
		{
			return ((Literal.String)((PExpr.Literal)((list<PExpr>.Cons)pars).hd).val).val;
		}
		Message.Error(_N_CreateAssemblyName_cp_63802._N_attr_63785.Location, "given attribute must have single string as parameter");
		throw new Recovery();
	}
}
