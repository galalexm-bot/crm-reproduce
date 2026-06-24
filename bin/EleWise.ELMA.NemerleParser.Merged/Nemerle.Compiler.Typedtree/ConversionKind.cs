using System.Runtime.CompilerServices;
using Nemerle.Internal;

namespace Nemerle.Compiler.Typedtree;

[Variant("Nemerle.Compiler.Typedtree.ConversionKind.MethodCall,Nemerle.Compiler.Typedtree.ConversionKind.IL,Nemerle.Compiler.Typedtree.ConversionKind.UpCast,Nemerle.Compiler.Typedtree.ConversionKind.DownCast,Nemerle.Compiler.Typedtree.ConversionKind.Implicit,Nemerle.Compiler.Typedtree.ConversionKind.IgnoreValue,Nemerle.Compiler.Typedtree.ConversionKind.Unspecified,Nemerle.Compiler.Typedtree.ConversionKind.GenericSim,Nemerle.Compiler.Typedtree.ConversionKind.Boxing,Nemerle.Compiler.Typedtree.ConversionKind.Nop")]
public abstract class ConversionKind : ISupportRelocation
{
	[VariantOption]
	public class MethodCall : ConversionKind
	{
		public readonly TExpr.StaticRef sr;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 0;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				sr?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public MethodCall([MappedMember("sr")] TExpr.StaticRef sr)
		{
			this.sr = sr;
		}
	}

	[VariantOption]
	public class IL : ConversionKind
	{
		public readonly bool is_checked;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 1;
		}

		[RecordCtor]
		public IL([MappedMember("is_checked")] bool is_checked)
		{
			this.is_checked = is_checked;
		}
	}

	[ConstantVariantOption]
	public class UpCast : ConversionKind
	{
		public static readonly UpCast _N_constant_object;

		[SpecialName]
		public static UpCast _N_constant_object_generator()
		{
			return _N_constant_object;
		}

		static UpCast()
		{
			_N_constant_object = new UpCast();
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 2;
		}

		[RecordCtor]
		private UpCast()
		{
		}
	}

	[VariantOption]
	public class DownCast : ConversionKind
	{
		public readonly bool InCheckedContext;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 3;
		}

		[RecordCtor]
		public DownCast([MappedMember("InCheckedContext")] bool inCheckedContext)
		{
			InCheckedContext = inCheckedContext;
		}
	}

	[ConstantVariantOption]
	public class Implicit : ConversionKind
	{
		public static readonly Implicit _N_constant_object;

		[SpecialName]
		public static Implicit _N_constant_object_generator()
		{
			return _N_constant_object;
		}

		static Implicit()
		{
			_N_constant_object = new Implicit();
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 4;
		}

		[RecordCtor]
		private Implicit()
		{
		}
	}

	[ConstantVariantOption]
	public class IgnoreValue : ConversionKind
	{
		public static readonly IgnoreValue _N_constant_object;

		[SpecialName]
		public static IgnoreValue _N_constant_object_generator()
		{
			return _N_constant_object;
		}

		static IgnoreValue()
		{
			_N_constant_object = new IgnoreValue();
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 5;
		}

		[RecordCtor]
		private IgnoreValue()
		{
		}
	}

	[ConstantVariantOption]
	public class Unspecified : ConversionKind
	{
		public static readonly Unspecified _N_constant_object;

		[SpecialName]
		public static Unspecified _N_constant_object_generator()
		{
			return _N_constant_object;
		}

		static Unspecified()
		{
			_N_constant_object = new Unspecified();
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 6;
		}

		[RecordCtor]
		private Unspecified()
		{
		}
	}

	[ConstantVariantOption]
	public class GenericSim : ConversionKind
	{
		public static readonly GenericSim _N_constant_object;

		[SpecialName]
		public static GenericSim _N_constant_object_generator()
		{
			return _N_constant_object;
		}

		static GenericSim()
		{
			_N_constant_object = new GenericSim();
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 7;
		}

		[RecordCtor]
		private GenericSim()
		{
		}
	}

	[ConstantVariantOption]
	public class Boxing : ConversionKind
	{
		public static readonly Boxing _N_constant_object;

		[SpecialName]
		public static Boxing _N_constant_object_generator()
		{
			return _N_constant_object;
		}

		static Boxing()
		{
			_N_constant_object = new Boxing();
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 8;
		}

		[RecordCtor]
		private Boxing()
		{
		}
	}

	[ConstantVariantOption]
	public class Nop : ConversionKind
	{
		public static readonly Nop _N_constant_object;

		[SpecialName]
		public static Nop _N_constant_object_generator()
		{
			return _N_constant_object;
		}

		static Nop()
		{
			_N_constant_object = new Nop();
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 9;
		}

		[RecordCtor]
		private Nop()
		{
		}
	}

	[SpecialName]
	public abstract override int _N_GetVariantCode();

	[SpecialName]
	public static int _N_GetVariantCodeSafe(ConversionKind x)
	{
		return ((object)x != null) ? x._N_GetVariantCode() : (-1);
	}

	[SpecialName]
	public static int _N_GetVariantCodeObject(object x)
	{
		return (!(x is ConversionKind)) ? (-1) : ((ConversionKind)x)._N_GetVariantCode();
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
