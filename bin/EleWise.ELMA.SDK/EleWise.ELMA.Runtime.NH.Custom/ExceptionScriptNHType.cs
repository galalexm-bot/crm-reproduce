using System;
using System.Data;
using System.Data.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.Type;
using NHibernate.UserTypes;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH.CustomTypes;

[Serializable]
public class ExceptionScriptNHType : IUserType
{
	public class Convention : AutoRegisterUserTypeConvention<ExceptionScriptNHType>
	{
		internal static Convention xtVH0eQYKqeYbK9DDC1T;

		public Convention()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool sO67EVQYXP1f6iMeoZo7()
		{
			return xtVH0eQYKqeYbK9DDC1T == null;
		}

		internal static Convention opZygiQYT81hXffh34ob()
		{
			return xtVH0eQYKqeYbK9DDC1T;
		}
	}

	private readonly SqlType[] sqlTypes;

	private static ExceptionScriptNHType nO9tC7W0XbHOG7wZrWmi;

	public SqlType[] SqlTypes => sqlTypes;

	public Type ReturnedType => XJnDvsW0OEn0wQotbmYD(typeof(ExceptionData).TypeHandle);

	public virtual bool IsMutable => false;

	public new virtual bool Equals(object x, object y)
	{
		//Discarded unreachable code: IL_0071, IL_0080, IL_0090, IL_009f, IL_00af, IL_00be
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				{
					if (!(y is ExceptionData))
					{
						num2 = 2;
						break;
					}
					ExceptionData obj = (ExceptionData)x;
					ExceptionData exceptionData = (ExceptionData)y;
					return eflvWyW0n4ZUfpacr9jx(obj.ToString(), exceptionData.ToString());
				}
				default:
					return true;
				case 4:
				case 7:
					if (!(x is ExceptionData))
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 2:
				case 6:
					return false;
				case 5:
					if (x != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				case 3:
					if (y != null)
					{
						num2 = 7;
						break;
					}
					goto default;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	public virtual int GetHashCode(object x)
	{
		return XJnDvsW0OEn0wQotbmYD(typeof(ExceptionData).TypeHandle).GetHashCode() + 473;
	}

	public object NullSafeGet(DbDataReader rs, string[] names, ISessionImplementor session, object owner)
	{
		//Discarded unreachable code: IL_0181, IL_0190, IL_01e9, IL_0245, IL_02e1, IL_02f0
		int num = 3;
		ExceptionData exceptionData = default(ExceptionData);
		ExceptionHolder exceptionHolder = default(ExceptionHolder);
		object obj = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					exceptionData.ExceptionCode = z7pBWxW0PJpTENd4NuDF(exceptionHolder);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					obj = KZX4tKW02FMPGG6VYLFY(NHibernateUtil.Binary, rs, names[0], session);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 2;
					}
					continue;
				default:
					try
					{
						object obj2 = rqEe90W01o7peTiw1Nv8(exceptionHolder.ExcetionData);
						int num3 = 6;
						while (true)
						{
							switch (num3)
							{
							case 5:
								pLZac4W0Nrx7iuOKhtPQ(exceptionData, new Exception((string)JHqIKKW03j92LY7ofIeW(exceptionData)));
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
								{
									num3 = 0;
								}
								break;
							case 8:
							{
								pLZac4W0Nrx7iuOKhtPQ(exceptionData, obj2 as Exception);
								int num4 = 2;
								num3 = num4;
								break;
							}
							case 4:
								if (obj2 is Exception)
								{
									num3 = 8;
									break;
								}
								goto case 5;
							case 3:
								if (obj2 is ScriptExecuteException)
								{
									num3 = 7;
									break;
								}
								goto case 4;
							case 6:
								if (obj2 == null)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
									{
										num3 = 0;
									}
									break;
								}
								goto case 3;
							case 7:
								exceptionData.OriginalException = obj2 as ScriptExecuteException;
								num3 = 9;
								break;
							default:
								if (obj2 is ExceptionHolder)
								{
									num3 = 3;
									break;
								}
								return exceptionData;
							case 1:
								return exceptionData;
							case 2:
								return exceptionData;
							case 9:
								return exceptionData;
							}
						}
					}
					catch (Exception ex)
					{
						int num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								fNkxSPW0DAnAiKmh9bL1(iQvA4rW0pU4BUWUb95Ab(), njnyTCW0axdU2Oe2QgC7(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123773908)), ex);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
								{
									num5 = 0;
								}
								break;
							default:
								return exceptionData;
							case 0:
								return exceptionData;
							}
						}
					}
				case 4:
					exceptionData = new ExceptionData();
					num2 = 7;
					continue;
				case 6:
					return exceptionData;
				case 5:
					return null;
				case 7:
					exceptionHolder = ClassSerializationHelper.DeserializeObjectByXml<ExceptionHolder>(obj as byte[]);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					if (exceptionHolder != null)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 2:
					if (obj == null)
					{
						num2 = 5;
						continue;
					}
					goto case 4;
				case 8:
					break;
				}
				break;
			}
			exceptionData.Message = (string)FEFmmZW0eb2pej8FdOrt(exceptionHolder);
			num = 9;
		}
	}

	public void NullSafeSet(DbCommand cmd, object value, int index, ISessionImplementor session)
	{
		//Discarded unreachable code: IL_00f6, IL_0129, IL_017f, IL_018e
		int num = 4;
		ExceptionData exceptionData = default(ExceptionData);
		ExceptionHolder exceptionHolder = default(ExceptionHolder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 5:
					goto end_IL_0012;
				case 4:
					if (value != null)
					{
						num2 = 3;
						continue;
					}
					break;
				case 3:
					if (!(value is ExceptionData))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					exceptionData = (ExceptionData)value;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					GwM19gW06yHKVFN7PtuQ(exceptionHolder, zCaInNW041mmb0b3poI2(exceptionData));
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 9;
					}
					continue;
				case 7:
					try
					{
						exceptionHolder.ExcetionData = (byte[])UlrooFW0HFfBywCDy9XU(exceptionData.OriginalException);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch (Exception exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								((ILogger)iQvA4rW0pU4BUWUb95Ab()).Warn(njnyTCW0axdU2Oe2QgC7(fpwu60W0AmUTmPrABqYY(0x35C0467B ^ 0x35C26CE1)), exception);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto end_IL_0012;
				case 9:
					exceptionHolder.Message = (string)JHqIKKW03j92LY7ofIeW(exceptionData);
					num2 = 7;
					continue;
				case 1:
					exceptionHolder = new ExceptionHolder();
					num2 = 6;
					continue;
				case 0:
					return;
				case 8:
					return;
				case 2:
					break;
				}
				FGWsKtW0wQyiBNZZfncg(KGPEKZW0tIHdZGqNB8nh(cmd.Parameters, index), DBNull.Value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			((IDataParameter)KGPEKZW0tIHdZGqNB8nh(v8NjYZW07OSO6IxswuDy(cmd), index)).Value = ClassSerializationHelper.SerializeObjectByXmlToBytes(exceptionHolder);
			num = 8;
		}
	}

	public virtual object DeepCopy(object value)
	{
		return value;
	}

	public virtual object Replace(object original, object target, object owner)
	{
		return original;
	}

	public virtual object Assemble(object cached, object owner)
	{
		return cached;
	}

	public virtual object Disassemble(object value)
	{
		return value;
	}

	public ExceptionScriptNHType()
	{
		//Discarded unreachable code: IL_0049, IL_004e
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		r1dcwvW0xYvnSF6e0avM();
		sqlTypes = (SqlType[])(object)new SqlType[1]
		{
			new SqlType(DbType.Binary, int.MaxValue)
		};
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool eflvWyW0n4ZUfpacr9jx(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool BCMu7LW0TkYDtQBQHFBB()
	{
		return nO9tC7W0XbHOG7wZrWmi == null;
	}

	internal static ExceptionScriptNHType tBmVV5W0kqir39Mwr6sU()
	{
		return nO9tC7W0XbHOG7wZrWmi;
	}

	internal static Type XJnDvsW0OEn0wQotbmYD(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object KZX4tKW02FMPGG6VYLFY(object P_0, object P_1, object P_2, object P_3)
	{
		return ((NullableType)P_0).NullSafeGet((DbDataReader)P_1, (string)P_2, (ISessionImplementor)P_3);
	}

	internal static object FEFmmZW0eb2pej8FdOrt(object P_0)
	{
		return ((ExceptionHolder)P_0).Message;
	}

	internal static int z7pBWxW0PJpTENd4NuDF(object P_0)
	{
		return ((ExceptionHolder)P_0).Code;
	}

	internal static object rqEe90W01o7peTiw1Nv8(object P_0)
	{
		return ClassSerializationHelper.DeserializeObject((byte[])P_0);
	}

	internal static void pLZac4W0Nrx7iuOKhtPQ(object P_0, object P_1)
	{
		((ExceptionData)P_0).OriginalException = (Exception)P_1;
	}

	internal static object JHqIKKW03j92LY7ofIeW(object P_0)
	{
		return ((ExceptionData)P_0).Message;
	}

	internal static object iQvA4rW0pU4BUWUb95Ab()
	{
		return Logger.Log;
	}

	internal static object njnyTCW0axdU2Oe2QgC7(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void fNkxSPW0DAnAiKmh9bL1(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}

	internal static object KGPEKZW0tIHdZGqNB8nh(object P_0, int P_1)
	{
		return ((DbParameterCollection)P_0)[P_1];
	}

	internal static void FGWsKtW0wQyiBNZZfncg(object P_0, object P_1)
	{
		((IDataParameter)P_0).Value = P_1;
	}

	internal static int zCaInNW041mmb0b3poI2(object P_0)
	{
		return ((ExceptionData)P_0).ExceptionCode;
	}

	internal static void GwM19gW06yHKVFN7PtuQ(object P_0, int value)
	{
		((ExceptionHolder)P_0).Code = value;
	}

	internal static object UlrooFW0HFfBywCDy9XU(object P_0)
	{
		return ClassSerializationHelper.SerializeObject(P_0);
	}

	internal static object fpwu60W0AmUTmPrABqYY(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object v8NjYZW07OSO6IxswuDy(object P_0)
	{
		return ((DbCommand)P_0).Parameters;
	}

	internal static void r1dcwvW0xYvnSF6e0avM()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
