using System;
using System.Runtime.CompilerServices;
using Nemerle.Core;
using Nemerle.Internal;
using Nemerle.Peg;

namespace EleWise.ELMA.NemerleParser;

[Variant("EleWise.ELMA.NemerleParser.Literal.Null,EleWise.ELMA.NemerleParser.Literal.Boolean,EleWise.ELMA.NemerleParser.Literal.Char,EleWise.ELMA.NemerleParser.Literal.String,EleWise.ELMA.NemerleParser.Literal.Real,EleWise.ELMA.NemerleParser.Literal.Integer,EleWise.ELMA.NemerleParser.Literal.ErrorOverflow,EleWise.ELMA.NemerleParser.Literal.ErrorUnicode,EleWise.ELMA.NemerleParser.Literal.ErrorChar")]
public abstract class Literal : Located
{
	[VariantOption]
	public class Null : Literal
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 0;
		}

		[RecordCtor]
		public Null()
		{
		}

		[RecordCtor]
		public Null(Location location)
			: base(location)
		{
		}
	}

	[VariantOption]
	public class Boolean : Literal
	{
		public readonly bool val;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 1;
		}

		[RecordCtor]
		public Boolean([MappedMember("val")] bool val)
		{
			this.val = val;
		}

		[RecordCtor]
		public Boolean(Location location, [MappedMember("val")] bool val)
			: base(location)
		{
			this.val = val;
		}
	}

	[VariantOption]
	public class Char : Literal
	{
		public readonly char val;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 2;
		}

		[RecordCtor]
		public Char([MappedMember("val")] char val)
		{
			this.val = val;
		}

		[RecordCtor]
		public Char(Location location, [MappedMember("val")] char val)
			: base(location)
		{
			this.val = val;
		}
	}

	[VariantOption]
	public class String : Literal
	{
		public readonly string val;

		public readonly bool is_verbatim;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 3;
		}

		[RecordCtor]
		public String([MappedMember("val")] string val, [MappedMember("is_verbatim")] bool is_verbatim)
		{
			this.val = val;
			this.is_verbatim = is_verbatim;
		}

		[RecordCtor]
		public String(Location location, [MappedMember("val")] string val, [MappedMember("is_verbatim")] bool is_verbatim)
			: base(location)
		{
			this.val = val;
			this.is_verbatim = is_verbatim;
		}
	}

	[VariantOption]
	public class Real : Literal
	{
		public readonly string mantissa;

		public readonly string exponent;

		public readonly string suffix;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 4;
		}

		[RecordCtor]
		public Real([MappedMember("mantissa")] string mantissa, [MappedMember("exponent")] string exponent, [MappedMember("suffix")] string suffix)
		{
			this.mantissa = mantissa;
			this.exponent = exponent;
			this.suffix = suffix;
		}

		[RecordCtor]
		public Real(Location location, [MappedMember("mantissa")] string mantissa, [MappedMember("exponent")] string exponent, [MappedMember("suffix")] string suffix)
			: base(location)
		{
			this.mantissa = mantissa;
			this.exponent = exponent;
			this.suffix = suffix;
		}
	}

	[VariantOption]
	public class Integer : Literal
	{
		public readonly ulong val;

		public readonly bool is_hexadecimal;

		public readonly string suffix;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 5;
		}

		[RecordCtor]
		public Integer([MappedMember("val")] ulong val, [MappedMember("is_hexadecimal")] bool is_hexadecimal, [MappedMember("suffix")] string suffix)
		{
			this.val = val;
			this.is_hexadecimal = is_hexadecimal;
			this.suffix = suffix;
		}

		[RecordCtor]
		public Integer(Location location, [MappedMember("val")] ulong val, [MappedMember("is_hexadecimal")] bool is_hexadecimal, [MappedMember("suffix")] string suffix)
			: base(location)
		{
			this.val = val;
			this.is_hexadecimal = is_hexadecimal;
			this.suffix = suffix;
		}
	}

	[VariantOption]
	public class ErrorOverflow : Literal
	{
		public readonly string value;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 6;
		}

		[RecordCtor]
		public ErrorOverflow([MappedMember("value")] string value)
		{
			this.value = value;
		}

		[RecordCtor]
		public ErrorOverflow(Location location, [MappedMember("value")] string value)
			: base(location)
		{
			this.value = value;
		}
	}

	[VariantOption]
	public class ErrorUnicode : Literal
	{
		public readonly bool is_char;

		public readonly list<Location> locations;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 7;
		}

		[RecordCtor]
		public ErrorUnicode([MappedMember("is_char")] bool is_char, [MappedMember("locations")] list<Location> locations)
		{
			this.is_char = is_char;
			this.locations = locations;
		}

		[RecordCtor]
		public ErrorUnicode(Location location, [MappedMember("is_char")] bool is_char, [MappedMember("locations")] list<Location> locations)
			: base(location)
		{
			this.is_char = is_char;
			this.locations = locations;
		}
	}

	[VariantOption]
	public class ErrorChar : Literal
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 8;
		}

		[RecordCtor]
		public ErrorChar()
		{
		}

		[RecordCtor]
		public ErrorChar(Location location)
			: base(location)
		{
		}
	}

	public override string ToString()
	{
		object result;
		if (this is Null)
		{
			result = "null";
		}
		else if (this is Boolean)
		{
			result = ((!((Boolean)this).val) ? "false" : "true");
		}
		else if (this is Char)
		{
			char val = ((Char)this).val;
			result = "'" + Convert.ToString(val) + "'";
		}
		else if (this is String)
		{
			string val2 = ((String)this).val;
			bool is_verbatim = ((String)this).is_verbatim;
			result = "\"" + Convert.ToString(val2) + "\"";
		}
		else if (this is Real)
		{
			string val2 = ((Real)this).mantissa;
			string exponent = ((Real)this).exponent;
			exponent = ((Real)this).suffix;
			result = string.Concat(Convert.ToString(val2));
		}
		else if (this is Integer)
		{
			ulong val3 = ((Integer)this).val;
			bool is_verbatim = ((Integer)this).is_hexadecimal;
			string val2 = ((Integer)this).suffix;
			result = Convert.ToString(val3) + Convert.ToString(val2);
		}
		else if (this is ErrorOverflow)
		{
			string val2 = ((ErrorOverflow)this).value;
			result = "Error:" + Convert.ToString(val2);
		}
		else if (this is ErrorUnicode)
		{
			result = "Error: Unrecognized unicode escape sequence";
		}
		else
		{
			if (!(this is ErrorChar))
			{
				throw new MatchFailureException();
			}
			result = "Error: Too many characters in literal";
		}
		return (string)result;
	}

	[SpecialName]
	public abstract override int _N_GetVariantCode();

	[SpecialName]
	public static int _N_GetVariantCodeSafe(Literal x)
	{
		return ((object)x != null) ? x._N_GetVariantCode() : (-1);
	}

	[SpecialName]
	public static int _N_GetVariantCodeObject(object x)
	{
		return (!(x is Literal)) ? (-1) : ((Literal)x)._N_GetVariantCode();
	}

	[RecordCtor]
	protected Literal()
	{
	}

	[RecordCtor]
	protected Literal(Location location)
		: base(location)
	{
	}
}
