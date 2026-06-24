using System;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using Nemerle.Core;
using Nemerle.Internal;
using Nemerle.Utility;

namespace Nemerle.Compiler;

[Variant("Nemerle.Compiler.Literal.Void,Nemerle.Compiler.Literal.Null,Nemerle.Compiler.Literal.String,Nemerle.Compiler.Literal.Float,Nemerle.Compiler.Literal.Double,Nemerle.Compiler.Literal.Decimal,Nemerle.Compiler.Literal.Char,Nemerle.Compiler.Literal.Bool,Nemerle.Compiler.Literal.Integer,Nemerle.Compiler.Literal.Enum")]
public abstract class Literal : IEquatable<Literal>, ISupportRelocation
{
	[VariantOption]
	public class Void : Literal
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 0;
		}

		[RecordCtor]
		public Void()
		{
		}
	}

	[VariantOption]
	public class Null : Literal
	{
		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 1;
		}

		[RecordCtor]
		public Null()
		{
		}
	}

	[VariantOption]
	public class String : Literal
	{
		public readonly string val;

		public String(string value, string rawString)
		{
			val = value;
			RawString = rawString;
		}

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 2;
		}

		[RecordCtor]
		public String([MappedMember("val")] string val)
		{
			this.val = val;
		}
	}

	[VariantOption]
	public class Float : Literal
	{
		public readonly float val;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 3;
		}

		[RecordCtor]
		public Float([MappedMember("val")] float val)
		{
			this.val = val;
		}
	}

	[VariantOption]
	public class Double : Literal
	{
		public readonly double val;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 4;
		}

		[RecordCtor]
		public Double([MappedMember("val")] double val)
		{
			this.val = val;
		}
	}

	[VariantOption]
	public class Decimal : Literal
	{
		public readonly decimal val;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 5;
		}

		[RecordCtor]
		public Decimal([MappedMember("val")] decimal val)
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
			return 6;
		}

		[RecordCtor]
		public Char([MappedMember("val")] char val)
		{
			this.val = val;
		}
	}

	[VariantOption]
	public class Bool : Literal
	{
		public readonly bool val;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 7;
		}

		[RecordCtor]
		public Bool([MappedMember("val")] bool val)
		{
			this.val = val;
		}
	}

	[VariantOption]
	public class Integer : Literal
	{
		public readonly ulong val;

		public readonly bool is_negative;

		public FixedType.Class treat_as;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 8;
		}

		[RecordCtor]
		public Integer([MappedMember("val")] ulong val, [MappedMember("is_negative")] bool is_negative, [MappedMember("treat_as")] FixedType.Class treat_as)
		{
			this.val = val;
			this.is_negative = is_negative;
			this.treat_as = treat_as;
		}
	}

	[VariantOption]
	public class Enum : Literal
	{
		public readonly Integer val;

		public readonly TypeInfo ty;

		public readonly IField field;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 9;
		}

		[RecordCtor]
		public Enum([MappedMember("val")] Integer val, [MappedMember("ty")] TypeInfo ty, [MappedMember("field")] IField field)
		{
			this.val = val;
			this.ty = ty;
			this.field = field;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				IField field = this.field;
				if (field != null)
				{
					((ISupportRelocation)field).RelocateImpl(_info);
				}
				val?.RelocateImplInternal(_info);
			}
		}
	}

	public string RawString { get; set; }

	public option<int> AsInt
	{
		get
		{
			object result;
			ulong val;
			bool is_negative;
			if (this is Integer)
			{
				if (((Integer)this).val == 2147483648L)
				{
					if (((Integer)this).is_negative)
					{
						result = new option<int>.Some(int.MinValue);
						goto IL_00c2;
					}
					val = ((Integer)this).val;
					is_negative = ((Integer)this).is_negative;
					if ((val & 0x7FFFFFFF) == val)
					{
						goto IL_006b;
					}
				}
				else
				{
					val = ((Integer)this).val;
					is_negative = ((Integer)this).is_negative;
					if ((val & 0x7FFFFFFF) == val)
					{
						goto IL_006b;
					}
				}
			}
			result = option<int>.None._N_constant_object;
			goto IL_00c2;
			IL_00c2:
			return (option<int>)result;
			IL_006b:
			result = new option<int>.Some(checked((!is_negative) ? ((int)val) : ((int)val * -1)));
			goto IL_00c2;
		}
	}

	internal option<int> AsRawInt
	{
		get
		{
			option<int> asInt = AsInt;
			object result;
			if (asInt is option<int>.Some)
			{
				result = (option<int>.Some)asInt;
			}
			else if (this is Enum)
			{
				Integer val = ((Enum)this).val;
				result = val.AsInt;
			}
			else
			{
				result = option<int>.None._N_constant_object;
			}
			return (option<int>)result;
		}
	}

	public option<sbyte> AsSByte
	{
		get
		{
			object result;
			ulong val;
			bool is_negative;
			if (this is Integer)
			{
				if (((Integer)this).val == 128)
				{
					if (((Integer)this).is_negative)
					{
						result = new option<sbyte>.Some(sbyte.MinValue);
						goto IL_00b7;
					}
					val = ((Integer)this).val;
					is_negative = ((Integer)this).is_negative;
					if ((val & 0x7F) == val)
					{
						goto IL_0062;
					}
				}
				else
				{
					val = ((Integer)this).val;
					is_negative = ((Integer)this).is_negative;
					if ((val & 0x7F) == val)
					{
						goto IL_0062;
					}
				}
			}
			result = option<sbyte>.None._N_constant_object;
			goto IL_00b7;
			IL_00b7:
			return (option<sbyte>)result;
			IL_0062:
			result = new option<sbyte>.Some(checked((!is_negative) ? ((sbyte)val) : ((sbyte)((int)val * -1))));
			goto IL_00b7;
		}
	}

	public option<byte> AsByte
	{
		get
		{
			object result;
			if (this is Integer && !((Integer)this).is_negative)
			{
				ulong val = ((Integer)this).val;
				if (val <= 255uL)
				{
					result = new option<byte>.Some(checked((byte)val));
					goto IL_0053;
				}
			}
			result = option<byte>.None._N_constant_object;
			goto IL_0053;
			IL_0053:
			return (option<byte>)result;
		}
	}

	public option<short> AsShort
	{
		get
		{
			object result;
			ulong val;
			bool is_negative;
			if (this is Integer)
			{
				if (((Integer)this).val == 32768)
				{
					if (((Integer)this).is_negative)
					{
						result = new option<short>.Some(short.MinValue);
						goto IL_00c0;
					}
					val = ((Integer)this).val;
					is_negative = ((Integer)this).is_negative;
					if ((val & 0x7FFF) == val)
					{
						goto IL_0068;
					}
				}
				else
				{
					val = ((Integer)this).val;
					is_negative = ((Integer)this).is_negative;
					if ((val & 0x7FFF) == val)
					{
						goto IL_0068;
					}
				}
			}
			result = option<short>.None._N_constant_object;
			goto IL_00c0;
			IL_00c0:
			return (option<short>)result;
			IL_0068:
			result = new option<short>.Some(checked((!is_negative) ? ((short)val) : ((short)((int)val * -1))));
			goto IL_00c0;
		}
	}

	public option<ushort> AsUShort
	{
		get
		{
			object result;
			if (this is Integer && !((Integer)this).is_negative)
			{
				ulong val = ((Integer)this).val;
				if (val <= 65535uL)
				{
					result = new option<ushort>.Some(checked((ushort)val));
					goto IL_0053;
				}
			}
			result = option<ushort>.None._N_constant_object;
			goto IL_0053;
			IL_0053:
			return (option<ushort>)result;
		}
	}

	public option<uint> AsUInt
	{
		get
		{
			object result;
			if (this is Integer && !((Integer)this).is_negative)
			{
				ulong val = ((Integer)this).val;
				if (val <= 4294967295uL)
				{
					result = new option<uint>.Some(checked((uint)val));
					goto IL_004f;
				}
			}
			result = option<uint>.None._N_constant_object;
			goto IL_004f;
			IL_004f:
			return (option<uint>)result;
		}
	}

	public option<long> AsLong
	{
		get
		{
			object result;
			ulong val;
			bool is_negative;
			if (this is Integer)
			{
				if (((Integer)this).val == 9223372036854775808uL)
				{
					if (((Integer)this).is_negative)
					{
						result = new option<long>.Some(long.MinValue);
						goto IL_00cd;
					}
					val = ((Integer)this).val;
					is_negative = ((Integer)this).is_negative;
					if ((val & 0x7FFFFFFFFFFFFFFFL) == val)
					{
						goto IL_0072;
					}
				}
				else
				{
					val = ((Integer)this).val;
					is_negative = ((Integer)this).is_negative;
					if ((val & 0x7FFFFFFFFFFFFFFFL) == val)
					{
						goto IL_0072;
					}
				}
			}
			result = option<long>.None._N_constant_object;
			goto IL_00cd;
			IL_00cd:
			return (option<long>)result;
			IL_0072:
			result = new option<long>.Some(checked((!is_negative) ? ((long)val) : ((long)val * -1L)));
			goto IL_00cd;
		}
	}

	public option<ulong> AsULong
	{
		get
		{
			object result;
			if (this is Integer && !((Integer)this).is_negative)
			{
				ulong val = ((Integer)this).val;
				result = new option<ulong>.Some(val);
			}
			else
			{
				result = option<ulong>.None._N_constant_object;
			}
			return (option<ulong>)result;
		}
	}

	public bool Equals(Literal lit)
	{
		Literal literal = null;
		literal = this;
		int result;
		if (literal is Void)
		{
			if (lit is Void)
			{
				goto IL_003a;
			}
		}
		else
		{
			if (!(literal is Null))
			{
				if (literal is String)
				{
					if (!(lit is String))
					{
						goto IL_030e;
					}
					string val = ((String)literal).val;
					string val2 = ((String)lit).val;
					result = ((val == val2) ? 1 : 0);
				}
				else if (literal is Float)
				{
					if (!(lit is Float))
					{
						goto IL_030e;
					}
					float val3 = ((Float)literal).val;
					float val4 = ((Float)lit).val;
					result = ((val3 == val4) ? 1 : 0);
				}
				else if (literal is Double)
				{
					if (!(lit is Double))
					{
						goto IL_030e;
					}
					double val5 = ((Double)literal).val;
					double val6 = ((Double)lit).val;
					result = ((val5 == val6) ? 1 : 0);
				}
				else if (literal is Decimal)
				{
					if (!(lit is Decimal))
					{
						goto IL_030e;
					}
					decimal val7 = ((Decimal)literal).val;
					decimal val8 = ((Decimal)lit).val;
					result = ((val7 == val8) ? 1 : 0);
				}
				else if (literal is Char)
				{
					if (!(lit is Char))
					{
						goto IL_030e;
					}
					char val9 = ((Char)literal).val;
					char val10 = ((Char)lit).val;
					result = ((val9 == val10) ? 1 : 0);
				}
				else if (literal is Bool)
				{
					if (!(lit is Bool))
					{
						goto IL_030e;
					}
					bool val11 = ((Bool)literal).val;
					bool val12 = ((Bool)lit).val;
					result = ((val11 == val12) ? 1 : 0);
				}
				else if (literal is Integer)
				{
					if (!(lit is Integer))
					{
						goto IL_030e;
					}
					ulong val13 = ((Integer)literal).val;
					bool val12 = ((Integer)literal).is_negative;
					ulong val14 = ((Integer)lit).val;
					bool val11 = ((Integer)lit).is_negative;
					result = ((val13 == val14 && val12 == val11) ? 1 : 0);
				}
				else
				{
					if (!(literal is Enum) || !(lit is Enum))
					{
						goto IL_030e;
					}
					Integer val15 = ((Enum)literal).val;
					TypeInfo ty = ((Enum)literal).ty;
					IField field = ((Enum)literal).field;
					Integer val16 = ((Enum)lit).val;
					TypeInfo ty2 = ((Enum)lit).ty;
					IField field2 = ((Enum)lit).field;
					result = ((val15.Equals(val16) && ty.Equals(ty2) && (field?.Equals(field2) ?? (field2 == null))) ? 1 : 0);
				}
				goto IL_030f;
			}
			if (lit is Null)
			{
				goto IL_003a;
			}
		}
		goto IL_030e;
		IL_003a:
		result = 1;
		goto IL_030f;
		IL_030e:
		result = 0;
		goto IL_030f;
		IL_030f:
		return (byte)result != 0;
	}

	private static string EscapeChar(char ch)
	{
		return ch switch
		{
			'"' => "\\\"", 
			'\\' => "\\\\", 
			'\n' => "\\n", 
			'\t' => "\\t", 
			'\r' => "\\r", 
			'\u001b' => "\\e", 
			'\a' => "\\a", 
			'\b' => "\\b", 
			'\f' => "\\f", 
			'\v' => "\\v", 
			'\0' => "\\0", 
			'\u2028' => "\\u2028", 
			'\u2029' => "\\u2029", 
			'\u0085' => "\\u0085", 
			'\uffff' => "\\uFFFF", 
			_ => ch.ToString(), 
		};
	}

	private static string EscapeString(string str)
	{
		StringBuilder stringBuilder = new StringBuilder();
		CharEnumerator enumerator = str.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				char current = enumerator.Current;
				char ch = current;
				stringBuilder.Append(EscapeChar(ch));
			}
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
		return stringBuilder.ToString();
	}

	public override string ToString()
	{
		object result;
		if (this is Void)
		{
			result = "()";
		}
		else if (this is Null)
		{
			result = "null";
		}
		else if (this is String)
		{
			string val = ((String)this).val;
			result = string.Concat("\"" + EscapeString(val), "\"");
		}
		else if (this is Float)
		{
			result = ((Float)this).val.ToString(NumberFormatInfo.InvariantInfo) + "f";
		}
		else if (this is Double)
		{
			result = ((Double)this).val.ToString(NumberFormatInfo.InvariantInfo) + "d";
		}
		else if (this is Decimal)
		{
			result = ((Decimal)this).val.ToString(NumberFormatInfo.InvariantInfo) + "m";
		}
		else if (this is Char)
		{
			char val2 = ((Char)this).val;
			result = string.Concat("'" + EscapeChar(val2), "'");
		}
		else if (this is Bool)
		{
			result = ((!((Bool)this).val) ? "false" : "true");
		}
		else if (this is Integer)
		{
			ulong val3 = ((Integer)this).val;
			bool is_negative = ((Integer)this).is_negative;
			FixedType.Class treat_as = ((Integer)this).treat_as;
			object obj;
			if (is_negative)
			{
				obj = "-" + val3;
			}
			else if (treat_as == null)
			{
				obj = val3.ToString();
			}
			else
			{
				InternalTypeClass internalType = treat_as.InternalType;
				obj = (treat_as.Equals(internalType.Int32) ? val3.ToString() : (treat_as.Equals(internalType.Int64) ? (Convert.ToString(val3) + "L") : (treat_as.Equals(internalType.UInt64) ? (Convert.ToString(val3) + "UL") : (treat_as.Equals(internalType.UInt32) ? (Convert.ToString(val3) + "U") : (treat_as.Equals(internalType.Int16) ? (Convert.ToString(val3) + "S") : (treat_as.Equals(internalType.UInt16) ? (Convert.ToString(val3) + "SU") : (treat_as.Equals(internalType.Byte) ? (Convert.ToString(val3) + "B") : ((!treat_as.Equals(internalType.SByte)) ? val3.ToString() : (Convert.ToString(val3) + "SB")))))))));
			}
			string val = (string)obj;
			result = val;
		}
		else
		{
			if (!(this is Enum))
			{
				throw new MatchFailureException();
			}
			Integer val4 = ((Enum)this).val;
			TypeInfo ty = ((Enum)this).ty;
			result = string.Concat(string.Concat(string.Concat("(" + val4.ToString(), " :> "), ty.FullName), ")");
		}
		return (string)result;
	}

	public Type SystemType(InternalTypeClass InternalType)
	{
		return GetInternalType(InternalType).GetSystemType();
	}

	public FixedType GetInternalType(InternalTypeClass InternalType)
	{
		object result;
		if (this is Void)
		{
			result = InternalType.Void;
		}
		else if (this is Null)
		{
			result = InternalType.Object;
		}
		else if (this is String)
		{
			result = InternalType.String;
		}
		else if (this is Float)
		{
			result = InternalType.Single;
		}
		else if (this is Double)
		{
			result = InternalType.Double;
		}
		else if (this is Decimal)
		{
			result = InternalType.Decimal;
		}
		else if (this is Char)
		{
			result = InternalType.Char;
		}
		else if (this is Bool)
		{
			result = InternalType.Boolean;
		}
		else if (this is Integer)
		{
			FixedType.Class treat_as = ((Integer)this).treat_as;
			result = treat_as;
		}
		else
		{
			if (!(this is Enum))
			{
				throw new MatchFailureException();
			}
			TypeInfo ty = ((Enum)this).ty;
			result = ty.GetMemType();
		}
		return (FixedType)result;
	}

	public option<Literal> WithType(FixedType t)
	{
		InternalTypeClass internalType = t.Manager.InternalType;
		object result;
		if (this is Void)
		{
			result = option<Literal>.None._N_constant_object;
		}
		else
		{
			if (this is Null)
			{
				if (t.CanBeNull)
				{
					goto IL_01c7;
				}
			}
			else if (this is String)
			{
				if (t.Equals(internalType.String))
				{
					goto IL_01c7;
				}
			}
			else if (this is Float)
			{
				if (t.Equals(internalType.Single))
				{
					goto IL_01c7;
				}
			}
			else if (this is Double)
			{
				if (t.Equals(internalType.Double))
				{
					goto IL_01c7;
				}
			}
			else if (this is Decimal)
			{
				if (t.Equals(internalType.Decimal))
				{
					goto IL_01c7;
				}
			}
			else if (this is Char)
			{
				if (t.Equals(internalType.Char))
				{
					goto IL_01c7;
				}
			}
			else if (this is Bool)
			{
				if (t.Equals(internalType.Boolean))
				{
					goto IL_01c7;
				}
			}
			else
			{
				if (this is Integer)
				{
					ulong val = ((Integer)this).val;
					bool is_negative = ((Integer)this).is_negative;
					FixedType.Class treat_as = ((Integer)this).treat_as;
					result = (treat_as.Equals(t) ? new option<Literal>.Some(this) : ((!Typer.LiteralConversionPossible(this, t)) ? ((option<Literal>)option<Literal>.None._N_constant_object) : ((option<Literal>)new option<Literal>.Some(new Integer(val, is_negative, (FixedType.Class)t)))));
					goto IL_01e1;
				}
				if (this is Enum)
				{
					TypeInfo ty = ((Enum)this).ty;
					if (new FixedType.Class(ty, list<TypeVar>.Nil._N_constant_object).Equals(t))
					{
						goto IL_01c7;
					}
				}
			}
			result = option<Literal>.None._N_constant_object;
		}
		goto IL_01e1;
		IL_01c7:
		result = new option<Literal>.Some(this);
		goto IL_01e1;
		IL_01e1:
		return (option<Literal>)result;
	}

	public Literal WithProperType()
	{
		InternalTypeClass internalType = ManagerClass.Instance.InternalType;
		object result;
		if (this is Integer)
		{
			if (((Integer)this).val == 0uL && ((Integer)this).is_negative)
			{
				result = new Integer(0uL, is_negative: false, internalType.Int32);
			}
			else
			{
				ulong val = ((Integer)this).val;
				bool is_negative = ((Integer)this).is_negative;
				FixedType.Class treat_as = (is_negative ? ((checked(val - 1uL) > 2147483647uL) ? internalType.Int64 : internalType.Int32) : ((val <= 2147483647uL) ? internalType.Int32 : ((val <= 4294967295uL) ? internalType.UInt32 : ((val > Convert.ToUInt64(long.MaxValue)) ? internalType.UInt64 : internalType.Int64))));
				result = new Integer(val, is_negative, treat_as);
			}
		}
		else
		{
			result = this;
		}
		return (Literal)result;
	}

	public object AsObject(InternalTypeClass InternalType)
	{
		if (this is Void)
		{
			throw new AssertionException("ncc\\parsing\\AST.n", 970, "", "");
		}
		object result;
		Integer val7;
		Type systemType;
		checked
		{
			if (this is Null)
			{
				result = null;
			}
			else if (this is String)
			{
				string val = ((String)this).val;
				result = val;
			}
			else if (this is Float)
			{
				float val2 = ((Float)this).val;
				result = val2;
			}
			else if (this is Double)
			{
				double val3 = ((Double)this).val;
				result = val3;
			}
			else if (this is Decimal)
			{
				decimal val4 = ((Decimal)this).val;
				result = val4;
			}
			else if (this is Char)
			{
				char val5 = ((Char)this).val;
				result = val5;
			}
			else if (this is Bool)
			{
				bool val6 = ((Bool)this).val;
				result = val6;
			}
			else
			{
				if (!(this is Integer))
				{
					if (this is Enum)
					{
						val7 = ((Enum)this).val;
						TypeInfo ty = ((Enum)this).ty;
						systemType = ty.SystemType;
						if (systemType is EnumBuilder)
						{
							if (1 == 0)
							{
								goto IL_0376;
							}
						}
						else if (0 == 0)
						{
							goto IL_0376;
						}
						goto IL_038e;
					}
					throw new MatchFailureException();
				}
				ulong val8 = ((Integer)this).val;
				bool val6 = ((Integer)this).is_negative;
				FixedType.Class treat_as = ((Integer)this).treat_as;
				treat_as = ((treat_as != null) ? treat_as : InternalType.Int32);
				if (treat_as.Equals(InternalType.UInt64))
				{
					if (val6)
					{
						throw new AssertionException("ncc\\parsing\\AST.n", 988, "!is_neg", "");
					}
					result = val8;
				}
				else if (val8 == 9223372036854775808uL)
				{
					if (!val6)
					{
						throw new AssertionException("ncc\\parsing\\AST.n", 991, "is_neg", "");
					}
					if (!treat_as.Equals(InternalType.Int64))
					{
						throw new AssertionException("ncc\\parsing\\AST.n", 992, "t.Equals(InternalType.Int64)", "");
					}
					result = long.MinValue;
				}
				else
				{
					long num = ((!val6) ? Convert.ToInt64(val8) : (Convert.ToInt64(val8) * -1L));
					result = treat_as.tycon.FullName switch
					{
						"System.UInt32" => (uint)num, 
						"System.Int32" => (int)num, 
						"System.Int16" => (short)num, 
						"System.UInt16" => (ushort)num, 
						"System.SByte" => (sbyte)num, 
						"System.Byte" => (byte)num, 
						"System.Int64" => num, 
						_ => throw new AssertionException("ncc\\parsing\\AST.n", 1008, "", treat_as.tycon.FullName.ToString()), 
					};
				}
			}
			goto IL_03b5;
		}
		IL_0376:
		if (systemType is System.Reflection.Emit.TypeBuilder)
		{
			goto IL_038e;
		}
		result = System.Enum.ToObject(systemType, val7.AsObject(InternalType));
		goto IL_03b5;
		IL_038e:
		result = val7.AsObject(InternalType);
		goto IL_03b5;
		IL_03b5:
		return result;
	}

	public static Integer FromInt(int x)
	{
		InternalTypeClass internalType = ManagerClass.Instance.InternalType;
		return (x != int.MinValue) ? new Integer(checked((ulong)Math.Abs(x)), x < 0, internalType.Int32) : new Integer(2147483648uL, is_negative: true, internalType.Int32);
	}

	public static Integer FromSByte(sbyte x)
	{
		InternalTypeClass internalType = ManagerClass.Instance.InternalType;
		return (x != sbyte.MinValue) ? new Integer(checked((ulong)Math.Abs(x)), x < 0, internalType.SByte) : new Integer(128uL, is_negative: true, internalType.SByte);
	}

	public static Integer FromByte(byte x)
	{
		InternalTypeClass internalType = ManagerClass.Instance.InternalType;
		return new Integer(x, is_negative: false, internalType.Byte);
	}

	public static Integer FromShort(short x)
	{
		InternalTypeClass internalType = ManagerClass.Instance.InternalType;
		return (x != short.MinValue) ? new Integer(checked((ulong)Math.Abs(x)), x < 0, internalType.Int16) : new Integer(32768uL, is_negative: true, internalType.Int16);
	}

	public static Integer FromUShort(ushort x)
	{
		InternalTypeClass internalType = ManagerClass.Instance.InternalType;
		return new Integer(x, is_negative: false, internalType.UInt16);
	}

	public static Integer FromUInt(uint x)
	{
		InternalTypeClass internalType = ManagerClass.Instance.InternalType;
		return new Integer(x, is_negative: false, internalType.UInt32);
	}

	public static Integer FromLong(long x)
	{
		InternalTypeClass internalType = ManagerClass.Instance.InternalType;
		return (x != long.MinValue) ? new Integer(checked((ulong)Math.Abs(x)), x < 0L, internalType.Int64) : new Integer(9223372036854775808uL, is_negative: true, internalType.Int64);
	}

	public static Integer FromULong(ulong x)
	{
		InternalTypeClass internalType = ManagerClass.Instance.InternalType;
		return new Integer(x, is_negative: false, internalType.UInt64);
	}

	public static Literal FromObject(object o)
	{
		object result;
		if (o == null)
		{
			result = new Null();
		}
		else if (o is bool)
		{
			result = new Bool((bool)o);
		}
		else if (o is string)
		{
			result = new String((string)o);
		}
		else if (o is float)
		{
			result = new Float((float)o);
		}
		else if (o is double)
		{
			result = new Double((double)o);
		}
		else if (o is decimal)
		{
			result = new Decimal((decimal)o);
		}
		else if (o is char)
		{
			result = new Char((char)o);
		}
		else if (o is int)
		{
			result = FromInt((int)o);
		}
		else if (o is sbyte)
		{
			result = FromSByte((sbyte)o);
		}
		else if (o is byte)
		{
			result = FromByte((byte)o);
		}
		else if (o is short)
		{
			result = FromShort((short)o);
		}
		else if (o is ushort)
		{
			result = FromUShort((ushort)o);
		}
		else if (o is uint)
		{
			result = FromUInt((uint)o);
		}
		else if (o is long)
		{
			result = FromLong((long)o);
		}
		else if (o is ulong)
		{
			result = FromULong((ulong)o);
		}
		else
		{
			string text;
			if (!(o is System.Enum))
			{
				if (!Message.SeenError)
				{
					text = ("cannot create literal from " + Convert.ToString(o)).ToString();
					Message.Debug(string.Concat("Internal compiler error '" + Convert.ToString(text) + "', please report a bug to bugs.nemerle.org. ", "You can try modifying program near this location."));
				}
				throw new AssertionException("ncc\\parsing\\AST.n", 1217, "", ("cannot create literal from " + Convert.ToString(o)).ToString());
			}
			System.Enum @enum = (System.Enum)o;
			text = @enum.ToString("d");
			list<string> list = NString.Split(@enum.GetType().TypeFullName(), '+', '.');
			option<TypeInfo> option = ManagerClass.Instance.NameTree.LookupExactType(list);
			if (!(option is option<TypeInfo>.Some))
			{
				if (option == option<TypeInfo>.None._N_constant_object)
				{
					Message.Error(Location.Default, "type `" + Convert.ToString(list.ToString(".")) + "' is not available - it is either not public or not referenced properly");
					throw new Recovery();
				}
				throw new MatchFailureException();
			}
			TypeInfo val = ((option<TypeInfo>.Some)option).val;
			val = val;
			FixedType.Class memType = val.GetMemType();
			Integer val2 = ((text[0] != '-') ? new Integer(ulong.Parse(text), is_negative: false, memType) : new Integer(ulong.Parse(text.Substring(1)), is_negative: true, memType));
			result = new Enum(val2, val, null);
		}
		return (Literal)result;
	}

	public override bool Equals(object other)
	{
		return other == this || (other is Literal && Equals((Literal)other));
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
