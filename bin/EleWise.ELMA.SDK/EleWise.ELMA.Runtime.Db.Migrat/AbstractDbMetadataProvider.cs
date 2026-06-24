using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Migrator.Providers;

public abstract class AbstractDbMetadataProvider
{
	public const string INDEX_NAME_PARAMETER = "IndexName";

	public const string TABLE_NAME_PARAMETER = "TableName";

	public const string COLUMN_NAME_PARAMETER = "ColumnName";

	public const string FOREIGN_KEY_NAME_PARAMETER = "ForeignKeyName";

	public const string PARENT_TABLE_NAME_PARAMETER = "ParentTableName";

	public const string PARENT_COLUMN_NAME_PARAMETER = "ParentColumnName";

	public const string REF_TABLE_NAME_PARAMETER = "ReferenceTableName";

	public const string REF_COLUMN_NAME_PARAMETER = "ReferenceColumnName";

	protected ITransformationProvider transformationProvider;

	internal static AbstractDbMetadataProvider ppP88JWkc1BURDS1jCTm;

	protected abstract string ForeignKeysScript { get; }

	protected abstract string PrimaryKeysScript { get; }

	protected abstract string IndexesScript { get; }

	public AbstractDbMetadataProvider(ITransformationProvider transform)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		FgpV6HWnBrLJXgPxV1ne();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			transformationProvider = transform;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
			{
				num = 1;
			}
		}
	}

	public virtual IEnumerable<PrimaryKey> GetPrimaryKeys()
	{
		Dictionary<string, PrimaryKey> dictionary = new Dictionary<string, PrimaryKey>();
		using (IDataReader dataReader = transformationProvider.ExecuteQuery(PrimaryKeysScript))
		{
			while (dataReader.Read())
			{
				string text = ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886517109)]);
				if (!dictionary.TryGetValue(text, out var value))
				{
					value = (dictionary[text] = new PrimaryKey
					{
						Name = text,
						TableName = ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195744753)])
					});
				}
				value.Columns.Add(ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A7FFF7)]));
			}
		}
		return dictionary.Values;
	}

	public virtual IEnumerable<Index> GetIndexes()
	{
		Dictionary<string, Index> dictionary = new Dictionary<string, Index>();
		using (IDataReader dataReader = transformationProvider.ExecuteQuery(IndexesScript))
		{
			while (dataReader.Read())
			{
				string text = ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281974340)]);
				if (!dictionary.TryGetValue(text, out var value))
				{
					value = (dictionary[text] = new Index
					{
						Name = text,
						TableName = ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105331976)])
					});
				}
				value.Columns.Add(ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824518483)]));
			}
		}
		return dictionary.Values;
	}

	public virtual IEnumerable<ForeignKey> GetForeignKeys()
	{
		Dictionary<string, ForeignKey> dictionary = new Dictionary<string, ForeignKey>();
		using (IDataReader dataReader = transformationProvider.ExecuteQuery(ForeignKeysScript))
		{
			while (dataReader.Read())
			{
				string text = ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A83BCFC)]);
				if (!dictionary.TryGetValue(text, out var value))
				{
					value = (dictionary[text] = new ForeignKey
					{
						Name = text,
						TableName = ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099621313)]),
						RefTableName = ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x72450700)])
					});
				}
				value.Columns.Add(ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811893252)]));
				value.RefColumns.Add(ConvertToString(dataReader[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538649152)]));
			}
		}
		return dictionary.Values;
	}

	public virtual string GetAsDbIdentifier(string name)
	{
		//Discarded unreachable code: IL_0031
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return ConvertToRegularDbIdentifier(name);
			case 2:
				return name;
			case 1:
				if (uaMuTqWnWwGYcOr9jaTq(name))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (TWgEIVWnbo7GIyrXWH91(gEwmgwWnocX8ckWUZCV6(transformationProvider), name))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 3;
			default:
				return null;
			}
		}
	}

	protected virtual string ConvertToString(object dbString)
	{
		return (string)FXMbkbWnhs3uKqxxvhho(dbString);
	}

	protected virtual string Quote(string identifier)
	{
		return transformationProvider.Dialect.QuoteIfNeeded(identifier);
	}

	protected abstract string ConvertToRegularDbIdentifier(string name);

	internal static void FgpV6HWnBrLJXgPxV1ne()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool jobuhJWkzLqx9Z31RwKh()
	{
		return ppP88JWkc1BURDS1jCTm == null;
	}

	internal static AbstractDbMetadataProvider IetnT3WnFmJBWtXsuCtR()
	{
		return ppP88JWkc1BURDS1jCTm;
	}

	internal static bool uaMuTqWnWwGYcOr9jaTq(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object gEwmgwWnocX8ckWUZCV6(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static bool TWgEIVWnbo7GIyrXWH91(object P_0, object P_1)
	{
		return ((Dialect)P_0).IsReservedWord((string)P_1);
	}

	internal static object FXMbkbWnhs3uKqxxvhho(object P_0)
	{
		return Convert.ToString(P_0);
	}
}
