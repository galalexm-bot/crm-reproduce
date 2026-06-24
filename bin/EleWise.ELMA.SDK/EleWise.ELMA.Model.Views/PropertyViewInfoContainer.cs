using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Views;

public sealed class PropertyViewInfoContainer
{
	private readonly Dictionary<string, PropertyViewInfo> dict;

	internal static PropertyViewInfoContainer bkqI0koR8Ykmk1LeMVFV;

	public PropertyViewInfoContainer(ClassMetadata classMetadata)
	{
		//Discarded unreachable code: IL_002a, IL_0097, IL_00a6, IL_00d4, IL_00e3, IL_00ee, IL_01af, IL_01c2, IL_01d1, IL_022a, IL_0239, IL_0244, IL_02ff, IL_0337, IL_0346
		pHDpD1oRIbVvOCfbl64N();
		base._002Ector();
		int num = 4;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
		{
			num = 6;
		}
		List<PropertyMetadata>.Enumerator enumerator2 = default(List<PropertyMetadata>.Enumerator);
		IEnumerator<IPropertyMetadata> enumerator = default(IEnumerator<IPropertyMetadata>);
		ITablePartContainer tablePartContainer = default(ITablePartContainer);
		PropertyMetadata current2 = default(PropertyMetadata);
		IPropertyMetadata current = default(IPropertyMetadata);
		while (true)
		{
			switch (num)
			{
			case 4:
				return;
			case 5:
				return;
			case 3:
			{
				enumerator2 = classMetadata.Properties.GetEnumerator();
				int num6 = 8;
				num = num6;
				break;
			}
			case 7:
				dict = new Dictionary<string, PropertyViewInfo>();
				num = 3;
				break;
			case 1:
				enumerator = tablePartContainer.TableParts.OfType<IPropertyMetadata>().GetEnumerator();
				num = 2;
				break;
			case 8:
				try
				{
					while (true)
					{
						IL_015d:
						int num4;
						if (!enumerator2.MoveNext())
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
							{
								num4 = 1;
							}
							goto IL_00f2;
						}
						goto IL_014a;
						IL_014a:
						current2 = enumerator2.Current;
						num4 = 3;
						goto IL_00f2;
						IL_00f2:
						while (true)
						{
							switch (num4)
							{
							case 3:
							{
								Dictionary<string, PropertyViewInfo> dictionary2 = dict;
								object key = Vg0oGnoRitsDZ1dcpvqA(current2);
								PropertyViewInfo propertyViewInfo2 = new PropertyViewInfo();
								aGo3BZoRqERvvV5fJe7S(propertyViewInfo2, i0m7pkoRRPI3Fm0tjvvn(current2));
								dictionary2.Add((string)key, propertyViewInfo2);
								num4 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
								{
									num4 = 0;
								}
								continue;
							}
							case 2:
								goto IL_015d;
							case 1:
								goto end_IL_015d;
							}
							break;
						}
						goto IL_014a;
						continue;
						end_IL_015d:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto default;
			case 6:
				n9OWoloRSoqABV0eVopm(classMetadata, LkBWhIoRVHWuRLFQjXlX(0x5DD55050 ^ 0x5DD75EB4));
				num = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num = 4;
				}
				break;
			default:
				if ((tablePartContainer = classMetadata as ITablePartContainer) == null)
				{
					num = 4;
					break;
				}
				goto case 1;
			case 2:
				try
				{
					while (true)
					{
						int num2;
						if (!SdccUhoRKci0551xMVce(enumerator))
						{
							num2 = 2;
							goto IL_0248;
						}
						goto IL_0278;
						IL_0248:
						while (true)
						{
							switch (num2)
							{
							case 2:
								return;
							case 3:
								break;
							case 1:
								goto IL_0278;
							default:
							{
								Dictionary<string, PropertyViewInfo> dictionary = dict;
								string name = current.Name;
								PropertyViewInfo propertyViewInfo = new PropertyViewInfo();
								aGo3BZoRqERvvV5fJe7S(propertyViewInfo, current.PropertyUid);
								dictionary.Add(name, propertyViewInfo);
								num2 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
								{
									num2 = 3;
								}
								continue;
							}
							}
							break;
						}
						continue;
						IL_0278:
						current = enumerator.Current;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num2 = 0;
						}
						goto IL_0248;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								M2u0yloRXwbaPrhDQ9Ub(enumerator);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
								{
									num3 = 1;
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
	}

	public PropertyViewInfo Get(string name)
	{
		int num = 1;
		int num2 = num;
		PropertyViewInfo value = default(PropertyViewInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				return value;
			case 1:
				dict.TryGetValue(name, out value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ICollection<PropertyViewInfo> GetAll()
	{
		return dict.Values.ToList();
	}

	internal static void pHDpD1oRIbVvOCfbl64N()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object LkBWhIoRVHWuRLFQjXlX(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void n9OWoloRSoqABV0eVopm(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object Vg0oGnoRitsDZ1dcpvqA(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static Guid i0m7pkoRRPI3Fm0tjvvn(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void aGo3BZoRqERvvV5fJe7S(object P_0, Guid value)
	{
		((PropertyViewInfo)P_0).Uid = value;
	}

	internal static bool SdccUhoRKci0551xMVce(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void M2u0yloRXwbaPrhDQ9Ub(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool Xp3T8foRZ5Ei7AtFHcMr()
	{
		return bkqI0koR8Ykmk1LeMVFV == null;
	}

	internal static PropertyViewInfoContainer Eg4UWNoRu7mqlWaieghP()
	{
		return bkqI0koR8Ykmk1LeMVFV;
	}
}
