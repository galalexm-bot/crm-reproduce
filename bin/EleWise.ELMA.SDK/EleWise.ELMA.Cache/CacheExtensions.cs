using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using EleWise.ELMA.Cache.Modules;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Cache;

public static class CacheExtensions
{
	private static CacheExtensions qlS8w0fqSxDmmqb0nLXP;

	public static T GetOrAdd<T>(this IMemoryCacheService cache, string key, Func<T> factory)
	{
		if (!cache.TryGetValue<T>(key, out var result))
		{
			result = factory();
			cache.Insert(key, result);
		}
		return result;
	}

	public static T GetOrAdd<T>(this IMemoryCacheService cache, string key, Func<T> factory, TimeSpan cacheDuration)
	{
		if (!cache.TryGetValue<T>(key, out var result))
		{
			result = factory();
			cache.Insert(key, result, cacheDuration);
		}
		return result;
	}

	public static T GetOrAdd<T>(this ICacheService cache, string key, Func<T> factory)
	{
		if (!cache.TryGetValue<T>(key, out var value))
		{
			value = factory();
			cache.Insert(key, value);
		}
		return value;
	}

	public static T GetOrAdd<T>(this ICacheService cache, string key, Func<T> factory, TimeSpan cacheDuration)
	{
		if (!cache.TryGetValue<T>(key, out var value))
		{
			value = factory();
			cache.Insert(key, value, cacheDuration);
		}
		return value;
	}

	public static T GetOrAdd<T>(this ICacheService cache, string key, Func<T> factory, string region)
	{
		if (!cache.TryGetValue<T>(key, region, out var value))
		{
			value = factory();
			cache.Insert(key, value, region);
		}
		return value;
	}

	public static T GetOrAdd<T>(this ICacheService cache, string key, Func<T> factory, string region, TimeSpan cacheDuration)
	{
		if (!cache.TryGetValue<T>(key, region, out var value))
		{
			value = factory();
			cache.Insert(key, value, region, cacheDuration);
		}
		return value;
	}

	public static void ClearFor<TResult>(this ICacheService cacheService, Func<TResult> func)
	{
		cacheService.ClearFor(func.Method);
	}

	public static void ClearFor<T, TResult>(this ICacheService cacheService, Func<T, TResult> func)
	{
		cacheService.ClearFor(func.Method);
	}

	public static void ClearFor<T1, T2, TResult>(this ICacheService cacheService, Func<T1, T2, TResult> func)
	{
		cacheService.ClearFor(func.Method);
	}

	public static void ClearFor<T1, T2, T3, TResult>(this ICacheService cacheService, Func<T1, T2, T3, TResult> func)
	{
		cacheService.ClearFor(func.Method);
	}

	public static void ClearFor(this ICacheService cacheService, MethodInfo method)
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
				CacheInterceptor.ClearRegion(cacheService, method.GetCacheRegion());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void ClearFor<TResult>(this IComplexCacheService complexCacheService, Func<TResult> func)
	{
		complexCacheService.ClearFor(func.Method);
	}

	public static void ClearFor<T, TResult>(this IComplexCacheService complexCacheService, Func<T, TResult> func)
	{
		complexCacheService.ClearFor(func.Method);
	}

	public static void ClearFor<T1, T2, TResult>(this IComplexCacheService complexCacheService, Func<T1, T2, TResult> func)
	{
		complexCacheService.ClearFor(func.Method);
	}

	public static void ClearFor<T1, T2, T3, TResult>(this IComplexCacheService complexCacheService, Func<T1, T2, T3, TResult> func)
	{
		complexCacheService.ClearFor(func.Method);
	}

	public static void ClearFor(this IComplexCacheService complexCacheService, MethodInfo method)
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
				U1G1oCfqKct4nd3IKXMV(complexCacheService, EAEr5ufqqIdk9YkdZTCM(method));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static string GetCacheRegion(this MethodInfo method)
	{
		return (string)RX205vfqXdlhGX8uEuvB(method, method.DeclaringType);
	}

