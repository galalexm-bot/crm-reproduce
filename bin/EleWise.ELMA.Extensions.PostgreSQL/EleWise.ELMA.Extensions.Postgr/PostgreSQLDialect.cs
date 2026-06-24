using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;

namespace EleWise.ELMA.Extensions.PostgreSQL;

public class PostgreSQLDialect : Dialect
{
	public override int MaxTableNameLength => 29;

	public override string CurrentTimestamp => "CURRENT_TIMESTAMP";

	public override string CurrentUtcTimestamp => "CURRENT_TIMESTAMP";

	public PostgreSQLDialect(List<string> reservedWords)
		: base(reservedWords)
	{
		RegisterColumnType(DbType.AnsiStringFixedLength, "CHAR(255)");
		RegisterColumnType(DbType.AnsiStringFixedLength, 1024, "CHAR($l)");
		RegisterColumnType(DbType.AnsiString, "VARCHAR(255)");
		RegisterColumnType(DbType.AnsiString, 1024, "VARCHAR($l)");
		RegisterColumnType(DbType.AnsiString, int.MaxValue, "TEXT");
		RegisterColumnType(DbType.Binary, "BYTEA");
		RegisterColumnType(DbType.Binary, int.MaxValue, "BYTEA");
		RegisterColumnType(DbType.Boolean, "SMALLINT");
		RegisterColumnType(DbType.Byte, "SMALLINT");
		RegisterColumnType(DbType.Currency, "MONEY");
		RegisterColumnType(DbType.Date, "DATE");
		RegisterColumnType(DbType.DateTime, "TIMESTAMP(4)");
		RegisterColumnType(DbType.Decimal, "DECIMAL");
		RegisterColumnType(DbType.Decimal, 38, "DECIMAL($l, $s)", 2);
		RegisterColumnType(DbType.Double, "DOUBLE PRECISION");
		RegisterColumnType(DbType.Guid, "UUID");
		RegisterColumnType(DbType.Int16, "SMALLINT");
		RegisterColumnType(DbType.Int32, "INTEGER");
		RegisterColumnType(DbType.Int64, "BIGINT");
		RegisterColumnType(DbType.Single, "REAL");
		RegisterColumnType(DbType.StringFixedLength, "VARCHAR(255)");
		RegisterColumnType(DbType.StringFixedLength, 512, "VARCHAR($l)");
		RegisterColumnType(DbType.String, "VARCHAR(255)");
		RegisterColumnType(DbType.String, 512, "VARCHAR($l)");
		RegisterColumnType(DbType.String, int.MaxValue, "TEXT");
		RegisterColumnType(DbType.Xml, "XML");
		RegisterColumnType(DbType.Time, "TIMESTAMP(4)");
		RegisterProperty(ColumnProperty.Identity, "IDENTITY");
		AddReservedWord("Start");
	}

	public override string Default(object defaultValue)
	{
		if (defaultValue is bool)
		{
			defaultValue = (((bool)defaultValue) ? 1 : 0);
		}
		return base.Default(defaultValue);
	}

	public override string DateToSql(DateTime date)
	{
		DateTime dateTime = date.ToServerDateTime();
		return $"cast(to_timestamp('{dateTime.Day}-{dateTime.Month}-{dateTime.Year}', 'DD-MM-YYYY') as timestamp(4) without time zone)";
	}

	public override string DateTimeToSql(DateTime date)
	{
		DateTime dateTime = date.ToServerDateTime();
		return $"cast(to_timestamp('{dateTime.Day}-{dateTime.Month}-{dateTime.Year} {dateTime.Hour}:{dateTime.Minute}:{dateTime.Second}', 'DD-MM-YYYY hh24:mi:ss') as timestamp(4) without time zone)";
	}

	public override string StrToIntFromSql(string parametrName)
	{
		return $"cast ({parametrName} as int)";
	}

	public override string GuidToCharFromSql(string parametrName)
	{
		return GuidToCharFromSqlWithoutQuote(QuoteIfNeeded(parametrName));
	}

	public override string GuidToCharFromSqlWithoutQuote(string parametrName)
	{
		return $"GUID_TO_CHAR_SQL({parametrName})";
	}

	public override string CharToGuidFromSql(string parametrName)
	{
		return CharToGuidFromSqlWithoutQuote(QuoteIfNeeded(parametrName));
	}

	protected override void BuildColumnSql(List<string> vals, Column column, bool compoundPrimaryKey)
	{
		AddColumnName(vals, column);
		AddColumnType(vals, column);
		AddDefaultValueSql(vals, column);
		AddNotNullSql(vals, column);
		AddPrimaryKeySql(vals, column, compoundPrimaryKey);
		AddUniqueSql(vals, column);
	}

	public override string AddSecond(string arg, string second)
	{
		return $"{arg}+{second}*interval '1 seconds'";
	}

	public override string ConcatenateSymbol()
	{
		return "||";
	}

	public override string IsNull(string checkExpression, string replacementValue)
	{
		return $"COALESCE({checkExpression}, {replacementValue})";
	}

	public override string QuoteSymbol()
	{
		return "'";
	}

	public override string QuoteString(string text)
	{
		return string.Format("{1}{0}{1}", text, QuoteSymbol());
	}

	public override string GetIsNullFunctionName()
	{
		return "COALESCE";
	}

	public override string GetParamName(string queryPart)
	{
		int num = queryPart.IndexOf("::", StringComparison.Ordinal);
		if (num <= -1)
		{
			return queryPart.Substring(1);
		}
		return queryPart.Substring(1, num - 1);
	}

	public override string GenUid()
	{
		return "uuid_generate_v4()";
	}

	public override string Concat(params string[] items)
	{
		return string.Join($" {ConcatenateSymbol()} ", items);
	}

	public override string CastToString(string columnName)
	{
		return $"cast({columnName} as text)";
	}

	public override string List(string columNameForConnect, string inColumNameForConnect, string outAlias, string inAlias, string tableName, string where)
	{
		return $"string_agg(distinct {outAlias}.{columNameForConnect} , ', ')";
	}

	public override string CharToGuidFromSqlWithoutQuote(string parametrName)
	{
		return $"CHAR_TO_GUID_SQL({parametrName})";
	}

	public override string ConvertToInt64(string parameter)
	{
		return $"CAST({parameter} AS bigint)";
	}

	public override string Length(string columnName)
	{
		return $"LENGTH({columnName})";
	}

	public override string Substring(string val, int start, int? length = null)
	{
		return string.Format("SUBSTRING({0} FROM {1}{2})", val, start, length.HasValue ? $" FOR {length.Value}" : "");
	}

	public override string BinOr(string value1, string value2)
	{
		return $"({value1} | {value2})";
	}

	public override string InsertIf(string expression, string trueValue, string falseValue)
	{
		return $"CASE WHEN {expression} THEN {trueValue} ELSE {falseValue} END";
	}
}
