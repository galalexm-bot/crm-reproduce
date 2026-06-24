using System;
using System.Runtime.CompilerServices;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Peg;

[Variant("Nemerle.Peg.Transition.Symbol,Nemerle.Peg.Transition.Epsilon")]
public abstract class Transition
{
	[VariantOption]
	public class Symbol : Transition
	{
		public readonly RangeSet Chars;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 0;
		}

		[RecordCtor]
		public Symbol([MappedMember("From")] int from, [MappedMember("To")] int to, [MappedMember("Chars")] RangeSet chars)
			: base(from, to)
		{
			Chars = chars;
		}
	}

	[VariantOption]
	public class Epsilon : Transition
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 1;
		}

		[RecordCtor]
		public Epsilon([MappedMember("From")] int from, [MappedMember("To")] int to)
			: base(from, to)
		{
		}
	}

	public readonly int From;

	public readonly int To;

	public override string ToString()
	{
		string result;
		if (this is Symbol)
		{
			RangeSet chars = ((Symbol)this).Chars;
			result = "Symbol(" + Convert.ToString(From) + " " + Convert.ToString(To) + " [" + Convert.ToString(chars) + "])";
		}
		else
		{
			if (!(this is Epsilon))
			{
				throw new MatchFailureException();
			}
			result = "Epsilon(" + Convert.ToString(From) + " " + Convert.ToString(To) + ")";
		}
		return result;
	}

	[SpecialName]
	public abstract override int _N_GetVariantCode();

	[SpecialName]
	public static int _N_GetVariantCodeSafe(Transition x)
	{
		return ((object)x != null) ? x._N_GetVariantCode() : (-1);
	}

	[SpecialName]
	public static int _N_GetVariantCodeObject(object x)
	{
		return (!(x is Transition)) ? (-1) : ((Transition)x)._N_GetVariantCode();
	}

	[RecordCtor]
	protected Transition([MappedMember("From")] int from, [MappedMember("To")] int to)
	{
		From = from;
		To = to;
	}
}
