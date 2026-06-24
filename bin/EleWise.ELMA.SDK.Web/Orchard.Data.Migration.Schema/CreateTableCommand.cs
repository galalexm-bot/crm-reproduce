using System;
using System.Data;

namespace Orchard.Data.Migration.Schema;

public class CreateTableCommand : SchemaCommand
{
	public CreateTableCommand(string name)
		: base(name, SchemaCommandType.CreateTable)
	{
	}

	public CreateTableCommand Column(string columnName, DbType dbType, Action<CreateColumnCommand> column = null)
	{
		CreateColumnCommand createColumnCommand = new CreateColumnCommand(base.Name, columnName);
		createColumnCommand.WithType(dbType);
		column?.Invoke(createColumnCommand);
		base.TableCommands.Add(createColumnCommand);
		return this;
	}

	public CreateTableCommand Column<T>(string columnName, Action<CreateColumnCommand> column = null)
	{
		DbType dbType = SchemaUtils.ToDbType(typeof(T));
		return Column(columnName, dbType, column);
	}

	public CreateTableCommand ContentPartRecord()
	{
		Column<int>("Id", delegate(CreateColumnCommand column)
		{
			column.PrimaryKey().NotNull();
		});
		return this;
	}

	public CreateTableCommand ContentPartVersionRecord()
	{
		Column<int>("Id", delegate(CreateColumnCommand column)
		{
			column.PrimaryKey().NotNull();
		});
		Column<int>("ContentItemRecord_id");
		return this;
	}
}
