using System;
using Antlr.Runtime.Misc;

namespace Antlr.Runtime;

public class UnbufferedTokenStream : LookaheadStream<IToken>, ITokenStream, IIntStream
{
	[CLSCompliant(false)]
	protected ITokenSource tokenSource;

	protected int tokenIndex;

	protected int channel;

	public ITokenSource TokenSource => tokenSource;

	public string SourceName => TokenSource.SourceName;

	public UnbufferedTokenStream(ITokenSource tokenSource)
	{
		this.tokenSource = tokenSource;
	}

	public override IToken NextElement()
	{
		IToken token = tokenSource.NextToken();
		token.TokenIndex = tokenIndex++;
		return token;
	}

	public override bool IsEndOfFile(IToken o)
	{
		return o.Type == -1;
	}

	public IToken Get(int i)
	{
		throw new NotSupportedException("Absolute token indexes are meaningless in an unbuffered stream");
	}

	public int LA(int i)
	{
		return LT(i).Type;
	}

	public string ToString(int start, int stop)
	{
		return "n/a";
	}

	public string ToString(IToken start, IToken stop)
	{
		return "n/a";
	}
}
