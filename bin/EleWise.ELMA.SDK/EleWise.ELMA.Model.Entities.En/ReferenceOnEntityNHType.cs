using System;
using System.Data;
using System.Data.Common;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Engine;
using NHibernate.Type;
using NHibernate.UserTypes;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities.EntityReferences;

[Serializable]
public class ReferenceOnEntityNHType : ICompositeUserType
{
	public static string ObjectIdColumn;

	public static string ObjectTypeUid;

	internal static ReferenceOnEntityNHType qI4Zr0hV11IshGVNyXqH;

	public bool IsMutable => true;

	public string[] PropertyNames => new string[2] { ObjectIdColumn, ObjectTypeUid };

	public IType[] PropertyTypes => (IType[])(object)new IType[2]
	{
		(IType)NHibernateUtil.Int64,
		(IType)NHibernateUtil.Guid
	};

	public Type ReturnedClass => AJqrcghVmXDxtfQ76Zdp(typeof(ReferenceOnEntity).TypeHandle);

	public static string GenerateObjectIdName(string propertyName)
	{
		return (string)BVrOFyhVpTtcBGjQtU15(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606608394), propertyName, ObjectIdColumn);
	}

	public static string GenerateObjectTypeName(string propertyName)
	{
		return (string)BVrOFyhVpTtcBGjQtU15(fawoS3hVaYY1EfahyDre(-1108654032 ^ -1108632870), propertyName, ObjectTypeUid);
	}

	public object DeepCopy(object value)
	{
		//Discarded unreachable code: IL_0051, IL_0060
		int num = 3;
		int num2 = num;
		ReferenceOnEntity referenceOnEntity = default(ReferenceOnEntity);
		while (true)
		{
			switch (num2)
			{
			default:
			{
				ReferenceOnEntity referenceOnEntity2 = new ReferenceOnEntity();
				DGB34WhVtqTR06LAKCu0(referenceOnEntity2, AQRRTlhVDuck9Uj6Simy(referenceOnEntity));
				uxexFOhV4gkh2cJpTSUb(referenceOnEntity2, VqZ4PDhVwdOcC3fAQkLM(referenceOnEntity));
				return referenceOnEntity2;
			}
			case 3:
				if (value != null)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 1:
				return null;
			case 2:
				referenceOnEntity = AsReferenceOnEntity(value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public object Assemble(object cached, ISessionImplementor session, object owner)
	{
		return DeepCopy(cached);
	}

	public object Disassemble(object value, ISessionImplementor session)
	{
		return DeepCopy(value);
	}

	public new bool Equals(object x, object y)
	{
		//Discarded unreachable code: IL_003f, IL_004e
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 1:
				return x.Equals(y);
			case 2:
				return true;
			case 4:
				if (y != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 3:
				if (x != y)
				{
					if (x != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto default;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public int GetHashCode(object x)
	{
		//Discarded unreachable code: IL_006a, IL_0079
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return x.GetHashCode();
			default:
				return typeof(ReferenceOnEntity).GetHashCode() + 321;
			case 1:
				if (x == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public object NullSafeGet(DbDataReader dr, string[] names, ISessionImplementor session, object owner)
	{
		//Discarded unreachable code: IL_003d, IL_004c, IL_00b4, IL_00c3
		int num = 4;
		int num2 = num;
		object obj = default(object);
		object obj2 = default(object);
		while (true)
		{
			switch (num2)
			{
			default:
			{
				ReferenceOnEntity referenceOnEntity = new ReferenceOnEntity();
				DGB34WhVtqTR06LAKCu0(referenceOnEntity, JkZic0hVHKwew6bgRDt8(obj));
				uxexFOhV4gkh2cJpTSUb(referenceOnEntity, (Guid)obj2);
				return referenceOnEntity;
			}
			case 2:
			case 5:
				return null;
			case 3:
				obj2 = rMJfWHhV6jTYkcAdOQ0X(NHibernateUtil.Guid, dr, names[1], session);
				num2 = 6;
				break;
			case 4:
				obj = rMJfWHhV6jTYkcAdOQ0X(NHibernateUtil.Int64, dr, names[0], session);
				num2 = 3;
				break;
			case 6:
				if (obj == null)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 1:
				if (obj2 == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto default;
			}
		}
	}

	public void NullSafeSet(DbCommand cmd, object value, int index, ISessionImplementor session)
	{
		//Discarded unreachable code: IL_0093, IL_00a2
		int num = 1;
		ReferenceOnEntity referenceOnEntity = default(ReferenceOnEntity);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					((IDataParameter)blaY5ShVx1Ia03EHppFv(HCDpdkhV7gHurE6jcYNV(cmd), index + 1)).Value = DBNull.Value;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 2;
					}
					continue;
				case 3:
					XONBM3hV0tikU3xAxrEv(blaY5ShVx1Ia03EHppFv(HCDpdkhV7gHurE6jcYNV(cmd), index), DBNull.Value);
					num2 = 7;
					continue;
				case 4:
					XONBM3hV0tikU3xAxrEv(blaY5ShVx1Ia03EHppFv(HCDpdkhV7gHurE6jcYNV(cmd), index + 1), VqZ4PDhVwdOcC3fAQkLM(referenceOnEntity));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 6;
					}
					continue;
				case 2:
					return;
				case 5:
					break;
				default:
					if (referenceOnEntity != null)
					{
						num2 = 5;
						continue;
					}
					goto case 3;
				case 1:
					referenceOnEntity = (ReferenceOnEntity)c5HeIrhVA6OL6d8sEixM(value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					return;
				}
				break;
			}
			XONBM3hV0tikU3xAxrEv(((DbParameterCollection)HCDpdkhV7gHurE6jcYNV(cmd))[index], AQRRTlhVDuck9Uj6Simy(referenceOnEntity));
			num = 4;
		}
	}

	public void NullSafeSet(DbCommand cmd, object value, int index, bool[] settable, ISessionImplementor session)
	{
		//Discarded unreachable code: IL_006a, IL_00c5, IL_00d4, IL_00fa, IL_0109
		int num = 4;
		ReferenceOnEntity referenceOnEntity = default(ReferenceOnEntity);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (referenceOnEntity == null)
					{
						num2 = 11;
						continue;
					}
					if (!settable[0])
					{
						num2 = 12;
						continue;
					}
					goto case 6;
				case 13:
					return;
				case 11:
					if (!settable[0])
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 7;
				case 5:
					((IDataParameter)((DbParameterCollection)HCDpdkhV7gHurE6jcYNV(cmd))[index + 1]).Value = referenceOnEntity.ObjectTypeUId;
					num2 = 2;
					continue;
				case 4:
					break;
				case 10:
				case 12:
					if (!settable[1])
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 5;
				case 7:
					XONBM3hV0tikU3xAxrEv(blaY5ShVx1Ia03EHppFv(HCDpdkhV7gHurE6jcYNV(cmd), index), DBNull.Value);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (settable[1])
					{
						num2 = 8;
						continue;
					}
					return;
				case 8:
					XONBM3hV0tikU3xAxrEv(blaY5ShVx1Ia03EHppFv(HCDpdkhV7gHurE6jcYNV(cmd), index + 1), DBNull.Value);
					num2 = 9;
					continue;
				case 9:
					return;
				case 6:
					XONBM3hV0tikU3xAxrEv(blaY5ShVx1Ia03EHppFv(cmd.Parameters, index), AQRRTlhVDuck9Uj6Simy(referenceOnEntity));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 10;
					}
					continue;
				case 2:
					return;
				}
				break;
			}
			referenceOnEntity = AsReferenceOnEntity(value);
			num = 3;
		}
	}

	public object Replace(object original, object target, ISessionImplementor session, object owner)
	{
		return DeepCopy(original);
	}

	public object GetPropertyValue(object component, int property)
	{
		//Discarded unreachable code: IL_00dd, IL_00ec, IL_00fc, IL_010b
		int num = 3;
		int num2 = num;
		ReferenceOnEntity referenceOnEntity = default(ReferenceOnEntity);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (property == 0)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 5;
			case 5:
				if (property != 1)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 1;
					}
					break;
				}
				return VqZ4PDhVwdOcC3fAQkLM(referenceOnEntity);
			case 3:
				referenceOnEntity = (ReferenceOnEntity)c5HeIrhVA6OL6d8sEixM(component);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return AQRRTlhVDuck9Uj6Simy(referenceOnEntity);
			case 1:
				throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8335DBA), property));
			}
		}
	}

	public void SetPropertyValue(object component, int property, object value)
	{
		//Discarded unreachable code: IL_006c, IL_007b, IL_00ad, IL_00bc
		int num = 3;
		int num2 = num;
		ReferenceOnEntity referenceOnEntity = default(ReferenceOnEntity);
		while (true)
		{
			switch (num2)
			{
			default:
				DGB34WhVtqTR06LAKCu0(referenceOnEntity, JkZic0hVHKwew6bgRDt8(value));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				return;
			case 7:
				throw new Exception((string)G4JNLnhVyulnpvEKEvVw(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x6382BC63), property));
			case 3:
				if (component == null)
				{
					num2 = 2;
					break;
				}
				referenceOnEntity = (ReferenceOnEntity)c5HeIrhVA6OL6d8sEixM(component);
				num2 = 4;
				break;
			case 4:
				if (property == 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 5:
				if (property != 1)
				{
					num2 = 7;
					break;
				}
				uxexFOhV4gkh2cJpTSUb(referenceOnEntity, (Guid)value);
				num2 = 8;
				break;
			case 1:
				return;
			case 2:
				throw new ArgumentNullException((string)fawoS3hVaYY1EfahyDre(-1411196499 ^ -1411321787));
			}
		}
	}

	private static ReferenceOnEntity AsReferenceOnEntity(object value)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (value != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return null;
			default:
				return (value as ReferenceOnEntity) ?? throw new InvalidCastException(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345283526), AJqrcghVmXDxtfQ76Zdp(typeof(ReferenceOnEntity).TypeHandle), value.GetType()));
			}
		}
	}

	public ReferenceOnEntityNHType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vHD863hVMEAZMZ43oFGV();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ReferenceOnEntityNHType()
	{
		int num = 2;
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
				ObjectIdColumn = (string)fawoS3hVaYY1EfahyDre(-289714582 ^ -289928504);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				vHD863hVMEAZMZ43oFGV();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				ObjectTypeUid = (string)fawoS3hVaYY1EfahyDre(-1824388195 ^ -1824436425);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object BVrOFyhVpTtcBGjQtU15(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static bool eMcTYThVNkOhthoXT6G5()
	{
		return qI4Zr0hV11IshGVNyXqH == null;
	}

	internal static ReferenceOnEntityNHType aWU1sehV3SZRBPlNEXle()
	{
		return qI4Zr0hV11IshGVNyXqH;
	}

	internal static object fawoS3hVaYY1EfahyDre(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static long AQRRTlhVDuck9Uj6Simy(object P_0)
	{
		return ((ReferenceOnEntity)P_0).ObjectId;
	}

	internal static void DGB34WhVtqTR06LAKCu0(object P_0, long value)
	{
		((ReferenceOnEntity)P_0).ObjectId = value;
	}

	internal static Guid VqZ4PDhVwdOcC3fAQkLM(object P_0)
	{
		return ((ReferenceOnEntity)P_0).ObjectTypeUId;
	}

	internal static void uxexFOhV4gkh2cJpTSUb(object P_0, Guid value)
	{
		((ReferenceOnEntity)P_0).ObjectTypeUId = value;
	}

	internal static object rMJfWHhV6jTYkcAdOQ0X(object P_0, object P_1, object P_2, object P_3)
	{
		return ((NullableType)P_0).NullSafeGet((DbDataReader)P_1, (string)P_2, (ISessionImplementor)P_3);
	}

	internal static long JkZic0hVHKwew6bgRDt8(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static object c5HeIrhVA6OL6d8sEixM(object P_0)
	{
		return AsReferenceOnEntity(P_0);
	}

	internal static object HCDpdkhV7gHurE6jcYNV(object P_0)
	{
		return ((DbCommand)P_0).Parameters;
	}

	internal static object blaY5ShVx1Ia03EHppFv(object P_0, int P_1)
	{
		return ((DbParameterCollection)P_0)[P_1];
	}

	internal static void XONBM3hV0tikU3xAxrEv(object P_0, object P_1)
	{
		((IDataParameter)P_0).Value = P_1;
	}

	internal static Type AJqrcghVmXDxtfQ76Zdp(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object G4JNLnhVyulnpvEKEvVw(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void vHD863hVMEAZMZ43oFGV()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
