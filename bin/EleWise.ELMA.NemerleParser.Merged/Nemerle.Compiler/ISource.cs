namespace Nemerle.Compiler;

public interface ISource
{
	int FileIndex { get; }

	string GetText();
}
