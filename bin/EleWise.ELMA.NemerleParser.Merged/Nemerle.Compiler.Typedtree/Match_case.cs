using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler.Typedtree;

public class Match_case : TypedBase
{
	public list<Tuple<Pattern, TExpr, list<Tuple<LocalValue, TExpr>>>> patterns;

	public TExpr body;

	public bool disable_warnings;

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

	[RecordCtor]
	public Match_case([MappedMember("patterns")] list<Tuple<Pattern, TExpr, list<Tuple<LocalValue, TExpr>>>> patterns, [MappedMember("body")] TExpr body, [MappedMember("disable_warnings")] bool disable_warnings)
	{
		this.patterns = patterns;
		this.body = body;
		this.disable_warnings = disable_warnings;
	}

	[RecordCtor]
	public Match_case(Location loc, [MappedMember("patterns")] list<Tuple<Pattern, TExpr, list<Tuple<LocalValue, TExpr>>>> patterns, [MappedMember("body")] TExpr body, [MappedMember("disable_warnings")] bool disable_warnings)
		: base(loc)
	{
		this.patterns = patterns;
		this.body = body;
		this.disable_warnings = disable_warnings;
	}
}
