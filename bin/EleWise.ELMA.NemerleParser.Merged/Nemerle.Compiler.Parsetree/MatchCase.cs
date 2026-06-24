using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler.Parsetree;

public class MatchCase : ParsedBase
{
	private sealed class _N_closureOf_get_Location_44043
	{
		internal Location _N_loc_44048;

		internal _N_closureOf_get_Location_44043()
		{
		}
	}

	private sealed class _N__N_lambda__44036__44050 : FunctionVoid<PExpr>
	{
		[SpecialName]
		private _N_closureOf_get_Location_44043 _N_get_Location_closure_44054;

		public _N__N_lambda__44036__44050(_N_closureOf_get_Location_44043 _N_get_Location_closure_44054)
		{
			this._N_get_Location_closure_44054 = _N_get_Location_closure_44054;
		}

		[SpecialName]
		public sealed override void apply_void(PExpr p)
		{
			_N_get_Location_closure_44054._N_loc_44048 = _N_get_Location_closure_44054._N_loc_44048.Combine(p.Location);
		}
	}

	public readonly list<PExpr> patterns;

	public readonly PExpr body;

	public bool disable_warnings;

	[IgnoreField]
	private Location _patternsLocation;

	[IgnoreField]
	private Location _arrowLocation;

	public Location BodyLocation => body.Location;

	public override Location Location
	{
		get
		{
			_N_closureOf_get_Location_44043 n_closureOf_get_Location_ = new _N_closureOf_get_Location_44043();
			n_closureOf_get_Location_._N_loc_44048 = body.Location;
			list<PExpr> list = patterns;
			FunctionVoid<PExpr> f = new _N__N_lambda__44036__44050(n_closureOf_get_Location_);
			list.Iter(f);
			return n_closureOf_get_Location_._N_loc_44048;
		}
	}

	public Location PatternsLocation
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _patternsLocation;
		}
	}

	public Location ArrowLocation
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return _arrowLocation;
		}
	}

	public MatchCase(list<PExpr> patterns, PExpr body)
		: this(patterns, body, disable_warnings: false)
	{
	}

	public MatchCase(list<PExpr> patterns, PExpr body, Location patternsLocation, Location arrowLocation)
		: this(patterns, body, disable_warnings: false)
	{
		_patternsLocation = patternsLocation;
		_arrowLocation = arrowLocation;
	}

	public override string ToString()
	{
		return "| " + Convert.ToString(patterns.ToString(" | ")) + " => " + Convert.ToString(body);
	}

	[RecordCtor]
	public MatchCase([MappedMember("patterns")] list<PExpr> patterns, [MappedMember("body")] PExpr body, [MappedMember("disable_warnings")] bool disable_warnings)
	{
		this.patterns = patterns;
		this.body = body;
		this.disable_warnings = disable_warnings;
	}

	[RecordCtor]
	public MatchCase(Location loc, [MappedMember("patterns")] list<PExpr> patterns, [MappedMember("body")] PExpr body, [MappedMember("disable_warnings")] bool disable_warnings)
		: base(loc)
	{
		this.patterns = patterns;
		this.body = body;
		this.disable_warnings = disable_warnings;
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
		_arrowLocation = Completion.Relocate(_arrowLocation, _info);
		_patternsLocation = Completion.Relocate(_patternsLocation, _info);
		body?.RelocateImplInternal(_info);
		list<PExpr> list = patterns;
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
	}
}
