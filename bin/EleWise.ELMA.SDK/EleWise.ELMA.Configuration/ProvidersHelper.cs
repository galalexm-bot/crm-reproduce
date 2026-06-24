using System;
using System.Collections;
using System.Collections.Specialized;
using System.Configuration;
using System.Configuration.Provider;
using EleWise.ELMA.ComponentModel;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Configuration;

public static class ProvidersHelper
{
	private static ProvidersHelper kLSS99fWDBTQe2OYHRsN;

	public static ProviderBase InstantiateProvider(ProviderSettings providerSettings, Type providerType)
	{
		//Discarded unreachable code: IL_003e, IL_00c2, IL_00d1, IL_0109, IL_0113, IL_01c3, IL_0210, IL_022a, IL_033a, IL_0359, IL_03e4, IL_03f3
		int num = 2;
		int num2 = num;
		Type type = default(Type);
		NameValueCollection parameters = default(NameValueCollection);
		IEnumerator enumerator = default(IEnumerator);
		string text = default(string);
		NameValueCollection nameValueCollection = default(NameValueCollection);
		ProviderBase providerBase = default(ProviderBase);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					int num3;
					if (aDiFehfW4MZWhFDEZftB(providerSettings) != null)
					{
						num3 = 9;
						goto IL_0042;
					}
					object obj = null;
					goto IL_0276;
					IL_0276:
					if (G0IXtIfW66n5cymiQa5H(obj))
					{
						throw new ArgumentException(SR.T((string)GYsJaQfWHmqGG7lfdUfI(-951514650 ^ -951313584)));
					}
					type = uca59nfWAk2Txm2CQ8ne(obj, true, true);
					num3 = 4;
					goto IL_0042;
					IL_0042:
					while (true)
					{
						object obj2;
						switch (num3)
						{
						case 10:
							parameters = providerSettings.Parameters;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
							{
								num3 = 0;
							}
							continue;
						case 8:
							enumerator = parameters.GetEnumerator();
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
							{
								num3 = 1;
							}
							continue;
						case 4:
							if (providerType.IsAssignableFrom(type))
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
								{
									num3 = 3;
								}
								continue;
							}
							goto case 6;
						case 1:
							try
							{
								while (true)
								{
									int num4;
									if (!bJUE0OfW9GQcFfpe2K7s(enumerator))
									{
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
										{
											num4 = 1;
										}
										goto IL_0117;
									}
									goto IL_0173;
									IL_0173:
									text = (string)l0MjiqfWyr0dFcsWwn1B(enumerator);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
									{
										num4 = 0;
									}
									goto IL_0117;
									IL_0117:
									while (true)
									{
										switch (num4)
										{
										case 2:
											break;
										default:
											EHGeQjfWJ9QgpEEUvYG2(nameValueCollection, text, NCM1AffWMDAob1avkDtd(parameters, text));
											num4 = 2;
											continue;
										case 3:
											goto IL_0173;
										case 1:
											goto end_IL_0131;
										}
										break;
									}
									continue;
									end_IL_0131:
									break;
								}
							}
							finally
							{
								IDisposable disposable = enumerator as IDisposable;
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									default:
										if (disposable != null)
										{
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
											{
												num5 = 1;
											}
											continue;
										}
										break;
									case 1:
										mFfqePfWd4jJkbo5c5pd(disposable);
										num5 = 2;
										continue;
									case 2:
										break;
									}
									break;
								}
							}
							goto case 7;
						case 9:
							break;
						default:
							nameValueCollection = new NameValueCollection(lya3yifW0uQsaKRRXDg2(parameters), (IEqualityComparer)TyK4eafWmNQDJqRHP52L());
							num3 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
							{
								num3 = 5;
							}
							continue;
						case 7:
							providerBase.Initialize((string)vmqbHtfWlLfSbPUUDInk(providerSettings), nameValueCollection);
							num3 = 5;
							continue;
						case 6:
							throw new ArgumentException(SR.T((string)GYsJaQfWHmqGG7lfdUfI(-1411196499 ^ -1410872487), providerType));
						case 3:
							obj2 = QpRsNVfWxLPx8LQbQdtT(eOm2yifW7uFC2TK33Su2(), type);
							if (obj2 != null)
							{
								goto IL_0308;
							}
							num3 = 2;
							continue;
						case 2:
							obj2 = Activator.CreateInstance(type);
							goto IL_0308;
						case 5:
							{
								return providerBase;
							}
							IL_0308:
							providerBase = (ProviderBase)obj2;
							num3 = 10;
							continue;
						}
						break;
					}
					obj = ((string)aDiFehfW4MZWhFDEZftB(providerSettings)).Trim();
					goto IL_0276;
				}
				catch (Exception ex)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						default:
							if (!(ex is ConfigurationException))
							{
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
								{
									num6 = 1;
								}
								break;
							}
							goto case 2;
						case 2:
							throw;
						case 1:
							throw new ConfigurationErrorsException((string)oT3o8MfWr8IvC2wrhe47(ex), ex, (string)u4u1udfWjbmbyr11p6Dn(Q27rvnfW5he1MdooTVVB(((ElementInformation)BUmmS5fWgTpJtGMRKS7O(providerSettings)).Properties, GYsJaQfWHmqGG7lfdUfI(-2099751081 ^ -2099750027))), llZtuTfWYNjYoxy3vlbS(Q27rvnfW5he1MdooTVVB(((ElementInformation)BUmmS5fWgTpJtGMRKS7O(providerSettings)).Properties, GYsJaQfWHmqGG7lfdUfI(0x1637C429 ^ 0x1637C80B))));
						}
					}
				}
			case 2:
				providerBase = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return providerBase;
			}
		}
	}

	public static void InstantiateProviders(ProviderSettingsCollection configProviders, ProviderCollection providers, Type providerType)
	{
		//Discarded unreachable code: IL_002f, IL_0039, IL_00e5, IL_0142, IL_0151
		int num = 2;
		int num2 = num;
		IEnumerator enumerator = default(IEnumerator);
		ProviderSettings providerSettings = default(ProviderSettings);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				try
				{
					while (true)
					{
						IL_006f:
						int num3;
						if (!bJUE0OfW9GQcFfpe2K7s(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
							{
								num3 = 0;
							}
							goto IL_003d;
						}
						goto IL_0057;
						IL_0057:
						providerSettings = (ProviderSettings)enumerator.Current;
						num3 = 2;
						goto IL_003d;
						IL_003d:
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 3:
								break;
							case 1:
								goto IL_006f;
							case 2:
								providers.Add((ProviderBase)GWIgJRfWU80O3v4V3nIq(providerSettings, providerType));
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
								{
									num3 = 1;
								}
								continue;
							}
							break;
						}
						goto IL_0057;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							disposable.Dispose();
							num4 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
							{
								num4 = 2;
							}
							continue;
						default:
							if (disposable != null)
							{
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
								{
									num4 = 0;
								}
								continue;
							}
							break;
						case 2:
							break;
						}
						break;
					}
				}
			case 2:
				enumerator = (IEnumerator)JH5FjtfWLTPKXqW7r6WT(configProviders);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static object aDiFehfW4MZWhFDEZftB(object P_0)
	{
		return ((ProviderSettings)P_0).Type;
	}

	internal static bool G0IXtIfW66n5cymiQa5H(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object GYsJaQfWHmqGG7lfdUfI(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type uca59nfWAk2Txm2CQ8ne(object P_0, bool P_1, bool P_2)
	{
		return Type.GetType((string)P_0, P_1, P_2);
	}

	internal static object eOm2yifW7uFC2TK33Su2()
	{
		return ComponentManager.Current;
	}

	internal static object QpRsNVfWxLPx8LQbQdtT(object P_0, Type type)
	{
		return ((ComponentManager)P_0).GetExtensionPointByType(type);
	}

	internal static int lya3yifW0uQsaKRRXDg2(object P_0)
	{
		return ((NameObjectCollectionBase)P_0).Count;
	}

	internal static object TyK4eafWmNQDJqRHP52L()
	{
		return StringComparer.Ordinal;
	}

	internal static object l0MjiqfWyr0dFcsWwn1B(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static object NCM1AffWMDAob1avkDtd(object P_0, object P_1)
	{
		return ((NameValueCollection)P_0)[(string)P_1];
	}

	internal static void EHGeQjfWJ9QgpEEUvYG2(object P_0, object P_1, object P_2)
	{
		((NameValueCollection)P_0)[(string)P_1] = (string)P_2;
	}

	internal static bool bJUE0OfW9GQcFfpe2K7s(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void mFfqePfWd4jJkbo5c5pd(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object vmqbHtfWlLfSbPUUDInk(object P_0)
	{
		return ((ProviderSettings)P_0).Name;
	}

	internal static object oT3o8MfWr8IvC2wrhe47(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object BUmmS5fWgTpJtGMRKS7O(object P_0)
	{
		return ((ConfigurationElement)P_0).ElementInformation;
	}

	internal static object Q27rvnfW5he1MdooTVVB(object P_0, object P_1)
	{
		return ((PropertyInformationCollection)P_0)[(string)P_1];
	}

	internal static object u4u1udfWjbmbyr11p6Dn(object P_0)
	{
		return ((PropertyInformation)P_0).Source;
	}

	internal static int llZtuTfWYNjYoxy3vlbS(object P_0)
	{
		return ((PropertyInformation)P_0).LineNumber;
	}

	internal static bool OXfaAMfWtjrYYlnlYdg4()
	{
		return kLSS99fWDBTQe2OYHRsN == null;
	}

	internal static ProvidersHelper P9JtR7fWwvmubtmQMBib()
	{
		return kLSS99fWDBTQe2OYHRsN;
	}

	internal static object JH5FjtfWLTPKXqW7r6WT(object P_0)
	{
		return ((ConfigurationElementCollection)P_0).GetEnumerator();
	}

	internal static object GWIgJRfWU80O3v4V3nIq(object P_0, Type providerType)
	{
		return InstantiateProvider((ProviderSettings)P_0, providerType);
	}
}
