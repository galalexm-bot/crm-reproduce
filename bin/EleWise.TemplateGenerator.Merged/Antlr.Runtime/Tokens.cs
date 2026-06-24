namespace Antlr.Runtime;

public static class Tokens
{
	public static readonly IToken EndOfFile = Tokens<CommonToken>.EndOfFile;

	public static readonly IToken Invalid = new CommonToken(0);

	public static readonly IToken Skip = new CommonToken(0);
}
public static class Tokens<T> where T : IToken, new()
{
	public static readonly T EndOfFile = new T
	{
		Type = -1
	};

	public static readonly T Invalid = new T
	{
		Type = 0
	};

	public static readonly T Skip = new T
	{
		Type = 0
	};
}
