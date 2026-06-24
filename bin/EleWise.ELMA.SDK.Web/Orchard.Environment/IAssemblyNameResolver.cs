namespace Orchard.Environment;

public interface IAssemblyNameResolver
{
	int Order { get; }

	string Resolve(string shortName);
}
