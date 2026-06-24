using System.Runtime.CompilerServices;
using Nemerle.Internal;

namespace Nemerle.Compiler.Typedtree;

[Variant("Nemerle.Compiler.Typedtree.Try_case.Fault,Nemerle.Compiler.Typedtree.Try_case.Catch,Nemerle.Compiler.Typedtree.Try_case.Filter")]
public abstract class Try_case : TypedBase
{
	[VariantOption]
	public class Fault : Try_case
	{
		public readonly TExpr handler;

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
				handler?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public Fault([MappedMember("handler")] TExpr handler)
		{
			this.handler = handler;
		}

		[RecordCtor]
		public Fault(Location loc, [MappedMember("handler")] TExpr handler)
			: base(loc)
		{
			this.handler = handler;
		}
	}

	[VariantOption]
	public class Catch : Try_case
	{
		public readonly LocalValue exn;

		public readonly TExpr handler;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 1;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				handler?.RelocateImplInternal(_info);
				exn?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public Catch([MappedMember("exn")] LocalValue exn, [MappedMember("handler")] TExpr handler)
		{
			this.exn = exn;
			this.handler = handler;
		}

		[RecordCtor]
		public Catch(Location loc, [MappedMember("exn")] LocalValue exn, [MappedMember("handler")] TExpr handler)
			: base(loc)
		{
			this.exn = exn;
			this.handler = handler;
		}
	}

	[VariantOption]
	public class Filter : Try_case
	{
		public readonly LocalValue exn;

		public readonly TExpr filter;

		public readonly TExpr handler;

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
				handler?.RelocateImplInternal(_info);
				filter?.RelocateImplInternal(_info);
				exn?.RelocateImplInternal(_info);
			}
		}

		[RecordCtor]
		public Filter([MappedMember("exn")] LocalValue exn, [MappedMember("filter")] TExpr filter, [MappedMember("handler")] TExpr handler)
		{
			this.exn = exn;
			this.filter = filter;
			this.handler = handler;
		}

		[RecordCtor]
		public Filter(Location loc, [MappedMember("exn")] LocalValue exn, [MappedMember("filter")] TExpr filter, [MappedMember("handler")] TExpr handler)
			: base(loc)
		{
			this.exn = exn;
			this.filter = filter;
			this.handler = handler;
		}
	}

	[SpecialName]
	public abstract override int _N_GetVariantCode();

	[SpecialName]
	public static int _N_GetVariantCodeSafe(Try_case x)
	{
		return ((object)x != null) ? x._N_GetVariantCode() : (-1);
	}

	[SpecialName]
	public static int _N_GetVariantCodeObject(object x)
	{
		return (!(x is Try_case)) ? (-1) : ((Try_case)x)._N_GetVariantCode();
	}

	[RecordCtor]
	protected Try_case()
	{
	}

	[RecordCtor]
	protected Try_case(Location loc)
		: base(loc)
	{
	}
}
