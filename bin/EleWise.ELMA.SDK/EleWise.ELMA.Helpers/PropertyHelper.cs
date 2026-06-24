using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public class PropertyHelper
{
	private static PropertyHelper akkInJhLEJXrvHId1Cmj;

	public static bool IsHide<T>(T entity, Expression<Func<T, object>> expr) where T : class
	{
		if (Locator.GetService<IPropertyPermissionService>().CheckPropertyPermission(entity, InterfaceActivator.PropertyUid(expr, inherit: true)) != PropertyPermissionType.Hide)
		{
			return false;
		}
		return true;
	}

	public static string GetNameSortExpression<T>(Expression<Func<T, object>> expr) where T : class
	{
		Type typeFromHandle = typeof(T);
		if (!(expr.Body is MemberExpression memberExpression))
		{
			throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459401365), expr));
		}
		PropertyInfo propertyInfo = memberExpression.Member as PropertyInfo;
		if (propertyInfo == null)
		{
			throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4FDD91), expr));
		}
		if (typeFromHandle != propertyInfo.ReflectedType && !typeFromHandle.IsSubclassOf(propertyInfo.ReflectedType))
		{
			throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3243202), expr, typeFromHandle));
		}
		string titlePropertyNameByMetadata = GetTitlePropertyNameByMetadata(propertyInfo.PropertyType);
		if (string.IsNullOrEmpty(titlePropertyNameByMetadata))
		{
			return propertyInfo.Name;
		}
		return propertyInfo.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3326242) + titlePropertyNameByMetadata;
	}

	internal static string GetTitlePropertyNameByMetadata(Type entityType)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				object obj = dXdk8ehLC5ADoWB9V0m3(entityType);
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return (string)TZndk1hLvg6PZ4PTSDtc(obj);
			}
			default:
				return null;
			}
		}
	}

	internal static PropertyMetadata GetTitlePropertyByMetadata(Type entityType)
	{
		int num = 2;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				entityMetadata = MetadataLoader.LoadMetadata(entityType) as EntityMetadata;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (entityMetadata == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (PropertyMetadata)YmIajthL8WgWf0lu474h(entityMetadata);
			default:
				return null;
			}
		}
	}

	public static string GetNameSortExpression(IPropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_004b, IL_00dd, IL_011e, IL_012d, IL_0168
		int num = 8;
		Guid? guid2 = default(Guid?);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			Guid? guid;
			while (true)
			{
				switch (num2)
				{
				case 2:
					guid = guid2;
					break;
				case 8:
					if (propertyMetadata != null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 4;
				case 6:
					if (!DkFFvOhLVg5De8nqS9mB(text))
					{
						num2 = 3;
						continue;
					}
					goto case 5;
				case 9:
					if (!z1cwd2hLutssaDJMim5A(guid2.GetValueOrDefault(), Guid.Empty))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 4:
					guid2 = null;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					return propertyMetadata.Name;
				default:
					text = (string)oJ1pPyhLInSBbyU37LTL(tdim6yhLZ6hmMt1IocEo(propertyMetadata));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 6;
					}
					continue;
				case 5:
					return propertyMetadata.Name;
				case 3:
					return (string)dj2ph5hLiX09pq64LZeX(propertyMetadata.Name, dtLpLChLS7OIkkABmsll(0x3630F361 ^ 0x3630E9A5), text);
				case 7:
					guid = tdim6yhLZ6hmMt1IocEo(propertyMetadata);
					break;
				}
				break;
			}
			guid2 = guid;
			num = 9;
		}
	}

	internal static string GetTitlePropertyNameByMetadata(Guid subTypeUid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				object obj = jR50RchLRPG3TZV0Qpqn(subTypeUid);
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (string)TZndk1hLvg6PZ4PTSDtc(obj);
			}
			default:
				return null;
			}
		}
	}

	internal static PropertyMetadata GetTitlePropertyByMetadata(Guid subTypeUid)
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 3;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (entityMetadata != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 3:
				entityMetadata = MetadataLoader.LoadMetadata(subTypeUid) as EntityMetadata;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 2;
				}
				break;
			default:
				return null;
			case 1:
				return (PropertyMetadata)YmIajthL8WgWf0lu474h(entityMetadata);
			}
		}
	}

	internal static string GetSortExpression(IPropertyMetadata propMetadata, string defaultValue)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return defaultValue;
			case 1:
				if (propMetadata != null)
				{
					return (string)cw1Bm1hLqc7N8a4VfeYb(propMetadata);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public PropertyHelper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object dXdk8ehLC5ADoWB9V0m3(Type entityType)
	{
		return GetTitlePropertyByMetadata(entityType);
	}

	internal static object TZndk1hLvg6PZ4PTSDtc(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static bool V7YZ98hLfivEjVSL20Nj()
	{
		return akkInJhLEJXrvHId1Cmj == null;
	}

	internal static PropertyHelper JWCgSdhLQWSHg4aHbBve()
	{
		return akkInJhLEJXrvHId1Cmj;
	}

	internal static object YmIajthL8WgWf0lu474h(object P_0)
	{
		return ((ClassMetadata)P_0).GetTitleProperty();
	}

	internal static Guid tdim6yhLZ6hmMt1IocEo(object P_0)
	{
		return ((IPropertyMetadata)P_0).SubTypeUid;
	}

	internal static bool z1cwd2hLutssaDJMim5A(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object oJ1pPyhLInSBbyU37LTL(Guid subTypeUid)
	{
		return GetTitlePropertyNameByMetadata(subTypeUid);
	}

	internal static bool DkFFvOhLVg5De8nqS9mB(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object dtLpLChLS7OIkkABmsll(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object dj2ph5hLiX09pq64LZeX(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object jR50RchLRPG3TZV0Qpqn(Guid subTypeUid)
	{
		return GetTitlePropertyByMetadata(subTypeUid);
	}

	internal static object cw1Bm1hLqc7N8a4VfeYb(object P_0)
	{
		return GetNameSortExpression((IPropertyMetadata)P_0);
	}
}
