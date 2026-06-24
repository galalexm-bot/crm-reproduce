using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions.MSSQL;

public class MSSQLDialect : Dialect
{
	internal static MSSQLDialect hxbYhIMu1AeI9ONgrxE;

	public override int MaxTableNameLength => 29;

	public override DateTime MinDateTime => DateTime.FromOADate(0.0);

	public override bool SupportsIndex => false;

	public override string QuoteReservedWordsSymbolStart => (string)GOsG20M9tT7GM95KyOt(-868652467 ^ -868648435);

	public override string QuoteReservedWordsSymbolEnd => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6BA69CC5 ^ 0x6BA68C83);

	public override string CurrentTimestamp => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x510BFFD ^ 0x510AF9B);

	public override string CurrentUtcTimestamp => (string)GOsG20M9tT7GM95KyOt(0x6BA69CC5 ^ 0x6BA68C49);

	public MSSQLDialect(List<string> reservedWords)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.BPCyhsoin5();
		this._002Ector(reservedWords, string.Empty);
	}

	public MSSQLDialect(List<string> reservedWords, string schemaName)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.BPCyhsoin5();
		base._002Ector(reservedWords, schemaName);
		RegisterColumnType(DbType.AnsiStringFixedLength, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x510BFFD ^ 0x510B1F1));
		RegisterColumnType(DbType.AnsiStringFixedLength, 1024, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12FD2B1 ^ 0x12FDC93));
		RegisterColumnType(DbType.AnsiString, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1933751546 ^ -1933753040));
		RegisterColumnType(DbType.AnsiString, 1024, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7323CF8E ^ 0x7323C1DC));
		RegisterColumnType(DbType.AnsiString, int.MaxValue, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-169056146 ^ -169056766));
		RegisterColumnType(DbType.Binary, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x483FFC8B ^ 0x483FF203));
		RegisterColumnType(DbType.Binary, int.MaxValue, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-15819198 ^ -15822646));
		RegisterColumnType(DbType.Boolean, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3897EFFA ^ 0x3897E152));
		RegisterColumnType(DbType.Byte, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-147020345 ^ -147018891));
		RegisterColumnType(DbType.Currency, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x44957A45 ^ 0x44957481));
		RegisterColumnType(DbType.Date, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x77B5510C ^ 0x77B55FDE));
		RegisterColumnType(DbType.DateTime, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1918094472 ^ -1918091862));
		RegisterColumnType(DbType.Decimal, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-603134395 ^ -603133789));
		RegisterColumnType(DbType.Decimal, 38, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-261945208 ^ -261945744), 2);
		RegisterColumnType(DbType.Double, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1104925895 ^ -1104927709));
		RegisterColumnType(DbType.Guid, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x58D4045 ^ 0x58D4F7B));
		RegisterColumnType(DbType.Int16, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2115681549 ^ -2115678831));
		RegisterColumnType(DbType.Int32, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x77B5510C ^ 0x77B55E7A));
		RegisterColumnType(DbType.Int64, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-169056146 ^ -169056274));
		RegisterColumnType(DbType.Single, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x44957A45 ^ 0x449575D5));
		RegisterColumnType(DbType.StringFixedLength, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-370249262 ^ -370246066));
		RegisterColumnType(DbType.StringFixedLength, 512, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x58C3C0F3 ^ 0x58C3CF47));
		RegisterColumnType(DbType.String, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1239877681 ^ -1239877627));
		RegisterColumnType(DbType.String, 512, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1906803267 ^ 0x71A78DAB));
		RegisterColumnType(DbType.String, int.MaxValue, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-242527442 ^ -242531542));
		RegisterColumnType(DbType.Time, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2008939226 ^ -2008937484));
		RegisterColumnType(DbType.Xml, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x816BBA1 ^ 0x816AB83));
		RegisterProperty(ColumnProperty.Identity, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FD7E9B3 ^ 0x1FD7F99F));
	}

	public override string Default(object defaultValue)
	{
		//Discarded unreachable code: IL_0039, IL_009a, IL_00aa
		int num = 2;
		int num2 = num;
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 2:
				if (!(defaultValue is bool))
				{
					num2 = 1;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_636573f0701e4d3dad6ad17b85776458 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 5;
			default:
				return (string)UVvnvgMylwUuDDWELQT(GOsG20M9tT7GM95KyOt(-242527442 ^ -242531486), defaultValue);
			case 5:
				if ((bool)defaultValue)
				{
					num2 = 3;
					continue;
				}
				goto case 4;
			case 4:
				num3 = 0;
				break;
			case 3:
				num3 = 1;
				break;
			}
			defaultValue = num3;
			num2 = 0;
			if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_38564d6ade73482fadcc5aedb5edd1aa == 0)
			{
				num2 = 0;
			}
		}
	}

	public override string DateToSql(DateTime date)
	{
		int num = 1;
		int num2 = num;
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)BBVd22MOIEOkM9eTZqE(GOsG20M9tT7GM95KyOt(0x586FD9AE ^ 0x586FC91E), dateTime.Day, dateTime.Month, dateTime.Year);
			case 1:
				dateTime = O6h74PMneKKkVqA4c78(date);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_9f50fa62c83545aa885cad260f298366 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override string StrToIntFromSql(string parametrName)
	{
		return string.Format((string)GOsG20M9tT7GM95KyOt(-900013974 ^ -900009832), parametrName);
	}

	public override string DateTimeToSql(DateTime date)
	{
		int num = 1;
		int num2 = num;
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 1:
				dateTime = O6h74PMneKKkVqA4c78(date);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_0d93129ec5af4fc5926990956e624437 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)AFRAUyMAVdEsIsyiqNS(GOsG20M9tT7GM95KyOt(0x5E77F19D ^ 0x5E77E085), new object[6] { dateTime.Day, dateTime.Month, dateTime.Year, dateTime.Hour, dateTime.Minute, dateTime.Second });
			}
		}
	}

	public override string GuidToCharFromSql(string parametrName)
	{
		return (string)z06dBQMxPuL7scU0TnS(this, RZQnufMjoB0cbarRugL(this, parametrName));
	}

	public override string CharToGuidFromSql(string parametrName)
	{
		return (string)i3tDyaMQ4ZhEdBC62cc(this, RZQnufMjoB0cbarRugL(this, parametrName));
	}

	public override string AddSecond(string arg, string second)
	{
		return (string)VSDiD0MNWltl4Pw3meO(GOsG20M9tT7GM95KyOt(0x2219352 ^ 0x2218228), second, arg);
	}

	public override string ConcatenateSymbol()
	{
		return (string)GOsG20M9tT7GM95KyOt(0x55622768 ^ 0x556236C4);
	}

	public override string IsNull(string checkExpression, string replacementValue)
	{
		return string.Format((string)GOsG20M9tT7GM95KyOt(-1933751546 ^ -1933747532), checkExpression, replacementValue);
	}

	public override string QuoteSymbol()
	{
		return (string)GOsG20M9tT7GM95KyOt(-250283594 ^ -250288032);
	}

	public override string QuoteString(string text)
	{
		return (string)M8oFXLM6OtWsZXKgjCy(QuoteSymbol(), text.Replace((string)vIKsVcMLgYRcJNqK5nO(this), (string)L4RSxBMkAkGXSTuUu10(vIKsVcMLgYRcJNqK5nO(this), vIKsVcMLgYRcJNqK5nO(this))), vIKsVcMLgYRcJNqK5nO(this));
	}

	public override string GetIsNullFunctionName()
	{
		return (string)GOsG20M9tT7GM95KyOt(0x2E102DC0 ^ 0x2E103C1C);
	}

	public override string GenUid()
	{
		return (string)GOsG20M9tT7GM95KyOt(-1374979190 ^ -1374983578);
	}

	public override string Concat(params string[] items)
	{
		return string.Join((string)UVvnvgMylwUuDDWELQT(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-250283594 ^ -250288056), ConcatenateSymbol()), items);
	}

	public override string CastToString(string columnName)
	{
		return (string)UVvnvgMylwUuDDWELQT(GOsG20M9tT7GM95KyOt(0x720B60EA ^ 0x720B72E6), columnName);
	}

	public override string List(string columNameForConnect, string inColumNameForConnect, string outAlias, string inAlias, string tableName, string where)
	{
		return (string)AFRAUyMAVdEsIsyiqNS(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-786261895 ^ -786265537), new object[4] { inColumNameForConnect, tableName, where, inAlias });
	}

	public override string GuidToCharFromSqlWithoutQuote(string parametrName)
	{
		return string.Format((string)GOsG20M9tT7GM95KyOt(0x379281FC ^ 0x37929302), parametrName, (!mZxCXXMJhhW1mmjgQHw(VGv9lFMC24yuowgg6Vt(this))) ? UVvnvgMylwUuDDWELQT(GOsG20M9tT7GM95KyOt(0x2CE25C3E ^ 0x2CE24F08), VGv9lFMC24yuowgg6Vt(this)) : "");
	}

	public override string CharToGuidFromSqlWithoutQuote(string parametrName)
	{
		return (string)VSDiD0MNWltl4Pw3meO(GOsG20M9tT7GM95KyOt(-1227940259 ^ -1227944677), parametrName, (!mZxCXXMJhhW1mmjgQHw(base.SchemaName)) ? string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2F47749 ^ 0x2F4647F), VGv9lFMC24yuowgg6Vt(this)) : "");
	}

	public override string ConvertToInt64(string parameter)
	{
		return (string)UVvnvgMylwUuDDWELQT(GOsG20M9tT7GM95KyOt(-860755570 ^ -860751120), parameter);
	}

	public override string Substring(string val, int start, int? length = null)
	{
		return string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2061675377 ^ -2061678811), val, start, length.HasValue ? length.Value.ToString() : string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x15436EBF ^ 0x15437D61), val, start));
	}

	public override string BinOr(string value1, string value2)
	{
		return string.Format((string)GOsG20M9tT7GM95KyOt(-424049965 ^ -424046291), value1, value2);
	}

	public override string LikeValue(string value)
	{
		return value.Replace((string)GOsG20M9tT7GM95KyOt(0x4F69E90A ^ 0x4F69F94A), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4960B0BA ^ 0x4960A4A2));
	}

	internal static object GOsG20M9tT7GM95KyOt(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool r3YwjnMIPypr6remyOf()
	{
		return hxbYhIMu1AeI9ONgrxE == null;
	}

	internal static MSSQLDialect lqgQlUMEgdqElXr3AkI()
	{
		return hxbYhIMu1AeI9ONgrxE;
	}

	internal static object UVvnvgMylwUuDDWELQT(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static DateTime O6h74PMneKKkVqA4c78(DateTime P_0)
	{
		return P_0.ToServerDateTime();
	}

	internal static object BBVd22MOIEOkM9eTZqE(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object AFRAUyMAVdEsIsyiqNS(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object RZQnufMjoB0cbarRugL(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object z06dBQMxPuL7scU0TnS(object P_0, object P_1)
	{
		return ((Dialect)P_0).GuidToCharFromSqlWithoutQuote((string)P_1);
	}

	internal static object i3tDyaMQ4ZhEdBC62cc(object P_0, object P_1)
	{
		return ((Dialect)P_0).CharToGuidFromSqlWithoutQuote((string)P_1);
	}

	internal static object VSDiD0MNWltl4Pw3meO(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object vIKsVcMLgYRcJNqK5nO(object P_0)
	{
		return ((Dialect)P_0).QuoteSymbol();
	}

	internal static object L4RSxBMkAkGXSTuUu10(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object M8oFXLM6OtWsZXKgjCy(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object VGv9lFMC24yuowgg6Vt(object P_0)
	{
		return ((Dialect)P_0).SchemaName;
	}

	internal static bool mZxCXXMJhhW1mmjgQHw(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}
}
