using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.Dynamic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl;

public class NotificationGenerationData : IDynamicObject
{
	private Dictionary<string, object> namedObjects;

	private static NotificationGenerationData WlaI2ttpauCMg3aDgmA;

	public object this[string name]
	{
		get
		{
			return namedObjects[name];
		}
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
					namedObjects[name] = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public NotificationGenerationData(INotification notification)
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_008e, IL_00e5, IL_01a3, IL_01ad, IL_025d, IL_0295, IL_02b4, IL_02c3, IL_0334, IL_0343
		GR7tAJttxYq6jCmnkuM();
		namedObjects = new Dictionary<string, object>();
		base._002Ector();
		int num = 5;
		PropertyInfo propertyInfo = default(PropertyInfo);
		PropertyInfo[] properties = default(PropertyInfo[]);
		int num2 = default(int);
		IExtendedPropertiesContainer extendedPropertiesContainer = default(IExtendedPropertiesContainer);
		IEnumerator<KeyValuePair<string, object>> enumerator = default(IEnumerator<KeyValuePair<string, object>>);
		KeyValuePair<string, object> current = default(KeyValuePair<string, object>);
		while (true)
		{
			switch (num)
			{
			case 14:
				return;
			case 2:
				return;
			case 16:
				return;
			case 7:
				propertyInfo = properties[num2];
				num = 8;
				break;
			case 5:
				wUUx9vt4EC8LvSTVnij(notification, ujP3vJtwA4Edyr9qqSm(-195614443 ^ -195580133));
				num = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num = 8;
				}
				break;
			case 1:
				namedObjects[(string)GqtsV8tAhdadocNAarF(propertyInfo)] = propertyInfo.GetValue(notification, null);
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num = 2;
				}
				break;
			case 8:
				if (xbmpV7t6YOUv3fClEZE(propertyInfo))
				{
					num = 13;
					break;
				}
				goto case 4;
			case 13:
				if (((Array)RGki6StHvurkRk2Innt(propertyInfo)).Length != 0)
				{
					num = 18;
					break;
				}
				goto case 1;
			case 11:
				if (extendedPropertiesContainer.ExtendedProperties == null)
				{
					num = 16;
					break;
				}
				goto case 15;
			case 10:
			case 12:
				if (num2 >= properties.Length)
				{
					num = 17;
					break;
				}
				goto case 7;
			default:
				if (extendedPropertiesContainer == null)
				{
					num = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num = 11;
					}
					break;
				}
				goto case 11;
			case 6:
				try
				{
					while (true)
					{
						int num3;
						if (!oUmtTQt7KofjquAJ2h3(enumerator))
						{
							num3 = 3;
							goto IL_01b1;
						}
						goto IL_01e1;
						IL_01b1:
						while (true)
						{
							switch (num3)
							{
							case 3:
								return;
							case 1:
								break;
							case 2:
								goto IL_01e1;
							default:
								namedObjects[current.Key] = current.Value;
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							break;
						}
						continue;
						IL_01e1:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num3 = 0;
						}
						goto IL_01b1;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								ewAuXUtxttMZ3CyVUOH(enumerator);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
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
			case 4:
			case 18:
				num2++;
				num = 12;
				break;
			case 17:
				extendedPropertiesContainer = notification as IExtendedPropertiesContainer;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num = 0;
				}
				break;
			case 9:
				properties = notification.GetType().GetProperties();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num = 3;
				}
				break;
			case 15:
				enumerator = extendedPropertiesContainer.ExtendedProperties.GetEnumerator();
				num = 6;
				break;
			case 3:
				num2 = 0;
				num = 10;
				break;
			}
		}
	}

	public bool ContainsProperty(string name, bool ignoreCase = false)
	{
		return namedObjects.ContainsKey(name);
	}

	public object GetPropertyValue(string name, bool ignoreCase = false)
	{
		int num = 1;
		int num2 = num;
		object value = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				namedObjects.TryGetValue(name, out value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return value;
			}
		}
	}

	public void SetPropertyValue(string name, object value, bool ignoreCase = false)
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
				namedObjects[name] = value;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void GR7tAJttxYq6jCmnkuM()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object ujP3vJtwA4Edyr9qqSm(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void wUUx9vt4EC8LvSTVnij(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool xbmpV7t6YOUv3fClEZE(object P_0)
	{
		return ((PropertyInfo)P_0).CanRead;
	}

	internal static object RGki6StHvurkRk2Innt(object P_0)
	{
		return ((PropertyInfo)P_0).GetIndexParameters();
	}

	internal static object GqtsV8tAhdadocNAarF(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static bool oUmtTQt7KofjquAJ2h3(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void ewAuXUtxttMZ3CyVUOH(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool AlaWxxta1pSJnHLBG2d()
	{
		return WlaI2ttpauCMg3aDgmA == null;
	}

	internal static NotificationGenerationData FYK5HKtDR7wY0SWONYE()
	{
		return WlaI2ttpauCMg3aDgmA;
	}
}
