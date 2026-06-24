using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Migrator.Providers;

public abstract class Dialect
{
	private readonly Dictionary<ColumnProperty, string> propertyMap;

	private readonly TypeNames typeNames;

	private readonly List<string> reservedWords;

	private readonly string schemaName;

	public const string UnQuoteSymbol = "^^";

	private static Dialect obAVaoWn0LsHsLfxJahv;

	public List<string> ReservedWords => reservedWords;

	public string SchemaName => schemaName;

	public virtual int MaxTableNameLength => 28;

	public virtual DateTime MinDateTime => DateTime.MinValue;

	public virtual DateTime MaxDateTime => DateTime.MaxValue;

	public virtual bool TableNameNeedsQuote => false;

	public virtual bool ConstraintNameNeedsQuote => false;

	public virtual bool IdentityNeedsType => true;

	public virtual bool NeedsNotNullForIdentity => true;

	public virtual bool SupportsIndex => true;

	public virtual string QuoteTemplate => (string)y5v6JQWOFR8F9EhCXC1q(rrwkl1WnLliKhsOMwb73(0x12A5FAC7 ^ 0x12A7FE2D), o9AqFbWn5Ecx2iktAay3(this), loLuCDWnrGGLVZuaZP5G(this));

	public virtual string QuoteReservedWordsSymbolStart => (string)rrwkl1WnLliKhsOMwb73(-477139494 ^ -477138814);

	public virtual string QuoteReservedWordsSymbolEnd => (string)rrwkl1WnLliKhsOMwb73(0x20261A4F ^ 0x20260717);

	public abstract string CurrentTimestamp { get; }

	public abstract string CurrentUtcTimestamp { get; }

