using System;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Reflection;
using System.Xml;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.UserTypes;

namespace EleWise.ELMA.Runtime.NH.CustomTypes;

[Serializable]
public class XmlSerializableType<T> : IUserType where T : class
{
	private readonly SqlType[] sqlTypes;

	internal static object bm8FoHWyTs0KyyZ3WZ5S;

	public SqlType[] SqlTypes => sqlTypes;

	public Type ReturnedType => typeof(T);

	public virtual bool IsMutable => false;

	public new virtual bool Equals(object x, object y)
	{
		//Discarded unreachable code: IL_00b3, IL_00c2
		int num = 8;
		int num2 = num;
		T val = default(T);
		T val2 = default(T);
		while (true)
		{
			switch (num2)
			{
			case 8:
				val = x as T;
				num2 = 7;
				break;
			case 4:
				if (val == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 7:
				val2 = y as T;
				num2 = 4;
				break;
			case 6:
				return val.Equals(val2);
			case 2:
				return true;
			case 1:
				if (val2 == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 5:
				if (val2 != null)
				{
					num2 = 3;
					break;
				}
				goto IL_00aa;
			default:
				if (val != null)
				{
					num2 = 5;
					break;
				}
				goto IL_00aa;
			case 3:
				{
					if (val == val2)
					{
						return true;
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 6;
					}
					break;
				}
				IL_00aa:
				return false;
			}
		}
	}

	public virtual int GetHashCode(object x)
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
					return typeof(T).GetHashCode() + 473;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public object NullSafeGet(DbDataReader rs, string[] names, ISessionImplementor session, object owner)
	{
		//Discarded unreachable code: IL_007d, IL_00a5, IL_0126, IL_0135, IL_0141, IL_0150
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		object result = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				memoryStream = NHProviderDependentUserTypes.GetInstance<StreamNHType>().NullSafeGet(rs, names, session, owner) as MemoryStream;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				int num3;
				if (memoryStream != null)
				{
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num3 = 0;
					}
					goto IL_0081;
				}
				object obj = GetNullObject();
				goto IL_00b0;
				IL_00b0:
				result = obj;
				num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num3 = 0;
				}
				goto IL_0081;
				IL_0081:
				switch (num3)
				{
				default:
					return result;
				case 0:
					return result;
				case 1:
					break;
				}
				obj = LoadObjectFromStream(memoryStream);
				goto IL_00b0;
			}
			finally
			{
				int num5;
				if (memoryStream == null)
				{
					int num4 = 2;
					num5 = num4;
					goto IL_00ea;
				}
				goto IL_0100;
				IL_00ea:
				switch (num5)
				{
				default:
					goto end_IL_00d1;
				case 1:
					break;
				case 2:
					goto end_IL_00d1;
				case 0:
					goto end_IL_00d1;
				}
				goto IL_0100;
				IL_0100:
				((IDisposable)memoryStream).Dispose();
				num5 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num5 = 0;
				}
				goto IL_00ea;
				end_IL_00d1:;
			}
		}
	}

	public void NullSafeSet(DbCommand cmd, object value, int index, ISessionImplementor session)
	{
		//Discarded unreachable code: IL_004d, IL_005c, IL_0099, IL_00a8
		int num = 7;
		int num2 = num;
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = default(_003C_003Ec__DisplayClass3_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				cmd.Disposed += OnDisposed;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				continue;
			default:
				NHProviderDependentUserTypes.GetInstance<StreamNHType>().NullSafeSet(cmd, (object)CS_0024_003C_003E8__locals0.stream, index, session);
				num2 = 4;
				continue;
			case 10:
				CS_0024_003C_003E8__locals0.stream = MemoryHelper.GetMemoryStream();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 1;
				}
				continue;
			case 8:
				return;
			case 5:
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
				num2 = 10;
				continue;
			case 7:
				if (value == null)
				{
					num2 = 6;
					continue;
				}
				goto case 9;
			case 1:
				SaveObjectToStream(CS_0024_003C_003E8__locals0.stream.AsNoClose(), (T)value);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 2;
				}
				continue;
			case 9:
				if (!IsEmpty((T)value))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 2:
			case 6:
				break;
			case 4:
				return;
			}
			((IDataParameter)cmd.Parameters[index]).Value = DBNull.Value;
			num2 = 8;
		}
	}

	protected virtual bool IsEmpty(T obj)
	{
		return obj == null;
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

	protected virtual T LoadObjectFromStream(Stream stream)
	{
		using XmlTextReader reader = new XmlTextReader(stream);
		return (T)ClassSerializationHelper.DeserializeObjectByXml(TypeOf<T>.Raw, reader);
	}

	protected virtual void SaveObjectToStream(Stream stream, T obj)
	{
		using XmlWriter writer = XmlWriter.Create(stream);
		ClassSerializationHelper.SerializeObjectByXml(obj, writer);
	}

	protected virtual object GetNullObject()
	{
		return null;
	}

	public XmlSerializableType()
	{
		//Discarded unreachable code: IL_0048, IL_004d
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		SingletonReader.JJCZtPuTvSt();
		sqlTypes = (SqlType[])(object)new SqlType[1] { (SqlType)new BinaryBlobSqlType(int.MaxValue) };
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool lR3ZX2WykEta05OwHc2T()
	{
		return bm8FoHWyTs0KyyZ3WZ5S == null;
	}

	internal static object gDbhcAWynevoCrS7xlDR()
	{
		return bm8FoHWyTs0KyyZ3WZ5S;
	}
}
