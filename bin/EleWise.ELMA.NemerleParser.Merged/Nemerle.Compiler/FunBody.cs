using System;
using System.Runtime.CompilerServices;
using Nemerle.Compiler.Parsetree;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler;

[Variant("Nemerle.Compiler.FunBody.Parsed,Nemerle.Compiler.FunBody.Typed,Nemerle.Compiler.FunBody.ILed,Nemerle.Compiler.FunBody.Abstract")]
public abstract class FunBody : ISupportRelocation
{
	[VariantOption]
	public class Parsed : FunBody
	{
		public readonly PExpr expr;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 0;
		}

		[RecordCtor]
		public Parsed([MappedMember("expr")] PExpr expr)
		{
			this.expr = expr;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				expr?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class Typed : FunBody
	{
		public readonly TExpr expr;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 1;
		}

		[RecordCtor]
		public Typed([MappedMember("expr")] TExpr expr)
		{
			this.expr = expr;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				expr?.RelocateImplInternal(_info);
			}
		}
	}

	[ConstantVariantOption]
	public class ILed : FunBody
	{
		public static readonly ILed _N_constant_object;

		[SpecialName]
		public static ILed _N_constant_object_generator()
		{
			return _N_constant_object;
		}

		static ILed()
		{
			_N_constant_object = new ILed();
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 2;
		}

		[RecordCtor]
		private ILed()
		{
		}
	}

	[ConstantVariantOption]
	public class Abstract : FunBody
	{
		public static readonly Abstract _N_constant_object;

		[SpecialName]
		public static Abstract _N_constant_object_generator()
		{
			return _N_constant_object;
		}

		static Abstract()
		{
			_N_constant_object = new Abstract();
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 3;
		}

		[RecordCtor]
		private Abstract()
		{
		}
	}

	public override string ToString()
	{
		object result;
		if (this is Parsed)
		{
			PExpr expr = ((Parsed)this).expr;
			result = "Parsed: " + Convert.ToString(expr);
		}
		else if (this is Typed)
		{
			TExpr expr2 = ((Typed)this).expr;
			result = "Typed: " + Convert.ToString(expr2);
		}
		else if (this == ILed._N_constant_object)
		{
			result = "FunBody.ILed";
		}
		else
		{
			if (this != Abstract._N_constant_object)
			{
				throw new MatchFailureException();
			}
			result = "FunBody.Abstract";
		}
		return (string)result;
	}

	[SpecialName]
	public abstract override int _N_GetVariantCode();

	[SpecialName]
	public static int _N_GetVariantCodeSafe(FunBody x)
	{
		return ((object)x != null) ? x._N_GetVariantCode() : (-1);
	}

	[SpecialName]
	public static int _N_GetVariantCodeObject(object x)
	{
		return (!(x is FunBody)) ? (-1) : ((FunBody)x)._N_GetVariantCode();
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
