using System.Runtime.CompilerServices;
using Nemerle.Compiler.Typedtree;
using Nemerle.Internal;

namespace Nemerle.Compiler.Parsetree;

[Variant("Nemerle.Compiler.Parsetree.TryCase.Catch,Nemerle.Compiler.Parsetree.TryCase.Filter,Nemerle.Compiler.Parsetree.TryCase.Ellipsis")]
public abstract class TryCase : ParsedBase
{
	[VariantOption]
	public class Catch : TryCase
	{
		public readonly Splicable exn;

		public readonly PExpr exn_ty;

		public readonly PExpr handler;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 0;
		}

		[RecordCtor]
		public Catch([MappedMember("exn")] Splicable exn, [MappedMember("exn_ty")] PExpr exn_ty, [MappedMember("handler")] PExpr handler)
		{
			this.exn = exn;
			this.exn_ty = exn_ty;
			this.handler = handler;
		}

		[RecordCtor]
		public Catch(Location loc, [MappedMember("exn")] Splicable exn, [MappedMember("exn_ty")] PExpr exn_ty, [MappedMember("handler")] PExpr handler)
			: base(loc)
		{
			this.exn = exn;
			this.exn_ty = exn_ty;
			this.handler = handler;
		}

		[CompilerGenerated]
		internal override void RelocateImplInternal(RelocationInfo _info)
		{
			if (!_info.VisitedObjects.ContainsKey(this))
			{
				base.RelocateImplInternal(_info);
				_info.VisitedObjects[this] = 0;
				handler?.RelocateImplInternal(_info);
				exn_ty?.RelocateImplInternal(_info);
				exn?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class Filter : TryCase
	{
		public readonly Splicable exn;

		public readonly PExpr exn_ty;

		public readonly PExpr filter;

		public readonly PExpr handler;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 1;
		}

		[RecordCtor]
		public Filter([MappedMember("exn")] Splicable exn, [MappedMember("exn_ty")] PExpr exn_ty, [MappedMember("filter")] PExpr filter, [MappedMember("handler")] PExpr handler)
		{
			this.exn = exn;
			this.exn_ty = exn_ty;
			this.filter = filter;
			this.handler = handler;
		}

		[RecordCtor]
		public Filter(Location loc, [MappedMember("exn")] Splicable exn, [MappedMember("exn_ty")] PExpr exn_ty, [MappedMember("filter")] PExpr filter, [MappedMember("handler")] PExpr handler)
			: base(loc)
		{
			this.exn = exn;
			this.exn_ty = exn_ty;
			this.filter = filter;
			this.handler = handler;
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
				exn_ty?.RelocateImplInternal(_info);
				exn?.RelocateImplInternal(_info);
			}
		}
	}

	[VariantOption]
	public class Ellipsis : TryCase
	{
		public readonly PExpr body;

		[SpecialName]
		public override int _N_GetVariantCode()
		{
			return 2;
		}

		[RecordCtor]
		public Ellipsis([MappedMember("body")] PExpr body)
		{
			this.body = body;
		}

		[RecordCtor]
		public Ellipsis(Location loc, [MappedMember("body")] PExpr body)
			: base(loc)
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

	public new Try_case TypedObject => (Try_case)base.TypedObject;

	[SpecialName]
	public abstract override int _N_GetVariantCode();

	[SpecialName]
	public static int _N_GetVariantCodeSafe(TryCase x)
	{
		return ((object)x != null) ? x._N_GetVariantCode() : (-1);
	}

	[SpecialName]
	public static int _N_GetVariantCodeObject(object x)
	{
		return (!(x is TryCase)) ? (-1) : ((TryCase)x)._N_GetVariantCode();
	}

	[RecordCtor]
	protected TryCase()
	{
	}

	[RecordCtor]
	protected TryCase(Location loc)
		: base(loc)
	{
	}
}
