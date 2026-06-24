namespace EleWise.ELMA.Runtime.Db.Migrator.Framework;

public interface IColumn
{
	ColumnProperty ColumnProperty { get; set; }

	string Name { get; set; }

	ColumnType ColumnType { get; }

	bool IsIdentity { get; }

	bool IsPrimaryKey { get; }

	object DefaultValue { get; set; }

	void SetColumnType(ColumnType type);
}
