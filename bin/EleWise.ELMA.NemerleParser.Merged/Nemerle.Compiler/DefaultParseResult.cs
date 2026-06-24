using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Nemerle.Builtins;
using Nemerle.Compiler.Parsetree;
using Nemerle.Core;
using Nemerle.Internal;

namespace Nemerle.Compiler;

public sealed class DefaultParseResult : ParseResult
{
	private readonly LexerBase lexer;

	public override List<Tuple<Location, string, bool>> CommentLocations
	{
		get
		{
			LexerBase lexerBase = lexer;
			return (!(lexerBase is LexerString)) ? new List<Tuple<Location, string, bool>>() : ((LexerString)lexerBase).CommentLocations;
		}
	}

	public override Location Location => lexer.Location;

	public override list<Region> Regions => lexer.Regions;

	public override int[] LinesLengths => lexer.LinesLengths;

	[RecordCtor]
	public DefaultParseResult([MappedMember("TopDeclarations")] list<TopDeclaration> topDeclarations, [MappedMember("lexer")] LexerBase lexer)
		: base(topDeclarations)
	{
		this.lexer = lexer;
	}

	[CompilerGenerated]
	internal override void RelocateImplInternal(RelocationInfo _info)
	{
		if (!_info.VisitedObjects.ContainsKey(this))
		{
			base.RelocateImplInternal(_info);
			_info.VisitedObjects[this] = 0;
			lexer?.RelocateImplInternal(_info);
		}
	}
}
