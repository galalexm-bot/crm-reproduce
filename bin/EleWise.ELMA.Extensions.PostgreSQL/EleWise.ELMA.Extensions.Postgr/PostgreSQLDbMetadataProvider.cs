using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;

namespace EleWise.ELMA.Extensions.PostgreSQL;

internal class PostgreSQLDbMetadataProvider : AbstractDbMetadataProvider
{
	protected override string ForeignKeysScript => string.Format("\r\nSELECT  {5}.conname AS {0},\r\n        {6}.relname AS {1},\r\n        {8}.attname AS {2},\r\n        {7}.relname AS {3},\r\n        {9}.attname AS {4}\r\nFROM    pg_catalog.pg_constraint AS {5},\r\n        pg_catalog.pg_class AS {6},\r\n        pg_catalog.pg_class AS {7},\r\n        pg_catalog.pg_attribute AS {8},\r\n        pg_catalog.pg_attribute AS {9},\r\n        pg_catalog.pg_namespace AS {10},\r\n        pg_catalog.pg_namespace AS {11}\r\nWHERE   {5}.conrelid = {6}.oid\r\nAND     {5}.confrelid = {7}.oid\r\nAND     {5}.contype = 'f'\r\nAND     {8}.attrelid = {6}.oid\r\nAND     {8}.attnum = ANY({5}.conkey)\r\nAND     {9}.attrelid = {7}.oid\r\nAND     {9}.attnum = ANY({5}.confkey)\r\nAND     {6}.relkind = 'r'\r\nAND     {7}.relkind = 'r'\r\nAND     {10}.oid = {6}.relnamespace\r\nAND     {11}.oid = {7}.relnamespace\r\nAND     {10}.nspname NOT IN ('pg_catalog', 'pg_toast')\r\nAND     {11}.nspname NOT IN ('pg_catalog', 'pg_toast')\r\nAND     pg_catalog.pg_table_is_visible({6}.oid)\r\nAND     pg_catalog.pg_table_is_visible({7}.oid)\r\n", Quote("ForeignKeyName"), Quote("ParentTableName"), Quote("ParentColumnName"), Quote("ReferenceTableName"), Quote("ReferenceColumnName"), Quote("c"), Quote("t1"), Quote("t2"), Quote("a1"), Quote("a2"), Quote("n1"), Quote("n2"));

	protected override string PrimaryKeysScript => string.Format("\r\nSELECT  {3}.conname AS {0},\r\n        {4}.relname AS {1},\r\n        {5}.attname AS {2}\r\nFROM    pg_catalog.pg_constraint AS {3},\r\n        pg_catalog.pg_class AS {4},\r\n        pg_catalog.pg_attribute AS {5},\r\n        pg_catalog.pg_namespace AS {6}\r\nWHERE   {3}.conrelid = {4}.oid\r\nAND     {3}.contype = 'p'\r\nAND     {5}.attrelid = {4}.oid\r\nAND     {5}.attnum = ANY({3}.conkey)\r\nAND     {4}.relkind = 'r'\r\nAND     {6}.oid = {4}.relnamespace\r\nAND     {6}.nspname NOT IN ('pg_catalog', 'pg_toast')\r\nAND     pg_catalog.pg_table_is_visible({4}.oid)\r\n", Quote("IndexName"), Quote("TableName"), Quote("ColumnName"), Quote("c"), Quote("t1"), Quote("a1"), Quote("n1"));

	protected override string IndexesScript => string.Format("\r\nSELECT  {3}.relname AS {0},\r\n        {5}.relname AS {1},\r\n        {6}.attname AS {2}\r\nFROM    pg_class AS {5},\r\n        pg_class AS {3},\r\n        pg_index AS {4},\r\n        pg_attribute AS {6},\r\n        pg_namespace AS {7}\r\nWHERE   {5}.oid = {4}.indrelid\r\n        AND {3}.oid = {4}.indexrelid\r\n        AND {4}.indisprimary = 'f'\r\n        AND {6}.attrelid = {5}.oid\r\n        AND {6}.attnum = ANY({4}.indkey)\r\n        AND {5}.relkind = 'r'\r\n        AND {5}.relnamespace = {7}.oid\r\n        AND {7}.nspname NOT IN ('pg_catalog', 'pg_toast')\r\n", Quote("IndexName"), Quote("TableName"), Quote("ColumnName"), Quote("i"), Quote("ix"), Quote("t"), Quote("a"), Quote("ns"));

	public PostgreSQLDbMetadataProvider(ITransformationProvider transform)
		: base(transform)
	{
	}

	protected override string ConvertToRegularDbIdentifier(string name)
	{
		return name.ToLower();
	}
}
