using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FullTextSearch.Descriptors;

public class BoolPropertyDescriptor : FullTextPropertyDescriptor
{
	internal static BoolPropertyDescriptor tumMgcGCcCdPw34dXulo;

	public BoolPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(typeDescriptor);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override FieldIndexList GetMappingField(IPropertyMetadata propMd)
	{
		return new FieldIndexList
		{
			new FieldIndexListItem(ValueFieldName(propMd), null, FullTextFieldType.String, FullTextFieldTag.Value)
		};
	}

	public override FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd, bool reindex)
	{
		//Discarded unreachable code: IL_004d, IL_005c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (propMd != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return new FieldIndexList();
			case 1:
				return new FieldIndexList
				{
					new FieldIndexListItem(ValueFieldName(propMd), (obj == null) ? "" : ii5bvYGvBNTSmuHZ3WRS(obj.ToString()), FullTextFieldType.String)
				};
			}
		}
	}

	public override FilterListItem GetFilterField(object value, IPropertyMetadata propMd, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_003d, IL_0060, IL_006f, IL_00fc, IL_0134, IL_0143
		FilterListItem result = default(FilterListItem);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				int num;
				if (!(value is bool))
				{
					num = 2;
					goto IL_0041;
				}
				goto IL_0097;
				IL_0041:
				while (true)
				{
					switch (num)
					{
					default:
						return result;
					case 0:
						return result;
					case 1:
						return result;
					case 2:
						result = null;
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
						{
							num = 0;
						}
						continue;
					case 3:
						break;
					}
					break;
				}
				goto IL_0097;
				IL_0097:
				result = new FilterListItem(ValueFieldName(propMd), new List<object> { ii5bvYGvBNTSmuHZ3WRS(value.ToString()) }, FilterListItemType.Must, FullTextFieldType.String);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num = 0;
				}
				goto IL_0041;
			}
			catch (Exception)
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						return result;
					}
					result = null;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
				}
			}
		}
	}

	public override SortListItem GetSortField(IPropertyMetadata propMd)
	{
		return new SortListItem(ValueFieldName(propMd), FullTextFieldType.String);
	}

	public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
	{
		//Discarded unreachable code: IL_005e, IL_00de, IL_0133, IL_0142, IL_0152, IL_0161, IL_018d, IL_01de
		int num = 8;
		WebDataItem webDataItem = default(WebDataItem);
		PropertyInfo propertyCached = default(PropertyInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					if (webDataItem != null)
					{
						num2 = 3;
						continue;
					}
					return;
				case 6:
					webDataItem = value as WebDataItem;
					num = 5;
					break;
				case 7:
					if (propMd != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 2:
					return;
				default:
					propertyCached = obj.GetType().GetPropertyCached((string)GG3YGsGvWPARhLXjmG2S(propMd));
					num = 6;
					break;
				case 1:
					try
					{
						int num3;
						if (!bool.TryParse(webDataItem.Value, out var result))
						{
							num3 = 4;
							goto IL_00e2;
						}
						goto IL_0114;
						IL_00e2:
						while (true)
						{
							switch (num3)
							{
							default:
								goto IL_0100;
							case 1:
								break;
							case 2:
								return;
							case 3:
								return;
							}
							break;
							IL_0100:
							JyiOGwGvhnnGagdbUvE5(propertyCached, obj, null, null);
							num3 = 3;
						}
						goto IL_0114;
						IL_0114:
						JyiOGwGvhnnGagdbUvE5(propertyCached, obj, result, null);
						num3 = 2;
						goto IL_00e2;
					}
					catch (Exception ex)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
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
							i3duEZGvf6sHrOxh7tAv(z2kFIxGvGsqlBJQfKv9d(), HBnwH4GvEu0kbpRSriPe(0x34185E55 ^ 0x341B94BD), ex);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
							{
								num4 = 1;
							}
						}
					}
				case 8:
					if (obj == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 7;
					}
					continue;
				case 3:
					if (KPIDQrGvbuFLhRWUq0nI(OgIgrZGvoqxMY9AX70HV(webDataItem), ValueFieldName(propMd)))
					{
						num2 = 4;
						continue;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					if (!(propertyCached == null))
					{
						num = 10;
						break;
					}
					return;
				case 9:
					return;
				case 4:
					return;
				}
				break;
			}
		}
	}

	public override void SetEmptyIndexField(object obj, IPropertyMetadata propMd, string fieldName)
	{
		//Discarded unreachable code: IL_0073, IL_009e, IL_00ad, IL_0146, IL_015d, IL_016c, IL_01d1, IL_0253, IL_0262
		int num = 7;
		int num2 = num;
		object value = default(object);
		PropertyInfo propertyCached = default(PropertyInfo);
		object obj2 = default(object);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 5:
				try
				{
					int num3;
					if (LHb1FhGvCIy2F34aD0Qs(propMd as PropertyMetadata))
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num3 = 0;
						}
						goto IL_0077;
					}
					goto IL_0104;
					IL_0104:
					value = base.TypeDescriptor.SerializeSimple(null, typeof(bool));
					num3 = 2;
					goto IL_0077;
					IL_0077:
					while (true)
					{
						switch (num3)
						{
						case 3:
							return;
						case 4:
							JyiOGwGvhnnGagdbUvE5(propertyCached, obj, obj2, null);
							num3 = 5;
							continue;
						default:
							propertyCached.SetValue(obj, null, null);
							num3 = 3;
							continue;
						case 2:
							obj2 = base.TypeDescriptor.DeserializeSimple(value, hp5joSGvvDUdvErZMinB(typeof(bool).TypeHandle));
							num3 = 4;
							continue;
						case 1:
							break;
						case 5:
							return;
						}
						break;
					}
					goto IL_0104;
				}
				catch (Exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
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
			case 8:
				if (X1s6RrGvQHCNgMClqLmF(propertyCached, null))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 9:
				return;
			case 10:
				propertyCached = obj.GetType().GetPropertyCached((string)GG3YGsGvWPARhLXjmG2S(propMd));
				num2 = 8;
				continue;
			case 7:
				if (obj == null)
				{
					return;
				}
				num2 = 6;
				continue;
			case 0:
				return;
			case 2:
				return;
			case 6:
				if (propMd == null)
				{
					return;
				}
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 10;
				}
				continue;
			case 3:
				if (propMd is PropertyMetadata)
				{
					num2 = 5;
					continue;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				break;
			case 1:
				return;
			}
			if (fieldName != ValueFieldName(propMd))
			{
				break;
			}
			num2 = 3;
		}
	}

	internal static bool V4rTy7GCzjVdtW8yOI8D()
	{
		return tumMgcGCcCdPw34dXulo == null;
	}

	internal static BoolPropertyDescriptor Qf408YGvFiLepVRwIl1i()
	{
		return tumMgcGCcCdPw34dXulo;
	}

	internal static object ii5bvYGvBNTSmuHZ3WRS(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static object GG3YGsGvWPARhLXjmG2S(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static object OgIgrZGvoqxMY9AX70HV(object P_0)
	{
		return ((WebDataItem)P_0).Name;
	}

	internal static bool KPIDQrGvbuFLhRWUq0nI(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void JyiOGwGvhnnGagdbUvE5(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static object z2kFIxGvGsqlBJQfKv9d()
	{
		return Logger.Log;
	}

	internal static object HBnwH4GvEu0kbpRSriPe(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void i3duEZGvf6sHrOxh7tAv(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Warn(P_1, (Exception)P_2);
	}

	internal static bool X1s6RrGvQHCNgMClqLmF(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static bool LHb1FhGvCIy2F34aD0Qs(object P_0)
	{
		return ((PropertyMetadata)P_0).Nullable;
	}

	internal static Type hp5joSGvvDUdvErZMinB(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
