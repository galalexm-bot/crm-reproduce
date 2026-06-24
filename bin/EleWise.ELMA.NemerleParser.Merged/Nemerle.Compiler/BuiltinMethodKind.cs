using System.Runtime.CompilerServices;
using Nemerle.Internal;

namespace Nemerle.Compiler;

[Variant("Nemerle.Compiler.BuiltinMethodKind.NotBuiltin,Nemerle.Compiler.BuiltinMethodKind.OpCode,Nemerle.Compiler.BuiltinMethodKind.CallWithCast,Nemerle.Compiler.BuiltinMethodKind.ValueTypeConversion,Nemerle.Compiler.BuiltinMethodKind.ExtensionMethod")]
public abstract class BuiltinMethodKind : ISupportRelocation
{
	[ConstantVariantOption]
	public class NotBuiltin : BuiltinMethodKind
	{
		public static readonly NotBuiltin _N_constant_object;

		[SpecialName]
		public static NotBuiltin _N_constant_object_generator()
		{
			return _N_constant_object;
		}

		static NotBuiltin()
		{
			_N_constant_object = new NotBuiltin();
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 0;
		}

		[RecordCtor]
		private NotBuiltin()
		{
		}
	}

	[VariantOption]
	public class OpCode : BuiltinMethodKind
	{
		public readonly string checked_opcode;

		public readonly string unchecked_opcode;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 1;
		}

		[RecordCtor]
		public OpCode([MappedMember("checked_opcode")] string checked_opcode, [MappedMember("unchecked_opcode")] string unchecked_opcode)
		{
			this.checked_opcode = checked_opcode;
			this.unchecked_opcode = unchecked_opcode;
		}
	}

	[VariantOption]
	public class CallWithCast : BuiltinMethodKind
	{
		public readonly IMethod meth;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 2;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				IMethod method = meth;
				if (method != null)
				{
					((ISupportRelocation)method).RelocateImpl(_info);
				}
			}
		}

		[RecordCtor]
		public CallWithCast([MappedMember("meth")] IMethod meth)
		{
			this.meth = meth;
		}
	}

	[ConstantVariantOption]
	public class ValueTypeConversion : BuiltinMethodKind
	{
		public static readonly ValueTypeConversion _N_constant_object;

		[SpecialName]
		public static ValueTypeConversion _N_constant_object_generator()
		{
			return _N_constant_object;
		}

		static ValueTypeConversion()
		{
			_N_constant_object = new ValueTypeConversion();
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 3;
		}

		[RecordCtor]
		private ValueTypeConversion()
		{
		}
	}

	[VariantOption]
	public class ExtensionMethod : BuiltinMethodKind
	{
		public readonly IMethod impl;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 4;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				IMethod method = impl;
				if (method != null)
				{
					((ISupportRelocation)method).RelocateImpl(_info);
				}
			}
		}

		[RecordCtor]
		public ExtensionMethod([MappedMember("impl")] IMethod impl)
		{
			this.impl = impl;
		}
	}

	[SpecialName]
	public abstract override int _N_GetVariantCode();

	[SpecialName]
	public static int _N_GetVariantCodeSafe(BuiltinMethodKind x)
	{
		return ((object)x != null) ? x._N_GetVariantCode() : (-1);
	}

	[SpecialName]
	public static int _N_GetVariantCodeObject(object x)
	{
		return (!(x is BuiltinMethodKind)) ? (-1) : ((BuiltinMethodKind)x)._N_GetVariantCode();
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
