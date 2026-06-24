using System;
using System.Data;
using System.Data.Common;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.Type;
using NHibernate.UserTypes;

namespace EleWise.ELMA.Files;

[Serializable]
public class BinaryFileType : IUserType
{
	private static BinaryFileType VB4TXGGT4VoPr2l3ea3d;

	SqlType[] SqlTypes => (SqlType[])(object)new SqlType[1] { (SqlType)oX01wqGTlBXbBc3IbUPg(LtYY3kGTds7YeBhZmkxn(250)) };

	Type ReturnedType => zBqQVoGTA5IaYxC232Me(typeof(BinaryFile).TypeHandle);

	bool IsMutable => true;

	bool IUserType.Equals(object x, object y)
	{
		int num = 1;
		BinaryFile binaryFile2 = default(BinaryFile);
		BinaryFile binaryFile = default(BinaryFile);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (binaryFile2 == binaryFile)
					{
						return true;
					}
					goto end_IL_0012;
				case 4:
					if (binaryFile2 != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto IL_00c4;
				default:
					binaryFile = y as BinaryFile;
					num2 = 3;
					break;
				case 2:
					if (binaryFile != null)
					{
						num2 = 5;
						break;
					}
					goto IL_00c4;
				case 3:
					if (binaryFile2 == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 4;
				case 7:
					return binaryFile2.Equals(binaryFile);
				case 1:
					binaryFile2 = x as BinaryFile;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					{
						if (binaryFile == null)
						{
							return true;
						}
						num2 = 4;
						break;
					}
					IL_00c4:
					return false;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	int IUserType.GetHashCode(object x)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return x.GetHashCode();
			case 1:
				if (x == null)
				{
					return zBqQVoGTA5IaYxC232Me(typeof(BinaryFile).TypeHandle).GetHashCode() + 473;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	object IUserType.NullSafeGet(DbDataReader rs, string[] names, ISessionImplementor session, object owner)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = (string)xPc0n8GT7sWmiIj8VhTp(NHibernateUtil.String, rs, names[0], session);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return dh2EETGTmRUXqcoecNQb(GtvmZUGT0Cl6mu75Zqvf(), text);
			}
			if (!G0WYmQGTx0pnYfBI1b5T(text))
			{
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			return null;
		}
	}

	void IUserType.NullSafeSet(DbCommand cmd, object value, int index, ISessionImplementor session)
	{
		//Discarded unreachable code: IL_0049, IL_0058, IL_0067
		int num = 6;
		string text = default(string);
		BinaryFile binaryFile = default(BinaryFile);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					text = ((IFileManager)GtvmZUGT0Cl6mu75Zqvf()).SaveFile(binaryFile);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					return;
				case 1:
				case 9:
					FYpp7rGTJwJc9EoJ69oN(((DbParameterCollection)egOTJHGTyvfRc8LpAJ3l(cmd))[index], text);
					num2 = 2;
					continue;
				case 7:
					if (!G0WYmQGTx0pnYfBI1b5T(text))
					{
						num2 = 9;
						continue;
					}
					goto case 4;
				case 6:
					if (value != null)
					{
						num2 = 5;
						continue;
					}
					break;
				default:
					text = (string)iL8RrqGT97aVJBcm739J(binaryFile);
					num2 = 7;
					continue;
				case 3:
					return;
				case 5:
					binaryFile = (BinaryFile)value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					break;
				}
				break;
			}
			FYpp7rGTJwJc9EoJ69oN(QDiVsdGTMTSQk1UiWKi7(egOTJHGTyvfRc8LpAJ3l(cmd), index), DBNull.Value);
			num = 3;
		}
	}

	object IUserType.DeepCopy(object value)
	{
		return value;
	}

	object IUserType.Replace(object original, object target, object owner)
	{
		return original;
	}

	object IUserType.Assemble(object cached, object owner)
	{
		return cached;
	}

	object IUserType.Disassemble(object value)
	{
		return value;
	}

	public BinaryFileType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ueJeHGGTr3XugLOgpZqu();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool nYnR92GT6OnS1rcdIGko()
	{
		return VB4TXGGT4VoPr2l3ea3d == null;
	}

	internal static BinaryFileType FmNhkSGTHrivSbUFuDHh()
	{
		return VB4TXGGT4VoPr2l3ea3d;
	}

	internal static Type zBqQVoGTA5IaYxC232Me(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object xPc0n8GT7sWmiIj8VhTp(object P_0, object P_1, object P_2, object P_3)
	{
		return ((NullableType)P_0).NullSafeGet((DbDataReader)P_1, (string)P_2, (ISessionImplementor)P_3);
	}

	internal static bool G0WYmQGTx0pnYfBI1b5T(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object GtvmZUGT0Cl6mu75Zqvf()
	{
		return DataAccessManager.FileManager;
	}

	internal static object dh2EETGTmRUXqcoecNQb(object P_0, object P_1)
	{
		return ((IFileManager)P_0).LoadFile((string)P_1);
	}

	internal static object egOTJHGTyvfRc8LpAJ3l(object P_0)
	{
		return ((DbCommand)P_0).Parameters;
	}

	internal static object QDiVsdGTMTSQk1UiWKi7(object P_0, int P_1)
	{
		return ((DbParameterCollection)P_0)[P_1];
	}

	internal static void FYpp7rGTJwJc9EoJ69oN(object P_0, object P_1)
	{
		((IDataParameter)P_0).Value = P_1;
	}

	internal static object iL8RrqGT97aVJBcm739J(object P_0)
	{
		return ((BinaryFile)P_0).Id;
	}

	internal static object LtYY3kGTds7YeBhZmkxn(int P_0)
	{
		return TypeFactory.GetStringType(P_0);
	}

	internal static object oX01wqGTlBXbBc3IbUPg(object P_0)
	{
		return ((NullableType)P_0).get_SqlType();
	}

	internal static void ueJeHGGTr3XugLOgpZqu()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
