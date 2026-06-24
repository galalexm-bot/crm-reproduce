using System;
using System.Data;

namespace Orchard.Data.Migration.Schema;

public class AlterTableCommand : SchemaCommand
{
	public AlterTableCommand(string name)
		: base(name, SchemaCommandType.AlterTable)
	{
	}

	public void AddColumn(string columnName, DbType dbType, Action<AddColumnCommand> column = null)
	{
		AddColumnCommand addColumnCommand = new AddColumnCommand(base.Name, columnName);
		addColumnCommand.WithType(dbType);
		column?.Invoke(addColumnCommand);
		base.TableCommands.Add(addColumnCommand);
	}

	public void AddColumn<T>(string columnName, Action<AddColumnCommand> column = null)
	{
		DbType dbType = SchemaUtils.ToDbType(typeof(T));
		AddColumn(columnName, dbType, column);
	}

	public void DropColumn(string columnName)
	{
		DropColumnCommand item = new DropColumnCommand(base.Name, columnName);
		base.TableCommands.Add(item);
	}

	public void AlterColumn(string columnName, Action<AlterColumnCommand> column = null)
	{
		AlterColumnCommand alterColumnCommand = new AlterColumnCommand(base.Name, columnName);
		column?.Invoke(alterColumnCommand);
		base.TableCommands.Add(alterColumnCommand);
	}

	public void CreateIndex(string indexName, params string[] columnNames)
	{
		AddIndexCommand item = new AddIndexCommand(base.Name, indexName, columnNames);
		base.TableCommands.Add(item);
	}

	public void DropIndex(string indexName)
	{
		DropIndexCommand item = new DropIndexCommand(base.Name, indexName);
		base.TableCommands.Add(item);
	}

	public void AddUniqueConstraint(string constraintName, params string[] columnNames)
	{
		AddUniqueConstraintCommand item = new AddUniqueConstraintCommand(base.Name, constraintName, columnNames);
		base.TableCommands.Add(item);
	}

	public void DropUniqueConstraint(string constraintName)
	{
		DropUniqueConstraintCommand item = new DropUniqueConstraintCommand(base.Name, constraintName);
		base.TableCommands.Add(item);
	}
}
