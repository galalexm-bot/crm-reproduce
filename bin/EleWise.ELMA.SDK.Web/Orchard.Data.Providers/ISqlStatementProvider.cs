namespace Orchard.Data.Providers;

public interface ISqlStatementProvider : ISingletonDependency, IDependency
{
	string DataProvider { get; }

	string GetStatement(string command);
}
