using Orchard.Data.Migration.Schema;

namespace Orchard.Data.Migration.Interpreters;

public interface ICommandInterpreter<in T> : ICommandInterpreter, IDependency where T : ISchemaBuilderCommand
{
	string[] CreateStatements(T command);
}
public interface ICommandInterpreter : IDependency
{
	string DataProvider { get; }
}
