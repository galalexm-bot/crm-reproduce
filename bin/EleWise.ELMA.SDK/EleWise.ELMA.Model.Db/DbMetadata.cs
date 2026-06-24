using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Db;

public static class DbMetadata
{
	public static class Tables
	{
		public static class Model
		{
			public static class Fields
			{
				public const string Id = "Id";

				public const string Version = "VERSION";

				public const string UpdateDate = "UpdateDate";
			}

			public const string TableName = "MD_MODEL";
		}

		public static class AssemblyModel
		{
			public static class Fields
			{
				public const string Id = "Id";

				public const string Name = "AssemblyName";

				public const string Status = "Status";

				public const string Metadata = "Metadata";

				public const string AssemblyRaw = "AssemblyRaw";

				public const string DebugRaw = "DebugRaw";

				public const string DocumentationRaw = "DocumentationRaw";
			}

			public const string TableName = "MD_ASSEMBLY_MODEL";
		}
	}

	private static DbMetadata zkFyf7ohCgPtvk9oEeXX;

	public static void CreateStructures(ITransformationProvider transform, int version)
	{
		//Discarded unreachable code: IL_006f
		int num = 1;
		int num2 = num;
		Table table = default(Table);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				if (!RPJkaCohuqqNIv52cCpD(transform, PvHukIohZwulCdZ3aBvJ(-1978478350 ^ -1978441688)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 5;
					}
					break;
				}
				return;
			case 0:
				return;
			case 2:
				return;
			case 4:
				z8H4m3ohVk4D6qxiaQ0N(transform, table);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
			{
				Table obj = new Table
				{
					Name = (string)PvHukIohZwulCdZ3aBvJ(-812025778 ^ -812070764)
				};
				List<Column> list = new List<Column>();
				Column column = new Column((string)PvHukIohZwulCdZ3aBvJ(-521266112 ^ -521233122), DbType.Int64);
				C5wMxqohIDbGjyAgRXnr(column, ColumnProperty.PrimaryKey);
				list.Add(column);
				list.Add(new Column((string)PvHukIohZwulCdZ3aBvJ(0x5F3078B6 ^ 0x5F31C8E6), DbType.String, 255));
				list.Add(new Column((string)PvHukIohZwulCdZ3aBvJ(0x4D1C1EE4 ^ 0x4D1C9F62), DbType.Int32));
				list.Add(new Column((string)PvHukIohZwulCdZ3aBvJ(-398663332 ^ -398698594), DbType.Binary));
				list.Add(new Column((string)PvHukIohZwulCdZ3aBvJ(0x5DD55050 ^ 0x5DD4E150), DbType.Binary));
				list.Add(new Column((string)PvHukIohZwulCdZ3aBvJ(-309639236 ^ -309659994), DbType.Binary));
				list.Add(new Column(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867153733), DbType.Binary));
				obj.Columns = list;
				table = obj;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 1;
				}
				break;
			}
			case 1:
				if (version != 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	internal static object PvHukIohZwulCdZ3aBvJ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool RPJkaCohuqqNIv52cCpD(object P_0, object P_1)
	{
		return ((ITransformationProvider)P_0).TableExists((string)P_1);
	}

	internal static void C5wMxqohIDbGjyAgRXnr(object P_0, ColumnProperty value)
	{
		((Column)P_0).ColumnProperty = value;
	}

	internal static void z8H4m3ohVk4D6qxiaQ0N(object P_0, object P_1)
	{
		((ITransformationProvider)P_0).AddTable((Table)P_1);
	}

	internal static bool xaraB3ohvvW8xxbFw2OV()
	{
		return zkFyf7ohCgPtvk9oEeXX == null;
	}

	internal static DbMetadata aPGrksoh8Hf7deG2w39G()
	{
		return zkFyf7ohCgPtvk9oEeXX;
	}
}
