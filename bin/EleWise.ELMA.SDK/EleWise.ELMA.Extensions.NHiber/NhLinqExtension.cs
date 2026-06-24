using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Linq;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions.NHibernateLinqExtensions;

public static class NhLinqExtension
{
	private class InvokeInfo
	{
		internal static object LQTrDe8CV1r50uXNyP7g;

		public Type[] GenericArguments
		{
			[CompilerGenerated]
			get
			{
				return _003CGenericArguments_003Ek__BackingField;
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
						_003CGenericArguments_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public object[] Parameters
		{
			[CompilerGenerated]
			get
			{
				return _003CParameters_003Ek__BackingField;
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
					case 1:
						_003CParameters_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public string MethodName
		{
			[CompilerGenerated]
			get
			{
				return _003CMethodName_003Ek__BackingField;
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
						_003CMethodName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public InvokeInfo()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			A6nrbc8CRWlcA5bVl7oo();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool bSJn6W8CSPt5udBrWrwL()
		{
			return LQTrDe8CV1r50uXNyP7g == null;
		}

		internal static InvokeInfo Me5In18CiZyueGxBpM1t()
		{
			return (InvokeInfo)LQTrDe8CV1r50uXNyP7g;
		}

		internal static void A6nrbc8CRWlcA5bVl7oo()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	internal static NhLinqExtension xR2uGCGmBkFrTYr1SBjY;

	private static Dictionary<string, MethodInfo> FetchMethodInfo { get; set; }

	public static IQueryable<TOriginating> Fetch<TOriginating>(this IQueryable<TOriginating> query, string relatedObjectSelector)
	{
		return query.ApplyFetch(relatedObjectSelector);
	}

	public static IQueryable<TOriginating> SetupFetchOptions<TOriginating>(this IQueryable<TOriginating> query, FetchOptions fetchOptions)
	{
		if (fetchOptions == null)
		{
			return query;
		}
		if (fetchOptions.FetchRelations != null && fetchOptions.FetchRelations.Any())
		{
			foreach (string fetchRelation in fetchOptions.FetchRelations)
			{
				query = query.Fetch(fetchRelation);
			}
		}
		query = SetupSortOptionsLinq(query, fetchOptions);
		if (fetchOptions.FirstResult > 0)
		{
			query = query.Skip(fetchOptions.FirstResult);
		}
		if (fetchOptions.MaxResults > 0)
		{
			query = query.Take(fetchOptions.MaxResults);
		}
		return query;
	}

	private static IQueryable<TOriginating> SetupSortOptionsLinq<TOriginating>(IQueryable<TOriginating> query, object fetchOptions)
	{
		IEnumerable<string> enumerable;
		if (string.IsNullOrEmpty(((FetchOptions)fetchOptions).SortExpression))
		{
			enumerable = Enumerable.Empty<string>();
		}
		else
		{
			IEnumerable<string> enumerable2 = ((FetchOptions)fetchOptions).SortExpression.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			enumerable = enumerable2;
		}
		foreach (string item in enumerable)
		{
			string ordering = AddOrderIfNeeded(item, ((FetchOptions)fetchOptions).SortDirection);
			query = query.OrderBy(ordering);
		}
		return query;
	}

	private static string AddOrderIfNeeded(object sortExpression, ListSortDirection sortDirection)
	{
		//Discarded unreachable code: IL_003d, IL_004c, IL_005c, IL_006b, IL_011e
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 3:
				return (string)qeYKGYGmGMMRcp8ZhvMD(sortExpression, text);
			default:
				return (string)sortExpression;
			case 6:
				if (sortDirection != 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				obj = JiG9NJGmbc2uZacRBbd3(-1767720453 ^ -1767770139);
				break;
			case 1:
				if (GJG6UJGmh45kciBQBZj2(sortExpression, JiG9NJGmbc2uZacRBbd3(0x66F566B6 ^ 0x66F628A6), StringComparison.OrdinalIgnoreCase))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 2;
			case 2:
				if (!GJG6UJGmh45kciBQBZj2(sortExpression, JiG9NJGmbc2uZacRBbd3(-3333094 ^ -3249660), StringComparison.OrdinalIgnoreCase))
				{
					num2 = 6;
					continue;
				}
				goto default;
			case 4:
				obj = JiG9NJGmbc2uZacRBbd3(-951514650 ^ -951433226);
				break;
			}
			text = (string)obj;
			num2 = 3;
		}
	}

	private static IQueryable<T> ApplyFetch<T>(this IQueryable<T> source, object property)
	{
		Type typeFromHandle = typeof(T);
		Type type = typeFromHandle;
		InvokeInfo invokeInfo = new InvokeInfo();
		int num = 0;
		IQueryable queryable = source;
		string[] array = ((string)property).Split(new char[1] { '.' });
		foreach (string text in array)
		{
			PropertyInfo property2 = GetProperty(type, text);
			List<Type> list;
			if (num == 0)
			{
				invokeInfo.MethodName = string.Empty;
				list = new List<Type> { type };
			}
			else
			{
				invokeInfo.MethodName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6A56ED);
				list = new List<Type> { typeFromHandle, type };
			}
			bool? flag = CheckRelation(type, text);
			if (!flag.HasValue)
			{
				break;
			}
			Type type2;
			Type resultType;
			if (flag.Value)
			{
				invokeInfo.MethodName += z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x74192F0);
				type2 = property2.PropertyType;
				resultType = type2;
			}
			else
			{
				invokeInfo.MethodName += z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC54AB0);
				type2 = property2.PropertyType.GetGenericArguments()[0];
				resultType = typeof(IEnumerable<>).MakeGenericType(type2);
			}
			list.Add(type2);
			invokeInfo.GenericArguments = list.ToArray();
			LambdaExpression lambda = GetLambda(type, resultType, property2);
			invokeInfo.Parameters = new object[2] { queryable, lambda };
			queryable = ApplyFetchMethod(invokeInfo);
			type = type2;
			num++;
		}
		return (IQueryable<T>)queryable;
	}

	private static IQueryable ApplyFetchMethod(object invokeInfo)
	{
		return (IQueryable)cWGuOuGmvZZdIvufbfB1(H3tggZGmQy2PJMblHjE2(MnGKrBGmErOtl379l6PN(invokeInfo), CoPA0IGmfgAWwB54xT4t(invokeInfo)), null, zBwYlpGmCb9M3gOgLBgb(invokeInfo));
	}

	private static bool? CheckRelation(Type type, object property)
	{
		_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_0();
		CS_0024_003C_003E8__locals0.property = (string)property;
		PropertyMetadata propertyMetadata = (MetadataLoader.LoadMetadata(type) as EntityMetadata).Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec__DisplayClass15_0.Dm0WRU8CntmSvjZARPVY(_003C_003Ec__DisplayClass15_0.m6Jbj18CkLSoD2npU1ao(p), CS_0024_003C_003E8__locals0.property));
		if (propertyMetadata == null || propertyMetadata.SubTypeUid == Guid.Empty)
		{
			return null;
		}
		if (!(propertyMetadata.Settings is EntitySettings entitySettings))
		{
			return null;
		}
		CacheEntityAttribute attribute = AttributeHelper<CacheEntityAttribute>.GetAttribute(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(propertyMetadata.SubTypeUid), inherited: true);
		if (attribute != null && attribute.Enabled)
		{
			return null;
		}
		return entitySettings.RelationType == RelationType.OneToOne;
	}

	private static PropertyInfo GetProperty(Type type, object propName)
	{
		//Discarded unreachable code: IL_003d, IL_004c, IL_005d, IL_0067, IL_00e1, IL_0136, IL_016e
		int num = 3;
		int num2 = num;
		IEnumerator<Type> enumerator = default(IEnumerator<Type>);
		PropertyInfo propertyCached = default(PropertyInfo);
		PropertyInfo result = default(PropertyInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				try
				{
					while (true)
					{
						IL_008d:
						int num3;
						if (!ldtXj1GmuMqCj6AWkAta(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
							{
								num3 = 0;
							}
							goto IL_006b;
						}
						goto IL_00b3;
						IL_00b3:
						propertyCached = enumerator.Current.GetPropertyCached((string)propName);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num3 = 0;
						}
						goto IL_006b;
						IL_006b:
						while (true)
						{
							switch (num3)
							{
							case 4:
								goto IL_008d;
							case 5:
								goto IL_00b3;
							case 3:
								result = propertyCached;
								num3 = 2;
								continue;
							case 1:
								if (propertyCached != null)
								{
									num3 = 3;
									continue;
								}
								goto IL_008d;
							case 0:
								break;
							case 2:
								return result;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								xN2rJpGmIIEGDVfeBl0t(enumerator);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
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
				goto case 6;
			case 4:
				if (ikC0s1GmZS5b3O8rIoPg(propertyCached, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 1;
					}
					break;
				}
				enumerator = type.SelfAndBaseTypes().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (!Nmra8eGm8JEPxJOjQpeJ(type, null))
				{
					num2 = 2;
					break;
				}
				goto case 5;
			case 5:
				return null;
			case 2:
				propertyCached = type.GetPropertyCached((string)propName);
				num2 = 4;
				break;
			case 6:
				return null;
			case 1:
				return propertyCached;
			}
		}
	}

	private static LambdaExpression GetLambda(Type sourceType, Type resultType, object pi)
	{
		int num = 1;
		int num2 = num;
		Expression body = default(Expression);
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			switch (num2)
			{
			default:
				body = (Expression)D6sxYCGmSdavfdTgIxv0(parameterExpression, pi);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return Expression.Lambda(typeof(Func<, >).MakeGenericType(sourceType, resultType), body, parameterExpression);
			case 1:
				parameterExpression = (ParameterExpression)GWOfwoGmVKPkQauyuyj4(sourceType, JiG9NJGmbc2uZacRBbd3(0x4785BC0D ^ 0x47879D3D));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static MethodInfo GetFetchMethodInfo(object invokeInfo)
	{
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = default(_003C_003Ec__DisplayClass18_0);
		string key = default(string);
		MethodInfo value = default(MethodInfo);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass18_.invokeInfo = (InvokeInfo)invokeInfo;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				key = (string)TFGP54GmiFPbDebEOhuP(_003C_003Ec__DisplayClass18_.invokeInfo);
				num2 = 6;
				break;
			case 4:
				_003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 3;
				}
				break;
			case 6:
				if (!FetchMethodInfo.TryGetValue(key, out value))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			case 5:
				return value;
			case 2:
				FetchMethodInfo.Add(key, value);
				num2 = 5;
				break;
			case 1:
				value = jWPx4XGmRPLBDJIhtRUQ(typeof(EagerFetchingExtensionMethods).TypeHandle).GetMethods().Single(_003C_003Ec__DisplayClass18_._003CGetFetchMethodInfo_003Eb__0);
				num2 = 2;
				break;
			}
		}
	}

	private static string GetMethodKey(object invokeInfo)
	{
		return string.Format((string)JiG9NJGmbc2uZacRBbd3(0x3A6135BE ^ 0x3A6538A8), Xq3UBEGmqAUULs9yA3uU(invokeInfo), ((Array)zBwYlpGmCb9M3gOgLBgb(invokeInfo)).Length, ((InvokeInfo)invokeInfo).GenericArguments.Length);
	}

	internal static object JiG9NJGmbc2uZacRBbd3(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool GJG6UJGmh45kciBQBZj2(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).EndsWith((string)P_1, P_2);
	}

	internal static object qeYKGYGmGMMRcp8ZhvMD(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool R6Lk14GmWvqo5poTeobe()
	{
		return xR2uGCGmBkFrTYr1SBjY == null;
	}

	internal static NhLinqExtension BdxQ8eGmo6iLeJCH6Vus()
	{
		return xR2uGCGmBkFrTYr1SBjY;
	}

	internal static object MnGKrBGmErOtl379l6PN(object P_0)
	{
		return GetFetchMethodInfo(P_0);
	}

	internal static object CoPA0IGmfgAWwB54xT4t(object P_0)
	{
		return ((InvokeInfo)P_0).GenericArguments;
	}

	internal static object H3tggZGmQy2PJMblHjE2(object P_0, object P_1)
	{
		return ((MethodInfo)P_0).MakeGenericMethod((Type[])P_1);
	}

	internal static object zBwYlpGmCb9M3gOgLBgb(object P_0)
	{
		return ((InvokeInfo)P_0).Parameters;
	}

	internal static object cWGuOuGmvZZdIvufbfB1(object P_0, object P_1, object P_2)
	{
		return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
	}

	internal static bool Nmra8eGm8JEPxJOjQpeJ(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool ikC0s1GmZS5b3O8rIoPg(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static bool ldtXj1GmuMqCj6AWkAta(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void xN2rJpGmIIEGDVfeBl0t(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object GWOfwoGmVKPkQauyuyj4(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object D6sxYCGmSdavfdTgIxv0(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (PropertyInfo)P_1);
	}

	internal static object TFGP54GmiFPbDebEOhuP(object P_0)
	{
		return GetMethodKey(P_0);
	}

	internal static Type jWPx4XGmRPLBDJIhtRUQ(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Xq3UBEGmqAUULs9yA3uU(object P_0)
	{
		return ((InvokeInfo)P_0).MethodName;
	}
}
