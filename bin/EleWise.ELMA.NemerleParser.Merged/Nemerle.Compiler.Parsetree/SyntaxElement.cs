using System.Runtime.CompilerServices;
using Nemerle.Compiler.Typedtree;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler.Parsetree;

[Variant("Nemerle.Compiler.Parsetree.SyntaxElement.Expression,Nemerle.Compiler.Parsetree.SyntaxElement.MatchCase,Nemerle.Compiler.Parsetree.SyntaxElement.Function,Nemerle.Compiler.Parsetree.SyntaxElement.Parameter,Nemerle.Compiler.Parsetree.SyntaxElement.TType,Nemerle.Compiler.Parsetree.SyntaxElement.RawToken,Nemerle.Compiler.Parsetree.SyntaxElement.ClassMember,Nemerle.Compiler.Parsetree.SyntaxElement.TypeBuilder,Nemerle.Compiler.Parsetree.SyntaxElement.FieldBuilder,Nemerle.Compiler.Parsetree.SyntaxElement.MethodBuilder,Nemerle.Compiler.Parsetree.SyntaxElement.PropertyBuilder,Nemerle.Compiler.Parsetree.SyntaxElement.EventBuilder,Nemerle.Compiler.Parsetree.SyntaxElement.ParameterBuilder")]
public abstract class SyntaxElement : ISupportRelocation
{
	[VariantOption]
	public class Expression : SyntaxElement
	{
		public readonly PExpr body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 0;
		}

