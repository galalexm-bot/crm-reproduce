using System.Diagnostics;
using System.Runtime.CompilerServices;
using Nemerle.Internal;

namespace Nemerle.Compiler;

public sealed class DefaultParser : IParser, ISupportRelocation
{
	private readonly ManagerClass manager;

	public ManagerClass Manager
	{
		[DebuggerStepThrough]
		[CompilerGenerated]
		get
		{
			return manager;
		}
	}

	public ParseResult Parse(ISource source)
	{
		LexerFile lexerFile = new LexerFile(manager, source.FileIndex, source.GetText(), manager.Options.LexerStoreComments);
		if (manager.Options.IndentationSyntax)
		{
			lexerFile.SwitchToIndentationMode();
		}
		return new DefaultParseResult(MainParser.Parse(lexerFile), lexerFile);
	}

	[RecordCtor]
	public DefaultParser([MappedMember("manager")] ManagerClass manager)
	{
		this.manager = manager;
	}

	[CompilerGenerated]
	internal void RelocateImplInternal(RelocationInfo _info)
	{
	}

	void ISupportRelocation.RelocateImpl(RelocationInfo _info)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RelocateImplInternal
		this.RelocateImplInternal(_info);
	}
}
