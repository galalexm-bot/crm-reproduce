using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FullTextSearch.Descriptors;

public class StringPropertyDescriptor : FullTextPropertyDescriptor
{
	internal static StringPropertyDescriptor Wi7Q95GuV37ADXK74hYF;

	public override bool IsSupportedFullTextSearchInIndex => true;

	public StringPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		hpdOMKGuReJbWaRlJk66();
		base._002Ector(typeDescriptor);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public static string ConvertToSortable(object obj)
	{
		//Discarded unreachable code: IL_0049, IL_0078, IL_010f, IL_011e, IL_0129, IL_01d0, IL_0208
		int num = 1;
		int num2 = num;
		IEnumerator<char> enumerator = default(IEnumerator<char>);
		string text2 = default(string);
		string text = default(string);
		char current = default(char);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (obj != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 9:
				enumerator = ((IEnumerable<char>)LWGYISGuKpnOv9duJuUe(text2)).Where(char.IsLetterOrDigit).Take(50).GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 8;
				}
				break;
			case 7:
				return text;
			case 6:
				text = (string)gpjsjyGuXJVnNBqVEPjF(text, hpVe5GGunx2A196kWAM6(0x5DD55050 ^ 0x5DD54FDC));
				num2 = 7;
				break;
			case 2:
				if (text2 != null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 5;
			case 8:
				try
				{
					while (true)
					{
						IL_016a:
						int num3;
						if (!KQaPgYGuTs6NupInWWE6(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
							{
								num3 = 0;
							}
							goto IL_012d;
						}
						goto IL_0147;
						IL_0147:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num3 = 2;
						}
						goto IL_012d;
						IL_012d:
						while (true)
						{
							switch (num3)
							{
							case 1:
								goto IL_0147;
							case 3:
								goto IL_016a;
							case 2:
								text = (string)gpjsjyGuXJVnNBqVEPjF(text, current.ToString());
								num3 = 3;
								continue;
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
					if (enumerator != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								osP3xZGuk3hb9qPfXIDK(enumerator);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
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
				goto case 6;
			case 3:
				return string.Empty;
			default:
				text2 = (string)oigbtmGuqMG72uxrWcMl(obj);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				return string.Empty;
			case 4:
				text = string.Empty;
				num2 = 9;
				break;
			}
		}
	}

	public override FieldIndexList GetMappingField(IPropertyMetadata propMd)
	{
		return new FieldIndexList
		{
			new FieldIndexListItem(ValueFieldName(propMd), null, FullTextFieldType.String, FullTextFieldTag.Value),
			new FieldIndexListItem(SortFieldName(propMd), null, FullTextFieldType.String, FullTextFieldTag.Sort)
		};
	}

	public override FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd, bool reindex)
	{
		//Discarded unreachable code: IL_004d, IL_005c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (propMd != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return new FieldIndexList();
			default:
				return new FieldIndexList
				{
					new FieldIndexListItem(ValueFieldName(propMd), oigbtmGuqMG72uxrWcMl(obj), FullTextFieldType.String),
					new FieldIndexListItem(SortFieldName(propMd), D5g1j4GuOjZEw7SLMWiG(obj), FullTextFieldType.String)
				};
			}
		}
	}

	public override FieldListItem GetSearchField(object value, IPropertyMetadata propMd)
	{
		return new FieldListItem(ValueFieldName(propMd), (value == null) ? string.Empty : value.ToString());
	}

	public override SortListItem GetSortField(IPropertyMetadata propMd)
	{
		return new SortListItem(SortFieldName(propMd), FullTextFieldType.String);
	}

	public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_007c, IL_008b, IL_00d0, IL_0103, IL_015a, IL_0169, IL_0178
		int num = 5;
		PropertyInfo propertyCached = default(PropertyInfo);
		WebDataItem webDataItem = default(WebDataItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 11:
					if (BYUfuCGuev6yyG6Z62F0(propertyCached, null))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 10;
				case 4:
					return;
				case 0:
					return;
				case 6:
					return;
				case 12:
					try
					{
						yQsQ6KGuNbLkLMHRFhiw(propertyCached, obj, S3yAVxGu1PWDmDetRFGG(webDataItem), null);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
						return;
					}
					catch (Exception exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								return;
							}
							((ILogger)SfRgcMGu38WOdEXRY164()).Warn(hpVe5GGunx2A196kWAM6(-1123633026 ^ -1123716458), exception);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
							{
								num4 = 1;
							}
						}
					}
				case 2:
					if (propMd != null)
					{
						num2 = 3;
						continue;
					}
					return;
				case 10:
					if (webDataItem == null)
					{
						return;
					}
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 7;
					}
					continue;
				case 5:
					if (obj == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 2;
				case 1:
					return;
				case 3:
					propertyCached = obj.GetType().GetPropertyCached((string)bJUkOhGu2KyZY8lC5lDa(propMd));
					num2 = 8;
					continue;
				case 9:
					return;
				case 7:
					break;
				case 8:
					webDataItem = value as WebDataItem;
					num2 = 11;
					continue;
				}
				break;
			}
			num = (LB69uIGuPi9rAkkkD59T(webDataItem.Name, ValueFieldName(propMd)) ? 6 : 12);
		}
	}

	public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
	{
		//Discarded unreachable code: IL_005d, IL_00c4, IL_00e8, IL_010d, IL_01e6, IL_01f5, IL_0220, IL_0237
		int num = 6;
		int num2 = num;
		PropertyInfo propertyCached = default(PropertyInfo);
		object value = default(object);
		object value2 = default(object);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return;
			case 11:
				return;
			case 4:
				num2 = 10;
				break;
			default:
				if (LB69uIGuPi9rAkkkD59T(fieldName, ValueFieldName(propMd)))
				{
					num2 = 7;
					break;
				}
				goto case 8;
			case 6:
				if (obj != null)
				{
					num2 = 5;
					break;
				}
				return;
			case 1:
				if (BYUfuCGuev6yyG6Z62F0(propertyCached, null))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				if (!(propMd is PropertyMetadata))
				{
					return;
				}
				num2 = 4;
				break;
			case 10:
				try
				{
					int num3;
					if (hmBal4GupL4RNsoI5TUS(propMd as PropertyMetadata))
					{
						num3 = 2;
						goto IL_0111;
					}
					goto IL_01af;
					IL_0111:
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 4:
							value = base.TypeDescriptor.DeserializeSimple(value2, UJDj7aGuajYt8vUot9rw(typeof(string).TypeHandle));
							num3 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							yQsQ6KGuNbLkLMHRFhiw(propertyCached, obj, null, null);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
							{
								num3 = 1;
							}
							continue;
						case 5:
							propertyCached.SetValue(obj, value, null);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
							{
								num3 = 0;
							}
							continue;
						case 3:
							break;
						case 1:
							return;
						case 0:
							return;
						}
						break;
					}
					goto IL_01af;
					IL_01af:
					value2 = base.TypeDescriptor.SerializeSimple(null, UJDj7aGuajYt8vUot9rw(typeof(string).TypeHandle));
					num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num3 = 4;
					}
					goto IL_0111;
				}
				catch (Exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
					return;
				}
			case 5:
				if (propMd != null)
				{
					num2 = 2;
					break;
				}
				return;
			case 3:
				return;
			case 2:
				propertyCached = obj.GetType().GetPropertyCached(propMd.Name);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				return;
			}
		}
	}

	internal static void hpdOMKGuReJbWaRlJk66()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool joNNQOGuSB9AX0HCnJ6W()
	{
		return Wi7Q95GuV37ADXK74hYF == null;
	}

	internal static StringPropertyDescriptor yf5afHGuifrKrXaJg4in()
	{
		return Wi7Q95GuV37ADXK74hYF;
	}

	internal static object oigbtmGuqMG72uxrWcMl(object P_0)
	{
		return Convert.ToString(P_0);
	}

	internal static object LWGYISGuKpnOv9duJuUe(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static object gpjsjyGuXJVnNBqVEPjF(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool KQaPgYGuTs6NupInWWE6(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void osP3xZGuk3hb9qPfXIDK(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object hpVe5GGunx2A196kWAM6(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object D5g1j4GuOjZEw7SLMWiG(object P_0)
	{
		return ConvertToSortable(P_0);
	}

	internal static object bJUkOhGu2KyZY8lC5lDa(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static bool BYUfuCGuev6yyG6Z62F0(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static bool LB69uIGuPi9rAkkkD59T(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object S3yAVxGu1PWDmDetRFGG(object P_0)
	{
		return ((WebDataItem)P_0).Value;
	}

	internal static void yQsQ6KGuNbLkLMHRFhiw(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static object SfRgcMGu38WOdEXRY164()
	{
		return Logger.Log;
	}

	internal static bool hmBal4GupL4RNsoI5TUS(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static Type UJDj7aGuajYt8vUot9rw(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
