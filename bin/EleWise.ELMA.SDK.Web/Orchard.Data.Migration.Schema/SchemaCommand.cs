using System.Collections.Generic;

namespace Orchard.Data.Migration.Schema;

public abstract class SchemaCommand : ISchemaBuilderCommand
{
	public string Name { get; private set; }

	public List<TableCommand> TableCommands { get; private set; }

	public SchemaCommandType Type { get; private set; }

	protected SchemaCommand(string name, SchemaCommandType type)
	{
		TableCommands = new List<TableCommand>();
		Type = type;
		WithName(name);
	}

	public SchemaCommand WithName(string name)
	{
		Name = name;
		return this;
	}
}
