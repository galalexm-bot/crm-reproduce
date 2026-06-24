using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Settings.Impl;

[Service(Type = ComponentType.Server, EnableInterceptors = true, InjectProperties = true)]
public class SystemSettingsManager : NHManager
{
	protected static readonly string F_ModuleUid;

	protected static readonly string F_Key;

	internal static SystemSettingsManager vrHMjlWGoalMX9Ge8HWw;

	public ILockManager LockManager
	{
		[CompilerGenerated]
		get
		{
			return _003CLockManager_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
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
					_003CLockManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[Transaction]
	public virtual void SetString(Guid uid, string key, string value)
	{
		//Discarded unreachable code: IL_0091, IL_013d, IL_0175, IL_0184
		int num = 2;
		int num2 = num;
		IDisposable disposable = default(IDisposable);
		SystemSettings systemSettings = default(SystemSettings);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				disposable = LockManager.Lock((string)AnddXTWGGY6wHAyZOWme(uid.ToString(), key));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					object obj = SL8370WGEAV0xK3yhgZL(this, uid, key);
					if (obj != null)
					{
						goto IL_00fb;
					}
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num3 = 3;
					}
					goto IL_0095;
					IL_0095:
					while (true)
					{
						switch (num3)
						{
						default:
							CM6EtOWGQFNtbCHniFjq(systemSettings, value);
							num3 = 2;
							continue;
						case 2:
							bhD27vWGCeLlakmvuShQ(base.Session, systemSettings);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
							{
								num3 = 1;
							}
							continue;
						case 3:
							break;
						case 1:
							return;
						}
						break;
					}
					obj = new SystemSettings();
					j9qKhKWGfBmHVVwfxuZd(obj, uid);
					((SystemSettings)obj).Key = key;
					goto IL_00fb;
					IL_00fb:
					systemSettings = (SystemSettings)obj;
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num3 = 0;
					}
					goto IL_0095;
				}
				finally
				{
					if (disposable != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								GjyeGgWGvS2BFtlwWFKS(disposable);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 0:
				return;
			}
		}
	}

	[Transaction]
	public virtual void SetStrings(Guid uid, IDictionary<string, string> strings)
	{
		if (strings == null)
		{
			return;
		}
		foreach (KeyValuePair<string, string> @string in strings)
		{
			SetString(uid, @string.Key, @string.Value);
		}
	}

	public virtual string GetString(Guid uid, string key)
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 3;
		int num2 = num;
		SystemSettings item = default(SystemSettings);
		while (true)
		{
			switch (num2)
			{
			case 3:
				item = GetItem(uid, key);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 2;
				}
				break;
			default:
				return null;
			case 1:
				return (string)EEAnTsWG8d5FD64ao4l8(item);
			case 2:
				if (item != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public virtual IDictionary<string, string> GetAllStrings(Guid uid)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq(F_ModuleUid, (object)uid)).List<SystemSettings>().ToDictionary((SystemSettings s) => (string)_003C_003Ec.ObWpr0QNIRmQt6UP8tSk(s), (SystemSettings s) => s.Value);
	}

	[Transaction]
	public virtual void RemoveString(Guid uid, string key)
	{
		//Discarded unreachable code: IL_002e, IL_003d, IL_0048, IL_00dc, IL_011c, IL_012b, IL_0137, IL_0146
		int num = 1;
		int num2 = num;
		IEnumerator<SystemSettings> enumerator = default(IEnumerator<SystemSettings>);
		SystemSettings current = default(SystemSettings);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = ((ICriteria)MvOHvVWGIkOgyneaFV3D(MvOHvVWGIkOgyneaFV3D(MJKsqdWGZWrIdQ5Z2suP(this), DDcxGfWGu9Z1rCZ1oWRv(F_ModuleUid, uid)), DDcxGfWGu9Z1rCZ1oWRv(F_Key, key))).List<SystemSettings>().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				while (true)
				{
					IL_0089:
					int num3;
					if (!FikRJrWGVHqVNguoZ1cU(enumerator))
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num3 = 0;
						}
						goto IL_004c;
					}
					goto IL_0066;
					IL_0066:
					current = enumerator.Current;
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num3 = 1;
					}
					goto IL_004c;
					IL_004c:
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 3:
							break;
						case 2:
							goto IL_0089;
						case 1:
							base.Session.Delete((object)current);
							num3 = 2;
							continue;
						case 0:
							return;
						}
						break;
					}
					goto IL_0066;
				}
			}
			finally
			{
				int num4;
				if (enumerator == null)
				{
					num4 = 2;
					goto IL_00e0;
				}
				goto IL_00f6;
				IL_00e0:
				switch (num4)
				{
				default:
					goto end_IL_00cb;
				case 1:
					break;
				case 2:
					goto end_IL_00cb;
				case 0:
					goto end_IL_00cb;
				}
				goto IL_00f6;
				IL_00f6:
				enumerator.Dispose();
				num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num4 = 0;
				}
				goto IL_00e0;
				end_IL_00cb:;
			}
		}
	}

	[Transaction]
	public virtual void RemoveAllStrings(Guid uid)
	{
		//Discarded unreachable code: IL_002e, IL_0038, IL_00ec, IL_0124, IL_0133
		int num = 1;
		int num2 = num;
		IEnumerator<SystemSettings> enumerator = default(IEnumerator<SystemSettings>);
		SystemSettings current = default(SystemSettings);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = ((ICriteria)MJKsqdWGZWrIdQ5Z2suP(this)).Add((ICriterion)(object)Restrictions.Eq(F_ModuleUid, (object)uid)).List<SystemSettings>().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!FikRJrWGVHqVNguoZ1cU(enumerator))
					{
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
						{
							num3 = 0;
						}
						goto IL_003c;
					}
					goto IL_00a3;
					IL_00a3:
					current = enumerator.Current;
					num3 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num3 = 3;
					}
					goto IL_003c;
					IL_003c:
					while (true)
					{
						switch (num3)
						{
						case 3:
							CfhSHeWGSEU0beI35tEY(base.Session, current);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							goto IL_00a3;
						case 1:
							return;
						}
						break;
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							enumerator.Dispose();
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
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
			}
		}
	}

	protected virtual ICriteria CreateCriteria()
	{
		return (ICriteria)RducReWGiW2tG0CyoFdq(base.Session.CreateCriteria<SystemSettings>(), true);
	}

	public virtual SystemSettings GetItem(Guid uid, string key)
	{
		return ((ICriteria)MvOHvVWGIkOgyneaFV3D(MvOHvVWGIkOgyneaFV3D(MJKsqdWGZWrIdQ5Z2suP(this), DDcxGfWGu9Z1rCZ1oWRv(F_ModuleUid, uid)), Restrictions.Eq(F_Key, (object)key))).List<SystemSettings>().FirstOrDefault();
	}

	public SystemSettingsManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static SystemSettingsManager()
	{
		int num = 3;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					parameterExpression = (ParameterExpression)JdkfhGWGq1grBZxtYO14(typeof(SystemSettings), qFwrxbWGRDUt3wsYkeGR(0x1637C429 ^ 0x163731B9));
					num2 = 5;
					continue;
				case 5:
					F_ModuleUid = LinqUtils.NameOf(Expression.Lambda<Func<SystemSettings, object>>((Expression)dEXigJWGkhLlVkP0xYcw(f0l00UWGXdl14sGV8vPo(parameterExpression, (MethodInfo)Of8gF0WGKC2MmfS4of8Y((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), WBZ1aYWGTRsClXrofHL8(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					SingletonReader.JJCZtPuTvSt();
					num2 = 2;
					continue;
				case 1:
					return;
				case 4:
					F_Key = LinqUtils.NameOf(Expression.Lambda<Func<SystemSettings, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			parameterExpression = (ParameterExpression)JdkfhGWGq1grBZxtYO14(WBZ1aYWGTRsClXrofHL8(typeof(SystemSettings).TypeHandle), qFwrxbWGRDUt3wsYkeGR(-2107978722 ^ -2108016242));
			num = 4;
		}
	}

	internal static bool SCmnE5WGbBP1A9nlH1VD()
	{
		return vrHMjlWGoalMX9Ge8HWw == null;
	}

	internal static SystemSettingsManager yUym9XWGhYX4bqFmJ58g()
	{
		return vrHMjlWGoalMX9Ge8HWw;
	}

	internal static object AnddXTWGGY6wHAyZOWme(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object SL8370WGEAV0xK3yhgZL(object P_0, Guid uid, object P_2)
	{
		return ((SystemSettingsManager)P_0).GetItem(uid, (string)P_2);
	}

	internal static void j9qKhKWGfBmHVVwfxuZd(object P_0, Guid value)
	{
		((SystemSettings)P_0).ModuleUid = value;
	}

	internal static void CM6EtOWGQFNtbCHniFjq(object P_0, object P_1)
	{
		((SystemSettings)P_0).Value = (string)P_1;
	}

	internal static void bhD27vWGCeLlakmvuShQ(object P_0, object P_1)
	{
		((ISession)P_0).SaveOrUpdate(P_1);
	}

	internal static void GjyeGgWGvS2BFtlwWFKS(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object EEAnTsWG8d5FD64ao4l8(object P_0)
	{
		return ((SystemSettings)P_0).Value;
	}

	internal static object MJKsqdWGZWrIdQ5Z2suP(object P_0)
	{
		return ((SystemSettingsManager)P_0).CreateCriteria();
	}

	internal static object DDcxGfWGu9Z1rCZ1oWRv(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object MvOHvVWGIkOgyneaFV3D(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static bool FikRJrWGVHqVNguoZ1cU(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void CfhSHeWGSEU0beI35tEY(object P_0, object P_1)
	{
		((ISession)P_0).Delete(P_1);
	}

	internal static object RducReWGiW2tG0CyoFdq(object P_0, bool P_1)
	{
		return ((ICriteria)P_0).SetCacheable(P_1);
	}

	internal static object qFwrxbWGRDUt3wsYkeGR(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object JdkfhGWGq1grBZxtYO14(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object Of8gF0WGKC2MmfS4of8Y(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object f0l00UWGXdl14sGV8vPo(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static Type WBZ1aYWGTRsClXrofHL8(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object dEXigJWGkhLlVkP0xYcw(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}
}
