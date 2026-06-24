using System;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Actions;

public class DbRenameColumnAction : DbAction
{
	private string tableName;

	private string oldName;

	private string newName;

	private static DbRenameColumnAction GCj79GWqy0P7Qh5nb5RN;

	public string TableName => tableName;

	public string OldColumnName => oldName;

	public string NewColumnName => newName;

	public DbRenameColumnAction(ITransformationProvider transform, string tableName, string oldName, string newName)
	{
		//Discarded unreachable code: IL_001b, IL_0020
		GHWriEWq9ExkDikG19UG();
		base._002Ector(transform);
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 3:
				this.oldName = oldName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				this.tableName = tableName;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num = 0;
				}
				break;
			default:
				this.newName = newName;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public override void Execute()
	{
		//Discarded unreachable code: IL_009d, IL_0185, IL_0194, IL_01c6, IL_01d5, IL_02f0, IL_02ff, IL_036c, IL_037b, IL_0401, IL_04d9, IL_04e8
		int num = 23;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 25:
				return;
			case 8:
			case 11:
			case 12:
				if (string.IsNullOrEmpty(base.LogMessage))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 15;
			case 4:
				if (base.Transform.Dialect.IsReservedWord(newName))
				{
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 26;
					}
					break;
				}
				return;
			case 13:
				return;
			case 16:
				WriteLogMessage();
				num2 = 25;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 28;
				}
				break;
			case 20:
				dBUnhCWqjK8FOLHpOOnD(base.Transform, tableName, text, newName);
				num2 = 6;
				break;
			case 14:
				if (jiOCnPWqroLgtWJBV2IC(ubD9FtWqlXjMVvAKCZ8l(base.Transform), oldName))
				{
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 14;
					}
					break;
				}
				goto IL_024c;
			case 28:
				text = (string)fUnmnSWqgZvnYopTMRFL(base.Transform.Dialect, oldName);
				num2 = 27;
				break;
			case 15:
				WriteLogMessage();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (((Dialect)ubD9FtWqlXjMVvAKCZ8l(base.Transform)).IsReservedWord(oldName))
				{
					num2 = 29;
					break;
				}
				goto case 4;
			case 10:
				if (base.Transform.ColumnExists(tableName, oldName))
				{
					num2 = 8;
					break;
				}
				goto case 7;
			case 6:
				return;
			case 24:
				return;
			case 27:
				if (!yKMu86Wq5k2ldMBcxXrQ(base.Transform, tableName, text))
				{
					num2 = 24;
					break;
				}
				goto case 20;
			case 7:
				if (yKMu86Wq5k2ldMBcxXrQ(base.Transform, tableName, newName))
				{
					return;
				}
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 11;
				}
				break;
			case 30:
				if (!yKMu86Wq5k2ldMBcxXrQ(base.Transform, tableName, newName))
				{
					num2 = 19;
					break;
				}
				goto case 2;
			case 1:
				if (yKMu86Wq5k2ldMBcxXrQ(base.Transform, tableName, oldName))
				{
					num2 = 30;
					break;
				}
				goto case 19;
			default:
				dBUnhCWqjK8FOLHpOOnD(base.Transform, tableName, oldName, newName);
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 5;
				}
				break;
			case 18:
				if (yKMu86Wq5k2ldMBcxXrQ(base.Transform, tableName, newName))
				{
					num2 = 9;
					break;
				}
				goto case 21;
			case 21:
				throw new DbStructureException((string)fGW2R6WqUhRJ10sC3XqL(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638529721)), oldName, tableName));
			case 9:
				if (cF9eGyWqsZGlDyhkuAK6(oldName, newName, StringComparison.CurrentCultureIgnoreCase))
				{
					num2 = 12;
					break;
				}
				goto case 10;
			case 22:
				if (kM76SFWqdTwtCPQxqYc2(oldName, newName))
				{
					num2 = 14;
					break;
				}
				goto IL_024c;
			case 2:
				throw new DbStructureException(string.Format((string)aIjZ2qWqL5lFxomDQXaw(ntY11BWqYyrhv5qyadSp(-643786247 ^ -643732719)), newName, tableName));
			case 19:
				if (!yKMu86Wq5k2ldMBcxXrQ(base.Transform, tableName, oldName))
				{
					num2 = 18;
					break;
				}
				goto case 9;
			case 3:
				base.LogMessage = SR.T((string)ntY11BWqYyrhv5qyadSp(-812025778 ^ -812086286), tableName, oldName, newName);
				num2 = 15;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 9;
				}
				break;
			case 23:
				base.Execute();
				num2 = 22;
				break;
			case 17:
				return;
			case 26:
			case 29:
				{
					if (!string.Equals(oldName, newName, StringComparison.CurrentCultureIgnoreCase))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 19;
				}
				IL_024c:
				if (string.Equals(oldName, newName, StringComparison.CurrentCultureIgnoreCase))
				{
					num2 = 5;
					break;
				}
				goto case 26;
			}
		}
	}

	internal static void GHWriEWq9ExkDikG19UG()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool JgHWqOWqMAruGFHa9ECF()
	{
		return GCj79GWqy0P7Qh5nb5RN == null;
	}

	internal static DbRenameColumnAction PiNdFqWqJOf6J6KDYlBi()
	{
		return GCj79GWqy0P7Qh5nb5RN;
	}

	internal static bool kM76SFWqdTwtCPQxqYc2(object P_0, object P_1)
	{
		return string.Equals((string)P_0, (string)P_1);
	}

	internal static object ubD9FtWqlXjMVvAKCZ8l(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static bool jiOCnPWqroLgtWJBV2IC(object P_0, object P_1)
	{
		return ((Dialect)P_0).IsReservedWord((string)P_1);
	}

	internal static object fUnmnSWqgZvnYopTMRFL(object P_0, object P_1)
	{
		return ((Dialect)P_0).UnQuoteString((string)P_1);
	}

	internal static bool yKMu86Wq5k2ldMBcxXrQ(object P_0, object P_1, object P_2)
	{
		return ((ITransformationProvider)P_0).ColumnExists((string)P_1, (string)P_2);
	}

	internal static void dBUnhCWqjK8FOLHpOOnD(object P_0, object P_1, object P_2, object P_3)
	{
		((ITransformationProvider)P_0).RenameColumn((string)P_1, (string)P_2, (string)P_3);
	}

	internal static object ntY11BWqYyrhv5qyadSp(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object aIjZ2qWqL5lFxomDQXaw(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object fGW2R6WqUhRJ10sC3XqL(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static bool cF9eGyWqsZGlDyhkuAK6(object P_0, object P_1, StringComparison P_2)
	{
		return string.Equals((string)P_0, (string)P_1, P_2);
	}
}