	internal static string GetCacheRegion(this MethodInfo method, Type targetType)
	{
		//Discarded unreachable code: IL_0071, IL_0080, IL_0117, IL_02e5, IL_02f4
		int num = 4;
		int num3 = default(int);
		ParameterInfo[] array = default(ParameterInfo[]);
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
				case 19:
					if (num3 < array.Length)
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 15;
				case 3:
					Jjq71nfqkvmDjQ1vSQyq(stringBuilder, SyoNBWfqTOL07IHxfY3E(-629844702 ^ -630188310));
					num2 = 12;
					continue;
				default:
					num3 = 0;
					num2 = 19;
					continue;
				case 1:
					return stringBuilder.ToString();
				case 13:
				case 17:
					Jjq71nfqkvmDjQ1vSQyq(stringBuilder, sKhZBNfq2MCOKOOEWhy2(array[num3]).FullName);
					num = 2;
					break;
				case 2:
					Jjq71nfqkvmDjQ1vSQyq(stringBuilder, SyoNBWfqTOL07IHxfY3E(0x571EA399 ^ 0x571EEABB));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
					{
						num2 = 8;
					}
					continue;
				case 8:
					Jjq71nfqkvmDjQ1vSQyq(stringBuilder, array[num3].Name);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 5;
					}
					continue;
				case 4:
					stringBuilder = new StringBuilder();
					num2 = 3;
					continue;
				case 15:
					Jjq71nfqkvmDjQ1vSQyq(stringBuilder, SyoNBWfqTOL07IHxfY3E(0x42643203 ^ 0x42642DBF));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 1;
					}
					continue;
				case 14:
					array = (ParameterInfo[])iBsfDGfqOP5h0Ou3pBHU(method);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					stringBuilder.Append((string)SyoNBWfqTOL07IHxfY3E(0x571EA399 ^ 0x571EBC2F));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 14;
					}
					continue;
				case 9:
					Jjq71nfqkvmDjQ1vSQyq(stringBuilder, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA55AF8));
					num2 = 18;
					continue;
				case 10:
					Jjq71nfqkvmDjQ1vSQyq(stringBuilder, SyoNBWfqTOL07IHxfY3E(-1317790512 ^ -1317779444));
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 4;
					}
					continue;
				case 11:
				case 16:
					num3++;
					num2 = 7;
					continue;
				case 18:
					stringBuilder.Append((string)gWqPvvfqnNhKERDVarVN(method));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 2;
					}
					continue;
				case 12:
					stringBuilder.Append(targetType);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 9;
					}
					continue;
				case 5:
					if (num3 >= array.Length - 1)
					{
						num = 11;
						break;
					}
					goto case 10;
				}
				break;
			}
		}
	}

	internal static string GetCacheKey(this MethodInfo method, Type targetType, object[] arguments)
	{
		//Discarded unreachable code: IL_00a1, IL_00b0, IL_0237, IL_0246
		int num = 11;
		int num2 = num;
		int num3 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		ParameterInfo[] parameters = default(ParameterInfo[]);
		object value = default(object);
		while (true)
		{
			switch (num2)
			{
			case 2:
				num3 = 0;
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				oXNQLpfqeDFoPb3D26W3(stringBuilder, targetType);
				num2 = 8;
				break;
			case 12:
			case 16:
				num3++;
				num2 = 15;
				break;
			case 11:
				stringBuilder = new StringBuilder();
				num2 = 10;
				break;
			case 7:
				Jjq71nfqkvmDjQ1vSQyq(stringBuilder, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35987857));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				return stringBuilder.ToString();
			case 8:
				stringBuilder.Append((string)SyoNBWfqTOL07IHxfY3E(0x1637C429 ^ 0x1637DEED));
				num2 = 3;
				break;
			default:
				stringBuilder.Append((string)yvk1EffqPebybMlGLvBr(parameters[num3]));
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 4;
				}
				break;
			case 14:
				parameters = method.GetParameters();
				num2 = 2;
				break;
			case 18:
				if (num3 >= parameters.Length - 1)
				{
					num2 = 16;
					break;
				}
				goto case 6;
			case 6:
				stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C012A7));
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 4;
				}
				break;
			case 19:
				Jjq71nfqkvmDjQ1vSQyq(stringBuilder, PrepareForCacheKeyValue(value, sKhZBNfq2MCOKOOEWhy2(parameters[num3])));
				num2 = 18;
				break;
			case 3:
				Jjq71nfqkvmDjQ1vSQyq(stringBuilder, gWqPvvfqnNhKERDVarVN(method));
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 3;
				}
				break;
			case 9:
				Jjq71nfqkvmDjQ1vSQyq(stringBuilder, SyoNBWfqTOL07IHxfY3E(0x1C9495B4 ^ 0x1C948A02));
				num2 = 14;
				break;
			case 13:
			case 15:
				if (num3 >= parameters.Length)
				{
					num2 = 7;
					break;
				}
				goto default;
			case 10:
				Jjq71nfqkvmDjQ1vSQyq(stringBuilder, SyoNBWfqTOL07IHxfY3E(0x463A0F3C ^ 0x463F4CF4));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 1;
				}
				break;
			case 17:
				value = arguments[num3];
				num2 = 19;
				break;
			case 4:
				Jjq71nfqkvmDjQ1vSQyq(stringBuilder, SyoNBWfqTOL07IHxfY3E(0x35C0467B ^ 0x35C11739));
				num2 = 17;
				break;
			}
		}
	}

	private static string PrepareForCacheKeyValue(object value, Type parameterType)
	{
		//Discarded unreachable code: IL_00d2, IL_00e1, IL_0144, IL_0153, IL_0218, IL_0227, IL_024c, IL_025b, IL_02e6, IL_02f5, IL_0300, IL_03a9, IL_03f6, IL_0405
		int num = 17;
		object obj = default(object);
		IIdentified identified = default(IIdentified);
		ReferenceOnEntityType referenceOnEntityType = default(ReferenceOnEntityType);
		Guid guid = default(Guid);
		Type @interface = default(Type);
		IEnumerator enumerator = default(IEnumerator);
		Type parameterType2 = default(Type);
		object value2 = default(object);
		List<string> list = default(List<string>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 25:
					if (obj == null)
					{
						num2 = 24;
						break;
					}
					return (string)SbU4f0fq4Sj0J8Pm1K5M(identified.GetType().FullName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87339341), obj);
				case 17:
					if (value != null)
					{
						goto end_IL_0012;
					}
					goto default;
				case 14:
					if (referenceOnEntityType == null)
					{
						num2 = 2;
						break;
					}
					goto case 5;
				case 5:
					guid = AWD7LOfqtI75sg8M0vna(referenceOnEntityType);
					num2 = 10;
					break;
				case 23:
					if (identified == null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 13;
				case 4:
					referenceOnEntityType = value as ReferenceOnEntityType;
					num2 = 14;
					break;
				case 10:
					return guid.ToString();
				case 2:
					identified = value as IIdentified;
					num2 = 23;
					break;
				case 19:
					@interface = parameterType.GetInterface((string)gWqPvvfqnNhKERDVarVN(sZMXInfq1TJrgFEuamsj(typeof(IEnumerable<>).TypeHandle)));
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 5;
					}
					break;
				case 3:
					enumerator = (IEnumerator)vVU3oSfqpJ2PMZASWFvK((IEnumerable)value);
					num2 = 11;
					break;
				case 24:
					return identified.GetType().FullName;
				case 7:
					return value.GetType().FullName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x2026008B) + value.GetHashCode();
				case 1:
					if (!parameterType.IsGenericType)
					{
						num2 = 8;
						break;
					}
					goto case 19;
				case 22:
					if (KvTOIrfq3iaYvNS727kn(@interface, null))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num2 = 6;
						}
						break;
					}
					goto case 8;
				default:
					return "";
				case 16:
					if (!parameterType.IsPrimitive)
					{
						num2 = 15;
						break;
					}
					goto case 12;
				case 13:
					obj = cgTrktfqww8Wj6qWQXgO(identified);
					num2 = 25;
					break;
				case 9:
					parameterType2 = @interface.GetGenericArguments()[0];
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 4;
					}
					break;
				case 11:
					try
					{
						while (true)
						{
							IL_0338:
							int num3;
							if (!jXkZt8fqDZQL1SbWixDx(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
								{
									num3 = 0;
								}
								goto IL_0304;
							}
							goto IL_035e;
							IL_035e:
							value2 = XeZOC3fqaeFjhjCMdSaW(enumerator);
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
							{
								num3 = 0;
							}
							goto IL_0304;
							IL_0304:
							while (true)
							{
								switch (num3)
								{
								case 3:
									list.Add(PrepareForCacheKeyValue(value2, parameterType2));
									num3 = 2;
									continue;
								case 2:
									goto IL_0338;
								case 1:
									goto IL_035e;
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
						IDisposable disposable = enumerator as IDisposable;
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								if (disposable != null)
								{
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
									{
										num4 = 0;
									}
									continue;
								}
								break;
							case 1:
								disposable.Dispose();
								num4 = 2;
								continue;
							case 2:
								break;
							}
							break;
						}
					}
					goto case 21;
				case 6:
					list = new List<string>();
					num2 = 3;
					break;
				case 15:
					if (L1FDYNfqNBhnVHwm6LCW(parameterType, sZMXInfq1TJrgFEuamsj(typeof(string).TypeHandle)))
					{
						num2 = 12;
						break;
					}
					if (!sZMXInfq1TJrgFEuamsj(typeof(IEnumerable).TypeHandle).IsAssignableFrom(parameterType))
					{
						num2 = 20;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
						{
							num2 = 11;
						}
						break;
					}
					goto case 1;
				case 18:
					if (!parameterType.IsInterface)
					{
						return value.ToString();
					}
					num2 = 4;
					break;
				case 21:
					return string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123620210), list);
				case 8:
				case 20:
					if (!parameterType.IsClass)
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
						{
							num2 = 18;
						}
						break;
					}
					goto case 4;
				case 12:
					return value.ToString();
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 16;
		}
	}

	internal static bool ePwioUfqiOQKmJMsIuP5()
	{
		return qlS8w0fqSxDmmqb0nLXP == null;
	}

	internal static CacheExtensions Py2kTCfqRWheq3dXhBPQ()
	{
		return qlS8w0fqSxDmmqb0nLXP;
	}

	internal static object EAEr5ufqqIdk9YkdZTCM(object P_0)
	{
		return ((MethodInfo)P_0).GetCacheRegion();
	}

	internal static void U1G1oCfqKct4nd3IKXMV(object P_0, object P_1)
	{
		ComplexCacheInterceptor.ClearRegion((IComplexCacheService)P_0, (string)P_1);
	}

	internal static object RX205vfqXdlhGX8uEuvB(object P_0, Type targetType)
	{
		return ((MethodInfo)P_0).GetCacheRegion(targetType);
	}

	internal static object SyoNBWfqTOL07IHxfY3E(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Jjq71nfqkvmDjQ1vSQyq(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static object gWqPvvfqnNhKERDVarVN(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object iBsfDGfqOP5h0Ou3pBHU(object P_0)
	{
		return ((MethodBase)P_0).GetParameters();
	}

	internal static Type sKhZBNfq2MCOKOOEWhy2(object P_0)
	{
		return ((ParameterInfo)P_0).ParameterType;
	}

	internal static object oXNQLpfqeDFoPb3D26W3(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	internal static object yvk1EffqPebybMlGLvBr(object P_0)
	{
		return ((ParameterInfo)P_0).Name;
	}

	internal static Type sZMXInfq1TJrgFEuamsj(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool L1FDYNfqNBhnVHwm6LCW(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool KvTOIrfq3iaYvNS727kn(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object vVU3oSfqpJ2PMZASWFvK(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static object XeZOC3fqaeFjhjCMdSaW(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static bool jXkZt8fqDZQL1SbWixDx(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static Guid AWD7LOfqtI75sg8M0vna(object P_0)
	{
		return ((ReferenceOnEntityType)P_0).TypeUid;
	}

	internal static object cgTrktfqww8Wj6qWQXgO(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static object SbU4f0fq4Sj0J8Pm1K5M(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}
}
