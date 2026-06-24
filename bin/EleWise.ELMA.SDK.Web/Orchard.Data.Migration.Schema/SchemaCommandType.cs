namespace Orchard.Data.Migration.Schema;

public enum SchemaCommandType
{
	CreateTable,
	DropTable,
	AlterTable,
	SqlStatement,
	CreateForeignKey,
	DropForeignKey
}
