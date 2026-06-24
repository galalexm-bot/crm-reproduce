using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH.CustomTypes;

[Serializable]
public abstract class FixedAbstractBinaryType : MutableType, IVersionType, IType, ICacheAssembler, IComparer
{
	private static FixedAbstractBinaryType fyvA8nWx2BN4AarAkcUj;

	public IComparer Comparator => this;

	public abstract override string Name { get; }

	public Task<object> NextAsync(object current, ISessionImplementor session, CancellationToken cancellationToken)
	{
		return Task.FromResult(current);
	}

	public Task<object> SeedAsync(ISessionImplementor session, CancellationToken cancellationToken)
	{
		return Task.FromResult<object>(null);
	}

	internal FixedAbstractBinaryType()
	{
		//Discarded unreachable code: IL_002f, IL_0034
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		FxHxyAWx1KtZv8EdEsWC();
		this._002Ector(new BinarySqlType());
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal FixedAbstractBinaryType(BinarySqlType sqlType)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		((MutableType)this)._002Ector((SqlType)(object)sqlType);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public object Next(object current, ISessionImplementor session)
	{
		return current;
	}

	public object Seed(ISessionImplementor session)
	{
		return null;
	}

	public override bool IsEqual(object x, object y)
	{
		//Discarded unreachable code: IL_007d, IL_008c
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (y == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 1;
					}
					break;
				}
				return wJCbhlWx31JguWFOUSxi(PYZVdyWxNGKdGoJaVF3W(this, x), PYZVdyWxNGKdGoJaVF3W(this, y));
			case 1:
			case 4:
				return false;
			case 2:
				return true;
			case 3:
				if (x != y)
				{
					if (x == null)
					{
						num2 = 4;
						break;
					}
					goto default;
				}
				num2 = 2;
				break;
			}
		}
	}

	protected internal abstract object ToExternalFormat(byte[] bytes);

	protected internal abstract byte[] ToInternalFormat(object bytes);

	public override void Set(DbCommand cmd, object value, int index, ISessionImplementor session)
	{
		int num = 2;
		int num2 = num;
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				f7sGZRWxawxyXABZO0cB(((DbParameterCollection)m2iYe9WxpCcBng1IrymL(cmd))[index], array);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				array = (byte[])PYZVdyWxNGKdGoJaVF3W(this, value);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override object Get(DbDataReader rs, int index, ISessionImplementor session)
	{
		int num = 2;
		int num2 = num;
		byte[] array = default(byte[]);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return rXPMyEWxtkGUqw3412Zh(this, array);
			case 1:
				array = new byte[num3];
				num2 = 3;
				break;
			case 2:
				num3 = (int)HxiLIGWxDPFOctg9hRsI(rs, index, 0L, null, 0, 0);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				HxiLIGWxDPFOctg9hRsI(rs, index, 0L, array, 0, num3);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override object Get(DbDataReader rs, string name, ISessionImplementor session)
	{
		return rrmN91WxwvpxMlNqFoHk(this, rs, rs.GetOrdinal(name), session);
	}

	public override int GetHashCode(object x)
	{
		//Discarded unreachable code: IL_00a6, IL_00b5
		int num = 5;
		int num2 = num;
		byte[] array = default(byte[]);
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 5:
				array = (byte[])PYZVdyWxNGKdGoJaVF3W(this, x);
				num2 = 4;
				continue;
			case 2:
				num3 = 0;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 3;
				}
				continue;
			case 6:
			case 7:
				if (num3 >= array.Length)
				{
					num2 = 3;
					continue;
				}
				break;
			case 3:
				return num4;
			case 4:
				num4 = 1;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 2;
				}
				continue;
			case 1:
				num3++;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 7;
				}
				continue;
			}
			num4 = 31 * num4 + array[num3];
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
			{
				num2 = 1;
			}
		}
	}

	public override int Compare(object x, object y)
	{
		//Discarded unreachable code: IL_005d, IL_006c, IL_0095, IL_0124, IL_0133, IL_0156, IL_01b7
		int num = 14;
		int num3 = default(int);
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
				case 11:
					if (num3 < array2.Length)
					{
						num = 9;
						break;
					}
					goto case 12;
				case 12:
					return 0;
				case 7:
					return -1;
				case 2:
					if (array2.Length > array.Length)
					{
						num2 = 4;
						continue;
					}
					num3 = 0;
					num2 = 3;
					continue;
				case 8:
					if (array2.Length >= array.Length)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 7;
				case 6:
				case 9:
					if (array2[num3] >= array[num3])
					{
						num2 = 10;
						continue;
					}
					goto case 5;
				case 4:
					return 1;
				case 1:
					return 1;
				default:
					num3++;
					num = 11;
					break;
				case 14:
					array2 = (byte[])PYZVdyWxNGKdGoJaVF3W(this, x);
					num2 = 13;
					continue;
				case 5:
					return -1;
				case 10:
					if (array2[num3] <= array[num3])
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 13:
					array = ToInternalFormat(y);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 8;
					}
					continue;
				}
				break;
			}
		}
	}

	public override string ToString(object val)
	{
		//Discarded unreachable code: IL_0146, IL_0155
		int num = 6;
		int num3 = default(int);
		string text = default(string);
		StringBuilder stringBuilder = default(StringBuilder);
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					num3 = 0;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 7;
					}
					continue;
				case 10:
					num3++;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					if (v3G5lYWx6OEfRe4pJh87(text) == 1)
					{
						num2 = 9;
						continue;
					}
					goto case 4;
				case 4:
					KWQ581WxHmvQBcraQZWx(stringBuilder, text);
					num = 10;
					break;
				case 6:
					array = ToInternalFormat(val);
					num2 = 5;
					continue;
				default:
					text = (string)Lb75oeWx4HgiibuZDKMt(array[num3], 16);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 2;
					}
					continue;
				case 5:
					stringBuilder = new StringBuilder();
					num = 8;
					break;
				case 9:
					stringBuilder.Append('0');
					num2 = 4;
					continue;
				case 1:
				case 7:
					if (num3 < array.Length)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 3:
					return stringBuilder.ToString();
				}
				break;
			}
		}
	}

	public override object DeepCopyNotNull(object value)
	{
		int num = 1;
		int num2 = num;
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			default:
				array = new byte[array2.Length];
				num2 = 3;
				break;
			case 1:
				array2 = (byte[])PYZVdyWxNGKdGoJaVF3W(this, value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				CJ7TYaWxABCai9HYwMRA(array2, 0, array, 0, array2.Length);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return ToExternalFormat(array);
			}
		}
	}

	public override object FromStringValue(string xml)
	{
		//Discarded unreachable code: IL_00c2, IL_00d1, IL_010a
		int num = 9;
		int num2 = num;
		byte[] array = default(byte[]);
		int num3 = default(int);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 9:
				if (xml == null)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				if (xml.Length % 2 == 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 4;
			case 4:
				throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638539501));
			default:
				array = new byte[v3G5lYWx6OEfRe4pJh87(xml) / 2];
				num2 = 6;
				continue;
			case 6:
				num3 = 0;
				num2 = 2;
				continue;
			case 1:
				return rXPMyEWxtkGUqw3412Zh(this, array);
			case 3:
				num3++;
				num2 = 7;
				continue;
			case 8:
				return null;
			case 5:
				array[num3] = (byte)nSMP6eWxxGtXdsRrtJnt(text, 16);
				num2 = 3;
				continue;
			case 2:
			case 7:
				if (num3 >= array.Length)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 10:
				break;
			}
			text = (string)eTZPVgWx7P6m5uFso5Z9(xml, num3 * 2, (num3 + 1) * 2 - num3 * 2);
			num2 = 5;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
			{
				num2 = 5;
			}
		}
	}

	internal static void FxHxyAWx1KtZv8EdEsWC()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool cKbJ9rWxeWgHhKin08lq()
	{
		return fyvA8nWx2BN4AarAkcUj == null;
	}

	internal static FixedAbstractBinaryType zk8NHiWxPEnIHJhRa0Mc()
	{
		return fyvA8nWx2BN4AarAkcUj;
	}

	internal static object PYZVdyWxNGKdGoJaVF3W(object P_0, object P_1)
	{
		return ((FixedAbstractBinaryType)P_0).ToInternalFormat(P_1);
	}

	internal static bool wJCbhlWx31JguWFOUSxi(object P_0, object P_1)
	{
		return CollectionExtensions.ByteArrayCompare((byte[])P_0, (byte[])P_1);
	}

	internal static object m2iYe9WxpCcBng1IrymL(object P_0)
	{
		return ((DbCommand)P_0).Parameters;
	}

	internal static void f7sGZRWxawxyXABZO0cB(object P_0, object P_1)
	{
		((IDataParameter)P_0).Value = P_1;
	}

	internal static long HxiLIGWxDPFOctg9hRsI(object P_0, int P_1, long P_2, object P_3, int P_4, int P_5)
	{
		return ((DbDataReader)P_0).GetBytes(P_1, P_2, (byte[])P_3, P_4, P_5);
	}

	internal static object rXPMyEWxtkGUqw3412Zh(object P_0, object P_1)
	{
		return ((FixedAbstractBinaryType)P_0).ToExternalFormat((byte[])P_1);
	}

	internal static object rrmN91WxwvpxMlNqFoHk(object P_0, object P_1, int P_2, object P_3)
	{
		return ((NullableType)P_0).Get((DbDataReader)P_1, P_2, (ISessionImplementor)P_3);
	}

	internal static object Lb75oeWx4HgiibuZDKMt(int P_0, int P_1)
	{
		return Convert.ToString(P_0, P_1);
	}

	internal static int v3G5lYWx6OEfRe4pJh87(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object KWQ581WxHmvQBcraQZWx(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static void CJ7TYaWxABCai9HYwMRA(object P_0, int P_1, object P_2, int P_3, int P_4)
	{
		Array.Copy((Array)P_0, P_1, (Array)P_2, P_3, P_4);
	}

	internal static object eTZPVgWx7P6m5uFso5Z9(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static int nSMP6eWxxGtXdsRrtJnt(object P_0, int P_1)
	{
		return Convert.ToInt32((string)P_0, P_1);
	}
}
