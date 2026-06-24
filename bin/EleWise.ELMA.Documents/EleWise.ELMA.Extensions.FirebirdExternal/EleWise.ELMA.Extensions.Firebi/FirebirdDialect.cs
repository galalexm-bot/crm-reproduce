using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;

namespace EleWise.ELMA.Extensions.FirebirdExternal;

public class FirebirdDialect : Dialect
{
	public override string CurrentTimestamp
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override string CurrentUtcTimestamp
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override int MaxTableNameLength
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public FirebirdDialect(List<string> reservedWords)
		: base(reservedWords)
	{
		AddReservedWord("Start");
	}

	public override string AddSecond(string arg, string second)
	{
		throw new NotImplementedException();
	}

	public override string BinOr(string value1, string value2)
	{
		throw new NotImplementedException();
	}

	public override string CastToString(string columnName)
	{
		throw new NotImplementedException();
	}

	public override string CharToGuidFromSql(string parametrName)
	{
		throw new NotImplementedException();
	}

	public override string CharToGuidFromSqlWithoutQuote(string parametrName)
	{
		throw new NotImplementedException();
	}

	public override string Concat(params string[] items)
	{
		throw new NotImplementedException();
	}

	public override string ConcatenateSymbol()
	{
		throw new NotImplementedException();
	}

	public override string ConvertToInt64(string parameter)
	{
		throw new NotImplementedException();
	}

	public override string DateTimeToSql(DateTime date)
	{
		throw new NotImplementedException();
	}

	public override string DateToSql(DateTime date)
	{
		throw new NotImplementedException();
	}

	public override string GenUid()
	{
		throw new NotImplementedException();
	}

	public override string GetIsNullFunctionName()
	{
		throw new NotImplementedException();
	}

	public override string GuidToCharFromSql(string parametrName)
	{
		throw new NotImplementedException();
	}

	public override string GuidToCharFromSqlWithoutQuote(string parametrName)
	{
		throw new NotImplementedException();
	}

	public override string IsNull(string checkExpression, string replacementValue)
	{
		throw new NotImplementedException();
	}

	public override string List(string columNameForConnect, string inColumNameForConnect, string outAlias, string inAlias, string tableName, string where)
	{
		throw new NotImplementedException();
	}

	public override string QuoteString(string text)
	{
		return QuoteSymbol() + text.Replace(QuoteSymbol(), QuoteSymbol() + QuoteSymbol()) + QuoteSymbol();
	}

	public override string QuoteSymbol()
	{
		return "'";
	}

	public override string StrToIntFromSql(string parametrName)
	{
		throw new NotImplementedException();
	}

	public override string Substring(string val, int start, int? length = null)
	{
		throw new NotImplementedException();
	}

	public override bool TypeIsRegistred(DbType type)
	{
		throw new NotImplementedException();
	}

	public override string SqlForProperty(ColumnProperty property)
	{
		throw new NotImplementedException();
	}

	public override string Default(object defaultValue)
	{
		throw new NotImplementedException();
	}

	protected override void BuildColumnSql(List<string> vals, Column column, bool compoundPrimaryKey)
	{
	}
}
