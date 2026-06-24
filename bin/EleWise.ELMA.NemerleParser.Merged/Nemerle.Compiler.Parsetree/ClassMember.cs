using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler.Parsetree;

[Variant("Nemerle.Compiler.Parsetree.ClassMember.TypeDeclaration,Nemerle.Compiler.Parsetree.ClassMember.Field,Nemerle.Compiler.Parsetree.ClassMember.Function,Nemerle.Compiler.Parsetree.ClassMember.Property,Nemerle.Compiler.Parsetree.ClassMember.Event,Nemerle.Compiler.Parsetree.ClassMember.EnumOption")]
public abstract class ClassMember : MemberBase
{
	[VariantOption]
	public class TypeDeclaration : ClassMember
	{
		public readonly TopDeclaration td;

		public TypeDeclaration(Splicable name, TopDeclaration td)
			: this(td.Location, name, td.modifiers, td)
		{
		}

		public TypeDeclaration(TopDeclaration td)
			: this(td.Location, td.name, td.modifiers, td)
		{
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 0;
		}

		[RecordCtor]
		public TypeDeclaration(Splicable name, AttributesAndModifiers modifiers, [MappedMember("td")] TopDeclaration td)
			: base(name, modifiers)
		{
			this.td = td;
		}

		[RecordCtor]
		public TypeDeclaration(Location loc, Splicable name, AttributesAndModifiers modifiers, [MappedMember("td")] TopDeclaration td)
			: base(loc, name, modifiers)
		{
			this.td = td;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				td?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class Field : ClassMember
	{
		public PExpr ty;

		[IgnoreField]
		[field: IgnoreField]
		public PExpr Initializer { get; internal set; }

		[IgnoreField]
		[field: IgnoreField]
		public PExpr ParsedType { get; internal set; }

		public new FieldBuilder Builder => (FieldBuilder)_builder;

		public Field(Location loc, Splicable name, AttributesAndModifiers modifiers, PExpr ty)
			: base(loc, name, modifiers)
		{
			this.ty = ty;
			ParsedType = ty;
		}

		public Field(Location loc, Splicable name, AttributesAndModifiers modifiers, PExpr ty, PExpr initializer)
			: this(loc, name, modifiers, ty)
		{
			Initializer = initializer;
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 1;
		}

		[RecordCtor]
		public Field(Splicable name, AttributesAndModifiers modifiers, [MappedMember("ty")] PExpr ty)
			: base(name, modifiers)
		{
			this.ty = ty;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				ty?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class Function : ClassMember
	{
		public readonly PFunHeader header;

		public list<PExpr> implemented;

		public FunBody body;

		[IgnoreField]
		[field: IgnoreField]
		public list<PExpr> ParsedImplemented { get; internal set; }

		[IgnoreField]
		[field: IgnoreField]
		public FunBody ParsedBody { get; set; }

		[IgnoreField]
		[field: IgnoreField]
		public bool IsExtension { get; set; }

		[IgnoreField]
		[field: IgnoreField]
		public AttributesAndModifiers ReturnValueModifiers { get; set; }

		public new MethodBuilder Builder => (MethodBuilder)_builder;

		public Function(Location loc, Splicable name, AttributesAndModifiers modifiers, PFunHeader header, list<PExpr> implemented, FunBody body)
			: base(loc, name, modifiers)
		{
			this.header = header;
			this.implemented = implemented;
			ParsedImplemented = implemented;
			this.body = body;
			ParsedBody = body;
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 2;
		}

		[RecordCtor]
		public Function(Splicable name, AttributesAndModifiers modifiers, [MappedMember("header")] PFunHeader header, [MappedMember("implemented")] list<PExpr> implemented, [MappedMember("body")] FunBody body)
			: base(name, modifiers)
		{
			this.header = header;
			this.implemented = implemented;
			this.body = body;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (_info.VisitedObjects.ContainsKey(this))
			{
				return;
			}
			base.RelocateImplInternal(_info);
			_info.VisitedObjects[this] = 0;
			body?.RelocateImplInternal(_info);
			list<PExpr> list = implemented;
			if (list != null)
			{
				list = list;
				while (list is list<PExpr>.Cons)
				{
					PExpr hd = ((list<PExpr>.Cons)list).hd;
					list = ((list<PExpr>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			header?.RelocateImplInternal(_info);
		}
	}

	[VariantOption]
	public class Property : ClassMember
	{
		private sealed class _N__N_lambda__41425__41448 : Function<PParameter, PExpr>
		{
			[SpecialName]
			public static readonly _N__N_lambda__41425__41448 Instance = new _N__N_lambda__41425__41448();

			[SpecialName]
			public sealed override PExpr apply(PParameter _N__41424)
			{
				return _N__41424.Type;
			}
		}

		private sealed class _N__N_lambda__41472__41495 : Function<PParameter, PExpr>
		{
			[SpecialName]
			public static readonly _N__N_lambda__41472__41495 Instance = new _N__N_lambda__41472__41495();

			[SpecialName]
			public sealed override PExpr apply(PParameter _N__41471)
			{
				return _N__41471.Type;
			}
		}

		public PExpr returnType;

		[IgnoreField]
		public readonly PExpr parsedReturnType;

		public list<PParameter> parameters;

		[IgnoreField]
		public readonly list<PParameter> parsedParameters;

		public option<Function> getter;

		[IgnoreField]
		public readonly option<Function> parsedGetter;

		public option<Function> setter;

		[IgnoreField]
		public readonly option<Function> parsedSetter;

		public option<PExpr> initializer;

		[IgnoreField]
		internal Location _parsedParametersOpenLocation;

		[IgnoreField]
		internal Location _parsedParametersCloseLocation;

		[IgnoreField]
		[field: IgnoreField]
		public list<PExpr> ParsedImplemented { get; internal set; }

		public PExpr SignatureType
		{
			get
			{
				list<PParameter> list = parameters;
				object result;
				if (list is list<PParameter>.Cons)
				{
					if ((object)((list<PParameter>.Cons)list).tl == list<PParameter>.Nil._N_constant_object)
					{
						PParameter hd = ((list<PParameter>.Cons)list).hd;
						Location location = hd.Location + returnType.Location;
						bool flag = location.FileIndex != 0;
						if (flag)
						{
							LocationStack.Push(location);
						}
						PExpr.Call call;
						try
						{
							call = new PExpr.Call(new PExpr.Ref(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("->", _N_MacroContexts.Get(3, ManagerClass.Instance))), new list<PExpr>.Cons(Macros.QuotationChoose(hd.Type), new list<PExpr>.Cons(Macros.QuotationChoose(returnType), list<PExpr>.Nil._N_constant_object)));
						}
						finally
						{
							if (flag)
							{
								LocationStack.RemoveTop();
							}
						}
						result = call;
					}
					else
					{
						PParameter hd2 = ((list<PParameter>.Cons)list).hd;
						list<PParameter> list2 = parameters;
						Function<PParameter, PExpr> instance = _N__N_lambda__41425__41448.Instance;
						list<PExpr> expr = list2.Map(instance);
						Location location2 = hd2.Location + returnType.Location;
						bool flag2 = location2.FileIndex != 0;
						if (flag2)
						{
							LocationStack.Push(location2);
						}
						PExpr.Call call2;
						try
						{
							call2 = new PExpr.Call(new PExpr.Ref(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("->", _N_MacroContexts.Get(3, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("*", _N_MacroContexts.Get(3, ManagerClass.Instance))), Macros.QuotationChoose(expr)), new list<PExpr>.Cons(Macros.QuotationChoose(returnType), list<PExpr>.Nil._N_constant_object)));
						}
						finally
						{
							if (flag2)
							{
								LocationStack.RemoveTop();
							}
						}
						result = call2;
					}
				}
				else
				{
					if ((object)list == list<PParameter>.Nil._N_constant_object)
					{
					}
					result = returnType;
				}
				return (PExpr)result;
			}
		}

		public PExpr ParsedSignatureType
		{
			get
			{
				list<PParameter> list = parsedParameters;
				object result;
				if (list is list<PParameter>.Cons)
				{
					if ((object)((list<PParameter>.Cons)list).tl == list<PParameter>.Nil._N_constant_object)
					{
						PParameter hd = ((list<PParameter>.Cons)list).hd;
						Location location = hd.Location + parsedReturnType.Location;
						bool flag = location.FileIndex != 0;
						if (flag)
						{
							LocationStack.Push(location);
						}
						PExpr.Call call;
						try
						{
							call = new PExpr.Call(new PExpr.Ref(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("->", _N_MacroContexts.Get(3, ManagerClass.Instance))), new list<PExpr>.Cons(Macros.QuotationChoose(hd.Type), new list<PExpr>.Cons(Macros.QuotationChoose(parsedReturnType), list<PExpr>.Nil._N_constant_object)));
						}
						finally
						{
							if (flag)
							{
								LocationStack.RemoveTop();
							}
						}
						result = call;
					}
					else
					{
						PParameter hd2 = ((list<PParameter>.Cons)list).hd;
						list<PParameter> list2 = parsedParameters;
						Function<PParameter, PExpr> instance = _N__N_lambda__41472__41495.Instance;
						list<PExpr> expr = list2.Map(instance);
						Location location2 = hd2.Location + parsedReturnType.Location;
						bool flag2 = location2.FileIndex != 0;
						if (flag2)
						{
							LocationStack.Push(location2);
						}
						PExpr.Call call2;
						try
						{
							call2 = new PExpr.Call(new PExpr.Ref(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("->", _N_MacroContexts.Get(3, ManagerClass.Instance))), new list<PExpr>.Cons(new PExpr.Call(new PExpr.Ref(Nemerle.Compiler.Parsetree.Name.NameInCurrentColor("*", _N_MacroContexts.Get(3, ManagerClass.Instance))), Macros.QuotationChoose(expr)), new list<PExpr>.Cons(Macros.QuotationChoose(parsedReturnType), list<PExpr>.Nil._N_constant_object)));
						}
						finally
						{
							if (flag2)
							{
								LocationStack.RemoveTop();
							}
						}
						result = call2;
					}
				}
				else
				{
					if ((object)list != list<PParameter>.Nil._N_constant_object)
					{
						throw new MatchFailureException();
					}
					result = parsedReturnType;
				}
				return (PExpr)result;
			}
		}

		public new PropertyBuilder Builder => (PropertyBuilder)_builder;

		public Location ParsedParametersOpenLocation
		{
			[CompilerGenerated]
			[DebuggerStepThrough]
			get
			{
				return _parsedParametersOpenLocation;
			}
			[CompilerGenerated]
			[DebuggerStepThrough]
			set
			{
				_parsedParametersOpenLocation = value;
			}
		}

		public Location ParsedParametersCloseLocation
		{
			[DebuggerStepThrough]
			[CompilerGenerated]
			get
			{
				return _parsedParametersCloseLocation;
			}
			[CompilerGenerated]
			[DebuggerStepThrough]
			set
			{
				_parsedParametersCloseLocation = value;
			}
		}

		public Property(Splicable name, AttributesAndModifiers modifiers, PExpr returnType, list<PParameter> parameters, option<Function> getter, option<Function> setter)
			: this(Location.Default, name, modifiers, returnType, parameters, getter, setter)
		{
		}

		public Property(Location loc, Splicable name, AttributesAndModifiers modifiers, PExpr returnType, list<PParameter> parameters, option<Function> getter, option<Function> setter)
			: this(loc, name, modifiers, returnType, parameters, getter, setter, option<PExpr>.None._N_constant_object)
		{
		}

		public Property(Location loc, Splicable name, AttributesAndModifiers modifiers, PExpr returnType, list<PParameter> parameters, option<Function> getter, option<Function> setter, option<PExpr> initializer)
			: base(loc, name, modifiers)
		{
			parsedReturnType = returnType;
			this.returnType = returnType;
			parsedParameters = parameters;
			this.parameters = parameters;
			parsedGetter = getter;
			this.getter = getter;
			parsedSetter = setter;
			this.setter = setter;
			this.initializer = initializer;
		}

		public Property(Location loc, Splicable name, AttributesAndModifiers modifiers, PExpr returnType, list<PParameter> parameters, option<Function> getter, option<Function> setter, list<PExpr> implemented)
			: this(loc, name, modifiers, returnType, parameters, getter, setter)
		{
			ParsedImplemented = implemented;
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 3;
		}

		[RecordCtor]
		public Property(Splicable name, AttributesAndModifiers modifiers, [MappedMember("returnType")] PExpr returnType, [MappedMember("parameters")] list<PParameter> parameters, [MappedMember("getter")] option<Function> getter, [MappedMember("setter")] option<Function> setter, [MappedMember("initializer")] option<PExpr> initializer)
			: base(name, modifiers)
		{
			this.returnType = returnType;
			this.parameters = parameters;
			this.getter = getter;
			this.setter = setter;
			this.initializer = initializer;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (_info.VisitedObjects.ContainsKey(this))
			{
				return;
			}
			base.RelocateImplInternal(_info);
			_info.VisitedObjects[this] = 0;
			_parsedParametersCloseLocation = Completion.Relocate(_parsedParametersCloseLocation, _info);
			_parsedParametersOpenLocation = Completion.Relocate(_parsedParametersOpenLocation, _info);
			option<PExpr> option = initializer;
			if (option is option<PExpr>.Some)
			{
				PExpr val = ((option<PExpr>.Some)option).val;
				((ISupportRelocation)val).RelocateImpl(_info);
			}
			option<Function> option2 = parsedSetter;
			if (option2 is option<Function>.Some)
			{
				Function val2 = ((option<Function>.Some)option2).val;
				((ISupportRelocation)val2).RelocateImpl(_info);
			}
			option2 = setter;
			if (option2 is option<Function>.Some)
			{
				Function val2 = ((option<Function>.Some)option2).val;
				((ISupportRelocation)val2).RelocateImpl(_info);
			}
			option2 = parsedGetter;
			if (option2 is option<Function>.Some)
			{
				Function val2 = ((option<Function>.Some)option2).val;
				((ISupportRelocation)val2).RelocateImpl(_info);
			}
			option2 = getter;
			if (option2 is option<Function>.Some)
			{
				Function val2 = ((option<Function>.Some)option2).val;
				((ISupportRelocation)val2).RelocateImpl(_info);
			}
			list<PParameter> list = parsedParameters;
			if (list != null)
			{
				list = list;
				while (list is list<PParameter>.Cons)
				{
					PParameter hd = ((list<PParameter>.Cons)list).hd;
					list = ((list<PParameter>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			list = parameters;
			if (list != null)
			{
				list = list;
				while (list is list<PParameter>.Cons)
				{
					PParameter hd = ((list<PParameter>.Cons)list).hd;
					list = ((list<PParameter>.Cons)list).tl;
					((ISupportRelocation)hd).RelocateImpl(_info);
					list = list;
				}
			}
			parsedReturnType?.RelocateImplInternal(_info);
			returnType?.RelocateImplInternal(_info);
		}
	}

	[VariantOption]
	public class Event : ClassMember
	{
		public readonly PExpr ty;

		public readonly Field field;

		public readonly Function add;

		public readonly Function remove;

		public new EventBuilder Builder => (EventBuilder)_builder;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 4;
		}

		[RecordCtor]
		public Event(Splicable name, AttributesAndModifiers modifiers, [MappedMember("ty")] PExpr ty, [MappedMember("field")] Field field, [MappedMember("add")] Function add, [MappedMember("remove")] Function remove)
			: base(name, modifiers)
		{
			this.ty = ty;
			this.field = field;
			this.add = add;
			this.remove = remove;
		}

		[RecordCtor]
		public Event(Location loc, Splicable name, AttributesAndModifiers modifiers, [MappedMember("ty")] PExpr ty, [MappedMember("field")] Field field, [MappedMember("add")] Function add, [MappedMember("remove")] Function remove)
			: base(loc, name, modifiers)
		{
			this.ty = ty;
			this.field = field;
			this.add = add;
			this.remove = remove;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				remove?.RelocateImplInternal(_info);
				add?.RelocateImplInternal(_info);
				field?.RelocateImplInternal(_info);
				ty?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class EnumOption : ClassMember
	{
		public readonly option<PExpr> value;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 5;
		}

		[RecordCtor]
		public EnumOption(Splicable name, AttributesAndModifiers modifiers, [MappedMember("value")] option<PExpr> value)
			: base(name, modifiers)
		{
			this.value = value;
		}

		[RecordCtor]
		public EnumOption(Location loc, Splicable name, AttributesAndModifiers modifiers, [MappedMember("value")] option<PExpr> value)
			: base(loc, name, modifiers)
		{
			this.value = value;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				option<PExpr> option = value;
				if (option is option<PExpr>.Some)
				{
					PExpr val = ((option<PExpr>.Some)option).val;
					((ISupportRelocation)val).RelocateImpl(_info);
				}
			}
		}
	}

	private sealed class _N_closureOf_PrintBody_40955
	{
		internal LocatableTextWriter _N_writer_40960;

		internal _N_closureOf_PrintBody_40955()
		{
		}
	}

	private sealed class _N_closureOf_HeaderToString_41011
	{
		internal ClassMember _N__N_closurised_this_ptr_41018;

		internal string _N_attrs_41016;

		internal _N_closureOf_HeaderToString_41011()
		{
		}
	}

	private sealed class _N_closureOf_ToString_41083
	{
		internal ClassMember _N__N_closurised_this_ptr_41090;

		internal string _N_attrs_41088;

		internal _N_closureOf_ToString_41083()
		{
		}
	}

	internal GlobalEnv _env;

	internal Token.BracesGroup _tokens;

	internal TopDeclaration _definedIn;

	internal MemberBuilder _builder;

	private object _userData;

	public PExpr Body
	{
		get
		{
			object result;
			if (this is Function)
			{
				FunBody body = ((Function)this).body;
				if (body is FunBody.Parsed)
				{
					PExpr expr = ((FunBody.Parsed)body).expr;
					result = expr;
				}
				else if (body is FunBody.Typed)
				{
					Message.Error("Body of typed method is not accessible");
					result = null;
				}
				else if (body == FunBody.ILed._N_constant_object)
				{
					Message.Error("Body of compiled method is not accessible");
					result = null;
				}
				else
				{
					if (body != FunBody.Abstract._N_constant_object)
					{
						throw new MatchFailureException();
					}
					result = new PExpr.Literal(new Literal.Void());
				}
			}
			else
			{
				Message.Error("Body is accessible only for ClassMember.Function variant option");
				result = null;
			}
			return (PExpr)result;
		}
		set
		{
			if (this is Function)
			{
				Function function = (Function)this;
				function.body = new FunBody.Parsed(value);
			}
			else
			{
				Message.Error("Body is accessible only for ClassMember.Function variant option");
			}
		}
	}

	public GlobalEnv Env
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _env;
		}
	}

	public Token.BracesGroup Tokens
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _tokens;
		}
	}

	public TopDeclaration DefinedIn
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return _definedIn;
		}
	}

	public MemberBuilder Builder
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _builder;
		}
	}

	public object UserData
	{
		[CompilerGenerated]
		[DebuggerStepThrough]
		get
		{
			return _userData;
		}
		[DebuggerStepThrough]
		[CompilerGenerated]
		set
		{
			_userData = value;
		}
	}

	public void SetEnv(GlobalEnv env)
	{
		_env = env;
	}

	public bool IsMutable()
	{
		return (modifiers.mods & NemerleModifiers.Mutable) != 0;
	}

	internal void PrintBody(LocatableTextWriter writer)
	{
		_N_closureOf_PrintBody_40955 n_closureOf_PrintBody_ = new _N_closureOf_PrintBody_40955();
		n_closureOf_PrintBody_._N_writer_40960 = writer;
		if (this is Function)
		{
			FunBody body = ((Function)this).body;
			if (body is FunBody.Parsed)
			{
				PExpr expr = ((FunBody.Parsed)body).expr;
				PrettyPrint.SprintExpr(option<Typer>.None._N_constant_object, expr, "", n_closureOf_PrintBody_._N_writer_40960);
			}
		}
		else if (this is Property)
		{
			option<Function> accessor = ((Property)this).getter;
			option<Function> accessor2 = ((Property)this).setter;
			option<PExpr> option = ((Property)this).initializer;
			_N_print_40970(n_closureOf_PrintBody_, accessor, "get");
			_N_print_40970(n_closureOf_PrintBody_, accessor2, "set");
			if (option is option<PExpr>.Some)
			{
				PExpr expr = ((option<PExpr>.Some)option).val;
				n_closureOf_PrintBody_._N_writer_40960.Write("\ndefault");
				PrettyPrint.SprintExpr(option<Typer>.None._N_constant_object, expr, "", n_closureOf_PrintBody_._N_writer_40960);
				n_closureOf_PrintBody_._N_writer_40960.Write("\n");
			}
		}
	}

	public string HeaderToString()
	{
		_N_closureOf_HeaderToString_41011 n_closureOf_HeaderToString_ = new _N_closureOf_HeaderToString_41011();
		n_closureOf_HeaderToString_._N__N_closurised_this_ptr_41018 = this;
		string text = ((modifiers != null) ? Attributes.ToString().ToLower().Replace(",", "") : "");
		n_closureOf_HeaderToString_._N_attrs_41016 = ((!(text == "")) ? (text + " ") : text);
		Splicable splicable = name;
		string result;
		if (this is TypeDeclaration)
		{
			TopDeclaration td = ((TypeDeclaration)this).td;
			result = Convert.ToString(_N_prefix_41037(n_closureOf_HeaderToString_)) + Convert.ToString(td);
		}
		else if (this is Field)
		{
			PExpr ty = ((Field)this).ty;
			result = Convert.ToString(_N_prefix_41037(n_closureOf_HeaderToString_)) + Convert.ToString(splicable) + " : " + Convert.ToString(ty);
		}
		else if (this is Function)
		{
			PFunHeader header = ((Function)this).header;
			result = Convert.ToString(_N_prefix_41037(n_closureOf_HeaderToString_)) + Convert.ToString(header);
		}
		else if (this is Property)
		{
			PExpr ty = ((Property)this).returnType;
			list<PParameter> list = ((Property)this).parameters;
			result = Convert.ToString(_N_prefix_41037(n_closureOf_HeaderToString_)) + Convert.ToString(splicable) + Convert.ToString((!list.IsEmpty) ? list.ToString() : "") + " : " + Convert.ToString(ty);
		}
		else if (this is Event)
		{
			PExpr ty = ((Event)this).ty;
			result = Convert.ToString(_N_prefix_41037(n_closureOf_HeaderToString_)) + Convert.ToString(splicable) + " : " + Convert.ToString(ty);
		}
		else
		{
			if (!(this is EnumOption))
			{
				throw new MatchFailureException();
			}
			option<PExpr> option = ((EnumOption)this).value;
			string text2 = string.Concat(Convert.ToString(splicable));
			object obj;
			if (option is option<PExpr>.Some)
			{
				PExpr ty = ((option<PExpr>.Some)option).val;
				obj = " = " + Convert.ToString(ty);
			}
			else
			{
				if (option != option<PExpr>.None._N_constant_object)
				{
					throw new MatchFailureException();
				}
				obj = "";
			}
			string text3 = (string)obj;
			result = text2 + text3;
		}
		return result;
	}

	public override string ToString()
	{
		string text = null;
		_N_closureOf_ToString_41083 n_closureOf_ToString_ = new _N_closureOf_ToString_41083();
		n_closureOf_ToString_._N__N_closurised_this_ptr_41090 = this;
		text = ((modifiers != null) ? Attributes.ToString().ToLower().Replace(",", "") : "");
		n_closureOf_ToString_._N_attrs_41088 = ((!(text == "")) ? (text + " ") : text);
		Splicable splicable = name;
		object result;
		if (this is TypeDeclaration)
		{
			TopDeclaration td = ((TypeDeclaration)this).td;
			result = "TopDeclaration: " + Convert.ToString(_N_prefix_41109(n_closureOf_ToString_)) + "Name=" + Convert.ToString(splicable) + " (" + Convert.ToString(td) + ")";
		}
		else if (this is Field)
		{
			PExpr ty = ((Field)this).ty;
			result = "Field: " + Convert.ToString(_N_prefix_41109(n_closureOf_ToString_)) + Convert.ToString(splicable) + " : " + Convert.ToString(ty) + ";";
		}
		else if (this is Function)
		{
			PFunHeader header = ((Function)this).header;
			result = "Function: " + Convert.ToString(_N_prefix_41109(n_closureOf_ToString_)) + Convert.ToString(header) + ";";
		}
		else if (this is Property)
		{
			PExpr ty = ((Property)this).returnType;
			list<PParameter> list = ((Property)this).parameters;
			option<Function> option = ((Property)this).getter;
			option<Function> option2 = ((Property)this).setter;
			option<PExpr> option3 = ((Property)this).initializer;
			text = "{ ";
			if (option.IsSome)
			{
				text += "get; ";
			}
			if (option2.IsSome)
			{
				text += "set; ";
			}
			if (option3.IsSome)
			{
				text += "default; ";
			}
			result = string.Concat(str1: (text.Length <= 2) ? ";" : (text + "}"), str0: string.Concat("Property: " + Convert.ToString(_N_prefix_41109(n_closureOf_ToString_)) + Convert.ToString(splicable) + " : " + Convert.ToString(ty), (!list.IsEmpty) ? list.ToString() : ""));
		}
		else if (this is Event)
		{
			PExpr ty = ((Event)this).ty;
			result = "Event: " + Convert.ToString(_N_prefix_41109(n_closureOf_ToString_)) + Convert.ToString(splicable) + " : " + Convert.ToString(ty);
		}
		else
		{
			if (!(this is EnumOption))
			{
				throw new MatchFailureException();
			}
			option<PExpr> option3 = ((EnumOption)this).value;
			string text2 = string.Concat(Convert.ToString(splicable));
			object obj2;
			if (option3 is option<PExpr>.Some)
			{
				PExpr ty = ((option<PExpr>.Some)option3).val;
				obj2 = " = " + Convert.ToString(ty);
			}
			else
			{
				if (option3 != option<PExpr>.None._N_constant_object)
				{
					throw new MatchFailureException();
				}
				obj2 = "";
			}
			string text3 = (string)obj2;
			result = text2 + text3;
		}
		return (string)result;
	}

	[SpecialName]
	public abstract override int _N_GetVariantCode();

	[SpecialName]
	public static int _N_GetVariantCodeSafe(ClassMember x)
	{
		return ((object)x != null) ? x._N_GetVariantCode() : (-1);
	}

	[SpecialName]
	public static int _N_GetVariantCodeObject(object x)
	{
		return (!(x is ClassMember)) ? (-1) : ((ClassMember)x)._N_GetVariantCode();
	}

	[RecordCtor]
	protected ClassMember(Splicable name, AttributesAndModifiers modifiers)
		: base(name, modifiers)
	{
	}

	[RecordCtor]
	protected ClassMember(Location loc, Splicable name, AttributesAndModifiers modifiers)
		: base(loc, name, modifiers)
	{
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			base.RelocateImplInternal(_info);
			_info.VisitedObjects[this] = 0;
			_builder?.RelocateImplInternal(_info);
			_tokens?.RelocateImplInternal(_info);
		}
	}

	private static void _N_print_40970(_N_closureOf_PrintBody_40955 _N_PrintBody_cp_40969, option<Function> accessor, string acc_type)
	{
		if (accessor is option<Function>.Some && ((option<Function>.Some)accessor).val.body is FunBody.Parsed)
		{
			PExpr expr = ((FunBody.Parsed)((option<Function>.Some)accessor).val.body).expr;
			_N_PrintBody_cp_40969._N_writer_40960.Write(Environment.NewLine + Convert.ToString(acc_type));
			PrettyPrint.SprintExpr(option<Typer>.None._N_constant_object, expr, "", _N_PrintBody_cp_40969._N_writer_40960);
			_N_PrintBody_cp_40969._N_writer_40960.Write("\n");
		}
	}

	private string _N_ifMutable_41027(_N_closureOf_HeaderToString_41011 _N_HeaderToString_cp_41026)
	{
		return (!IsMutable()) ? "" : "mutable ";
	}

	private string _N_prefix_41037(_N_closureOf_HeaderToString_41011 _N_HeaderToString_cp_41036)
	{
		return Convert.ToString(_N_HeaderToString_cp_41036._N_attrs_41016) + Convert.ToString(_N_ifMutable_41027(_N_HeaderToString_cp_41036));
	}

	private string _N_ifMutable_41099(_N_closureOf_ToString_41083 _N_ToString_cp_41098)
	{
		return (!IsMutable()) ? "" : "mutable ";
	}

	private string _N_prefix_41109(_N_closureOf_ToString_41083 _N_ToString_cp_41108)
	{
		return Convert.ToString(_N_ToString_cp_41108._N_attrs_41088) + Convert.ToString(_N_ifMutable_41099(_N_ToString_cp_41108));
	}
}
