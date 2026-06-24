namespace Nemerle.Compiler;

public interface IParser
{
	ParseResult Parse(ISource source);
}
