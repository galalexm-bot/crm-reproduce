using System;

namespace EleWise.ELMA.Runtime.Db.Migrator.Framework;

[Flags]
public enum ColumnProperty
{
	None = 0,
	Null = 1,
	NotNull = 2,
	Identity = 4,
	Unique = 8,
	Unsigned = 0x10,
	ForeignKey = 0x20,
	PrimaryKey = 0x42,
	PrimaryKeyWithIdentity = 0x46
}