		[RecordCtor]
		public Expression([MappedMember("body")] PExpr body)
		{
			this.body = body;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				body?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class MatchCase : SyntaxElement
	{
		public readonly Nemerle.Compiler.Parsetree.MatchCase body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 1;
		}

		[RecordCtor]
		public MatchCase([MappedMember("body")] Nemerle.Compiler.Parsetree.MatchCase body)
		{
			this.body = body;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				body?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class Function : SyntaxElement
	{
		public readonly Function_decl body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 2;
		}

		[RecordCtor]
		public Function([MappedMember("body")] Function_decl body)
		{
			this.body = body;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				body?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class Parameter : SyntaxElement
	{
		public readonly PParameter body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 3;
		}

		[RecordCtor]
		public Parameter([MappedMember("body")] PParameter body)
		{
			this.body = body;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				body?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class TType : SyntaxElement
	{
		public readonly PExpr body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 4;
		}

		[RecordCtor]
		public TType([MappedMember("body")] PExpr body)
		{
			this.body = body;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				body?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class RawToken : SyntaxElement
	{
		public readonly Token body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 5;
		}

		[RecordCtor]
		public RawToken([MappedMember("body")] Token body)
		{
			this.body = body;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				body?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class ClassMember : SyntaxElement
	{
		public readonly Nemerle.Compiler.Parsetree.ClassMember body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 6;
		}

		[RecordCtor]
		public ClassMember([MappedMember("body")] Nemerle.Compiler.Parsetree.ClassMember body)
		{
			this.body = body;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				body?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class TypeBuilder : SyntaxElement
	{
		public readonly Nemerle.Compiler.TypeBuilder body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 7;
		}

		[RecordCtor]
		public TypeBuilder([MappedMember("body")] Nemerle.Compiler.TypeBuilder body)
		{
			this.body = body;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				body?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class FieldBuilder : SyntaxElement
	{
		public readonly Nemerle.Compiler.FieldBuilder body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 8;
		}

		[RecordCtor]
		public FieldBuilder([MappedMember("body")] Nemerle.Compiler.FieldBuilder body)
		{
			this.body = body;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				body?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class MethodBuilder : SyntaxElement
	{
		public readonly Nemerle.Compiler.MethodBuilder body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 9;
		}

		[RecordCtor]
		public MethodBuilder([MappedMember("body")] Nemerle.Compiler.MethodBuilder body)
		{
			this.body = body;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				body?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class PropertyBuilder : SyntaxElement
	{
		public readonly Nemerle.Compiler.PropertyBuilder body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 10;
		}

		[RecordCtor]
		public PropertyBuilder([MappedMember("body")] Nemerle.Compiler.PropertyBuilder body)
		{
			this.body = body;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				body?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class EventBuilder : SyntaxElement
	{
		public readonly Nemerle.Compiler.EventBuilder body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 11;
		}

		[RecordCtor]
		public EventBuilder([MappedMember("body")] Nemerle.Compiler.EventBuilder body)
		{
			this.body = body;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				body?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class ParameterBuilder : SyntaxElement
	{
		public readonly TParameter body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 12;
		}

		[RecordCtor]
		public ParameterBuilder([MappedMember("body")] TParameter body)
		{
			this.body = body;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				body?.RelocateImplInternal(_info);
			}
		}
	}

	public Location Location
	{
		get
		{
			Located body;
			Location result;
			MemberBuilder body2;
			switch (_N_GetVariantCodeSafe(this))
			{
			default:
				throw new MatchFailureException();
			case 0:
				if ((object)((Expression)this).body == null)
				{
					goto IL_0294;
				}
				body = ((Expression)this).body;
				goto IL_02aa;
			case 1:
			{
				if ((object)((MatchCase)this).body == null)
				{
					goto IL_0294;
				}
				Nemerle.Compiler.Parsetree.MatchCase body5 = ((MatchCase)this).body;
				result = body5.Location;
				break;
			}
			case 2:
			{
				if ((object)((Function)this).body == null)
				{
					goto IL_0294;
				}
				Function_decl body3 = ((Function)this).body;
				result = body3.Location;
				break;
			}
			case 3:
				if ((object)((Parameter)this).body == null)
				{
					goto IL_0294;
				}
				body = ((Parameter)this).body;
				goto IL_02aa;
			case 4:
				if ((object)((TType)this).body == null)
				{
					goto IL_0294;
				}
				body = ((TType)this).body;
				goto IL_02aa;
			case 5:
			{
				if ((object)((RawToken)this).body == null)
				{
					goto IL_0294;
				}
				Token body6 = ((RawToken)this).body;
				result = body6.Location;
				break;
			}
			case 6:
				if ((object)((ClassMember)this).body == null)
				{
					goto IL_0294;
				}
				body = ((ClassMember)this).body;
				goto IL_02aa;
			case 7:
			{
				if ((object)((TypeBuilder)this).body == null)
				{
					goto IL_0294;
				}
				Nemerle.Compiler.TypeBuilder body4 = ((TypeBuilder)this).body;
				result = body4.Location;
				break;
			}
			case 8:
				if ((object)((FieldBuilder)this).body == null)
				{
					goto IL_0294;
				}
				body2 = ((FieldBuilder)this).body;
				goto IL_0272;
			case 9:
				if ((object)((MethodBuilder)this).body == null)
				{
					goto IL_0294;
				}
				body2 = ((MethodBuilder)this).body;
				goto IL_0272;
			case 10:
				if ((object)((PropertyBuilder)this).body == null)
				{
					goto IL_0294;
				}
				body2 = ((PropertyBuilder)this).body;
				goto IL_0272;
			case 11:
				if ((object)((EventBuilder)this).body == null)
				{
					goto IL_0294;
				}
				body2 = ((EventBuilder)this).body;
				goto IL_0272;
			case 12:
				{
					if ((object)((ParameterBuilder)this).body == null)
					{
						goto IL_0294;
					}
					body = ((ParameterBuilder)this).body;
					goto IL_02aa;
				}
				IL_0294:
				result = Location.Default;
				break;
				IL_0272:
				result = body2.Location;
				break;
				IL_02aa:
				result = body.Location;
				break;
			}
			return result;
		}
	}

	public override string ToString()
	{
		object result;
		switch (_N_GetVariantCodeSafe(this))
		{
		default:
			throw new MatchFailureException();
		case 0:
		{
			if ((object)((Expression)this).body == null)
			{
				result = "";
				break;
			}
			PExpr body2 = ((Expression)this).body;
			result = body2.ToString();
			break;
		}
		case 1:
			result = "match case";
			break;
		case 2:
			result = "function";
			break;
		case 3:
			result = "parameter";
			break;
		case 4:
		{
			PExpr body2 = ((TType)this).body;
			result = "ttype: " + body2.ToString();
			break;
		}
		case 5:
		{
			Token body = ((RawToken)this).body;
			result = body.ToString();
			break;
		}
		case 6:
			result = "ClassMember";
			break;
		case 7:
			result = "TypeBuilder";
			break;
		case 8:
			result = "FieldBuilder";
			break;
		case 9:
			result = "MethodBuilder";
			break;
		case 10:
			result = "PropertyBuilder";
			break;
		case 11:
			result = "EventBuilder";
			break;
		case 12:
			result = "ParameterBuilder";
			break;
		}
		return (string)result;
	}

	[SpecialName]
	public abstract override int _N_GetVariantCode();

	[SpecialName]
	public static int _N_GetVariantCodeSafe(SyntaxElement x)
	{
		return ((object)x != null) ? x._N_GetVariantCode() : (-1);
	}

	[SpecialName]
	public static int _N_GetVariantCodeObject(object x)
	{
		return (!(x is SyntaxElement)) ? (-1) : ((SyntaxElement)x)._N_GetVariantCode();
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
