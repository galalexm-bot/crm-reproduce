using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Db.Actions;

public class DeletePropertyAction : EntityPropertyAction
{
	private static DeletePropertyAction Po4DGfoGI3nbBdAj9TOL;

	public DeletePropertyAction(IDbModelUpdater updater, EntityMetadata metadata, EntityPropertyMetadata propertyMetadata, ref int startTableActionsIndex)
	{
		//Discarded unreachable code: IL_0021, IL_00b1, IL_00c0, IL_00cb, IL_021e, IL_0231, IL_0240, IL_0251, IL_0260, IL_026b, IL_032a, IL_033d, IL_034c
		L4yxaXoGiUr1ECyNxDvb();
		base._002Ector(updater, metadata, propertyMetadata);
		int num = 5;
		int num2 = num;
		List<Table>.Enumerator enumerator2 = default(List<Table>.Enumerator);
		TypeDbStructures typeDbStructures = default(TypeDbStructures);
		List<Column>.Enumerator enumerator = default(List<Column>.Enumerator);
		Column current = default(Column);
		string text = default(string);
		Table current2 = default(Table);
		while (true)
		{
			switch (num2)
			{
			case 2:
				throw new DbModelException(string.Format((string)lebCKKoGXJsmHXNOFDK8(FNq1ZhoGKHjYlSRQwjOj(0x571EA399 ^ 0x571CF05F)), nyodAaoGTXlUPtZi8a0I(base.Metadata)));
			default:
				enumerator2 = typeDbStructures.Tables.GetEnumerator();
				num2 = 3;
				break;
			case 4:
				try
				{
					while (true)
					{
						IL_0131:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
							{
								num3 = 0;
							}
							goto IL_00cf;
						}
						goto IL_01bd;
						IL_01bd:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num3 = 1;
						}
						goto IL_00cf;
						IL_00cf:
						while (true)
						{
							switch (num3)
							{
							case 2:
								base.Updater.TablesCreatedActions.Insert(startTableActionsIndex, new DbRenameColumnAction(base.Transform, (string)BHiDWFoGRxIgjuIdqgGe(base.Metadata), (string)qcskU3oGn97Ot4Hg1GWO(current), text));
								num3 = 3;
								continue;
							case 5:
								goto IL_0131;
							case 4:
								base.Updater.TablesDeletedActions.Add(new DbDeleteColumnAction(base.Transform, (string)BHiDWFoGRxIgjuIdqgGe(base.Metadata), text));
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
								{
									num3 = 5;
								}
								continue;
							case 1:
								text = (string)t9cVtSoGOpeYmH9kjAXp(base.Updater, BHiDWFoGRxIgjuIdqgGe(metadata), qcskU3oGn97Ot4Hg1GWO(current));
								num3 = 2;
								continue;
							case 6:
								goto IL_01bd;
							case 3:
								startTableActionsIndex++;
								num3 = 4;
								continue;
							case 0:
								break;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto default;
			case 3:
				try
				{
					while (true)
					{
						IL_02d8:
						int num5;
						if (!enumerator2.MoveNext())
						{
							num5 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
							{
								num5 = 3;
							}
							goto IL_026f;
						}
						goto IL_0289;
						IL_0289:
						current2 = enumerator2.Current;
						num5 = 2;
						goto IL_026f;
						IL_026f:
						while (true)
						{
							switch (num5)
							{
							case 2:
								base.Updater.TablesDeletedActions.Add(new DbDeleteTableAction(base.Transform, (string)evX7EYoG28o3t5AUk6EQ(current2)));
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
								{
									num5 = 1;
								}
								continue;
							case 1:
								goto IL_02d8;
							case 3:
								return;
							}
							break;
						}
						goto IL_0289;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					case 0:
						break;
					}
				}
			case 5:
				if (!CcpVZYoGqDqtkv1k7UJh(BHiDWFoGRxIgjuIdqgGe(base.Metadata)))
				{
					typeDbStructures = (TypeDbStructures)kUddWioGkDCH6gOsUiMv(base.Metadata, propertyMetadata);
					num2 = 6;
				}
				else
				{
					num2 = 2;
				}
				break;
			case 6:
				enumerator = typeDbStructures.Columns.GetEnumerator();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				return;
			}
		}
	}

	internal static void L4yxaXoGiUr1ECyNxDvb()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object BHiDWFoGRxIgjuIdqgGe(object P_0)
	{
		return ((EntityMetadata)P_0).TableName;
	}

	internal static bool CcpVZYoGqDqtkv1k7UJh(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object FNq1ZhoGKHjYlSRQwjOj(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object lebCKKoGXJsmHXNOFDK8(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object nyodAaoGTXlUPtZi8a0I(object P_0)
	{
		return ((ClassMetadata)P_0).FullTypeName;
	}

	internal static object kUddWioGkDCH6gOsUiMv(object P_0, object P_1)
	{
		return DbModelHelper.GetPropertyDbStructures((EntityMetadata)P_0, (EntityPropertyMetadata)P_1);
	}

	internal static object qcskU3oGn97Ot4Hg1GWO(object P_0)
	{
		return ((Column)P_0).Name;
	}

	internal static object t9cVtSoGOpeYmH9kjAXp(object P_0, object P_1, object P_2)
	{
		return ((IDbModelUpdater)P_0).GenerateDeletingColumnTemporaryName((string)P_1, (string)P_2);
	}

	internal static object evX7EYoG28o3t5AUk6EQ(object P_0)
	{
		return ((Table)P_0).Name;
	}

	internal static bool vPTsfSoGVnuQcu5nM8TR()
	{
		return Po4DGfoGI3nbBdAj9TOL == null;
	}

	internal static DeletePropertyAction MPoSLxoGS2hxRM0UmwRK()
	{
		return Po4DGfoGI3nbBdAj9TOL;
	}
}