	protected Dialect(List<string> reservedWords)
	{
		SingletonReader.JJCZtPuTvSt();
		propertyMap = new Dictionary<ColumnProperty, string>();
		typeNames = new TypeNames();
		base._002Ector();
		this.reservedWords = reservedWords ?? new List<string>();
		RegisterProperty(ColumnProperty.Null, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521397696));
		RegisterProperty(ColumnProperty.NotNull, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7D341E));
		RegisterProperty(ColumnProperty.Unique, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53F806EE));
		RegisterProperty(ColumnProperty.PrimaryKey, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675373169));
	}

	protected Dialect(List<string> reservedWords, string schemaName)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(reservedWords);
		this.schemaName = schemaName;
	}

	public virtual bool TypeIsRegistred(DbType type)
	{
		return W0X1TRWnMCqKBqevbUS0(typeNames, type);
	}

	protected void RegisterColumnType(DbType code, int capacity, string name)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				typeNames.Put(code, capacity, name);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected void RegisterColumnType(DbType code, int capacity, string name, int defaultScale)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				typeNames.Put(code, capacity, name, defaultScale);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected void RegisterColumnType(DbType code, string name)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				fwe2XlWnJHGxhDMnsWnd(typeNames, code, name);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual string GetTypeName(DbType type)
	{
		return (string)cpI1JGWn9MPTMDgUWSwy(typeNames, type);
	}

	public virtual string GetTypeName(ColumnType type)
	{
		return typeNames.Get(type);
	}

	public virtual string GetTypeName(DbType type, int? length, int? scale)
	{
		return typeNames.Get(type, length, scale);
	}

	public void RegisterProperty(ColumnProperty property, string sql)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
			case 4:
				propertyMap[property] = sql;
				num2 = 3;
				break;
			default:
				propertyMap.Add(property, sql);
				num2 = 4;
				break;
			case 2:
				if (propertyMap.ContainsKey(property))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	public virtual string SqlForProperty(ColumnProperty property)
	{
		//Discarded unreachable code: IL_006b, IL_007a
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return propertyMap[property];
			default:
				return string.Empty;
			case 1:
				if (!propertyMap.ContainsKey(property))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public virtual string Quote(string value)
	{
		return string.Format((string)C9gcf1Wnd3YUeTBlIdtP(this), value);
	}

	public virtual string UnquoteIfNeeded(string name)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (!pNHvUkWngiQYGMnXgSDi(name, loLuCDWnrGGLVZuaZP5G(this)))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 1;
					}
					break;
				}
				return (string)hqWuh7WnYMHAEHFHmpbt(name, UsIwOuWnjASJ2PyISe3d(o9AqFbWn5Ecx2iktAay3(this)), UsIwOuWnjASJ2PyISe3d(name) - ((string)loLuCDWnrGGLVZuaZP5G(this)).Length - UsIwOuWnjASJ2PyISe3d(o9AqFbWn5Ecx2iktAay3(this)));
			case 2:
				if (!vBCisLWnlkg5C2In2Qcm(name, QuoteReservedWordsSymbolStart))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 1:
			case 3:
				return name;
			}
		}
	}

	public virtual string QuoteIfNeeded(string name)
	{
		//Discarded unreachable code: IL_00d3, IL_00e2, IL_0136, IL_0145
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (vBCisLWnlkg5C2In2Qcm(text, o9AqFbWn5Ecx2iktAay3(this)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto IL_00ef;
			case 8:
				return RemoveUnQuote(name);
			default:
				text = (string)iTo6FBWnU00y7OdYLgjj(name);
				num2 = 4;
				break;
			case 5:
				return name;
			case 7:
				return (string)NiM3pPWnzECleTAOuxJE(C9gcf1Wnd3YUeTBlIdtP(this), name);
			case 1:
				if (!vBCisLWnlkg5C2In2Qcm(name, rrwkl1WnLliKhsOMwb73(0x7247028A ^ 0x724504C0)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 9;
			case 2:
				return name;
			case 3:
				if (text.EndsWith((string)loLuCDWnrGGLVZuaZP5G(this)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto IL_00ef;
			case 9:
				if (name.EndsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998409360)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto default;
			case 6:
				{
					if (!zpe2bcWncb5JDBEwoU0r(name))
					{
						num2 = 7;
						break;
					}
					goto case 5;
				}
				IL_00ef:
				if (!XJAg8CWnsXkIrxM1DAMv(this, name))
				{
					num2 = 6;
					break;
				}
				goto case 7;
			}
		}
	}

	public virtual bool IsReservedWord(string name)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = default(_003C_003Ec__DisplayClass39_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass39_.trimedName = (string)iTo6FBWnU00y7OdYLgjj(name);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return reservedWords.Any(_003C_003Ec__DisplayClass39_._003CIsReservedWord_003Eb__0);
			}
		}
	}

	public virtual string Default(object defaultValue)
	{
		return (string)NiM3pPWnzECleTAOuxJE(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53EAAF1), defaultValue);
	}

	public virtual string GetColumnSql(Column column, bool compoundPrimaryKey)
	{
		int num = 3;
		int num2 = num;
		List<string> list = default(List<string>);
		while (true)
		{
			switch (num2)
			{
			default:
				BuildColumnSql(list, column, compoundPrimaryKey);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return (string)ooWyrsWOo2jx6Inrbllg(rrwkl1WnLliKhsOMwb73(-1822890472 ^ -1822904518), h3pZdAWOWAy37X2xXjjD(list));
			case 2:
				list = new List<string>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				S09BKTWOBWu5uFGXVa8x(column, rrwkl1WnLliKhsOMwb73(-210725949 ^ -210670391));
				num2 = 2;
				break;
			}
		}
	}

	public abstract string DateToSql(DateTime date);

	public abstract string ConvertToInt64(string parameter);

	public abstract string DateTimeToSql(DateTime date);

	public abstract string StrToIntFromSql(string parametrName);

	public abstract string GuidToCharFromSql(string parametrName);

	public abstract string GuidToCharFromSqlWithoutQuote(string parametrName);

	public abstract string CharToGuidFromSqlWithoutQuote(string parametrName);

	public abstract string CharToGuidFromSql(string parametrName);

	public abstract string AddSecond(string arg, string second);

	public abstract string QuoteSymbol();

	public abstract string ConcatenateSymbol();

	public abstract string IsNull(string checkExpression, string replacementValue);

	public abstract string QuoteString(string text);

	public string UnQuoteString(string text)
	{
		return (string)Ie2JMNWOG2psmcToryBg(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426226829), fF6aLKWOh6ghgyPYVHyI(text, rrwkl1WnLliKhsOMwb73(-70037984 ^ -70170518), p3dGbPWObHXq3JQtqVf4(rrwkl1WnLliKhsOMwb73(0x5DD55050 ^ 0x5DD7561A), rrwkl1WnLliKhsOMwb73(0x31326106 ^ 0x3130674C))), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979383173));
	}

	public string RemoveUnQuote(string text)
	{
		return (string)hqWuh7WnYMHAEHFHmpbt(text, eIkqWdWOEuVAopwZ8Wmy(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112834852)), UsIwOuWnjASJ2PyISe3d(text) - eIkqWdWOEuVAopwZ8Wmy(rrwkl1WnLliKhsOMwb73(-138018305 ^ -138147915)) * 2);
	}

	public virtual Guid GetGuid(object value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (value == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 0;
					}
					break;
				}
				return (Guid)value;
			default:
				return Guid.Empty;
			}
		}
	}

	public abstract string GetIsNullFunctionName();

	public virtual bool IsIsolationLevelSupported(IsolationLevel isolationLevel)
	{
		return true;
	}

	public abstract string GenUid();

	public abstract string Concat(params string[] items);

	public abstract string Substring(string val, int start, int? length = null);

	public virtual string Length(string columnName)
	{
		return string.Format((string)rrwkl1WnLliKhsOMwb73(0x1C9495B4 ^ 0x1C9693D8), columnName);
	}

	public virtual string Max(string columnName)
	{
		return (string)NiM3pPWnzECleTAOuxJE(rrwkl1WnLliKhsOMwb73(-1867198571 ^ -1867069163), columnName);
	}

	public abstract string CastToString(string columnName);

	public abstract string List(string columNameForConnect, string inColumNameForConnect, string outAlias, string inAlias, string tableName, string where);

	public virtual string GetParamName(string queryPart)
	{
		return (string)p4B5rZWOfwyrwI0FFwhV(queryPart, 1);
	}

	public abstract string BinOr(string value1, string value2);

	public virtual string InsertIf(string expression, string trueValue, string falseValue)
	{
		return (string)KU8m1yWOQ5g06pWy8koD(rrwkl1WnLliKhsOMwb73(0x18A6761F ^ 0x18A4708B), expression, trueValue, falseValue);
	}

	public virtual string LikeValue(string value)
	{
		return value;
	}

	protected virtual void BuildColumnSql(List<string> vals, Column column, bool compoundPrimaryKey)
	{
		AddColumnName(vals, column);
		AddColumnType(vals, column);
		AddSqlForIdentityWhichNotNeedsType(vals, column);
		AddUnsignedSql(vals, column);
		AddNotNullSql(vals, column);
		AddPrimaryKeySql(vals, column, compoundPrimaryKey);
		AddSqlForIdentityWhichNeedsType(vals, column);
		AddUniqueSql(vals, column);
		AddForeignKeySql(vals, column);
		AddDefaultValueSql(vals, column);
	}

	protected void AddColumnName(List<string> vals, Column column)
	{
		vals.Add(QuoteIfNeeded(column.Name));
	}

	protected void AddColumnType(List<string> vals, Column column)
	{
		string text = ((!IdentityNeedsType && column.IsIdentity) ? string.Empty : GetTypeName(column.ColumnType));
		if (!text.IsNullOrEmpty())
		{
			vals.Add(text);
		}
	}

	protected void AddSqlForIdentityWhichNotNeedsType(List<string> vals, Column column)
	{
		if (!IdentityNeedsType)
		{
			AddValueIfSelected(column, ColumnProperty.Identity, vals);
		}
	}

	protected void AddUnsignedSql(List<string> vals, Column column)
	{
		AddValueIfSelected(column, ColumnProperty.Unsigned, vals);
	}

	protected void AddNotNullSql(List<string> vals, Column column)
	{
		if (!column.ColumnProperty.HasProperty(ColumnProperty.PrimaryKey) || NeedsNotNullForIdentity)
		{
			AddValueIfSelected(column, ColumnProperty.NotNull, vals);
		}
	}

	protected void AddPrimaryKeySql(List<string> vals, Column column, bool compoundPrimaryKey)
	{
		if (!compoundPrimaryKey)
		{
			AddValueIfSelected(column, ColumnProperty.PrimaryKey, vals);
		}
	}

	protected void AddSqlForIdentityWhichNeedsType(List<string> vals, Column column)
	{
		if (IdentityNeedsType)
		{
			AddValueIfSelected(column, ColumnProperty.Identity, vals);
		}
	}

	protected void AddForeignKeySql(List<string> vals, Column column)
	{
		AddValueIfSelected(column, ColumnProperty.ForeignKey, vals);
	}

	protected void AddUniqueSql(List<string> vals, Column column)
	{
		AddValueIfSelected(column, ColumnProperty.Unique, vals);
	}

	protected void AddDefaultValueSql(List<string> vals, Column column)
	{
		if (column.DefaultValue != null)
		{
			vals.Add(Default(column.DefaultValue));
		}
	}

	protected void AddReservedWord(string word)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				reservedWords.Add(word);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				if (XJAg8CWnsXkIrxM1DAMv(this, word))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected void AddValueIfSelected(Column column, ColumnProperty property, ICollection<string> vals)
	{
		if (column.ColumnProperty.HasProperty(property))
		{
			vals.Add(SqlForProperty(property));
		}
	}

	internal static bool W0X1TRWnMCqKBqevbUS0(object P_0, DbType type)
	{
		return ((TypeNames)P_0).HasType(type);
	}

	internal static bool MIe5R1Wnm9Wi7VkGtBxV()
	{
		return obAVaoWn0LsHsLfxJahv == null;
	}

	internal static Dialect dfobXkWnyvcNAZka5nHB()
	{
		return obAVaoWn0LsHsLfxJahv;
	}

	internal static void fwe2XlWnJHGxhDMnsWnd(object P_0, DbType typecode, object P_2)
	{
		((TypeNames)P_0).Put(typecode, (string)P_2);
	}

	internal static object cpI1JGWn9MPTMDgUWSwy(object P_0, DbType typecode)
	{
		return ((TypeNames)P_0).Get(typecode);
	}

	internal static object C9gcf1Wnd3YUeTBlIdtP(object P_0)
	{
		return ((Dialect)P_0).QuoteTemplate;
	}

	internal static bool vBCisLWnlkg5C2In2Qcm(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static object loLuCDWnrGGLVZuaZP5G(object P_0)
	{
		return ((Dialect)P_0).QuoteReservedWordsSymbolEnd;
	}

	internal static bool pNHvUkWngiQYGMnXgSDi(object P_0, object P_1)
	{
		return ((string)P_0).EndsWith((string)P_1);
	}

	internal static object o9AqFbWn5Ecx2iktAay3(object P_0)
	{
		return ((Dialect)P_0).QuoteReservedWordsSymbolStart;
	}

	internal static int UsIwOuWnjASJ2PyISe3d(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object hqWuh7WnYMHAEHFHmpbt(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object rrwkl1WnLliKhsOMwb73(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object iTo6FBWnU00y7OdYLgjj(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static bool XJAg8CWnsXkIrxM1DAMv(object P_0, object P_1)
	{
		return ((Dialect)P_0).IsReservedWord((string)P_1);
	}

	internal static bool zpe2bcWncb5JDBEwoU0r(object P_0)
	{
		return ((string)P_0).IsValidIdentifier();
	}

	internal static object NiM3pPWnzECleTAOuxJE(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object y5v6JQWOFR8F9EhCXC1q(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void S09BKTWOBWu5uFGXVa8x(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object h3pZdAWOWAy37X2xXjjD(object P_0)
	{
		return ((List<string>)P_0).ToArray();
	}

	internal static object ooWyrsWOo2jx6Inrbllg(object P_0, object P_1)
	{
		return string.Join((string)P_0, (string[])P_1);
	}

	internal static object p3dGbPWObHXq3JQtqVf4(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object fF6aLKWOh6ghgyPYVHyI(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object Ie2JMNWOG2psmcToryBg(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static int eIkqWdWOEuVAopwZ8Wmy(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object p4B5rZWOfwyrwI0FFwhV(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static object KU8m1yWOQ5g06pWy8koD(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}
}
