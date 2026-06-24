namespace EleWise.ELMA.Runtime.Db.Migrator.Framework;

public enum ForeignKeyConstraint
{
	Cascade,
	SetNull,
	NoAction,
	Restrict,
	SetDefault
}
