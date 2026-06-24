using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Compiler.Parsetree;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler;

public class ParseResult : ISupportRelocation
{
	public list<TopDeclaration> TopDeclarations { get; }

	public override List<Tuple<Location, string, bool>> CommentLocations => new List<Tuple<Location, string, bool>>();

	public override Location Location => Location.Default;

	public override list<Region> Regions => list<Region>.Nil._N_constant_object;

	public override int[] LinesLengths => new int[0];

	[RecordCtor]
	public ParseResult([MappedMember("TopDeclarations")] list<TopDeclaration> topDeclarations)
	{
		_N_TopDeclarations_7219 = topDeclarations;
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
